import argparse
import os
import sys

import requests


class Downloader(object):
    """

    Args:
        cookie (string): main argument to be passed
    """

    def __init__(self, cookie):
        self.cookie = cookie.strip().strip('"')
        self.download_path = os.environ.get("FILE_PATH", "./skillshare_dl")
        # the following show stay untouched
        self.pk = "BCpkADawqM2OOcM6njnM7hf9EaK6lIFlqiXB0iWjqGWUQjU7R8965xUvIQNqdQbnDTLz0IAO7E6Ir2rIbXJtFdzrGtitoee0n1XXRliD-RH9A-svuvNW9qgo3Bh34HEZjXjG4Nml4iyz3KqF".strip()
        self.brightcove_account_id = 3695997568001
        self.pythonversion = 3 if sys.version_info >= (3, 0) else 2

    def is_unicode_string(self, string):
        if self.pythonversion == 3 and isinstance(string, str):
            return True
        else:
            return False

    def slugify(self, string) -> str:
        """Takes in a string as argument and returns a slugified version of that string

        Args:
            string ([type])

        Returns:
            str
        """
        return str(string).strip().replace(" ", "-")

    def download_course_by_class_id(self, class_id):
        data = self.fetch_course_data_by_class_id(class_id=class_id)
        teacher_name = None

        if "vanity_username" in data["_embedded"]["teacher"]:
            teacher_name = data["_embedded"]["teacher"]["vanity_username"]

        if not teacher_name:
            teacher_name = data["_embedded"]["teacher"]["full_name"]

        if not teacher_name:
            raise Exception("Failed to read teacher name from data")

        if self.is_unicode_string(teacher_name):
            teacher_name = teacher_name.encode("ascii", "replace")

        title = data["title"]

        if self.is_unicode_string(title):
            title = title.encode("ascii", "replace")  # ignore any weird char

        base_path = os.path.abspath(
            os.path.join(
                self.download_path,
                self.slugify(teacher_name),
                self.slugify(title),
            )
        ).rstrip("/")

        if not os.path.exists(base_path):
            os.makedirs(base_path)

        for u in data["_embedded"]["units"]["_embedded"]["units"]:
            for s in u["_embedded"]["sessions"]["_embedded"]["sessions"]:
                video_id = None

                if "video_hashed_id" in s and s["video_hashed_id"]:
                    video_id = s["video_hashed_id"].split(":")[1]

                if not video_id:
                    # NOTE: this happens sometimes...
                    # seems random and temporary but might be some random
                    # server-side check on user-agent etc?
                    # ...think it's more stable now with those set to
                    # emulate an android device
                    raise Exception("Failed to read video ID from data")

                s_title = s["title"]

                if self.is_unicode_string(s_title):
                    s_title = s_title.encode(
                        "ascii", "replace"
                    )  # ignore any weird char

                file_name = "{} - {}".format(
                    str(s["index"] + 1).zfill(2),
                    self.slugify(s_title),
                )

                self.download_video(
                    fpath="{base_path}/{session}.mp4".format(
                        base_path=base_path,
                        session=file_name,
                    ),
                    video_id=video_id,
                )

                print("")

    def fetch_course_data_by_class_id(self, class_id):
        res = requests.get(
            url="https://api.skillshare.com/classes/{}".format(class_id),
            headers={
                "Accept": "application/vnd.skillshare.class+json;,version=0.8",
                "User-Agent": "Skillshare/5.3.0; Android 9.0.1",
                "Host": "api.skillshare.com",
                "Referer": "https://www.skillshare.com/",
                "cookie": self.cookie,
            },
        )

        if not res.status_code == 200:
            raise Exception("Fetch error, code == {}".format(res.status_code))

        return res.json()

    def download_video(self, fpath, video_id):
        meta_url = "https://edge.api.brightcove.com/playback/v1/accounts/{account_id}/videos/{video_id}".format(
            account_id=self.brightcove_account_id,
            video_id=video_id,
        )

        meta_res = requests.get(
            meta_url,
            headers={
                "Accept": "application/json;pk={}".format(self.pk),
                "User-Agent": "Mozilla/5.0 (X11; Linux x86_64; rv:52.0) Gecko/20100101 Firefox/52.0",
                "Origin": "https://www.skillshare.com",
            },
        )

        if meta_res.status_code != 200:
            raise Exception("Failed to fetch video meta")

        for x in meta_res.json()["sources"]:
            if "container" in x:
                if x["container"] == "MP4" and "src" in x:
                    dl_url = x["src"]
                    break

        print("Downloading {}...".format(fpath))

        if os.path.exists(fpath):
            print("Video already downloaded, skipping...")
            return

        with open(fpath, "wb") as f:
            response = requests.get(dl_url, allow_redirects=True, stream=True)
            total_length = response.headers.get("content-length")

            if not total_length:
                f.write(response.content)

            else:
                dl = 0
                total_length = int(total_length)

                for data in response.iter_content(chunk_size=4096):
                    dl += len(data)
                    f.write(data)
                    done = int(50 * dl / total_length)
                    sys.stdout.write("\r[%s%s]" % ("=" * done, " " * (50 - done)))
                    sys.stdout.flush()

            print("")


# arguments, because it makes it simpler to use
# create an ArgumentParser object
parser = argparse.ArgumentParser(
    description="Download skillshare courses for **personal** and **non-commercial** use!"
)

# from the two first arguments, in my case, one has to be entered, the other one is not necessary
# create an argument to take
parser.add_argument(
    "-c",
    "--cookie",
    type=str,
    metavar="",
    required=True,
    help="cookie got from document.cookie",
)
parser.add_argument(
    "-i",
    "--courseId",
    type=str,
    metavar="",
    required=True,
    help="id of the course",
)


# put all the arguments in one value for later use
arguments = parser.parse_args()

dl = Downloader(cookie=arguments.cookie)
dl.download_course_by_class_id(arguments.courseId)

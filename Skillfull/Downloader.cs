using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;

namespace Skillfull
{
    class Downloader
    {
        public string session_cookie, course_id, download_path, pk;
        public long brightcove_account_id;

        public Downloader(string cookie, string courseId)
        {
            session_cookie = cookie.Trim().Replace("\"", "");
            course_id = courseId.Trim();
            pk = "BCpkADawqM2OOcM6njnM7hf9EaK6lIFlqiXB0iWjqGWUQjU7R8965xUvIQNqdQbnDTLz0IAO7E6Ir2rIbXJtFdzrGtitoee0n1XXRliD-RH9A-svuvNW9qgo3Bh34HEZjXjG4Nml4iyz3KqF".Trim();
            brightcove_account_id = 3695997568001;
            download_path = Path.Combine("C:\\Users\\", Environment.UserName, "Videos", "Skillfull_DL");
        }

        public bool isUnicode(string input_string)
        {
            if (input_string.IsNormalized())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string slugify(string input_string)
        {
            return input_string.Trim().Replace(" ", "-");
        }

        async public Task<object> fetcCourseData()
        {
            HttpClient ht = new HttpClient();
            ht.DefaultRequestHeaders.Add("Accept", "application/vnd.skillshare.class+json;,version=0.8");
            ht.DefaultRequestHeaders.Add("User-Agent", "Skillshare/5.3.0; Android 9.0.1");
            ht.DefaultRequestHeaders.Add("Host", "api.skillshare.com");
            ht.DefaultRequestHeaders.Add("Referer", "https://www.skillshare.com/");
            ht.DefaultRequestHeaders.Add("cookie", session_cookie);
            HttpResponseMessage res = await ht.GetAsync($"https://api.skillshare.com/classes/{course_id}");

            if (res.StatusCode != HttpStatusCode.OK)
            {
                throw new HttpRequestException($"Fetch Error => {res.StatusCode}");
            }

            MessageBox.Show(JsonSerializer.Serialize(res.Content));

            return JsonSerializer.Serialize(res.Content);
        }

        public void downloadCourse()
        {
            dynamic data = fetcCourseData();
            string teacher_name = "";

            string temp_teacher_name = data["_embedded"]["teacher"];

            if (temp_teacher_name.Contains("vanity_username"))
            {
                teacher_name = data["_embedded"]["teacher"]["vanity_username"];
            }

            if (String.IsNullOrEmpty(teacher_name))
            {
                teacher_name = data["_embedded"]["teacher"]["full_name"];
            }

            if (String.IsNullOrEmpty(teacher_name))
            {
                throw new Exception("Teacher name is empty, what now?");
            }

            //if self.is_unicode_string(teacher_name):
            //    teacher_name = teacher_name.encode("ascii", "replace")

            string title = data["title"];

            string dl_path = Path.Combine(download_path, slugify(teacher_name), slugify(title));

            if (!Directory.Exists(dl_path))
            {
                Directory.CreateDirectory(dl_path);
            }

            foreach (var u in data["_embedded"]["units"]["_embedded"]["units"])
            {
                foreach (var s in u["_embedded"]["sessions"]["_embedded"]["sessions"])
                {
                    string video_id = String.Empty;

                    if (s.Contains("video_hashed_id") && s["video_hashed_id"])
                    {
                        video_id = s["video_hashed_id"].Split(":")[1];
                    }

                    string s_title = s["title"];

                    string file_name = slugify(s_title);
                    string fPath = Path.Combine(dl_path, file_name + ".mp4");

                    downloadVideo(video_id, fPath);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="fPath"></param>
        /// 
        /// My dudes, any help would be much appreciated

        async public void downloadVideo(string videoId, string fPath)
        {
            HttpClient ht = new HttpClient();
            ht.DefaultRequestHeaders.Add("Accept", $"application/json;pk={pk}");
            ht.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (X11; Linux x86_64; rv:52.0) Gecko/20100101 Firefox/52.0");
            ht.DefaultRequestHeaders.Add("Origin", "https://www.skillshare.com");

            HttpResponseMessage res = await ht.GetAsync($"https://edge.api.brightcove.com/playback/v1/accounts/{brightcove_account_id}/videos/{videoId}");

            if (res.StatusCode != HttpStatusCode.OK)
            {
                throw new HttpRequestException($"Fetch Error => {res.StatusCode}");
            }

            string jRes = JsonSerializer.Serialize(res.Content);

            foreach (var x in jRes)
            {

            }

            //for x in meta_res.json()["sources"]:
            //    if "container" in x:
            //        if x["container"] == "MP4" and "src" in x:
            //            dl_url = x["src"]   
            //                    break
        }

    }
}

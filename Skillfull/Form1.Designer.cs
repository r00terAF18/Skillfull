
namespace Skillfull
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cookieTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.urlTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnDownload = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCopyCode = new MaterialSkin.Controls.MaterialRaisedButton();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(307, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Step 1: Paste this in your browsers console: ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(325, 9);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(128, 21);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "document.cookie";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 46);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(268, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Step 2: Copy and Paste the output here";
            // 
            // cookieTxt
            // 
            this.cookieTxt.Depth = 0;
            this.cookieTxt.Hint = "with or without \"";
            this.cookieTxt.Location = new System.Drawing.Point(325, 46);
            this.cookieTxt.MaxLength = 2000000;
            this.cookieTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.cookieTxt.Name = "cookieTxt";
            this.cookieTxt.PasswordChar = '\0';
            this.cookieTxt.SelectedText = "";
            this.cookieTxt.SelectionLength = 0;
            this.cookieTxt.SelectionStart = 0;
            this.cookieTxt.Size = new System.Drawing.Size(244, 23);
            this.cookieTxt.TabIndex = 2;
            this.cookieTxt.TabStop = false;
            this.cookieTxt.UseSystemPasswordChar = false;
            this.cookieTxt.TextChanged += new System.EventHandler(this.cookieTxt_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLbl});
            this.statusStrip.Location = new System.Drawing.Point(0, 179);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(584, 22);
            this.statusStrip.TabIndex = 5;
            // 
            // statusStripLbl
            // 
            this.statusStripLbl.ActiveLinkColor = System.Drawing.Color.Salmon;
            this.statusStripLbl.Name = "statusStripLbl";
            this.statusStripLbl.Size = new System.Drawing.Size(569, 17);
            this.statusStripLbl.Spring = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 84);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(296, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Step 3: Copy and paste course URL/ID here";
            // 
            // urlTxt
            // 
            this.urlTxt.Depth = 0;
            this.urlTxt.Hint = "URL or ID";
            this.urlTxt.Location = new System.Drawing.Point(325, 84);
            this.urlTxt.MaxLength = 2000000;
            this.urlTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.urlTxt.Name = "urlTxt";
            this.urlTxt.PasswordChar = '\0';
            this.urlTxt.SelectedText = "";
            this.urlTxt.SelectionLength = 0;
            this.urlTxt.SelectionStart = 0;
            this.urlTxt.Size = new System.Drawing.Size(244, 23);
            this.urlTxt.TabIndex = 3;
            this.urlTxt.TabStop = false;
            this.urlTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 129);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(166, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Step 4: Start Download!";
            // 
            // btnDownload
            // 
            this.btnDownload.AutoSize = true;
            this.btnDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownload.Depth = 0;
            this.btnDownload.Icon = null;
            this.btnDownload.Location = new System.Drawing.Point(477, 129);
            this.btnDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Primary = true;
            this.btnDownload.Size = new System.Drawing.Size(96, 36);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnCopyCode
            // 
            this.btnCopyCode.AutoSize = true;
            this.btnCopyCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopyCode.Depth = 0;
            this.btnCopyCode.Icon = null;
            this.btnCopyCode.Location = new System.Drawing.Point(477, 4);
            this.btnCopyCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCopyCode.Name = "btnCopyCode";
            this.btnCopyCode.Primary = true;
            this.btnCopyCode.Size = new System.Drawing.Size(95, 36);
            this.btnCopyCode.TabIndex = 1;
            this.btnCopyCode.Text = "Copy Code";
            this.btnCopyCode.UseVisualStyleBackColor = true;
            this.btnCopyCode.Click += new System.EventHandler(this.btnCopyCode_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 201);
            this.Controls.Add(this.btnCopyCode);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.urlTxt);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.cookieTxt);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 240);
            this.MinimumSize = new System.Drawing.Size(600, 240);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skillfull";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField cookieTxt;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLbl;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField urlTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton btnDownload;
        private MaterialSkin.Controls.MaterialRaisedButton btnCopyCode;
    }
}


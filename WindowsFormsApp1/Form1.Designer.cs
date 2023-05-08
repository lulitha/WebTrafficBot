namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listUrls = new System.Windows.Forms.ListBox();
            this.listProxy = new System.Windows.Forms.ListBox();
            this.listUA = new System.Windows.Forms.ListBox();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnAddUrls = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAddProxy = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAddUA = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblUrl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblProxy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUA = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.progressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // listUrls
            // 
            this.listUrls.FormattingEnabled = true;
            this.listUrls.Location = new System.Drawing.Point(12, 12);
            this.listUrls.Name = "listUrls";
            this.listUrls.Size = new System.Drawing.Size(234, 95);
            this.listUrls.TabIndex = 0;
            // 
            // listProxy
            // 
            this.listProxy.FormattingEnabled = true;
            this.listProxy.Location = new System.Drawing.Point(12, 113);
            this.listProxy.Name = "listProxy";
            this.listProxy.Size = new System.Drawing.Size(234, 95);
            this.listProxy.TabIndex = 0;
            // 
            // listUA
            // 
            this.listUA.FormattingEnabled = true;
            this.listUA.Location = new System.Drawing.Point(12, 214);
            this.listUA.Name = "listUA";
            this.listUA.Size = new System.Drawing.Size(234, 95);
            this.listUA.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BorderRadius = 20;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(496, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(180, 45);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(349, 230);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(725, 250);
            this.webBrowser1.TabIndex = 2;
            // 
            // btnAddUrls
            // 
            this.btnAddUrls.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUrls.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUrls.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddUrls.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddUrls.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnAddUrls.ForeColor = System.Drawing.Color.White;
            this.btnAddUrls.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUrls.Image")));
            this.btnAddUrls.Location = new System.Drawing.Point(252, 12);
            this.btnAddUrls.Name = "btnAddUrls";
            this.btnAddUrls.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddUrls.Size = new System.Drawing.Size(36, 36);
            this.btnAddUrls.TabIndex = 3;
            this.btnAddUrls.Click += new System.EventHandler(this.btnAddUrls_Click);
            // 
            // btnAddProxy
            // 
            this.btnAddProxy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProxy.BackgroundImage")));
            this.btnAddProxy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProxy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProxy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProxy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddProxy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddProxy.ForeColor = System.Drawing.Color.White;
            this.btnAddProxy.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProxy.Image")));
            this.btnAddProxy.Location = new System.Drawing.Point(252, 113);
            this.btnAddProxy.Name = "btnAddProxy";
            this.btnAddProxy.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddProxy.Size = new System.Drawing.Size(36, 36);
            this.btnAddProxy.TabIndex = 3;
            this.btnAddProxy.Click += new System.EventHandler(this.btnAddProxy_Click);
            // 
            // btnAddUA
            // 
            this.btnAddUA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddUA.BackgroundImage")));
            this.btnAddUA.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddUA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddUA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddUA.ForeColor = System.Drawing.Color.White;
            this.btnAddUA.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUA.Image")));
            this.btnAddUA.Location = new System.Drawing.Point(252, 214);
            this.btnAddUA.Name = "btnAddUA";
            this.btnAddUA.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddUA.Size = new System.Drawing.Size(36, 36);
            this.btnAddUA.TabIndex = 3;
            this.btnAddUA.Click += new System.EventHandler(this.btnAddUA_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.BackColor = System.Drawing.Color.Transparent;
            this.lblUrl.Location = new System.Drawing.Point(693, 13);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(23, 15);
            this.lblUrl.TabIndex = 4;
            this.lblUrl.Text = "*****";
            // 
            // lblProxy
            // 
            this.lblProxy.BackColor = System.Drawing.Color.Transparent;
            this.lblProxy.Location = new System.Drawing.Point(693, 28);
            this.lblProxy.Name = "lblProxy";
            this.lblProxy.Size = new System.Drawing.Size(23, 15);
            this.lblProxy.TabIndex = 4;
            this.lblProxy.Text = "*****";
            // 
            // lblUA
            // 
            this.lblUA.BackColor = System.Drawing.Color.Transparent;
            this.lblUA.Location = new System.Drawing.Point(693, 43);
            this.lblUA.Name = "lblUA";
            this.lblUA.Size = new System.Drawing.Size(23, 15);
            this.lblUA.TabIndex = 4;
            this.lblUA.Text = "*****";
            // 
            // progressBar1
            // 
            this.progressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.progressBar1.FillThickness = 20;
            this.progressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progressBar1.ForeColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(349, -1);
            this.progressBar1.Minimum = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressThickness = 15;
            this.progressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBar1.Size = new System.Drawing.Size(130, 130);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Text = "guna2CircleProgressBar1";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.BackgroundImage")));
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.Location = new System.Drawing.Point(252, 155);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(36, 36);
            this.guna2CircleButton1.TabIndex = 3;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 492);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblUA);
            this.Controls.Add(this.lblProxy);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.btnAddUA);
            this.Controls.Add(this.btnAddProxy);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.btnAddUrls);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.listUA);
            this.Controls.Add(this.listProxy);
            this.Controls.Add(this.listUrls);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUrls;
        private System.Windows.Forms.ListBox listProxy;
        private System.Windows.Forms.ListBox listUA;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddUrls;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddProxy;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddUA;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUrl;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProxy;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUA;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressBar1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}


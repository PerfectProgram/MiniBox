namespace Mini_Box
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_yuru = new System.Windows.Forms.ToolStripMenuItem();
            this.soruSorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.ShowPopup = new System.Windows.Forms.NotifyIcon(this.components);
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_yuru,
            this.soruSorToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 92);
            this.contextMenuStrip1.Text = "Masaüstü Faresi";
            // 
            // cms_yuru
            // 
            this.cms_yuru.CheckOnClick = true;
            this.cms_yuru.Image = ((System.Drawing.Image)(resources.GetObject("cms_yuru.Image")));
            this.cms_yuru.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cms_yuru.Name = "cms_yuru";
            this.cms_yuru.Size = new System.Drawing.Size(177, 22);
            this.cms_yuru.Text = "Masaüstümde Yürü";
            this.cms_yuru.CheckedChanged += new System.EventHandler(this.cms_yuru_CheckedChanged);
            // 
            // soruSorToolStripMenuItem
            // 
            this.soruSorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("soruSorToolStripMenuItem.Image")));
            this.soruSorToolStripMenuItem.Name = "soruSorToolStripMenuItem";
            this.soruSorToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.soruSorToolStripMenuItem.Text = "Soru sor...";
            this.soruSorToolStripMenuItem.Click += new System.EventHandler(this.soruSorToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 20;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // ShowPopup
            // 
            this.ShowPopup.ContextMenuStrip = this.contextMenuStrip1;
            this.ShowPopup.Icon = ((System.Drawing.Icon)(resources.GetObject("ShowPopup.Icon")));
            this.ShowPopup.Text = "Mini Box";
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "SagaDurus.png");
            this.ımageCollection1.Images.SetKeyName(1, "SagYurume1.png");
            this.ımageCollection1.Images.SetKeyName(2, "SagYurume2.png");
            this.ımageCollection1.Images.SetKeyName(3, "SagYurume3.png");
            this.ımageCollection1.Images.SetKeyName(4, "SagYurume4.png");
            this.ımageCollection1.Images.SetKeyName(5, "SagYurume5.png");
            this.ımageCollection1.Images.SetKeyName(6, "SagYurume6.png");
            this.ımageCollection1.Images.SetKeyName(7, "SolaDurus.png");
            this.ımageCollection1.Images.SetKeyName(8, "SolYurume1.png");
            this.ımageCollection1.Images.SetKeyName(9, "SolYurume2.png");
            this.ımageCollection1.Images.SetKeyName(10, "SolYurume3.png");
            this.ımageCollection1.Images.SetKeyName(11, "SolYurume4.png");
            this.ımageCollection1.Images.SetKeyName(12, "SolYurume5.png");
            this.ımageCollection1.Images.SetKeyName(13, "SolYurume6.png");
            // 
            // timer4
            // 
            this.timer4.Interval = 200;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.BackColor2 = System.Drawing.Color.White;
            this.Appearance.BorderColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(32, 32);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(32, 32);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cms_yuru;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.NotifyIcon ShowPopup;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.ToolStripMenuItem soruSorToolStripMenuItem;
    }
}
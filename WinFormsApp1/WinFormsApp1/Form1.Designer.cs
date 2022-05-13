namespace WinFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.biçimleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.yeniToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.açToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.kaydetToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.yazdırToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.kesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.kopyalaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.yapıştırToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yardımToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.biçimleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.richTextBox1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(787, 401);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(787, 456);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(787, 401);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.düzenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.açToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.çıkışToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 24);
            this.toolStripMenuItem1.Text = "Dosya";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yeniToolStripMenuItem.Text = "Yeni";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.açToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.çıkışToolStripMenuItem.Text = "Kaydet";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem1
            // 
            this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            this.çıkışToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.çıkışToolStripMenuItem1.Text = "Çıkış";
            this.çıkışToolStripMenuItem1.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.toolStripMenuItem2,
            this.biçimleToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 6);
            // 
            // biçimleToolStripMenuItem
            // 
            this.biçimleToolStripMenuItem.Name = "biçimleToolStripMenuItem";
            this.biçimleToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.biçimleToolStripMenuItem.Text = "Biçimle";
            this.biçimleToolStripMenuItem.Click += new System.EventHandler(this.biçimleToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripButton,
            this.açToolStripButton,
            this.kaydetToolStripButton,
            this.yazdırToolStripButton,
            this.toolStripSeparator,
            this.kesToolStripButton,
            this.kopyalaToolStripButton,
            this.yapıştırToolStripButton,
            this.toolStripSeparator1,
            this.yardımToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(4, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(257, 27);
            this.toolStrip1.TabIndex = 1;
            // 
            // yeniToolStripButton
            // 
            this.yeniToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yeniToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("yeniToolStripButton.Image")));
            this.yeniToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yeniToolStripButton.Name = "yeniToolStripButton";
            this.yeniToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.yeniToolStripButton.Text = "Yeni";
            this.yeniToolStripButton.ToolTipText = "Yeni Dosya Aç";
            this.yeniToolStripButton.Click += new System.EventHandler(this.yeniToolStripButton_Click);
            // 
            // açToolStripButton
            // 
            this.açToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.açToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("açToolStripButton.Image")));
            this.açToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.açToolStripButton.Name = "açToolStripButton";
            this.açToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.açToolStripButton.Text = "Aç";
            this.açToolStripButton.ToolTipText = "Dosya Aç";
            this.açToolStripButton.Click += new System.EventHandler(this.açToolStripButton_Click);
            // 
            // kaydetToolStripButton
            // 
            this.kaydetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kaydetToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("kaydetToolStripButton.Image")));
            this.kaydetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kaydetToolStripButton.Name = "kaydetToolStripButton";
            this.kaydetToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.kaydetToolStripButton.Text = "Kaydet";
            this.kaydetToolStripButton.Click += new System.EventHandler(this.kaydetToolStripButton_Click);
            // 
            // yazdırToolStripButton
            // 
            this.yazdırToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yazdırToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("yazdırToolStripButton.Image")));
            this.yazdırToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yazdırToolStripButton.Name = "yazdırToolStripButton";
            this.yazdırToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.yazdırToolStripButton.Text = "&Yazdır";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // kesToolStripButton
            // 
            this.kesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("kesToolStripButton.Image")));
            this.kesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kesToolStripButton.Name = "kesToolStripButton";
            this.kesToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.kesToolStripButton.Text = "&Kes";
            // 
            // kopyalaToolStripButton
            // 
            this.kopyalaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kopyalaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("kopyalaToolStripButton.Image")));
            this.kopyalaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kopyalaToolStripButton.Name = "kopyalaToolStripButton";
            this.kopyalaToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.kopyalaToolStripButton.Text = "K&opyala";
            // 
            // yapıştırToolStripButton
            // 
            this.yapıştırToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yapıştırToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("yapıştırToolStripButton.Image")));
            this.yapıştırToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yapıştırToolStripButton.Name = "yapıştırToolStripButton";
            this.yapıştırToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.yapıştırToolStripButton.Text = "&Yapıştır";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // yardımToolStripButton
            // 
            this.yardımToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yardımToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("yardımToolStripButton.Image")));
            this.yardımToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yardımToolStripButton.Name = "yardımToolStripButton";
            this.yardımToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.yardımToolStripButton.Text = "&Yardım";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem1,
            this.kopyalaToolStripMenuItem1,
            this.yapıştırToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.biçimleToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 106);
            // 
            // kesToolStripMenuItem1
            // 
            this.kesToolStripMenuItem1.Name = "kesToolStripMenuItem1";
            this.kesToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.kesToolStripMenuItem1.Text = "Kes";
            this.kesToolStripMenuItem1.Click += new System.EventHandler(this.kesToolStripMenuItem1_Click);
            // 
            // kopyalaToolStripMenuItem1
            // 
            this.kopyalaToolStripMenuItem1.Name = "kopyalaToolStripMenuItem1";
            this.kopyalaToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.kopyalaToolStripMenuItem1.Text = "Kopyala";
            this.kopyalaToolStripMenuItem1.Click += new System.EventHandler(this.kopyalaToolStripMenuItem1_Click);
            // 
            // yapıştırToolStripMenuItem1
            // 
            this.yapıştırToolStripMenuItem1.Name = "yapıştırToolStripMenuItem1";
            this.yapıştırToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.yapıştırToolStripMenuItem1.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem1.Click += new System.EventHandler(this.yapıştırToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(129, 6);
            // 
            // biçimleToolStripMenuItem1
            // 
            this.biçimleToolStripMenuItem1.Name = "biçimleToolStripMenuItem1";
            this.biçimleToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.biçimleToolStripMenuItem1.Text = "Biçimle";
            this.biçimleToolStripMenuItem1.Click += new System.EventHandler(this.biçimleToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 456);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotePad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton yeniToolStripButton;
        private ToolStripButton açToolStripButton;
        private ToolStripButton kaydetToolStripButton;
        private ToolStripButton yazdırToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton kesToolStripButton;
        private ToolStripButton kopyalaToolStripButton;
        private ToolStripButton yapıştırToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton yardımToolStripButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem yeniToolStripMenuItem;
        private ToolStripMenuItem açToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem1;
        private ToolStripMenuItem düzenToolStripMenuItem;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem kopyalaToolStripMenuItem;
        private ToolStripMenuItem yapıştırToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem biçimleToolStripMenuItem;
        private FontDialog fontDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem kesToolStripMenuItem1;
        private ToolStripMenuItem kopyalaToolStripMenuItem1;
        private ToolStripMenuItem yapıştırToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem biçimleToolStripMenuItem1;
    }
}
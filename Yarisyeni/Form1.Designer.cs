
namespace Yarisyeni
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FontR = new System.Windows.Forms.Button();
            this.btnPanelC = new System.Windows.Forms.Button();
            this.ButtonFormD = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TmBasla = new System.Windows.Forms.Timer(this.components);
            this.TmBitir = new System.Windows.Forms.Timer(this.components);
            this.ClDiaFon = new System.Windows.Forms.ColorDialog();
            this.ClDiaPanel = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yerDeğiştirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yarışlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriYarışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 206);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox1.Location = new System.Drawing.Point(99, 393);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seviye";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Basla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.FontR);
            this.panel1.Controls.Add(this.btnPanelC);
            this.panel1.Controls.Add(this.ButtonFormD);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(713, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 448);
            this.panel1.TabIndex = 6;
            // 
            // FontR
            // 
            this.FontR.Location = new System.Drawing.Point(-3, 153);
            this.FontR.Name = "FontR";
            this.FontR.Size = new System.Drawing.Size(87, 23);
            this.FontR.TabIndex = 10;
            this.FontR.Text = "Font ";
            this.FontR.UseVisualStyleBackColor = true;
            this.FontR.Click += new System.EventHandler(this.Font_Click);
            // 
            // btnPanelC
            // 
            this.btnPanelC.Location = new System.Drawing.Point(-3, 124);
            this.btnPanelC.Name = "btnPanelC";
            this.btnPanelC.Size = new System.Drawing.Size(87, 23);
            this.btnPanelC.TabIndex = 9;
            this.btnPanelC.Text = "Panel Renk";
            this.btnPanelC.UseVisualStyleBackColor = true;
            this.btnPanelC.Click += new System.EventHandler(this.btnPanelC_Click);
            // 
            // ButtonFormD
            // 
            this.ButtonFormD.Location = new System.Drawing.Point(-3, 95);
            this.ButtonFormD.Name = "ButtonFormD";
            this.ButtonFormD.Size = new System.Drawing.Size(87, 23);
            this.ButtonFormD.TabIndex = 8;
            this.ButtonFormD.Text = "Fon Renk";
            this.ButtonFormD.UseVisualStyleBackColor = true;
            this.ButtonFormD.Click += new System.EventHandler(this.ButtonFormD_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "YerD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TmBasla
            // 
            this.TmBasla.Tick += new System.EventHandler(this.TmBasla_Tick);
            // 
            // TmBitir
            // 
            this.TmBitir.Tick += new System.EventHandler(this.TmBitir_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem,
            this.yarışlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formRengiToolStripMenuItem,
            this.panelRengiToolStripMenuItem,
            this.yerDeğiştirmeToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // formRengiToolStripMenuItem
            // 
            this.formRengiToolStripMenuItem.Name = "formRengiToolStripMenuItem";
            this.formRengiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formRengiToolStripMenuItem.Text = "Form Rengi";
            this.formRengiToolStripMenuItem.Click += new System.EventHandler(this.formRengiToolStripMenuItem_Click);
            // 
            // panelRengiToolStripMenuItem
            // 
            this.panelRengiToolStripMenuItem.Name = "panelRengiToolStripMenuItem";
            this.panelRengiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.panelRengiToolStripMenuItem.Text = "Panel Rengi";
            this.panelRengiToolStripMenuItem.Click += new System.EventHandler(this.panelRengiToolStripMenuItem_Click);
            // 
            // yerDeğiştirmeToolStripMenuItem
            // 
            this.yerDeğiştirmeToolStripMenuItem.Name = "yerDeğiştirmeToolStripMenuItem";
            this.yerDeğiştirmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yerDeğiştirmeToolStripMenuItem.Text = "Yer Değiştirme";
            // 
            // yarışlarToolStripMenuItem
            // 
            this.yarışlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ileriToolStripMenuItem,
            this.geriYarışToolStripMenuItem});
            this.yarışlarToolStripMenuItem.Name = "yarışlarToolStripMenuItem";
            this.yarışlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yarışlarToolStripMenuItem.Text = "Yarışlar";
            // 
            // ileriToolStripMenuItem
            // 
            this.ileriToolStripMenuItem.Name = "ileriToolStripMenuItem";
            this.ileriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ileriToolStripMenuItem.Text = "İleri Yarış";
            this.ileriToolStripMenuItem.Click += new System.EventHandler(this.ileriToolStripMenuItem_Click);
            // 
            // geriYarışToolStripMenuItem
            // 
            this.geriYarışToolStripMenuItem.Name = "geriYarışToolStripMenuItem";
            this.geriYarışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.geriYarışToolStripMenuItem.Text = "GeriYarış";
            this.geriYarışToolStripMenuItem.Click += new System.EventHandler(this.geriYarışToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Fon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer TmBasla;
        private System.Windows.Forms.Timer TmBitir;
        private System.Windows.Forms.Button ButtonFormD;
        private System.Windows.Forms.ColorDialog ClDiaFon;
        private System.Windows.Forms.Button btnPanelC;
        private System.Windows.Forms.ColorDialog ClDiaPanel;
        private System.Windows.Forms.Button FontR;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yerDeğiştirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yarışlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriYarışToolStripMenuItem;
    }
}


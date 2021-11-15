
namespace OnlyTwo
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SendFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PlainTextGroupBox = new System.Windows.Forms.GroupBox();
            this.PlainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.Warning = new System.Windows.Forms.Label();
            this.FindLabel = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DeleteButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AddFileButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CipherTextGroupBox = new System.Windows.Forms.GroupBox();
            this.CipherTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.SPNRadioButton = new System.Windows.Forms.RadioButton();
            this.SHARadioButton = new System.Windows.Forms.RadioButton();
            this.EncryptionGroupBox = new System.Windows.Forms.GroupBox();
            this.SolveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EncryptButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.KeygenTextBox = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.LogoName = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.FindWordsGroupBox = new System.Windows.Forms.GroupBox();
            this.PlainTextGroupBox.SuspendLayout();
            this.CipherTextGroupBox.SuspendLayout();
            this.EncryptionGroupBox.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.FindWordsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendFlatButton
            // 
            this.SendFlatButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.SendFlatButton.BackColor = System.Drawing.Color.Black;
            this.SendFlatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SendFlatButton.BorderRadius = 0;
            this.SendFlatButton.ButtonText = "Send";
            this.SendFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendFlatButton.DisabledColor = System.Drawing.Color.Gray;
            this.SendFlatButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SendFlatButton.Iconimage = null;
            this.SendFlatButton.Iconimage_right = null;
            this.SendFlatButton.Iconimage_right_Selected = null;
            this.SendFlatButton.Iconimage_Selected = null;
            this.SendFlatButton.IconMarginLeft = 0;
            this.SendFlatButton.IconMarginRight = 0;
            this.SendFlatButton.IconRightVisible = true;
            this.SendFlatButton.IconRightZoom = 0D;
            this.SendFlatButton.IconVisible = true;
            this.SendFlatButton.IconZoom = 90D;
            this.SendFlatButton.IsTab = false;
            this.SendFlatButton.Location = new System.Drawing.Point(12, 472);
            this.SendFlatButton.Name = "SendFlatButton";
            this.SendFlatButton.Normalcolor = System.Drawing.Color.Black;
            this.SendFlatButton.OnHovercolor = System.Drawing.Color.Red;
            this.SendFlatButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SendFlatButton.selected = false;
            this.SendFlatButton.Size = new System.Drawing.Size(677, 33);
            this.SendFlatButton.TabIndex = 2;
            this.SendFlatButton.Text = "Send";
            this.SendFlatButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SendFlatButton.Textcolor = System.Drawing.Color.White;
            this.SendFlatButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PlainTextGroupBox
            // 
            this.PlainTextGroupBox.Controls.Add(this.PlainRichTextBox);
            this.PlainTextGroupBox.Location = new System.Drawing.Point(12, 56);
            this.PlainTextGroupBox.Name = "PlainTextGroupBox";
            this.PlainTextGroupBox.Size = new System.Drawing.Size(677, 202);
            this.PlainTextGroupBox.TabIndex = 3;
            this.PlainTextGroupBox.TabStop = false;
            this.PlainTextGroupBox.Text = "Plain Text";
            // 
            // PlainRichTextBox
            // 
            this.PlainRichTextBox.Location = new System.Drawing.Point(6, 19);
            this.PlainRichTextBox.Name = "PlainRichTextBox";
            this.PlainRichTextBox.Size = new System.Drawing.Size(662, 176);
            this.PlainRichTextBox.TabIndex = 5;
            this.PlainRichTextBox.Text = "";
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.BackColor = System.Drawing.Color.Transparent;
            this.Warning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Warning.Location = new System.Drawing.Point(1, 65);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(172, 13);
            this.Warning.TabIndex = 6;
            this.Warning.Text = "Warning: Makes all text lowercase.";
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.BackColor = System.Drawing.Color.Transparent;
            this.FindLabel.ForeColor = System.Drawing.Color.White;
            this.FindLabel.Location = new System.Drawing.Point(6, 22);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(71, 13);
            this.FindLabel.TabIndex = 4;
            this.FindLabel.Text = "Find Keyword";
            // 
            // FindTextBox
            // 
            this.FindTextBox.BackColor = System.Drawing.Color.White;
            this.FindTextBox.Location = new System.Drawing.Point(5, 38);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(164, 20);
            this.FindTextBox.TabIndex = 1;
            // 
            // FindButton
            // 
            this.FindButton.Activecolor = System.Drawing.Color.Transparent;
            this.FindButton.BackColor = System.Drawing.Color.Transparent;
            this.FindButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindButton.BorderRadius = 3;
            this.FindButton.ButtonText = "  Find";
            this.FindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindButton.DisabledColor = System.Drawing.Color.Gray;
            this.FindButton.Iconcolor = System.Drawing.Color.Transparent;
            this.FindButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("FindButton.Iconimage")));
            this.FindButton.Iconimage_right = null;
            this.FindButton.Iconimage_right_Selected = null;
            this.FindButton.Iconimage_Selected = null;
            this.FindButton.IconMarginLeft = 5;
            this.FindButton.IconMarginRight = 0;
            this.FindButton.IconRightVisible = true;
            this.FindButton.IconRightZoom = 120D;
            this.FindButton.IconVisible = true;
            this.FindButton.IconZoom = 85D;
            this.FindButton.IsTab = false;
            this.FindButton.Location = new System.Drawing.Point(5, 81);
            this.FindButton.Name = "FindButton";
            this.FindButton.Normalcolor = System.Drawing.Color.Transparent;
            this.FindButton.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.FindButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.FindButton.selected = false;
            this.FindButton.Size = new System.Drawing.Size(164, 35);
            this.FindButton.TabIndex = 3;
            this.FindButton.Text = "  Find";
            this.FindButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FindButton.Textcolor = System.Drawing.Color.White;
            this.FindButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Activecolor = System.Drawing.Color.Transparent;
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteButton.BorderRadius = 3;
            this.DeleteButton.ButtonText = "  Delete All Text";
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.DisabledColor = System.Drawing.Color.Gray;
            this.DeleteButton.Iconcolor = System.Drawing.Color.Transparent;
            this.DeleteButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Iconimage")));
            this.DeleteButton.Iconimage_right = null;
            this.DeleteButton.Iconimage_right_Selected = null;
            this.DeleteButton.Iconimage_Selected = null;
            this.DeleteButton.IconMarginLeft = 5;
            this.DeleteButton.IconMarginRight = 0;
            this.DeleteButton.IconRightVisible = true;
            this.DeleteButton.IconRightZoom = 0D;
            this.DeleteButton.IconVisible = true;
            this.DeleteButton.IconZoom = 85D;
            this.DeleteButton.IsTab = false;
            this.DeleteButton.Location = new System.Drawing.Point(5, 122);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Normalcolor = System.Drawing.Color.Transparent;
            this.DeleteButton.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.DeleteButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.DeleteButton.selected = false;
            this.DeleteButton.Size = new System.Drawing.Size(164, 35);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "  Delete All Text";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Textcolor = System.Drawing.Color.White;
            this.DeleteButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddFileButton
            // 
            this.AddFileButton.ActiveBorderThickness = 1;
            this.AddFileButton.ActiveCornerRadius = 20;
            this.AddFileButton.ActiveFillColor = System.Drawing.Color.Red;
            this.AddFileButton.ActiveForecolor = System.Drawing.Color.White;
            this.AddFileButton.ActiveLineColor = System.Drawing.Color.Red;
            this.AddFileButton.BackColor = System.Drawing.Color.Transparent;
            this.AddFileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFileButton.BackgroundImage")));
            this.AddFileButton.ButtonText = "Add File";
            this.AddFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFileButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFileButton.ForeColor = System.Drawing.Color.Red;
            this.AddFileButton.IdleBorderThickness = 1;
            this.AddFileButton.IdleCornerRadius = 20;
            this.AddFileButton.IdleFillColor = System.Drawing.Color.White;
            this.AddFileButton.IdleForecolor = System.Drawing.Color.Red;
            this.AddFileButton.IdleLineColor = System.Drawing.Color.Red;
            this.AddFileButton.Location = new System.Drawing.Point(7, 165);
            this.AddFileButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(161, 33);
            this.AddFileButton.TabIndex = 2;
            this.AddFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CipherTextGroupBox
            // 
            this.CipherTextGroupBox.Controls.Add(this.CipherTextBox);
            this.CipherTextGroupBox.Location = new System.Drawing.Point(12, 264);
            this.CipherTextGroupBox.Name = "CipherTextGroupBox";
            this.CipherTextGroupBox.Size = new System.Drawing.Size(677, 202);
            this.CipherTextGroupBox.TabIndex = 4;
            this.CipherTextGroupBox.TabStop = false;
            this.CipherTextGroupBox.Text = "CipherText";
            // 
            // CipherTextBox
            // 
            this.CipherTextBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.CipherTextBox.Location = new System.Drawing.Point(6, 19);
            this.CipherTextBox.Multiline = true;
            this.CipherTextBox.Name = "CipherTextBox";
            this.CipherTextBox.Size = new System.Drawing.Size(662, 177);
            this.CipherTextBox.TabIndex = 0;
            // 
            // SPNRadioButton
            // 
            this.SPNRadioButton.AutoSize = true;
            this.SPNRadioButton.Location = new System.Drawing.Point(93, 18);
            this.SPNRadioButton.Name = "SPNRadioButton";
            this.SPNRadioButton.Size = new System.Drawing.Size(62, 17);
            this.SPNRadioButton.TabIndex = 2;
            this.SPNRadioButton.TabStop = true;
            this.SPNRadioButton.Text = "SPN-16";
            this.SPNRadioButton.UseVisualStyleBackColor = true;
            // 
            // SHARadioButton
            // 
            this.SHARadioButton.AutoSize = true;
            this.SHARadioButton.Location = new System.Drawing.Point(19, 18);
            this.SHARadioButton.Name = "SHARadioButton";
            this.SHARadioButton.Size = new System.Drawing.Size(68, 17);
            this.SHARadioButton.TabIndex = 1;
            this.SHARadioButton.TabStop = true;
            this.SHARadioButton.Text = "SHA-256";
            this.SHARadioButton.UseVisualStyleBackColor = true;
            // 
            // EncryptionGroupBox
            // 
            this.EncryptionGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.EncryptionGroupBox.Controls.Add(this.SolveButton);
            this.EncryptionGroupBox.Controls.Add(this.EncryptButton);
            this.EncryptionGroupBox.Controls.Add(this.SPNRadioButton);
            this.EncryptionGroupBox.Controls.Add(this.SHARadioButton);
            this.EncryptionGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EncryptionGroupBox.Location = new System.Drawing.Point(10, 13);
            this.EncryptionGroupBox.Name = "EncryptionGroupBox";
            this.EncryptionGroupBox.Size = new System.Drawing.Size(178, 127);
            this.EncryptionGroupBox.TabIndex = 5;
            this.EncryptionGroupBox.TabStop = false;
            this.EncryptionGroupBox.Text = "Encryption Type";
            // 
            // SolveButton
            // 
            this.SolveButton.Activecolor = System.Drawing.Color.Transparent;
            this.SolveButton.BackColor = System.Drawing.Color.Transparent;
            this.SolveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SolveButton.BorderRadius = 3;
            this.SolveButton.ButtonText = "  Solve";
            this.SolveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SolveButton.DisabledColor = System.Drawing.Color.Gray;
            this.SolveButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SolveButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("SolveButton.Iconimage")));
            this.SolveButton.Iconimage_right = null;
            this.SolveButton.Iconimage_right_Selected = null;
            this.SolveButton.Iconimage_Selected = null;
            this.SolveButton.IconMarginLeft = 5;
            this.SolveButton.IconMarginRight = 0;
            this.SolveButton.IconRightVisible = true;
            this.SolveButton.IconRightZoom = 120D;
            this.SolveButton.IconVisible = true;
            this.SolveButton.IconZoom = 85D;
            this.SolveButton.IsTab = false;
            this.SolveButton.Location = new System.Drawing.Point(7, 82);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Normalcolor = System.Drawing.Color.Transparent;
            this.SolveButton.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.SolveButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.SolveButton.selected = false;
            this.SolveButton.Size = new System.Drawing.Size(164, 35);
            this.SolveButton.TabIndex = 8;
            this.SolveButton.Text = "  Solve";
            this.SolveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SolveButton.Textcolor = System.Drawing.Color.White;
            this.SolveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // EncryptButton
            // 
            this.EncryptButton.Activecolor = System.Drawing.Color.Transparent;
            this.EncryptButton.BackColor = System.Drawing.Color.Transparent;
            this.EncryptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EncryptButton.BorderRadius = 3;
            this.EncryptButton.ButtonText = " Encrypt";
            this.EncryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptButton.DisabledColor = System.Drawing.Color.Gray;
            this.EncryptButton.Iconcolor = System.Drawing.Color.Transparent;
            this.EncryptButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("EncryptButton.Iconimage")));
            this.EncryptButton.Iconimage_right = null;
            this.EncryptButton.Iconimage_right_Selected = null;
            this.EncryptButton.Iconimage_Selected = null;
            this.EncryptButton.IconMarginLeft = 5;
            this.EncryptButton.IconMarginRight = 0;
            this.EncryptButton.IconRightVisible = true;
            this.EncryptButton.IconRightZoom = 120D;
            this.EncryptButton.IconVisible = true;
            this.EncryptButton.IconZoom = 85D;
            this.EncryptButton.IsTab = false;
            this.EncryptButton.Location = new System.Drawing.Point(7, 41);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Normalcolor = System.Drawing.Color.Transparent;
            this.EncryptButton.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.EncryptButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.EncryptButton.selected = false;
            this.EncryptButton.Size = new System.Drawing.Size(164, 35);
            this.EncryptButton.TabIndex = 7;
            this.EncryptButton.Text = " Encrypt";
            this.EncryptButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EncryptButton.Textcolor = System.Drawing.Color.White;
            this.EncryptButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // KeygenTextBox
            // 
            this.KeygenTextBox.Location = new System.Drawing.Point(18, 30);
            this.KeygenTextBox.Name = "KeygenTextBox";
            this.KeygenTextBox.Size = new System.Drawing.Size(662, 20);
            this.KeygenTextBox.TabIndex = 6;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(18, 13);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(104, 13);
            this.KeyLabel.TabIndex = 7;
            this.KeyLabel.Text = "Key to the Message:";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.LogoName);
            this.bunifuGradientPanel1.Controls.Add(this.LogoPictureBox);
            this.bunifuGradientPanel1.Controls.Add(this.FindWordsGroupBox);
            this.bunifuGradientPanel1.Controls.Add(this.EncryptionGroupBox);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(715, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(196, 519);
            this.bunifuGradientPanel1.TabIndex = 8;
            // 
            // LogoName
            // 
            this.LogoName.AutoSize = true;
            this.LogoName.BackColor = System.Drawing.Color.Transparent;
            this.LogoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LogoName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoName.Location = new System.Drawing.Point(73, 467);
            this.LogoName.Name = "LogoName";
            this.LogoName.Size = new System.Drawing.Size(60, 13);
            this.LogoName.TabIndex = 11;
            this.LogoName.Text = "Only Two";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(60, 403);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(86, 72);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoPictureBox.TabIndex = 10;
            this.LogoPictureBox.TabStop = false;
            // 
            // FindWordsGroupBox
            // 
            this.FindWordsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.FindWordsGroupBox.Controls.Add(this.FindLabel);
            this.FindWordsGroupBox.Controls.Add(this.FindTextBox);
            this.FindWordsGroupBox.Controls.Add(this.FindButton);
            this.FindWordsGroupBox.Controls.Add(this.AddFileButton);
            this.FindWordsGroupBox.Controls.Add(this.Warning);
            this.FindWordsGroupBox.Controls.Add(this.DeleteButton);
            this.FindWordsGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FindWordsGroupBox.Location = new System.Drawing.Point(10, 145);
            this.FindWordsGroupBox.Name = "FindWordsGroupBox";
            this.FindWordsGroupBox.Size = new System.Drawing.Size(178, 209);
            this.FindWordsGroupBox.TabIndex = 9;
            this.FindWordsGroupBox.TabStop = false;
            this.FindWordsGroupBox.Text = "Plain Text Operation";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(911, 519);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.KeygenTextBox);
            this.Controls.Add(this.CipherTextGroupBox);
            this.Controls.Add(this.PlainTextGroupBox);
            this.Controls.Add(this.SendFlatButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "OnlyTwo";
            this.PlainTextGroupBox.ResumeLayout(false);
            this.CipherTextGroupBox.ResumeLayout(false);
            this.CipherTextGroupBox.PerformLayout();
            this.EncryptionGroupBox.ResumeLayout(false);
            this.EncryptionGroupBox.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.FindWordsGroupBox.ResumeLayout(false);
            this.FindWordsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton SendFlatButton;
        private System.Windows.Forms.GroupBox PlainTextGroupBox;
        private System.Windows.Forms.GroupBox CipherTextGroupBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox CipherTextBox;
        private System.Windows.Forms.GroupBox EncryptionGroupBox;
        private Bunifu.Framework.UI.BunifuThinButton2 AddFileButton;
        private System.Windows.Forms.TextBox KeygenTextBox;
        private System.Windows.Forms.Label KeyLabel;
        private Bunifu.Framework.UI.BunifuFlatButton DeleteButton;
        private System.Windows.Forms.TextBox FindTextBox;
        private Bunifu.Framework.UI.BunifuFlatButton FindButton;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.RichTextBox PlainRichTextBox;
        private System.Windows.Forms.Label Warning;
        private System.Windows.Forms.RadioButton SPNRadioButton;
        private System.Windows.Forms.RadioButton SHARadioButton;
        private Bunifu.Framework.UI.BunifuFlatButton SolveButton;
        private Bunifu.Framework.UI.BunifuFlatButton EncryptButton;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.GroupBox FindWordsGroupBox;
        private System.Windows.Forms.Label LogoName;
        private System.Windows.Forms.PictureBox LogoPictureBox;
    }
}


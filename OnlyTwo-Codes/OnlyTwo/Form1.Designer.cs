
namespace OnlyTwo
{
    partial class OnlyTwoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlyTwoForm));
            this.SendFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PlainTextGroupBox = new System.Windows.Forms.GroupBox();
            this.CounterPlainLabel = new System.Windows.Forms.Label();
            this.PlainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.Warning = new System.Windows.Forms.Label();
            this.FindLabel = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DeleteButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AddFileButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CipherTextGroupBox = new System.Windows.Forms.GroupBox();
            this.CounterCipherLabel = new System.Windows.Forms.Label();
            this.CipherTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.EncryptionGroupBox = new System.Windows.Forms.GroupBox();
            this.EncryptComboBox = new System.Windows.Forms.ComboBox();
            this.SolveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EncryptButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.SagPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.LogoName = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.FindWordsGroupBox = new System.Windows.Forms.GroupBox();
            this.ReturnButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.KeygenTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.SendUserInfoLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ServerInfoLabel = new System.Windows.Forms.Label();
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.PlainTextGroupBox.SuspendLayout();
            this.CipherTextGroupBox.SuspendLayout();
            this.EncryptionGroupBox.SuspendLayout();
            this.SagPanel.SuspendLayout();
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
            this.SendFlatButton.Location = new System.Drawing.Point(299, 602);
            this.SendFlatButton.Margin = new System.Windows.Forms.Padding(5);
            this.SendFlatButton.Name = "SendFlatButton";
            this.SendFlatButton.Normalcolor = System.Drawing.Color.Black;
            this.SendFlatButton.OnHovercolor = System.Drawing.Color.Red;
            this.SendFlatButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SendFlatButton.selected = false;
            this.SendFlatButton.Size = new System.Drawing.Size(704, 41);
            this.SendFlatButton.TabIndex = 2;
            this.SendFlatButton.Text = "Send";
            this.SendFlatButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SendFlatButton.Textcolor = System.Drawing.Color.White;
            this.SendFlatButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendFlatButton.Click += new System.EventHandler(this.SendFlatButton_Click);
            // 
            // PlainTextGroupBox
            // 
            this.PlainTextGroupBox.Controls.Add(this.CounterPlainLabel);
            this.PlainTextGroupBox.Controls.Add(this.PlainRichTextBox);
            this.PlainTextGroupBox.Location = new System.Drawing.Point(299, 64);
            this.PlainTextGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.PlainTextGroupBox.Name = "PlainTextGroupBox";
            this.PlainTextGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.PlainTextGroupBox.Size = new System.Drawing.Size(704, 262);
            this.PlainTextGroupBox.TabIndex = 3;
            this.PlainTextGroupBox.TabStop = false;
            this.PlainTextGroupBox.Text = "Plain Text";
            // 
            // CounterPlainLabel
            // 
            this.CounterPlainLabel.AutoSize = true;
            this.CounterPlainLabel.Location = new System.Drawing.Point(600, 15);
            this.CounterPlainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CounterPlainLabel.Name = "CounterPlainLabel";
            this.CounterPlainLabel.Size = new System.Drawing.Size(62, 17);
            this.CounterPlainLabel.TabIndex = 6;
            this.CounterPlainLabel.Text = "Counter:";
            // 
            // PlainRichTextBox
            // 
            this.PlainRichTextBox.Location = new System.Drawing.Point(8, 34);
            this.PlainRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PlainRichTextBox.Name = "PlainRichTextBox";
            this.PlainRichTextBox.Size = new System.Drawing.Size(683, 216);
            this.PlainRichTextBox.TabIndex = 5;
            this.PlainRichTextBox.Text = "";
            this.PlainRichTextBox.TextChanged += new System.EventHandler(this.PlainRichTextBox_TextChanged);
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.BackColor = System.Drawing.Color.Transparent;
            this.Warning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Warning.Location = new System.Drawing.Point(12, 79);
            this.Warning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(225, 17);
            this.Warning.TabIndex = 6;
            this.Warning.Text = "Warning: Makes all text lowercase.";
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.BackColor = System.Drawing.Color.Transparent;
            this.FindLabel.ForeColor = System.Drawing.Color.White;
            this.FindLabel.Location = new System.Drawing.Point(12, 27);
            this.FindLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(93, 17);
            this.FindLabel.TabIndex = 4;
            this.FindLabel.Text = "Find Keyword";
            // 
            // FindTextBox
            // 
            this.FindTextBox.BackColor = System.Drawing.Color.White;
            this.FindTextBox.Location = new System.Drawing.Point(15, 47);
            this.FindTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(216, 22);
            this.FindTextBox.TabIndex = 1;
            // 
            // FindButton
            // 
            this.FindButton.Activecolor = System.Drawing.Color.Transparent;
            this.FindButton.BackColor = System.Drawing.Color.Transparent;
            this.FindButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindButton.BorderRadius = 3;
            this.FindButton.ButtonText = "Find";
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
            this.FindButton.IconRightZoom = 110D;
            this.FindButton.IconVisible = true;
            this.FindButton.IconZoom = 65D;
            this.FindButton.IsTab = false;
            this.FindButton.Location = new System.Drawing.Point(15, 100);
            this.FindButton.Margin = new System.Windows.Forms.Padding(5);
            this.FindButton.Name = "FindButton";
            this.FindButton.Normalcolor = System.Drawing.Color.Transparent;
            this.FindButton.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.FindButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.FindButton.selected = false;
            this.FindButton.Size = new System.Drawing.Size(216, 43);
            this.FindButton.TabIndex = 3;
            this.FindButton.Text = "Find";
            this.FindButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.DeleteButton.ButtonText = "     Delete All Text";
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
            this.DeleteButton.IconZoom = 65D;
            this.DeleteButton.IsTab = false;
            this.DeleteButton.Location = new System.Drawing.Point(15, 201);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Normalcolor = System.Drawing.Color.Transparent;
            this.DeleteButton.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.DeleteButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.DeleteButton.selected = false;
            this.DeleteButton.Size = new System.Drawing.Size(216, 43);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "     Delete All Text";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.AddFileButton.Location = new System.Drawing.Point(15, 250);
            this.AddFileButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(216, 39);
            this.AddFileButton.TabIndex = 2;
            this.AddFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CipherTextGroupBox
            // 
            this.CipherTextGroupBox.Controls.Add(this.CounterCipherLabel);
            this.CipherTextGroupBox.Controls.Add(this.CipherTextBox);
            this.CipherTextGroupBox.Location = new System.Drawing.Point(299, 334);
            this.CipherTextGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.CipherTextGroupBox.Name = "CipherTextGroupBox";
            this.CipherTextGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.CipherTextGroupBox.Size = new System.Drawing.Size(704, 260);
            this.CipherTextGroupBox.TabIndex = 4;
            this.CipherTextGroupBox.TabStop = false;
            this.CipherTextGroupBox.Text = "CipherText";
            // 
            // CounterCipherLabel
            // 
            this.CounterCipherLabel.AutoSize = true;
            this.CounterCipherLabel.Location = new System.Drawing.Point(600, 15);
            this.CounterCipherLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CounterCipherLabel.Name = "CounterCipherLabel";
            this.CounterCipherLabel.Size = new System.Drawing.Size(62, 17);
            this.CounterCipherLabel.TabIndex = 7;
            this.CounterCipherLabel.Text = "Counter:";
            // 
            // CipherTextBox
            // 
            this.CipherTextBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.CipherTextBox.Location = new System.Drawing.Point(8, 34);
            this.CipherTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CipherTextBox.Multiline = true;
            this.CipherTextBox.Name = "CipherTextBox";
            this.CipherTextBox.Size = new System.Drawing.Size(683, 217);
            this.CipherTextBox.TabIndex = 0;
            this.CipherTextBox.TextChanged += new System.EventHandler(this.CipherTextBox_TextChanged_1);
            // 
            // EncryptionGroupBox
            // 
            this.EncryptionGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.EncryptionGroupBox.Controls.Add(this.EncryptComboBox);
            this.EncryptionGroupBox.Controls.Add(this.SolveButton);
            this.EncryptionGroupBox.Controls.Add(this.EncryptButton);
            this.EncryptionGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EncryptionGroupBox.Location = new System.Drawing.Point(12, 15);
            this.EncryptionGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.EncryptionGroupBox.Name = "EncryptionGroupBox";
            this.EncryptionGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.EncryptionGroupBox.Size = new System.Drawing.Size(245, 156);
            this.EncryptionGroupBox.TabIndex = 5;
            this.EncryptionGroupBox.TabStop = false;
            this.EncryptionGroupBox.Text = "Encryption Type";
            // 
            // EncryptComboBox
            // 
            this.EncryptComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EncryptComboBox.ForeColor = System.Drawing.Color.Red;
            this.EncryptComboBox.FormattingEnabled = true;
            this.EncryptComboBox.Items.AddRange(new object[] {
            "SHA-256",
            "SPN-16"});
            this.EncryptComboBox.Location = new System.Drawing.Point(15, 23);
            this.EncryptComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.EncryptComboBox.Name = "EncryptComboBox";
            this.EncryptComboBox.Size = new System.Drawing.Size(216, 24);
            this.EncryptComboBox.TabIndex = 6;
            // 
            // SolveButton
            // 
            this.SolveButton.Activecolor = System.Drawing.Color.Transparent;
            this.SolveButton.BackColor = System.Drawing.Color.Transparent;
            this.SolveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SolveButton.BorderRadius = 3;
            this.SolveButton.ButtonText = "Solve";
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
            this.SolveButton.IconZoom = 65D;
            this.SolveButton.IsTab = false;
            this.SolveButton.Location = new System.Drawing.Point(16, 103);
            this.SolveButton.Margin = new System.Windows.Forms.Padding(5);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Normalcolor = System.Drawing.Color.Transparent;
            this.SolveButton.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.SolveButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.SolveButton.selected = false;
            this.SolveButton.Size = new System.Drawing.Size(215, 43);
            this.SolveButton.TabIndex = 8;
            this.SolveButton.Text = "Solve";
            this.SolveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SolveButton.Textcolor = System.Drawing.Color.White;
            this.SolveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Activecolor = System.Drawing.Color.Transparent;
            this.EncryptButton.BackColor = System.Drawing.Color.Transparent;
            this.EncryptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EncryptButton.BorderRadius = 3;
            this.EncryptButton.ButtonText = "Encrypt";
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
            this.EncryptButton.IconZoom = 65D;
            this.EncryptButton.IsTab = false;
            this.EncryptButton.Location = new System.Drawing.Point(16, 54);
            this.EncryptButton.Margin = new System.Windows.Forms.Padding(5);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Normalcolor = System.Drawing.Color.Transparent;
            this.EncryptButton.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.EncryptButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.EncryptButton.selected = false;
            this.EncryptButton.Size = new System.Drawing.Size(215, 43);
            this.EncryptButton.TabIndex = 7;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EncryptButton.Textcolor = System.Drawing.Color.White;
            this.EncryptButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(307, 11);
            this.KeyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(308, 17);
            this.KeyLabel.TabIndex = 7;
            this.KeyLabel.Text = "Key to the Message: (Key Must Be 8 Character)";
            // 
            // SagPanel
            // 
            this.SagPanel.BackColor = System.Drawing.Color.Transparent;
            this.SagPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SagPanel.BackgroundImage")));
            this.SagPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SagPanel.Controls.Add(this.LogoName);
            this.SagPanel.Controls.Add(this.LogoPictureBox);
            this.SagPanel.Controls.Add(this.FindWordsGroupBox);
            this.SagPanel.Controls.Add(this.EncryptionGroupBox);
            this.SagPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SagPanel.GradientBottomLeft = System.Drawing.Color.Black;
            this.SagPanel.GradientBottomRight = System.Drawing.Color.Red;
            this.SagPanel.GradientTopLeft = System.Drawing.Color.Black;
            this.SagPanel.GradientTopRight = System.Drawing.Color.Black;
            this.SagPanel.Location = new System.Drawing.Point(1012, 0);
            this.SagPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SagPanel.Name = "SagPanel";
            this.SagPanel.Quality = 10;
            this.SagPanel.Size = new System.Drawing.Size(271, 655);
            this.SagPanel.TabIndex = 8;
            // 
            // LogoName
            // 
            this.LogoName.AutoSize = true;
            this.LogoName.BackColor = System.Drawing.Color.Transparent;
            this.LogoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LogoName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoName.Location = new System.Drawing.Point(112, 574);
            this.LogoName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogoName.Name = "LogoName";
            this.LogoName.Size = new System.Drawing.Size(75, 17);
            this.LogoName.TabIndex = 11;
            this.LogoName.Text = "Only Two";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(84, 497);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(115, 89);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoPictureBox.TabIndex = 10;
            this.LogoPictureBox.TabStop = false;
            // 
            // FindWordsGroupBox
            // 
            this.FindWordsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.FindWordsGroupBox.Controls.Add(this.ReturnButton);
            this.FindWordsGroupBox.Controls.Add(this.FindLabel);
            this.FindWordsGroupBox.Controls.Add(this.FindTextBox);
            this.FindWordsGroupBox.Controls.Add(this.FindButton);
            this.FindWordsGroupBox.Controls.Add(this.AddFileButton);
            this.FindWordsGroupBox.Controls.Add(this.Warning);
            this.FindWordsGroupBox.Controls.Add(this.DeleteButton);
            this.FindWordsGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FindWordsGroupBox.Location = new System.Drawing.Point(12, 177);
            this.FindWordsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.FindWordsGroupBox.Name = "FindWordsGroupBox";
            this.FindWordsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.FindWordsGroupBox.Size = new System.Drawing.Size(245, 300);
            this.FindWordsGroupBox.TabIndex = 9;
            this.FindWordsGroupBox.TabStop = false;
            this.FindWordsGroupBox.Text = "Plain Text Operation";
            // 
            // ReturnButton
            // 
            this.ReturnButton.Activecolor = System.Drawing.Color.Transparent;
            this.ReturnButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReturnButton.BorderRadius = 3;
            this.ReturnButton.ButtonText = "            Restore Previous Text";
            this.ReturnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnButton.DisabledColor = System.Drawing.Color.Gray;
            this.ReturnButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ReturnButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("ReturnButton.Iconimage")));
            this.ReturnButton.Iconimage_right = null;
            this.ReturnButton.Iconimage_right_Selected = null;
            this.ReturnButton.Iconimage_Selected = null;
            this.ReturnButton.IconMarginLeft = 5;
            this.ReturnButton.IconMarginRight = 0;
            this.ReturnButton.IconRightVisible = true;
            this.ReturnButton.IconRightZoom = 120D;
            this.ReturnButton.IconVisible = true;
            this.ReturnButton.IconZoom = 65D;
            this.ReturnButton.IsTab = false;
            this.ReturnButton.Location = new System.Drawing.Point(15, 149);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(5);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ReturnButton.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.ReturnButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.ReturnButton.selected = false;
            this.ReturnButton.Size = new System.Drawing.Size(217, 43);
            this.ReturnButton.TabIndex = 7;
            this.ReturnButton.Text = "            Restore Previous Text";
            this.ReturnButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReturnButton.Textcolor = System.Drawing.Color.White;
            this.ReturnButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // KeygenTextBox
            // 
            this.KeygenTextBox.Location = new System.Drawing.Point(307, 32);
            this.KeygenTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.KeygenTextBox.Name = "KeygenTextBox";
            this.KeygenTextBox.Size = new System.Drawing.Size(683, 22);
            this.KeygenTextBox.TabIndex = 6;
            this.KeygenTextBox.TextChanged += new System.EventHandler(this.KeygenTextBox_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(16, 11);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(250, 17);
            this.UsernameLabel.TabIndex = 10;
            this.UsernameLabel.Text = "Username (Max Lenght 20 Character):";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(16, 33);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(148, 22);
            this.UsernameTextBox.TabIndex = 11;
            // 
            // SendUserInfoLabel
            // 
            this.SendUserInfoLabel.AutoSize = true;
            this.SendUserInfoLabel.Location = new System.Drawing.Point(16, 68);
            this.SendUserInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SendUserInfoLabel.Name = "SendUserInfoLabel";
            this.SendUserInfoLabel.Size = new System.Drawing.Size(217, 17);
            this.SendUserInfoLabel.TabIndex = 12;
            this.SendUserInfoLabel.Text = "Choose Send The Message User";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(173, 33);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(112, 25);
            this.ConnectButton.TabIndex = 13;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ServerInfoLabel
            // 
            this.ServerInfoLabel.AutoSize = true;
            this.ServerInfoLabel.Location = new System.Drawing.Point(119, 624);
            this.ServerInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerInfoLabel.Name = "ServerInfoLabel";
            this.ServerInfoLabel.Size = new System.Drawing.Size(0, 17);
            this.ServerInfoLabel.TabIndex = 14;
            // 
            // UsersListBox
            // 
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.ItemHeight = 16;
            this.UsersListBox.Location = new System.Drawing.Point(16, 87);
            this.UsersListBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.Size = new System.Drawing.Size(268, 500);
            this.UsersListBox.TabIndex = 15;
            // 
            // OnlyTwoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1283, 655);
            this.Controls.Add(this.UsersListBox);
            this.Controls.Add(this.ServerInfoLabel);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.SendUserInfoLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.SagPanel);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.KeygenTextBox);
            this.Controls.Add(this.CipherTextGroupBox);
            this.Controls.Add(this.PlainTextGroupBox);
            this.Controls.Add(this.SendFlatButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OnlyTwoForm";
            this.Text = "OnlyTwo";
            this.Load += new System.EventHandler(this.OnlyTwoForm_Load);
            this.PlainTextGroupBox.ResumeLayout(false);
            this.PlainTextGroupBox.PerformLayout();
            this.CipherTextGroupBox.ResumeLayout(false);
            this.CipherTextGroupBox.PerformLayout();
            this.EncryptionGroupBox.ResumeLayout(false);
            this.SagPanel.ResumeLayout(false);
            this.SagPanel.PerformLayout();
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
        private System.Windows.Forms.Label KeyLabel;
        private Bunifu.Framework.UI.BunifuFlatButton DeleteButton;
        private System.Windows.Forms.TextBox FindTextBox;
        private Bunifu.Framework.UI.BunifuFlatButton FindButton;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.Label Warning;
        private Bunifu.Framework.UI.BunifuFlatButton SolveButton;
        private Bunifu.Framework.UI.BunifuFlatButton EncryptButton;
        private Bunifu.Framework.UI.BunifuGradientPanel SagPanel;
        private System.Windows.Forms.GroupBox FindWordsGroupBox;
        private System.Windows.Forms.Label LogoName;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.RichTextBox PlainRichTextBox;
        private System.Windows.Forms.ComboBox EncryptComboBox;
        private Bunifu.Framework.UI.BunifuFlatButton ReturnButton;
        private System.Windows.Forms.TextBox KeygenTextBox;
        private System.Windows.Forms.Label CounterPlainLabel;
        private System.Windows.Forms.Label CounterCipherLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label SendUserInfoLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label ServerInfoLabel;
        private System.Windows.Forms.ListBox UsersListBox;
    }
}


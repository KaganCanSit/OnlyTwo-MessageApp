namespace server
{
    partial class ServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.InfoLabelUp = new System.Windows.Forms.Label();
            this.InfoLabelDown = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ClintListBox = new System.Windows.Forms.ListBox();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.BackGradientPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BackGradientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(12, 28);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(275, 376);
            this.MessageTextBox.TabIndex = 0;
            this.MessageTextBox.Text = "";
            // 
            // InfoLabelUp
            // 
            this.InfoLabelUp.AutoSize = true;
            this.InfoLabelUp.Location = new System.Drawing.Point(12, 416);
            this.InfoLabelUp.Name = "InfoLabelUp";
            this.InfoLabelUp.Size = new System.Drawing.Size(0, 13);
            this.InfoLabelUp.TabIndex = 2;
            // 
            // InfoLabelDown
            // 
            this.InfoLabelDown.AutoSize = true;
            this.InfoLabelDown.Location = new System.Drawing.Point(12, 443);
            this.InfoLabelDown.Name = "InfoLabelDown";
            this.InfoLabelDown.Size = new System.Drawing.Size(0, 13);
            this.InfoLabelDown.TabIndex = 3;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(12, 13);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(58, 13);
            this.MessageLabel.TabIndex = 7;
            this.MessageLabel.Text = "Messages:";
            // 
            // ClintListBox
            // 
            this.ClintListBox.FormattingEnabled = true;
            this.ClintListBox.Location = new System.Drawing.Point(9, 33);
            this.ClintListBox.Name = "ClintListBox";
            this.ClintListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ClintListBox.Size = new System.Drawing.Size(125, 420);
            this.ClintListBox.TabIndex = 6;
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClientLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientLabel.Location = new System.Drawing.Point(6, 13);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(50, 13);
            this.ClientLabel.TabIndex = 8;
            this.ClientLabel.Text = "All Client:";
            // 
            // BackGradientPanel
            // 
            this.BackGradientPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackGradientPanel.BackgroundImage")));
            this.BackGradientPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackGradientPanel.Controls.Add(this.ClientLabel);
            this.BackGradientPanel.Controls.Add(this.ClintListBox);
            this.BackGradientPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.BackGradientPanel.GradientBottomLeft = System.Drawing.Color.DarkRed;
            this.BackGradientPanel.GradientBottomRight = System.Drawing.Color.DarkRed;
            this.BackGradientPanel.GradientTopLeft = System.Drawing.Color.Black;
            this.BackGradientPanel.GradientTopRight = System.Drawing.Color.Red;
            this.BackGradientPanel.Location = new System.Drawing.Point(298, 0);
            this.BackGradientPanel.Name = "BackGradientPanel";
            this.BackGradientPanel.Quality = 10;
            this.BackGradientPanel.Size = new System.Drawing.Size(143, 468);
            this.BackGradientPanel.TabIndex = 9;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 468);
            this.Controls.Add(this.BackGradientPanel);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.InfoLabelDown);
            this.Controls.Add(this.InfoLabelUp);
            this.Controls.Add(this.MessageTextBox);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.BackGradientPanel.ResumeLayout(false);
            this.BackGradientPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MessageTextBox;
        private System.Windows.Forms.Label InfoLabelUp;
        private System.Windows.Forms.Label InfoLabelDown;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.ListBox ClintListBox;
        private System.Windows.Forms.Label ClientLabel;
        private Bunifu.Framework.UI.BunifuGradientPanel BackGradientPanel;
    }
}


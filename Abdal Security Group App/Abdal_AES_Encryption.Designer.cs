namespace Abdal_Security_Group_App
{
    partial class Abdal_AES_Encryption
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem11 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem12 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem13 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abdal_AES_Encryption));
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.EncryptToggleSwitch = new Telerik.WinControls.UI.RadToggleSwitch();
            this.DecryptToggleSwitch = new Telerik.WinControls.UI.RadToggleSwitch();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.SecretKeyTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.EncDecButton = new Telerik.WinControls.UI.RadButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.StringTextEditor = new System.Windows.Forms.RichTextBox();
            this.ResultTextEditor = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cipherModeMenu = new Telerik.WinControls.UI.RadDropDownList();
            this.keyLengthDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.encodingModeDropDownList = new Telerik.WinControls.UI.RadDropDownList();
            this.randButton = new Telerik.WinControls.UI.RadButton();
            this.radDesktopAlert1 = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncryptToggleSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecryptToggleSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecretKeyTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncDecButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cipherModeMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyLengthDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encodingModeDropDownList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(62, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Your String";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // EncryptToggleSwitch
            // 
            this.EncryptToggleSwitch.Location = new System.Drawing.Point(368, 76);
            this.EncryptToggleSwitch.Name = "EncryptToggleSwitch";
            this.EncryptToggleSwitch.OffText = "Encrypt OFF";
            this.EncryptToggleSwitch.OnText = "Encrypt ON";
            this.EncryptToggleSwitch.Size = new System.Drawing.Size(137, 20);
            this.EncryptToggleSwitch.TabIndex = 3;
            this.EncryptToggleSwitch.ThemeName = "VisualStudio2012Dark";
            this.EncryptToggleSwitch.ThumbTickness = 15;
            this.EncryptToggleSwitch.ValueChanged += new System.EventHandler(this.EncryptToggleSwitch_ValueChanged);
            // 
            // DecryptToggleSwitch
            // 
            this.DecryptToggleSwitch.Location = new System.Drawing.Point(514, 76);
            this.DecryptToggleSwitch.Name = "DecryptToggleSwitch";
            this.DecryptToggleSwitch.OffText = "Decrypt OFF";
            this.DecryptToggleSwitch.OnText = "Decrypt ON";
            this.DecryptToggleSwitch.Size = new System.Drawing.Size(137, 20);
            this.DecryptToggleSwitch.TabIndex = 4;
            this.DecryptToggleSwitch.ThemeName = "VisualStudio2012Dark";
            this.DecryptToggleSwitch.ThumbTickness = 15;
            this.DecryptToggleSwitch.Value = false;
            this.DecryptToggleSwitch.ValueChanged += new System.EventHandler(this.DecryptToggleSwitch_ValueChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(368, 12);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(84, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Your Secret Key";
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            // 
            // SecretKeyTextBox
            // 
            this.SecretKeyTextBox.Location = new System.Drawing.Point(368, 36);
            this.SecretKeyTextBox.Name = "SecretKeyTextBox";
            this.SecretKeyTextBox.Size = new System.Drawing.Size(237, 24);
            this.SecretKeyTextBox.TabIndex = 1;
            this.SecretKeyTextBox.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(12, 149);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(37, 18);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Result";
            this.radLabel3.ThemeName = "VisualStudio2012Dark";
            // 
            // EncDecButton
            // 
            this.EncDecButton.Location = new System.Drawing.Point(371, 105);
            this.EncDecButton.Name = "EncDecButton";
            this.EncDecButton.Size = new System.Drawing.Size(280, 24);
            this.EncDecButton.TabIndex = 9;
            this.EncDecButton.Text = "Encrypt \\ Decrypt";
            this.EncDecButton.ThemeName = "VisualStudio2012Dark";
            this.EncDecButton.Click += new System.EventHandler(this.EncDecButton_Click);
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(12, 414);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(205, 18);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "Programmer : Ebrahim Shafiei (EbraSha)";
            this.radLabel4.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(223, 414);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(112, 18);
            this.radLabel5.TabIndex = 3;
            this.radLabel5.Text = "|  Www.Hackers.Zone";
            this.radLabel5.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(344, 414);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(135, 18);
            this.radLabel6.TabIndex = 4;
            this.radLabel6.Text = "|  Prof.Shafiei@Gmail.com";
            this.radLabel6.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(486, 414);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(189, 18);
            this.radLabel7.TabIndex = 6;
            this.radLabel7.Text = "| Powered By Abdal Security Agency ";
            this.radLabel7.ThemeName = "VisualStudio2012Dark";
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.Location = new System.Drawing.Point(11, 395);
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.Size = new System.Drawing.Size(640, 8);
            this.radProgressBar1.TabIndex = 9;
            this.radProgressBar1.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.ProgressIndicatorElement)(this.radProgressBar1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.UI.ProgressIndicatorElement)(this.radProgressBar1.GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // StringTextEditor
            // 
            this.StringTextEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.StringTextEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StringTextEditor.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.StringTextEditor.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.StringTextEditor.Location = new System.Drawing.Point(16, 36);
            this.StringTextEditor.Name = "StringTextEditor";
            this.StringTextEditor.Size = new System.Drawing.Size(346, 96);
            this.StringTextEditor.TabIndex = 0;
            this.StringTextEditor.Text = "";
            // 
            // ResultTextEditor
            // 
            this.ResultTextEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.ResultTextEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultTextEditor.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ResultTextEditor.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ResultTextEditor.Location = new System.Drawing.Point(11, 173);
            this.ResultTextEditor.Name = "ResultTextEditor";
            this.ResultTextEditor.Size = new System.Drawing.Size(640, 216);
            this.ResultTextEditor.TabIndex = 8;
            this.ResultTextEditor.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Abdal_AES_Encryption.Properties.Resources.logo_512;
            this.pictureBox2.Location = new System.Drawing.Point(686, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(380, 380);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // cipherModeMenu
            // 
            radListDataItem2.Text = "cbc";
            radListDataItem3.Text = "ecb";
            radListDataItem11.Text = "ofb";
            radListDataItem12.Text = "cfb";
            radListDataItem13.Text = "gcm";
            this.cipherModeMenu.Items.Add(radListDataItem2);
            this.cipherModeMenu.Items.Add(radListDataItem3);
            this.cipherModeMenu.Items.Add(radListDataItem11);
            this.cipherModeMenu.Items.Add(radListDataItem12);
            this.cipherModeMenu.Items.Add(radListDataItem13);
            this.cipherModeMenu.Location = new System.Drawing.Point(526, 143);
            this.cipherModeMenu.Name = "cipherModeMenu";
            this.cipherModeMenu.SelectNextOnDoubleClick = true;
            this.cipherModeMenu.Size = new System.Drawing.Size(125, 24);
            this.cipherModeMenu.TabIndex = 7;
            this.cipherModeMenu.Text = "CipherMode ";
            this.cipherModeMenu.ThemeName = "VisualStudio2012Dark";
            // 
            // keyLengthDropDownList
            // 
            radListDataItem4.Text = "256";
            this.keyLengthDropDownList.Items.Add(radListDataItem4);
            this.keyLengthDropDownList.Location = new System.Drawing.Point(395, 143);
            this.keyLengthDropDownList.Name = "keyLengthDropDownList";
            this.keyLengthDropDownList.Size = new System.Drawing.Size(125, 24);
            this.keyLengthDropDownList.TabIndex = 6;
            this.keyLengthDropDownList.Text = "Key Length ";
            this.keyLengthDropDownList.ThemeName = "VisualStudio2012Dark";
            // 
            // encodingModeDropDownList
            // 
            radListDataItem5.Text = "Hex";
            radListDataItem6.Text = "base64";
            this.encodingModeDropDownList.Items.Add(radListDataItem5);
            this.encodingModeDropDownList.Items.Add(radListDataItem6);
            this.encodingModeDropDownList.Location = new System.Drawing.Point(264, 143);
            this.encodingModeDropDownList.Name = "encodingModeDropDownList";
            this.encodingModeDropDownList.Size = new System.Drawing.Size(125, 24);
            this.encodingModeDropDownList.TabIndex = 5;
            this.encodingModeDropDownList.Text = "Encoding Mode ";
            this.encodingModeDropDownList.ThemeName = "VisualStudio2012Dark";
            // 
            // randButton
            // 
            this.randButton.Location = new System.Drawing.Point(611, 36);
            this.randButton.Name = "randButton";
            this.randButton.Size = new System.Drawing.Size(40, 24);
            this.randButton.TabIndex = 2;
            this.randButton.Text = "rand";
            this.randButton.ThemeName = "VisualStudio2012Dark";
            this.randButton.Click += new System.EventHandler(this.randButton_Click);
            // 
            // radDesktopAlert1
            // 
            this.radDesktopAlert1.AutoCloseDelay = 8;
            this.radDesktopAlert1.PopupAnimationEasing = Telerik.WinControls.RadEasingType.InQuart;
            this.radDesktopAlert1.ShowOptionsButton = false;
            this.radDesktopAlert1.ThemeName = "VisualStudio2012Dark";
            // 
            // Abdal_AES_Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 444);
            this.Controls.Add(this.randButton);
            this.Controls.Add(this.encodingModeDropDownList);
            this.Controls.Add(this.keyLengthDropDownList);
            this.Controls.Add(this.cipherModeMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ResultTextEditor);
            this.Controls.Add(this.StringTextEditor);
            this.Controls.Add(this.radProgressBar1);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.EncDecButton);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.DecryptToggleSwitch);
            this.Controls.Add(this.SecretKeyTextBox);
            this.Controls.Add(this.EncryptToggleSwitch);
            this.Controls.Add(this.radLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Abdal_AES_Encryption";
            this.Opacity = 0.9D;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Abdal AES Encryption";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.Abdal_2Key_Triple_DES_Builder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncryptToggleSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DecryptToggleSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecretKeyTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncDecButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cipherModeMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyLengthDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encodingModeDropDownList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadToggleSwitch EncryptToggleSwitch;
        private Telerik.WinControls.UI.RadToggleSwitch DecryptToggleSwitch;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox SecretKeyTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton EncDecButton;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;
        private System.Windows.Forms.RichTextBox StringTextEditor;
        private System.Windows.Forms.RichTextBox ResultTextEditor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Telerik.WinControls.UI.RadDropDownList cipherModeMenu;
        private Telerik.WinControls.UI.RadDropDownList keyLengthDropDownList;
        private Telerik.WinControls.UI.RadDropDownList encodingModeDropDownList;
        private Telerik.WinControls.UI.RadButton randButton;
        private Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert1;
    }
}


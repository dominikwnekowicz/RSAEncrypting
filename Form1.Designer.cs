namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstTabControl = new System.Windows.Forms.TabControl();
            this.encryptionTabPage = new System.Windows.Forms.TabPage();
            this.encryptButton = new System.Windows.Forms.Button();
            this.encryptionPublicKeyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.encryptionPublicKeylabel = new System.Windows.Forms.Label();
            this.encryptionMessageLabel = new System.Windows.Forms.Label();
            this.encryptionMessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.keyCheckBox = new System.Windows.Forms.CheckBox();
            this.decryptionTabPage = new System.Windows.Forms.TabPage();
            this.decryptButton = new System.Windows.Forms.Button();
            this.decryptionMessageLabel = new System.Windows.Forms.Label();
            this.decryptionPrivateKeyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.decryptionMessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.decryptionPrivateKeyLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveAllButton = new System.Windows.Forms.Button();
            this.secondTabControl = new System.Windows.Forms.TabControl();
            this.messageTabPage = new System.Windows.Forms.TabPage();
            this.messageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.privateKeyTabPage = new System.Windows.Forms.TabPage();
            this.privateKeyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.publicKeyTabPage = new System.Windows.Forms.TabPage();
            this.publicKeyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveAllFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.firstTabControl.SuspendLayout();
            this.encryptionTabPage.SuspendLayout();
            this.decryptionTabPage.SuspendLayout();
            this.secondTabControl.SuspendLayout();
            this.messageTabPage.SuspendLayout();
            this.privateKeyTabPage.SuspendLayout();
            this.publicKeyTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstTabControl
            // 
            this.firstTabControl.Controls.Add(this.encryptionTabPage);
            this.firstTabControl.Controls.Add(this.decryptionTabPage);
            this.firstTabControl.Location = new System.Drawing.Point(12, 12);
            this.firstTabControl.Name = "firstTabControl";
            this.firstTabControl.SelectedIndex = 0;
            this.firstTabControl.Size = new System.Drawing.Size(776, 426);
            this.firstTabControl.TabIndex = 0;
            // 
            // encryptionTabPage
            // 
            this.encryptionTabPage.Controls.Add(this.encryptButton);
            this.encryptionTabPage.Controls.Add(this.encryptionPublicKeyRichTextBox);
            this.encryptionTabPage.Controls.Add(this.encryptionPublicKeylabel);
            this.encryptionTabPage.Controls.Add(this.encryptionMessageLabel);
            this.encryptionTabPage.Controls.Add(this.encryptionMessageRichTextBox);
            this.encryptionTabPage.Controls.Add(this.keyCheckBox);
            this.encryptionTabPage.Location = new System.Drawing.Point(4, 22);
            this.encryptionTabPage.Name = "encryptionTabPage";
            this.encryptionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.encryptionTabPage.Size = new System.Drawing.Size(768, 400);
            this.encryptionTabPage.TabIndex = 0;
            this.encryptionTabPage.Text = "Szyfrowanie";
            this.encryptionTabPage.UseVisualStyleBackColor = true;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(672, 367);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 5;
            this.encryptButton.Text = "Szyfruj";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // encryptionPublicKeyRichTextBox
            // 
            this.encryptionPublicKeyRichTextBox.Location = new System.Drawing.Point(6, 201);
            this.encryptionPublicKeyRichTextBox.Name = "encryptionPublicKeyRichTextBox";
            this.encryptionPublicKeyRichTextBox.Size = new System.Drawing.Size(755, 160);
            this.encryptionPublicKeyRichTextBox.TabIndex = 4;
            this.encryptionPublicKeyRichTextBox.Text = "";
            // 
            // encryptionPublicKeylabel
            // 
            this.encryptionPublicKeylabel.AutoSize = true;
            this.encryptionPublicKeylabel.Location = new System.Drawing.Point(4, 185);
            this.encryptionPublicKeylabel.Name = "encryptionPublicKeylabel";
            this.encryptionPublicKeylabel.Size = new System.Drawing.Size(83, 13);
            this.encryptionPublicKeylabel.TabIndex = 3;
            this.encryptionPublicKeylabel.Text = "Klucz publiczny:";
            // 
            // encryptionMessageLabel
            // 
            this.encryptionMessageLabel.AutoSize = true;
            this.encryptionMessageLabel.Location = new System.Drawing.Point(4, 4);
            this.encryptionMessageLabel.Name = "encryptionMessageLabel";
            this.encryptionMessageLabel.Size = new System.Drawing.Size(66, 13);
            this.encryptionMessageLabel.TabIndex = 2;
            this.encryptionMessageLabel.Text = "Wiadomość:";
            // 
            // encryptionMessageRichTextBox
            // 
            this.encryptionMessageRichTextBox.Location = new System.Drawing.Point(6, 20);
            this.encryptionMessageRichTextBox.Name = "encryptionMessageRichTextBox";
            this.encryptionMessageRichTextBox.Size = new System.Drawing.Size(755, 160);
            this.encryptionMessageRichTextBox.TabIndex = 1;
            this.encryptionMessageRichTextBox.Text = "";
            this.encryptionMessageRichTextBox.TextChanged += new System.EventHandler(this.encryptionMessageRichTextBox_TextChanged);
            // 
            // keyCheckBox
            // 
            this.keyCheckBox.AutoSize = true;
            this.keyCheckBox.Location = new System.Drawing.Point(7, 371);
            this.keyCheckBox.Name = "keyCheckBox";
            this.keyCheckBox.Size = new System.Drawing.Size(111, 17);
            this.keyCheckBox.TabIndex = 0;
            this.keyCheckBox.Text = "Wygeneruj klucze";
            this.keyCheckBox.UseVisualStyleBackColor = true;
            this.keyCheckBox.CheckedChanged += new System.EventHandler(this.keyCheckBox_CheckedChanged);
            // 
            // decryptionTabPage
            // 
            this.decryptionTabPage.Controls.Add(this.decryptButton);
            this.decryptionTabPage.Controls.Add(this.decryptionMessageLabel);
            this.decryptionTabPage.Controls.Add(this.decryptionPrivateKeyRichTextBox);
            this.decryptionTabPage.Controls.Add(this.decryptionMessageRichTextBox);
            this.decryptionTabPage.Controls.Add(this.decryptionPrivateKeyLabel);
            this.decryptionTabPage.Location = new System.Drawing.Point(4, 22);
            this.decryptionTabPage.Name = "decryptionTabPage";
            this.decryptionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.decryptionTabPage.Size = new System.Drawing.Size(768, 400);
            this.decryptionTabPage.TabIndex = 1;
            this.decryptionTabPage.Text = "Deszyfrowanie";
            this.decryptionTabPage.UseVisualStyleBackColor = true;
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(672, 367);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 9;
            this.decryptButton.Text = "Deszyfruj";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // decryptionMessageLabel
            // 
            this.decryptionMessageLabel.AutoSize = true;
            this.decryptionMessageLabel.Location = new System.Drawing.Point(4, 4);
            this.decryptionMessageLabel.Name = "decryptionMessageLabel";
            this.decryptionMessageLabel.Size = new System.Drawing.Size(66, 13);
            this.decryptionMessageLabel.TabIndex = 8;
            this.decryptionMessageLabel.Text = "Wiadomość:";
            // 
            // decryptionPrivateKeyRichTextBox
            // 
            this.decryptionPrivateKeyRichTextBox.Location = new System.Drawing.Point(6, 201);
            this.decryptionPrivateKeyRichTextBox.Name = "decryptionPrivateKeyRichTextBox";
            this.decryptionPrivateKeyRichTextBox.Size = new System.Drawing.Size(755, 160);
            this.decryptionPrivateKeyRichTextBox.TabIndex = 6;
            this.decryptionPrivateKeyRichTextBox.Text = "";
            // 
            // decryptionMessageRichTextBox
            // 
            this.decryptionMessageRichTextBox.Location = new System.Drawing.Point(6, 20);
            this.decryptionMessageRichTextBox.Name = "decryptionMessageRichTextBox";
            this.decryptionMessageRichTextBox.Size = new System.Drawing.Size(755, 160);
            this.decryptionMessageRichTextBox.TabIndex = 7;
            this.decryptionMessageRichTextBox.Text = "";
            this.decryptionMessageRichTextBox.TextChanged += new System.EventHandler(this.decryptionMessageRichTextBox_TextChanged);
            // 
            // decryptionPrivateKeyLabel
            // 
            this.decryptionPrivateKeyLabel.AutoSize = true;
            this.decryptionPrivateKeyLabel.Location = new System.Drawing.Point(4, 185);
            this.decryptionPrivateKeyLabel.Name = "decryptionPrivateKeyLabel";
            this.decryptionPrivateKeyLabel.Size = new System.Drawing.Size(81, 13);
            this.decryptionPrivateKeyLabel.TabIndex = 5;
            this.decryptionPrivateKeyLabel.Text = "Klucz prywatny:";
            this.decryptionPrivateKeyLabel.UseMnemonic = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(37, 401);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Wróć";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(553, 401);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveAllButton
            // 
            this.saveAllButton.Location = new System.Drawing.Point(663, 401);
            this.saveAllButton.Name = "saveAllButton";
            this.saveAllButton.Size = new System.Drawing.Size(100, 23);
            this.saveAllButton.TabIndex = 12;
            this.saveAllButton.Text = "Zapisz wszystkie";
            this.saveAllButton.UseVisualStyleBackColor = true;
            this.saveAllButton.Click += new System.EventHandler(this.saveAllButton_Click);
            // 
            // secondTabControl
            // 
            this.secondTabControl.Controls.Add(this.messageTabPage);
            this.secondTabControl.Controls.Add(this.privateKeyTabPage);
            this.secondTabControl.Controls.Add(this.publicKeyTabPage);
            this.secondTabControl.ItemSize = new System.Drawing.Size(69, 18);
            this.secondTabControl.Location = new System.Drawing.Point(12, 12);
            this.secondTabControl.Name = "secondTabControl";
            this.secondTabControl.SelectedIndex = 0;
            this.secondTabControl.Size = new System.Drawing.Size(776, 426);
            this.secondTabControl.TabIndex = 11;
            // 
            // messageTabPage
            // 
            this.messageTabPage.Controls.Add(this.messageRichTextBox);
            this.messageTabPage.Location = new System.Drawing.Point(4, 22);
            this.messageTabPage.Name = "messageTabPage";
            this.messageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.messageTabPage.Size = new System.Drawing.Size(768, 400);
            this.messageTabPage.TabIndex = 0;
            this.messageTabPage.Text = "Wiadomość";
            this.messageTabPage.UseVisualStyleBackColor = true;
            // 
            // messageRichTextBox
            // 
            this.messageRichTextBox.Location = new System.Drawing.Point(6, 20);
            this.messageRichTextBox.Name = "messageRichTextBox";
            this.messageRichTextBox.Size = new System.Drawing.Size(755, 341);
            this.messageRichTextBox.TabIndex = 0;
            this.messageRichTextBox.Text = "";
            this.messageRichTextBox.ReadOnly = true;
            // 
            // privateKeyTabPage
            // 
            this.privateKeyTabPage.Controls.Add(this.privateKeyRichTextBox);
            this.privateKeyTabPage.Location = new System.Drawing.Point(4, 22);
            this.privateKeyTabPage.Name = "privateKeyTabPage";
            this.privateKeyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.privateKeyTabPage.Size = new System.Drawing.Size(768, 400);
            this.privateKeyTabPage.TabIndex = 1;
            this.privateKeyTabPage.Text = "Klucz prywatny";
            this.privateKeyTabPage.UseVisualStyleBackColor = true;
            // 
            // privateKeyRichTextBox
            // 
            this.privateKeyRichTextBox.Location = new System.Drawing.Point(6, 20);
            this.privateKeyRichTextBox.Name = "privateKeyRichTextBox";
            this.privateKeyRichTextBox.Size = new System.Drawing.Size(755, 341);
            this.privateKeyRichTextBox.TabIndex = 4;
            this.privateKeyRichTextBox.Text = "";
            this.privateKeyRichTextBox.ReadOnly = true;
            // 
            // publicKeyTabPage
            // 
            this.publicKeyTabPage.Controls.Add(this.publicKeyRichTextBox);
            this.publicKeyTabPage.Location = new System.Drawing.Point(4, 22);
            this.publicKeyTabPage.Name = "publicKeyTabPage";
            this.publicKeyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.publicKeyTabPage.Size = new System.Drawing.Size(768, 400);
            this.publicKeyTabPage.TabIndex = 2;
            this.publicKeyTabPage.Text = "Klucz publiczny";
            this.publicKeyTabPage.UseVisualStyleBackColor = true;
            // 
            // publicKeyRichTextBox
            // 
            this.publicKeyRichTextBox.Location = new System.Drawing.Point(6, 20);
            this.publicKeyRichTextBox.Name = "publicKeyRichTextBox";
            this.publicKeyRichTextBox.Size = new System.Drawing.Size(755, 341);
            this.publicKeyRichTextBox.TabIndex = 4;
            this.publicKeyRichTextBox.Text = "";
            this.publicKeyRichTextBox.ReadOnly = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.AddExtension = true;
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // saveAllFileDialog
            // 
            this.saveAllFileDialog.AddExtension = true;
            this.saveAllFileDialog.DefaultExt = "txt";
            this.saveAllFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveAllFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveAllFileDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.firstTabControl);
            this.Name = "Form1";
            this.Text = "RSAProgram";
            this.firstTabControl.ResumeLayout(false);
            this.encryptionTabPage.ResumeLayout(false);
            this.encryptionTabPage.PerformLayout();
            this.decryptionTabPage.ResumeLayout(false);
            this.decryptionTabPage.PerformLayout();
            this.secondTabControl.ResumeLayout(false);
            this.messageTabPage.ResumeLayout(false);
            this.privateKeyTabPage.ResumeLayout(false);
            this.publicKeyTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl firstTabControl;
        private System.Windows.Forms.TabPage encryptionTabPage;
        private System.Windows.Forms.TabPage decryptionTabPage;
        private System.Windows.Forms.CheckBox keyCheckBox;
        private System.Windows.Forms.Label encryptionMessageLabel;
        private System.Windows.Forms.RichTextBox encryptionMessageRichTextBox;
        private System.Windows.Forms.RichTextBox encryptionPublicKeyRichTextBox;
        private System.Windows.Forms.Label encryptionPublicKeylabel;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Label decryptionMessageLabel;
        private System.Windows.Forms.RichTextBox decryptionPrivateKeyRichTextBox;
        private System.Windows.Forms.RichTextBox decryptionMessageRichTextBox;
        private System.Windows.Forms.Label decryptionPrivateKeyLabel;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button saveAllButton;
        private System.Windows.Forms.TabControl secondTabControl;
        private System.Windows.Forms.TabPage messageTabPage;
        private System.Windows.Forms.RichTextBox messageRichTextBox;
        private System.Windows.Forms.TabPage privateKeyTabPage;
        private System.Windows.Forms.RichTextBox privateKeyRichTextBox;
        private System.Windows.Forms.TabPage publicKeyTabPage;
        private System.Windows.Forms.RichTextBox publicKeyRichTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.SaveFileDialog saveAllFileDialog;
    }
}


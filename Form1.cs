using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(2048); //2048 - Długość klucza
        private static string message = "";
        private static string privateKey;
        private static string publicKey;
        private static string encryptedMessage;
        private static string decryptedMessage;
        public Form1()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if(keyCheckBox.Checked)
            {
                GenerateKeys();
                privateKeyRichTextBox.Text = privateKey;
                publicKeyRichTextBox.Text = publicKey;
            }
            else
            {
                publicKey = encryptionPublicKeyRichTextBox.Text;
            }
            if(message != String.Empty && publicKey != String.Empty)
            {
                ChangeForm("encrypt");
                encryptedMessage = Encrypt();
                messageRichTextBox.Text = encryptedMessage;
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Błąd, wprowadź dane poprawnie","Error", buttons, MessageBoxIcon.Error);
            }
            
            
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            privateKey = decryptionPrivateKeyRichTextBox.Text;
            if (message != String.Empty && privateKey != String.Empty)
            {
                ChangeForm("decrypt");
                decryptedMessage = Decrypt();
                messageRichTextBox.Text = decryptedMessage;

            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Błąd, wprowadź dane poprawnie", "Error", buttons, MessageBoxIcon.Error);
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            ChangeForm("back");
        }

        private void encryptionMessageRichTextBox_TextChanged(object sender, EventArgs e)
        {
            message = encryptionMessageRichTextBox.Text;
            UpdateText();
        }

        private void decryptionMessageRichTextBox_TextChanged(object sender, EventArgs e)
        {
            message = decryptionMessageRichTextBox.Text;
            UpdateText();
        }

        private void keyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var status = keyCheckBox.Checked;
            if(status)
            {
                encryptionTabPage.Controls.Remove(encryptionPublicKeylabel);
                encryptionTabPage.Controls.Remove(encryptionPublicKeyRichTextBox);
                encryptionMessageRichTextBox.Height = 341;

            }
            else
            {
                encryptionTabPage.Controls.Add(encryptionPublicKeylabel);
                encryptionTabPage.Controls.Add(encryptionPublicKeyRichTextBox);
                encryptionMessageRichTextBox.Height = 160;
            }
        }



        private void GenerateKeys()
        {
            var PrivateKey = cryptoServiceProvider.ExportParameters(true); //Generowanie klucza prywatnego
            var PublicKey = cryptoServiceProvider.ExportParameters(false); //Generowanie klucza publiczny
            publicKey = GetKeyString(PublicKey);
            privateKey = GetKeyString(PrivateKey);
        }

        public static string GetKeyString(RSAParameters key)
        {

            var stringWriter = new System.IO.StringWriter();
            var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xmlSerializer.Serialize(stringWriter, key);
            return stringWriter.ToString();
        }

        public static string Encrypt()
        {
            var bytesToEncrypt = Encoding.UTF8.GetBytes(message);

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    rsa.FromXmlString(publicKey.ToString());
                    var encryptedData = rsa.Encrypt(bytesToEncrypt, true);
                    var base64Encrypted = Convert.ToBase64String(encryptedData);
                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }
        public static string Decrypt()
        {
            var bytesToDescrypt = Encoding.UTF8.GetBytes(message);

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {

                    // server decrypting data with private key                    
                    rsa.FromXmlString(privateKey);

                    var resultBytes = Convert.FromBase64String(message);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    return decryptedData.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }


        private void UpdateText()
        {
            var selectedIndex = firstTabControl.SelectedIndex;
            if (selectedIndex == 0)
            {
                decryptionMessageRichTextBox.Text = encryptionMessageRichTextBox.Text;
            }
            else
            {
                encryptionMessageRichTextBox.Text = decryptionMessageRichTextBox.Text;
            }
        }

        private void ChangeForm(string type)
        {
            if(type == "encrypt" )
            {
                
                var tabsCount = secondTabControl.TabPages.Count;
                if (tabsCount < 2)
                {
                    secondTabControl.Controls.Add(privateKeyTabPage);
                    secondTabControl.Controls.Add(publicKeyTabPage);
                }
                if(keyCheckBox.Checked)
                {
                    Controls.Remove(firstTabControl);
                    Controls.Add(backButton);
                    Controls.Add(saveButton);
                    Controls.Add(saveAllButton);
                    Controls.Add(secondTabControl);
                }
                else
                {
                    secondTabControl.Controls.Remove(privateKeyTabPage);
                    secondTabControl.Controls.Remove(publicKeyTabPage);
                    Controls.Remove(firstTabControl);
                    Controls.Add(backButton);
                    Controls.Add(saveButton);
                    Controls.Add(secondTabControl);
                }
            }
            else if(type == "decrypt")
            {
                Controls.Remove(firstTabControl);
                secondTabControl.Controls.Remove(privateKeyTabPage);
                secondTabControl.Controls.Remove(publicKeyTabPage);
                Controls.Add(backButton);
                Controls.Add(saveButton);
                Controls.Add(secondTabControl);
            }
            else
            {
                Controls.Add(firstTabControl);
                Controls.Remove(backButton);
                Controls.Remove(saveButton);
                Controls.Remove(saveAllButton);
                Controls.Remove(secondTabControl);
            }
            

        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string textToSave;
            var tab = secondTabControl.SelectedIndex;
            switch(tab)
            {
                case 0:
                    textToSave = messageRichTextBox.Text;break;
                case 1:
                    textToSave = privateKeyRichTextBox.Text;break;
                case 2:
                    textToSave = publicKeyRichTextBox.Text;break;
                default:
                    textToSave = "Wiadomość:\n\n" + messageRichTextBox.Text + "\n\nKlucz prywatny:\n\n" + privateKeyRichTextBox.Text + "\n\nKlucz publiczny\n\n" + publicKeyRichTextBox.Text + "\n\n"; break;
            }
            saveFile(textToSave, saveFileDialog.FileName);

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }
        private void saveAllFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            var textToSave = "Wiadomosc:\n\n" + messageRichTextBox.Text + "\n\nKlucz prywatny:\n\n" + privateKeyRichTextBox.Text + "\n\nKlucz publiczny:\n\n" + publicKeyRichTextBox.Text + "\n\n";
            saveFile(textToSave, saveAllFileDialog.FileName);
            
        }
        private void saveFile(string textToSave, string fileName)
        {
            TextWriter file = new StreamWriter(fileName);
            file.Write(textToSave);
            file.Close();
            saveFileDialog.FileName = String.Empty;
        }
        private void saveAllButton_Click(object sender, EventArgs e)
        {
            saveAllFileDialog.ShowDialog();
        }
    }
}

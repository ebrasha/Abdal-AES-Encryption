using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abdal_Security_Group_App
{
    public partial class Abdal_AES_Encryption : Telerik.WinControls.UI.RadForm
    {
        public Abdal_AES_Encryption()
        {
            InitializeComponent();
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            Text = "Abdal AES Encryption" + " " + version.Major + "." + version.Minor; //change form title
        }

        private void EncryptToggleSwitch_ValueChanged(object sender, EventArgs e)
        {
            if (EncryptToggleSwitch.Value == true)
            {
                DecryptToggleSwitch.Value = false;
            }
            else
            {
                DecryptToggleSwitch.Value = true;
            }
        }

        private void DecryptToggleSwitch_ValueChanged(object sender, EventArgs e)
        {
            if (DecryptToggleSwitch.Value == true)
            {
                EncryptToggleSwitch.Value = false;
            }
            else
            {
                EncryptToggleSwitch.Value = true;
            }
        }

        private void EncDecButton_Click(object sender, EventArgs e)
        {


            try{

                if (StringTextEditor.Text != "" && SecretKeyTextBox.Text != "")
                {

                    Chilkat.Crypt2 crypt = new Chilkat.Crypt2();



                    // AES 		
                    crypt.CryptAlgorithm = "aes";

                    // CipherMode may be "ecb", "cbc", "ofb", "cfb", "gcm", etc.
                    // Note: Check the online reference documentation to see the Chilkat versions
                    // when certain cipher modes were introduced.
                    crypt.CipherMode = cipherModeMenu.Text;

                    // KeyLength may be 128, 192, 256
                    crypt.KeyLength = Convert.ToInt32(keyLengthDropDownList.Text);

                    // The padding scheme determines the contents of the bytes
                    // that are added to pad the result to a multiple of the
                    // encryption algorithm's block size.  AES has a block
                    // size of 16 bytes, so encrypted output is always
                    // a multiple of 16.
                    crypt.PaddingScheme = 0;

                    // EncodingMode specifies the encoding of the output for
                    // encryption, and the input for decryption.
                    // It may be "hex", "url", "base64", or "quoted-printable".
                     

                    crypt.EncodingMode = encodingModeDropDownList.Text;

                    // An initialization vector is required if using CBC mode.
                    // ECB mode does not use an IV.
                    // The length of the IV is equal to the algorithm's block size.
                    // It is NOT equal to the length of the key.
                    string ivHex = "000102030405060708090A0B0C0D0E0F";
                    crypt.SetEncodedIV(ivHex, "hex");

                    string keyHex = crypt.HashStringENC(SecretKeyTextBox.Text);

                    // The secret key must equal the size of the key.  For
                    // 256-bit encryption, the binary secret key is 32 bytes.
                    // For 128-bit encryption, the binary secret key is 16 bytes.
//                    string keyHex = "000102030405060708090A0B0C0D0E0F101112131415161718191A1B1C1D1E1F";
                    crypt.SetEncodedKey(keyHex, "hex");
                    crypt.Charset = "utf-8";
                    string encStr = "";
                    string decStr = "";

                    if (EncryptToggleSwitch.Value == true)
                    {
                        // Encrypt
                        radProgressBar1.Value2 = 0;
                        encStr = crypt.EncryptStringENC(StringTextEditor.Text);
                        ResultTextEditor.Text = encStr;
                        radProgressBar1.Value2 = 100;


                        
                        this.radDesktopAlert1.CaptionText = "Abdal AES Encryption";
                        this.radDesktopAlert1.ContentText = "Encryption has been successful.";
                        this.radDesktopAlert1.Show();


                    }
                    else
                    {
                        // Now decrypt:
                        radProgressBar1.Value2 = 0;
                        decStr = crypt.DecryptStringENC(StringTextEditor.Text);
                        ResultTextEditor.Text = decStr;
                        radProgressBar1.Value2 = 100;
                        this.radDesktopAlert1.CaptionText = "Abdal AES Encryption";
                        this.radDesktopAlert1.ContentText = "Decryption has been successful.";
                        this.radDesktopAlert1.Show();

                    }

                }
                else
                {
                    MessageBox.Show("The String and Secret Password fields must be filled");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            
           

            


        }

        private void Abdal_2Key_Triple_DES_Builder_Load(object sender, EventArgs e)
        {
            // Call Global Chilkat Unlock
            Abdal_Security_Group_App.GlobalUnlockChilkat GlobalUnlock = new Abdal_Security_Group_App.GlobalUnlockChilkat();
            GlobalUnlock.unlock();
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void randButton_Click(object sender, EventArgs e)
        {

            SecretKeyTextBox.Text = RandomString(25);

        }
    }
}

using DukptNet;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TDESDUKPTTool.Extensions;

namespace TDESDUKPTTool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Form Events


        private void btnANSIKey_Click(object sender, EventArgs e)
        {
            // ANSI x9.24 Annex A test key
            txtBDK.Text = "0123456789ABCDEFFEDCBA9876543210";
        }

        private void btnANSIKSN_Click(object sender, EventArgs e)
        {
            // KSN with ANSI x9.24 Annex A test KSI
            txtKSN.Text = "FFFF9876543210E00001";
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove all white space
                string encryptedData = Regex.Replace(txtEncryptedData.Text, @"\s+", "");

                // Convert HEX string to bytes
                byte[] encryptedBytes = encryptedData.HexStringToByteArray();

                // Decrypt data
                byte[] decryptedBytes = Dukpt.Decrypt(txtBDK.Text, txtKSN.Text, encryptedBytes, rbPINVariant.Checked);

                // Convert bytes to ASCII string
                string decryptedString = Encoding.ASCII.GetString(decryptedBytes);

                txtDecryptedData.Text = decryptedString;
            }
            catch
            {
                MessageBox.Show("Failed to decrypt data!\nDouble check the BDK, KSN, and encrypted data values.", "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert ASCII string to bytes
                byte[] decryptedBytes = Encoding.ASCII.GetBytes(txtDecryptedData.Text.Trim());

                // Encrypt data
                byte[] encryptedBytes = Dukpt.Encrypt(txtBDK.Text, txtKSN.Text, decryptedBytes, rbPINVariant.Checked);

                // Convert encrypted bytes to ASCII string of HEX
                string encryptedString = encryptedBytes.ToHexString();

                txtEncryptedData.Text = encryptedString;
            }
            catch
            {
                MessageBox.Show("Failed to encrypt data!\nDouble check the BDK, KSN, and encrypted data values.", "Encryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiBDKKeyPartTool_Click(object sender, EventArgs e)
        {
            frmKeyPartTool kpt = new frmKeyPartTool();
            kpt.Show();
        }

        private void txtBDK_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.IgnoreNonHexKeyPress();
        }

        private void txtKSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.IgnoreNonHexKeyPress();
        }

        private void txtEncryptedData_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.IgnoreNonHexKeyPress();
        }

        private void lnkWikipediaDUKPT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Derived_unique_key_per_transaction");
        }

        private void lnkKeyVariants_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://stackoverflow.com/questions/39775824/difference-between-pin-encryption-key-variant-and-data-encryption-key-variant");
        }

        #endregion
    }
}

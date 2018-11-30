using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TDESDUKPTTool.Extensions;

namespace TDESDUKPTTool
{
    public partial class frmKeyPartTool : Form
    {
        public frmKeyPartTool()
        {
            InitializeComponent();
        }

        #region Form Events

        private void btnAddKeyPart_Click(object sender, EventArgs e)
        {
            txtKeyPart.Text = txtKeyPart.Text.RemoveNonHexChars();
            if (!txtKeyPart.Text.IsValidHex())
            {
                MessageBox.Show("Key part entered is not valid hexadecimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((lbKeyParts.Items.Count > 0) && (txtKeyPart.Text.Length != lbKeyParts.Items[0].ToString().Length))
            {
                MessageBox.Show("All key parts must be the same length.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbKeyParts.Items.Add(txtKeyPart.Text);
            txtKeyPart.Text = string.Empty;
            txtKeyPart.Focus();
            XORKeyParts();
        }

        private void btnDeleteKeyPart_Click(object sender, EventArgs e)
        {
            if (lbKeyParts.SelectedIndex > -1)
            {
                lbKeyParts.Items.RemoveAt(lbKeyParts.SelectedIndex);
                txtKey.Text = string.Empty;
                XORKeyParts();
            }
        }

        private void txtKeyPart_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.IgnoreNonHexKeyPress();
        }

        #endregion

        #region Methods

        /// <summary>
        /// XOR together all key parts entered
        /// </summary>
        private void XORKeyParts()
        {
            try
            {
                if (lbKeyParts.Items.Count < 2)
                {
                    return;
                }

                List<byte[]> keyParts = new List<byte[]>();
                foreach (string keyPart in lbKeyParts.Items)
                {
                    byte[] keyPartBytes = keyPart.HexStringToByteArray();
                    keyParts.Add(keyPartBytes);
                }

                byte[] bdk = XORKeyParts(keyParts);

                txtKey.Text = bdk.ToHexString();
            }
            catch
            {
                MessageBox.Show("Error combining key parts.\nDouble check all key parts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// XOR list of byte arrays together
        /// </summary>
        /// <param name="keyParts">List of byte arrays</param>
        /// <returns>Resuling array of all byte arrays XOR-ed together</returns>
        private static byte[] XORKeyParts(List<byte[]> keyParts)
        {
            byte[] keyBytes = new byte[keyParts[0].Length];

            for (int i = 0; i < keyParts.Count; i++)
            {
                byte[] keyPart = keyParts[i];
                keyBytes = XORArrays(keyBytes, keyPart);
            }

            return keyBytes;
        }


        /// <summary>
        /// XOR 2 arrays of bytes together
        /// </summary>
        /// <param name="a">Byte Array</param>
        /// <param name="b">Byte Array</param>
        /// <returns>Resulting array of byte arrays a and b XOR-ed together</returns>
        private static byte[] XORArrays(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
            {
                return null;
            }

            byte[] result = new byte[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                result[i] = (byte)(a[i] ^ b[i]);
            }

            return result;
        }

        #endregion

    }
}

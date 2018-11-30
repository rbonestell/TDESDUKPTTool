using System.Windows.Forms;

namespace TDESDUKPTTool.Extensions
{
    public static class FormExtensions
    {

        /// <summary>
        /// Key press event handler for ignoring non-hexadecimal characters on KeyPressEventArgs objects
        /// </summary>
        public static void IgnoreNonHexKeyPress(this KeyPressEventArgs e)
        {
            bool ignoreKeyPress = (e.KeyChar != 8); // Allow Backspace
            ignoreKeyPress &= (Control.ModifierKeys != Keys.Control); // Allow CTRL sequences
            ignoreKeyPress &= !System.Uri.IsHexDigit(e.KeyChar); // Allow hexadecimal characters
            e.Handled = ignoreKeyPress;
        }

    }
}

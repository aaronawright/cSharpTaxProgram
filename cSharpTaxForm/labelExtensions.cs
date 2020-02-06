using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpTaxForm
{
    public static class labelExtensions // add extra funcions to labels
    {
        public static void clearError(this Label lbl) // clear formatting
        {
            lbl.ForeColor = System.Drawing.Color.Black; // reset to black
            lbl.Text = lbl.Text.Replace("*", ""); // remove asterisk
        }
        public static bool showError(this Label lbl, ref List<string> errors) // clear formatting; passes a reference to the error list
        {
            lbl.ForeColor = System.Drawing.Color.Red; // show as red
            errors.Add(lbl.Text); // add this field to the error list
            lbl.Text += "*"; // add asterisk
            return false; // return false simple so we can put on the same line as the `success` variable
        }
    }
}

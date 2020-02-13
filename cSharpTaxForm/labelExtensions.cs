using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpTaxForm
{
    /*
    Note:
    Originally I did not have the application automatically correct invalid input and so these errors
    messages would get displayed.

    After adding the input correction handling these error handling functions never really get
    used, but I am leaving them in the code.
    */
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

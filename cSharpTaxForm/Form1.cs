using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpTaxForm
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // default values


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // default values
            comboBoxMaritalStatus.SelectedIndex = 0;
            comboBoxPayPeriod.SelectedIndex = 0;
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            /* error handling */
            bool success = true; // whether there were any errors
            List<string> errorFields = new List<string>(); // list of fields which have an error
            List<Label> fieldLabels = new List<Label> { labelGross, labelDependents, labelMaritalStatus, labelPayPeriod }; // input labels

            /* init input variables */
            PaycheckCalculation calculation;
            string name = "";
            double grossPay = 0.0;
            int dependents = 0;
            PaycheckCalculation.maritalStatusOptions maritalStatus;
            PaycheckCalculation.payPeriodOptions payPeriod;

            /* results */
            double[] resultData;

            /* clear errors */
            foreach (Label lbl in fieldLabels)
            {
                lbl.clearError();
            }

            /* gather input */
            name = ""; // not used in this version?       
            if (double.TryParse(textBoxGrossPay.Text, out grossPay) == false) // try to parse gross pay
            {
                success = labelGross.showError(ref errorFields);
            }
            if (int.TryParse(textBoxDependents.Text, out dependents) == false) // try to parse dependents
            {
                success = labelDependents.showError(ref errorFields);
            }
            else // check if max dependents has been reached
            {
                dependents = dependents > 10 ? 10 : dependents;
            }
            if (Enum.TryParse(comboBoxMaritalStatus.Text, true /* ignore case */, out maritalStatus) == false) // try to parse marital status
            {
                success = labelMaritalStatus.showError(ref errorFields);
            }
            if (Enum.TryParse(comboBoxPayPeriod.Text, true /* ignore case */, out payPeriod) == false)// try to parse pay period
            {
                success = labelPayPeriod.showError(ref errorFields);
            }

            /* success or failure */

            if (success)
            {
                calculation = new PaycheckCalculation(name, grossPay, dependents, maritalStatus, payPeriod); // pass input to constructor
                calculation.calculate(); // perform calculations
                resultData = calculation.getResults(); // extract results for output

                // display the results
                textBoxResultGross.Text = resultData[0].ToString("0.00");
                textBoxResultFederal.Text = resultData[1].ToString("0.00");
                textBoxSocial.Text = resultData[2].ToString("0.00");
                textBoxResultMedicare.Text = resultData[3].ToString("0.00");
                textBoxResultNet.Text = resultData[4].ToString("0.00");

            }
            else // there was some issue with an input
            {
                // Debug.WriteLine(string.Join(",", errorFields.ToArray()));
                // show some error messages
            }


        }

        private void textBoxGrossPay_Leave(object sender, EventArgs e)
        {
            // make sure data is numeric
        }

        private void textBoxDependents_Leave(object sender, EventArgs e)
        {
            // make sure data is numeric
        }
    }
}

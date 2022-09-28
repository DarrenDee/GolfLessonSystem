using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace GolfLessonSystem
{
    public partial class frmProAdd : Form
    {
        frmMainMenu parent;
        OracleConnection conn = new OracleConnection(DBConnect.oradb);

        public frmProAdd()
        {
            InitializeComponent();
            this.txtID.Text += Professional.getNextProdID().ToString("0000");

        }


        public frmProAdd(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            this.txtID.Text += Professional.getNextProdID().ToString("0000");

        }


        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {


            //validate the input

            if (txtForename.Text.Equals(""))
            {
                MessageBox.Show("Forename must be entered");
                txtForename.Focus();
                return;
            }

            //https://social.msdn.microsoft.com/Forums/vstudio/en-US/3de780d3-8fc0-41db-9bee-2fbfe6feebf1/possible-to-tell-if-a-string-contains-a-number?forum=csharpgeneral
            if (txtForename.Text.Any(c => char.IsDigit(c)))
            {
                MessageBox.Show("Forename can not contain numbers");
                txtForename.Focus();
                return;
            }

            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Surname must be entered");
                txtSurname.Focus();
                return;
            }

            //https://social.msdn.microsoft.com/Forums/vstudio/en-US/3de780d3-8fc0-41db-9bee-2fbfe6feebf1/possible-to-tell-if-a-string-contains-a-number?forum=csharpgeneral
            if (txtSurname.Text.Any(c => char.IsDigit(c)))
            {
                MessageBox.Show("Surname can not contain numbers");
                txtSurname.Focus();
                return;
            }

            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Email must be entered");
                txtEmail.Focus();
                return;
            }


            if (txtPhone.Text.Equals(""))
            {
                MessageBox.Show("Phone Number must be entered");
                txtPhone.Focus();
                return;
            }

            //https://social.msdn.microsoft.com/Forums/vstudio/en-US/3de780d3-8fc0-41db-9bee-2fbfe6feebf1/possible-to-tell-if-a-string-contains-a-number?forum=csharpgeneral
            if (txtPhone.Text.Any(c => char.IsLetter(c)))
            {
                MessageBox.Show("Phone Number must only contain numbers");
                txtPhone.Focus();
                return;
            }

            if (txtPhone.Text.Length != 10)
            {
                MessageBox.Show("Phone Number must be 10 digits");
                txtPhone.Focus();
                return;
            }


            if (txtFee.Text.Equals(""))
            {
                MessageBox.Show("Fee must be entered");
                txtFee.Focus();
                return;
            }

            if (txtFee.Text.Any(c => char.IsLetter(c)))
            {
                MessageBox.Show("Fee must be numeric");
                txtFee.Focus();
                return;
            }









            //create instance of product and instantiate with values from form
            //int proId , string forename, string surname, string email, string phone, decimal fee , string status
            Professional aProfessional = new Professional(Convert.ToInt32(txtID.Text), txtForename.Text, txtSurname.Text, txtEmail.Text, txtPhone.Text, Convert.ToDecimal(txtFee.Text), "R");


            //invoke method to add data
            aProfessional.addPro();

            //Display confirmation message
            MessageBox.Show("Registration Confirmed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //reset UI
            txtForename.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtSurname.Text = "";
            txtFee.Text = "";

            this.txtID.Text = Professional.getNextProdID().ToString("0000");

        }

        private void frmProAdd_Load(object sender, EventArgs e)
        {

        }
    }
}

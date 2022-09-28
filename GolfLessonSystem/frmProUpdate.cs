using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolfLessonSystem
{
    public partial class frmProUpdate : Form
    {

        frmMainMenu parent;
        public frmProUpdate()
        {
            int maxId = Professional.getNextProdID();
            InitializeComponent();
        }



        public frmProUpdate(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

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

            double fees = Double.Parse(txtFee.Text);
            Professional aProfessional = new Professional(Convert.ToInt32(txtID.Text), txtForename.Text, txtSurname.Text, txtEmail.Text, txtPhone.Text, Convert.ToDecimal(txtFee.Text), "R");

            aProfessional.UpdatePro();
            //Professional.UpdatePro(txtForename.Text, txtSurname.Text, txtEmail.Text, txtPhone.Text, fees);

            //Display Confirmation
            MessageBox.Show("Update Confirmed");
            //Reset UI         
            grpUpdateInfo.Visible = false;


        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboSelectID_SelectedIndexChanged(object sender, EventArgs e)
        {

            String name = cboProName.SelectedItem.ToString();
            var names = name.Split(' ');
            String proIdString = names[0];
            int proId = Int32.Parse(proIdString);
            String forename = names[1];
            String surname = names[2];
            DataSet ds = Professional.loadPro(proId);



            grpUpdateInfo.Visible = true;

            txtID.Text = (ds.Tables[0].Rows[0][0].ToString().PadLeft(3));
            txtForename.Text = (ds.Tables[0].Rows[0][1].ToString().PadLeft(3));
            txtSurname.Text = (ds.Tables[0].Rows[0][2].ToString().PadLeft(3));
            txtEmail.Text = (ds.Tables[0].Rows[0][3].ToString().PadLeft(3));
            txtPhone.Text = (ds.Tables[0].Rows[0][4].ToString().PadLeft(3));
            txtFee.Text = (ds.Tables[0].Rows[0][5].ToString().PadLeft(3));
            txtStatus.Text = (ds.Tables[0].Rows[0][6].ToString().PadLeft(3));

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            // int id = cboProName.SelectedIndex;
            grpUpdateInfo.Visible = true;
            //txtID.Text = cboSelectID.SelectedIndex;
        }

        private void frmProUpdate_Load(object sender, EventArgs e)
        {
            DataSet ds = Professional.getAllPros();


            for (int i = 0; i < ds.Tables["Pros"].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i][6].ToString() == "R")
                {
                    cboProName.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][2].ToString());
                }
            }
        }
    }
}

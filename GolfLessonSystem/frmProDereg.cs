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
    public partial class frmProDereg : Form
    {

        frmMainMenu parent;
        String proIdString;
        public frmProDereg()
        {
            InitializeComponent();
        }

        public frmProDereg(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void frmProDereg_Load(object sender, EventArgs e)
        {
            DataSet ds = Professional.getAllPros();


            for (int i = 0; i < ds.Tables["Pros"].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i][6].ToString() == "R")
                {
                    cboSelectID.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][2].ToString());
                }
                }
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btmSubmit_Click(object sender, EventArgs e)
        {
  
            
        }

        private void cboSelectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = cboSelectID.SelectedItem.ToString();
            var names = name.Split(' ');
            proIdString = names[0];
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

        private void txtSubmit_Click(object sender, EventArgs e)
        {
            Professional aProfessional = new Professional(Convert.ToInt32(txtID.Text), txtForename.Text, txtSurname.Text, txtEmail.Text, txtPhone.Text, Convert.ToDecimal(txtFee.Text), "R");
            DataSet dp = Lessons.loadTimesPro(proIdString);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to De-Register this professional", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            

            if (dialogResult == DialogResult.Yes)
            {

                //make sure that this pro has no upcoming lessons
                int AfterDate = 0;
                for (int i = 0; i < dp.Tables[0].Rows.Count; i++) {
                    if (DateTime.Compare(DateTime.Parse(dp.Tables[0].Rows[i][3].ToString()), DateTime.Now )> 0)
                    {
                        AfterDate++;
                    }
                        }

                if (AfterDate == 0)
                {
                    MessageBox.Show("Selected Pro has been De-Registered");
                    aProfessional.DeRegPro();
                }
                else
                {
                   MessageBox.Show("This Pro has a upcoming lesson and can not be de-registered", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Selected Pro Is still registered");
            }

            grpUpdateInfo.Visible = false;
        }
    }
}

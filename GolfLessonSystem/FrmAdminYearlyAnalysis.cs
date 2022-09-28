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
    public partial class FrmAdminYearlyAnalysis : Form
    {

        frmMainMenu parent;
        string year = "";
        public FrmAdminYearlyAnalysis()
        {
            InitializeComponent();

        }
        public FrmAdminYearlyAnalysis(frmMainMenu Parent)
        {
            InitializeComponent();


            parent = Parent;
        }

        private void cboPickYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            year = cboPickYear.SelectedItem.ToString();
            chtData.Titles.Clear();
            chtData.Titles.Add("Yearly Revenue " + cboPickYear.Text.ToString());
            chtData.Visible = true;

            DataSet dt = Admin.getYearlyAnalysis(year);
            //Array size 12 since there are 12 months in a year
            string[] Months = new string[12];
            decimal[] Amounts = new decimal[12];

            for (int i = 0; i < 12; i++)
            {
                if (dt.Tables[0].Rows.Count < 12)
                {
                    Months[i] = getMonth(i+1);
                    Amounts[i] = 0;
                }
                else
                {
                    Months[i] = getMonth(Convert.ToInt32(dt.Tables[0].Rows[i][1]));
                    Amounts[i] = Convert.ToDecimal(dt.Tables[0].Rows[i][0]);
                }
                }


            for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
            {
                Amounts[Convert.ToInt32(dt.Tables[0].Rows[i][1]) - 1] = Convert.ToDecimal(dt.Tables[0].Rows[i][0]);
            }
            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.Series[0].LegendText = "Income in €";
            chtData.Series[0].Points.DataBindXY(Months, Amounts);
            chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
            //chtSales.Series[0].Points[0] = "XXX";
            chtData.Series[0].Label = "#VALY";
            //chtData.Titles.Add("Yearly Revenue ");
            chtData.Visible = true;

        }

        private void FrmAdminYearlyAnalysis_Load(object sender, EventArgs e)
        {
            
            
            cboPickYear.Items.Add(DateTime.Today.Year - 3);
            cboPickYear.Items.Add(DateTime.Today.Year -2);
            cboPickYear.Items.Add(DateTime.Today.Year -1);
            cboPickYear.Items.Add(DateTime.Today.Year);
        }
        public String getMonth(int month)
        {
            switch (month)
            {
                case 1:
                    {
                        return "JAN";
                    }
                case 2:
                    {
                        return "FEB";
                    }
                case 3:
                    {
                        return "MAR";
                    }
                case 4:
                    {
                        return "APR";
                    }
                case 5:
                    {
                        return "MAY";
                    }
                case 6:
                    {
                        return "JUN";
                    }
                case 7:
                    {
                        return "JUL";
                    }
                case 8:
                    {
                        return "AUG";
                    }
                case 9:
                    {
                        return "SEP";
                    }
                case 10:
                    {
                        return "OCT";
                    }
                case 11:
                    {
                        return "NOV";
                    }
                case 12:
                    {
                        return "DEC";
                    }
                default: {
                        return "OTH";
                        }
            }
        
    

    }




 

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}

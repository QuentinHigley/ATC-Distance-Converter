using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            String strFrom, strTo;

            double dblOutput, dblInput;
            dblInput = Convert.ToDouble(txtInput.Text);
            
            
            if (lstFrom.SelectedIndex != -1)
            {
                strFrom = lstFrom.SelectedItem.ToString();
                switch (strFrom)
                {
                    case "Inches":
                        strFrom = "Inches";
                        break;
                    case "Feet":
                        strFrom = "Feet";
                        break;
                    case "Yard":
                        strFrom = "Yard";
                        break;
                }
                if (lstTo.SelectedIndex != -1)
                {
                    strTo = lstTo.SelectedItem.ToString();
                    switch (strTo)
                    {
                        case "Inches":
                            strTo = "Inches";
                            break;
                        case "Feet":
                            strTo = "Feet";
                            break;
                        case "Yard":
                            strTo = "Yards";
                            break;
                    }
                    if (strFrom == "Inches" && strTo == "Inches" || strFrom == "Inches" && strTo == "Inches")
                    {
                        lblOut.Text = dblInput.ToString("n2");
                    }
                    else if (strFrom == "Feet" && strTo == "Feet" || strFrom == "Feet" && strTo == "Feet")
                    {
                        lblOut.Text = dblInput.ToString("n2");
                    }
                    else if (strFrom == "Yards" && strTo == "Yards" || strFrom == "Yards" && strTo == "Yards")
                    {
                        lblOut.Text = dblInput.ToString("n2");
                    }
                    else if (strFrom == "Feet" && strTo == "Inches")
                    {
                        dblOutput = dblInput * 12;
                        lblOut.Text = dblOutput.ToString("n2");
                    }
                    else if (strFrom == "Yards" && strTo == "Inches")
                    {
                        dblOutput = dblInput * 36;
                        lblOut.Text = dblOutput.ToString("n2");
                    }
                    else if (strFrom == "Yards" && strTo == "Feet")
                    {
                        dblOutput = dblInput * 3;
                        lblOut.Text = dblOutput.ToString("n2");
                    }
                    else if (strFrom == "Inches" && strTo == "Feet")
                    {
                        dblOutput = dblInput / 12;
                        lblOut.Text = dblOutput.ToString("n2");
                    }
                    else if (strFrom == "Inches" && strTo == "Yards")
                    {
                        dblOutput = dblInput / 36;
                        lblOut.Text = dblOutput.ToString("n2");
                    }
                    else if (strFrom == "Feet" && strTo == "Yards")
                    {
                        dblOutput = dblInput / 3;
                        lblOut.Text = dblOutput.ToString("n2");
                    }

                }
                else
                {
                    MessageBox.Show("please select an item");
                }
            }
            else
            {
                MessageBox.Show("please select an item");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

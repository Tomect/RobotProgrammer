using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RobotProgrammer
{
    public partial class Keypad : Form
    {
        int intMin = 0;
        int intMax = 99999;

        public frmMain frmMain;

        public Keypad(string units, frmMain Parent)
        {
            InitializeComponent();

            frmMain = Parent;
            lblUnit.Text = units;

            txtResponse.Text = intMin.ToString();

            this.TopMost = true;
        }

        public Keypad(string units, int Value, frmMain Parent)
        {
            InitializeComponent();

            frmMain = Parent;
            lblUnit.Text = units;

            txtResponse.Text = Value.ToString();

            this.TopMost = true;
        }

        public Keypad(string units, frmMain Parent, int Min, int Max)
        {
            InitializeComponent();

            frmMain = Parent;
            lblUnit.Text = units;
            intMax = Max;
            intMin = Min;

            txtResponse.Text = intMin.ToString();

            this.TopMost = true;
        }

        public Keypad(string units, int Value, frmMain Parent, int Min, int Max)
        {
            InitializeComponent();

            frmMain = Parent;
            lblUnit.Text = units;
            intMax = Max;
            intMin = Min;

            txtResponse.Text = Value.ToString();

            this.TopMost = true;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            frmMain.intKeypadReturn = -1;
            frmMain.bolKeypadReturn = true;

            // Close the form
            this.Close();
            this.Dispose();
        }

        private void cmdAccept_Click(object sender, EventArgs e)
        {
            // Check the value is acceptable
            int intReturn = -1;
            if (!int.TryParse(txtResponse.Text, out intReturn)) intReturn = -1;
            
            // Indicate the form has returned a value
            frmMain.bolKeypadReturn = true;
            frmMain.intKeypadReturn = intReturn;

            // Close the form
            this.Close();
            this.Dispose();
        }

        private void Keypad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Keypad_Shown(object sender, EventArgs e)
        {
            cmdAccept.Focus();
        }

        private void cmdAccept_KeyPress(object sender, KeyPressEventArgs e)
        {
            int intIsNumber = 0;

            if (e.KeyChar == (char)Keys.Back)
            {
                if (txtResponse.Text.Length == 1)
                {
                    txtResponse.Text = "0";
                }
                else
                {
                    txtResponse.Text = txtResponse.Text.Substring(0, txtResponse.Text.Length - 1);
                }
            }

            if (int.TryParse(e.KeyChar.ToString(), out intIsNumber))
            {
                if (txtResponse.Text == "0")
                {
                    txtResponse.Text = e.KeyChar.ToString();
                }
                else
                {
                    txtResponse.Text += e.KeyChar.ToString();
                }
            }
            e.Handled = true;
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            if (txtResponse.Text == "0")
            {
                txtResponse.Text = "1";
            }
            else
            {
                txtResponse.Text += "1";
            }
            cmdAccept.Focus();
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            if (txtResponse.Text == "0")
            {
                txtResponse.Text = "2";
            }
            else
            {
                txtResponse.Text += "2";
            }
            cmdAccept.Focus();
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            if (txtResponse.Text == "0")
            {
                txtResponse.Text = "3";
            }
            else
            {
                txtResponse.Text += "3";
            }
            cmdAccept.Focus();
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            if (txtResponse.Text == "0")
            {
                txtResponse.Text = "4";
            }
            else
            {
                txtResponse.Text += "4";
            }
            cmdAccept.Focus();
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            if (txtResponse.Text == "0")
            {
                txtResponse.Text = "5";
            }
            else
            {
                txtResponse.Text += "5";
            }
            cmdAccept.Focus();
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            if (txtResponse.Text == "0")
            {
                txtResponse.Text = "6";
            }
            else
            {
                txtResponse.Text += "6";
            }
            cmdAccept.Focus();
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            if (txtResponse.Text == "0")
            {
                txtResponse.Text = "7";
            }
            else
            {
                txtResponse.Text += "7";
            }
            cmdAccept.Focus();
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            if (txtResponse.Text == "0")
            {
                txtResponse.Text = "8";
            }
            else
            {
                txtResponse.Text += "8";
            }
            cmdAccept.Focus();
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            if (txtResponse.Text == "0")
            {
                txtResponse.Text = "9";
            }
            else
            {
                txtResponse.Text += "9";
            }
            cmdAccept.Focus();
        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            if (txtResponse.Text != "0")
            {
                txtResponse.Text += "0";
            }
            cmdAccept.Focus();
        }

        private void txtResponse_Click(object sender, EventArgs e)
        {
            cmdAccept.Focus();
        }

        private void Keypad_Load(object sender, EventArgs e)
        {
            cmdAccept.Focus();
        }

        private void txtResponse_TextChanged(object sender, EventArgs e)
        {
            int intResponse = -1;

            if (int.TryParse(txtResponse.Text, out intResponse))
            {
                if (intResponse < intMin) txtResponse.Text = intMin.ToString();
                if (intResponse > intMax) txtResponse.Text = intMax.ToString();
            }
        }
    }
}

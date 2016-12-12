using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblOutputQ2.Visible = false;

            Int32 txtBox1, txtBox2;

            Boolean formOk = true;

            if (Int32.TryParse(txtBoxNumber1.Text, out txtBox1) == false)
            {
                lblOutputQ2.Visible = true;
                formOk = false;
            }
            else
            {
                lblOutputQ2.Text = GetNumber(txtBox1);
            }

            if (Int32.TryParse(txtBoxNumber2.Text, out txtBox2) == false)
            {
                lblOutputQ2.Visible = true;
                formOk = false;
            }
            else
            {
                lblOutputQ2.Text = GetNumber(txtBox2);
            }

            if (formOk == true)
            {

            }

        }
        private void multiplyNumbers(object sender, EventArgs e)
        {
            Int32 number1 = Convert.ToInt32(txtBoxNumber1.Text);
            Int32 number2 = Convert.ToInt32(txtBoxNumber2.Text);
            Int32 total = (number1 * number2);
            lblOutputQ2 = total.ToString();


            String[] group = new String[3];

            group[0] = "Merry";
            group[1] = "Christmas";
            group[2] = "C# is great";


            for (var i = 0; i < group.Length; i++)
            {
                Console.WriteLine(group[i]);
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
        }
        private String getPassword(String months)
        {

            lbl4Incorrect.Visible = false;

            Int32 txtPassword;

            String password = "frosty";

            Boolean formOk = true;

            if (Int32.TryParse(txtPassword.Text, out password) == false)
            {
                lbl4Incorrect.Visible = true;
                formOk = false;
            }
            else
            {
                lbl4Incorrect.Text = getPassword(password);
            }

            if (Int32.TryParse(txtPassword.Text, out password) == false)
            {
                lbl4Correct.Visible = true;
                formOk = false;
            }
            else
            {
                lbl4Correct.Text = getPassword(password);
            }

            if (formOk == true)
            {

            }
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            String[] movies = new String[3];

            movies[0] = "How the Grinch Stole Christmas / 1966";
            movies[1] = "Frosty the Snowman / 1969";
            movies[2] = "Arthur Christmas / 2011";

            for (var i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }
        }

        private void btnShowMonths_Click(object sender, EventArgs e)
        {
        }
        private String GetMonths(String months)
        {
            String getMonths = months;

            String cboBoxMonths = "";

            String cboBoxSeasons = "";

            if (cboBoxSeasons == "Spring")
            {
                cboBoxMonths = "March, April, May";
            }
            else if (cboBoxSeasons == "Summer")
            {
                cboBoxMonths = "June, July, August";
            }
            else if (cboBoxSeasons == "Fall")
            {
                cboBoxMonths = "September, October, November";
            }
            else if (cboBoxSeasons == "Winter")
            {
                cboBoxMonths = "December, January, February";
            }
            return cboBoxMonths;

        }
    }

    private void btnQuestion7_Click(object sender, EventArgs e)
    {
        Double x = 4;
        Double y = 12;

        Int32 result = (4 / 12);

        var lblQ7 = result;
    }
}

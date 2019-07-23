using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ApiApp
{
    public partial class FormApiApp : Form
    {
        public FormApiApp()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"[\D]");
            Match m = reg.Match(httpReqTxt.Text);

            if (httpReqTxt.Text == "" || m.Success)
            {
                MessageBox.Show("Invalid input, please capture a valid number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ApiApp.RequestMethods.GetMethods getAll = new ApiApp.RequestMethods.GetMethods();

                actualResultLbl.Text = getAll.GetHttpCode("http://numbersapi.com/" + httpReqTxt.Text).ToString();
                txtReqBody.Text = getAll.GetHttpBody("http://numbersapi.com/" + httpReqTxt.Text).ToString();

                rbtnDate.Checked = false;
                rbtnYear.Checked = false;
                rbtnMath.Checked = false;
                rbtnTrivia.Checked = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            httpReqTxt.Clear();
            txtReqBody.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApiApp.RequestMethods.GetMethods getAll = new ApiApp.RequestMethods.GetMethods();
            httpReqTxt.Clear();

            if (rbtnDate.Checked == false & rbtnMath.Checked == false & rbtnTrivia.Checked == false & rbtnYear.Checked == false)
            {
                MessageBox.Show("No selection has been made. Choose a random fact by selecting one of the options.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rbtnTrivia.Checked == true)
            {
                actualResultLbl.Text = getAll.GetHttpCode("http://numbersapi.com/random/trivia").ToString();
                txtReqBody.Text = getAll.GetHttpBody("http://numbersapi.com/random/trivia");
            }
            else if (rbtnMath.Checked == true)
            {
                actualResultLbl.Text = getAll.GetHttpCode("http://numbersapi.com/random/math").ToString();
                txtReqBody.Text = getAll.GetHttpBody("http://numbersapi.com/random/math".ToString());
            }
            else if (rbtnDate.Checked == true)
            {
                actualResultLbl.Text = getAll.GetHttpCode("http://numbersapi.com/random/date").ToString();
                txtReqBody.Text = getAll.GetHttpBody("http://numbersapi.com/random/date").ToString();
            }
            else if (rbtnYear.Checked == true)
            {
                actualResultLbl.Text = getAll.GetHttpCode("http://numbersapi.com/random/year").ToString();
                txtReqBody.Text = getAll.GetHttpBody("http://numbersapi.com/random/year").ToString();
            }
        }
    }
}

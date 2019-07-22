using System;
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
            ApiApp.RequestMethods.GetMethods getAll = new ApiApp.RequestMethods.GetMethods();          
            actualResultLbl.Text = getAll.GetHttpCode("http://numbersapi.com/"+httpReqTxt.Text).ToString();
            txtReqBody.Text = getAll.GetHttpBody("http://numbersapi.com/" + httpReqTxt.Text).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            httpReqTxt.Clear();
            txtReqBody.Clear();
        }
    }
}

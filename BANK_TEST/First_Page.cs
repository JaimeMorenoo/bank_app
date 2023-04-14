using System.Security.Cryptography;

namespace BANK_TEST
{
    public partial class First_Page : Form
    {
        public First_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateUser_Form frm = new CreateUser_Form();
           
            frm.Show();
            

        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            Login_Form frm = new Login_Form();
            frm.Show();
        }
    }
}
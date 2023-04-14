using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BANK_TEST
{
    public partial class CreateUser_Form : Form
    {
        private string connectionString = "datasource=127.0.0.1;" +
           "port= 3306;" +
           " username=root;"
           + " password= Jupo2011!;" +
           "database = bank_test";

        private MySqlConnection Connection { get; set; }
        

        public CreateUser_Form()
        {
            InitializeComponent();
            this.Connection = new MySqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           

            if (name_textbox.Text != "" && surname_textbox.Text != "")
            {
                user registered_user = new user(name_textbox.Text, surname_textbox.Text, password_textbox.Text, email_textbox.Text);
              
                DateTime datetest = date_textbox.Value;
                string date_formatted = datetest.ToString("yyyy/MM/dd");

                string gender = groupBox1.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked).Text;



                string query = $"INSERT INTO `bank_test`.`test` (`name`, `surname`,`email`,`password`,`gender`,`dob`)" +
                    $" VALUES ('{registered_user.Name}','{registered_user.Surname}','{registered_user.email}','{registered_user.Password}','{gender}','{date_formatted}')";
                MySqlCommand commandDatabase = new MySqlCommand(query, this.Connection);




                try
                {
                    this.Connection.Open();
                    int result = commandDatabase.ExecuteNonQuery();
                    this.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                this.Close();

            }
            else
            {
                MessageBox.Show("Fill all the boxes");
            }
            



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime datetest = date_textbox.Value;
            string tesssst = datetest.ToString("yyy--mm-dd");
            string gender = groupBox1.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked).Text;
            MessageBox.Show(gender);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }


    }
}

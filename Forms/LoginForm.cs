using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Админ
                if (passwordTextBox.Text == "321")
                {
                    Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                //Персонал
                else if (passwordTextBox.Text == "123")
                {
                    Hide();
                    PersonnelForm personnelForm = new PersonnelForm();
                    personnelForm.Show();
                }
                else
                {
                    MessageBox.Show("Невірний код");
                }
            }
        }
    }
}

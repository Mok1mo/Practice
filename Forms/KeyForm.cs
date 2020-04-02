using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practice.Forms
{
    public partial class KeyForm : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB.mdb";
        private OleDbConnection myConnection = new OleDbConnection(connectString);

        //Массив паролей
        string[] pass = new string[3];

        public KeyForm()
        {
            InitializeComponent();

        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                myConnection.Open();

                String query = "SELECT Пароль FROM Admins WHERE id = 1";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                pass[0] = command.ExecuteScalar().ToString();

                query = "SELECT Пароль FROM Admins WHERE id = 2";
                command = new OleDbCommand(query, myConnection);
                pass[1] = command.ExecuteScalar().ToString();

                query = "SELECT Пароль FROM Admins WHERE id = 3";
                command = new OleDbCommand(query, myConnection);
                pass[2] = command.ExecuteScalar().ToString();

                if (passwordTextBox.Text == pass[0] || passwordTextBox.Text == pass[1] || passwordTextBox.Text == pass[2])
                {
                    System.Diagnostics.Process.Start("Table.xls");
                    //Закрываем подключение к БД
                    myConnection.Close();
                    Close();
                }
                else
                {
                    MessageBox.Show("Невірний пароль");
                }
            }
            //Закрываем подключение к БД
            myConnection.Close();
        }
    }
}

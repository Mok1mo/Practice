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
    public partial class AdminForm : PersonnelForm
    {
        //private OleDbConnection myConnection = new OleDbConnection(connectString);

        public AdminForm()
        {
            InitializeComponent();

            ////Подключение к БД
            //myConnection.Open();
        }

        private void tableLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Table.xls");
        }
    }
}

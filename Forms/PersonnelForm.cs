using Practice.Forms;
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
    public partial class PersonnelForm : Form
    {
        public PersonnelForm()
        {
            InitializeComponent();
        }

        public TablesForm TablesForm
        {
            get => default(TablesForm);
            set
            {
            }
        }

        public KeyForm KeyForm
        {
            get => default(KeyForm);
            set
            {
            }
        }

        private void tableLabel_Click(object sender, EventArgs e)
        {
            TablesForm tablesForm = new TablesForm();
            tablesForm.Show();
        }

        private void patternsLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Doc.docx");
        }

        private void PersonnelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tablesLabel_Click(object sender, EventArgs e)
        {
            KeyForm keyForm = new KeyForm();
            keyForm.Show();
        }
    }

}

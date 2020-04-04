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
    public partial class TablesForm : Form
    {
        public TablesForm()
        {
            InitializeComponent();
           
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if(tabControl.SelectedIndex == 0)
                    {
                        for (int i = 0; i < workersDataGridView.RowCount; i++)
                        {
                            if (workersDataGridView[0, i].Value.ToString() == searchTextBox.Text)
                            {
                                workersDataGridView.CurrentCell = workersDataGridView[0, i];
                                break;
                            }
                        }
                    }
                    if(tabControl.SelectedIndex == 1)
                    {
                        for (int i = 0; i < studentsDataGridView.RowCount; i++)
                        {
                            if (studentsDataGridView[0, i].Value.ToString() == searchTextBox.Text)
                            {
                                studentsDataGridView.CurrentCell = studentsDataGridView[0, i];
                                break;
                            }
                        }
                    }
                    if(tabControl.SelectedIndex == 2)
                    {
                        for (int i = 0; i < conscriptsDataGridView.RowCount; i++)
                        {
                            if (conscriptsDataGridView[0, i].Value.ToString() == searchTextBox.Text)
                            {
                                conscriptsDataGridView.CurrentCell = conscriptsDataGridView[0, i];
                                break;
                            }
                        }
                    }
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show("Запис не знайдено :(");
                }
            }
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Введіть прізвище")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.Black;
            }
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                searchTextBox.Text = "Введіть прізвище";
                searchTextBox.ForeColor = Color.Gray;
            }
        }

        private void PersonnelResultForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Conscripts' table. You can move, or remove it, as needed.
            this.conscriptsTableAdapter.Fill(this.dBDataSet.Conscripts);
            // TODO: This line of code loads data into the 'dBDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.dBDataSet.Students);
            // TODO: This line of code loads data into the 'dBDataSet.Personnel' table. You can move, or remove it, as needed.
            this.personnelTableAdapter.Fill(this.dBDataSet.Personnel);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            const string message = "Зберегти зміни?";
            const string caption = "Збереження";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                if (tabControl.SelectedIndex == 0)
                {
                    personnelTableAdapter.Update(dBDataSet);
                }
                if (tabControl.SelectedIndex == 1)
                {
                    studentsTableAdapter.Update(dBDataSet);
                }
                if (tabControl.SelectedIndex == 2)
                {
                    conscriptsTableAdapter.Update(dBDataSet);
                }
            }
        }
        //DElETE
        private void workersDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void studentsDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void conscriptsDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void tabControl_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                this.Width = workersDataGridView.Width;
            }
            if (tabControl.SelectedIndex == 1)
            {
                this.Width = studentsDataGridView.Width;
            }
            if (tabControl.SelectedIndex == 2)
            {
                this.Width = conscriptsDataGridView.Width;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

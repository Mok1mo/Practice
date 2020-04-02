namespace Practice
{
    partial class TablesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        protected void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.припискаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНародженняDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.прізвищеDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBDataSet = new Practice.DBDataSet();
            this.conscriptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conscriptsTableAdapter = new Practice.DBDataSetTableAdapters.ConscriptsTableAdapter();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelTableAdapter = new Practice.DBDataSetTableAdapters.PersonnelTableAdapter();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Practice.DBDataSetTableAdapters.StudentsTableAdapter();
            this.прізвищеDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.спеціалізаціяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.факультетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.групаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНародженняDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.містоселоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.місцеПропискиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersDataGridView = new System.Windows.Forms.DataGridView();
            this.прізвищеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категоріяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колишняРоботаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кваліфікаціяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.посадаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНародженняDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conscriptsDataGridView = new System.Windows.Forms.DataGridView();
            this.прізвищеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНародженняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.припискаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conscriptsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conscriptsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.ForeColor = System.Drawing.Color.Gray;
            this.searchTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(250, 29);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.Text = "Введіть прізвище";
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.saveButton);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(884, 53);
            this.searchPanel.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkCyan;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(722, 11);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 29);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Зберегти";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(884, 302);
            this.tabControl.TabIndex = 1;
            this.tabControl.TabIndexChanged += new System.EventHandler(this.tabControl_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.workersDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Працівники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.studentsDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Студенти";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.conscriptsDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(876, 276);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Військовозобов\'язані";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.tabControl);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataPanel.Location = new System.Drawing.Point(0, 59);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(884, 302);
            this.dataPanel.TabIndex = 3;
            // 
            // припискаDataGridViewTextBoxColumn
            // 
            this.припискаDataGridViewTextBoxColumn.DataPropertyName = "Приписка";
            this.припискаDataGridViewTextBoxColumn.HeaderText = "Приписка";
            this.припискаDataGridViewTextBoxColumn.Name = "припискаDataGridViewTextBoxColumn";
            this.припискаDataGridViewTextBoxColumn.Width = 82;
            // 
            // датаНародженняDataGridViewTextBoxColumn2
            // 
            this.датаНародженняDataGridViewTextBoxColumn2.DataPropertyName = "ДатаНародження";
            this.датаНародженняDataGridViewTextBoxColumn2.HeaderText = "ДатаНародження";
            this.датаНародженняDataGridViewTextBoxColumn2.Name = "датаНародженняDataGridViewTextBoxColumn2";
            this.датаНародженняDataGridViewTextBoxColumn2.Width = 122;
            // 
            // імяDataGridViewTextBoxColumn2
            // 
            this.імяDataGridViewTextBoxColumn2.DataPropertyName = "Ім\'я";
            this.імяDataGridViewTextBoxColumn2.HeaderText = "Ім\'я";
            this.імяDataGridViewTextBoxColumn2.Name = "імяDataGridViewTextBoxColumn2";
            this.імяDataGridViewTextBoxColumn2.Width = 51;
            // 
            // прізвищеDataGridViewTextBoxColumn2
            // 
            this.прізвищеDataGridViewTextBoxColumn2.DataPropertyName = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn2.HeaderText = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn2.Name = "прізвищеDataGridViewTextBoxColumn2";
            this.прізвищеDataGridViewTextBoxColumn2.Width = 81;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.Width = 40;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conscriptsBindingSource
            // 
            this.conscriptsBindingSource.DataMember = "Conscripts";
            this.conscriptsBindingSource.DataSource = this.dBDataSet;
            // 
            // conscriptsTableAdapter
            // 
            this.conscriptsTableAdapter.ClearBeforeFill = true;
            // 
            // personnelBindingSource
            // 
            this.personnelBindingSource.DataMember = "Personnel";
            this.personnelBindingSource.DataSource = this.dBDataSet;
            // 
            // personnelTableAdapter
            // 
            this.personnelTableAdapter.ClearBeforeFill = true;
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AutoGenerateColumns = false;
            this.studentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.прізвищеDataGridViewTextBoxColumn3,
            this.імяDataGridViewTextBoxColumn3,
            this.спеціалізаціяDataGridViewTextBoxColumn,
            this.факультетDataGridViewTextBoxColumn,
            this.групаDataGridViewTextBoxColumn,
            this.датаНародженняDataGridViewTextBoxColumn3,
            this.містоселоDataGridViewTextBoxColumn,
            this.місцеПропискиDataGridViewTextBoxColumn});
            this.studentsDataGridView.DataSource = this.studentsBindingSource;
            this.studentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.Size = new System.Drawing.Size(870, 270);
            this.studentsDataGridView.TabIndex = 0;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.dBDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // прізвищеDataGridViewTextBoxColumn3
            // 
            this.прізвищеDataGridViewTextBoxColumn3.DataPropertyName = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn3.HeaderText = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn3.Name = "прізвищеDataGridViewTextBoxColumn3";
            // 
            // імяDataGridViewTextBoxColumn3
            // 
            this.імяDataGridViewTextBoxColumn3.DataPropertyName = "Ім\'я";
            this.імяDataGridViewTextBoxColumn3.HeaderText = "Ім\'я";
            this.імяDataGridViewTextBoxColumn3.Name = "імяDataGridViewTextBoxColumn3";
            // 
            // спеціалізаціяDataGridViewTextBoxColumn
            // 
            this.спеціалізаціяDataGridViewTextBoxColumn.DataPropertyName = "Спеціалізація";
            this.спеціалізаціяDataGridViewTextBoxColumn.HeaderText = "Спеціалізація";
            this.спеціалізаціяDataGridViewTextBoxColumn.Name = "спеціалізаціяDataGridViewTextBoxColumn";
            // 
            // факультетDataGridViewTextBoxColumn
            // 
            this.факультетDataGridViewTextBoxColumn.DataPropertyName = "Факультет";
            this.факультетDataGridViewTextBoxColumn.HeaderText = "Факультет";
            this.факультетDataGridViewTextBoxColumn.Name = "факультетDataGridViewTextBoxColumn";
            // 
            // групаDataGridViewTextBoxColumn
            // 
            this.групаDataGridViewTextBoxColumn.DataPropertyName = "Група";
            this.групаDataGridViewTextBoxColumn.HeaderText = "Група";
            this.групаDataGridViewTextBoxColumn.Name = "групаDataGridViewTextBoxColumn";
            // 
            // датаНародженняDataGridViewTextBoxColumn3
            // 
            this.датаНародженняDataGridViewTextBoxColumn3.DataPropertyName = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn3.HeaderText = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn3.Name = "датаНародженняDataGridViewTextBoxColumn3";
            // 
            // містоселоDataGridViewTextBoxColumn
            // 
            this.містоселоDataGridViewTextBoxColumn.DataPropertyName = "Місто/село";
            this.містоселоDataGridViewTextBoxColumn.HeaderText = "Місто/село";
            this.містоселоDataGridViewTextBoxColumn.Name = "містоселоDataGridViewTextBoxColumn";
            // 
            // місцеПропискиDataGridViewTextBoxColumn
            // 
            this.місцеПропискиDataGridViewTextBoxColumn.DataPropertyName = "Місце прописки";
            this.місцеПропискиDataGridViewTextBoxColumn.HeaderText = "Місце прописки";
            this.місцеПропискиDataGridViewTextBoxColumn.Name = "місцеПропискиDataGridViewTextBoxColumn";
            // 
            // workersDataGridView
            // 
            this.workersDataGridView.AutoGenerateColumns = false;
            this.workersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.прізвищеDataGridViewTextBoxColumn1,
            this.імяDataGridViewTextBoxColumn1,
            this.категоріяDataGridViewTextBoxColumn,
            this.колишняРоботаDataGridViewTextBoxColumn,
            this.кваліфікаціяDataGridViewTextBoxColumn,
            this.посадаDataGridViewTextBoxColumn,
            this.датаНародженняDataGridViewTextBoxColumn1});
            this.workersDataGridView.DataSource = this.personnelBindingSource;
            this.workersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.workersDataGridView.Name = "workersDataGridView";
            this.workersDataGridView.Size = new System.Drawing.Size(870, 270);
            this.workersDataGridView.TabIndex = 0;
            // 
            // прізвищеDataGridViewTextBoxColumn1
            // 
            this.прізвищеDataGridViewTextBoxColumn1.DataPropertyName = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn1.HeaderText = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn1.Name = "прізвищеDataGridViewTextBoxColumn1";
            // 
            // імяDataGridViewTextBoxColumn1
            // 
            this.імяDataGridViewTextBoxColumn1.DataPropertyName = "Ім\'я";
            this.імяDataGridViewTextBoxColumn1.HeaderText = "Ім\'я";
            this.імяDataGridViewTextBoxColumn1.Name = "імяDataGridViewTextBoxColumn1";
            // 
            // категоріяDataGridViewTextBoxColumn
            // 
            this.категоріяDataGridViewTextBoxColumn.DataPropertyName = "Категорія";
            this.категоріяDataGridViewTextBoxColumn.HeaderText = "Категорія";
            this.категоріяDataGridViewTextBoxColumn.Name = "категоріяDataGridViewTextBoxColumn";
            // 
            // колишняРоботаDataGridViewTextBoxColumn
            // 
            this.колишняРоботаDataGridViewTextBoxColumn.DataPropertyName = "Колишня робота";
            this.колишняРоботаDataGridViewTextBoxColumn.HeaderText = "Колишня робота";
            this.колишняРоботаDataGridViewTextBoxColumn.Name = "колишняРоботаDataGridViewTextBoxColumn";
            // 
            // кваліфікаціяDataGridViewTextBoxColumn
            // 
            this.кваліфікаціяDataGridViewTextBoxColumn.DataPropertyName = "Кваліфікація";
            this.кваліфікаціяDataGridViewTextBoxColumn.HeaderText = "Кваліфікація";
            this.кваліфікаціяDataGridViewTextBoxColumn.Name = "кваліфікаціяDataGridViewTextBoxColumn";
            // 
            // посадаDataGridViewTextBoxColumn
            // 
            this.посадаDataGridViewTextBoxColumn.DataPropertyName = "Посада";
            this.посадаDataGridViewTextBoxColumn.HeaderText = "Посада";
            this.посадаDataGridViewTextBoxColumn.Name = "посадаDataGridViewTextBoxColumn";
            // 
            // датаНародженняDataGridViewTextBoxColumn1
            // 
            this.датаНародженняDataGridViewTextBoxColumn1.DataPropertyName = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn1.HeaderText = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn1.Name = "датаНародженняDataGridViewTextBoxColumn1";
            // 
            // conscriptsDataGridView
            // 
            this.conscriptsDataGridView.AutoGenerateColumns = false;
            this.conscriptsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.conscriptsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conscriptsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.прізвищеDataGridViewTextBoxColumn,
            this.імяDataGridViewTextBoxColumn,
            this.датаНародженняDataGridViewTextBoxColumn,
            this.припискаDataGridViewTextBoxColumn1});
            this.conscriptsDataGridView.DataSource = this.conscriptsBindingSource;
            this.conscriptsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conscriptsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.conscriptsDataGridView.Name = "conscriptsDataGridView";
            this.conscriptsDataGridView.Size = new System.Drawing.Size(870, 270);
            this.conscriptsDataGridView.TabIndex = 0;
            // 
            // прізвищеDataGridViewTextBoxColumn
            // 
            this.прізвищеDataGridViewTextBoxColumn.DataPropertyName = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn.Name = "прізвищеDataGridViewTextBoxColumn";
            // 
            // імяDataGridViewTextBoxColumn
            // 
            this.імяDataGridViewTextBoxColumn.DataPropertyName = "Ім\'я";
            this.імяDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.імяDataGridViewTextBoxColumn.Name = "імяDataGridViewTextBoxColumn";
            // 
            // датаНародженняDataGridViewTextBoxColumn
            // 
            this.датаНародженняDataGridViewTextBoxColumn.DataPropertyName = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn.Name = "датаНародженняDataGridViewTextBoxColumn";
            // 
            // припискаDataGridViewTextBoxColumn1
            // 
            this.припискаDataGridViewTextBoxColumn1.DataPropertyName = "Приписка";
            this.припискаDataGridViewTextBoxColumn1.HeaderText = "Приписка";
            this.припискаDataGridViewTextBoxColumn1.Name = "припискаDataGridViewTextBoxColumn1";
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.searchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TablesForm";
            this.Text = "Таблиці";
            this.Load += new System.EventHandler(this.PersonnelResultForm_Load);
            this.searchPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conscriptsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conscriptsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn припискаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНародженняDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn прізвищеDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource conscriptsBindingSource;
        private DBDataSetTableAdapters.ConscriptsTableAdapter conscriptsTableAdapter;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private DBDataSetTableAdapters.PersonnelTableAdapter personnelTableAdapter;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private DBDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridView workersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn прізвищеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn категоріяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колишняРоботаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кваліфікаціяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn посадаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНародженняDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn прізвищеDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn спеціалізаціяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn факультетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn групаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНародженняDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn містоселоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn місцеПропискиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView conscriptsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn прізвищеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНародженняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn припискаDataGridViewTextBoxColumn1;
    }
}
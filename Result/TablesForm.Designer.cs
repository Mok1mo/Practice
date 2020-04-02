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
            this.workersDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.conscriptsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.припискаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНародженняDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.прізвищеDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dBDataSet = new Practice.DBDataSet();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelTableAdapter = new Practice.DBDataSetTableAdapters.PersonnelTableAdapter();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Practice.DBDataSetTableAdapters.StudentsTableAdapter();
            this.conscriptsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conscriptsTableAdapter = new Practice.DBDataSetTableAdapters.ConscriptsTableAdapter();
            this.прізвищеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категоріяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колишняРоботаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кваліфікаціяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.посадаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНародженняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.прізвищеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.спеціалізаціяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.факультетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.групаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНародженняDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.містоселоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.місцеПропискиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.прізвищеDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНародженняDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.припискаДоВоєнкоматуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conscriptsDataGridView)).BeginInit();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conscriptsBindingSource)).BeginInit();
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
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.workersDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Працівники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // workersDataGridView
            // 
            this.workersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.workersDataGridView.Name = "workersDataGridView";
            this.workersDataGridView.Size = new System.Drawing.Size(870, 270);
            this.workersDataGridView.TabIndex = 0;
            this.workersDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.workersDataGridView_UserDeletingRow);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.studentsDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Студенти";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.Size = new System.Drawing.Size(870, 270);
            this.studentsDataGridView.TabIndex = 1;
            this.studentsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.studentsDataGridView_UserDeletingRow);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.conscriptsDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(876, 276);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Військовозобов\'язані";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // conscriptsDataGridView
            // 
            this.conscriptsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.conscriptsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conscriptsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conscriptsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.conscriptsDataGridView.Name = "conscriptsDataGridView";
            this.conscriptsDataGridView.Size = new System.Drawing.Size(870, 270);
            this.conscriptsDataGridView.TabIndex = 1;
            this.conscriptsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.conscriptsDataGridView_UserDeletingRow);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.прізвищеDataGridViewTextBoxColumn,
            this.імяDataGridViewTextBoxColumn,
            this.категоріяDataGridViewTextBoxColumn,
            this.колишняРоботаDataGridViewTextBoxColumn,
            this.кваліфікаціяDataGridViewTextBoxColumn,
            this.посадаDataGridViewTextBoxColumn,
            this.датаНародженняDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personnelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(870, 270);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.прізвищеDataGridViewTextBoxColumn1,
            this.імяDataGridViewTextBoxColumn1,
            this.спеціалізаціяDataGridViewTextBoxColumn,
            this.факультетDataGridViewTextBoxColumn,
            this.групаDataGridViewTextBoxColumn,
            this.датаНародженняDataGridViewTextBoxColumn1,
            this.містоселоDataGridViewTextBoxColumn,
            this.місцеПропискиDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.studentsBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(870, 270);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.прізвищеDataGridViewTextBoxColumn3,
            this.імяDataGridViewTextBoxColumn3,
            this.датаНародженняDataGridViewTextBoxColumn3,
            this.припискаДоВоєнкоматуDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.conscriptsBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(870, 270);
            this.dataGridView3.TabIndex = 2;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.dBDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
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
            // датаНародженняDataGridViewTextBoxColumn
            // 
            this.датаНародженняDataGridViewTextBoxColumn.DataPropertyName = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn.Name = "датаНародженняDataGridViewTextBoxColumn";
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
            // датаНародженняDataGridViewTextBoxColumn1
            // 
            this.датаНародженняDataGridViewTextBoxColumn1.DataPropertyName = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn1.HeaderText = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn1.Name = "датаНародженняDataGridViewTextBoxColumn1";
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
            // датаНародженняDataGridViewTextBoxColumn3
            // 
            this.датаНародженняDataGridViewTextBoxColumn3.DataPropertyName = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn3.HeaderText = "Дата народження";
            this.датаНародженняDataGridViewTextBoxColumn3.Name = "датаНародженняDataGridViewTextBoxColumn3";
            // 
            // припискаДоВоєнкоматуDataGridViewTextBoxColumn
            // 
            this.припискаДоВоєнкоматуDataGridViewTextBoxColumn.DataPropertyName = "Приписка до воєнкомату";
            this.припискаДоВоєнкоматуDataGridViewTextBoxColumn.HeaderText = "Приписка до воєнкомату";
            this.припискаДоВоєнкоматуDataGridViewTextBoxColumn.Name = "припискаДоВоєнкоматуDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.conscriptsDataGridView)).EndInit();
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conscriptsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        protected System.Windows.Forms.DataGridView workersDataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Button saveButton;
        protected System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        protected System.Windows.Forms.DataGridView conscriptsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn припискаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНародженняDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn прізвищеDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private DBDataSetTableAdapters.PersonnelTableAdapter personnelTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private DBDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource conscriptsBindingSource;
        private DBDataSetTableAdapters.ConscriptsTableAdapter conscriptsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn прізвищеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категоріяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колишняРоботаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кваліфікаціяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn посадаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНародженняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn прізвищеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn спеціалізаціяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn факультетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn групаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНародженняDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn містоселоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn місцеПропискиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn прізвищеDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНародженняDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn припискаДоВоєнкоматуDataGridViewTextBoxColumn;
    }
}
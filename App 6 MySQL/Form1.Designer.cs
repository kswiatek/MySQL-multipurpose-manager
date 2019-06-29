namespace App_6_MySQL
{
    partial class Form1
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_NewDatabase = new System.Windows.Forms.TabPage();
            this.btn_createNewDatabase = new System.Windows.Forms.Button();
            this.tB_newDatabaseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_removeSelectedTable = new System.Windows.Forms.Button();
            this.lB_addedTables = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addNewTable = new System.Windows.Forms.Button();
            this.tB_newTableName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl_ExistingDatabase = new System.Windows.Forms.TabControl();
            this.tabPage_chooseDatabase = new System.Windows.Forms.TabPage();
            this.btn_refreshAvailableDatabases = new System.Windows.Forms.Button();
            this.btn_chooseThisDatabase = new System.Windows.Forms.Button();
            this.lb_receivedDataBases = new System.Windows.Forms.Label();
            this.lB_availableDatabases = new System.Windows.Forms.ListBox();
            this.tabPage_readDatabase = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_currentTableSelected = new System.Windows.Forms.ComboBox();
            this.btn_refreshGridView = new System.Windows.Forms.Button();
            this.dataGridView_ReadDatabase = new System.Windows.Forms.DataGridView();
            this.tabPage_modifyDatabase = new System.Windows.Forms.TabPage();
            this.btn_discardChanges = new System.Windows.Forms.Button();
            this.btn_saveChanges = new System.Windows.Forms.Button();
            this.cB_tableToModify = new System.Windows.Forms.ComboBox();
            this.dataGridView_modifyTable = new System.Windows.Forms.DataGridView();
            this.tabPage_modifyStructure = new System.Windows.Forms.TabPage();
            this.btn_addNewTables = new System.Windows.Forms.Button();
            this.btn_removeSelectedRow = new System.Windows.Forms.Button();
            this.btn_removeSelectedColumn = new System.Windows.Forms.Button();
            this.btn_deleteCurrentDatabase = new System.Windows.Forms.Button();
            this.cB_tableToDelete = new System.Windows.Forms.ComboBox();
            this.btn_addNewColumn = new System.Windows.Forms.Button();
            this.dataGridView_modifyStructure = new System.Windows.Forms.DataGridView();
            this.btn_deleteChosenTable = new System.Windows.Forms.Button();
            this.lb_connectedDatabase = new System.Windows.Forms.Label();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_NewDatabase.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl_ExistingDatabase.SuspendLayout();
            this.tabPage_chooseDatabase.SuspendLayout();
            this.tabPage_readDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReadDatabase)).BeginInit();
            this.tabPage_modifyDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_modifyTable)).BeginInit();
            this.tabPage_modifyStructure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_modifyStructure)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Main.Controls.Add(this.tabPage_NewDatabase);
            this.tabControl_Main.Controls.Add(this.tabPage2);
            this.tabControl_Main.Location = new System.Drawing.Point(12, 12);
            this.tabControl_Main.MinimumSize = new System.Drawing.Size(481, 316);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(481, 316);
            this.tabControl_Main.TabIndex = 2;
            // 
            // tabPage_NewDatabase
            // 
            this.tabPage_NewDatabase.Controls.Add(this.btn_createNewDatabase);
            this.tabPage_NewDatabase.Controls.Add(this.tB_newDatabaseName);
            this.tabPage_NewDatabase.Controls.Add(this.label1);
            this.tabPage_NewDatabase.Controls.Add(this.groupBox1);
            this.tabPage_NewDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabPage_NewDatabase.Name = "tabPage_NewDatabase";
            this.tabPage_NewDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NewDatabase.Size = new System.Drawing.Size(473, 290);
            this.tabPage_NewDatabase.TabIndex = 0;
            this.tabPage_NewDatabase.Text = "Nowa baza danych";
            this.tabPage_NewDatabase.UseVisualStyleBackColor = true;
            // 
            // btn_createNewDatabase
            // 
            this.btn_createNewDatabase.Location = new System.Drawing.Point(23, 86);
            this.btn_createNewDatabase.Name = "btn_createNewDatabase";
            this.btn_createNewDatabase.Size = new System.Drawing.Size(147, 42);
            this.btn_createNewDatabase.TabIndex = 2;
            this.btn_createNewDatabase.Text = "Utwórz";
            this.btn_createNewDatabase.UseVisualStyleBackColor = true;
            this.btn_createNewDatabase.Click += new System.EventHandler(this.btn_createNewDatabase_Click);
            // 
            // tB_newDatabaseName
            // 
            this.tB_newDatabaseName.Location = new System.Drawing.Point(23, 47);
            this.tB_newDatabaseName.Name = "tB_newDatabaseName";
            this.tB_newDatabaseName.Size = new System.Drawing.Size(425, 20);
            this.tB_newDatabaseName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa bazy danych:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_removeSelectedTable);
            this.groupBox1.Controls.Add(this.lB_addedTables);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_addNewTable);
            this.groupBox1.Controls.Add(this.tB_newTableName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(23, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 118);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodawanie tabel";
            // 
            // btn_removeSelectedTable
            // 
            this.btn_removeSelectedTable.Location = new System.Drawing.Point(127, 70);
            this.btn_removeSelectedTable.Name = "btn_removeSelectedTable";
            this.btn_removeSelectedTable.Size = new System.Drawing.Size(105, 23);
            this.btn_removeSelectedTable.TabIndex = 8;
            this.btn_removeSelectedTable.Text = "Usuń";
            this.btn_removeSelectedTable.UseVisualStyleBackColor = true;
            this.btn_removeSelectedTable.Click += new System.EventHandler(this.btn_removeSelectedTable_Click);
            // 
            // lB_addedTables
            // 
            this.lB_addedTables.FormattingEnabled = true;
            this.lB_addedTables.Items.AddRange(new object[] {
            "*pusta baza*"});
            this.lB_addedTables.Location = new System.Drawing.Point(258, 32);
            this.lB_addedTables.Name = "lB_addedTables";
            this.lB_addedTables.Size = new System.Drawing.Size(150, 69);
            this.lB_addedTables.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dodane tabele:";
            // 
            // btn_addNewTable
            // 
            this.btn_addNewTable.Location = new System.Drawing.Point(9, 70);
            this.btn_addNewTable.Name = "btn_addNewTable";
            this.btn_addNewTable.Size = new System.Drawing.Size(112, 23);
            this.btn_addNewTable.TabIndex = 7;
            this.btn_addNewTable.Text = "Dodaj";
            this.btn_addNewTable.UseVisualStyleBackColor = true;
            this.btn_addNewTable.Click += new System.EventHandler(this.btn_addNewTable_Click);
            // 
            // tB_newTableName
            // 
            this.tB_newTableName.Location = new System.Drawing.Point(83, 38);
            this.tB_newTableName.Name = "tB_newTableName";
            this.tB_newTableName.Size = new System.Drawing.Size(149, 20);
            this.tB_newTableName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nazwa tabeli:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl_ExistingDatabase);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(473, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Istniejąca baza danych";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl_ExistingDatabase
            // 
            this.tabControl_ExistingDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_ExistingDatabase.Controls.Add(this.tabPage_chooseDatabase);
            this.tabControl_ExistingDatabase.Controls.Add(this.tabPage_readDatabase);
            this.tabControl_ExistingDatabase.Controls.Add(this.tabPage_modifyDatabase);
            this.tabControl_ExistingDatabase.Controls.Add(this.tabPage_modifyStructure);
            this.tabControl_ExistingDatabase.Location = new System.Drawing.Point(6, 6);
            this.tabControl_ExistingDatabase.Name = "tabControl_ExistingDatabase";
            this.tabControl_ExistingDatabase.SelectedIndex = 0;
            this.tabControl_ExistingDatabase.Size = new System.Drawing.Size(461, 278);
            this.tabControl_ExistingDatabase.TabIndex = 0;
            // 
            // tabPage_chooseDatabase
            // 
            this.tabPage_chooseDatabase.Controls.Add(this.btn_refreshAvailableDatabases);
            this.tabPage_chooseDatabase.Controls.Add(this.btn_chooseThisDatabase);
            this.tabPage_chooseDatabase.Controls.Add(this.lb_receivedDataBases);
            this.tabPage_chooseDatabase.Controls.Add(this.lB_availableDatabases);
            this.tabPage_chooseDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabPage_chooseDatabase.Name = "tabPage_chooseDatabase";
            this.tabPage_chooseDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_chooseDatabase.Size = new System.Drawing.Size(453, 252);
            this.tabPage_chooseDatabase.TabIndex = 0;
            this.tabPage_chooseDatabase.Text = "Wybierz bazę danych";
            this.tabPage_chooseDatabase.UseVisualStyleBackColor = true;
            // 
            // btn_refreshAvailableDatabases
            // 
            this.btn_refreshAvailableDatabases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_refreshAvailableDatabases.Location = new System.Drawing.Point(16, 211);
            this.btn_refreshAvailableDatabases.Name = "btn_refreshAvailableDatabases";
            this.btn_refreshAvailableDatabases.Size = new System.Drawing.Size(75, 23);
            this.btn_refreshAvailableDatabases.TabIndex = 3;
            this.btn_refreshAvailableDatabases.Text = "Odśwież";
            this.btn_refreshAvailableDatabases.UseVisualStyleBackColor = true;
            this.btn_refreshAvailableDatabases.Click += new System.EventHandler(this.btn_refreshAvailableDatabases_Click);
            // 
            // btn_chooseThisDatabase
            // 
            this.btn_chooseThisDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_chooseThisDatabase.Enabled = false;
            this.btn_chooseThisDatabase.Location = new System.Drawing.Point(97, 211);
            this.btn_chooseThisDatabase.Name = "btn_chooseThisDatabase";
            this.btn_chooseThisDatabase.Size = new System.Drawing.Size(120, 23);
            this.btn_chooseThisDatabase.TabIndex = 2;
            this.btn_chooseThisDatabase.Text = "Wybierz zaznaczoną";
            this.btn_chooseThisDatabase.UseVisualStyleBackColor = true;
            this.btn_chooseThisDatabase.Click += new System.EventHandler(this.btn_chooseThisDatabase_Click);
            // 
            // lb_receivedDataBases
            // 
            this.lb_receivedDataBases.AutoSize = true;
            this.lb_receivedDataBases.Location = new System.Drawing.Point(17, 19);
            this.lb_receivedDataBases.Name = "lb_receivedDataBases";
            this.lb_receivedDataBases.Size = new System.Drawing.Size(119, 13);
            this.lb_receivedDataBases.TabIndex = 1;
            this.lb_receivedDataBases.Text = "Dostępne bazy danych:";
            // 
            // lB_availableDatabases
            // 
            this.lB_availableDatabases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lB_availableDatabases.FormattingEnabled = true;
            this.lB_availableDatabases.Location = new System.Drawing.Point(16, 45);
            this.lB_availableDatabases.Name = "lB_availableDatabases";
            this.lB_availableDatabases.Size = new System.Drawing.Size(419, 147);
            this.lB_availableDatabases.TabIndex = 0;
            this.lB_availableDatabases.SelectedIndexChanged += new System.EventHandler(this.lB_availableDatabases_SelectedIndexChanged);
            // 
            // tabPage_readDatabase
            // 
            this.tabPage_readDatabase.Controls.Add(this.label2);
            this.tabPage_readDatabase.Controls.Add(this.cB_currentTableSelected);
            this.tabPage_readDatabase.Controls.Add(this.btn_refreshGridView);
            this.tabPage_readDatabase.Controls.Add(this.dataGridView_ReadDatabase);
            this.tabPage_readDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabPage_readDatabase.Name = "tabPage_readDatabase";
            this.tabPage_readDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_readDatabase.Size = new System.Drawing.Size(453, 252);
            this.tabPage_readDatabase.TabIndex = 1;
            this.tabPage_readDatabase.Text = "Odczytaj";
            this.tabPage_readDatabase.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wybierz tabelę:";
            // 
            // cB_currentTableSelected
            // 
            this.cB_currentTableSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cB_currentTableSelected.FormattingEnabled = true;
            this.cB_currentTableSelected.Location = new System.Drawing.Point(208, 223);
            this.cB_currentTableSelected.Name = "cB_currentTableSelected";
            this.cB_currentTableSelected.Size = new System.Drawing.Size(239, 21);
            this.cB_currentTableSelected.TabIndex = 3;
            this.cB_currentTableSelected.SelectedIndexChanged += new System.EventHandler(this.cB_currentTableSelected_SelectedIndexChanged);
            // 
            // btn_refreshGridView
            // 
            this.btn_refreshGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_refreshGridView.Location = new System.Drawing.Point(6, 223);
            this.btn_refreshGridView.Name = "btn_refreshGridView";
            this.btn_refreshGridView.Size = new System.Drawing.Size(99, 23);
            this.btn_refreshGridView.TabIndex = 2;
            this.btn_refreshGridView.Text = "Odśwież";
            this.btn_refreshGridView.UseVisualStyleBackColor = true;
            this.btn_refreshGridView.Click += new System.EventHandler(this.btn_refreshGridView_Click);
            // 
            // dataGridView_ReadDatabase
            // 
            this.dataGridView_ReadDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ReadDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReadDatabase.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_ReadDatabase.Name = "dataGridView_ReadDatabase";
            this.dataGridView_ReadDatabase.Size = new System.Drawing.Size(441, 211);
            this.dataGridView_ReadDatabase.TabIndex = 1;
            // 
            // tabPage_modifyDatabase
            // 
            this.tabPage_modifyDatabase.Controls.Add(this.btn_discardChanges);
            this.tabPage_modifyDatabase.Controls.Add(this.btn_saveChanges);
            this.tabPage_modifyDatabase.Controls.Add(this.cB_tableToModify);
            this.tabPage_modifyDatabase.Controls.Add(this.dataGridView_modifyTable);
            this.tabPage_modifyDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabPage_modifyDatabase.Name = "tabPage_modifyDatabase";
            this.tabPage_modifyDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_modifyDatabase.Size = new System.Drawing.Size(453, 252);
            this.tabPage_modifyDatabase.TabIndex = 2;
            this.tabPage_modifyDatabase.Text = "Modyfikuj";
            this.tabPage_modifyDatabase.UseVisualStyleBackColor = true;
            // 
            // btn_discardChanges
            // 
            this.btn_discardChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_discardChanges.Location = new System.Drawing.Point(106, 223);
            this.btn_discardChanges.Name = "btn_discardChanges";
            this.btn_discardChanges.Size = new System.Drawing.Size(94, 23);
            this.btn_discardChanges.TabIndex = 3;
            this.btn_discardChanges.Text = "Porzuć zmiany";
            this.btn_discardChanges.UseVisualStyleBackColor = true;
            this.btn_discardChanges.Click += new System.EventHandler(this.btn_discardChanges_Click);
            // 
            // btn_saveChanges
            // 
            this.btn_saveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_saveChanges.Location = new System.Drawing.Point(6, 223);
            this.btn_saveChanges.Name = "btn_saveChanges";
            this.btn_saveChanges.Size = new System.Drawing.Size(94, 23);
            this.btn_saveChanges.TabIndex = 2;
            this.btn_saveChanges.Text = "Zapisz zmiany";
            this.btn_saveChanges.UseVisualStyleBackColor = true;
            this.btn_saveChanges.Click += new System.EventHandler(this.btn_saveChanges_Click);
            // 
            // cB_tableToModify
            // 
            this.cB_tableToModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cB_tableToModify.FormattingEnabled = true;
            this.cB_tableToModify.Location = new System.Drawing.Point(213, 223);
            this.cB_tableToModify.Name = "cB_tableToModify";
            this.cB_tableToModify.Size = new System.Drawing.Size(234, 21);
            this.cB_tableToModify.TabIndex = 1;
            this.cB_tableToModify.SelectedIndexChanged += new System.EventHandler(this.cB_tableToModify_SelectedIndexChanged);
            // 
            // dataGridView_modifyTable
            // 
            this.dataGridView_modifyTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_modifyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_modifyTable.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_modifyTable.Name = "dataGridView_modifyTable";
            this.dataGridView_modifyTable.Size = new System.Drawing.Size(441, 211);
            this.dataGridView_modifyTable.TabIndex = 0;
            // 
            // tabPage_modifyStructure
            // 
            this.tabPage_modifyStructure.Controls.Add(this.btn_addNewTables);
            this.tabPage_modifyStructure.Controls.Add(this.btn_removeSelectedRow);
            this.tabPage_modifyStructure.Controls.Add(this.btn_removeSelectedColumn);
            this.tabPage_modifyStructure.Controls.Add(this.btn_deleteCurrentDatabase);
            this.tabPage_modifyStructure.Controls.Add(this.cB_tableToDelete);
            this.tabPage_modifyStructure.Controls.Add(this.btn_addNewColumn);
            this.tabPage_modifyStructure.Controls.Add(this.dataGridView_modifyStructure);
            this.tabPage_modifyStructure.Controls.Add(this.btn_deleteChosenTable);
            this.tabPage_modifyStructure.Location = new System.Drawing.Point(4, 22);
            this.tabPage_modifyStructure.Name = "tabPage_modifyStructure";
            this.tabPage_modifyStructure.Size = new System.Drawing.Size(453, 252);
            this.tabPage_modifyStructure.TabIndex = 3;
            this.tabPage_modifyStructure.Text = "Struktura tabeli";
            this.tabPage_modifyStructure.UseVisualStyleBackColor = true;
            // 
            // btn_addNewTables
            // 
            this.btn_addNewTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addNewTables.Location = new System.Drawing.Point(234, 205);
            this.btn_addNewTables.Name = "btn_addNewTables";
            this.btn_addNewTables.Size = new System.Drawing.Size(213, 32);
            this.btn_addNewTables.TabIndex = 12;
            this.btn_addNewTables.Text = "Dodaj nowe tabele";
            this.btn_addNewTables.UseVisualStyleBackColor = true;
            this.btn_addNewTables.Click += new System.EventHandler(this.btn_addNewTables_Click);
            // 
            // btn_removeSelectedRow
            // 
            this.btn_removeSelectedRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_removeSelectedRow.Location = new System.Drawing.Point(6, 145);
            this.btn_removeSelectedRow.Name = "btn_removeSelectedRow";
            this.btn_removeSelectedRow.Size = new System.Drawing.Size(213, 23);
            this.btn_removeSelectedRow.TabIndex = 11;
            this.btn_removeSelectedRow.Text = "Usuń wiersz";
            this.btn_removeSelectedRow.UseVisualStyleBackColor = true;
            this.btn_removeSelectedRow.Click += new System.EventHandler(this.btn_removeSelectedRow_Click);
            this.btn_removeSelectedRow.MouseEnter += new System.EventHandler(this.btn_removeSelectedRow_MouseEnter);
            this.btn_removeSelectedRow.MouseLeave += new System.EventHandler(this.btn_removeSelectedRow_MouseLeave);
            // 
            // btn_removeSelectedColumn
            // 
            this.btn_removeSelectedColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_removeSelectedColumn.Location = new System.Drawing.Point(234, 145);
            this.btn_removeSelectedColumn.Name = "btn_removeSelectedColumn";
            this.btn_removeSelectedColumn.Size = new System.Drawing.Size(213, 23);
            this.btn_removeSelectedColumn.TabIndex = 10;
            this.btn_removeSelectedColumn.Text = "Usuń kolumnę";
            this.btn_removeSelectedColumn.UseVisualStyleBackColor = true;
            this.btn_removeSelectedColumn.Click += new System.EventHandler(this.btn_removeSelectedColumn_Click);
            this.btn_removeSelectedColumn.MouseEnter += new System.EventHandler(this.btn_removeSelectedColumn_MouseEnter);
            this.btn_removeSelectedColumn.MouseLeave += new System.EventHandler(this.btn_removeSelectedColumn_MouseLeave);
            // 
            // btn_deleteCurrentDatabase
            // 
            this.btn_deleteCurrentDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_deleteCurrentDatabase.Location = new System.Drawing.Point(290, 174);
            this.btn_deleteCurrentDatabase.Name = "btn_deleteCurrentDatabase";
            this.btn_deleteCurrentDatabase.Size = new System.Drawing.Size(157, 23);
            this.btn_deleteCurrentDatabase.TabIndex = 5;
            this.btn_deleteCurrentDatabase.Text = "Usuń aktualną bazę danych";
            this.btn_deleteCurrentDatabase.UseVisualStyleBackColor = true;
            this.btn_deleteCurrentDatabase.Click += new System.EventHandler(this.btn_deleteCurrentDatabase_Click);
            // 
            // cB_tableToDelete
            // 
            this.cB_tableToDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cB_tableToDelete.FormattingEnabled = true;
            this.cB_tableToDelete.Location = new System.Drawing.Point(89, 176);
            this.cB_tableToDelete.Name = "cB_tableToDelete";
            this.cB_tableToDelete.Size = new System.Drawing.Size(186, 21);
            this.cB_tableToDelete.TabIndex = 6;
            this.cB_tableToDelete.SelectedIndexChanged += new System.EventHandler(this.cB_tableToDelete_SelectedIndexChanged);
            // 
            // btn_addNewColumn
            // 
            this.btn_addNewColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addNewColumn.Location = new System.Drawing.Point(6, 205);
            this.btn_addNewColumn.Name = "btn_addNewColumn";
            this.btn_addNewColumn.Size = new System.Drawing.Size(213, 32);
            this.btn_addNewColumn.TabIndex = 9;
            this.btn_addNewColumn.Text = "Dodaj nową kolumnę";
            this.btn_addNewColumn.UseVisualStyleBackColor = true;
            this.btn_addNewColumn.Click += new System.EventHandler(this.btn_addNewColumn_Click);
            // 
            // dataGridView_modifyStructure
            // 
            this.dataGridView_modifyStructure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_modifyStructure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_modifyStructure.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_modifyStructure.Name = "dataGridView_modifyStructure";
            this.dataGridView_modifyStructure.Size = new System.Drawing.Size(441, 133);
            this.dataGridView_modifyStructure.TabIndex = 8;
            // 
            // btn_deleteChosenTable
            // 
            this.btn_deleteChosenTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_deleteChosenTable.Location = new System.Drawing.Point(6, 174);
            this.btn_deleteChosenTable.Name = "btn_deleteChosenTable";
            this.btn_deleteChosenTable.Size = new System.Drawing.Size(77, 23);
            this.btn_deleteChosenTable.TabIndex = 4;
            this.btn_deleteChosenTable.Text = "Usuń tabelę:";
            this.btn_deleteChosenTable.UseVisualStyleBackColor = true;
            this.btn_deleteChosenTable.Click += new System.EventHandler(this.btn_deleteChosenTable_Click_1);
            // 
            // lb_connectedDatabase
            // 
            this.lb_connectedDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_connectedDatabase.AutoSize = true;
            this.lb_connectedDatabase.Location = new System.Drawing.Point(13, 342);
            this.lb_connectedDatabase.Name = "lb_connectedDatabase";
            this.lb_connectedDatabase.Size = new System.Drawing.Size(135, 13);
            this.lb_connectedDatabase.TabIndex = 3;
            this.lb_connectedDatabase.Text = "Podłączona baza danych: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 373);
            this.Controls.Add(this.lb_connectedDatabase);
            this.Controls.Add(this.tabControl_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(521, 412);
            this.Name = "Form1";
            this.Text = "Bazy danych SQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_NewDatabase.ResumeLayout(false);
            this.tabPage_NewDatabase.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl_ExistingDatabase.ResumeLayout(false);
            this.tabPage_chooseDatabase.ResumeLayout(false);
            this.tabPage_chooseDatabase.PerformLayout();
            this.tabPage_readDatabase.ResumeLayout(false);
            this.tabPage_readDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReadDatabase)).EndInit();
            this.tabPage_modifyDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_modifyTable)).EndInit();
            this.tabPage_modifyStructure.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_modifyStructure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_NewDatabase;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl_ExistingDatabase;
        private System.Windows.Forms.TabPage tabPage_chooseDatabase;
        private System.Windows.Forms.TabPage tabPage_readDatabase;
        private System.Windows.Forms.TabPage tabPage_modifyDatabase;
        private System.Windows.Forms.TextBox tB_newDatabaseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_createNewDatabase;
        private System.Windows.Forms.Button btn_chooseThisDatabase;
        private System.Windows.Forms.Label lb_receivedDataBases;
        private System.Windows.Forms.ListBox lB_availableDatabases;
        private System.Windows.Forms.Button btn_refreshAvailableDatabases;
        private System.Windows.Forms.Label lb_connectedDatabase;
        private System.Windows.Forms.DataGridView dataGridView_ReadDatabase;
        private System.Windows.Forms.Button btn_refreshGridView;
        private System.Windows.Forms.ComboBox cB_currentTableSelected;
        private System.Windows.Forms.Button btn_saveChanges;
        private System.Windows.Forms.ComboBox cB_tableToModify;
        private System.Windows.Forms.DataGridView dataGridView_modifyTable;
        private System.Windows.Forms.Button btn_discardChanges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage_modifyStructure;
        private System.Windows.Forms.Button btn_deleteCurrentDatabase;
        private System.Windows.Forms.ComboBox cB_tableToDelete;
        private System.Windows.Forms.Button btn_deleteChosenTable;
        private System.Windows.Forms.DataGridView dataGridView_modifyStructure;
        private System.Windows.Forms.Button btn_removeSelectedRow;
        private System.Windows.Forms.Button btn_removeSelectedColumn;
        private System.Windows.Forms.Button btn_addNewColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lB_addedTables;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_newTableName;
        private System.Windows.Forms.Button btn_addNewTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_removeSelectedTable;
        private System.Windows.Forms.Button btn_addNewTables;
    }
}


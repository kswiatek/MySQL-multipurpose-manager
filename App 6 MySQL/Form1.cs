using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_6_MySQL
{
    public partial class Form1 : Form //Główne okno aplikacji
    {
        public Form1()
        {
            InitializeComponent();
            tabPage_readDatabase.Enabled = false; //tabPage można dać Enabled..
            tabPage_modifyDatabase.Enabled = false; //..choć nie widać że można
            changeModifyStructureTabPageElementsAccessibility(false); 
            btn_addNewTables.Enabled = false;
            tabPage_modifyStructure.Enabled = true;
            Database.ConnectedDatabaseChanged += WhenConnectedDatabaseChange;
            dataGridView_ReadDatabase.ReadOnly = true;
            dataGridView_modifyStructure.ReadOnly = true;
        }

        private bool emptyNewDatabase = true;

        //Widoczność tylko jednego przycisku "addNewTables" jest niezależna
        private void changeModifyStructureTabPageElementsAccessibility(bool value)
        {
            btn_removeSelectedColumn.Enabled = value;
            btn_removeSelectedRow.Enabled = value;
            btn_deleteChosenTable.Enabled = value;
            btn_deleteCurrentDatabase.Enabled = value;
            btn_addNewColumn.Enabled = value;
            cB_tableToDelete.Enabled = value;
        }

        private void btn_createNewDatabase_Click(object sender, EventArgs e)
        {
            if (tB_newDatabaseName.Text != "")
            {
                if (emptyNewDatabase)
                    CreateDatabase.CreateNewDatabase(tB_newDatabaseName.Text);
                else
                {
                    CreateDatabase.CreateNewDatabase(tB_newDatabaseName.Text);
                    CreateDatabase.AddNewTables(lB_addedTables);
                }
                btn_addNewTables.Enabled = true;
            }
            else
                MessageBox.Show("Wprowadź nazwę bazy danych!");
        }

        private void btn_refreshAvailableDatabases_Click(object sender, EventArgs e)
        {
            lB_availableDatabases.Items.Clear();
            ReadDatabase.ShowAvailableDatabases(lB_availableDatabases);
            lb_receivedDataBases.Text = "Dostępne bazy danych: "
                + lB_availableDatabases.Items.Count;
        }

        private void btn_chooseThisDatabase_Click(object sender, EventArgs e)
        {
            if (lB_availableDatabases.SelectedIndex > -1)
            {
                ReadDatabase.ChooseThisDatabase(lB_availableDatabases.SelectedItem.ToString());
                RefreshComboBoxes();
            }
        }

        //Obsługa zdarzenia zmiany wybranej bazy danych (aktu. ścieżki, odświeżanie widoków)
        private void WhenConnectedDatabaseChange(object sender, EventArgs e)
        {
            if (e is DatabaseChangedEventArgs)
            {
                DatabaseChangedEventArgs args = e as DatabaseChangedEventArgs;
                lb_connectedDatabase.Text = "Podłączona baza danych: " + args.DatabaseName;
                Database.IsDatabaseOK = true;
                Database.ExistingFilledRows = 0;
                Database.ConnectionPath =
                    "server=localhost; database=" + args.DatabaseName + "; user=root";
                Database.ConnectedDatabase = args.DatabaseName;
                ClearEverything();
                RefreshComboBoxes();
                if (cB_currentTableSelected.Text != "(brak)")
                {
                    tabPage_readDatabase.Enabled = true;
                    tabPage_modifyDatabase.Enabled = true;
                    changeModifyStructureTabPageElementsAccessibility(true);
                }
                else
                {
                    tabPage_readDatabase.Enabled = false;
                    tabPage_modifyDatabase.Enabled = false;
                    changeModifyStructureTabPageElementsAccessibility(false);
                }
                btn_addNewTables.Enabled = true;
                RefreshGridViews();
            }
        }

        private void lB_availableDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lB_availableDatabases.SelectedIndex > -1)
                btn_chooseThisDatabase.Enabled = true;
        }

        //Wyświetlanie zawartości aktualnie wybranej bazy danych
        private void btn_refreshGridView_Click(object sender, EventArgs e)
        {
            RefreshGridViews();
        }

        private void cB_currentTableSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            cB_tableToModify.SelectedIndex = cB_currentTableSelected.SelectedIndex;
            cB_tableToDelete.SelectedIndex = cB_currentTableSelected.SelectedIndex;
            RefreshGridViews();
        }

        private void cB_tableToModify_SelectedIndexChanged(object sender, EventArgs e)
        {
            cB_currentTableSelected.SelectedIndex = cB_tableToModify.SelectedIndex;
            cB_tableToDelete.SelectedIndex = cB_tableToModify.SelectedIndex;
            RefreshGridViews();
        }

        private void cB_tableToDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            cB_tableToModify.SelectedIndex = cB_tableToDelete.SelectedIndex;
            cB_currentTableSelected.SelectedIndex = cB_tableToDelete.SelectedIndex;
            RefreshGridViews();
        }

        private void RefreshGridViews()
        {
            //jeżeli wybrano tabelę to pokazuje jej zwartość
            if (cB_currentTableSelected.SelectedIndex > -1 && 
                cB_currentTableSelected.Text != "(brak)") //jeśli comboBox jest wypełniony
            {
                //odświeżanie gridView'ów
                ReadDatabase.ReadChosenTableContent(dataGridView_ReadDatabase,
                    cB_currentTableSelected.Text);
                ReadDatabase.ReadChosenTableContent(dataGridView_modifyTable,
                    cB_currentTableSelected.Text);
                ReadDatabase.ReadChosenTableContent(dataGridView_modifyStructure,
                    cB_currentTableSelected.Text);
                dataGridView_modifyTable.Columns[0].ReadOnly = true;
                dataGridView_modifyTable.Columns[0].DefaultCellStyle.BackColor =
                    Color.Red;
                Database.ExistingFilledRows = dataGridView_ReadDatabase.RowCount;
            }
            else
            {
                dataGridView_ReadDatabase.DataSource = null;
                dataGridView_modifyTable.DataSource = null;
                dataGridView_modifyStructure.DataSource = null;
            }
        }

        private void RefreshComboBoxes()
        {
            //odświeżanie comboBoxów
            cB_currentTableSelected.Items.Clear();
            cB_tableToDelete.Items.Clear();
            cB_tableToModify.Items.Clear();
            ReadDatabase.ShowAvailableTables(cB_currentTableSelected);
            ReadDatabase.ShowAvailableTables(cB_tableToDelete);
            ReadDatabase.ShowAvailableTables(cB_tableToModify);
            cB_currentTableSelected.SelectedIndex = 0;
            if (cB_currentTableSelected.Text == "(brak)")
            {
                tabPage_readDatabase.Enabled = false;
                tabPage_modifyDatabase.Enabled = false;
                changeModifyStructureTabPageElementsAccessibility(false);
            }
        }

        //Czyszczenie comboBoxów i GridView'ów
        private void ClearEverything()
        {
            cB_currentTableSelected.Items.Clear();
            cB_tableToDelete.Items.Clear();
            cB_tableToModify.Items.Clear();
            dataGridView_ReadDatabase.DataSource = null;
            dataGridView_modifyTable.DataSource = null;
            dataGridView_modifyStructure.DataSource = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            ModifyDatabase.ModifySelectedTable(dataGridView_modifyTable, 
                cB_tableToModify);
            RefreshGridViews();
        }

        private void btn_discardChanges_Click(object sender, EventArgs e)
        {
            ReadDatabase.ReadChosenTableContent(dataGridView_modifyTable,
                cB_currentTableSelected.Text);
        }

//Usuwanie zaznaczonych kolumn i wierszy//////////////////////////////////////////////
        //Usuwanie wiersza
        private void btn_removeSelectedRow_Click(object sender, EventArgs e)
        {
            if (dataGridView_modifyStructure.SelectedCells.Count > 0)
            {
                int selectedRowIndex;
                int id;
                foreach (DataGridViewCell cell in dataGridView_modifyStructure.SelectedCells)
                {
                    selectedRowIndex = cell.RowIndex;
                    id = Convert.ToInt32(
                        dataGridView_modifyStructure.Rows[selectedRowIndex].Cells[0].Value);
                    ModifyStructure.DeleteRow(cB_tableToDelete.Text,
                        dataGridView_modifyStructure.Columns[0].Name, id);
                }
            }
            RefreshGridViews();
        }

        //Podświetlanie wybranego wiersza danych
        private void btn_removeSelectedRow_MouseEnter(object sender, EventArgs e)
        {
            int row;
            foreach (DataGridViewCell cell in dataGridView_modifyStructure.SelectedCells)
            {
                row = cell.RowIndex;
                dataGridView_modifyStructure.Rows[row].DefaultCellStyle.BackColor = Color.Aqua;
            }
        }

        private void btn_removeSelectedRow_MouseLeave(object sender, EventArgs e)
        {
            int row;
            foreach (DataGridViewCell cell in dataGridView_modifyStructure.SelectedCells)
            {
                row = cell.RowIndex;
                dataGridView_modifyStructure.Rows[row].DefaultCellStyle.BackColor = Color.Empty;
            }
        }

        //Usuwanie kolumny
        private void btn_removeSelectedColumn_Click(object sender, EventArgs e)
        {
            if (dataGridView_modifyStructure.SelectedCells.Count > 0)
            {
                int selectedColumnIndex;
                foreach (DataGridViewCell cell in dataGridView_modifyStructure.SelectedCells)
                {
                    selectedColumnIndex = cell.ColumnIndex;
                    ModifyStructure.DeleteColumn(cB_tableToDelete.Text,
                        dataGridView_modifyStructure.Columns[selectedColumnIndex].Name);
                }
            }
            RefreshGridViews();
        }

        //Podświetlanie wybranej kolumny danych
        private void btn_removeSelectedColumn_MouseEnter(object sender, EventArgs e)
        {
            int column;
            foreach (DataGridViewCell cell in dataGridView_modifyStructure.SelectedCells)
            {
                column = cell.ColumnIndex;
                dataGridView_modifyStructure.Columns[column].DefaultCellStyle.BackColor
                    = Color.Aqua;
            }
        }

        private void btn_removeSelectedColumn_MouseLeave(object sender, EventArgs e)
        {
            int column;
            foreach (DataGridViewCell cell in dataGridView_modifyStructure.SelectedCells)
            {
                column = cell.ColumnIndex;
                dataGridView_modifyStructure.Columns[column].DefaultCellStyle.BackColor
                    = Color.Empty;
            }
        }
///////////////////////////////////////////////////////////////////////////////////
        private void btn_deleteChosenTable_Click_1(object sender, EventArgs e)
        {
            ModifyStructure.DeleteTable(cB_tableToDelete.Text);
            RefreshComboBoxes();
            RefreshGridViews();
        }

        private void btn_deleteCurrentDatabase_Click(object sender, EventArgs e)
        {
            ModifyStructure.DeleteDatabase();
            tabPage_readDatabase.Enabled = false;
            tabPage_modifyDatabase.Enabled = false;
            tabPage_modifyStructure.Enabled = false;
            ClearEverything();
        }

        private void btn_addNewColumn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(cB_currentTableSelected.Text, 
                lB_availableDatabases.SelectedItem.ToString());
            form2.Show();
        }

        private void btn_addNewTables_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

//Dodawanie tabel przy tworzeniu nowej bazy danych///////////////////////////////
        private void btn_addNewTable_Click(object sender, EventArgs e)
        {
            if (emptyNewDatabase)
                lB_addedTables.Items.Clear();
            if(tB_newTableName.Text != "")
            lB_addedTables.Items.Add(tB_newTableName.Text);
            emptyNewDatabase = false;
        }

        private void btn_removeSelectedTable_Click(object sender, EventArgs e)
        {
            if (lB_addedTables.SelectedIndex > -1)
            {
                if (lB_addedTables.Items.Count == 1)
                {
                    lB_addedTables.Items.Clear();
                    lB_addedTables.Items.Add("*pusta baza*");
                    emptyNewDatabase = true;
                }
                else
                {
                    int index = lB_addedTables.SelectedIndex;
                    lB_addedTables.Items.RemoveAt(index);
                }
            }
        }


    }
}

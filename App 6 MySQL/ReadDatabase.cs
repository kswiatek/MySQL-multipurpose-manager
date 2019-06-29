using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace App_6_MySQL
{
    static class ReadDatabase
    {
        static MySqlConnection connection;
        static MySqlCommand command;
        static MySqlDataReader reader; //do czytnika nie daje się nic przed komendą
        static string SQLquery;

        //Pokazywanie istniejących baz danych (wynik jest wpisywany do ListBoxa)
        public static void ShowAvailableDatabases(ListBox listBox)
        {
            try
            {
                connection = new MySqlConnection(Database.ConnectionPath);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SQLquery = "show databases";
                command = new MySqlCommand(SQLquery, connection);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listBox.Items.Add(reader[0] + Environment.NewLine);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem podczas szukania baz danych:\n" + ex.Message,
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
                if (command != null)
                {
                    command.Dispose();
                    command = null;
                }
            }
        }

        //Rozsyłamy event o zmianie wybranej bazy danych
        public static void ChooseThisDatabase(string databaseName) 
        {
            DatabaseChangedEventArgs args = new DatabaseChangedEventArgs();
            args.DatabaseName = databaseName;
            Database.OnConnectedDatabaseChanged(args);
        }

        //Pokazuje zawartość aktualnie wybranej tabeli (wynik umieszczany w GridView'ie)
        public static void ReadChosenTableContent(DataGridView dataGridView_ReadDatabase,
            string chosenTableName)
        {
            try
            {
                connection = new MySqlConnection(Database.ConnectionPath);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SQLquery = "select * from " + chosenTableName;
                command = new MySqlCommand(SQLquery, connection);
                reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView_ReadDatabase.DataSource = dataTable;

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd w odczycie bazy danych: " + ex.Message,
                    "Okno błędu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                reader = null;
                command = null;
                SQLquery = null;
            }
        }

        //Pokazuje istniejące w wybranej bazie danych tabele
        public static void ShowAvailableTables(ComboBox cB_currentTableSelected)
        {
            try
            {
                connection = new MySqlConnection(Database.ConnectionPath);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                DataTable tables = connection.GetSchema("Tables");
                if (tables.Rows.Count > 0)
                {
                    foreach (DataRow row in tables.Rows)
                        cB_currentTableSelected.Items.Add(row[2].ToString());
                }
                else
                    cB_currentTableSelected.Items.Add("(brak)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie można było połączyć z bazą danych:\n" + ex.Message,
                    "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void ShowExistingColumns(string tableName, ListBox listBox)
        {
            try
            {
                connection = new MySqlConnection(Database.ConnectionPath);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SQLquery = "select column_name from information_schema.columns"+
                    " where table_name='" + tableName + "'";
                command = new MySqlCommand(SQLquery, connection);
                reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listBox.Items.Add(reader[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie można było połączyć z bazą danych:\n" + ex.Message,
                    "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}

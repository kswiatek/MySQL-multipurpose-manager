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
    static class CreateDatabase
    {
        static MySqlConnection connection;
        static MySqlCommand command;
        static string SQLquery;

        //Tworzenie nowej pustej bazy danych
        public static void CreateNewDatabase(string name)
        {
            try
            {
                connection = new MySqlConnection(Database.ConnectionPath);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SQLquery =
                    "create database `"+name+
                    "` character set utf8 collate utf8_polish_ci";
                command = new MySqlCommand(SQLquery, connection);
                command.ExecuteNonQuery();

                //wywoływanie zdarzenia informującego o zmianie podłączonej bazy danych
                DatabaseChangedEventArgs args = new DatabaseChangedEventArgs();
                args.DatabaseName = name;
                Database.OnConnectedDatabaseChanged(args);
                MessageBox.Show("Baza danych o nazwie: " + name + " została utworzona.",
                "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem podczas tworzenia bazy danych:\n" + ex.Message,
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

        //Tworzenie nowych tabel (w oparciu o listę itemów z listBoxa)
        public static void AddNewTables(ListBox lB_tables)
        {
            try
            {
                connection = new MySqlConnection(Database.ConnectionPath);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                foreach (string item in lB_tables.Items)
                {
                    //domyślnie nowe tabele są tworzone z jedną kolumną ID
                    SQLquery = "create table " + item + 
                        " (ID int not null auto_increment primary key)";
                    command = new MySqlCommand(SQLquery, connection);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Dodano nowe tabele.", "Informacja", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem podczas tworzenia bazy danych:\n" + ex.Message,
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

        //Dodawanie nowej kolumny (tablica options zawiera parametry dla nowej kolumny)
        public static void AddNewColumn(string tableName, string columnName, string[] options)
        {
            try
            {
                connection = new MySqlConnection(Database.ConnectionPath);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SQLquery = "alter table " + tableName + " add column " + columnName;
                //typ danych
                SQLquery += " " + options[0];
                //max dł.
                if (options[1] != null)
                    SQLquery += "(" + options[1] + ")";
                //domyślna wart.
                if (options[2] != null)
                    SQLquery += " default '" + options[2] + "'";
                //czy null
                if (options[3] == "False")
                    SQLquery += " not null";
                //czy auto inc.
                if (options[4] == "True")
                    SQLquery += " auto_increment";
                //wyżej niżej (null jak nie ma innych, first albo after nazwaPoprzedniego)
                if (options[5] != null)
                    SQLquery += " " + options[5];

                command = new MySqlCommand(SQLquery, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Kolumna o nazwie: " + columnName +
                    " została pomyślnie utworzona.", "Informacja", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                //MessageBox.Show("Zapytanie: \n" + SQLquery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem podczas tworzenia nowej kolumny:\n" + ex.Message,
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

    }
}

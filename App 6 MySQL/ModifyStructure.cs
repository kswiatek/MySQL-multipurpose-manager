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
    static class ModifyStructure
    {
        static MySqlConnection connection;
        static MySqlCommand command;
        static string SQLquery = "";

        public static void DeleteRow(string tableName, string idName, int id)
        {
            SQLquery = "delete from " + tableName + " where " + idName + " = " + id;
            Delete(SQLquery);
        }

        public static void DeleteColumn(string tableName, string columnName)
        {
            SQLquery = "alter table " + tableName + " drop column " + columnName;
            Delete(SQLquery);
        }

        public static void DeleteTable(string tableName)
        {
            SQLquery = "drop table " + tableName;
            Delete(SQLquery);
            MessageBox.Show("Tabela o nazwie: " + tableName + " została usunięta!",
                "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Usuwanie akutalnie podłączonej bazy danych
        public static void DeleteDatabase()
        {
            SQLquery = "drop database " + Database.ConnectedDatabase;
            Delete(SQLquery);
            MessageBox.Show("Baza danych o nazwie: " + Database.ConnectedDatabase +
                " została usunięta!", "Informacja", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Database.ConnectedDatabase = "";
            Database.IsDatabaseOK = false;
            DatabaseChangedEventArgs args = new DatabaseChangedEventArgs();
            args.DatabaseName = "";
            Database.OnConnectedDatabaseChanged(args);
        }

        //Prywatna metoda wykonująca na bazie dowolne usuwanie (wybrane z powyższych metod)
        private static void Delete(string query)
        {
            try
            {
                connection = new MySqlConnection(Database.ConnectionPath);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas modyfikacji bazy danych: " + ex.Message, "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

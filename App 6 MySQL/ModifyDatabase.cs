using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace App_6_MySQL
{
    static class ModifyDatabase
    {
        static MySqlConnection connection;
        static MySqlCommand command;
        static string SQLquery = "";

        //Wprowadzanie zmian z GridViewa do wybranej w comboBoxach tabeli
        public static void ModifySelectedTable(DataGridView dGV_modifyTable, 
            ComboBox cB_tableToModify)
        {
            string[] columnNames = new string[dGV_modifyTable.Columns.Count];
            for (int i = 0; i < dGV_modifyTable.ColumnCount; i++)
                columnNames[i] = dGV_modifyTable.Columns[i].Name;

            int c = dGV_modifyTable.ColumnCount; //ilość kolumn w bazie danych
            int r = dGV_modifyTable.RowCount;    //wierszy (po modyfikacjach)

            //tworzenie zapytania modyfikującego na podst. zawartości DataGridView'a
            string[] SQLqueries = new string[r];
            for (int j = 0; j < Database.ExistingFilledRows - 1; j++)
            {
                SQLquery = "update " + cB_tableToModify.Text + " set ";
                for (int k = 0; k < c; k++)
                {
                    if (dGV_modifyTable.Rows[j].Cells[k].Value != null)
                    {
                        string content = dGV_modifyTable.Rows[j].Cells[k].Value.ToString();
                        if (isNumberAndFloating(content))
                            content = content.Replace(',', '.');
                        SQLquery += columnNames[k] + " = '" + content + "', ";
                    }
                    else
                        SQLquery = "";
                }
                if (SQLquery != "")
                {
                    //ID musi być pierwsze i być liczbą int, poza tym baza może być dowolna
                    SQLquery = SQLquery.Remove(SQLquery.Length - 2);
                    SQLquery += " where " + columnNames[0] + " = '" +
                        dGV_modifyTable.Rows[j].Cells[0].Value + "'";
                    if(dGV_modifyTable.Rows[j].Cells[0].Value.ToString() != "")
                        SQLqueries[j] = SQLquery;
                }
            }

            //tworzenie zapytań dodających nowe wiersze danych
            for (int i = Database.ExistingFilledRows - 1; i < r; i++)
            {                               //tyle wierszy ile jest aktualnie wypełnionych + 1
                if (dGV_modifyTable.Rows[i].Cells[0].Value != null) //jeśli id nie jest puste
                {
                    SQLquery = "insert into " + cB_tableToModify.Text +
                            " values(null";
                    for (int j = 1; j < c; j++) //j = 1 żeby nie brać id pod uwagę przy insert
                    {
                        string content2 = dGV_modifyTable.Rows[i].Cells[j].Value.ToString();
                        if (isNumberAndFloating(content2))
                            content2 = content2.Replace(',', '.');
                        SQLquery += ", '" + content2 +"'";
                    }
                    SQLquery += ")";
                    SQLqueries[i] = SQLquery;
                }
            }

            //wykonywanie kolekcji utworzonych zapytań na bazie danych
            try
            {
                connection = new MySqlConnection(Database.ConnectionPath);
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                for (int i = 0; i < r; i++)
                {
                    if (SQLqueries[i] != null && SQLqueries[i] != "")
                    {
                        command = new MySqlCommand(SQLqueries[i], connection);
                        command.ExecuteNonQuery();
                        command = null;
                    }
                }
                MessageBox.Show("Zmienione dane zostały zapisane w bazie danych poprawnie",
                    "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd z dostępem do bazy: \n" + ex.Message,
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            ////diagnostic tool//
            //string t = "";
            //for (int i = 0; i < SQLqueries.Length; i++)
            //    t += SQLqueries[i] + Environment.NewLine;
            //MessageBox.Show("Zapytania: \n" + t);

        }

        //Sprawdzanie czy podany string to liczba i do tego zmiennoprzecinkowa
        public static bool isNumberAndFloating(string data)
        {
            if (!data.Contains(","))    //jeśli string nie posiada przecinka
                return false;
            string[] parts = data.Split(',');
            if (parts.Length != 2)      //jeśli jest tylko jeden przecinek
                return false;
            int output;
            if (!Int32.TryParse(parts[0], out output))//jeśli pierwsza cz. to int
                return false;
            if (!Int32.TryParse(parts[1], out output))//jeśli druga też jw.
                return false;
            return true;
        }

    }
}

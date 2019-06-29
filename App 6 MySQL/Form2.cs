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
    public partial class Form2 : Form //Okno tworzenia nowej kolumny
    {
        public Form2(string tableName, string databaseName)
        {
            InitializeComponent();
            cB_columnType.SelectedIndex = 0;
            ReadDatabase.ShowExistingColumns(tableName, lB_existingColumns);
            this.tableName = tableName;
            this.databaseName = databaseName;
            //dodawanie elementu wskazującego miejsce w kolejności istniejących kolumn
            lB_existingColumns.Items.Add("*nowa kolumna*");
            lB_existingColumns.SelectedIndex = lB_existingColumns.Items.Count - 1;
        }

        private string tableName;
        private string databaseName;

        private void btn_createColumn_Click(object sender, EventArgs e)
        {
            //sprawdzanie poprawności danych
            string wrongDataList = "";
            if (String.IsNullOrEmpty(tB_columnName.Text))
                wrongDataList += "Brak nazwy kolumny." + Environment.NewLine;

            if(String.IsNullOrEmpty(tB_maxDataLength.Text) && cB_columnType.Text == "VARCHAR")
                wrongDataList += 
                    "Przy typie danych VARCHAR, należy podać maksymalną długość danych."
                    + Environment.NewLine;
            if (!String.IsNullOrEmpty(tB_maxDataLength.Text))
            {
                int temp;
                if (!Int32.TryParse(tB_maxDataLength.Text, out temp))
                    wrongDataList += "Maksymalna długość musi być liczbą całkowitą."
                        + Environment.NewLine;
            }

            if (!String.IsNullOrEmpty(tB_defaultValue.Text))
            {
                if (cB_columnType.Text == "INT")
                {
                    int temp;
                    if (!Int32.TryParse(tB_defaultValue.Text, out temp))
                        wrongDataList += "Podana wartość domyślna nie jest liczbą całkowitą."
                            + Environment.NewLine;
                }
                else if(cB_columnType.Text == "FLOAT")
                {
                    string content = tB_defaultValue.Text;
                    int temp;
                    if (ModifyDatabase.isNumberAndFloating(content))
                    {
                        content = content.Replace(',', '.');
                        tB_defaultValue.Text = content;
                    }
                    else if (!Int32.TryParse(tB_defaultValue.Text, out temp))
                        wrongDataList += "Podana wartość domyślna nie jest poprawną liczbą."
                            + Environment.NewLine;
                }
            }

            //wywoływanie metody tworzącej kolumnę
            if (wrongDataList == "")
            {
                string[] options = new string[6];
                //typ danych
                options[0] = cB_columnType.Text;
                //max dł.
                if (!String.IsNullOrEmpty(tB_maxDataLength.Text))
                    options[1] = tB_maxDataLength.Text;
                else
                    options[1] = null;
                //domyślna wart.
                if (!String.IsNullOrEmpty(tB_defaultValue.Text))
                    options[2] = tB_defaultValue.Text;
                else
                    options[2] = null;
                //czy null
                options[3] = checkBox_nullAllowed.Checked.ToString();
                //czy auto inc.
                options[4] = checkBox_autoIncrement.Checked.ToString();
                //wyżej niżej
                if (lB_existingColumns.Items.Count == 1) //brak obecności inych kolumn
                    options[5] = null;
                else
                {
                    if (lB_existingColumns.SelectedIndex == 0) //nowa kolumna będzie pierwszą
                        options[5] = "first";
                    else
                    {
                        int index = lB_existingColumns.SelectedIndex - 1;
                        options[5] = "after " + lB_existingColumns.Items[index].ToString();
                    }
                }

                CreateDatabase.AddNewColumn(tableName, tB_columnName.Text, options);
                ReadDatabase.ChooseThisDatabase(databaseName);
                this.Close();
            }
            else
                MessageBox.Show(wrongDataList, "Wprowadzono nieprawidłowe dane", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Ograniczenie maksymalnej ilości znaków w wartości domyślnej (jeśli ustalono)
        private void tB_maxDataLength_Leave(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tB_maxDataLength.Text))
            {
                int temp;
                if (Int32.TryParse(tB_maxDataLength.Text, out temp))
                    tB_maxDataLength.MaxLength = temp;
            }
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if(lB_existingColumns.SelectedIndex > 1)
            {
                int indexToMove = lB_existingColumns.SelectedIndex - 1;
                lB_existingColumns.Items[indexToMove + 1] = lB_existingColumns.Items[indexToMove];
                lB_existingColumns.Items[indexToMove] = "*nowa kolumna*";
                lB_existingColumns.SelectedIndex -= 1;
            }
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (lB_existingColumns.SelectedIndex != lB_existingColumns.Items.Count - 1)
            {
                int indexToMove = lB_existingColumns.SelectedIndex + 1;
                lB_existingColumns.Items[indexToMove - 1] = lB_existingColumns.Items[indexToMove];
                lB_existingColumns.Items[indexToMove] = "*nowa kolumna*";
                lB_existingColumns.SelectedIndex += 1;
            }
        }
    }
}

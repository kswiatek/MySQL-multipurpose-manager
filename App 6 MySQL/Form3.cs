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
    public partial class Form3 : Form //Okno tworzenia nowej tabeli
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_addNewTable_Click(object sender, EventArgs e)
        {
            if (tB_newTableName.Text != "")
                lB_addedTables.Items.Add(tB_newTableName.Text);
        }

        private void btn_removeSelectedTable_Click(object sender, EventArgs e)
        {
            if (lB_addedTables.SelectedIndex > -1)
            {
                int index = lB_addedTables.SelectedIndex;
                lB_addedTables.Items.RemoveAt(index);
            }
        }

        private void btn_ready_Click(object sender, EventArgs e)
        {
            if (lB_addedTables.Items.Count > 0)
            {
                CreateDatabase.AddNewTables(lB_addedTables);
                DatabaseChangedEventArgs args = new DatabaseChangedEventArgs();
                args.DatabaseName = Database.ConnectedDatabase;
                Database.OnConnectedDatabaseChanged(args);
                this.Close();
            }
        }


    }
}
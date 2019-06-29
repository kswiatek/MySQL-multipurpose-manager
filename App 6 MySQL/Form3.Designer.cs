namespace App_6_MySQL
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label4 = new System.Windows.Forms.Label();
            this.tB_newTableName = new System.Windows.Forms.TextBox();
            this.btn_addNewTable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lB_addedTables = new System.Windows.Forms.ListBox();
            this.btn_removeSelectedTable = new System.Windows.Forms.Button();
            this.btn_ready = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nazwa tabeli:";
            // 
            // tB_newTableName
            // 
            this.tB_newTableName.Location = new System.Drawing.Point(83, 13);
            this.tB_newTableName.Name = "tB_newTableName";
            this.tB_newTableName.Size = new System.Drawing.Size(149, 20);
            this.tB_newTableName.TabIndex = 5;
            // 
            // btn_addNewTable
            // 
            this.btn_addNewTable.Location = new System.Drawing.Point(9, 45);
            this.btn_addNewTable.Name = "btn_addNewTable";
            this.btn_addNewTable.Size = new System.Drawing.Size(112, 23);
            this.btn_addNewTable.TabIndex = 7;
            this.btn_addNewTable.Text = "Dodaj";
            this.btn_addNewTable.UseVisualStyleBackColor = true;
            this.btn_addNewTable.Click += new System.EventHandler(this.btn_addNewTable_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dodawane tabele:";
            // 
            // lB_addedTables
            // 
            this.lB_addedTables.FormattingEnabled = true;
            this.lB_addedTables.Location = new System.Drawing.Point(258, 32);
            this.lB_addedTables.Name = "lB_addedTables";
            this.lB_addedTables.Size = new System.Drawing.Size(150, 108);
            this.lB_addedTables.TabIndex = 3;
            // 
            // btn_removeSelectedTable
            // 
            this.btn_removeSelectedTable.Location = new System.Drawing.Point(127, 45);
            this.btn_removeSelectedTable.Name = "btn_removeSelectedTable";
            this.btn_removeSelectedTable.Size = new System.Drawing.Size(105, 23);
            this.btn_removeSelectedTable.TabIndex = 8;
            this.btn_removeSelectedTable.Text = "Usuń";
            this.btn_removeSelectedTable.UseVisualStyleBackColor = true;
            this.btn_removeSelectedTable.Click += new System.EventHandler(this.btn_removeSelectedTable_Click);
            // 
            // btn_ready
            // 
            this.btn_ready.Location = new System.Drawing.Point(9, 88);
            this.btn_ready.Name = "btn_ready";
            this.btn_ready.Size = new System.Drawing.Size(223, 52);
            this.btn_ready.TabIndex = 9;
            this.btn_ready.Text = "Gotowe";
            this.btn_ready.UseVisualStyleBackColor = true;
            this.btn_ready.Click += new System.EventHandler(this.btn_ready_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ready);
            this.groupBox1.Controls.Add(this.btn_removeSelectedTable);
            this.groupBox1.Controls.Add(this.lB_addedTables);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_addNewTable);
            this.groupBox1.Controls.Add(this.tB_newTableName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 152);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 170);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Dodawanie tabel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_newTableName;
        private System.Windows.Forms.Button btn_addNewTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lB_addedTables;
        private System.Windows.Forms.Button btn_removeSelectedTable;
        private System.Windows.Forms.Button btn_ready;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
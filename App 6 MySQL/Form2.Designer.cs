namespace App_6_MySQL
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_columnName = new System.Windows.Forms.TextBox();
            this.tB_maxDataLength = new System.Windows.Forms.TextBox();
            this.cB_columnType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_nullAllowed = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_defaultValue = new System.Windows.Forms.TextBox();
            this.checkBox_autoIncrement = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_createColumn = new System.Windows.Forms.Button();
            this.lB_existingColumns = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa kolumny:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Typ danych:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maksymalna długość:";
            // 
            // tB_columnName
            // 
            this.tB_columnName.Location = new System.Drawing.Point(191, 28);
            this.tB_columnName.Name = "tB_columnName";
            this.tB_columnName.Size = new System.Drawing.Size(197, 20);
            this.tB_columnName.TabIndex = 3;
            // 
            // tB_maxDataLength
            // 
            this.tB_maxDataLength.Location = new System.Drawing.Point(191, 81);
            this.tB_maxDataLength.Name = "tB_maxDataLength";
            this.tB_maxDataLength.Size = new System.Drawing.Size(115, 20);
            this.tB_maxDataLength.TabIndex = 4;
            this.tB_maxDataLength.Leave += new System.EventHandler(this.tB_maxDataLength_Leave);
            // 
            // cB_columnType
            // 
            this.cB_columnType.FormattingEnabled = true;
            this.cB_columnType.Items.AddRange(new object[] {
            "INT",
            "FLOAT",
            "VARCHAR",
            "TEXT"});
            this.cB_columnType.Location = new System.Drawing.Point(191, 54);
            this.cB_columnType.Name = "cB_columnType";
            this.cB_columnType.Size = new System.Drawing.Size(197, 21);
            this.cB_columnType.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Domyślna wartość:";
            // 
            // checkBox_nullAllowed
            // 
            this.checkBox_nullAllowed.AutoSize = true;
            this.checkBox_nullAllowed.Location = new System.Drawing.Point(191, 140);
            this.checkBox_nullAllowed.Name = "checkBox_nullAllowed";
            this.checkBox_nullAllowed.Size = new System.Drawing.Size(47, 17);
            this.checkBox_nullAllowed.TabIndex = 7;
            this.checkBox_nullAllowed.Text = "TAK";
            this.checkBox_nullAllowed.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dopuszczalna wart. NULL:";
            // 
            // tB_defaultValue
            // 
            this.tB_defaultValue.Location = new System.Drawing.Point(191, 110);
            this.tB_defaultValue.Name = "tB_defaultValue";
            this.tB_defaultValue.Size = new System.Drawing.Size(197, 20);
            this.tB_defaultValue.TabIndex = 9;
            // 
            // checkBox_autoIncrement
            // 
            this.checkBox_autoIncrement.AutoSize = true;
            this.checkBox_autoIncrement.Location = new System.Drawing.Point(191, 171);
            this.checkBox_autoIncrement.Name = "checkBox_autoIncrement";
            this.checkBox_autoIncrement.Size = new System.Drawing.Size(47, 17);
            this.checkBox_autoIncrement.TabIndex = 10;
            this.checkBox_autoIncrement.Text = "TAK";
            this.checkBox_autoIncrement.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Auto. inkrementacja:";
            // 
            // btn_createColumn
            // 
            this.btn_createColumn.Location = new System.Drawing.Point(269, 229);
            this.btn_createColumn.Name = "btn_createColumn";
            this.btn_createColumn.Size = new System.Drawing.Size(139, 134);
            this.btn_createColumn.TabIndex = 12;
            this.btn_createColumn.Text = "Utwórz kolumnę";
            this.btn_createColumn.UseVisualStyleBackColor = true;
            this.btn_createColumn.Click += new System.EventHandler(this.btn_createColumn_Click);
            // 
            // lB_existingColumns
            // 
            this.lB_existingColumns.Enabled = false;
            this.lB_existingColumns.FormattingEnabled = true;
            this.lB_existingColumns.Location = new System.Drawing.Point(12, 229);
            this.lB_existingColumns.Name = "lB_existingColumns";
            this.lB_existingColumns.Size = new System.Drawing.Size(173, 134);
            this.lB_existingColumns.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 200);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wprowadź dane";
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(191, 229);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(59, 62);
            this.btn_up.TabIndex = 15;
            this.btn_up.Text = "wyżej";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(191, 297);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(59, 66);
            this.btn_down.TabIndex = 16;
            this.btn_down.Text = "niżej";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 379);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.lB_existingColumns);
            this.Controls.Add(this.btn_createColumn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox_autoIncrement);
            this.Controls.Add(this.tB_defaultValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox_nullAllowed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cB_columnType);
            this.Controls.Add(this.tB_maxDataLength);
            this.Controls.Add(this.tB_columnName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Tworzenie nowej kolumny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_columnName;
        private System.Windows.Forms.TextBox tB_maxDataLength;
        private System.Windows.Forms.ComboBox cB_columnType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_nullAllowed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_defaultValue;
        private System.Windows.Forms.CheckBox checkBox_autoIncrement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_createColumn;
        private System.Windows.Forms.ListBox lB_existingColumns;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
    }
}
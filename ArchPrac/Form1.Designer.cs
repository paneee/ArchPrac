namespace ArchPrac
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSciezkaArchiwum = new System.Windows.Forms.TextBox();
            this.buttonSciezkaArchiwum = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_wyszukaj = new System.Windows.Forms.Button();
            this.textBox_wyszukaj = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonKonfOdczyt = new System.Windows.Forms.Button();
            this.buttonKonfZapis = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxNazwaPlikuTag = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxSciezkaTotalCommander = new System.Windows.Forms.TextBox();
            this.buttonSciezkaTotalCommander = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.richTextBoxTagi = new System.Windows.Forms.RichTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.buttonUtworzFolder = new System.Windows.Forms.Button();
            this.textBoxNazwaFolderu = new System.Windows.Forms.TextBox();
            this.buttonDzisiejszaData = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_WyczyscFormatki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(19, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(582, 190);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // textBoxSciezkaArchiwum
            // 
            this.textBoxSciezkaArchiwum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSciezkaArchiwum.Font = new System.Drawing.Font("Courier New", 12F);
            this.textBoxSciezkaArchiwum.Location = new System.Drawing.Point(19, 19);
            this.textBoxSciezkaArchiwum.Name = "textBoxSciezkaArchiwum";
            this.textBoxSciezkaArchiwum.Size = new System.Drawing.Size(539, 19);
            this.textBoxSciezkaArchiwum.TabIndex = 1;
            this.textBoxSciezkaArchiwum.TextChanged += new System.EventHandler(this.textBoxSciezkaArchiwum_TextChanged);
            // 
            // buttonSciezkaArchiwum
            // 
            this.buttonSciezkaArchiwum.Location = new System.Drawing.Point(564, 16);
            this.buttonSciezkaArchiwum.Name = "buttonSciezkaArchiwum";
            this.buttonSciezkaArchiwum.Size = new System.Drawing.Size(34, 24);
            this.buttonSciezkaArchiwum.TabIndex = 2;
            this.buttonSciezkaArchiwum.Text = "...";
            this.buttonSciezkaArchiwum.UseVisualStyleBackColor = true;
            this.buttonSciezkaArchiwum.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_wyszukaj
            // 
            this.button_wyszukaj.Location = new System.Drawing.Point(487, 16);
            this.button_wyszukaj.Name = "button_wyszukaj";
            this.button_wyszukaj.Size = new System.Drawing.Size(114, 24);
            this.button_wyszukaj.TabIndex = 4;
            this.button_wyszukaj.Text = "Wyszukaj";
            this.button_wyszukaj.UseVisualStyleBackColor = true;
            this.button_wyszukaj.Click += new System.EventHandler(this.button_wyszukaj_Click);
            // 
            // textBox_wyszukaj
            // 
            this.textBox_wyszukaj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_wyszukaj.Font = new System.Drawing.Font("Courier New", 12F);
            this.textBox_wyszukaj.Location = new System.Drawing.Point(19, 19);
            this.textBox_wyszukaj.Name = "textBox_wyszukaj";
            this.textBox_wyszukaj.Size = new System.Drawing.Size(462, 19);
            this.textBox_wyszukaj.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSciezkaArchiwum);
            this.groupBox1.Controls.Add(this.buttonSciezkaArchiwum);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 48);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ścieżka do folderu archiwów";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_wyszukaj);
            this.groupBox2.Controls.Add(this.button_wyszukaj);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 50);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wyszukaj";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(3, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 212);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wynik";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 303);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(617, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wyszukiwanie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(617, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Konfiguracja";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonKonfOdczyt);
            this.groupBox6.Controls.Add(this.buttonKonfZapis);
            this.groupBox6.Location = new System.Drawing.Point(237, 114);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(373, 48);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Konfiguracja";
            // 
            // buttonKonfOdczyt
            // 
            this.buttonKonfOdczyt.Location = new System.Drawing.Point(9, 16);
            this.buttonKonfOdczyt.Name = "buttonKonfOdczyt";
            this.buttonKonfOdczyt.Size = new System.Drawing.Size(176, 24);
            this.buttonKonfOdczyt.TabIndex = 9;
            this.buttonKonfOdczyt.Text = "Odczyt";
            this.buttonKonfOdczyt.UseVisualStyleBackColor = true;
            this.buttonKonfOdczyt.Click += new System.EventHandler(this.buttonKonfOdczyt_Click);
            // 
            // buttonKonfZapis
            // 
            this.buttonKonfZapis.Location = new System.Drawing.Point(191, 16);
            this.buttonKonfZapis.Name = "buttonKonfZapis";
            this.buttonKonfZapis.Size = new System.Drawing.Size(176, 24);
            this.buttonKonfZapis.TabIndex = 8;
            this.buttonKonfZapis.Text = "Zapis";
            this.buttonKonfZapis.UseVisualStyleBackColor = true;
            this.buttonKonfZapis.Click += new System.EventHandler(this.buttonZapisKonfig_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxNazwaPlikuTag);
            this.groupBox5.Location = new System.Drawing.Point(6, 114);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(225, 48);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nazwa pliku tag";
            // 
            // textBoxNazwaPlikuTag
            // 
            this.textBoxNazwaPlikuTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNazwaPlikuTag.Font = new System.Drawing.Font("Courier New", 12F);
            this.textBoxNazwaPlikuTag.Location = new System.Drawing.Point(19, 19);
            this.textBoxNazwaPlikuTag.Name = "textBoxNazwaPlikuTag";
            this.textBoxNazwaPlikuTag.Size = new System.Drawing.Size(200, 19);
            this.textBoxNazwaPlikuTag.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxSciezkaTotalCommander);
            this.groupBox4.Controls.Add(this.buttonSciezkaTotalCommander);
            this.groupBox4.Location = new System.Drawing.Point(6, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(604, 48);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scieżka Total Commander";
            // 
            // textBoxSciezkaTotalCommander
            // 
            this.textBoxSciezkaTotalCommander.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSciezkaTotalCommander.Font = new System.Drawing.Font("Courier New", 12F);
            this.textBoxSciezkaTotalCommander.Location = new System.Drawing.Point(19, 19);
            this.textBoxSciezkaTotalCommander.Name = "textBoxSciezkaTotalCommander";
            this.textBoxSciezkaTotalCommander.Size = new System.Drawing.Size(539, 19);
            this.textBoxSciezkaTotalCommander.TabIndex = 1;
            // 
            // buttonSciezkaTotalCommander
            // 
            this.buttonSciezkaTotalCommander.Location = new System.Drawing.Point(564, 16);
            this.buttonSciezkaTotalCommander.Name = "buttonSciezkaTotalCommander";
            this.buttonSciezkaTotalCommander.Size = new System.Drawing.Size(34, 24);
            this.buttonSciezkaTotalCommander.TabIndex = 2;
            this.buttonSciezkaTotalCommander.Text = "...";
            this.buttonSciezkaTotalCommander.UseVisualStyleBackColor = true;
            this.buttonSciezkaTotalCommander.Click += new System.EventHandler(this.buttonSciezkaTotalCommander_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(617, 277);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tworzenie";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.richTextBoxTagi);
            this.groupBox8.Location = new System.Drawing.Point(6, 5);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(604, 213);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Tagi";
            // 
            // richTextBoxTagi
            // 
            this.richTextBoxTagi.BackColor = System.Drawing.Color.White;
            this.richTextBoxTagi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxTagi.Font = new System.Drawing.Font("Courier New", 12F);
            this.richTextBoxTagi.Location = new System.Drawing.Point(18, 20);
            this.richTextBoxTagi.Name = "richTextBoxTagi";
            this.richTextBoxTagi.Size = new System.Drawing.Size(580, 187);
            this.richTextBoxTagi.TabIndex = 0;
            this.richTextBoxTagi.Text = "";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.button_WyczyscFormatki);
            this.groupBox7.Controls.Add(this.buttonUtworzFolder);
            this.groupBox7.Controls.Add(this.textBoxNazwaFolderu);
            this.groupBox7.Controls.Add(this.buttonDzisiejszaData);
            this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox7.Location = new System.Drawing.Point(6, 224);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(604, 48);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Nazwa folderu";
            // 
            // buttonUtworzFolder
            // 
            this.buttonUtworzFolder.Location = new System.Drawing.Point(498, 14);
            this.buttonUtworzFolder.Name = "buttonUtworzFolder";
            this.buttonUtworzFolder.Size = new System.Drawing.Size(100, 24);
            this.buttonUtworzFolder.TabIndex = 3;
            this.buttonUtworzFolder.Text = "Utwórz Folder";
            this.buttonUtworzFolder.UseVisualStyleBackColor = true;
            this.buttonUtworzFolder.Click += new System.EventHandler(this.buttonUtworzFolder_Click);
            // 
            // textBoxNazwaFolderu
            // 
            this.textBoxNazwaFolderu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNazwaFolderu.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNazwaFolderu.Location = new System.Drawing.Point(18, 19);
            this.textBoxNazwaFolderu.Name = "textBoxNazwaFolderu";
            this.textBoxNazwaFolderu.Size = new System.Drawing.Size(216, 19);
            this.textBoxNazwaFolderu.TabIndex = 1;
            // 
            // buttonDzisiejszaData
            // 
            this.buttonDzisiejszaData.Location = new System.Drawing.Point(286, 14);
            this.buttonDzisiejszaData.Name = "buttonDzisiejszaData";
            this.buttonDzisiejszaData.Size = new System.Drawing.Size(100, 24);
            this.buttonDzisiejszaData.TabIndex = 2;
            this.buttonDzisiejszaData.Text = "Dzisiejsza Data";
            this.buttonDzisiejszaData.UseVisualStyleBackColor = true;
            this.buttonDzisiejszaData.Click += new System.EventHandler(this.buttonDzisiejszaData_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Exe files (*.exe)|*.exe";
            // 
            // button_WyczyscFormatki
            // 
            this.button_WyczyscFormatki.Location = new System.Drawing.Point(392, 14);
            this.button_WyczyscFormatki.Name = "button_WyczyscFormatki";
            this.button_WyczyscFormatki.Size = new System.Drawing.Size(100, 24);
            this.button_WyczyscFormatki.TabIndex = 4;
            this.button_WyczyscFormatki.Text = "Wyczyść";
            this.button_WyczyscFormatki.UseVisualStyleBackColor = true;
            this.button_WyczyscFormatki.Click += new System.EventHandler(this.button_WyczyscFormatki_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 306);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Archiwum prac";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSciezkaArchiwum;
        private System.Windows.Forms.Button buttonSciezkaArchiwum;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_wyszukaj;
        private System.Windows.Forms.TextBox textBox_wyszukaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxNazwaPlikuTag;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxSciezkaTotalCommander;
        private System.Windows.Forms.Button buttonSciezkaTotalCommander;
        private System.Windows.Forms.Button buttonKonfZapis;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonKonfOdczyt;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonUtworzFolder;
        private System.Windows.Forms.TextBox textBoxNazwaFolderu;
        private System.Windows.Forms.Button buttonDzisiejszaData;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RichTextBox richTextBoxTagi;
        private System.Windows.Forms.Button button_WyczyscFormatki;
    }
}


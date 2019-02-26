using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ArchPrac
{
    public partial class Form1 : Form
    { 
        List<Dane> listaDanych = new List<Dane>();
        Konfiguracja konf = new Konfiguracja();
        
        public Form1()
        {
            InitializeComponent();
            OdczytKonfiguracji();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBoxSciezkaArchiwum.Text = folderBrowserDialog1.SelectedPath;
                    folderBrowserDialog1.Description = "Wybierz katalog, w którym będą wyszukiwane pliki";
                }
            }
            catch
            {
                    MessageBox.Show("Błąd w wyborze folderu", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 0)
                { 
                    Dane wybranyWiersz = listaDanych[e.RowIndex];
                    System.Diagnostics.Process.Start(konf.sciezkaTotalCommander, textBoxSciezkaArchiwum.Text + "\\" + wybranyWiersz.Folder);
                }
            }
            catch
            {
                MessageBox.Show("Błąd otworzenia folderu", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    Dane wybranyWiersz2 = listaDanych[e.RowIndex];

                    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        string textPoZmianie = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Replace("  ", "\r\n");
                        string pathOpistxt = textBoxSciezkaArchiwum.Text + "\\" + listaDanych[e.RowIndex].Folder + "\\" + konf.nazwaPlikuTag;
                        
                        if (File.Exists(pathOpistxt))
                        {
                            System.IO.File.WriteAllText (pathOpistxt, textPoZmianie);
                            MessageBox.Show("Zapis do pliku: " + konf.sciezkaFolderArchiwum + "\\" + listaDanych[e.RowIndex].Folder + "\\" + konf.nazwaPlikuTag +" - OK", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                   
                }
            }
            catch
            {
                MessageBox.Show("Błąd zapisu do pliku Opis.txt", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button_wyszukaj_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string komunikat = "";

            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                listaDanych.Clear();

                List<string> listaFolderow = new List<string>();
                listaFolderow = Directory.GetDirectories(textBoxSciezkaArchiwum.Text).ToList();

                foreach (string s in listaFolderow)
                {
                    if (File.Exists(s + "\\" + konf.nazwaPlikuTag) && (textBox_wyszukaj.Text == ""))
                    {
                        listaDanych.Add(new Dane { Folder = s.Remove(0, textBoxSciezkaArchiwum.Text.Count() + 1), Tagi = System.IO.File.ReadAllText(s + "\\" + konf.nazwaPlikuTag).Replace("\r\n", "  ") });
                    }
                    else if (File.Exists(s + "\\" + konf.nazwaPlikuTag) && (textBox_wyszukaj.Text != ""))
                    {
                        string _tagi = System.IO.File.ReadAllText(s + "\\" + konf.nazwaPlikuTag);
                        if (_tagi.ToUpper().Contains(textBox_wyszukaj.Text.ToUpper()))
                        {
                            listaDanych.Add(new Dane { Folder = s.Remove(0, textBoxSciezkaArchiwum.Text.Count() + 1), Tagi = System.IO.File.ReadAllText(s + "\\" + konf.nazwaPlikuTag).Replace("\r\n", "  ") });
                            
                        }
                    }
                    else
                    {
                        komunikat += "Brak pliku: " + konf.nazwaPlikuTag + " w folderze: " + s + "\n";
                    }
                }
                listaDanych = listaDanych.OrderByDescending(n => n.Folder).ToList();
                int dlugoscNajdluzszegoOpisuFolder = listaDanych.OrderByDescending(n => n.Folder.Length).First().Folder.Length;
                dataGridView1.DataSource = listaDanych;
                dataGridView1.Columns[0].Width = dlugoscNajdluzszegoOpisuFolder * 8;
            }
            catch
            {
                MessageBox.Show("Nieprawidłowa ścieżka lub błędna nazwa pliku tag", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonZapisKonfig_Click(object sender, EventArgs e)
        {
            try
            {  
             konf.nazwaPlikuTag = textBoxNazwaPlikuTag.Text;
             konf.sciezkaFolderArchiwum = textBoxSciezkaArchiwum.Text;
             konf.sciezkaTotalCommander = textBoxSciezkaTotalCommander.Text;

                  string sciezka = Application.StartupPath + "\\Konfiguracja.xml";
                  XmlSerializer sr = new XmlSerializer(typeof(Konfiguracja));
                  StreamWriter tw = new StreamWriter(sciezka); 
                  sr.Serialize(tw, konf);
                  tw.Flush();
                  tw.Close();
                  MessageBox.Show("Plik konfiguracyjny utworzony prawidłowo", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Niepoprawny plik konfiguracyjny", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSciezkaTotalCommander_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSciezkaTotalCommander.Text = openFileDialog1.FileName; 
            }

        }


        private void buttonKonfOdczyt_Click(object sender, EventArgs e)
        {
            OdczytKonfiguracji();
        }

        private void OdczytKonfiguracji()
        {
            try
            {
                string sciezka = Application.StartupPath + "\\Konfiguracja.xml";
                XmlSerializer sr = new XmlSerializer(typeof(Konfiguracja));
                StreamReader tr = new StreamReader(sciezka);
                konf = (Konfiguracja)sr.Deserialize(tr);
                textBoxSciezkaArchiwum.Text = konf.sciezkaFolderArchiwum;
                textBoxSciezkaTotalCommander.Text = konf.sciezkaTotalCommander;
                textBoxNazwaPlikuTag.Text = konf.nazwaPlikuTag;
                tr.Close();
            }
            catch
            {
                MessageBox.Show("Niepoprawny plik konfiguracyjny - Utwórz Nowy", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDzisiejszaData_Click(object sender, EventArgs e)
        {
            textBoxNazwaFolderu.Text = DateTime.Now.Year + "_" + DateTime.Now.Month.ToString("00") + "_" + DateTime.Now.Day.ToString("00");
        }

        private void buttonUtworzFolder_Click(object sender, EventArgs e)
        {  
            if (Directory.Exists(konf.sciezkaFolderArchiwum))
            {
                if (!Directory.Exists(konf.sciezkaFolderArchiwum + "\\" + textBoxNazwaFolderu.Text))
                {
                        Directory.CreateDirectory(konf.sciezkaFolderArchiwum + "\\" + textBoxNazwaFolderu.Text);
                        File.Create(konf.sciezkaFolderArchiwum + "\\" + textBoxNazwaFolderu.Text + "\\" + konf.nazwaPlikuTag).Dispose();
                        File.WriteAllText(konf.sciezkaFolderArchiwum + "\\" + textBoxNazwaFolderu.Text + "\\" + konf.nazwaPlikuTag, richTextBoxTagi.Text.Replace("\n", "\r\n").Replace("  ", "\r\n"));
                        MessageBox.Show("Folder i plik utworzono poprawnie", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                }
                else
                {
                    MessageBox.Show("Folder o takiej nazwie istnieje już w tej lokalizacji lub nazwa folderu nieprawidłowa", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nieprawidłowa ścieżka", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void textBoxSciezkaArchiwum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_WyczyscFormatki_Click(object sender, EventArgs e)
        {
            richTextBoxTagi.Text = "";
            textBoxNazwaFolderu.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using MySqlX.XDevAPI.Common;
using System.Xml.Linq;
using System.Data.Odbc;

namespace Tetelkezelo
{
    public partial class Form1 : Form
    {

        static MySqlConnection kapcsolo;

        private string selected = "";

        public Byte[] Draft;
        public Byte[] Essay;
        public Form1()
        {
            InitializeComponent();
            
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            read.Width = screenWidth / 2;
            upload.Width = screenWidth / 2;
            upload.Location = new Point(screenWidth / 2);

        }

        private void Database()
        {
            string connStr = "server=localhost;user=root;password='';";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd;
            string s0;
            try
            {
                conn.Open();
                s0 = "CREATE DATABASE IF NOT EXISTS Tetelkezelo DEFAULT CHARSET = utf8 COLLATE utf8_hungarian_ci;";
                cmd = new MySqlCommand(s0, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            } catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void read_Click(object sender, EventArgs e)
        {
            if (selected == "upload" || selected == "")
            {
                selected = "read";
                read.BackColor = Color.Orange;
                upload.BackColor = Color.LightGray;
                upload_panel.Visible = false;
                read_panel.Visible = true;
                
                filter_subject.Text = "";
                filter_subject.Items.Clear();

                List<string> subjects = tombLekerdez("SELECT table_name FROM information_schema.tables WHERE table_schema = 'Tetelkezelo';");
                filter_subject.Items.AddRange(subjects.ToArray());

            }

        }
        

        private void upload_Click(object sender, EventArgs e)
        {
            if (selected == "read" || selected == "")
            {
                selected = "upload";
                upload.BackColor = Color.Orange;
                read.BackColor = Color.LightGray;
                upload_panel.Visible = true;
                read_panel.Visible = false;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleTextBox.Text = TitleComboBox.Text;
        }

        private void draft_file_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PDF (*.pdf) | *.pdf";
                if (ofd.ShowDialog() == DialogResult.OK) {
                   draft_file.Text = ofd.FileName;
                    
                    Draft = File.ReadAllBytes(ofd.FileName);
                }
                

            }
            catch {
                MessageBox.Show("Invalid input!");
            
            }
        }

        private void thesis_file_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PDF (*.pdf) | *.pdf";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    essay_file.Text = ofd.FileName;
                    Essay = File.ReadAllBytes(ofd.FileName);
                    
                }
            } catch
            {
                MessageBox.Show("Invalid input!");

            }
        }

        private void addSubject(string subject)
        {
           // DialogResult result = MessageBox.Show("This title does not exist in the database, do you want to add it?", "Confimation", MessageBoxButtons.YesNo);
             

            string sql = $"CREATE TABLE IF NOT EXISTS {subject} (id INT AUTO_INCREMENT PRIMARY KEY, title VARCHAR(255) NOT NULL, draft LONGBLOB, essay LONGBLOB, changed TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP); ";

            Lekerdez(sql, 0);
        }
        private void addTitle(string subject,string title)
        {
            addSubject(subject);
            string sql = $"SELECT id FROM {subject} WHERE title = '{title}'";
            string sorsz = Lekerdez(sql, 1);
            if(sorsz == "")
            {
                DialogResult result = MessageBox.Show("This title does not exist in the database, do you want to add it?", "Confimation", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    sql = $"INSERT IGNORE INTO {subject} (title) Values ('{title}')";
                    Lekerdez(sql, 0);
                }
            
            } 
            else
            {
                
            }

            
            

        }

        private void addDraft(Byte[] data) //my.ini max_allowed_packet = 64M
        {
            string sql = $"select id from {subjectTextBox.Text} where title = '{TitleTextBox.Text}' and draft IS NULL";
            if(Lekerdez(sql,1) == "") //null = true, not null = false
            {
                DialogResult result = MessageBox.Show("There is already a draft for this title, would you like to overwrite?", "Confirmation",MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    string base64Data = Convert.ToBase64String(data);
                    sql = $"update {subjectTextBox.Text} set draft = '{base64Data}' where title = '{TitleTextBox.Text}'";
                    Lekerdez(sql, 0);
                }
            } else
            {

            string base64Data = Convert.ToBase64String(data);
            sql = $"update {subjectTextBox.Text} set draft = '{base64Data}' where title = '{TitleTextBox.Text}'";
            Lekerdez(sql , 0);
            }
        }

        private void addEssay(Byte[] data)
        {

            string sql = $"select id from {subjectTextBox.Text} where title = '{TitleTextBox.Text}' and essay IS NULL";
            if(Lekerdez(sql, 1) == "") //null = true, not null = false
            {
                DialogResult result = MessageBox.Show("There is already an essay for this title, would you like to overwrite?", "Confirmation", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    string base64Data = Convert.ToBase64String(data);
                     sql = $"update {subjectTextBox.Text} set essay = '{base64Data}' where title = '{TitleTextBox.Text}'";
                    Lekerdez(sql, 0);
                }
            } else
            {

                string base64Data = Convert.ToBase64String(data);
                sql = $"update {subjectTextBox.Text} set essay = '{base64Data}' where title = '{TitleTextBox.Text}'";
                Lekerdez(sql, 0);
            }


           
        }

        private void uploadData_Click(object sender, EventArgs e)
        {


            List<string> subjects = tombLekerdez("SELECT table_name FROM information_schema.tables WHERE table_schema = 'Tetelkezelo';");
            if(subjectTextBox.Text == "")
            {
                MessageBox.Show("Missing subject name!");
            } else
            {
                if(TitleTextBox.Text == "")
                {
                    MessageBox.Show("Missing title!");
                } else
                {
                    if(Draft == null)
                    {
                       
                        addTitle(subjectTextBox.Text,TitleTextBox.Text);
                    } else
                    {

                        if(Essay == null)
                        {
                            addTitle(subjectTextBox.Text, TitleTextBox.Text);
                            addDraft(Draft);
                        } else
                        {
                            addTitle(subjectTextBox.Text, TitleTextBox.Text);
                            addDraft(Draft);
                            addEssay(Essay);
                        }

                    }

                   
                        
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database();

            //kapcsoló az adatbázishoz
            kapcsolo = new MySqlConnection("server=localhost;user=root;database=Tetelkezelo;password=''");
            kapcsolo.Open();

            FillSubjects();
            read_panel.Visible = false;
            read_panel.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - 75, 130);
            upload_panel.Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - 300, 130);
        }

        private void FillSubjects()
        {
            List<string> subjects = tombLekerdez("SELECT table_name FROM information_schema.tables WHERE table_schema = 'Tetelkezelo';");
            SubjectComboBox.Items.AddRange(subjects.ToArray());
            
        }


        private byte[] Blobquery(string sql)
        {
            byte[] result = null;

            using(MySqlConnection connection = kapcsolo)
            {
                MySqlCommand command = new MySqlCommand(sql, connection);
               

                using(MySqlDataReader reader = command.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        // Assuming the BLOB data is in the first column
                        if(!reader.IsDBNull(0))
                        {
                            using(MemoryStream ms = new MemoryStream())
                            {
                                long bufferSize = reader.GetBytes(0, 0, null, 0, 0); // Get the size of the data
                                byte[] buffer = new byte[bufferSize];
                                reader.GetBytes(0, 0, buffer, 0, buffer.Length);
                                result = buffer;
                            }
                        }
                    }
                }
            }

            return result;
        }


        static string Lekerdez(string sql, int adatdb)
        {
            string vissza = "";
            MySqlCommand parancs = new MySqlCommand(sql, kapcsolo);
            //NonQuery ha nem vár vissza adatot
            if(adatdb == 0)
            {
                parancs.ExecuteNonQuery();
                return vissza;
            } else
            {
                MySqlDataReader adatolvas = parancs.ExecuteReader();
                while(adatolvas.Read())
                {
                    if(adatdb == 1)
                    {
                        vissza = adatolvas[0].ToString();
                    }
                }
                adatolvas.Close();
                return vissza;
            }

        }
        static List<string> tombLekerdez(string sql)
        {
            MySqlCommand parancs = new MySqlCommand(sql, kapcsolo);
            List<string> vissza = new List<string>();
            MySqlDataReader adatolvas = parancs.ExecuteReader();
            while(adatolvas.Read())
            {
                vissza.Add(adatolvas[0].ToString());
            }
            adatolvas.Close();
            return vissza;
        }

        private void FillTitles(string subject)
        {
            string sql = $"select title from {subject}";
            TitleComboBox.Items.AddRange(tombLekerdez(sql).ToArray());
        }

        private void SubjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleTextBox.Text = "";
            TitleComboBox.Items.Clear();
            subjectTextBox.Text = SubjectComboBox.Text;
            FillTitles(subjectTextBox.Text);
        }

        private void filter_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter_title.Text = "";
            filter_title.Items.Clear();
            string sql = $"select title from {filter_subject.Text}";
            filter_title.Items.AddRange(tombLekerdez(sql).ToArray());
        }

        private void filter_title_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void view_draft_Click(object sender, EventArgs e)
        {
            string sql = $"select draft from {filter_subject.Text} where title = '{filter_title.Text}'";

            byte[] base64PdfBytes = Blobquery(sql);

            string base64PdfString = Encoding.UTF8.GetString(base64PdfBytes);

            byte[] pdfBytes = Convert.FromBase64String(base64PdfString);
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
              
                File.WriteAllBytes($"{selectedPath}/{filter_title.Text}_draft.pdf", pdfBytes);
            }


        }

        private void view_essay_Click(object sender, EventArgs e)
        {
            string sql = $"select essay from {filter_subject.Text} where title = '{filter_title.Text}'";

            byte[] base64PdfBytes = Blobquery(sql);

           
            string base64PdfString = Encoding.UTF8.GetString(base64PdfBytes);

            byte[] pdfBytes = Convert.FromBase64String(base64PdfString);


            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                File.WriteAllBytes($"{selectedPath}/{filter_title.Text}_essay.pdf", pdfBytes);
            }

        }
    }
}

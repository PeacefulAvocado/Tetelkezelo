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
                upload.BackColor = Color.Gray;
            }
            
        }

        private void upload_Click(object sender, EventArgs e)
        {
            if (selected == "read" || selected == "")
            {
                selected = "upload";
                upload.BackColor = Color.Orange;
                read.BackColor = Color.Gray;
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
            
        }

        private void draft_file_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "PDF (*.pdf) | *.pdf";
                if (ofd.ShowDialog() == DialogResult.OK) {
                    //StreamReader bef = new StreamReader(ofd.FileName);
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
                    //StreamReader bef = new StreamReader(ofd.FileName);
                    Essay = File.ReadAllBytes(ofd.FileName);
                }
            } catch
            {
                MessageBox.Show("Invalid input!");

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


                DialogResult result = MessageBox.Show("This title does not exist in the database, do you want to add it?", "Confimation", MessageBoxButtons.YesNo);
                string subject = subjectTextBox.Text;
                
                string sql = $"CREATE TABLE IF NOT EXISTS {subject} (id INT AUTO_INCREMENT PRIMARY KEY, title VARCHAR(255) NOT NULL, draft MEDIUMTEXT, essay MEDIUMTEXT, changed TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP); ";

                Lekerdez(sql,0);


                if(TitleTextBox.Text == "")
                {
                    MessageBox.Show("Missing title!");
                } else
                {
                    result = MessageBox.Show("This title does not exist in the database, do you want to add it?", "Confimation", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                    {
                        sql = $"INSERT IGNORE INTO {subject} (title) Values ({TitleTextBox.Text})";
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
    }
}

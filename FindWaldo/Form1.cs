using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindWaldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gpo_Info.Enabled = false;
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpo_Info.Enabled = true;
            pct_Image.Image = global::FindWaldo.Properties.Resources._1;
            mode = 1;
            txt_Mode.Text = "Easy";
        }
        private DateTime _start;
        public int mode;
        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("Enter player name!", "Attention");
            }
            else
            {
                _start = DateTime.Now;
                gameTime.Start();
            }
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Now - _start;
            txt_Time.Text = duration.Hours.ToString("00")+":" + duration.Minutes.ToString("00")+ ":" + duration.Seconds.ToString("00");
        }

        private void limpia()
        {
            txt_Name.Text = "";
            txt_Mode.Text = "";
            txt_Time.Text = "";
            pct_Image.Image = global::FindWaldo.Properties.Resources._0;
            gpo_Info.Enabled = false;
        }
        private void saveNshow()
        {
            string conString = null;
            conString = "Server=LAPTOP-7D6DN5RT\\SQLEXPRESS;Database=FindWaldo;Trusted_Connection=true;";
            SqlConnection conn;
            conn = new SqlConnection(conString);
            SqlCommand com2;
            string query2;
            query2 = "INSERT INTO Records VALUES('" + txt_Name.Text + "','" + txt_Mode.Text + "','" + txt_Time.Text + "');";
            try
            {
                conn.Open();
                com2 = new SqlCommand(query2, conn);
                com2.ExecuteNonQuery();
                
                com2.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            SqlCommand com;
            SqlDataReader dataReader;
            string query;
            query = "SELECT * FROM Records order by Tiempo ASC, Modo DESC;";
            try
            {
                conn.Open();
                com = new SqlCommand(query, conn);
                dataReader = com.ExecuteReader();
                string data = "Nombre     | Dificultad          |Tiempo \n";
                while (dataReader.Read())
                {
                    data += dataReader.GetValue(0) + "        " + dataReader.GetValue(1) + "          \t" + dataReader.GetValue(2) + "\n";
                }
                MessageBox.Show(data);
                com.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_Time.Text == "")
            {
                MessageBox.Show("Start the game!!", "Attention");
            }
            else
            {
                if (mode == 1)
                {
                    if (e.X >= 722 && e.X <= 763 && e.Y >= 83 && e.Y <= 153)
                    {
                        gameTime.Stop();
                        MessageBox.Show("Congratulations!!! You found Waldo in: " + txt_Time.Text);
                        saveNshow();
                        limpia();
                    }
                }
                else if (mode == 2)
                {
                    if (e.X >= 500 && e.X <= 533 && e.Y >= 346 && e.Y <= 386)
                    {
                        gameTime.Stop();
                        MessageBox.Show("Congratulations!!! You found Waldo in: " + txt_Time.Text);
                        saveNshow();
                        limpia();
                    }
                }
                else if (mode == 3)
                {
                    if (e.X >= 384 && e.X <= 424 && e.Y >= 244 && e.Y <= 284)
                    {
                        gameTime.Stop();
                        MessageBox.Show("Congratulations!!! You found Waldo in: " + txt_Time.Text);
                        saveNshow();
                        limpia();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.MouseClick += new MouseEventHandler(Form1_MouseClick);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpo_Info.Enabled = true;
            pct_Image.Image = global::FindWaldo.Properties.Resources._2;
            mode = 2;
            txt_Mode.Text = "Medium";
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpo_Info.Enabled = true;
            pct_Image.Image = global::FindWaldo.Properties.Resources._3;
            mode = 3;
            txt_Mode.Text = "Hard";
        }
    }
}

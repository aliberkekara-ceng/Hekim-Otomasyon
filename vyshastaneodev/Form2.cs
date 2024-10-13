using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vyshastaneodev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            veri_goster("select * from muayene;");
        }

        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=muayene;");


        public void veri_goster(string sql)
        {
            connection.Open();
            NpgsqlCommand komut_ = new NpgsqlCommand(sql, connection);
            NpgsqlDataReader reader = komut_.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
            }
            connection.Close();
            reader.Close();
            komut_.Dispose();
        }

        public void ilac_alanlari_goster()
        {
            connection.Open();

            string sql;

            if (textBox1.Text == "1")
            {
                 sql = "select * from muayene where verilen_ilac1='1' OR verilen_ilac2='1' OR verilen_ilac3='1' OR verilen_ilac4='1' OR verilen_ilac5='1';";
            }
            else if (textBox1.Text == "2")
            {
                sql = "select * from muayene where verilen_ilac1='2' OR verilen_ilac2='2' OR verilen_ilac3='2' OR verilen_ilac4='2' OR verilen_ilac5='2';";
            }
            else if (textBox1.Text == "3")
            {
                sql = "select * from muayene where verilen_ilac1='3' OR verilen_ilac2='3' OR verilen_ilac3='3' OR verilen_ilac4='3' OR verilen_ilac5='3';";
            }
            else if (textBox1.Text == "4")
            {
                sql = "select * from muayene where verilen_ilac1=4 OR verilen_ilac2=4 OR verilen_ilac3=4 OR verilen_ilac4=4 OR verilen_ilac5=4;";
            }
            else if (textBox1.Text == "5")
            {
                sql = "select * from muayene where verilen_ilac1=5 OR verilen_ilac2=5 OR verilen_ilac3=5 OR verilen_ilac4=5 OR verilen_ilac5=5;";
            }
            else
            {
                 sql = "select tc_kimlik from muayene;";
            }

            NpgsqlCommand komut_ = new NpgsqlCommand(sql, connection);

            NpgsqlDataReader reader = komut_.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
            }
            connection.Close();
            reader.Close();
            komut_.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ilac_alanlari_goster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            veri_goster("select * from muayene order by muayene_tarihi DESC;");
        }
    }
}

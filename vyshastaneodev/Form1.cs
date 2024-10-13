using Npgsql;
using System.Data;

namespace vyshastaneodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hasta_verilerini_goster();
            ilac_verilerini_goster();
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
                dataGridView3.DataSource = dataTable;
            }
            connection.Close();
            reader.Close();
            komut_.Dispose();
        }

        public void hasta_verilerini_goster()
        {          
            connection.Open();

            string sql = "select * from hasta";

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

        public void ilac_verilerini_goster()
        {            
            connection.Open();

            string sql = "select * from ilac";

            NpgsqlCommand komut_ = new NpgsqlCommand(sql, connection);

            NpgsqlDataReader reader = komut_.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView2.DataSource = dataTable;
            }
            connection.Close();
            reader.Close();
            komut_.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            string sql = "insert into muayene (tc_kimlik, muayene_tarihi, hasta_sikayet, hastalık_teshis, recete_no, verilen_ilac1, verilen_ilac2, verilen_ilac3, verilen_ilac4, verilen_ilac5) values (@tc_kimlik, @muayene_tarihi, @hasta_sikayet, @hastalık_teshis, @recete_no, @verilen_ilac1, @verilen_ilac2, @verilen_ilac3, @verilen_ilac4, @verilen_ilac5)";

            NpgsqlCommand komut_ekle = new NpgsqlCommand(sql,connection);

            komut_ekle.Parameters.AddWithValue("@tc_kimlik", Convert.ToInt32(txt_tcKimlikNo.Text));
            komut_ekle.Parameters.AddWithValue("@muayene_tarihi", Convert.ToDateTime(txt_muayeneTarihi.Text));
            komut_ekle.Parameters.AddWithValue("@hasta_sikayet", txt_hastaSikayet.Text);
            komut_ekle.Parameters.AddWithValue("@hastalık_teshis", txt_hastalikTeshis.Text);
            komut_ekle.Parameters.AddWithValue("@recete_no", Convert.ToInt32(txt_receteNo.Text));

            komut_ekle.Parameters.AddWithValue("@verilen_ilac1", Convert.ToInt32(txt_ilac1.Text));
            komut_ekle.Parameters.AddWithValue("@verilen_ilac2", Convert.ToInt32(txt_ilac2.Text));
            komut_ekle.Parameters.AddWithValue("@verilen_ilac3", Convert.ToInt32(txt_ilac3.Text));
            komut_ekle.Parameters.AddWithValue("@verilen_ilac4", Convert.ToInt32(txt_ilac4.Text));
            komut_ekle.Parameters.AddWithValue("@verilen_ilac5", Convert.ToInt32(txt_ilac5.Text));

            int rowsAffected = komut_ekle.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Reçete yazıldı ve muayene defterine kaydedildi.");
                txt_hastalikTeshis.Clear();
                txt_ilac1.Clear();
                txt_ilac2.Clear();
                txt_ilac3.Clear();
                txt_ilac4.Clear();
                txt_ilac5.Clear();
                txt_muayeneTarihi.Clear();
                txt_receteNo.Clear();
                txt_tcKimlikNo.Clear();
                txt_hastaSikayet.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen girdiğiniz değerlere dikkat edin.");
            }

            komut_ekle.Dispose();                                 
            connection.Close();
            veri_goster("select * from muayene;");

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void verileriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
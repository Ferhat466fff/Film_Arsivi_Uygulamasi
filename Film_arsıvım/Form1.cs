using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Film_arsıvım
{
    public partial class Form1 : Form
    {  //renk değiştirmek icin color sınıfını kullandık
        public static Color[] renkler = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Purple, Color.Pink, Color.Gray, Color.Brown, Color.DarkBlue };
        public Form1()
        {
            InitializeComponent();

        }
        SqlConnection baglantı = new SqlConnection("Data Source=MONSTER;Initial Catalog=Film_Arşivi;Integrated Security=True");
        void listele()
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_FİLMLER", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglantı.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void btn_KAYDET_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_FİLMLER (AD,KATEGORI,LINK)VALUES(@P1,@P2,@P3)", baglantı);
            komut.Parameters.AddWithValue("@p1", txt_FİLM_AD.Text);
            komut.Parameters.AddWithValue("@p2", txt_KATEGORII.Text);
            komut.Parameters.AddWithValue("@p3", txt_LINK.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Film'iniz Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            baglantı.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_FİLM_AD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_KATEGORII.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_LINK.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string lınk = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            webBrowser1.Navigate(lınk);

        }

        private void btn_HAKKIMIZDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Proje Ferhat Sakar tarafından 23.02.2024 Tarihinde yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_ÇIKIŞ_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_RENK_DEĞİŞ_Click(object sender, EventArgs e)
        {
            //Butona Tıklayınca 10 Renkten Rastgele bir Renk alsın

            Random random = new Random();
            int index = random.Next(renkler.Length);//index=renklerin uzunlugunca rastgele renk alacak
           this.BackColor = renkler[index];
            //form1 arka plan=renklerin indexine gore
        }
    }
}

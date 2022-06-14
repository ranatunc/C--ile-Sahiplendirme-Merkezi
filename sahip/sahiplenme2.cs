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


namespace projeclab
{
    public partial class sahiplenme2 : Form
    {
        public sahiplenme2()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-JTO494P;Initial Catalog=oopproje;Integrated Security=True");
        
        
        
        private void sahiplenme2_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from sahiplendirme", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            
        }
       
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            



            if (tad.Text == "" || String.IsNullOrEmpty(tsoyad.Text) || string.IsNullOrEmpty(mtel.Text) || String.IsNullOrEmpty(radres.Text) || String.IsNullOrEmpty(ccins.Text) || String.IsNullOrEmpty(tyas.Text) || String.IsNullOrEmpty(ccinsiyet.Text) )
            {
                MessageBox.Show("LÜTFEN EKSİK ALAN BIRAKMAYINIZ.");
            }
            

            else if(mtel.TextLength == 10)
            {

                bgl.Open();
                SqlCommand komut1 = new SqlCommand("insert into sahiplendirme (shpad,shpsoyad,shpadres,shpcins,shpyas,shpcinsiyet,shptel)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7) ", bgl);
                komut1.Parameters.AddWithValue("@p1", tad.Text);
                komut1.Parameters.AddWithValue("@p2", tsoyad.Text);
                komut1.Parameters.AddWithValue("@p3", radres.Text);
                komut1.Parameters.AddWithValue("@p4", ccins.Text);
                komut1.Parameters.AddWithValue("@p5", tyas.Text);
                komut1.Parameters.AddWithValue("@p6", ccinsiyet.Text);
                komut1.Parameters.AddWithValue("@p7", mtel.Text);
                komut1.ExecuteNonQuery();
                                      
                bgl.Close();
                MessageBox.Show("Sahiplendirme işlemi başarıyla gerçekleşmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else              
            {
                MessageBox.Show("LÜTFEN TELEFONUNUZU EKSİKSİZ GİRİNİZ.");
            }



        }

      
        private void btnyenile_Click(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from sahiplendirme", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void bsil_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut1 = new SqlCommand("delete from sahiplendirme where shpad=@p1 and shpsoyad=@p2", bgl);
            komut1.Parameters.AddWithValue("@p1", tad.Text);
            komut1.Parameters.AddWithValue("@p2", tsoyad.Text);
            komut1.ExecuteNonQuery();

            bgl.Close();
            MessageBox.Show("Kaydınız başarılı bir şekilde silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tad_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void mtel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
             
        }

        private void tsoyad_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tyas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
  
        private void mtel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}

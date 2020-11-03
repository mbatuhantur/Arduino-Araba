using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;


namespace araba
{
    public partial class Form1 : Form
    {
        
        SerialPort deneme = new SerialPort("COM3", 9600);

        public Form1()
        {
            InitializeComponent();

            
            deneme.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            deneme.Write("u");
            
        }
        SqlConnection baglan = new SqlConnection("Data Source=WINDOWS81SL\\SQLEXPRESS; Initial Catalog=araba; Integrated Security=true ");
    
    private void Form1_Load(object sender, EventArgs e)
        {
            baglan.Open();
            label1.Text = DateTime.Today.ToShortDateString();

            string kayit1 = "INSERT INTO araba.dbo.giris(tarih) Values (@tarih)";
            SqlCommand komut1 = new SqlCommand(kayit1, baglan);

            komut1.Parameters.AddWithValue("@tarih", Convert.ToDateTime(label1.Text));
            komut1.ExecuteNonQuery();
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            deneme.Write("b");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deneme.Write("l");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deneme.Write("r");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deneme.Write("s");
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }
    }
}

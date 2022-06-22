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

namespace Travel_Management_System
{
    public partial class Packages : Form
    {
        public Packages()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        string Select_Package;
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Select_Package = "Package3";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BR1CNRR;Initial Catalog=Registration_R;User ID=sa;Password=r15v2celica");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Travel(Select_Package) VALUES (@Select_Package)", con);



            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Package Selection Sucessful");
            BlindData();

        }
        void BlindData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BR1CNRR;Initial Catalog=Travel_T;User ID=sa;Password=r15v2celica");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Travel", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Select_Package = "Package1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Select_Package = "Package2";

        }

        private void Packages_Load(object sender, EventArgs e)
        {
            void BlindData()
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-BR1CNRR;Initial Catalog=Travel_T;User ID=sa;Password=r15v2celica");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Travel", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

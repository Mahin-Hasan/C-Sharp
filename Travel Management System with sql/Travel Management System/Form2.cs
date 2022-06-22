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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BR1CNRR;Initial Catalog=Travel_T;User ID=sa;Password=r15v2celica");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Travel", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BR1CNRR;Initial Catalog=Travel_T;User ID=sa;Password=r15v2celica");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Travel(UserName, Password, Confirm_Pass, Email,Location, Number, NID,Gender) VALUES(@UserName, @Password, @Confirm_Pass, @Email, @Location, @Number, @NID,@Gender)", con);
            cmd.Parameters.AddWithValue("@UserName", (textBox1.Text));
            cmd.Parameters.AddWithValue("@Password", (textBox2).Text);
            cmd.Parameters.AddWithValue("@Confirm_Pass", (textBox3.Text));
            cmd.Parameters.AddWithValue("@Email", (textBox4.Text));
            cmd.Parameters.AddWithValue("@Location", (textBox5.Text));
            cmd.Parameters.AddWithValue("@Number", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@NID", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@Gender", (textBox8.Text));

            cmd.ExecuteNonQuery();

            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";


            MessageBox.Show("Sign up Sucessful");
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
            dataGridView1.DataSource = dt;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyutnii_burtgel
{
    public partial class Form1 : Form
    {
        public object LstLanguage { get; }

        public Form1(string v)
        {
            InitializeComponent();

            LstLanguage.SelectedItem = v;

            comboBox1.DataSource = null;
            comboBox1.Items.Clear();

            comboBox1.Items.Add("Мэдээллийн технологи");
            comboBox1.Items.Add("Компьютерын ухаан");
            comboBox1.Items.Add("Программ хангамж");
            comboBox1.Items.Add("Математик");
            comboBox1.Items.Add("Физик");

            comboBox1.SelectedIndex = 0;
    
        InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void istlanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            MessageBox.Show("Оюутан амжилттай бүртгэгдлээ!");


        }
    }
}

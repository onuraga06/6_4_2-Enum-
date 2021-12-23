using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_4_2_Enum_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         //Enumdakı verılerı combobox'a ekledik.   
            comboBox1.Items.AddRange(Enum.GetNames(typeof(Fren_Tipi)));
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.AddRange(Enum.GetNames(typeof(KadroTipi)));
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bisiklet b=new Bisiklet();
            b.Fren = (Fren_Tipi)comboBox1.SelectedIndex;
            b.Kadro =(KadroTipi)comboBox2.SelectedIndex;
            b.ModelYil = dateTimePicker1.Value.Year;
            textBox1.Text = b.Yas.ToString();
            MessageBox.Show(b.ToString());
        }
    }
}

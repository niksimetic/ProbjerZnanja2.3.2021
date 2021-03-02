using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nikSimeticIspit2._3._2021
{
    public partial class Form2 : Form
    {
        List<Osoba> Lista = new List<Osoba>();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text );
            
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
        }
    }
}

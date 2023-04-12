using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace binTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> jmena = new List<string>();
        List<string> znamky = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            FileStream datovy_tok = new FileStream("seznam.dat", FileMode.Open, FileAccess.ReadWrite);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        int index = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            FileStream datovy_tok = new FileStream("seznam.dat", FileMode.Create, FileAccess.ReadWrite);

            BinaryWriter bw = new BinaryWriter(datovy_tok);

            bw.Write(textBox1.Text + ";");

            for (int i = 0; i < textBox2.Lines.Length; i++)
            {
                bw.Write(textBox2.Lines[i]);
            }
            datovy_tok.Close();
            index++;
        }
    }
}

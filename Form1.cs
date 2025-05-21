using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciclo for

namespace CicloFOR_BF_5toB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (int.TryParse(txtNúmero1.Text, out int num))
            {
                for (int i = 1; i <= 10; i++)
                {
                    listBox1.Items.Add($"{num} * {i} = {i * num}");
                }

            }
            else
            {
                MessageBox.Show("ingrese un número valido: ");
            }
        }
    }

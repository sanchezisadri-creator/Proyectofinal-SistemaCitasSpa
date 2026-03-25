using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaCitasSpa
{
    public partial class Form2 : Form
    {
        List<string> citas = new List<string>();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 ventana = new Form3();
            ventana.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Por favor escribe una cita");
            }
            else
            {
                citas.Add(textBox1.Text);

                MessageBox.Show("Cita agregada correctamente");
                textBox1.Clear();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (string c in citas)
            {
                listBox1.Items.Add(c);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una cita para eliminar");
            }
            else
            {
                citas.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                MessageBox.Show("Cita eliminada");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
        }
    }
}

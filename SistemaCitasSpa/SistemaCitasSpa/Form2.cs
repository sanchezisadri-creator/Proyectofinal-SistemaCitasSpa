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
        int CalcularDuracion(string servicio)
        {
            switch (servicio.ToLower())
            {
                case "masaje": return 60;
                case "facial": return 45;
                case "manicura": return 30;
                default: return 0;
            }
        }
        string CalcularTiempoRestante(DateTime fechaHora)
        {
            TimeSpan diferencia = fechaHora - DateTime.Now;

            if (diferencia.TotalSeconds < 0)
                return "Ya pasó";

            return diferencia.Days + " días " + diferencia.Hours + " horas";
        }
        string CalcularEstado(DateTime fechaHora)
        {
            if (fechaHora < DateTime.Now)
                return "Finalizado";

            if ((fechaHora - DateTime.Now).TotalHours <= 24)
                return "En proceso";

            return "Vigente";
        }
        void LimpiarCampos()
        {
            textBoxID.Clear();
            textBoxPaciente.Clear();
            comboBoxDentista.SelectedIndex = -1;    
            comboBoxTerapeuta.SelectedIndex = -1;   
            comboBoxServicio.SelectedIndex = -1;
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        List<string> citas = new List<string>();
        public Form2()
        {
            InitializeComponent();
            this.MouseDown += Form2_MouseDown;
            this.MouseDown += Form2_MouseDown;
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

        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Aquí ponemos los nombres de los dentistas
            comboBoxDentista.Items.Add("Dr. Juan Pérez");
            comboBoxDentista.Items.Add("Dra. María López");
            comboBoxDentista.Items.Add("Dr. Carlos Ramírez");
            comboBoxDentista.Items.Add("Dra. Ana Martínez");

            // Aquí ponemos los nombres de los terapeutas
            comboBoxTerapeuta.Items.Add("Terapeuta Luis Gómez");
            comboBoxTerapeuta.Items.Add("Terapeuta Carla Díaz");
            comboBoxTerapeuta.Items.Add("Terapeuta Miguel Torres");
            comboBoxTerapeuta.Items.Add("Terapeuta Sofía Ruiz");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "" ||
        textBoxPaciente.Text == "" ||
        comboBoxDentista.Text == "" ||
        comboBoxTerapeuta.Text == "" ||
        comboBoxServicio.Text == "")
            {
                MessageBox.Show("Complete todos los campos obligatorios");
                return;
            }

            DateTime fechaHora = dateTimePickerFecha.Value.Date + dateTimePickerHora.Value.TimeOfDay;

            if (fechaHora < DateTime.Now)
            {
                MessageBox.Show("No puedes agendar una cita en el pasado");
                return;
            }

            string servicio = comboBoxServicio.Text;
            int duracion = CalcularDuracion(servicio);

            string tiempoRestante = CalcularTiempoRestante(fechaHora);
            string estado = CalcularEstado(fechaHora);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == textBoxID.Text)
                {
                    MessageBox.Show("El ID ya existe");
                    return;
                }
            }

            string dentista = comboBoxDentista.Text;
            string terapeuta = comboBoxTerapeuta.Text;

            dataGridView1.Rows.Add(
                textBoxID.Text,
                textBoxPaciente.Text,
                dateTimePickerFecha.Value.ToShortDateString(),
                dateTimePickerHora.Value.ToShortTimeString(),
                dentista,
                comboBoxServicio.Text,
                duracion + " min",
                terapeuta,
                tiempoRestante,
                estado
            );

            LimpiarCampos();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            bool encontrado = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == textBoxID.Text)
                {
                    dataGridView1.Rows.Remove(row);
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("ID no encontrado");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                textBoxID.Text = fila.Cells[0].Value?.ToString();
                textBoxPaciente.Text = fila.Cells[1].Value?.ToString();
                comboBoxDentista.Text = fila.Cells[4].Value?.ToString();   
                comboBoxServicio.Text = fila.Cells[5].Value?.ToString();
                comboBoxTerapeuta.Text = fila.Cells[7].Value?.ToString();
            }
        }
    }
}

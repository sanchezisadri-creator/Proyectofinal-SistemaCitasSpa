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
        int contadorID = 1;

        bool panelAbierto = true;

        int indiceImagen = 0;
        List<Image> imagenes = new List<Image>();

        int velocidadPanel = 10;
        int alturaMaxima = 278;
        int alturaMinima = 30;
        bool expandiendo = false;
        public Form2()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

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
            this.Owner.Show();
            this.Close(); ;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Owner.WindowState = FormWindowState.Maximized;
            this.Owner.Refresh();
            this.Close();
        }

        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            comboBoxDentista.Items.Add("Dr. Juan Pérez");
            comboBoxDentista.Items.Add("Dra. María López");
            comboBoxDentista.Items.Add("Dr. Carlos Ramírez");
            comboBoxDentista.Items.Add("Dra. Ana Martínez");


            comboBoxTerapeuta.Items.Add("Terapeuta Luis Gómez");
            comboBoxTerapeuta.Items.Add("Terapeuta Carla Díaz");
            comboBoxTerapeuta.Items.Add("Terapeuta Miguel Torres");
            comboBoxTerapeuta.Items.Add("Terapeuta Sofía Ruiz");

            imagenes.Add(Image.FromFile("Imagenes/imagen1.jpg"));
            imagenes.Add(Image.FromFile("Imagenes/imagen2.jpg"));
            imagenes.Add(Image.FromFile("Imagenes/imagen3.jpg"));

            pictureBox1.Image = imagenes[0];

            timer1.Start();
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
            if (textBoxPaciente.Text == "" ||
         comboBoxDentista.Text == "" ||
         comboBoxTerapeuta.Text == "" ||
         comboBoxServicio.Text == "")
            {
                MessageBox.Show("Complete todos los campos obligatorios");
                return;
            }

            DateTime fechaHora = dateTimePickerFecha.Value.Date + dateTimePickerHora.Value.TimeOfDay;


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string fechaExistente = row.Cells[2].Value.ToString();
                    string horaExistente = row.Cells[3].Value.ToString();
                    string dentistaExistente = row.Cells[4].Value.ToString();

                    string nuevaFecha = dateTimePickerFecha.Value.ToShortDateString();
                    string nuevaHora = dateTimePickerHora.Value.ToShortTimeString();

                    if (fechaExistente == nuevaFecha &&
                        horaExistente == nuevaHora &&
                        dentistaExistente == comboBoxDentista.Text)
                    {
                        MessageBox.Show("Este dentista ya tiene una cita a esa hora");
                        return;
                    }
                }
            }

            if (fechaHora < DateTime.Now)
            {
                MessageBox.Show("No puedes agendar una cita en el pasado");
                return;
            }

            string servicio = comboBoxServicio.Text;
            int duracion = CalcularDuracion(servicio);

            string tiempoRestante = CalcularTiempoRestante(fechaHora);
            string estado = CalcularEstado(fechaHora);

            string dentista = comboBoxDentista.Text;
            string terapeuta = comboBoxTerapeuta.Text;

            dataGridView1.Rows.Add(
                contadorID,
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
            contadorID++;
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

            LimpiarCampos();
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

        private void buttonMute_Click(object sender, EventArgs e)
        {
            if (MusicaGlobal.estaSonando)
            {
                MusicaGlobal.Detener();
                buttonMute.Text = "🔇";
            }
            else
            {
                MusicaGlobal.Iniciar();
                buttonMute.Text = "🔊";
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Seleccione una cita para editar");
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null &&
                    row.Cells[0].Value.ToString() == textBoxID.Text)
                {
                    // 🔍 VALIDAR SI NO HUBO CAMBIOS
                    if (
                        row.Cells[1].Value?.ToString() == textBoxPaciente.Text &&
                        row.Cells[2].Value?.ToString() == dateTimePickerFecha.Value.ToShortDateString() &&
                        row.Cells[3].Value?.ToString() == dateTimePickerHora.Value.ToShortTimeString() &&
                        row.Cells[4].Value?.ToString() == comboBoxDentista.Text &&
                        row.Cells[5].Value?.ToString() == comboBoxServicio.Text &&
                        row.Cells[7].Value?.ToString() == comboBoxTerapeuta.Text
                    )
                    {
                        MessageBox.Show("No se realizaron cambios");
                        return;
                    }

                    DateTime fechaHora = dateTimePickerFecha.Value.Date + dateTimePickerHora.Value.TimeOfDay;

                    string servicio = comboBoxServicio.Text;
                    int duracion = CalcularDuracion(servicio);

                    string tiempoRestante = CalcularTiempoRestante(fechaHora);
                    string estado = CalcularEstado(fechaHora);

                    row.Cells[1].Value = textBoxPaciente.Text;
                    row.Cells[2].Value = dateTimePickerFecha.Value.ToShortDateString();
                    row.Cells[3].Value = dateTimePickerHora.Value.ToShortTimeString();
                    row.Cells[4].Value = comboBoxDentista.Text;
                    row.Cells[5].Value = servicio;
                    row.Cells[6].Value = duracion + " min";
                    row.Cells[7].Value = comboBoxTerapeuta.Text;
                    row.Cells[8].Value = tiempoRestante;
                    row.Cells[9].Value = estado;

                    MessageBox.Show("Cita actualizada correctamente");
                    LimpiarCampos();
                    return;
                }
            }

            MessageBox.Show("ID no encontrado");
        }

        private void buttonToggle_Click(object sender, EventArgs e)
        {
            timerPanel.Start();

            if (panelAbierto)
            {
                expandiendo = false;
                buttonToggle.Text = "▼";
            }
            else
            {
                expandiendo = true;
                buttonToggle.Text = "▲";
            }
        }

        private void timerPanel_Tick(object sender, EventArgs e)
        {
            if (expandiendo)
            {
                if (panelGrid.Height < alturaMaxima)
                {
                    panelGrid.Height += velocidadPanel;
                }
                else
                {
                    timerPanel.Stop();
                    panelAbierto = true;
                }
            }
            else
            {
                if (panelGrid.Height > alturaMinima)
                {
                    panelGrid.Height -= velocidadPanel;
                }
                else
                {
                    timerPanel.Stop();
                    panelAbierto = false;
                }
            }
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo CSV (*.csv)|*.csv";
            guardar.Title = "Guardar citas";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();


                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    sb.Append(dataGridView1.Columns[i].HeaderText);

                    if (i < dataGridView1.Columns.Count - 1)
                        sb.Append(",");
                }
                sb.AppendLine();


                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            sb.Append(row.Cells[i].Value?.ToString());

                            if (i < dataGridView1.Columns.Count - 1)
                                sb.Append(",");
                        }
                        sb.AppendLine();
                    }
                }

                System.IO.File.WriteAllText(guardar.FileName, sb.ToString());

                MessageBox.Show("Citas exportadas correctamente");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            indiceImagen++;

            if (indiceImagen >= imagenes.Count)
                indiceImagen = 0;

            pictureBox1.Image = imagenes[indiceImagen];
        }
    }
}

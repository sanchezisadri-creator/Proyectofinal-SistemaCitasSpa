using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace SistemaCitasSpa
{
    public partial class FormAsistente : Form
    {

        public FormAsistente()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxCitas.Visible = true;


            textBoxCitas.Text = "Para reservar tu cita, selecciona el servicio que deseas y escoge la fecha y hora disponibles. También puedes llamarnos directamente para agendar. TEl.809-206-8469";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxCitas.Visible = false;
            textBoxHorarios.Visible = true;

            textBoxHorarios.Text = "Nuestros horarios de atención son:\r\n" +
                                    "Lunes a Viernes: 9:00 AM - 8:00 PM\r\n" +
                                    "Sábados: 10:00 AM - 5:00 PM\r\n" +
                                    "Domingos: Cerrado";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxCitas.Visible = false;
            textBoxHorarios.Visible = false;
            textBoxContactos.Visible = true;

            textBoxContactos.Text = "Puedes contactarnos a través de:\r\n" +
                                    "📞 Teléfono: 809-XXX-XXXX\r\n" +
                                    "📧 Email: spa@ejemplo.com\r\n" +
                                    "📍 Dirección: Av. Principal #123, Santo Domingo";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxCitas.Visible = false;
            textBoxHorarios.Visible = false;
            textBoxContactos.Visible = false;
            textBoxPrecios.Visible = true;

            
            textBoxPrecios.Text = "Nuestros servicios:\r\n" +
                                  "💆 Masaje relajante – RD$1,500 DOP \r\n" +
                                  "💅 Manicure – RD$700 DOP\r\n" +
                                  "💇 Corte de cabello – RD$500 DOP \r\n" +
                                  "🧖 Spa facial – RD$1,200 DOP";
        }
    }
}

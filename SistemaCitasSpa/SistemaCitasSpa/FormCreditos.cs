using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaCitasSpa
{
    public partial class FormCreditos : Form
    {
        public FormCreditos()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelCreditos.Top -= 2;

            if (labelCreditos.Bottom < 0)
            {
                timerCreditos.Stop();
                this.Close();
            }
        }

        private void FormCreditos_Load(object sender, EventArgs e)
        {
            labelCreditos.Top = this.Height;
            timerCreditos.Start();
        }
    }
}



namespace SistemaCitasSpa
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        int paso = 0;

        string numero = "📞 829-123-231";
        string textoOriginal = "📞";
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += Form1_MouseDown;
            this.MouseDown += Form1_MouseDown;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            ventana.WindowState = FormWindowState.Maximized;
            ventana.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Left = -200;
            button3.Left = -200;
            button4.Left = -250;



            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int velocidad = 15;

            int destino = 50;


            if (button1.Left < destino)
            {
                button1.Left += velocidad;
            }

            else if (button3.Left < destino)
            {
                button3.Left += velocidad;
            }

            else if (button4.Left < destino)
            {
                button4.Left += velocidad;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.Text = numero;
            label6.ForeColor = Color.Gold;
            label6.Font = new Font("Segoe UI", 12, FontStyle.Regular);

        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.Text = textoOriginal;
            label6.ForeColor = Color.White;
            label6.Font = new Font("Segoe UI", 18, FontStyle.Regular);
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FormCreditos f = new FormCreditos();


            f.StartPosition = FormStartPosition.Manual;

            f.Location = new Point(
                this.Location.X + (this.Width - f.Width) / 2,
                this.Location.Y + (this.Height - f.Height) / 2
            );

            f.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            FormAsistente asistente = new FormAsistente();


            asistente.TopLevel = false;
            asistente.FormBorderStyle = FormBorderStyle.None;
            asistente.Size = new Size(300, 400);
            asistente.Location = new Point(
                this.ClientSize.Width - asistente.Width - 20,
                this.ClientSize.Height - asistente.Height - 20
            );


            this.Controls.Add(asistente);


            asistente.BringToFront();


            asistente.Show();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


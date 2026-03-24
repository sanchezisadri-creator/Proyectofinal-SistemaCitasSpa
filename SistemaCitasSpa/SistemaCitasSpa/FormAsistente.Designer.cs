namespace SistemaCitasSpa
{
    partial class FormAsistente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsistente));
            labelChat = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBoxCitas = new TextBox();
            textBoxHorarios = new TextBox();
            textBoxContactos = new TextBox();
            textBoxPrecios = new TextBox();
            SuspendLayout();
            // 
            // labelChat
            // 
            labelChat.BackColor = Color.SeaShell;
            labelChat.BorderStyle = BorderStyle.Fixed3D;
            labelChat.FlatStyle = FlatStyle.Flat;
            labelChat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelChat.ForeColor = SystemColors.ActiveCaptionText;
            labelChat.ImageAlign = ContentAlignment.TopLeft;
            labelChat.Location = new Point(12, 20);
            labelChat.Name = "labelChat";
            labelChat.Size = new Size(276, 108);
            labelChat.TabIndex = 0;
            labelChat.Text = "Hola,  soy Cool ,\r\ntu asistente virtual\r\n\r\nde iformacion rapida ¿En qué puedo ayudarte?";
            // 
            // button1
            // 
            button1.BackColor = Color.PeachPuff;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 131);
            button1.Name = "button1";
            button1.Size = new Size(85, 26);
            button1.TabIndex = 1;
            button1.Text = "Citas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PeachPuff;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(103, 131);
            button2.Name = "button2";
            button2.Size = new Size(85, 26);
            button2.TabIndex = 2;
            button2.Text = "Horarios";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PeachPuff;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 163);
            button3.Name = "button3";
            button3.Size = new Size(85, 26);
            button3.TabIndex = 3;
            button3.Text = "Precios";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PeachPuff;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(194, 131);
            button4.Name = "button4";
            button4.Size = new Size(85, 26);
            button4.TabIndex = 4;
            button4.Text = "Contactos";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.PeachPuff;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(103, 163);
            button5.Name = "button5";
            button5.Size = new Size(106, 26);
            button5.TabIndex = 5;
            button5.Text = "Abandonar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBoxCitas
            // 
            textBoxCitas.BackColor = Color.PeachPuff;
            textBoxCitas.BorderStyle = BorderStyle.FixedSingle;
            textBoxCitas.Location = new Point(24, 213);
            textBoxCitas.Multiline = true;
            textBoxCitas.Name = "textBoxCitas";
            textBoxCitas.ReadOnly = true;
            textBoxCitas.ScrollBars = ScrollBars.Vertical;
            textBoxCitas.Size = new Size(250, 150);
            textBoxCitas.TabIndex = 6;
            textBoxCitas.Visible = false;
            // 
            // textBoxHorarios
            // 
            textBoxHorarios.BackColor = Color.PeachPuff;
            textBoxHorarios.BorderStyle = BorderStyle.FixedSingle;
            textBoxHorarios.Location = new Point(24, 242);
            textBoxHorarios.Multiline = true;
            textBoxHorarios.Name = "textBoxHorarios";
            textBoxHorarios.ReadOnly = true;
            textBoxHorarios.ScrollBars = ScrollBars.Vertical;
            textBoxHorarios.Size = new Size(250, 150);
            textBoxHorarios.TabIndex = 7;
            textBoxHorarios.Visible = false;
            // 
            // textBoxContactos
            // 
            textBoxContactos.BackColor = Color.PeachPuff;
            textBoxContactos.BorderStyle = BorderStyle.FixedSingle;
            textBoxContactos.Location = new Point(24, 231);
            textBoxContactos.Multiline = true;
            textBoxContactos.Name = "textBoxContactos";
            textBoxContactos.ReadOnly = true;
            textBoxContactos.ScrollBars = ScrollBars.Vertical;
            textBoxContactos.Size = new Size(250, 150);
            textBoxContactos.TabIndex = 8;
            textBoxContactos.Visible = false;
            // 
            // textBoxPrecios
            // 
            textBoxPrecios.BackColor = Color.PeachPuff;
            textBoxPrecios.BorderStyle = BorderStyle.FixedSingle;
            textBoxPrecios.Location = new Point(24, 213);
            textBoxPrecios.Multiline = true;
            textBoxPrecios.Name = "textBoxPrecios";
            textBoxPrecios.ReadOnly = true;
            textBoxPrecios.ScrollBars = ScrollBars.Vertical;
            textBoxPrecios.Size = new Size(250, 150);
            textBoxPrecios.TabIndex = 9;
            textBoxPrecios.Visible = false;
            // 
            // FormAsistente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(300, 500);
            Controls.Add(textBoxPrecios);
            Controls.Add(textBoxContactos);
            Controls.Add(textBoxHorarios);
            Controls.Add(textBoxCitas);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelChat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAsistente";
            Opacity = 0.9D;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAsistente";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelChat;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBoxCitas;
        private TextBox textBoxHorarios;
        private TextBox textBoxContactos;
        private TextBox textBoxPrecios;
    }
}
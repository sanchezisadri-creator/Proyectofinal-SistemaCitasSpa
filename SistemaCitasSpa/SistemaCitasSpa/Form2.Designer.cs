namespace SistemaCitasSpa
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Linen;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Baskerville Old Face", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 431);
            label1.Name = "label1";
            label1.Size = new Size(187, 19);
            label1.TabIndex = 0;
            label1.Text = " Spa La Maravilla (✿ ͡ᵔ ͜ʖ ͡ᵔ)";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.BlanchedAlmond;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Baskerville Old Face", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(165, 94);
            label2.Name = "label2";
            label2.Size = new Size(518, 52);
            label2.TabIndex = 1;
            label2.Text = " ✿Seleccione una opción✿";
            // 
            // button2
            // 
            button2.BackColor = Color.BlanchedAlmond;
            button2.FlatAppearance.BorderColor = Color.Maroon;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Baskerville Old Face", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(369, 283);
            button2.Name = "button2";
            button2.Size = new Size(106, 46);
            button2.TabIndex = 3;
            button2.Text = "Ver Citas";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.BlanchedAlmond;
            button1.FlatAppearance.BorderColor = Color.Maroon;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Baskerville Old Face", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(330, 219);
            button1.Name = "button1";
            button1.Size = new Size(176, 58);
            button1.TabIndex = 2;
            button1.Text = "Agendar Cita";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.BlanchedAlmond;
            button3.FlatAppearance.BorderColor = Color.Maroon;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Baskerville Old Face", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(637, 392);
            button3.Name = "button3";
            button3.Size = new Size(151, 46);
            button3.TabIndex = 4;
            button3.Text = "SALIR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}
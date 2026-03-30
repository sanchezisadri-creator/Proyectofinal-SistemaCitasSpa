namespace SistemaCitasSpa
{
    partial class FormCreditos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreditos));
            labelCreditos = new Label();
            timerCreditos = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // labelCreditos
            // 
            labelCreditos.BackColor = Color.Transparent;
            labelCreditos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreditos.ForeColor = SystemColors.Control;
            labelCreditos.Location = new Point(22, 21);
            labelCreditos.Name = "labelCreditos";
            labelCreditos.Size = new Size(401, 325);
            labelCreditos.TabIndex = 0;
            labelCreditos.Text = resources.GetString("labelCreditos.Text");
            labelCreditos.TextAlign = ContentAlignment.TopCenter;
            labelCreditos.Click += labelCreditos_Click;
            // 
            // timerCreditos
            // 
            timerCreditos.Interval = 33;
            timerCreditos.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.close;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(418, 3);
            button1.Name = "button1";
            button1.Size = new Size(31, 33);
            button1.TabIndex = 1;
            toolTip1.SetToolTip(button1, "Cerrar");
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // FormCreditos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(450, 370);
            Controls.Add(button1);
            Controls.Add(labelCreditos);
            DoubleBuffered = true;
            ForeColor = SystemColors.Info;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCreditos";
            Opacity = 0.8D;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCreditos";
            TopMost = true;
            Load += FormCreditos_Load;
            Click += FormCreditos_Click;
            ResumeLayout(false);
        }

        #endregion

        private Label labelCreditos;
        private System.Windows.Forms.Timer timerCreditos;
        private Button button1;
        private ToolTip toolTip1;
    }
}
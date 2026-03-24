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
            SuspendLayout();
            // 
            // labelCreditos
            // 
            labelCreditos.BackColor = Color.Transparent;
            labelCreditos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreditos.ForeColor = SystemColors.Control;
            labelCreditos.Location = new Point(22, 21);
            labelCreditos.Name = "labelCreditos";
            labelCreditos.Size = new Size(401, 270);
            labelCreditos.TabIndex = 0;
            labelCreditos.Text = resources.GetString("labelCreditos.Text");
            labelCreditos.TextAlign = ContentAlignment.TopCenter;
            // 
            // timerCreditos
            // 
            timerCreditos.Interval = 30;
            timerCreditos.Tick += timer1_Tick;
            // 
            // FormCreditos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(450, 300);
            Controls.Add(labelCreditos);
            DoubleBuffered = true;
            ForeColor = SystemColors.Info;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCreditos";
            Opacity = 0.9D;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCreditos";
            TopMost = true;
            Load += FormCreditos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labelCreditos;
        private System.Windows.Forms.Timer timerCreditos;
    }
}
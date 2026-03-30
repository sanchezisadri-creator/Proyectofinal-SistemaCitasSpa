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
            tableLayoutPanel1 = new TableLayoutPanel();
            label8 = new Label();
            button5 = new Button();
            button6 = new Button();
            buttonMaximizar = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBoxID = new TextBox();
            textBoxPaciente = new TextBox();
            buttonAgregar = new Button();
            dateTimePickerFecha = new DateTimePicker();
            dateTimePickerHora = new DateTimePicker();
            comboBoxServicio = new ComboBox();
            buttonEliminar = new Button();
            comboBoxDentista = new ComboBox();
            comboBoxTerapeuta = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.MistyRose;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Controls.Add(button5, 4, 0);
            tableLayoutPanel1.Controls.Add(button6, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonMaximizar, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1161, 33);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            tableLayoutPanel1.MouseDown += tableLayoutPanel1_MouseDown;
            // 
            // label8
            // 
            label8.BackColor = Color.Black;
            label8.Font = new Font("Showcard Gothic", 10F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(66, 29);
            label8.TabIndex = 28;
            label8.Text = "U-S-S™";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.UseWaitCursor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(1122, 3);
            button5.Name = "button5";
            button5.Size = new Size(34, 24);
            button5.TabIndex = 27;
            button5.Text = "x";
            button5.UseVisualStyleBackColor = false;
            button5.UseWaitCursor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.Dock = DockStyle.Top;
            button6.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(1045, 3);
            button6.Name = "button6";
            button6.Size = new Size(32, 13);
            button6.TabIndex = 24;
            button6.UseVisualStyleBackColor = false;
            button6.UseWaitCursor = true;
            button6.Click += button6_Click;
            // 
            // buttonMaximizar
            // 
            buttonMaximizar.BackColor = Color.Black;
            buttonMaximizar.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMaximizar.ForeColor = SystemColors.ButtonHighlight;
            buttonMaximizar.Location = new Point(1083, 3);
            buttonMaximizar.Name = "buttonMaximizar";
            buttonMaximizar.Size = new Size(33, 24);
            buttonMaximizar.TabIndex = 26;
            buttonMaximizar.Text = "☐";
            buttonMaximizar.UseVisualStyleBackColor = false;
            buttonMaximizar.UseWaitCursor = true;
            buttonMaximizar.Click += buttonMaximizar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView1.GridColor = Color.Coral;
            dataGridView1.Location = new Point(0, 477);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1161, 311);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre paciente";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Fecha";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Hora";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Nombre dentista";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Servicio";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Duracion";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Nombre terapeuta";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Dias y horas restantes";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Estado ";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(27, 346);
            button1.Name = "button1";
            button1.Size = new Size(104, 26);
            button1.TabIndex = 0;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(57, 444);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(92, 27);
            textBoxID.TabIndex = 4;
            // 
            // textBoxPaciente
            // 
            textBoxPaciente.Location = new Point(165, 444);
            textBoxPaciente.Name = "textBoxPaciente";
            textBoxPaciente.Size = new Size(92, 27);
            textBoxPaciente.TabIndex = 5;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(12, 173);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(151, 40);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.Text = "AGREGRA CITA";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Format = DateTimePickerFormat.Short;
            dateTimePickerFecha.Location = new Point(273, 443);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(110, 27);
            dateTimePickerFecha.TabIndex = 7;
            // 
            // dateTimePickerHora
            // 
            dateTimePickerHora.Format = DateTimePickerFormat.Time;
            dateTimePickerHora.Location = new Point(384, 444);
            dateTimePickerHora.Name = "dateTimePickerHora";
            dateTimePickerHora.ShowUpDown = true;
            dateTimePickerHora.Size = new Size(118, 27);
            dateTimePickerHora.TabIndex = 8;
            // 
            // comboBoxServicio
            // 
            comboBoxServicio.FormattingEnabled = true;
            comboBoxServicio.Items.AddRange(new object[] { "MASAJE  ", "MANICURA", "FACIAL " });
            comboBoxServicio.Location = new Point(613, 446);
            comboBoxServicio.Name = "comboBoxServicio";
            comboBoxServicio.Size = new Size(98, 28);
            comboBoxServicio.TabIndex = 10;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(21, 219);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(128, 51);
            buttonEliminar.TabIndex = 12;
            buttonEliminar.Text = "ELIMINAR CITA";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // comboBoxDentista
            // 
            comboBoxDentista.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDentista.FormattingEnabled = true;
            comboBoxDentista.Location = new Point(508, 446);
            comboBoxDentista.Name = "comboBoxDentista";
            comboBoxDentista.Size = new Size(99, 28);
            comboBoxDentista.TabIndex = 13;
            // 
            // comboBoxTerapeuta
            // 
            comboBoxTerapeuta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTerapeuta.FormattingEnabled = true;
            comboBoxTerapeuta.Location = new Point(827, 443);
            comboBoxTerapeuta.Name = "comboBoxTerapeuta";
            comboBoxTerapeuta.Size = new Size(99, 28);
            comboBoxTerapeuta.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.attractive_african_woman_enjoying_face_massage_spa_salon_1_min_1024x683;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1161, 786);
            Controls.Add(comboBoxTerapeuta);
            Controls.Add(comboBoxDentista);
            Controls.Add(buttonEliminar);
            Controls.Add(comboBoxServicio);
            Controls.Add(dateTimePickerHora);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(buttonAgregar);
            Controls.Add(textBoxPaciente);
            Controls.Add(textBoxID);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            MouseDown += Form2_MouseDown;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button button6;
        private Button buttonMaximizar;
        private Button button5;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Button button1;
        private TextBox textBoxID;
        private TextBox textBoxPaciente;
        private Button buttonAgregar;
        private DateTimePicker dateTimePickerFecha;
        private DateTimePicker dateTimePickerHora;
        private ComboBox comboBoxServicio;
        private Button buttonEliminar;
        private ComboBox comboBoxDentista;
        private ComboBox comboBoxTerapeuta;
    }
}
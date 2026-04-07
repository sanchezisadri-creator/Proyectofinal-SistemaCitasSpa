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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonMute = new Button();
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
            label1 = new Label();
            Fecha = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonEditar = new Button();
            panelGrid = new Panel();
            buttonToggle = new Button();
            timerPanel = new System.Windows.Forms.Timer(components);
            buttonExportar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label6 = new Label();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelGrid.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Moccasin;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.Controls.Add(buttonMute, 1, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Controls.Add(button5, 4, 0);
            tableLayoutPanel1.Controls.Add(button6, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonMaximizar, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(961, 33);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            tableLayoutPanel1.MouseDown += tableLayoutPanel1_MouseDown;
            // 
            // buttonMute
            // 
            buttonMute.BackColor = Color.BurlyWood;
            buttonMute.Location = new Point(75, 3);
            buttonMute.Name = "buttonMute";
            buttonMute.Size = new Size(35, 27);
            buttonMute.TabIndex = 15;
            buttonMute.Text = "🔊";
            buttonMute.UseVisualStyleBackColor = false;
            buttonMute.Click += buttonMute_Click;
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
            button5.Location = new Point(922, 3);
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
            button6.Location = new Point(845, 3);
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
            buttonMaximizar.Location = new Point(883, 3);
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
            dataGridView1.BackgroundColor = Color.Moccasin;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.AntiqueWhite;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(961, 278);
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
            button1.BackColor = Color.Moccasin;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(9, 324);
            button1.Name = "button1";
            button1.Size = new Size(104, 40);
            button1.TabIndex = 0;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(27, 132);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(10, 27);
            textBoxID.TabIndex = 4;
            // 
            // textBoxPaciente
            // 
            textBoxPaciente.Location = new Point(85, 3);
            textBoxPaciente.Name = "textBoxPaciente";
            textBoxPaciente.Size = new Size(92, 27);
            textBoxPaciente.TabIndex = 5;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.Moccasin;
            buttonAgregar.FlatAppearance.BorderColor = Color.Yellow;
            buttonAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAgregar.Location = new Point(5, 228);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(135, 40);
            buttonAgregar.TabIndex = 6;
            buttonAgregar.Text = "AGREGRA CITA";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Format = DateTimePickerFormat.Short;
            dateTimePickerFecha.Location = new Point(67, 177);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(110, 27);
            dateTimePickerFecha.TabIndex = 7;
            // 
            // dateTimePickerHora
            // 
            dateTimePickerHora.Format = DateTimePickerFormat.Time;
            dateTimePickerHora.Location = new Point(56, 143);
            dateTimePickerHora.Name = "dateTimePickerHora";
            dateTimePickerHora.ShowUpDown = true;
            dateTimePickerHora.Size = new Size(118, 27);
            dateTimePickerHora.TabIndex = 8;
            // 
            // comboBoxServicio
            // 
            comboBoxServicio.FormattingEnabled = true;
            comboBoxServicio.Items.AddRange(new object[] { "MASAJE  ", "MANICURA", "FACIAL " });
            comboBoxServicio.Location = new Point(85, 36);
            comboBoxServicio.Name = "comboBoxServicio";
            comboBoxServicio.Size = new Size(127, 28);
            comboBoxServicio.TabIndex = 10;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.Moccasin;
            buttonEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEliminar.Location = new Point(150, 271);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(128, 43);
            buttonEliminar.TabIndex = 12;
            buttonEliminar.Text = "ELIMINAR CITA";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // comboBoxDentista
            // 
            comboBoxDentista.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDentista.FormattingEnabled = true;
            comboBoxDentista.Location = new Point(56, 70);
            comboBoxDentista.Name = "comboBoxDentista";
            comboBoxDentista.Size = new Size(156, 28);
            comboBoxDentista.TabIndex = 13;
            // 
            // comboBoxTerapeuta
            // 
            comboBoxTerapeuta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTerapeuta.FormattingEnabled = true;
            comboBoxTerapeuta.Location = new Point(96, 109);
            comboBoxTerapeuta.Name = "comboBoxTerapeuta";
            comboBoxTerapeuta.Size = new Size(151, 28);
            comboBoxTerapeuta.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Moccasin;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(76, 22);
            label1.TabIndex = 15;
            label1.Text = "Nombres";
            // 
            // Fecha
            // 
            Fecha.AutoSize = true;
            Fecha.BackColor = Color.Moccasin;
            Fecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Fecha.Location = new Point(3, 184);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(49, 20);
            Fecha.TabIndex = 16;
            Fecha.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Moccasin;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 147);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 17;
            label2.Text = "Hora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Moccasin;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 42);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 18;
            label3.Text = "Servicios";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Moccasin;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 112);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 19;
            label4.Text = "Terapeutas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Moccasin;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 73);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 20;
            label5.Text = "Dr.s";
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.Moccasin;
            buttonEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditar.Location = new Point(146, 228);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(132, 40);
            buttonEditar.TabIndex = 21;
            buttonEditar.Text = "EDITAR CITA";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dataGridView1);
            panelGrid.Controls.Add(textBoxID);
            panelGrid.Dock = DockStyle.Bottom;
            panelGrid.Location = new Point(0, 464);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(961, 278);
            panelGrid.TabIndex = 22;
            // 
            // buttonToggle
            // 
            buttonToggle.BackColor = Color.Moccasin;
            buttonToggle.ForeColor = Color.Orange;
            buttonToggle.Location = new Point(3, 3);
            buttonToggle.Name = "buttonToggle";
            buttonToggle.Size = new Size(42, 34);
            buttonToggle.TabIndex = 23;
            buttonToggle.Text = "▲";
            buttonToggle.UseVisualStyleBackColor = false;
            buttonToggle.Click += buttonToggle_Click;
            // 
            // timerPanel
            // 
            timerPanel.Interval = 10;
            timerPanel.Tick += timerPanel_Tick;
            // 
            // buttonExportar
            // 
            buttonExportar.BackColor = Color.Moccasin;
            buttonExportar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExportar.Location = new Point(5, 274);
            buttonExportar.Name = "buttonExportar";
            buttonExportar.Size = new Size(136, 40);
            buttonExportar.TabIndex = 24;
            buttonExportar.Text = "EXPORTAR CSV";
            buttonExportar.UseVisualStyleBackColor = false;
            buttonExportar.Click += buttonExportar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(buttonToggle);
            flowLayoutPanel1.Location = new Point(8, 412);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(52, 46);
            flowLayoutPanel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(buttonEliminar);
            panel2.Controls.Add(buttonAgregar);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(buttonEditar);
            panel2.Controls.Add(textBoxPaciente);
            panel2.Controls.Add(buttonExportar);
            panel2.Controls.Add(Fecha);
            panel2.Controls.Add(dateTimePickerFecha);
            panel2.Controls.Add(comboBoxDentista);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBoxTerapeuta);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateTimePickerHora);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBoxServicio);
            panel2.Location = new Point(3, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(308, 367);
            panel2.TabIndex = 27;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Location = new Point(632, 310);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(317, 148);
            flowLayoutPanel2.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 4);
            label6.Name = "label6";
            label6.Size = new Size(215, 23);
            label6.TabIndex = 29;
            label6.Text = "DISFRUTA DE NOSOTROS";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.Moccasin;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(676, 280);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 27);
            panel1.TabIndex = 30;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(961, 742);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelGrid);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            MouseDown += Form2_MouseDown;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelGrid.ResumeLayout(false);
            panelGrid.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Button buttonMute;
        private Label label1;
        private Label Fecha;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonEditar;
        private Panel panelGrid;
        private Button buttonToggle;
        private System.Windows.Forms.Timer timerPanel;
        private Button buttonExportar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label6;
        private Panel panel1;
    }
}
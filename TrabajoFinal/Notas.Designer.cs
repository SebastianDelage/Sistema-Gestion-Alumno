namespace TrabajoFinal
{
    partial class Notas
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            dtgNotas = new DataGridView();
            btnBuscarNota = new Button();
            label10 = new Label();
            CmbInstacia = new ComboBox();
            txtLibro = new TextBox();
            label9 = new Label();
            txtFolio = new TextBox();
            label8 = new Label();
            txtMateria = new TextBox();
            label7 = new Label();
            dtpFechaNota = new DateTimePicker();
            label3 = new Label();
            txtNota = new TextBox();
            label6 = new Label();
            txtMatriculaNota = new TextBox();
            label1 = new Label();
            txtDniNota = new TextBox();
            label2 = new Label();
            txtApellidoNota = new TextBox();
            label5 = new Label();
            txtNombreNotas = new TextBox();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            visualizarAlumnosToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            notasToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            generarReporteToolStripMenuItem = new ToolStripMenuItem();
            navegacionToolStripMenuItem = new ToolStripMenuItem();
            volverToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgNotas).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 449);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 63, 97);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(dtgNotas);
            panel2.Controls.Add(btnBuscarNota);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(CmbInstacia);
            panel2.Controls.Add(txtLibro);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtFolio);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtMateria);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dtpFechaNota);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtNota);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtMatriculaNota);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtDniNota);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtApellidoNota);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtNombreNotas);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 24);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(795, 425);
            panel2.TabIndex = 25;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(46, 89, 134);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 89, 134);
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 63, 97);
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Location = new Point(276, 241);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(105, 33);
            btnModificar.TabIndex = 63;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(46, 89, 134);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 89, 134);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 63, 97);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Location = new Point(156, 241);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 33);
            btnEliminar.TabIndex = 62;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(46, 89, 134);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 89, 134);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 63, 97);
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Location = new Point(31, 241);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 33);
            btnAgregar.TabIndex = 61;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button2_Click;
            // 
            // dtgNotas
            // 
            dtgNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgNotas.Location = new Point(31, 292);
            dtgNotas.Name = "dtgNotas";
            dtgNotas.Size = new Size(710, 130);
            dtgNotas.TabIndex = 60;
            // 
            // btnBuscarNota
            // 
            btnBuscarNota.BackColor = Color.FromArgb(46, 89, 134);
            btnBuscarNota.FlatAppearance.BorderSize = 0;
            btnBuscarNota.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 89, 134);
            btnBuscarNota.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 63, 97);
            btnBuscarNota.FlatStyle = FlatStyle.Popup;
            btnBuscarNota.Location = new Point(16, 176);
            btnBuscarNota.Name = "btnBuscarNota";
            btnBuscarNota.Size = new Size(105, 33);
            btnBuscarNota.TabIndex = 45;
            btnBuscarNota.Text = "Buscar";
            btnBuscarNota.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(507, 221);
            label10.Name = "label10";
            label10.Size = new Size(76, 20);
            label10.TabIndex = 59;
            label10.Text = "Instancia";
            // 
            // CmbInstacia
            // 
            CmbInstacia.FormattingEnabled = true;
            CmbInstacia.Items.AddRange(new object[] { "Trabajo practico", "Parcial", "Recuperatorio", "Flotante", "Final" });
            CmbInstacia.Location = new Point(591, 218);
            CmbInstacia.Name = "CmbInstacia";
            CmbInstacia.Size = new Size(149, 23);
            CmbInstacia.TabIndex = 58;
            // 
            // txtLibro
            // 
            txtLibro.Location = new Point(591, 176);
            txtLibro.Name = "txtLibro";
            txtLibro.Size = new Size(150, 23);
            txtLibro.TabIndex = 57;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(506, 179);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 56;
            label9.Text = "Libro";
            // 
            // txtFolio
            // 
            txtFolio.Location = new Point(591, 134);
            txtFolio.Name = "txtFolio";
            txtFolio.Size = new Size(150, 23);
            txtFolio.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(506, 137);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 54;
            label8.Text = "Folio";
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(591, 94);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(150, 23);
            txtMateria.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(506, 97);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 52;
            label7.Text = "Materia";
            // 
            // dtpFechaNota
            // 
            dtpFechaNota.Location = new Point(592, 59);
            dtpFechaNota.Name = "dtpFechaNota";
            dtpFechaNota.Size = new Size(194, 23);
            dtpFechaNota.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(506, 61);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 49;
            label3.Text = "Fecha";
            // 
            // txtNota
            // 
            txtNota.Location = new Point(591, 18);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(150, 23);
            txtNota.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(506, 21);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 47;
            label6.Text = "Nota";
            // 
            // txtMatriculaNota
            // 
            txtMatriculaNota.Location = new Point(101, 134);
            txtMatriculaNota.Name = "txtMatriculaNota";
            txtMatriculaNota.Size = new Size(150, 23);
            txtMatriculaNota.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(16, 137);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 45;
            label1.Text = "Matricula";
            // 
            // txtDniNota
            // 
            txtDniNota.Location = new Point(101, 94);
            txtDniNota.Name = "txtDniNota";
            txtDniNota.Size = new Size(150, 23);
            txtDniNota.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(16, 97);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 43;
            label2.Text = "DNI";
            // 
            // txtApellidoNota
            // 
            txtApellidoNota.Location = new Point(101, 58);
            txtApellidoNota.Name = "txtApellidoNota";
            txtApellidoNota.Size = new Size(150, 23);
            txtApellidoNota.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(16, 61);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 41;
            label5.Text = "Apellido";
            // 
            // txtNombreNotas
            // 
            txtNombreNotas.Location = new Point(101, 18);
            txtNombreNotas.Name = "txtNombreNotas";
            txtNombreNotas.Size = new Size(150, 23);
            txtNombreNotas.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(16, 21);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 39;
            label4.Text = "Nombre";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(46, 89, 134);
            menuStrip1.Items.AddRange(new ToolStripItem[] { alumnosToolStripMenuItem, notasToolStripMenuItem, navegacionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(795, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visualizarAlumnosToolStripMenuItem, buscarToolStripMenuItem });
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(67, 20);
            alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // visualizarAlumnosToolStripMenuItem
            // 
            visualizarAlumnosToolStripMenuItem.Name = "visualizarAlumnosToolStripMenuItem";
            visualizarAlumnosToolStripMenuItem.Size = new Size(172, 22);
            visualizarAlumnosToolStripMenuItem.Text = "Visualizar alumnos";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(172, 22);
            buscarToolStripMenuItem.Text = "Bucar alumno";
            // 
            // notasToolStripMenuItem
            // 
            notasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modificarToolStripMenuItem, generarReporteToolStripMenuItem });
            notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            notasToolStripMenuItem.Size = new Size(50, 20);
            notasToolStripMenuItem.Text = "Notas";
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(157, 22);
            modificarToolStripMenuItem.Text = "Modificar notas";
            // 
            // generarReporteToolStripMenuItem
            // 
            generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            generarReporteToolStripMenuItem.Size = new Size(157, 22);
            generarReporteToolStripMenuItem.Text = "Generar reporte";
            // 
            // navegacionToolStripMenuItem
            // 
            navegacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { volverToolStripMenuItem, salirToolStripMenuItem });
            navegacionToolStripMenuItem.Name = "navegacionToolStripMenuItem";
            navegacionToolStripMenuItem.Size = new Size(82, 20);
            navegacionToolStripMenuItem.Text = "Navegacion";
            // 
            // volverToolStripMenuItem
            // 
            volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            volverToolStripMenuItem.Size = new Size(106, 22);
            volverToolStripMenuItem.Text = "Volver";
            volverToolStripMenuItem.Click += volverToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(106, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // Notas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Notas";
            Text = "Notas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgNotas).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem visualizarAlumnosToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem notasToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem generarReporteToolStripMenuItem;
        private ToolStripMenuItem navegacionToolStripMenuItem;
        private ToolStripMenuItem volverToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label label3;
        private TextBox txtNota;
        private Label label6;
        private TextBox txtMatriculaNota;
        private Label label1;
        private TextBox txtDniNota;
        private Label label2;
        private TextBox txtApellidoNota;
        private Label label5;
        private TextBox txtNombreNotas;
        private Label label4;
        private TextBox txtLibro;
        private Label label9;
        private TextBox txtFolio;
        private Label label8;
        private TextBox txtMateria;
        private Label label7;
        private DateTimePicker dtpFechaNota;
        private Label label10;
        private ComboBox CmbInstacia;
        private DataGridView dtgNotas;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnBuscarNota;
    }
}
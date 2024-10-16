namespace TrabajoFinal
{
    partial class Alumnos
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
            dtg_verAlumnos = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            btnReporteAlumno = new Button();
            btnBuscarAlumno = new Button();
            label7 = new Label();
            dtpFecha = new DateTimePicker();
            txtMatricula = new TextBox();
            label5 = new Label();
            txtDni = new TextBox();
            label4 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dtg_verAlumnos).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dtg_verAlumnos
            // 
            dtg_verAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_verAlumnos.Location = new Point(56, 289);
            dtg_verAlumnos.Name = "dtg_verAlumnos";
            dtg_verAlumnos.Size = new Size(701, 135);
            dtg_verAlumnos.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 63, 97);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtg_verAlumnos);
            panel1.Controls.Add(btnReporteAlumno);
            panel1.Controls.Add(btnBuscarAlumno);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(txtMatricula);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtDni);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 24);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 427);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(259, 14);
            label1.Name = "label1";
            label1.Size = new Size(250, 33);
            label1.TabIndex = 45;
            label1.Text = "Visualizar alumnos";
            // 
            // btnReporteAlumno
            // 
            btnReporteAlumno.BackColor = Color.FromArgb(46, 89, 134);
            btnReporteAlumno.FlatAppearance.BorderSize = 0;
            btnReporteAlumno.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 89, 134);
            btnReporteAlumno.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 63, 97);
            btnReporteAlumno.FlatStyle = FlatStyle.Popup;
            btnReporteAlumno.Location = new Point(182, 235);
            btnReporteAlumno.Name = "btnReporteAlumno";
            btnReporteAlumno.Size = new Size(105, 33);
            btnReporteAlumno.TabIndex = 44;
            btnReporteAlumno.Text = "Reporte";
            btnReporteAlumno.UseVisualStyleBackColor = false;
            // 
            // btnBuscarAlumno
            // 
            btnBuscarAlumno.BackColor = Color.FromArgb(46, 89, 134);
            btnBuscarAlumno.FlatAppearance.BorderSize = 0;
            btnBuscarAlumno.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 89, 134);
            btnBuscarAlumno.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 63, 97);
            btnBuscarAlumno.FlatStyle = FlatStyle.Popup;
            btnBuscarAlumno.Location = new Point(61, 235);
            btnBuscarAlumno.Name = "btnBuscarAlumno";
            btnBuscarAlumno.Size = new Size(105, 33);
            btnBuscarAlumno.TabIndex = 43;
            btnBuscarAlumno.Text = "Buscar";
            btnBuscarAlumno.UseVisualStyleBackColor = false;
            btnBuscarAlumno.Click += btnBuscarAlumno_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(56, 170);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 42;
            label7.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(141, 170);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(213, 23);
            dtpFecha.TabIndex = 41;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(141, 126);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(150, 23);
            txtMatricula.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(56, 129);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 37;
            label5.Text = "Matricula";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(141, 86);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(150, 23);
            txtDni.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(56, 89);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 35;
            label4.Text = "DNI";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(484, 127);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 23);
            txtApellido.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(399, 130);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 33;
            label2.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(484, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 23);
            txtNombre.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(399, 85);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 31;
            label3.Text = "Nombre";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(46, 89, 134);
            menuStrip1.Items.AddRange(new ToolStripItem[] { alumnosToolStripMenuItem, notasToolStripMenuItem, navegacionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 23;
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
            modificarToolStripMenuItem.Size = new Size(180, 22);
            modificarToolStripMenuItem.Text = "Modificar notas";
            // 
            // generarReporteToolStripMenuItem
            // 
            generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            generarReporteToolStripMenuItem.Size = new Size(180, 22);
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
            volverToolStripMenuItem.Size = new Size(180, 22);
            volverToolStripMenuItem.Text = "Volver";
            volverToolStripMenuItem.Click += volverToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // Alumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Name = "Alumnos";
            Text = "Alumnos";
            ((System.ComponentModel.ISupportInitialize)dtg_verAlumnos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtg_verAlumnos;
        private Panel panel1;
        private Button btnReporteAlumno;
        private Button btnBuscarAlumno;
        private Label label7;
        private DateTimePicker dtpFecha;
        private TextBox txtMatricula;
        private Label label5;
        private TextBox txtDni;
        private Label label4;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
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
        private Label label1;
    }
}
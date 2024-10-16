namespace TrabajoFinal
{
    partial class Form1
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
            btn_redireccionAulmnos = new Button();
            btn_redireccionNotas = new Button();
            panel2 = new Panel();
            dtg_Pofesorxmateria = new DataGridView();
            lblNota = new Label();
            lblFecha = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            visualizarAlumnosToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            notasToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            generarReporteToolStripMenuItem = new ToolStripMenuItem();
            navegacionToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Pofesorxmateria).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 63, 97);
            panel1.Controls.Add(btn_redireccionAulmnos);
            panel1.Controls.Add(btn_redireccionNotas);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(159, 449);
            panel1.TabIndex = 1;
            // 
            // btn_redireccionAulmnos
            // 
            btn_redireccionAulmnos.FlatAppearance.BorderSize = 0;
            btn_redireccionAulmnos.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 63, 97);
            btn_redireccionAulmnos.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 70, 100);
            btn_redireccionAulmnos.FlatStyle = FlatStyle.Flat;
            btn_redireccionAulmnos.ForeColor = SystemColors.ButtonHighlight;
            btn_redireccionAulmnos.Location = new Point(0, 146);
            btn_redireccionAulmnos.Name = "btn_redireccionAulmnos";
            btn_redireccionAulmnos.Size = new Size(159, 38);
            btn_redireccionAulmnos.TabIndex = 0;
            btn_redireccionAulmnos.Text = "Alumnos";
            btn_redireccionAulmnos.UseVisualStyleBackColor = true;
            btn_redireccionAulmnos.Click += button1_Click;
            // 
            // btn_redireccionNotas
            // 
            btn_redireccionNotas.FlatAppearance.BorderSize = 0;
            btn_redireccionNotas.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 63, 97);
            btn_redireccionNotas.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 70, 100);
            btn_redireccionNotas.FlatStyle = FlatStyle.Flat;
            btn_redireccionNotas.ForeColor = SystemColors.ButtonHighlight;
            btn_redireccionNotas.Location = new Point(0, 249);
            btn_redireccionNotas.Name = "btn_redireccionNotas";
            btn_redireccionNotas.Size = new Size(159, 37);
            btn_redireccionNotas.TabIndex = 1;
            btn_redireccionNotas.Text = "Notas";
            btn_redireccionNotas.UseVisualStyleBackColor = true;
            btn_redireccionNotas.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 66, 82);
            panel2.Controls.Add(dtg_Pofesorxmateria);
            panel2.Controls.Add(lblNota);
            panel2.Controls.Add(lblFecha);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(158, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(642, 350);
            panel2.TabIndex = 13;
            // 
            // dtg_Pofesorxmateria
            // 
            dtg_Pofesorxmateria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Pofesorxmateria.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtg_Pofesorxmateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Pofesorxmateria.Location = new Point(220, 47);
            dtg_Pofesorxmateria.Name = "dtg_Pofesorxmateria";
            dtg_Pofesorxmateria.ReadOnly = true;
            dtg_Pofesorxmateria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_Pofesorxmateria.Size = new Size(410, 290);
            dtg_Pofesorxmateria.TabIndex = 22;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNota.ForeColor = SystemColors.ButtonFace;
            lblNota.Location = new Point(43, 165);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(77, 33);
            lblNota.TabIndex = 21;
            lblNota.Text = "Hora";
            lblNota.Click += label5_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = SystemColors.ButtonHighlight;
            lblFecha.Location = new Point(43, 124);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(97, 33);
            lblFecha.TabIndex = 20;
            lblFecha.Text = "Fecha";
            lblFecha.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(358, 13);
            label2.Name = "label2";
            label2.Size = new Size(152, 22);
            label2.TabIndex = 18;
            label2.Text = "Materias dadas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(353, 38);
            label1.Name = "label1";
            label1.Size = new Size(174, 39);
            label1.TabIndex = 14;
            label1.Text = "Profesores";
            label1.Click += label1_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(46, 89, 134);
            menuStrip1.Items.AddRange(new ToolStripItem[] { alumnosToolStripMenuItem, notasToolStripMenuItem, navegacionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 15;
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
            navegacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            navegacionToolStripMenuItem.Name = "navegacionToolStripMenuItem";
            navegacionToolStripMenuItem.Size = new Size(82, 20);
            navegacionToolStripMenuItem.Text = "Navegacion";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Tag = "Materia";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Pofesorxmateria).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button btn_redireccionNotas;
        private Panel panel2;
        private Label label2;
        private Label lblNota;
        private Label lblFecha;
        private DataGridView dtg_Pofesorxmateria;
        private Button btn_redireccionAulmnos;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem visualizarAlumnosToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem notasToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem generarReporteToolStripMenuItem;
        private ToolStripMenuItem navegacionToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}
namespace Presentacion
{
    partial class FrmVerMat
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvMatriculas = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAñoIngreso = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblConteo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbCaracterizacion = new System.Windows.Forms.ComboBox();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();

            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.turnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivel_inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAlumnoMatriculados = new System.Windows.Forms.DataGridView();

            this.dgvAlumPorTurno = new System.Windows.Forms.DataGridView();
            this.dgvAlumMatric = new System.Windows.Forms.DataGridView();

            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mujer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivel_inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoMatriculados)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumPorTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumMatric)).BeginInit();

            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(404, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "CEAT N°1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(446, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "San Vicente";
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 19;
            this.lineShape1.X2 = 1018;
            this.lineShape1.Y1 = 89;
            this.lineShape1.Y2 = 94;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1004, 645);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(19, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 517);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dgvMatriculas);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtAñoIngreso);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.CmbCaracterizacion);
            this.tabPage1.Controls.Add(this.CmbSexo);
            this.tabPage1.Controls.Add(this.cmbSeccion);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(946, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MATRICULAS";
            // 
            // dgvMatriculas
            // 
            this.dgvMatriculas.AllowDrop = true;
            this.dgvMatriculas.AllowUserToAddRows = false;
            this.dgvMatriculas.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriculas.Location = new System.Drawing.Point(17, 122);
            this.dgvMatriculas.Name = "dgvMatriculas";
            this.dgvMatriculas.RowHeadersVisible = false;
            this.dgvMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatriculas.Size = new System.Drawing.Size(908, 302);
            this.dgvMatriculas.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(628, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Año de ingreso :";
            // 
            // txtAñoIngreso
            // 
            this.txtAñoIngreso.Location = new System.Drawing.Point(631, 76);
            this.txtAñoIngreso.Name = "txtAñoIngreso";
            this.txtAñoIngreso.Size = new System.Drawing.Size(131, 20);
            this.txtAñoIngreso.TabIndex = 38;
            this.txtAñoIngreso.TextChanged += new System.EventHandler(this.txtAñoIngreso_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblConteo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(777, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 91);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TOTAL  :";
            // 
            // lblConteo
            // 
            this.lblConteo.AutoSize = true;
            this.lblConteo.Font = new System.Drawing.Font("Swis721 BlkCn BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteo.Location = new System.Drawing.Point(34, 25);
            this.lblConteo.Name = "lblConteo";
            this.lblConteo.Size = new System.Drawing.Size(80, 45);
            this.lblConteo.TabIndex = 0;
            this.lblConteo.Text = "888";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Caracterizacion :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Sexo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Grado :";
            // 
            // CmbCaracterizacion
            // 
            this.CmbCaracterizacion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CmbCaracterizacion.FormattingEnabled = true;
            this.CmbCaracterizacion.Location = new System.Drawing.Point(364, 76);
            this.CmbCaracterizacion.Name = "CmbCaracterizacion";
            this.CmbCaracterizacion.Size = new System.Drawing.Size(239, 21);
            this.CmbCaracterizacion.TabIndex = 33;
            this.CmbCaracterizacion.TextChanged += new System.EventHandler(this.CmbCaracterizacion_TextChanged);
            // 
            // CmbSexo
            // 
            this.CmbSexo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Todos"});
            this.CmbSexo.Location = new System.Drawing.Point(218, 76);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(116, 21);
            this.CmbSexo.TabIndex = 32;
            this.CmbSexo.TextChanged += new System.EventHandler(this.CmbSexo_TextChanged);
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Location = new System.Drawing.Point(36, 76);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(152, 21);
            this.cmbSeccion.TabIndex = 31;
            this.cmbSeccion.TextChanged += new System.EventHandler(this.cmbSeccion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "FILTRAR BUSQUEDA";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AllowDrop = true;
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(777, 359);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(148, 38);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);

            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.dgvAlumnoMatriculados);

            this.tabPage2.Controls.Add(this.dgvAlumPorTurno);
            this.tabPage2.Controls.Add(this.dgvAlumMatric);

            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(946, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ESTADISTICA";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(525, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Alumno segun regimen de turno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(123, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Alumnos matriculados";
            // 
            // dgvAlumPorTurno
            // 
            this.dgvAlumPorTurno.AllowUserToAddRows = false;
            this.dgvAlumPorTurno.AllowUserToDeleteRows = false;
            this.dgvAlumPorTurno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlumPorTurno.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgvAlumPorTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumPorTurno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turnos,
            this.nivel_inicial});
            this.dgvAlumPorTurno.Location = new System.Drawing.Point(562, 77);
            this.dgvAlumPorTurno.Name = "dgvAlumPorTurno";
            this.dgvAlumPorTurno.ReadOnly = true;
            this.dgvAlumPorTurno.RowHeadersVisible = false;
            this.dgvAlumPorTurno.Size = new System.Drawing.Size(258, 345);
            this.dgvAlumPorTurno.TabIndex = 1;
            // 
            // dgvAlumMatric
            // 

            this.turnos.HeaderText = "Turnos";
            this.turnos.Name = "turnos";
            this.turnos.Width = 65;
            // 
            // nivel_inicial
            // 
            this.nivel_inicial.HeaderText = "Nivel inicial";
            this.nivel_inicial.Name = "nivel_inicial";
            this.nivel_inicial.Width = 85;
            // 
            // dgvAlumnoMatriculados
            // 
            this.dgvAlumnoMatriculados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlumnoMatriculados.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgvAlumnoMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnoMatriculados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {

          
            
            this.categoria,
            this.varon,
            this.mujer,
            this.total});

            this.dgvAlumnoMatriculados.Location = new System.Drawing.Point(35, 77);
            this.dgvAlumnoMatriculados.Name = "dgvAlumnoMatriculados";
            this.dgvAlumnoMatriculados.RowHeadersVisible = false;
            this.dgvAlumnoMatriculados.Size = new System.Drawing.Size(325, 345);
            this.dgvAlumnoMatriculados.TabIndex = 0;

            this.dgvAlumMatric.Location = new System.Drawing.Point(35, 77);
            this.dgvAlumMatric.Name = "dgvAlumMatric";
            this.dgvAlumMatric.ReadOnly = true;
            this.dgvAlumMatric.RowHeadersVisible = false;
            this.dgvAlumMatric.Size = new System.Drawing.Size(445, 345);
            this.dgvAlumMatric.TabIndex = 0;

            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "Caracterizacion_Nombre";
            this.categoria.HeaderText = "Discapacidad/Trastorno";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 147;
            // 
            // varon
            // 
            this.varon.HeaderText = "Varon";
            this.varon.Name = "varon";
            this.varon.ReadOnly = true;
            this.varon.Width = 60;
            // 
            // mujer
            // 
            this.mujer.HeaderText = "Mujer";
            this.mujer.Name = "mujer";
            this.mujer.ReadOnly = true;
            this.mujer.Width = 58;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 56;
            // 
            // turnos
            // 
            this.turnos.DataPropertyName = "Categoria_Nombre";
            this.turnos.HeaderText = "Turnos";
            this.turnos.Name = "turnos";
            this.turnos.ReadOnly = true;
            this.turnos.Width = 65;
            // 
            // nivel_inicial
            // 
            this.nivel_inicial.HeaderText = "Nivel inicial";
            this.nivel_inicial.Name = "nivel_inicial";
            this.nivel_inicial.ReadOnly = true;
            this.nivel_inicial.Width = 85;
            // 
            // FrmVerMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1004, 645);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shapeContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVerMat";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmVerMat_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoMatriculados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumPorTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumMatric)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblConteo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbCaracterizacion;
        private System.Windows.Forms.ComboBox CmbSexo;

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dgvAlumnoMatriculados;

        private System.Windows.Forms.DataGridView dgvAlumPorTurno;
        private System.Windows.Forms.DataGridView dgvAlumMatric;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAñoIngreso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvMatriculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn varon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mujer;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivel_inicial;
    }
}
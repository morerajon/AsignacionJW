namespace Presentacion
{
    partial class FrmBajaMat
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
            this.lblElegir = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvMatriculas = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBajaCausa = new System.Windows.Forms.TextBox();
            this.btnGuardarBaja = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(379, 5);
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
            this.label3.Location = new System.Drawing.Point(421, 51);
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
            this.lineShape1.X1 = 88;
            this.lineShape1.X2 = 922;
            this.lineShape1.Y1 = 87;
            this.lineShape1.Y2 = 87;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(955, 575);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lblElegir
            // 
            this.lblElegir.AllowDrop = true;
            this.lblElegir.AutoSize = true;
            this.lblElegir.Location = new System.Drawing.Point(81, 152);
            this.lblElegir.Name = "lblElegir";
            this.lblElegir.Size = new System.Drawing.Size(78, 13);
            this.lblElegir.TabIndex = 11;
            this.lblElegir.Text = "Elegir Usuario :";
            // 
            // txtBuscar
            // 
            this.txtBuscar.AllowDrop = true;
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBuscar.Location = new System.Drawing.Point(166, 152);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(219, 20);
            this.txtBuscar.TabIndex = 12;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvMatriculas
            // 
            this.dgvMatriculas.AllowDrop = true;
            this.dgvMatriculas.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriculas.Location = new System.Drawing.Point(84, 218);
            this.dgvMatriculas.Name = "dgvMatriculas";
            this.dgvMatriculas.ReadOnly = true;
            this.dgvMatriculas.RowHeadersVisible = false;
            this.dgvMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatriculas.Size = new System.Drawing.Size(436, 302);
            this.dgvMatriculas.TabIndex = 13;
            this.dgvMatriculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriculas_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AllowDrop = true;
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(425, 152);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 20);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(625, 317);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // txtBajaCausa
            // 
            this.txtBajaCausa.Location = new System.Drawing.Point(625, 372);
            this.txtBajaCausa.Multiline = true;
            this.txtBajaCausa.Name = "txtBajaCausa";
            this.txtBajaCausa.Size = new System.Drawing.Size(297, 99);
            this.txtBajaCausa.TabIndex = 16;
            // 
            // btnGuardarBaja
            // 
            this.btnGuardarBaja.BackColor = System.Drawing.Color.Crimson;
            this.btnGuardarBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarBaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarBaja.Location = new System.Drawing.Point(713, 489);
            this.btnGuardarBaja.Name = "btnGuardarBaja";
            this.btnGuardarBaja.Size = new System.Drawing.Size(112, 31);
            this.btnGuardarBaja.TabIndex = 17;
            this.btnGuardarBaja.Text = "Dar de Baja";
            this.btnGuardarBaja.UseVisualStyleBackColor = false;
            this.btnGuardarBaja.Click += new System.EventHandler(this.btnGuardarBaja_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 48);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(50, 13);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Apellido :";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(153, 23);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(32, 13);
            this.lblDNI.TabIndex = 20;
            this.lblDNI.Text = "DNI :";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(153, 48);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(42, 13);
            this.lblGrado.TabIndex = 21;
            this.lblGrado.Text = "Grado :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDNI);
            this.groupBox1.Controls.Add(this.lblGrado);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Location = new System.Drawing.Point(625, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 82);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumno a dar de baja";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AllowDrop = true;
            this.btnSeleccionar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeleccionar.Location = new System.Drawing.Point(524, 255);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(95, 24);
            this.btnSeleccionar.TabIndex = 23;
            this.btnSeleccionar.Text = "Seleccionar =>>";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Causa de la Baja :";
            // 
            // FrmBajaMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(955, 575);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardarBaja);
            this.Controls.Add(this.txtBajaCausa);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvMatriculas);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblElegir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shapeContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBajaMat";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmBajaMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lblElegir;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvMatriculas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBajaCausa;
        private System.Windows.Forms.Button btnGuardarBaja;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label1;
    }
}
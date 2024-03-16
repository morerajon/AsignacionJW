namespace Presentacion
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picMaximizar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnBajaMatricula = new System.Windows.Forms.Button();
            this.btnEdtiarMatriculas = new System.Windows.Forms.Button();
            this.btnVerMatriculas = new System.Windows.Forms.Button();
            this.btnNuevaMatricula = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.picMinimizar);
            this.panel1.Controls.Add(this.picMaximizar);
            this.panel1.Controls.Add(this.picCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 27);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picMinimizar
            // 
            this.picMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picMinimizar.Image")));
            this.picMinimizar.Location = new System.Drawing.Point(1243, 7);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(20, 20);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimizar.TabIndex = 5;
            this.picMinimizar.TabStop = false;
            // 
            // picMaximizar
            // 
            this.picMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("picMaximizar.Image")));
            this.picMaximizar.Location = new System.Drawing.Point(1269, 3);
            this.picMaximizar.Name = "picMaximizar";
            this.picMaximizar.Size = new System.Drawing.Size(20, 20);
            this.picMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMaximizar.TabIndex = 4;
            this.picMaximizar.TabStop = false;
            // 
            // picCerrar
            // 
            this.picCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picCerrar.Image")));
            this.picCerrar.Location = new System.Drawing.Point(1295, 3);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(20, 20);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 3;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 687);
            this.panel2.TabIndex = 8;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.lblPermisos);
            this.pnlMenu.Controls.Add(this.lblApellido);
            this.pnlMenu.Controls.Add(this.lblNombre);
            this.pnlMenu.Controls.Add(this.btnSalir);
            this.pnlMenu.Controls.Add(this.btnUsuario);
            this.pnlMenu.Controls.Add(this.btnBajaMatricula);
            this.pnlMenu.Controls.Add(this.btnEdtiarMatriculas);
            this.pnlMenu.Controls.Add(this.btnVerMatriculas);
            this.pnlMenu.Controls.Add(this.btnNuevaMatricula);
            this.pnlMenu.Controls.Add(this.shapeContainer2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(21, 27);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(281, 687);
            this.pnlMenu.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermisos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPermisos.Location = new System.Drawing.Point(23, 69);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(73, 16);
            this.lblPermisos.TabIndex = 9;
            this.lblPermisos.Text = "Permisos";
            this.lblPermisos.Click += new System.EventHandler(this.lblPermisos_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblApellido.Location = new System.Drawing.Point(23, 29);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(74, 16);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombre.Location = new System.Drawing.Point(23, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 16);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombres";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSalir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(145, 653);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 31);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUsuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(23, 549);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(214, 50);
            this.btnUsuario.TabIndex = 5;
            this.btnUsuario.Text = " Administrar Usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            this.btnUsuario.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnUsuario.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnBajaMatricula
            // 
            this.btnBajaMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBajaMatricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBajaMatricula.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBajaMatricula.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnBajaMatricula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBajaMatricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBajaMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBajaMatricula.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaMatricula.Image = ((System.Drawing.Image)(resources.GetObject("btnBajaMatricula.Image")));
            this.btnBajaMatricula.Location = new System.Drawing.Point(23, 332);
            this.btnBajaMatricula.Name = "btnBajaMatricula";
            this.btnBajaMatricula.Size = new System.Drawing.Size(214, 50);
            this.btnBajaMatricula.TabIndex = 4;
            this.btnBajaMatricula.Text = " Baja de Matricula";
            this.btnBajaMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaMatricula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBajaMatricula.UseVisualStyleBackColor = false;
            this.btnBajaMatricula.Click += new System.EventHandler(this.btnBajaMatricula_Click);
            this.btnBajaMatricula.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnBajaMatricula.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnEdtiarMatriculas
            // 
            this.btnEdtiarMatriculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEdtiarMatriculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdtiarMatriculas.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEdtiarMatriculas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEdtiarMatriculas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdtiarMatriculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdtiarMatriculas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdtiarMatriculas.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdtiarMatriculas.Image = ((System.Drawing.Image)(resources.GetObject("btnEdtiarMatriculas.Image")));
            this.btnEdtiarMatriculas.Location = new System.Drawing.Point(23, 266);
            this.btnEdtiarMatriculas.Name = "btnEdtiarMatriculas";
            this.btnEdtiarMatriculas.Size = new System.Drawing.Size(214, 50);
            this.btnEdtiarMatriculas.TabIndex = 3;
            this.btnEdtiarMatriculas.Text = " Editar Matricula";
            this.btnEdtiarMatriculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdtiarMatriculas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdtiarMatriculas.UseVisualStyleBackColor = false;
            this.btnEdtiarMatriculas.Click += new System.EventHandler(this.btnEdtiarMatriculas_Click);
            this.btnEdtiarMatriculas.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnEdtiarMatriculas.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnVerMatriculas
            // 
            this.btnVerMatriculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVerMatriculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerMatriculas.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVerMatriculas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnVerMatriculas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVerMatriculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVerMatriculas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerMatriculas.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMatriculas.Image = ((System.Drawing.Image)(resources.GetObject("btnVerMatriculas.Image")));
            this.btnVerMatriculas.Location = new System.Drawing.Point(23, 200);
            this.btnVerMatriculas.Name = "btnVerMatriculas";
            this.btnVerMatriculas.Size = new System.Drawing.Size(214, 50);
            this.btnVerMatriculas.TabIndex = 2;
            this.btnVerMatriculas.Text = " Ver Matriculas";
            this.btnVerMatriculas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerMatriculas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerMatriculas.UseVisualStyleBackColor = false;
            this.btnVerMatriculas.Click += new System.EventHandler(this.btnVerMatriculas_Click);
            this.btnVerMatriculas.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnVerMatriculas.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnNuevaMatricula
            // 
            this.btnNuevaMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNuevaMatricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaMatricula.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNuevaMatricula.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNuevaMatricula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNuevaMatricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNuevaMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevaMatricula.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaMatricula.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaMatricula.Image")));
            this.btnNuevaMatricula.Location = new System.Drawing.Point(23, 133);
            this.btnNuevaMatricula.Name = "btnNuevaMatricula";
            this.btnNuevaMatricula.Size = new System.Drawing.Size(214, 50);
            this.btnNuevaMatricula.TabIndex = 1;
            this.btnNuevaMatricula.Text = " Nueva matricula";
            this.btnNuevaMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaMatricula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaMatricula.UseVisualStyleBackColor = false;
            this.btnNuevaMatricula.Click += new System.EventHandler(this.btnNuevaMatricula_Click);
            this.btnNuevaMatricula.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnNuevaMatricula.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(281, 687);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 23;
            this.lineShape2.X2 = 236;
            this.lineShape2.Y1 = 98;
            this.lineShape2.Y2 = 98;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(68, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer3.Size = new System.Drawing.Size(934, 687);
            this.shapeContainer3.TabIndex = 8;
            this.shapeContainer3.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 18;
            this.lineShape1.X2 = 832;
            this.lineShape1.Y1 = 96;
            this.lineShape1.Y2 = 96;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(465, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "San Vicente";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(423, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "CEAT N°1";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedor.Controls.Add(this.label2);
            this.pnlContenedor.Controls.Add(this.label3);
            this.pnlContenedor.Controls.Add(this.shapeContainer3);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(302, 27);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Padding = new System.Windows.Forms.Padding(68, 0, 23, 0);
            this.pnlContenedor.Size = new System.Drawing.Size(1025, 687);
            this.pnlContenedor.TabIndex = 11;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(184)))), ((int)(((byte)(146)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1327, 714);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "MenuPrincipal";
            this.TransparencyKey = System.Drawing.Color.MintCream;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picMaximizar;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMenu;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnBajaMatricula;
        private System.Windows.Forms.Button btnEdtiarMatriculas;
        private System.Windows.Forms.Button btnVerMatriculas;
        private System.Windows.Forms.Button btnNuevaMatricula;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}
namespace Reconocimiento_facial
{
    partial class Frm_Registrar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Registrar));
            Klik.Windows.Forms.v1.Common.GradientBlend gradientBlend1 = new Klik.Windows.Forms.v1.Common.GradientBlend();
            Klik.Windows.Forms.v1.Common.GradientBlend gradientBlend2 = new Klik.Windows.Forms.v1.Common.GradientBlend();
            Klik.Windows.Forms.v1.Common.GradientBlend gradientBlend3 = new Klik.Windows.Forms.v1.Common.GradientBlend();
            Klik.Windows.Forms.v1.Common.GradientBlend gradientBlend4 = new Klik.Windows.Forms.v1.Common.GradientBlend();
            Klik.Windows.Forms.v1.Common.GradientBlend gradientBlend5 = new Klik.Windows.Forms.v1.Common.GradientBlend();
            Klik.Windows.Forms.v1.Common.GradientBlend gradientBlend6 = new Klik.Windows.Forms.v1.Common.GradientBlend();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_mini = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumeroDetect = new System.Windows.Forms.Label();
            this.btn_detectar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.button1 = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_loadImgsBD = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_agregar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btnlimpiar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_detectar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlimpiar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btn_mini);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 44);
            this.panel1.TabIndex = 1;
            // 
            // btn_mini
            // 
            this.btn_mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mini.FlatAppearance.BorderSize = 0;
            this.btn_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mini.ForeColor = System.Drawing.Color.White;
            this.btn_mini.Image = ((System.Drawing.Image)(resources.GetObject("btn_mini.Image")));
            this.btn_mini.Location = new System.Drawing.Point(692, 9);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(32, 32);
            this.btn_mini.TabIndex = 11;
            this.btn_mini.UseVisualStyleBackColor = true;
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.Location = new System.Drawing.Point(731, 9);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(32, 32);
            this.btn_Salir.TabIndex = 10;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 437);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 10);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(262, 50);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(217, 280);
            this.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxFrameGrabber.TabIndex = 28;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(260, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Rostros detectados:";
            // 
            // lblNumeroDetect
            // 
            this.lblNumeroDetect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroDetect.AutoSize = true;
            this.lblNumeroDetect.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDetect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNumeroDetect.Location = new System.Drawing.Point(400, 333);
            this.lblNumeroDetect.Name = "lblNumeroDetect";
            this.lblNumeroDetect.Size = new System.Drawing.Size(14, 13);
            this.lblNumeroDetect.TabIndex = 39;
            this.lblNumeroDetect.Text = "0";
            // 
            // btn_detectar
            // 
            this.btn_detectar.BackgroundStyle.GradientEndColor = System.Drawing.Color.LightSteelBlue;
            this.btn_detectar.BackgroundStyle.GradientStartColor = System.Drawing.Color.White;
            this.btn_detectar.BorderStyle.EdgeRadius = 7;
            this.btn_detectar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btn_detectar.BorderStyle.SolidColor = System.Drawing.Color.SteelBlue;
            this.btn_detectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detectar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_detectar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_detectar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_detectar.Location = new System.Drawing.Point(9, 369);
            this.btn_detectar.Name = "btn_detectar";
            this.btn_detectar.Size = new System.Drawing.Size(177, 47);
            this.btn_detectar.StateStyles.DisabledStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_detectar.StateStyles.DisabledStyle.BackgroundSolidColor = System.Drawing.Color.LightSteelBlue;
            this.btn_detectar.StateStyles.FocusStyle.BackgroundGradientEndColor = System.Drawing.Color.LightSteelBlue;
            this.btn_detectar.StateStyles.FocusStyle.BackgroundGradientStartColor = System.Drawing.Color.SteelBlue;
            gradientBlend1.Factor = 0F;
            gradientBlend1.Position = 0F;
            gradientBlend2.Factor = 0F;
            gradientBlend2.Position = 0.5F;
            gradientBlend3.Factor = 1F;
            gradientBlend3.Position = 1F;
            this.btn_detectar.StateStyles.HoverStyle.BackgroundGradientBlend.Add(gradientBlend1);
            this.btn_detectar.StateStyles.HoverStyle.BackgroundGradientBlend.Add(gradientBlend2);
            this.btn_detectar.StateStyles.HoverStyle.BackgroundGradientBlend.Add(gradientBlend3);
            this.btn_detectar.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.btn_detectar.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.LightSteelBlue;
            this.btn_detectar.TabIndex = 63;
            this.btn_detectar.TextStyle.Text = "Detectar";
            this.btn_detectar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_detectar.TextStyle.TextType = Klik.Windows.Forms.v1.Common.TextTypes.BlockShadow;
            this.btn_detectar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_detectar.Click += new System.EventHandler(this.btn_detectar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundStyle.GradientEndColor = System.Drawing.Color.LightSteelBlue;
            this.button1.BackgroundStyle.GradientStartColor = System.Drawing.Color.White;
            this.button1.BorderStyle.EdgeRadius = 7;
            this.button1.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.button1.BorderStyle.SolidColor = System.Drawing.Color.SteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.button1.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.button1.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Location = new System.Drawing.Point(192, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 47);
            this.button1.StateStyles.DisabledStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.button1.StateStyles.DisabledStyle.BackgroundSolidColor = System.Drawing.Color.LightSteelBlue;
            this.button1.StateStyles.FocusStyle.BackgroundGradientEndColor = System.Drawing.Color.LightSteelBlue;
            this.button1.StateStyles.FocusStyle.BackgroundGradientStartColor = System.Drawing.Color.SteelBlue;
            gradientBlend4.Factor = 0F;
            gradientBlend4.Position = 0F;
            gradientBlend5.Factor = 0F;
            gradientBlend5.Position = 0.5F;
            gradientBlend6.Factor = 1F;
            gradientBlend6.Position = 1F;
            this.button1.StateStyles.HoverStyle.BackgroundGradientBlend.Add(gradientBlend4);
            this.button1.StateStyles.HoverStyle.BackgroundGradientBlend.Add(gradientBlend5);
            this.button1.StateStyles.HoverStyle.BackgroundGradientBlend.Add(gradientBlend6);
            this.button1.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.button1.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.LightSteelBlue;
            this.button1.TabIndex = 62;
            this.button1.TextStyle.Text = "Desconectar";
            this.button1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.TextStyle.TextType = Klik.Windows.Forms.v1.Common.TextTypes.BlockShadow;
            this.button1.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(522, 238);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 64;
            // 
            // imageBox2
            // 
            this.imageBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox2.Location = new System.Drawing.Point(510, 50);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(234, 176);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 65;
            this.imageBox2.TabStop = false;
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.BackColor = System.Drawing.Color.Transparent;
            this.btn_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ultimo.Location = new System.Drawing.Point(218, 134);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(35, 23);
            this.btn_ultimo.TabIndex = 67;
            this.btn_ultimo.Text = ">>I";
            this.btn_ultimo.UseVisualStyleBackColor = false;
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackColor = System.Drawing.Color.Transparent;
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anterior.Location = new System.Drawing.Point(218, 105);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(35, 23);
            this.btn_anterior.TabIndex = 68;
            this.btn_anterior.Text = "<<";
            this.btn_anterior.UseVisualStyleBackColor = false;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.BackColor = System.Drawing.Color.Transparent;
            this.btn_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_siguiente.Location = new System.Drawing.Point(218, 76);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(35, 23);
            this.btn_siguiente.TabIndex = 69;
            this.btn_siguiente.Text = ">>";
            this.btn_siguiente.UseVisualStyleBackColor = false;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_primero
            // 
            this.btn_primero.BackColor = System.Drawing.Color.Transparent;
            this.btn_primero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_primero.Location = new System.Drawing.Point(218, 47);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(35, 23);
            this.btn_primero.TabIndex = 70;
            this.btn_primero.Text = "I<<";
            this.btn_primero.UseVisualStyleBackColor = false;
            this.btn_primero.Click += new System.EventHandler(this.btn_primero_Click);
            // 
            // btn_loadImgsBD
            // 
            this.btn_loadImgsBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadImgsBD.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadImgsBD.Location = new System.Drawing.Point(218, 169);
            this.btn_loadImgsBD.Name = "btn_loadImgsBD";
            this.btn_loadImgsBD.Size = new System.Drawing.Size(35, 23);
            this.btn_loadImgsBD.TabIndex = 71;
            this.btn_loadImgsBD.Text = "...";
            this.btn_loadImgsBD.UseVisualStyleBackColor = true;
            this.btn_loadImgsBD.Click += new System.EventHandler(this.btn_loadImgsBD_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Nombre:";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BorderStyle.EdgeRadius = 7;
            this.btn_agregar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(83)))), ((int)(((byte)(92)))));
            this.btn_agregar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_agregar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_agregar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_agregar.Location = new System.Drawing.Point(9, 313);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernSilver;
            this.btn_agregar.Size = new System.Drawing.Size(118, 36);
            this.btn_agregar.TabIndex = 75;
            this.btn_agregar.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(83)))), ((int)(((byte)(92)))));
            this.btn_agregar.TextStyle.Text = "Agregar";
            this.btn_agregar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BorderStyle.EdgeRadius = 7;
            this.btnlimpiar.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btnlimpiar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btnlimpiar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlimpiar.Location = new System.Drawing.Point(136, 313);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicSilver;
            this.btnlimpiar.Size = new System.Drawing.Size(118, 36);
            this.btnlimpiar.TabIndex = 76;
            this.btnlimpiar.TextStyle.Text = "Limpiar";
            this.btnlimpiar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(49, 213);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(204, 26);
            this.txt_nombre.TabIndex = 77;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(49, 258);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(204, 26);
            this.txt_codigo.TabIndex = 78;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Frm_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 447);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ultimo);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_primero);
            this.Controls.Add(this.btn_loadImgsBD);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btn_detectar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumeroDetect);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Registrar";
            this.Load += new System.EventHandler(this.Frm_Registrar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_detectar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlimpiar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumeroDetect;
        public Klik.Windows.Forms.v1.EntryLib.ELButton btn_detectar;
        public Klik.Windows.Forms.v1.EntryLib.ELButton button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_loadImgsBD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Klik.Windows.Forms.v1.EntryLib.ELButton btnlimpiar;
        public Klik.Windows.Forms.v1.EntryLib.ELButton btn_agregar;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_nombre;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
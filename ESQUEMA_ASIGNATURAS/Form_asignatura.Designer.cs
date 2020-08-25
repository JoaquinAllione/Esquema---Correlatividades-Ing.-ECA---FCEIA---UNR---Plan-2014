namespace ESQUEMA_ASIGNATURAS
{
    partial class Form_asignatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_asignatura));
            this.boton_cerrar_2 = new System.Windows.Forms.Button();
            this.panel_control = new System.Windows.Forms.Panel();
            this.label_barra_control = new System.Windows.Forms.Label();
            this.label_codigo = new System.Windows.Forms.Label();
            this.label_año = new System.Windows.Forms.Label();
            this.label_cuatrimestre = new System.Windows.Forms.Label();
            this.label_monbre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uncheck_aprobada = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uncheck_no_aprobada = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uncheck_intermedia = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_nota = new System.Windows.Forms.TextBox();
            this.check_aprobada = new System.Windows.Forms.PictureBox();
            this.check_no_aprobada = new System.Windows.Forms.PictureBox();
            this.check_intermedia = new System.Windows.Forms.PictureBox();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_cuatri = new System.Windows.Forms.TextBox();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.textBox_estado = new System.Windows.Forms.TextBox();
            this.txt_plan = new System.Windows.Forms.TextBox();
            this.txt_nombre_asignatura = new System.Windows.Forms.TextBox();
            this.txt_corr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_corr_a = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uncheck_aprobada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uncheck_no_aprobada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uncheck_intermedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_aprobada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_no_aprobada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_intermedia)).BeginInit();
            this.SuspendLayout();
            // 
            // boton_cerrar_2
            // 
            this.boton_cerrar_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boton_cerrar_2.FlatAppearance.BorderSize = 0;
            this.boton_cerrar_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.boton_cerrar_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.boton_cerrar_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_cerrar_2.Image = ((System.Drawing.Image)(resources.GetObject("boton_cerrar_2.Image")));
            this.boton_cerrar_2.Location = new System.Drawing.Point(374, 0);
            this.boton_cerrar_2.Name = "boton_cerrar_2";
            this.boton_cerrar_2.Size = new System.Drawing.Size(40, 40);
            this.boton_cerrar_2.TabIndex = 40;
            this.boton_cerrar_2.UseVisualStyleBackColor = true;
            this.boton_cerrar_2.Click += new System.EventHandler(this.boton_cerrar_2_Click);
            // 
            // panel_control
            // 
            this.panel_control.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_control.Controls.Add(this.label_barra_control);
            this.panel_control.Controls.Add(this.boton_cerrar_2);
            this.panel_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_control.Location = new System.Drawing.Point(0, 0);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(414, 40);
            this.panel_control.TabIndex = 41;
            this.panel_control.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_control_MouseMove);
            // 
            // label_barra_control
            // 
            this.label_barra_control.AutoSize = true;
            this.label_barra_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_barra_control.ForeColor = System.Drawing.SystemColors.Control;
            this.label_barra_control.Location = new System.Drawing.Point(18, 12);
            this.label_barra_control.Name = "label_barra_control";
            this.label_barra_control.Size = new System.Drawing.Size(241, 15);
            this.label_barra_control.TabIndex = 42;
            this.label_barra_control.Text = "COD - NOMBRE DE LA ASIGNATURA";
            this.label_barra_control.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_barra_control.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_barra_control_MouseMove);
            // 
            // label_codigo
            // 
            this.label_codigo.AutoSize = true;
            this.label_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_codigo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_codigo.Location = new System.Drawing.Point(18, 88);
            this.label_codigo.Name = "label_codigo";
            this.label_codigo.Size = new System.Drawing.Size(64, 15);
            this.label_codigo.TabIndex = 43;
            this.label_codigo.Text = "CODIGO:";
            this.label_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_año
            // 
            this.label_año.AutoSize = true;
            this.label_año.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_año.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_año.Location = new System.Drawing.Point(128, 89);
            this.label_año.Name = "label_año";
            this.label_año.Size = new System.Drawing.Size(43, 15);
            this.label_año.TabIndex = 44;
            this.label_año.Text = "AÑO: ";
            this.label_año.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_cuatrimestre
            // 
            this.label_cuatrimestre.AutoSize = true;
            this.label_cuatrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cuatrimestre.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_cuatrimestre.Location = new System.Drawing.Point(214, 88);
            this.label_cuatrimestre.Name = "label_cuatrimestre";
            this.label_cuatrimestre.Size = new System.Drawing.Size(117, 15);
            this.label_cuatrimestre.TabIndex = 45;
            this.label_cuatrimestre.Text = "CUATRIMESTRE:";
            this.label_cuatrimestre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_monbre
            // 
            this.label_monbre.AutoSize = true;
            this.label_monbre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_monbre.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_monbre.Location = new System.Drawing.Point(18, 62);
            this.label_monbre.Name = "label_monbre";
            this.label_monbre.Size = new System.Drawing.Size(59, 15);
            this.label_monbre.TabIndex = 46;
            this.label_monbre.Text = "TITULO:";
            this.label_monbre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(18, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "PLAN DE ESTUDIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(214, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "CATEGORIA:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uncheck_aprobada
            // 
            this.uncheck_aprobada.Image = ((System.Drawing.Image)(resources.GetObject("uncheck_aprobada.Image")));
            this.uncheck_aprobada.Location = new System.Drawing.Point(23, 225);
            this.uncheck_aprobada.Name = "uncheck_aprobada";
            this.uncheck_aprobada.Size = new System.Drawing.Size(20, 19);
            this.uncheck_aprobada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uncheck_aprobada.TabIndex = 51;
            this.uncheck_aprobada.TabStop = false;
            this.uncheck_aprobada.Click += new System.EventHandler(this.uncheck_aprobada_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(45, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 52;
            this.label3.Text = "APROBADA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(173, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 54;
            this.label4.Text = "NO APROBADA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uncheck_no_aprobada
            // 
            this.uncheck_no_aprobada.Image = ((System.Drawing.Image)(resources.GetObject("uncheck_no_aprobada.Image")));
            this.uncheck_no_aprobada.Location = new System.Drawing.Point(151, 225);
            this.uncheck_no_aprobada.Name = "uncheck_no_aprobada";
            this.uncheck_no_aprobada.Size = new System.Drawing.Size(20, 19);
            this.uncheck_no_aprobada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uncheck_no_aprobada.TabIndex = 53;
            this.uncheck_no_aprobada.TabStop = false;
            this.uncheck_no_aprobada.Click += new System.EventHandler(this.uncheck_no_aprobada_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(318, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 56;
            this.label5.Text = "INSCRIPTO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uncheck_intermedia
            // 
            this.uncheck_intermedia.Image = ((System.Drawing.Image)(resources.GetObject("uncheck_intermedia.Image")));
            this.uncheck_intermedia.Location = new System.Drawing.Point(296, 224);
            this.uncheck_intermedia.Name = "uncheck_intermedia";
            this.uncheck_intermedia.Size = new System.Drawing.Size(20, 19);
            this.uncheck_intermedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uncheck_intermedia.TabIndex = 55;
            this.uncheck_intermedia.TabStop = false;
            this.uncheck_intermedia.Click += new System.EventHandler(this.uncheck_intermedia_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(18, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 57;
            this.label6.Text = "ESTADO:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(20, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 58;
            this.label7.Text = "NOTA:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_nota
            // 
            this.textBox_nota.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_nota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_nota.Enabled = false;
            this.textBox_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nota.ForeColor = System.Drawing.Color.Gray;
            this.textBox_nota.Location = new System.Drawing.Point(73, 254);
            this.textBox_nota.Name = "textBox_nota";
            this.textBox_nota.Size = new System.Drawing.Size(59, 14);
            this.textBox_nota.TabIndex = 59;
            this.textBox_nota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // check_aprobada
            // 
            this.check_aprobada.Image = ((System.Drawing.Image)(resources.GetObject("check_aprobada.Image")));
            this.check_aprobada.Location = new System.Drawing.Point(23, 225);
            this.check_aprobada.Name = "check_aprobada";
            this.check_aprobada.Size = new System.Drawing.Size(20, 19);
            this.check_aprobada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.check_aprobada.TabIndex = 61;
            this.check_aprobada.TabStop = false;
            this.check_aprobada.Visible = false;
            this.check_aprobada.Click += new System.EventHandler(this.check_aprobada_Click);
            // 
            // check_no_aprobada
            // 
            this.check_no_aprobada.Image = ((System.Drawing.Image)(resources.GetObject("check_no_aprobada.Image")));
            this.check_no_aprobada.Location = new System.Drawing.Point(151, 225);
            this.check_no_aprobada.Name = "check_no_aprobada";
            this.check_no_aprobada.Size = new System.Drawing.Size(20, 19);
            this.check_no_aprobada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.check_no_aprobada.TabIndex = 62;
            this.check_no_aprobada.TabStop = false;
            this.check_no_aprobada.Visible = false;
            this.check_no_aprobada.Click += new System.EventHandler(this.check_no_aprobada_Click);
            // 
            // check_intermedia
            // 
            this.check_intermedia.Image = ((System.Drawing.Image)(resources.GetObject("check_intermedia.Image")));
            this.check_intermedia.Location = new System.Drawing.Point(296, 224);
            this.check_intermedia.Name = "check_intermedia";
            this.check_intermedia.Size = new System.Drawing.Size(20, 19);
            this.check_intermedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.check_intermedia.TabIndex = 63;
            this.check_intermedia.TabStop = false;
            this.check_intermedia.Visible = false;
            this.check_intermedia.Click += new System.EventHandler(this.check_intermedia_Click);
            // 
            // txt_cod
            // 
            this.txt_cod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cod.Enabled = false;
            this.txt_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_cod.Location = new System.Drawing.Point(81, 88);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(41, 14);
            this.txt_cod.TabIndex = 67;
            this.txt_cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_a
            // 
            this.txt_a.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_a.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_a.Enabled = false;
            this.txt_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_a.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_a.Location = new System.Drawing.Point(168, 88);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(40, 14);
            this.txt_a.TabIndex = 68;
            this.txt_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_cuatri
            // 
            this.txt_cuatri.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cuatri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cuatri.Enabled = false;
            this.txt_cuatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuatri.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_cuatri.Location = new System.Drawing.Point(332, 89);
            this.txt_cuatri.Name = "txt_cuatri";
            this.txt_cuatri.Size = new System.Drawing.Size(62, 14);
            this.txt_cuatri.TabIndex = 69;
            this.txt_cuatri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_categoria
            // 
            this.txt_categoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_categoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_categoria.Enabled = false;
            this.txt_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoria.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_categoria.Location = new System.Drawing.Point(302, 115);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(92, 14);
            this.txt_categoria.TabIndex = 70;
            this.txt_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_estado
            // 
            this.textBox_estado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_estado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_estado.Enabled = false;
            this.textBox_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_estado.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox_estado.Location = new System.Drawing.Point(81, 195);
            this.textBox_estado.Name = "textBox_estado";
            this.textBox_estado.Size = new System.Drawing.Size(313, 14);
            this.textBox_estado.TabIndex = 71;
            this.textBox_estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_plan
            // 
            this.txt_plan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_plan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_plan.Enabled = false;
            this.txt_plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_plan.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_plan.Location = new System.Drawing.Point(151, 115);
            this.txt_plan.Name = "txt_plan";
            this.txt_plan.Size = new System.Drawing.Size(57, 14);
            this.txt_plan.TabIndex = 72;
            this.txt_plan.Text = "2014";
            this.txt_plan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nombre_asignatura
            // 
            this.txt_nombre_asignatura.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombre_asignatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre_asignatura.Enabled = false;
            this.txt_nombre_asignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_asignatura.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_nombre_asignatura.Location = new System.Drawing.Point(81, 62);
            this.txt_nombre_asignatura.Name = "txt_nombre_asignatura";
            this.txt_nombre_asignatura.Size = new System.Drawing.Size(313, 14);
            this.txt_nombre_asignatura.TabIndex = 73;
            this.txt_nombre_asignatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_corr
            // 
            this.txt_corr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_corr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_corr.Enabled = false;
            this.txt_corr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_corr.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_corr.Location = new System.Drawing.Point(144, 141);
            this.txt_corr.Name = "txt_corr";
            this.txt_corr.Size = new System.Drawing.Size(250, 14);
            this.txt_corr.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(18, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 15);
            this.label8.TabIndex = 72;
            this.label8.Text = "CORRELATIVA DE:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_corr_a
            // 
            this.txt_corr_a.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_corr_a.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_corr_a.Enabled = false;
            this.txt_corr_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_corr_a.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt_corr_a.Location = new System.Drawing.Point(128, 167);
            this.txt_corr_a.Name = "txt_corr_a";
            this.txt_corr_a.Size = new System.Drawing.Size(266, 14);
            this.txt_corr_a.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(18, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 75;
            this.label9.Text = "CORRELATIVAS:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_asignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(414, 295);
            this.Controls.Add(this.txt_corr_a);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_corr);
            this.Controls.Add(this.txt_nombre_asignatura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_plan);
            this.Controls.Add(this.textBox_estado);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.txt_cuatri);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.check_intermedia);
            this.Controls.Add(this.check_no_aprobada);
            this.Controls.Add(this.check_aprobada);
            this.Controls.Add(this.textBox_nota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uncheck_intermedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uncheck_no_aprobada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uncheck_aprobada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_monbre);
            this.Controls.Add(this.label_cuatrimestre);
            this.Controls.Add(this.label_año);
            this.Controls.Add(this.label_codigo);
            this.Controls.Add(this.panel_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_asignatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_asignatura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_asignatura_FormClosing);
            this.Load += new System.EventHandler(this.Form_asignatura_Load);
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uncheck_aprobada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uncheck_no_aprobada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uncheck_intermedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_aprobada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_no_aprobada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_intermedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_cerrar_2;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Label label_barra_control;
        private System.Windows.Forms.Label label_codigo;
        private System.Windows.Forms.Label label_año;
        private System.Windows.Forms.Label label_cuatrimestre;
        private System.Windows.Forms.Label label_monbre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox uncheck_aprobada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox uncheck_no_aprobada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox uncheck_intermedia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_nota;
        private System.Windows.Forms.PictureBox check_aprobada;
        private System.Windows.Forms.PictureBox check_no_aprobada;
        private System.Windows.Forms.PictureBox check_intermedia;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_cuatri;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.TextBox textBox_estado;
        private System.Windows.Forms.TextBox txt_plan;
        private System.Windows.Forms.TextBox txt_nombre_asignatura;
        private System.Windows.Forms.TextBox txt_corr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_corr_a;
        private System.Windows.Forms.Label label9;
    }
}
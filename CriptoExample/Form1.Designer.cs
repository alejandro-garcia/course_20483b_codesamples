namespace CriptoExample
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label13 = new System.Windows.Forms.Label();
            this.txtClavePublicaEnviador = new System.Windows.Forms.TextBox();
            this.txtFirmaEnviador = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtClaveEncriptadaEnviador = new System.Windows.Forms.TextBox();
            this.btnDesencriptarClaveSimetricaEnviador = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnValidarClavePublica = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_ExtraerInformacionClaveEnviador = new System.Windows.Forms.Button();
            this.txtPublicaAsimetricaEnviador = new System.Windows.Forms.TextBox();
            this.txtPrivadaAsimetricaEnviador = new System.Windows.Forms.TextBox();
            this.btnClavesAsimetricasEnviador = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirmaReceptor = new System.Windows.Forms.TextBox();
            this.txtValorHashReceptor = new System.Windows.Forms.TextBox();
            this.txtClaveEncriptadaReceptor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEncriptarInformacionClave = new System.Windows.Forms.Button();
            this.txtSimetricaKeyReceptor = new System.Windows.Forms.TextBox();
            this.txtSimetricaIVReceptor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSimetricaReceptor = new System.Windows.Forms.Button();
            this.txtPublicaAsimetricaReceptor = new System.Windows.Forms.TextBox();
            this.txtPrivadaAsimetricaReceptor = new System.Windows.Forms.TextBox();
            this.btnClavesAsimetricasReceptor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSimetricaKeyEnviador = new System.Windows.Forms.TextBox();
            this.txtSimetricaIVEnviador = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtSimetricaKeyEnviador);
            this.splitContainer1.Panel1.Controls.Add(this.txtSimetricaIVEnviador);
            this.splitContainer1.Panel1.Controls.Add(this.label21);
            this.splitContainer1.Panel1.Controls.Add(this.label22);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.txtClavePublicaEnviador);
            this.splitContainer1.Panel1.Controls.Add(this.txtFirmaEnviador);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.txtClaveEncriptadaEnviador);
            this.splitContainer1.Panel1.Controls.Add(this.btnDesencriptarClaveSimetricaEnviador);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.btnValidarClavePublica);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ExtraerInformacionClaveEnviador);
            this.splitContainer1.Panel1.Controls.Add(this.txtPublicaAsimetricaEnviador);
            this.splitContainer1.Panel1.Controls.Add(this.txtPrivadaAsimetricaEnviador);
            this.splitContainer1.Panel1.Controls.Add(this.btnClavesAsimetricasEnviador);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtFirmaReceptor);
            this.splitContainer1.Panel2.Controls.Add(this.txtValorHashReceptor);
            this.splitContainer1.Panel2.Controls.Add(this.txtClaveEncriptadaReceptor);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.btnEncriptarInformacionClave);
            this.splitContainer1.Panel2.Controls.Add(this.txtSimetricaKeyReceptor);
            this.splitContainer1.Panel2.Controls.Add(this.txtSimetricaIVReceptor);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.btnSimetricaReceptor);
            this.splitContainer1.Panel2.Controls.Add(this.txtPublicaAsimetricaReceptor);
            this.splitContainer1.Panel2.Controls.Add(this.txtPrivadaAsimetricaReceptor);
            this.splitContainer1.Panel2.Controls.Add(this.btnClavesAsimetricasReceptor);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox4);
            this.splitContainer1.Panel2.Controls.Add(this.label16);
            this.splitContainer1.Panel2.Controls.Add(this.label17);
            this.splitContainer1.Panel2.Controls.Add(this.label18);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox5);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox6);
            this.splitContainer1.Panel2.Controls.Add(this.textBox7);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.label19);
            this.splitContainer1.Panel2.Controls.Add(this.label20);
            this.splitContainer1.Size = new System.Drawing.Size(784, 561);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Clave Publica";
            // 
            // txtClavePublicaEnviador
            // 
            this.txtClavePublicaEnviador.Location = new System.Drawing.Point(106, 333);
            this.txtClavePublicaEnviador.Name = "txtClavePublicaEnviador";
            this.txtClavePublicaEnviador.Size = new System.Drawing.Size(258, 20);
            this.txtClavePublicaEnviador.TabIndex = 20;
            // 
            // txtFirmaEnviador
            // 
            this.txtFirmaEnviador.Location = new System.Drawing.Point(106, 307);
            this.txtFirmaEnviador.Name = "txtFirmaEnviador";
            this.txtFirmaEnviador.Size = new System.Drawing.Size(258, 20);
            this.txtFirmaEnviador.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(211, 464);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 27);
            this.button4.TabIndex = 23;
            this.button4.Text = "Enviar >>";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtClaveEncriptadaEnviador
            // 
            this.txtClaveEncriptadaEnviador.Location = new System.Drawing.Point(106, 283);
            this.txtClaveEncriptadaEnviador.Name = "txtClaveEncriptadaEnviador";
            this.txtClaveEncriptadaEnviador.Size = new System.Drawing.Size(258, 20);
            this.txtClaveEncriptadaEnviador.TabIndex = 22;
            // 
            // btnDesencriptarClaveSimetricaEnviador
            // 
            this.btnDesencriptarClaveSimetricaEnviador.Location = new System.Drawing.Point(16, 370);
            this.btnDesencriptarClaveSimetricaEnviador.Name = "btnDesencriptarClaveSimetricaEnviador";
            this.btnDesencriptarClaveSimetricaEnviador.Size = new System.Drawing.Size(162, 20);
            this.btnDesencriptarClaveSimetricaEnviador.TabIndex = 22;
            this.btnDesencriptarClaveSimetricaEnviador.Text = "Desencriptar la clave simetrica";
            this.btnDesencriptarClaveSimetricaEnviador.UseVisualStyleBackColor = true;
            this.btnDesencriptarClaveSimetricaEnviador.Click += new System.EventHandler(this.btnDesencriptarClaveSimetricaEnviador_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Firma";
            // 
            // btnValidarClavePublica
            // 
            this.btnValidarClavePublica.Location = new System.Drawing.Point(184, 240);
            this.btnValidarClavePublica.Name = "btnValidarClavePublica";
            this.btnValidarClavePublica.Size = new System.Drawing.Size(162, 27);
            this.btnValidarClavePublica.TabIndex = 21;
            this.btnValidarClavePublica.Text = "Validar Clave Publica";
            this.btnValidarClavePublica.UseVisualStyleBackColor = true;
            this.btnValidarClavePublica.Click += new System.EventHandler(this.btnValidarClavePublica_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Clave encriptada";
            // 
            // btn_ExtraerInformacionClaveEnviador
            // 
            this.btn_ExtraerInformacionClaveEnviador.Location = new System.Drawing.Point(16, 240);
            this.btn_ExtraerInformacionClaveEnviador.Name = "btn_ExtraerInformacionClaveEnviador";
            this.btn_ExtraerInformacionClaveEnviador.Size = new System.Drawing.Size(162, 27);
            this.btn_ExtraerInformacionClaveEnviador.TabIndex = 20;
            this.btn_ExtraerInformacionClaveEnviador.Text = "Encriptar Informacion Clave";
            this.btn_ExtraerInformacionClaveEnviador.UseVisualStyleBackColor = true;
            this.btn_ExtraerInformacionClaveEnviador.Click += new System.EventHandler(this.btn_ExtraerInformacionClaveEnviador_Click);
            // 
            // txtPublicaAsimetricaEnviador
            // 
            this.txtPublicaAsimetricaEnviador.Location = new System.Drawing.Point(93, 155);
            this.txtPublicaAsimetricaEnviador.Multiline = true;
            this.txtPublicaAsimetricaEnviador.Name = "txtPublicaAsimetricaEnviador";
            this.txtPublicaAsimetricaEnviador.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPublicaAsimetricaEnviador.Size = new System.Drawing.Size(272, 60);
            this.txtPublicaAsimetricaEnviador.TabIndex = 5;
            // 
            // txtPrivadaAsimetricaEnviador
            // 
            this.txtPrivadaAsimetricaEnviador.Location = new System.Drawing.Point(93, 89);
            this.txtPrivadaAsimetricaEnviador.Multiline = true;
            this.txtPrivadaAsimetricaEnviador.Name = "txtPrivadaAsimetricaEnviador";
            this.txtPrivadaAsimetricaEnviador.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrivadaAsimetricaEnviador.Size = new System.Drawing.Size(272, 60);
            this.txtPrivadaAsimetricaEnviador.TabIndex = 4;
            // 
            // btnClavesAsimetricasEnviador
            // 
            this.btnClavesAsimetricasEnviador.Location = new System.Drawing.Point(16, 42);
            this.btnClavesAsimetricasEnviador.Name = "btnClavesAsimetricasEnviador";
            this.btnClavesAsimetricasEnviador.Size = new System.Drawing.Size(162, 27);
            this.btnClavesAsimetricasEnviador.TabIndex = 3;
            this.btnClavesAsimetricasEnviador.Text = "Crear Claves Asimetricas";
            this.btnClavesAsimetricasEnviador.UseVisualStyleBackColor = true;
            this.btnClavesAsimetricasEnviador.Click += new System.EventHandler(this.btnClavesAsimetricasEnviador_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave Publica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave Privada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enviador";
            // 
            // txtFirmaReceptor
            // 
            this.txtFirmaReceptor.Location = new System.Drawing.Point(103, 396);
            this.txtFirmaReceptor.Name = "txtFirmaReceptor";
            this.txtFirmaReceptor.Size = new System.Drawing.Size(258, 20);
            this.txtFirmaReceptor.TabIndex = 19;
            // 
            // txtValorHashReceptor
            // 
            this.txtValorHashReceptor.Location = new System.Drawing.Point(103, 370);
            this.txtValorHashReceptor.Name = "txtValorHashReceptor";
            this.txtValorHashReceptor.Size = new System.Drawing.Size(258, 20);
            this.txtValorHashReceptor.TabIndex = 18;
            // 
            // txtClaveEncriptadaReceptor
            // 
            this.txtClaveEncriptadaReceptor.Location = new System.Drawing.Point(103, 343);
            this.txtClaveEncriptadaReceptor.Name = "txtClaveEncriptadaReceptor";
            this.txtClaveEncriptadaReceptor.Size = new System.Drawing.Size(258, 20);
            this.txtClaveEncriptadaReceptor.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Firma";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Valor hash";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Clave encriptada";
            // 
            // btnEncriptarInformacionClave
            // 
            this.btnEncriptarInformacionClave.Location = new System.Drawing.Point(13, 300);
            this.btnEncriptarInformacionClave.Name = "btnEncriptarInformacionClave";
            this.btnEncriptarInformacionClave.Size = new System.Drawing.Size(154, 27);
            this.btnEncriptarInformacionClave.TabIndex = 13;
            this.btnEncriptarInformacionClave.Text = "Encriptar Informacion Clave";
            this.btnEncriptarInformacionClave.UseVisualStyleBackColor = true;
            this.btnEncriptarInformacionClave.Click += new System.EventHandler(this.btnEncriptarInformacionClave_Click);
            // 
            // txtSimetricaKeyReceptor
            // 
            this.txtSimetricaKeyReceptor.Location = new System.Drawing.Point(103, 265);
            this.txtSimetricaKeyReceptor.Name = "txtSimetricaKeyReceptor";
            this.txtSimetricaKeyReceptor.Size = new System.Drawing.Size(258, 20);
            this.txtSimetricaKeyReceptor.TabIndex = 12;
            // 
            // txtSimetricaIVReceptor
            // 
            this.txtSimetricaIVReceptor.Location = new System.Drawing.Point(103, 237);
            this.txtSimetricaIVReceptor.Name = "txtSimetricaIVReceptor";
            this.txtSimetricaIVReceptor.Size = new System.Drawing.Size(258, 20);
            this.txtSimetricaIVReceptor.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "KEY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "IV";
            // 
            // btnSimetricaReceptor
            // 
            this.btnSimetricaReceptor.Location = new System.Drawing.Point(12, 194);
            this.btnSimetricaReceptor.Name = "btnSimetricaReceptor";
            this.btnSimetricaReceptor.Size = new System.Drawing.Size(154, 27);
            this.btnSimetricaReceptor.TabIndex = 8;
            this.btnSimetricaReceptor.Text = "Crear Clave Simetrica";
            this.btnSimetricaReceptor.UseVisualStyleBackColor = true;
            this.btnSimetricaReceptor.Click += new System.EventHandler(this.btnSimetricaReceptor_Click);
            // 
            // txtPublicaAsimetricaReceptor
            // 
            this.txtPublicaAsimetricaReceptor.Location = new System.Drawing.Point(89, 118);
            this.txtPublicaAsimetricaReceptor.Multiline = true;
            this.txtPublicaAsimetricaReceptor.Name = "txtPublicaAsimetricaReceptor";
            this.txtPublicaAsimetricaReceptor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPublicaAsimetricaReceptor.Size = new System.Drawing.Size(272, 60);
            this.txtPublicaAsimetricaReceptor.TabIndex = 7;
            // 
            // txtPrivadaAsimetricaReceptor
            // 
            this.txtPrivadaAsimetricaReceptor.Location = new System.Drawing.Point(89, 52);
            this.txtPrivadaAsimetricaReceptor.Multiline = true;
            this.txtPrivadaAsimetricaReceptor.Name = "txtPrivadaAsimetricaReceptor";
            this.txtPrivadaAsimetricaReceptor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrivadaAsimetricaReceptor.Size = new System.Drawing.Size(272, 60);
            this.txtPrivadaAsimetricaReceptor.TabIndex = 6;
            // 
            // btnClavesAsimetricasReceptor
            // 
            this.btnClavesAsimetricasReceptor.Location = new System.Drawing.Point(13, 12);
            this.btnClavesAsimetricasReceptor.Name = "btnClavesAsimetricasReceptor";
            this.btnClavesAsimetricasReceptor.Size = new System.Drawing.Size(154, 27);
            this.btnClavesAsimetricasReceptor.TabIndex = 5;
            this.btnClavesAsimetricasReceptor.Text = "Crear Claves Asimetricas";
            this.btnClavesAsimetricasReceptor.UseVisualStyleBackColor = true;
            this.btnClavesAsimetricasReceptor.Click += new System.EventHandler(this.btnClavesAsimetricasReceptor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Clave Publica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clave Privada";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "KEY";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(55, 240);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "IV";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 396);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 370);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(258, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 343);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(258, 20);
            this.textBox4.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 398);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Firma";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 370);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Valor hash";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 343);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Clave encriptada";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Encriptar Informacion Clave";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(103, 265);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(258, 20);
            this.textBox5.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Crear Clave Simetrica";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(89, 118);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(272, 60);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(89, 52);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox7.Size = new System.Drawing.Size(272, 60);
            this.textBox7.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "Crear Claves Asimetricas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 136);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Clave Publica";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 76);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Clave Privada";
            // 
            // txtSimetricaKeyEnviador
            // 
            this.txtSimetricaKeyEnviador.Location = new System.Drawing.Point(106, 426);
            this.txtSimetricaKeyEnviador.Name = "txtSimetricaKeyEnviador";
            this.txtSimetricaKeyEnviador.Size = new System.Drawing.Size(258, 20);
            this.txtSimetricaKeyEnviador.TabIndex = 28;
            // 
            // txtSimetricaIVEnviador
            // 
            this.txtSimetricaIVEnviador.Location = new System.Drawing.Point(106, 398);
            this.txtSimetricaIVEnviador.Name = "txtSimetricaIVEnviador";
            this.txtSimetricaIVEnviador.Size = new System.Drawing.Size(258, 20);
            this.txtSimetricaIVEnviador.TabIndex = 27;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(58, 429);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "KEY";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(58, 401);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "IV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtPublicaAsimetricaEnviador;
        private System.Windows.Forms.TextBox txtPrivadaAsimetricaEnviador;
        private System.Windows.Forms.Button btnClavesAsimetricasEnviador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPublicaAsimetricaReceptor;
        private System.Windows.Forms.TextBox txtPrivadaAsimetricaReceptor;
        private System.Windows.Forms.Button btnClavesAsimetricasReceptor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSimetricaKeyReceptor;
        private System.Windows.Forms.TextBox txtSimetricaIVReceptor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSimetricaReceptor;
        private System.Windows.Forms.TextBox txtFirmaReceptor;
        private System.Windows.Forms.TextBox txtValorHashReceptor;
        private System.Windows.Forms.TextBox txtClaveEncriptadaReceptor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEncriptarInformacionClave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtClavePublicaEnviador;
        private System.Windows.Forms.TextBox txtFirmaEnviador;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtClaveEncriptadaEnviador;
        private System.Windows.Forms.Button btnDesencriptarClaveSimetricaEnviador;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnValidarClavePublica;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_ExtraerInformacionClaveEnviador;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSimetricaKeyEnviador;
        private System.Windows.Forms.TextBox txtSimetricaIVEnviador;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}


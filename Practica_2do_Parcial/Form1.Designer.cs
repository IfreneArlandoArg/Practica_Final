namespace Practica_2do_Parcial
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsbDarsenas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumDarsena = new System.Windows.Forms.TextBox();
            this.btnAltaDarsena = new System.Windows.Forms.Button();
            this.btnOrdenarDarsenas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOrdenarEmbarcaciones = new System.Windows.Forms.Button();
            this.btnAltaEmbarcacion = new System.Windows.Forms.Button();
            this.txtNombreEmbarc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbEmbarcaciones = new System.Windows.Forms.ListBox();
            this.txtColorEmbarcacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPotenciaMotorEmbarcacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCostoEmbarcacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbLancha = new System.Windows.Forms.RadioButton();
            this.rbVelero = new System.Windows.Forms.RadioButton();
            this.rbCrucero = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.btnInstrucciones = new System.Windows.Forms.Button();
            this.lsbAlquileres = new System.Windows.Forms.ListBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrdenarDarsenas);
            this.groupBox1.Controls.Add(this.btnAltaDarsena);
            this.groupBox1.Controls.Add(this.txtNumDarsena);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lsbDarsenas);
            this.groupBox1.Location = new System.Drawing.Point(642, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 433);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Darsenas";
            // 
            // lsbDarsenas
            // 
            this.lsbDarsenas.FormattingEnabled = true;
            this.lsbDarsenas.HorizontalScrollbar = true;
            this.lsbDarsenas.ItemHeight = 20;
            this.lsbDarsenas.Location = new System.Drawing.Point(23, 42);
            this.lsbDarsenas.Name = "lsbDarsenas";
            this.lsbDarsenas.Size = new System.Drawing.Size(498, 264);
            this.lsbDarsenas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero :";
            // 
            // txtNumDarsena
            // 
            this.txtNumDarsena.Location = new System.Drawing.Point(120, 330);
            this.txtNumDarsena.Name = "txtNumDarsena";
            this.txtNumDarsena.Size = new System.Drawing.Size(100, 26);
            this.txtNumDarsena.TabIndex = 2;
            // 
            // btnAltaDarsena
            // 
            this.btnAltaDarsena.Location = new System.Drawing.Point(120, 380);
            this.btnAltaDarsena.Name = "btnAltaDarsena";
            this.btnAltaDarsena.Size = new System.Drawing.Size(100, 30);
            this.btnAltaDarsena.TabIndex = 3;
            this.btnAltaDarsena.Text = "Alta";
            this.btnAltaDarsena.UseVisualStyleBackColor = true;
            this.btnAltaDarsena.Click += new System.EventHandler(this.btnAltaDarsena_Click);
            // 
            // btnOrdenarDarsenas
            // 
            this.btnOrdenarDarsenas.Location = new System.Drawing.Point(285, 328);
            this.btnOrdenarDarsenas.Name = "btnOrdenarDarsenas";
            this.btnOrdenarDarsenas.Size = new System.Drawing.Size(100, 30);
            this.btnOrdenarDarsenas.TabIndex = 4;
            this.btnOrdenarDarsenas.Text = "Ordenar";
            this.btnOrdenarDarsenas.UseVisualStyleBackColor = true;
            this.btnOrdenarDarsenas.Click += new System.EventHandler(this.btnOrdenarDarsenas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnOrdenarEmbarcaciones);
            this.groupBox2.Controls.Add(this.btnAltaEmbarcacion);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtCostoEmbarcacion);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPotenciaMotorEmbarcacion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtColorEmbarcacion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNombreEmbarc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lsbEmbarcaciones);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 630);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Embarcaciones";
            // 
            // btnOrdenarEmbarcaciones
            // 
            this.btnOrdenarEmbarcaciones.Location = new System.Drawing.Point(261, 507);
            this.btnOrdenarEmbarcaciones.Name = "btnOrdenarEmbarcaciones";
            this.btnOrdenarEmbarcaciones.Size = new System.Drawing.Size(100, 30);
            this.btnOrdenarEmbarcaciones.TabIndex = 4;
            this.btnOrdenarEmbarcaciones.Text = "Ordenar";
            this.btnOrdenarEmbarcaciones.UseVisualStyleBackColor = true;
            this.btnOrdenarEmbarcaciones.Click += new System.EventHandler(this.btnOrdenarEmbarcaciones_Click);
            // 
            // btnAltaEmbarcacion
            // 
            this.btnAltaEmbarcacion.Location = new System.Drawing.Point(500, 507);
            this.btnAltaEmbarcacion.Name = "btnAltaEmbarcacion";
            this.btnAltaEmbarcacion.Size = new System.Drawing.Size(100, 30);
            this.btnAltaEmbarcacion.TabIndex = 3;
            this.btnAltaEmbarcacion.Text = "Alta";
            this.btnAltaEmbarcacion.UseVisualStyleBackColor = true;
            this.btnAltaEmbarcacion.Click += new System.EventHandler(this.btnAltaEmbarcacion_Click);
            // 
            // txtNombreEmbarc
            // 
            this.txtNombreEmbarc.Location = new System.Drawing.Point(382, 328);
            this.txtNombreEmbarc.Name = "txtNombreEmbarc";
            this.txtNombreEmbarc.Size = new System.Drawing.Size(225, 26);
            this.txtNombreEmbarc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Registrado :";
            // 
            // lsbEmbarcaciones
            // 
            this.lsbEmbarcaciones.FormattingEnabled = true;
            this.lsbEmbarcaciones.HorizontalScrollbar = true;
            this.lsbEmbarcaciones.ItemHeight = 20;
            this.lsbEmbarcaciones.Location = new System.Drawing.Point(23, 42);
            this.lsbEmbarcaciones.Name = "lsbEmbarcaciones";
            this.lsbEmbarcaciones.Size = new System.Drawing.Size(584, 264);
            this.lsbEmbarcaciones.TabIndex = 0;
            // 
            // txtColorEmbarcacion
            // 
            this.txtColorEmbarcacion.Location = new System.Drawing.Point(382, 367);
            this.txtColorEmbarcacion.Name = "txtColorEmbarcacion";
            this.txtColorEmbarcacion.Size = new System.Drawing.Size(225, 26);
            this.txtColorEmbarcacion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Color :";
            // 
            // txtPotenciaMotorEmbarcacion
            // 
            this.txtPotenciaMotorEmbarcacion.Location = new System.Drawing.Point(382, 411);
            this.txtPotenciaMotorEmbarcacion.Name = "txtPotenciaMotorEmbarcacion";
            this.txtPotenciaMotorEmbarcacion.Size = new System.Drawing.Size(225, 26);
            this.txtPotenciaMotorEmbarcacion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Potencia Motor :";
            // 
            // txtCostoEmbarcacion
            // 
            this.txtCostoEmbarcacion.Location = new System.Drawing.Point(383, 454);
            this.txtCostoEmbarcacion.Name = "txtCostoEmbarcacion";
            this.txtCostoEmbarcacion.Size = new System.Drawing.Size(225, 26);
            this.txtCostoEmbarcacion.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Costo :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbCrucero);
            this.groupBox3.Controls.Add(this.rbVelero);
            this.groupBox3.Controls.Add(this.rbLancha);
            this.groupBox3.Location = new System.Drawing.Point(23, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 143);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo";
            // 
            // rbLancha
            // 
            this.rbLancha.AutoSize = true;
            this.rbLancha.Checked = true;
            this.rbLancha.Location = new System.Drawing.Point(18, 27);
            this.rbLancha.Name = "rbLancha";
            this.rbLancha.Size = new System.Drawing.Size(87, 24);
            this.rbLancha.TabIndex = 0;
            this.rbLancha.TabStop = true;
            this.rbLancha.Text = "Lancha";
            this.rbLancha.UseVisualStyleBackColor = true;
            // 
            // rbVelero
            // 
            this.rbVelero.AutoSize = true;
            this.rbVelero.Location = new System.Drawing.Point(18, 62);
            this.rbVelero.Name = "rbVelero";
            this.rbVelero.Size = new System.Drawing.Size(80, 24);
            this.rbVelero.TabIndex = 1;
            this.rbVelero.Text = "Velero";
            this.rbVelero.UseVisualStyleBackColor = true;
            // 
            // rbCrucero
            // 
            this.rbCrucero.AutoSize = true;
            this.rbCrucero.Location = new System.Drawing.Point(18, 93);
            this.rbCrucero.Name = "rbCrucero";
            this.rbCrucero.Size = new System.Drawing.Size(90, 24);
            this.rbCrucero.TabIndex = 2;
            this.rbCrucero.Text = "Crucero";
            this.rbCrucero.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAlquilar);
            this.groupBox4.Controls.Add(this.btnInstrucciones);
            this.groupBox4.Controls.Add(this.lsbAlquileres);
            this.groupBox4.Location = new System.Drawing.Point(645, 451);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(544, 385);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alquileres";
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.Location = new System.Drawing.Point(24, 323);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(100, 30);
            this.btnAlquilar.TabIndex = 4;
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.UseVisualStyleBackColor = true;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // btnInstrucciones
            // 
            this.btnInstrucciones.Location = new System.Drawing.Point(408, 323);
            this.btnInstrucciones.Name = "btnInstrucciones";
            this.btnInstrucciones.Size = new System.Drawing.Size(117, 30);
            this.btnInstrucciones.TabIndex = 3;
            this.btnInstrucciones.Text = "Instrucciones";
            this.btnInstrucciones.UseVisualStyleBackColor = true;
            this.btnInstrucciones.Click += new System.EventHandler(this.btnInstrucciones_Click);
            // 
            // lsbAlquileres
            // 
            this.lsbAlquileres.FormattingEnabled = true;
            this.lsbAlquileres.HorizontalScrollbar = true;
            this.lsbAlquileres.ItemHeight = 20;
            this.lsbAlquileres.Location = new System.Drawing.Point(23, 42);
            this.lsbAlquileres.Name = "lsbAlquileres";
            this.lsbAlquileres.Size = new System.Drawing.Size(498, 264);
            this.lsbAlquileres.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(500, 550);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 30);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1201, 1018);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAltaDarsena;
        private System.Windows.Forms.TextBox txtNumDarsena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbDarsenas;
        private System.Windows.Forms.Button btnOrdenarDarsenas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOrdenarEmbarcaciones;
        private System.Windows.Forms.Button btnAltaEmbarcacion;
        private System.Windows.Forms.TextBox txtNombreEmbarc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbEmbarcaciones;
        private System.Windows.Forms.TextBox txtCostoEmbarcacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPotenciaMotorEmbarcacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColorEmbarcacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbCrucero;
        private System.Windows.Forms.RadioButton rbVelero;
        private System.Windows.Forms.RadioButton rbLancha;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.Button btnInstrucciones;
        private System.Windows.Forms.ListBox lsbAlquileres;
        private System.Windows.Forms.Button btnModificar;
    }
}


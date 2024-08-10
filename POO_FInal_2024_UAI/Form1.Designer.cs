namespace POO_FInal_2024_UAI
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
            this.lsbAnimales = new System.Windows.Forms.ListBox();
            this.cbAnimales = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarAnimal = new System.Windows.Forms.Button();
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAgregarAlimento = new System.Windows.Forms.Button();
            this.cbAnimalAlimento = new System.Windows.Forms.ComboBox();
            this.lsbAlimentos = new System.Windows.Forms.ListBox();
            this.cbVegetacion = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbAnimal = new System.Windows.Forms.RadioButton();
            this.rbVegetacion = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lsbAnimalAlimentos = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAlimentar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lsbAnimales);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 522);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animales";
            // 
            // lsbAnimales
            // 
            this.lsbAnimales.FormattingEnabled = true;
            this.lsbAnimales.ItemHeight = 20;
            this.lsbAnimales.Location = new System.Drawing.Point(7, 26);
            this.lsbAnimales.Name = "lsbAnimales";
            this.lsbAnimales.Size = new System.Drawing.Size(476, 324);
            this.lsbAnimales.TabIndex = 0;
            this.lsbAnimales.SelectedIndexChanged += new System.EventHandler(this.lsbAnimales_SelectedIndexChanged);
            // 
            // cbAnimales
            // 
            this.cbAnimales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimales.FormattingEnabled = true;
            this.cbAnimales.Items.AddRange(new object[] {
            "Tigre",
            "León",
            "Ciervo",
            "Cebra"});
            this.cbAnimales.Location = new System.Drawing.Point(17, 28);
            this.cbAnimales.Name = "cbAnimales";
            this.cbAnimales.Size = new System.Drawing.Size(174, 28);
            this.cbAnimales.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarAnimal);
            this.groupBox2.Controls.Add(this.cbAnimales);
            this.groupBox2.Location = new System.Drawing.Point(7, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 93);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animal";
            // 
            // btnAgregarAnimal
            // 
            this.btnAgregarAnimal.Location = new System.Drawing.Point(274, 29);
            this.btnAgregarAnimal.Name = "btnAgregarAnimal";
            this.btnAgregarAnimal.Size = new System.Drawing.Size(125, 33);
            this.btnAgregarAnimal.TabIndex = 2;
            this.btnAgregarAnimal.Text = "Agregar";
            this.btnAgregarAnimal.UseVisualStyleBackColor = true;
            this.btnAgregarAnimal.Click += new System.EventHandler(this.btnAgregarAnimal_Click);
            // 
            // btnAlimentar
            // 
            this.btnAlimentar.Location = new System.Drawing.Point(281, 474);
            this.btnAlimentar.Name = "btnAlimentar";
            this.btnAlimentar.Size = new System.Drawing.Size(125, 33);
            this.btnAlimentar.TabIndex = 3;
            this.btnAlimentar.Text = "Alimentar";
            this.btnAlimentar.UseVisualStyleBackColor = true;
            this.btnAlimentar.Click += new System.EventHandler(this.btnAlimentar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.btnAgregarAlimento);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.lsbAlimentos);
            this.groupBox3.Location = new System.Drawing.Point(519, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 522);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alimentos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbVegetacion);
            this.groupBox4.Controls.Add(this.cbAnimalAlimento);
            this.groupBox4.Location = new System.Drawing.Point(243, 366);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 104);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alimento";
            // 
            // btnAgregarAlimento
            // 
            this.btnAgregarAlimento.Location = new System.Drawing.Point(69, 474);
            this.btnAgregarAlimento.Name = "btnAgregarAlimento";
            this.btnAgregarAlimento.Size = new System.Drawing.Size(125, 33);
            this.btnAgregarAlimento.TabIndex = 2;
            this.btnAgregarAlimento.Text = "Agregar";
            this.btnAgregarAlimento.UseVisualStyleBackColor = true;
            this.btnAgregarAlimento.Click += new System.EventHandler(this.btnAgregarAlimento_Click);
            // 
            // cbAnimalAlimento
            // 
            this.cbAnimalAlimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimalAlimento.FormattingEnabled = true;
            this.cbAnimalAlimento.Items.AddRange(new object[] {
            "Ciervo",
            "Cebra"});
            this.cbAnimalAlimento.Location = new System.Drawing.Point(34, 59);
            this.cbAnimalAlimento.Name = "cbAnimalAlimento";
            this.cbAnimalAlimento.Size = new System.Drawing.Size(174, 28);
            this.cbAnimalAlimento.TabIndex = 1;
            // 
            // lsbAlimentos
            // 
            this.lsbAlimentos.FormattingEnabled = true;
            this.lsbAlimentos.ItemHeight = 20;
            this.lsbAlimentos.Location = new System.Drawing.Point(7, 26);
            this.lsbAlimentos.Name = "lsbAlimentos";
            this.lsbAlimentos.Size = new System.Drawing.Size(476, 324);
            this.lsbAlimentos.TabIndex = 0;
            // 
            // cbVegetacion
            // 
            this.cbVegetacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVegetacion.FormattingEnabled = true;
            this.cbVegetacion.Items.AddRange(new object[] {
            "Pasto",
            "Flores",
            "Plantas"});
            this.cbVegetacion.Location = new System.Drawing.Point(34, 25);
            this.cbVegetacion.Name = "cbVegetacion";
            this.cbVegetacion.Size = new System.Drawing.Size(174, 28);
            this.cbVegetacion.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbVegetacion);
            this.groupBox5.Controls.Add(this.rbAnimal);
            this.groupBox5.Location = new System.Drawing.Point(6, 366);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(221, 104);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Alimento";
            // 
            // rbAnimal
            // 
            this.rbAnimal.AutoSize = true;
            this.rbAnimal.Location = new System.Drawing.Point(22, 59);
            this.rbAnimal.Name = "rbAnimal";
            this.rbAnimal.Size = new System.Drawing.Size(82, 24);
            this.rbAnimal.TabIndex = 0;
            this.rbAnimal.Text = "Animal";
            this.rbAnimal.UseVisualStyleBackColor = true;
            // 
            // rbVegetacion
            // 
            this.rbVegetacion.AutoSize = true;
            this.rbVegetacion.Checked = true;
            this.rbVegetacion.Location = new System.Drawing.Point(22, 29);
            this.rbVegetacion.Name = "rbVegetacion";
            this.rbVegetacion.Size = new System.Drawing.Size(115, 24);
            this.rbVegetacion.TabIndex = 1;
            this.rbVegetacion.TabStop = true;
            this.rbVegetacion.Text = "Vegetacion";
            this.rbVegetacion.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lsbAnimalAlimentos);
            this.groupBox6.Location = new System.Drawing.Point(1014, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(489, 370);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Animal - Alimento(s)";
            // 
            // lsbAnimalAlimentos
            // 
            this.lsbAnimalAlimentos.FormattingEnabled = true;
            this.lsbAnimalAlimentos.ItemHeight = 20;
            this.lsbAnimalAlimentos.Location = new System.Drawing.Point(7, 26);
            this.lsbAnimalAlimentos.Name = "lsbAnimalAlimentos";
            this.lsbAnimalAlimentos.Size = new System.Drawing.Size(476, 324);
            this.lsbAnimalAlimentos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 563);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Zoologico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbAnimales;
        private System.Windows.Forms.ListBox lsbAnimales;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAlimentar;
        private System.Windows.Forms.Button btnAgregarAnimal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAgregarAlimento;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbVegetacion;
        private System.Windows.Forms.ComboBox cbAnimalAlimento;
        private System.Windows.Forms.ListBox lsbAlimentos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbVegetacion;
        private System.Windows.Forms.RadioButton rbAnimal;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lsbAnimalAlimentos;
    }
}


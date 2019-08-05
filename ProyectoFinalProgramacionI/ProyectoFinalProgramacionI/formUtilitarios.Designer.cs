namespace ProyectoFinalProgramacionI
{
    partial class FormUtilitarios
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
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGrado1 = new System.Windows.Forms.TextBox();
            this.comboBoxGrados = new System.Windows.Forms.ComboBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.txtResultado1 = new System.Windows.Forms.TextBox();
            this.txtResultado2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxMoneda = new System.Windows.Forms.ComboBox();
            this.txtMoneda1 = new System.Windows.Forms.TextBox();
            this.buttonLimpiar3 = new System.Windows.Forms.Button();
            this.buttonConvertir2 = new System.Windows.Forms.Button();
            this.buttonConvertir1 = new System.Windows.Forms.Button();
            this.buttonLimpiar2 = new System.Windows.Forms.Button();
            this.buttonLimpiar1 = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Font = new System.Drawing.Font("Permanent Marker", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenida.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelBienvenida.Location = new System.Drawing.Point(188, 21);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(293, 41);
            this.labelBienvenida.TabIndex = 9;
            this.labelBienvenida.Text = "Modulo Utilitarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(187, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = "Conversion de Grados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 21.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(183, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 43);
            this.label2.TabIndex = 11;
            this.label2.Text = "Conversion de Monedas";
            // 
            // txtGrado1
            // 
            this.txtGrado1.Location = new System.Drawing.Point(24, 166);
            this.txtGrado1.Name = "txtGrado1";
            this.txtGrado1.Size = new System.Drawing.Size(129, 20);
            this.txtGrado1.TabIndex = 12;
            // 
            // comboBoxGrados
            // 
            this.comboBoxGrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGrados.FormattingEnabled = true;
            this.comboBoxGrados.Items.AddRange(new object[] {
            "Celcius a Farenheit",
            "Farenheit a Celcius"});
            this.comboBoxGrados.Location = new System.Drawing.Point(159, 166);
            this.comboBoxGrados.Name = "comboBoxGrados";
            this.comboBoxGrados.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGrados.TabIndex = 13;
            this.comboBoxGrados.Text = "Seleccione";
            this.comboBoxGrados.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrados_SelectedIndexChanged);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(395, 168);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(94, 18);
            this.labelResultado.TabIndex = 15;
            this.labelResultado.Text = "Resultado:";
            // 
            // txtResultado1
            // 
            this.txtResultado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado1.Location = new System.Drawing.Point(495, 167);
            this.txtResultado1.Name = "txtResultado1";
            this.txtResultado1.Size = new System.Drawing.Size(129, 20);
            this.txtResultado1.TabIndex = 16;
            // 
            // txtResultado2
            // 
            this.txtResultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado2.Location = new System.Drawing.Point(495, 316);
            this.txtResultado2.Name = "txtResultado2";
            this.txtResultado2.Size = new System.Drawing.Size(129, 20);
            this.txtResultado2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Resultado:";
            // 
            // comboBoxMoneda
            // 
            this.comboBoxMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMoneda.FormattingEnabled = true;
            this.comboBoxMoneda.Items.AddRange(new object[] {
            "USD$ a RD$",
            "RD$ a USD$"});
            this.comboBoxMoneda.Location = new System.Drawing.Point(159, 314);
            this.comboBoxMoneda.Name = "comboBoxMoneda";
            this.comboBoxMoneda.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMoneda.TabIndex = 18;
            this.comboBoxMoneda.Text = "Seleccione";
            this.comboBoxMoneda.SelectedIndexChanged += new System.EventHandler(this.comboBoxMoneda_SelectedIndexChanged);
            // 
            // txtMoneda1
            // 
            this.txtMoneda1.Location = new System.Drawing.Point(24, 314);
            this.txtMoneda1.Name = "txtMoneda1";
            this.txtMoneda1.Size = new System.Drawing.Size(129, 20);
            this.txtMoneda1.TabIndex = 17;
            // 
            // buttonLimpiar3
            // 
            this.buttonLimpiar3.BackColor = System.Drawing.Color.Transparent;
            this.buttonLimpiar3.FlatAppearance.BorderSize = 0;
            this.buttonLimpiar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiar3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLimpiar3.Image = global::ProyectoFinalProgramacionI.Properties.Resources.icons8_broom_64;
            this.buttonLimpiar3.Location = new System.Drawing.Point(561, 361);
            this.buttonLimpiar3.Name = "buttonLimpiar3";
            this.buttonLimpiar3.Size = new System.Drawing.Size(75, 74);
            this.buttonLimpiar3.TabIndex = 28;
            this.buttonLimpiar3.UseVisualStyleBackColor = false;
            this.buttonLimpiar3.Click += new System.EventHandler(this.buttonLimpiar3_Click);
            // 
            // buttonConvertir2
            // 
            this.buttonConvertir2.BackColor = System.Drawing.Color.Transparent;
            this.buttonConvertir2.FlatAppearance.BorderSize = 0;
            this.buttonConvertir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConvertir2.Image = global::ProyectoFinalProgramacionI.Properties.Resources.icons8_go_48;
            this.buttonConvertir2.Location = new System.Drawing.Point(287, 303);
            this.buttonConvertir2.Name = "buttonConvertir2";
            this.buttonConvertir2.Size = new System.Drawing.Size(47, 46);
            this.buttonConvertir2.TabIndex = 27;
            this.buttonConvertir2.UseVisualStyleBackColor = false;
            this.buttonConvertir2.Click += new System.EventHandler(this.buttonConvertir2_Click);
            // 
            // buttonConvertir1
            // 
            this.buttonConvertir1.BackColor = System.Drawing.Color.Transparent;
            this.buttonConvertir1.FlatAppearance.BorderSize = 0;
            this.buttonConvertir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConvertir1.Image = global::ProyectoFinalProgramacionI.Properties.Resources.icons8_go_48;
            this.buttonConvertir1.Location = new System.Drawing.Point(287, 155);
            this.buttonConvertir1.Name = "buttonConvertir1";
            this.buttonConvertir1.Size = new System.Drawing.Size(47, 46);
            this.buttonConvertir1.TabIndex = 26;
            this.buttonConvertir1.UseVisualStyleBackColor = false;
            this.buttonConvertir1.Click += new System.EventHandler(this.buttonConvertir1_Click);
            // 
            // buttonLimpiar2
            // 
            this.buttonLimpiar2.BackColor = System.Drawing.Color.Transparent;
            this.buttonLimpiar2.FlatAppearance.BorderSize = 0;
            this.buttonLimpiar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiar2.Image = global::ProyectoFinalProgramacionI.Properties.Resources.icons8_erase_40;
            this.buttonLimpiar2.Location = new System.Drawing.Point(340, 303);
            this.buttonLimpiar2.Name = "buttonLimpiar2";
            this.buttonLimpiar2.Size = new System.Drawing.Size(47, 46);
            this.buttonLimpiar2.TabIndex = 25;
            this.buttonLimpiar2.UseVisualStyleBackColor = false;
            this.buttonLimpiar2.Click += new System.EventHandler(this.buttonLimpiar2_Click);
            // 
            // buttonLimpiar1
            // 
            this.buttonLimpiar1.BackColor = System.Drawing.Color.Transparent;
            this.buttonLimpiar1.FlatAppearance.BorderSize = 0;
            this.buttonLimpiar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiar1.Image = global::ProyectoFinalProgramacionI.Properties.Resources.icons8_erase_40;
            this.buttonLimpiar1.Location = new System.Drawing.Point(340, 155);
            this.buttonLimpiar1.Name = "buttonLimpiar1";
            this.buttonLimpiar1.Size = new System.Drawing.Size(47, 46);
            this.buttonLimpiar1.TabIndex = 23;
            this.buttonLimpiar1.UseVisualStyleBackColor = false;
            this.buttonLimpiar1.Click += new System.EventHandler(this.buttonLimpiar1_Click);
            // 
            // buttonInicio
            // 
            this.buttonInicio.BackColor = System.Drawing.Color.Transparent;
            this.buttonInicio.FlatAppearance.BorderSize = 0;
            this.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicio.Image = global::ProyectoFinalProgramacionI.Properties.Resources.icons8_home_64;
            this.buttonInicio.Location = new System.Drawing.Point(12, 361);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(75, 74);
            this.buttonInicio.TabIndex = 22;
            this.buttonInicio.UseVisualStyleBackColor = false;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // FormUtilitarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 447);
            this.Controls.Add(this.buttonLimpiar3);
            this.Controls.Add(this.buttonConvertir2);
            this.Controls.Add(this.buttonConvertir1);
            this.Controls.Add(this.buttonLimpiar2);
            this.Controls.Add(this.buttonLimpiar1);
            this.Controls.Add(this.buttonInicio);
            this.Controls.Add(this.txtResultado2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxMoneda);
            this.Controls.Add(this.txtMoneda1);
            this.Controls.Add(this.txtResultado1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.comboBoxGrados);
            this.Controls.Add(this.txtGrado1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBienvenida);
            this.Name = "FormUtilitarios";
            this.Text = "FormUtilitarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGrado1;
        private System.Windows.Forms.ComboBox comboBoxGrados;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox txtResultado1;
        private System.Windows.Forms.TextBox txtResultado2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxMoneda;
        private System.Windows.Forms.TextBox txtMoneda1;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button buttonLimpiar1;
        private System.Windows.Forms.Button buttonLimpiar2;
        private System.Windows.Forms.Button buttonConvertir2;
        private System.Windows.Forms.Button buttonConvertir1;
        private System.Windows.Forms.Button buttonLimpiar3;
    }
}
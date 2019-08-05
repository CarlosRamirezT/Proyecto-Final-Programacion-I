namespace ProyectoFinalProgramacionI
{
    partial class formInicio
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
            this.labelContactos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUtilitarios = new System.Windows.Forms.Label();
            this.buttonUtilitarios = new System.Windows.Forms.Button();
            this.buttonEventos = new System.Windows.Forms.Button();
            this.buttonContactos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.Font = new System.Drawing.Font("Permanent Marker", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenida.ForeColor = System.Drawing.Color.DarkRed;
            this.labelBienvenida.Location = new System.Drawing.Point(174, 18);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(122, 50);
            this.labelBienvenida.TabIndex = 3;
            this.labelBienvenida.Text = "Inicio";
            // 
            // labelContactos
            // 
            this.labelContactos.AutoSize = true;
            this.labelContactos.Font = new System.Drawing.Font("Permanent Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactos.Location = new System.Drawing.Point(34, 167);
            this.labelContactos.Name = "labelContactos";
            this.labelContactos.Size = new System.Drawing.Size(117, 30);
            this.labelContactos.TabIndex = 4;
            this.labelContactos.Text = "Contactos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Permanent Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Eventos";
            // 
            // labelUtilitarios
            // 
            this.labelUtilitarios.AutoSize = true;
            this.labelUtilitarios.Font = new System.Drawing.Font("Permanent Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUtilitarios.Location = new System.Drawing.Point(309, 167);
            this.labelUtilitarios.Name = "labelUtilitarios";
            this.labelUtilitarios.Size = new System.Drawing.Size(126, 30);
            this.labelUtilitarios.TabIndex = 7;
            this.labelUtilitarios.Text = "Utilitarios";
            // 
            // buttonUtilitarios
            // 
            this.buttonUtilitarios.BackColor = System.Drawing.Color.Transparent;
            this.buttonUtilitarios.FlatAppearance.BorderSize = 0;
            this.buttonUtilitarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUtilitarios.Image = global::ProyectoFinalProgramacionI.Properties.Resources.icons8_calculator_64;
            this.buttonUtilitarios.Location = new System.Drawing.Point(335, 95);
            this.buttonUtilitarios.Name = "buttonUtilitarios";
            this.buttonUtilitarios.Size = new System.Drawing.Size(75, 69);
            this.buttonUtilitarios.TabIndex = 0;
            this.buttonUtilitarios.UseVisualStyleBackColor = false;
            this.buttonUtilitarios.Click += new System.EventHandler(this.buttonUtilitarios_Click);
            // 
            // buttonEventos
            // 
            this.buttonEventos.BackColor = System.Drawing.Color.Transparent;
            this.buttonEventos.FlatAppearance.BorderSize = 0;
            this.buttonEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEventos.Image = global::ProyectoFinalProgramacionI.Properties.Resources.icons8_calendar_64;
            this.buttonEventos.Location = new System.Drawing.Point(195, 95);
            this.buttonEventos.Name = "buttonEventos";
            this.buttonEventos.Size = new System.Drawing.Size(75, 69);
            this.buttonEventos.TabIndex = 1;
            this.buttonEventos.UseVisualStyleBackColor = false;
            this.buttonEventos.Click += new System.EventHandler(this.buttonEventos_Click);
            // 
            // buttonContactos
            // 
            this.buttonContactos.BackColor = System.Drawing.Color.Transparent;
            this.buttonContactos.FlatAppearance.BorderSize = 0;
            this.buttonContactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContactos.Image = global::ProyectoFinalProgramacionI.Properties.Resources.icons8_contacts_80;
            this.buttonContactos.Location = new System.Drawing.Point(57, 95);
            this.buttonContactos.Name = "buttonContactos";
            this.buttonContactos.Size = new System.Drawing.Size(75, 69);
            this.buttonContactos.TabIndex = 0;
            this.buttonContactos.UseVisualStyleBackColor = false;
            this.buttonContactos.Click += new System.EventHandler(this.buttonContactos_Click);
            // 
            // formInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 238);
            this.Controls.Add(this.labelUtilitarios);
            this.Controls.Add(this.buttonUtilitarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelContactos);
            this.Controls.Add(this.labelBienvenida);
            this.Controls.Add(this.buttonEventos);
            this.Controls.Add(this.buttonContactos);
            this.Name = "formInicio";
            this.Text = "Proyecto Final";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonContactos;
        private System.Windows.Forms.Button buttonEventos;
        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Label labelContactos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUtilitarios;
        private System.Windows.Forms.Button buttonUtilitarios;
    }
}


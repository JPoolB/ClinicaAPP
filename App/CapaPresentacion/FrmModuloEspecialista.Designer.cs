﻿namespace CapaPresentacion
{
    partial class FrmModuloEspecialista
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoEspecialista = new System.Windows.Forms.TextBox();
            this.txtCmpEspecialista = new System.Windows.Forms.TextBox();
            this.txtNombreEspecialista = new System.Windows.Forms.TextBox();
            this.dgvEspecialista = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ramblin Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODULO REGISTRO DE ESPECIALISTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CMP ESPECIALISTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRE ESPECIALISTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "APELLIDO ESPECIALISTA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "ESPECIALIDAD";
            // 
            // txtApellidoEspecialista
            // 
            this.txtApellidoEspecialista.Location = new System.Drawing.Point(186, 144);
            this.txtApellidoEspecialista.Name = "txtApellidoEspecialista";
            this.txtApellidoEspecialista.Size = new System.Drawing.Size(200, 20);
            this.txtApellidoEspecialista.TabIndex = 5;
            // 
            // txtCmpEspecialista
            // 
            this.txtCmpEspecialista.Location = new System.Drawing.Point(186, 68);
            this.txtCmpEspecialista.Name = "txtCmpEspecialista";
            this.txtCmpEspecialista.Size = new System.Drawing.Size(200, 20);
            this.txtCmpEspecialista.TabIndex = 6;
            // 
            // txtNombreEspecialista
            // 
            this.txtNombreEspecialista.Location = new System.Drawing.Point(186, 106);
            this.txtNombreEspecialista.Name = "txtNombreEspecialista";
            this.txtNombreEspecialista.Size = new System.Drawing.Size(200, 20);
            this.txtNombreEspecialista.TabIndex = 7;
            // 
            // dgvEspecialista
            // 
            this.dgvEspecialista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialista.Location = new System.Drawing.Point(404, 56);
            this.dgvEspecialista.Name = "dgvEspecialista";
            this.dgvEspecialista.Size = new System.Drawing.Size(384, 382);
            this.dgvEspecialista.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "INSERTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "MODIFICAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(100, 388);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "BUSCAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(186, 182);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(200, 20);
            this.txtEspecialidad.TabIndex = 14;
            // 
            // FrmModuloEspecialista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvEspecialista);
            this.Controls.Add(this.txtNombreEspecialista);
            this.Controls.Add(this.txtCmpEspecialista);
            this.Controls.Add(this.txtApellidoEspecialista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmModuloEspecialista";
            this.Text = "A";
            this.Load += new System.EventHandler(this.FrmModuloEspecialista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidoEspecialista;
        private System.Windows.Forms.TextBox txtCmpEspecialista;
        private System.Windows.Forms.TextBox txtNombreEspecialista;
        private System.Windows.Forms.DataGridView dgvEspecialista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtEspecialidad;
    }
}
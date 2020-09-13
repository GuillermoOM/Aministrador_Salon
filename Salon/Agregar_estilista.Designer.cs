namespace Salon
{
    partial class Agregar_estilista
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
            this.cancelar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Apellido_2 = new System.Windows.Forms.TextBox();
            this.Apellido_1 = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelar.Location = new System.Drawing.Point(357, 214);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 0;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // Agregar
            // 
            this.Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Agregar.Location = new System.Drawing.Point(357, 185);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 1;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Segundo Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Primer Apellido";
            // 
            // Apellido_2
            // 
            this.Apellido_2.Location = new System.Drawing.Point(15, 103);
            this.Apellido_2.Name = "Apellido_2";
            this.Apellido_2.Size = new System.Drawing.Size(214, 20);
            this.Apellido_2.TabIndex = 33;
            // 
            // Apellido_1
            // 
            this.Apellido_1.Location = new System.Drawing.Point(15, 64);
            this.Apellido_1.Name = "Apellido_1";
            this.Apellido_1.Size = new System.Drawing.Size(214, 20);
            this.Apellido_1.TabIndex = 32;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(15, 25);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(214, 20);
            this.Nombre.TabIndex = 31;
            // 
            // Nueva_estilista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 249);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Apellido_2);
            this.Controls.Add(this.Apellido_1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.cancelar);
            this.Name = "Nueva_estilista";
            this.Text = "Nueva_estilista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Apellido_2;
        private System.Windows.Forms.TextBox Apellido_1;
        private System.Windows.Forms.TextBox Nombre;
    }
}
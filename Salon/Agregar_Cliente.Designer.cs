namespace Salon
{
    partial class Agregar_Cliente
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
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.TelefonoBox = new System.Windows.Forms.TextBox();
            this.BAgregar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.Apellido1Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Apellido2Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefono:";
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(80, 12);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(240, 20);
            this.NombreBox.TabIndex = 1;
            // 
            // TelefonoBox
            // 
            this.TelefonoBox.Location = new System.Drawing.Point(80, 90);
            this.TelefonoBox.Name = "TelefonoBox";
            this.TelefonoBox.Size = new System.Drawing.Size(240, 20);
            this.TelefonoBox.TabIndex = 4;
            // 
            // BAgregar
            // 
            this.BAgregar.Location = new System.Drawing.Point(164, 116);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(75, 23);
            this.BAgregar.TabIndex = 5;
            this.BAgregar.Text = "OK";
            this.BAgregar.UseVisualStyleBackColor = true;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancelar.Location = new System.Drawing.Point(245, 116);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 6;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            // 
            // Apellido1Box
            // 
            this.Apellido1Box.Location = new System.Drawing.Point(80, 38);
            this.Apellido1Box.Name = "Apellido1Box";
            this.Apellido1Box.Size = new System.Drawing.Size(240, 20);
            this.Apellido1Box.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "1er Apellido:";
            // 
            // Apellido2Box
            // 
            this.Apellido2Box.Location = new System.Drawing.Point(80, 64);
            this.Apellido2Box.Name = "Apellido2Box";
            this.Apellido2Box.Size = new System.Drawing.Size(240, 20);
            this.Apellido2Box.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "2do Apellido:";
            // 
            // Agregar_Cliente
            // 
            this.AcceptButton = this.BAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BCancelar;
            this.ClientSize = new System.Drawing.Size(326, 148);
            this.Controls.Add(this.Apellido2Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Apellido1Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BAgregar);
            this.Controls.Add(this.TelefonoBox);
            this.Controls.Add(this.NombreBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agregar_Cliente";
            this.ShowInTaskbar = false;
            this.Text = "Agregar_Cliente";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.TextBox TelefonoBox;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.TextBox Apellido1Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Apellido2Box;
        private System.Windows.Forms.Label label4;
    }
}
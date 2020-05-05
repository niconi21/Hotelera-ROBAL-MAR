namespace View.Components
{
    partial class Habitacion_component
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_habitacion = new System.Windows.Forms.Label();
            this.label_estatus = new System.Windows.Forms.Label();
            this.label_tipo = new System.Windows.Forms.Label();
            this.label_precio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_habitacion
            // 
            this.label_habitacion.AutoSize = true;
            this.label_habitacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label_habitacion.ForeColor = System.Drawing.Color.White;
            this.label_habitacion.Location = new System.Drawing.Point(3, 13);
            this.label_habitacion.Name = "label_habitacion";
            this.label_habitacion.Size = new System.Drawing.Size(85, 16);
            this.label_habitacion.TabIndex = 7;
            this.label_habitacion.Text = "Habitación:";
            // 
            // label_estatus
            // 
            this.label_estatus.AutoSize = true;
            this.label_estatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label_estatus.ForeColor = System.Drawing.Color.White;
            this.label_estatus.Location = new System.Drawing.Point(3, 88);
            this.label_estatus.Name = "label_estatus";
            this.label_estatus.Size = new System.Drawing.Size(63, 16);
            this.label_estatus.TabIndex = 8;
            this.label_estatus.Text = "Estatus:";
            // 
            // label_tipo
            // 
            this.label_tipo.AutoSize = true;
            this.label_tipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label_tipo.ForeColor = System.Drawing.Color.White;
            this.label_tipo.Location = new System.Drawing.Point(3, 113);
            this.label_tipo.Name = "label_tipo";
            this.label_tipo.Size = new System.Drawing.Size(42, 16);
            this.label_tipo.TabIndex = 9;
            this.label_tipo.Text = "Tipo:";
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label_precio.ForeColor = System.Drawing.Color.White;
            this.label_precio.Location = new System.Drawing.Point(3, 141);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(55, 16);
            this.label_precio.TabIndex = 10;
            this.label_precio.Text = "Precio:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.cama___verde;
            this.pictureBox1.Location = new System.Drawing.Point(40, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Habitacion_component
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.label_tipo);
            this.Controls.Add(this.label_estatus);
            this.Controls.Add(this.label_habitacion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Habitacion_component";
            this.Size = new System.Drawing.Size(137, 169);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_habitacion;
        private System.Windows.Forms.Label label_estatus;
        private System.Windows.Forms.Label label_tipo;
        private System.Windows.Forms.Label label_precio;
    }
}

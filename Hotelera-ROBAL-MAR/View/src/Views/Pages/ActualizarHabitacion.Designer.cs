namespace View
{
    partial class ActualizarHabitacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pb_minimizar = new System.Windows.Forms.PictureBox();
            this.pb_cerrar = new System.Windows.Forms.PictureBox();
            this.label_precio = new System.Windows.Forms.Label();
            this.label_tipo = new System.Windows.Forms.Label();
            this.label_habitacion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_estatus = new System.Windows.Forms.Label();
            this.cb_estatus = new System.Windows.Forms.ComboBox();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.btn_registrarEmpleado = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pb_minimizar);
            this.panel1.Controls.Add(this.pb_cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 26);
            this.panel1.TabIndex = 51;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(42, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Actualizar habitación";
            this.label9.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pb_minimizar
            // 
            this.pb_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_minimizar.Image = global::View.Properties.Resources.minimizar;
            this.pb_minimizar.Location = new System.Drawing.Point(226, 0);
            this.pb_minimizar.Name = "pb_minimizar";
            this.pb_minimizar.Size = new System.Drawing.Size(25, 26);
            this.pb_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_minimizar.TabIndex = 3;
            this.pb_minimizar.TabStop = false;
            this.pb_minimizar.Click += new System.EventHandler(this.pb_minimizar_Click);
            // 
            // pb_cerrar
            // 
            this.pb_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_cerrar.Image = global::View.Properties.Resources.cerrar;
            this.pb_cerrar.Location = new System.Drawing.Point(251, 0);
            this.pb_cerrar.Name = "pb_cerrar";
            this.pb_cerrar.Size = new System.Drawing.Size(25, 26);
            this.pb_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_cerrar.TabIndex = 2;
            this.pb_cerrar.TabStop = false;
            this.pb_cerrar.Click += new System.EventHandler(this.pb_cerrar_Click);
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label_precio.ForeColor = System.Drawing.Color.White;
            this.label_precio.Location = new System.Drawing.Point(26, 213);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(67, 16);
            this.label_precio.TabIndex = 34;
            this.label_precio.Text = "Precio: $";
            // 
            // label_tipo
            // 
            this.label_tipo.AutoSize = true;
            this.label_tipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label_tipo.ForeColor = System.Drawing.Color.White;
            this.label_tipo.Location = new System.Drawing.Point(47, 186);
            this.label_tipo.Name = "label_tipo";
            this.label_tipo.Size = new System.Drawing.Size(42, 16);
            this.label_tipo.TabIndex = 33;
            this.label_tipo.Text = "Tipo:";
            // 
            // label_habitacion
            // 
            this.label_habitacion.AutoSize = true;
            this.label_habitacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label_habitacion.ForeColor = System.Drawing.Color.White;
            this.label_habitacion.Location = new System.Drawing.Point(56, 33);
            this.label_habitacion.Name = "label_habitacion";
            this.label_habitacion.Size = new System.Drawing.Size(85, 16);
            this.label_habitacion.TabIndex = 32;
            this.label_habitacion.Text = "Habitación:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.cama___verde;
            this.pictureBox1.Location = new System.Drawing.Point(107, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label_estatus
            // 
            this.label_estatus.AutoSize = true;
            this.label_estatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label_estatus.ForeColor = System.Drawing.Color.White;
            this.label_estatus.Location = new System.Drawing.Point(26, 155);
            this.label_estatus.Name = "label_estatus";
            this.label_estatus.Size = new System.Drawing.Size(63, 16);
            this.label_estatus.TabIndex = 52;
            this.label_estatus.Text = "Estatus:";
            // 
            // cb_estatus
            // 
            this.cb_estatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(101)))));
            this.cb_estatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_estatus.ForeColor = System.Drawing.SystemColors.Control;
            this.cb_estatus.FormattingEnabled = true;
            this.cb_estatus.Location = new System.Drawing.Point(95, 149);
            this.cb_estatus.Name = "cb_estatus";
            this.cb_estatus.Size = new System.Drawing.Size(125, 21);
            this.cb_estatus.TabIndex = 72;
            // 
            // cb_tipo
            // 
            this.cb_tipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(101)))));
            this.cb_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_tipo.ForeColor = System.Drawing.SystemColors.Control;
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Location = new System.Drawing.Point(95, 186);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(125, 21);
            this.cb_tipo.TabIndex = 73;
            // 
            // txt_precio
            // 
            this.txt_precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(101)))));
            this.txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_precio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.txt_precio.ForeColor = System.Drawing.Color.White;
            this.txt_precio.Location = new System.Drawing.Point(95, 213);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(125, 24);
            this.txt_precio.TabIndex = 74;
            // 
            // btn_registrarEmpleado
            // 
            this.btn_registrarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(162)))), ((int)(((byte)(43)))));
            this.btn_registrarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.btn_registrarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_registrarEmpleado.Location = new System.Drawing.Point(59, 252);
            this.btn_registrarEmpleado.Name = "btn_registrarEmpleado";
            this.btn_registrarEmpleado.Size = new System.Drawing.Size(143, 28);
            this.btn_registrarEmpleado.TabIndex = 75;
            this.btn_registrarEmpleado.Text = "Actualizar habitación";
            this.btn_registrarEmpleado.UseVisualStyleBackColor = false;
            this.btn_registrarEmpleado.Click += new System.EventHandler(this.btn_registrarEmpleado_Click);
            // 
            // ActualizarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(276, 292);
            this.Controls.Add(this.btn_registrarEmpleado);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.cb_estatus);
            this.Controls.Add(this.label_estatus);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.label_tipo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_habitacion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActualizarHabitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarHabitacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pb_minimizar;
        private System.Windows.Forms.PictureBox pb_cerrar;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.Label label_tipo;
        private System.Windows.Forms.Label label_habitacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_estatus;
        private System.Windows.Forms.ComboBox cb_estatus;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Button btn_registrarEmpleado;
    }
}
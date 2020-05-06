namespace View.src.Views.Pages
{
    partial class ClienteFecha
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_finalizarCliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cerrar)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(312, 26);
            this.panel1.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(95, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Fecha del cliente";
            // 
            // pb_minimizar
            // 
            this.pb_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_minimizar.Image = global::View.Properties.Resources.minimizar;
            this.pb_minimizar.Location = new System.Drawing.Point(262, 0);
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
            this.pb_cerrar.Location = new System.Drawing.Point(287, 0);
            this.pb_cerrar.Name = "pb_cerrar";
            this.pb_cerrar.Size = new System.Drawing.Size(25, 26);
            this.pb_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_cerrar.TabIndex = 2;
            this.pb_cerrar.TabStop = false;
            this.pb_cerrar.Click += new System.EventHandler(this.pb_cerrar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 20);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 53;
            this.label1.Text = "Selecciona la fecha en la cual\r\n el cliente se retira";
            // 
            // btn_finalizarCliente
            // 
            this.btn_finalizarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(61)))), ((int)(((byte)(15)))));
            this.btn_finalizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizarCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btn_finalizarCliente.ForeColor = System.Drawing.Color.White;
            this.btn_finalizarCliente.Location = new System.Drawing.Point(91, 176);
            this.btn_finalizarCliente.Name = "btn_finalizarCliente";
            this.btn_finalizarCliente.Size = new System.Drawing.Size(126, 41);
            this.btn_finalizarCliente.TabIndex = 78;
            this.btn_finalizarCliente.Text = "Finalizar hospedaje";
            this.btn_finalizarCliente.UseCompatibleTextRendering = true;
            this.btn_finalizarCliente.UseVisualStyleBackColor = false;
            this.btn_finalizarCliente.Click += new System.EventHandler(this.btn_finalizarCliente_Click);
            // 
            // ClienteFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(312, 277);
            this.Controls.Add(this.btn_finalizarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClienteFecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteFecha";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pb_minimizar;
        private System.Windows.Forms.PictureBox pb_cerrar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_finalizarCliente;
    }
}
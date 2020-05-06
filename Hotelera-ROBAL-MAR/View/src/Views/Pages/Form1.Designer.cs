namespace View
{
    partial class Login
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
            this.pb_minimizar = new System.Windows.Forms.PictureBox();
            this.pb_cerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.label_error = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.pb_minimizar);
            this.panel1.Controls.Add(this.pb_cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(254, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 33);
            this.panel1.TabIndex = 1;
            // 
            // pb_minimizar
            // 
            this.pb_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_minimizar.Image = global::View.Properties.Resources.minimizar;
            this.pb_minimizar.Location = new System.Drawing.Point(447, 5);
            this.pb_minimizar.Name = "pb_minimizar";
            this.pb_minimizar.Size = new System.Drawing.Size(25, 25);
            this.pb_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_minimizar.TabIndex = 3;
            this.pb_minimizar.TabStop = false;
            this.pb_minimizar.Click += new System.EventHandler(this.pb_minimizar_Click);
            // 
            // pb_cerrar
            // 
            this.pb_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_cerrar.Image = global::View.Properties.Resources.cerrar;
            this.pb_cerrar.Location = new System.Drawing.Point(478, 5);
            this.pb_cerrar.Name = "pb_cerrar";
            this.pb_cerrar.Size = new System.Drawing.Size(25, 25);
            this.pb_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_cerrar.TabIndex = 2;
            this.pb_cerrar.TabStop = false;
            this.pb_cerrar.Click += new System.EventHandler(this.pb_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(467, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(330, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(101)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.txt_usuario.ForeColor = System.Drawing.Color.White;
            this.txt_usuario.Location = new System.Drawing.Point(428, 137);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(239, 24);
            this.txt_usuario.TabIndex = 5;
            // 
            // txt_clave
            // 
            this.txt_clave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(74)))), ((int)(((byte)(101)))));
            this.txt_clave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_clave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.txt_clave.ForeColor = System.Drawing.Color.White;
            this.txt_clave.Location = new System.Drawing.Point(428, 183);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '*';
            this.txt_clave.Size = new System.Drawing.Size(239, 24);
            this.txt_clave.TabIndex = 8;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label_error.ForeColor = System.Drawing.Color.DarkRed;
            this.label_error.Location = new System.Drawing.Point(332, 238);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(37, 12);
            this.label_error.TabIndex = 6;
            this.label_error.Text = "Error:";
            this.label_error.Visible = false;
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(73)))), ((int)(((byte)(97)))));
            this.btn_entrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(111)))));
            this.btn_entrar.FlatAppearance.BorderSize = 3;
            this.btn_entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(86)))), ((int)(((byte)(117)))));
            this.btn_entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(92)))), ((int)(((byte)(111)))));
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.btn_entrar.ForeColor = System.Drawing.Color.White;
            this.btn_entrar.Location = new System.Drawing.Point(393, 272);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(218, 38);
            this.btn_entrar.TabIndex = 9;
            this.btn_entrar.Text = "¡Entrar!";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::View.Properties.Resources.bloquear;
            this.pictureBox5.Location = new System.Drawing.Point(294, 176);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::View.Properties.Resources.usuario;
            this.pictureBox4.Location = new System.Drawing.Point(294, 130);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::View.Properties.Resources.hotel;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(345, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Clave:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(760, 352);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_minimizar;
        private System.Windows.Forms.PictureBox pb_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Label label4;
    }
}


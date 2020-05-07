namespace View
{
    partial class Grafica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.grafica_ganancias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pb_minimizar = new System.Windows.Forms.PictureBox();
            this.pb_cerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grafica_ganancias)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // grafica_ganancias
            // 
            chartArea1.Name = "ChartArea1";
            this.grafica_ganancias.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafica_ganancias.Legends.Add(legend1);
            this.grafica_ganancias.Location = new System.Drawing.Point(24, 65);
            this.grafica_ganancias.Name = "grafica_ganancias";
            this.grafica_ganancias.Size = new System.Drawing.Size(703, 366);
            this.grafica_ganancias.TabIndex = 0;
            this.grafica_ganancias.Text = "chart1";
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
            this.panel1.Size = new System.Drawing.Size(748, 26);
            this.panel1.TabIndex = 50;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(299, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Gráfica de ganancias";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pb_minimizar
            // 
            this.pb_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pb_minimizar.Image = global::View.Properties.Resources.minimizar;
            this.pb_minimizar.Location = new System.Drawing.Point(698, 0);
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
            this.pb_cerrar.Location = new System.Drawing.Point(723, 0);
            this.pb_cerrar.Name = "pb_cerrar";
            this.pb_cerrar.Size = new System.Drawing.Size(25, 26);
            this.pb_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_cerrar.TabIndex = 2;
            this.pb_cerrar.TabStop = false;
            this.pb_cerrar.Click += new System.EventHandler(this.pb_cerrar_Click);
            // 
            // Grafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(748, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grafica_ganancias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grafica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Grafica_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grafica_ganancias)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafica_ganancias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_minimizar;
        private System.Windows.Forms.PictureBox pb_cerrar;
        private System.Windows.Forms.Label label9;
    }
}
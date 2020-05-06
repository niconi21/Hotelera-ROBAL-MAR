namespace View.Options
{
    partial class Personal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_registrarEmpleado = new System.Windows.Forms.Button();
            this.tablaPersonal = new System.Windows.Forms.DataGridView();
            this.btn_modificarEmpleado = new System.Windows.Forms.Button();
            this.tipoPersonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apepatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apematDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuaioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Personal";
            // 
            // btn_registrarEmpleado
            // 
            this.btn_registrarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(162)))), ((int)(((byte)(43)))));
            this.btn_registrarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btn_registrarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_registrarEmpleado.Location = new System.Drawing.Point(63, 53);
            this.btn_registrarEmpleado.Name = "btn_registrarEmpleado";
            this.btn_registrarEmpleado.Size = new System.Drawing.Size(239, 28);
            this.btn_registrarEmpleado.TabIndex = 7;
            this.btn_registrarEmpleado.Text = "Agregar a un nuevo empleado";
            this.btn_registrarEmpleado.UseVisualStyleBackColor = false;
            this.btn_registrarEmpleado.Click += new System.EventHandler(this.btn_registrarEmpleado_Click);
            // 
            // tablaPersonal
            // 
            this.tablaPersonal.AutoGenerateColumns = false;
            this.tablaPersonal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.tablaPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaPersonal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(92)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaPersonal.ColumnHeadersHeight = 30;
            this.tablaPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoPersonalDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apepatDataGridViewTextBoxColumn,
            this.apematDataGridViewTextBoxColumn,
            this.usuaioDataGridViewTextBoxColumn,
            this.curpDataGridViewTextBoxColumn});
            this.tablaPersonal.DataSource = this.personalBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaPersonal.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaPersonal.EnableHeadersVisualStyles = false;
            this.tablaPersonal.GridColor = System.Drawing.Color.SteelBlue;
            this.tablaPersonal.Location = new System.Drawing.Point(63, 121);
            this.tablaPersonal.Name = "tablaPersonal";
            this.tablaPersonal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaPersonal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaPersonal.RowHeadersVisible = false;
            this.tablaPersonal.Size = new System.Drawing.Size(604, 412);
            this.tablaPersonal.TabIndex = 10;
            this.tablaPersonal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPersonal_CellClick);
            // 
            // btn_modificarEmpleado
            // 
            this.btn_modificarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(161)))), ((int)(((byte)(215)))));
            this.btn_modificarEmpleado.Enabled = false;
            this.btn_modificarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.btn_modificarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_modificarEmpleado.Location = new System.Drawing.Point(390, 53);
            this.btn_modificarEmpleado.Name = "btn_modificarEmpleado";
            this.btn_modificarEmpleado.Size = new System.Drawing.Size(239, 28);
            this.btn_modificarEmpleado.TabIndex = 11;
            this.btn_modificarEmpleado.Text = "Modificar a un empleado";
            this.btn_modificarEmpleado.UseVisualStyleBackColor = false;
            this.btn_modificarEmpleado.Click += new System.EventHandler(this.btn_modificarEmpleado_Click);
            // 
            // tipoPersonalDataGridViewTextBoxColumn
            // 
            this.tipoPersonalDataGridViewTextBoxColumn.DataPropertyName = "TipoPersonal";
            this.tipoPersonalDataGridViewTextBoxColumn.HeaderText = "TipoPersonal";
            this.tipoPersonalDataGridViewTextBoxColumn.Name = "tipoPersonalDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apepatDataGridViewTextBoxColumn
            // 
            this.apepatDataGridViewTextBoxColumn.DataPropertyName = "Apepat";
            this.apepatDataGridViewTextBoxColumn.HeaderText = "Apepat";
            this.apepatDataGridViewTextBoxColumn.Name = "apepatDataGridViewTextBoxColumn";
            // 
            // apematDataGridViewTextBoxColumn
            // 
            this.apematDataGridViewTextBoxColumn.DataPropertyName = "Apemat";
            this.apematDataGridViewTextBoxColumn.HeaderText = "Apemat";
            this.apematDataGridViewTextBoxColumn.Name = "apematDataGridViewTextBoxColumn";
            // 
            // usuaioDataGridViewTextBoxColumn
            // 
            this.usuaioDataGridViewTextBoxColumn.DataPropertyName = "Usuaio";
            this.usuaioDataGridViewTextBoxColumn.HeaderText = "Usuaio";
            this.usuaioDataGridViewTextBoxColumn.Name = "usuaioDataGridViewTextBoxColumn";
            // 
            // curpDataGridViewTextBoxColumn
            // 
            this.curpDataGridViewTextBoxColumn.DataPropertyName = "Curp";
            this.curpDataGridViewTextBoxColumn.HeaderText = "Curp";
            this.curpDataGridViewTextBoxColumn.Name = "curpDataGridViewTextBoxColumn";
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataSource = typeof(View.src.Tools.Objects.Personal);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(89)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.btn_modificarEmpleado);
            this.Controls.Add(this.tablaPersonal);
            this.Controls.Add(this.btn_registrarEmpleado);
            this.Controls.Add(this.label2);
            this.Name = "Personal";
            this.Size = new System.Drawing.Size(720, 533);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_registrarEmpleado;
        private System.Windows.Forms.DataGridView tablaPersonal;
        
        private System.Windows.Forms.Button btn_modificarEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPersonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apepatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apematDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuaioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curpDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personalBindingSource;
    }
}

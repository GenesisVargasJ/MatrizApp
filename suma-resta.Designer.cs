﻿namespace matriz
{
    partial class frm_sumayresta
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	this.dgv_matriz1 = new System.Windows.Forms.DataGridView();
        	this.dgv_matriz2 = new System.Windows.Forms.DataGridView();
        	this.dgv_suma = new System.Windows.Forms.DataGridView();
        	this.btn_calcular = new System.Windows.Forms.Button();
        	this.dgv_resta = new System.Windows.Forms.DataGridView();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label6 = new System.Windows.Forms.Label();
        	this.cmbx_filas = new System.Windows.Forms.ComboBox();
        	this.cmbx_columnas = new System.Windows.Forms.ComboBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.error = new System.Windows.Forms.ErrorProvider(this.components);
        	((System.ComponentModel.ISupportInitialize)(this.dgv_matriz1)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.dgv_matriz2)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.dgv_suma)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.dgv_resta)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// dgv_matriz1
        	// 
        	this.dgv_matriz1.AllowUserToAddRows = false;
        	this.dgv_matriz1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
        	this.dgv_matriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgv_matriz1.ColumnHeadersVisible = false;
        	this.dgv_matriz1.Location = new System.Drawing.Point(12, 75);
        	this.dgv_matriz1.Name = "dgv_matriz1";
        	this.dgv_matriz1.RowHeadersVisible = false;
        	this.dgv_matriz1.Size = new System.Drawing.Size(240, 150);
        	this.dgv_matriz1.TabIndex = 0;
        	this.dgv_matriz1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgv_matriz1EditingControlShowing);
        	this.dgv_matriz1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dgv_matriz1KeyPress);
        	// 
        	// dgv_matriz2
        	// 
        	this.dgv_matriz2.AllowUserToAddRows = false;
        	this.dgv_matriz2.BackgroundColor = System.Drawing.Color.LightSteelBlue;
        	this.dgv_matriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgv_matriz2.ColumnHeadersVisible = false;
        	this.dgv_matriz2.Location = new System.Drawing.Point(258, 75);
        	this.dgv_matriz2.Name = "dgv_matriz2";
        	this.dgv_matriz2.RowHeadersVisible = false;
        	this.dgv_matriz2.Size = new System.Drawing.Size(240, 150);
        	this.dgv_matriz2.TabIndex = 1;
        	this.dgv_matriz2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgv_matriz2EditingControlShowing);
        	this.dgv_matriz2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dgv_matriz2KeyPress);
        	// 
        	// dgv_suma
        	// 
        	this.dgv_suma.AllowUserToAddRows = false;
        	this.dgv_suma.BackgroundColor = System.Drawing.Color.LightSteelBlue;
        	this.dgv_suma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgv_suma.ColumnHeadersVisible = false;
        	this.dgv_suma.Enabled = false;
        	this.dgv_suma.Location = new System.Drawing.Point(12, 256);
        	this.dgv_suma.Name = "dgv_suma";
        	this.dgv_suma.RowHeadersVisible = false;
        	this.dgv_suma.Size = new System.Drawing.Size(240, 150);
        	this.dgv_suma.TabIndex = 3;
        	// 
        	// btn_calcular
        	// 
        	this.btn_calcular.Location = new System.Drawing.Point(334, 14);
        	this.btn_calcular.Name = "btn_calcular";
        	this.btn_calcular.Size = new System.Drawing.Size(75, 23);
        	this.btn_calcular.TabIndex = 4;
        	this.btn_calcular.Text = "Calcular";
        	this.btn_calcular.UseVisualStyleBackColor = true;
        	this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
        	// 
        	// dgv_resta
        	// 
        	this.dgv_resta.AllowUserToAddRows = false;
        	this.dgv_resta.BackgroundColor = System.Drawing.Color.LightSteelBlue;
        	this.dgv_resta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgv_resta.ColumnHeadersVisible = false;
        	this.dgv_resta.Enabled = false;
        	this.dgv_resta.Location = new System.Drawing.Point(258, 256);
        	this.dgv_resta.Name = "dgv_resta";
        	this.dgv_resta.RowHeadersVisible = false;
        	this.dgv_resta.Size = new System.Drawing.Size(240, 150);
        	this.dgv_resta.TabIndex = 6;
        	// 
        	// label1
        	// 
        	this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.Color.SteelBlue;
        	this.label1.Location = new System.Drawing.Point(92, 230);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(67, 23);
        	this.label1.TabIndex = 7;
        	this.label1.Text = "SUMA";
        	// 
        	// label2
        	// 
        	this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.ForeColor = System.Drawing.Color.SteelBlue;
        	this.label2.Location = new System.Drawing.Point(336, 230);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(73, 23);
        	this.label2.TabIndex = 8;
        	this.label2.Text = "RESTA";
        	// 
        	// label3
        	// 
        	this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.ForeColor = System.Drawing.Color.SteelBlue;
        	this.label3.Location = new System.Drawing.Point(319, 48);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(112, 23);
        	this.label3.TabIndex = 10;
        	this.label3.Text = "MATRIZ 2";
        	// 
        	// label4
        	// 
        	this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.ForeColor = System.Drawing.Color.SteelBlue;
        	this.label4.Location = new System.Drawing.Point(82, 48);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(111, 23);
        	this.label4.TabIndex = 9;
        	this.label4.Text = "MATRIZ 1";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(56, 21);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(132, 13);
        	this.label5.TabIndex = 11;
        	this.label5.Text = "Dimensión de las matrices:";
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(241, 21);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(14, 13);
        	this.label6.TabIndex = 12;
        	this.label6.Text = "X";
        	// 
        	// cmbx_filas
        	// 
        	this.cmbx_filas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cmbx_filas.FormattingEnabled = true;
        	this.cmbx_filas.Items.AddRange(new object[] {
        	        	        	"1",
        	        	        	"2",
        	        	        	"3",
        	        	        	"4",
        	        	        	"5",
        	        	        	"6",
        	        	        	"7",
        	        	        	"8",
        	        	        	"9",
        	        	        	"10"});
        	this.cmbx_filas.Location = new System.Drawing.Point(194, 16);
        	this.cmbx_filas.Name = "cmbx_filas";
        	this.cmbx_filas.Size = new System.Drawing.Size(41, 21);
        	this.cmbx_filas.TabIndex = 13;
        	this.cmbx_filas.SelectedIndexChanged += new System.EventHandler(this.Cmbx_filasSelectedIndexChanged);
        	this.cmbx_filas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmbx_filasKeyPress);
        	// 
        	// cmbx_columnas
        	// 
        	this.cmbx_columnas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cmbx_columnas.FormattingEnabled = true;
        	this.cmbx_columnas.Items.AddRange(new object[] {
        	        	        	"1",
        	        	        	"2",
        	        	        	"3",
        	        	        	"4",
        	        	        	"5",
        	        	        	"6",
        	        	        	"7",
        	        	        	"8",
        	        	        	"9",
        	        	        	"10"});
        	this.cmbx_columnas.Location = new System.Drawing.Point(261, 16);
        	this.cmbx_columnas.Name = "cmbx_columnas";
        	this.cmbx_columnas.Size = new System.Drawing.Size(41, 21);
        	this.cmbx_columnas.TabIndex = 14;
        	this.cmbx_columnas.SelectedIndexChanged += new System.EventHandler(this.Cmbx_columnasSelectedIndexChanged);
        	this.cmbx_columnas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmbx_columnasKeyPress);
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label7.ForeColor = System.Drawing.Color.DarkRed;
        	this.label7.Location = new System.Drawing.Point(225, 416);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(281, 13);
        	this.label7.TabIndex = 15;
        	this.label7.Text = "ATENCIÓN: Estás en Suma y Resta De Matrices";
        	// 
        	// error
        	// 
        	this.error.ContainerControl = this;
        	// 
        	// frm_sumayresta
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(510, 433);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.cmbx_columnas);
        	this.Controls.Add(this.cmbx_filas);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.dgv_resta);
        	this.Controls.Add(this.btn_calcular);
        	this.Controls.Add(this.dgv_suma);
        	this.Controls.Add(this.dgv_matriz2);
        	this.Controls.Add(this.dgv_matriz1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.MaximizeBox = false;
        	this.Name = "frm_sumayresta";
        	this.Text = "Suma y Resta de Matrices";
        	((System.ComponentModel.ISupportInitialize)(this.dgv_matriz1)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.dgv_matriz2)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.dgv_suma)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.dgv_resta)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbx_columnas;
        private System.Windows.Forms.ComboBox cmbx_filas;
        private System.Windows.Forms.Label label6;

        #endregion

        private System.Windows.Forms.DataGridView dgv_matriz1;
        private System.Windows.Forms.DataGridView dgv_matriz2;
        private System.Windows.Forms.DataGridView dgv_suma;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.DataGridView dgv_resta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}


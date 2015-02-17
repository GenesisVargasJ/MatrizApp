/*
 * Created by SharpDevelop.
 * User: genesis
 * Date: 15/06/2013
 * Time: 12:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace matriz
{
	partial class frm_multiplicacion
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.cmbx_columnas = new System.Windows.Forms.ComboBox();
			this.cmbx_filas = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_calcular = new System.Windows.Forms.Button();
			this.dgv_matriz2 = new System.Windows.Forms.DataGridView();
			this.dgv_matriz1 = new System.Windows.Forms.DataGridView();
			this.cmbx_columnas2 = new System.Windows.Forms.ComboBox();
			this.cmbx_filas2 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgv_resultado = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgv_matriz2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_matriz1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
			this.SuspendLayout();
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
			this.cmbx_columnas.Location = new System.Drawing.Point(143, 32);
			this.cmbx_columnas.Name = "cmbx_columnas";
			this.cmbx_columnas.Size = new System.Drawing.Size(41, 21);
			this.cmbx_columnas.TabIndex = 23;
			this.cmbx_columnas.SelectedIndexChanged += new System.EventHandler(this.Cmbx_columnasSelectedIndexChanged);
			this.cmbx_columnas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmbx_columnasKeyPress);
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
			this.cmbx_filas.Location = new System.Drawing.Point(76, 32);
			this.cmbx_filas.Name = "cmbx_filas";
			this.cmbx_filas.Size = new System.Drawing.Size(41, 21);
			this.cmbx_filas.TabIndex = 22;
			this.cmbx_filas.SelectedIndexChanged += new System.EventHandler(this.Cmbx_filasSelectedIndexChanged);
			this.cmbx_filas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmbx_filasKeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(123, 37);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(14, 13);
			this.label6.TabIndex = 21;
			this.label6.Text = "X";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(69, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(124, 13);
			this.label5.TabIndex = 20;
			this.label5.Text = "Dimensión de la matriz 1:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.SteelBlue;
			this.label3.Location = new System.Drawing.Point(319, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 23);
			this.label3.TabIndex = 19;
			this.label3.Text = "MATRIZ 2";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.SteelBlue;
			this.label4.Location = new System.Drawing.Point(82, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 23);
			this.label4.TabIndex = 18;
			this.label4.Text = "MATRIZ 1";
			// 
			// btn_calcular
			// 
			this.btn_calcular.Location = new System.Drawing.Point(216, 31);
			this.btn_calcular.Name = "btn_calcular";
			this.btn_calcular.Size = new System.Drawing.Size(75, 23);
			this.btn_calcular.TabIndex = 17;
			this.btn_calcular.Text = "Calcular";
			this.btn_calcular.UseVisualStyleBackColor = true;
			this.btn_calcular.Click += new System.EventHandler(this.Btn_calcularClick);
			// 
			// dgv_matriz2
			// 
			this.dgv_matriz2.AllowUserToAddRows = false;
			this.dgv_matriz2.BackgroundColor = System.Drawing.Color.LightSteelBlue;
			this.dgv_matriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_matriz2.ColumnHeadersVisible = false;
			this.dgv_matriz2.Location = new System.Drawing.Point(258, 89);
			this.dgv_matriz2.Name = "dgv_matriz2";
			this.dgv_matriz2.RowHeadersVisible = false;
			this.dgv_matriz2.Size = new System.Drawing.Size(240, 150);
			this.dgv_matriz2.TabIndex = 16;
			this.dgv_matriz2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgv_matriz2EditingControlShowing);
			this.dgv_matriz2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dgv_matriz2KeyPress);
			// 
			// dgv_matriz1
			// 
			this.dgv_matriz1.AllowUserToAddRows = false;
			this.dgv_matriz1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
			this.dgv_matriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_matriz1.ColumnHeadersVisible = false;
			this.dgv_matriz1.Location = new System.Drawing.Point(12, 89);
			this.dgv_matriz1.Name = "dgv_matriz1";
			this.dgv_matriz1.RowHeadersVisible = false;
			this.dgv_matriz1.Size = new System.Drawing.Size(240, 150);
			this.dgv_matriz1.TabIndex = 15;
			this.dgv_matriz1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgv_matriz1EditingControlShowing);
			this.dgv_matriz1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dgv_matriz1KeyPress);
			// 
			// cmbx_columnas2
			// 
			this.cmbx_columnas2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbx_columnas2.FormattingEnabled = true;
			this.cmbx_columnas2.Items.AddRange(new object[] {
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
			this.cmbx_columnas2.Location = new System.Drawing.Point(381, 31);
			this.cmbx_columnas2.Name = "cmbx_columnas2";
			this.cmbx_columnas2.Size = new System.Drawing.Size(41, 21);
			this.cmbx_columnas2.TabIndex = 27;
			this.cmbx_columnas2.SelectedIndexChanged += new System.EventHandler(this.Cmbx_columnas2SelectedIndexChanged);
			this.cmbx_columnas2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmbx_columnas2KeyPress);
			// 
			// cmbx_filas2
			// 
			this.cmbx_filas2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbx_filas2.FormattingEnabled = true;
			this.cmbx_filas2.Items.AddRange(new object[] {
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
			this.cmbx_filas2.Location = new System.Drawing.Point(317, 31);
			this.cmbx_filas2.Name = "cmbx_filas2";
			this.cmbx_filas2.Size = new System.Drawing.Size(41, 21);
			this.cmbx_filas2.TabIndex = 26;
			this.cmbx_filas2.SelectedIndexChanged += new System.EventHandler(this.Cmbx_filas2SelectedIndexChanged);
			this.cmbx_filas2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmbx_filas2KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(361, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 13);
			this.label1.TabIndex = 25;
			this.label1.Text = "X";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(311, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 13);
			this.label2.TabIndex = 24;
			this.label2.Text = "Dimensión de la matriz 2:";
			// 
			// dgv_resultado
			// 
			this.dgv_resultado.AllowUserToAddRows = false;
			this.dgv_resultado.BackgroundColor = System.Drawing.Color.LightSteelBlue;
			this.dgv_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_resultado.ColumnHeadersVisible = false;
			this.dgv_resultado.Location = new System.Drawing.Point(148, 250);
			this.dgv_resultado.Name = "dgv_resultado";
			this.dgv_resultado.RowHeadersVisible = false;
			this.dgv_resultado.Size = new System.Drawing.Size(240, 150);
			this.dgv_resultado.TabIndex = 28;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.SteelBlue;
			this.label7.Location = new System.Drawing.Point(12, 307);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(135, 23);
			this.label7.TabIndex = 29;
			this.label7.Text = "RESULTADO";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.DarkRed;
			this.label8.Location = new System.Drawing.Point(227, 416);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(279, 13);
			this.label8.TabIndex = 37;
			this.label8.Text = "ATENCIÓN: Estás en Multiplicación de Matrices";
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// frm_multiplicacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(510, 433);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dgv_resultado);
			this.Controls.Add(this.cmbx_columnas2);
			this.Controls.Add(this.cmbx_filas2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbx_columnas);
			this.Controls.Add(this.cmbx_filas);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btn_calcular);
			this.Controls.Add(this.dgv_matriz2);
			this.Controls.Add(this.dgv_matriz1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frm_multiplicacion";
			this.Text = "multiplicacion";
			((System.ComponentModel.ISupportInitialize)(this.dgv_matriz2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_matriz1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ErrorProvider error;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dgv_resultado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbx_filas2;
		private System.Windows.Forms.ComboBox cmbx_columnas2;
		private System.Windows.Forms.DataGridView dgv_matriz1;
		private System.Windows.Forms.DataGridView dgv_matriz2;
		private System.Windows.Forms.Button btn_calcular;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbx_filas;
		private System.Windows.Forms.ComboBox cmbx_columnas;
	}
}

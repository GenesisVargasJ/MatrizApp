/*
 * Created by SharpDevelop.
 * User: genesis
 * Date: 14/06/2013
 * Time: 0:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace matriz
{
	partial class frm_tipomatriz
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
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dgv_matriz = new System.Windows.Forms.DataGridView();
			this.btn_calcular = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lstbx_resultados = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgv_matriz)).BeginInit();
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
			this.cmbx_columnas.Location = new System.Drawing.Point(402, 104);
			this.cmbx_columnas.Name = "cmbx_columnas";
			this.cmbx_columnas.Size = new System.Drawing.Size(41, 21);
			this.cmbx_columnas.TabIndex = 31;
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
			this.cmbx_filas.Location = new System.Drawing.Point(335, 104);
			this.cmbx_filas.Name = "cmbx_filas";
			this.cmbx_filas.Size = new System.Drawing.Size(41, 21);
			this.cmbx_filas.TabIndex = 30;
			this.cmbx_filas.SelectedIndexChanged += new System.EventHandler(this.Cmbx_filasSelectedIndexChanged);
			this.cmbx_filas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmbx_filasKeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(382, 109);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(14, 13);
			this.label6.TabIndex = 29;
			this.label6.Text = "X";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(323, 77);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(132, 13);
			this.label7.TabIndex = 28;
			this.label7.Text = "Dimensión de las matrices:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.SteelBlue;
			this.label4.Location = new System.Drawing.Point(125, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 23);
			this.label4.TabIndex = 27;
			this.label4.Text = "MATRIZ";
			// 
			// dgv_matriz
			// 
			this.dgv_matriz.AllowUserToAddRows = false;
			this.dgv_matriz.BackgroundColor = System.Drawing.Color.LightSteelBlue;
			this.dgv_matriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_matriz.ColumnHeadersVisible = false;
			this.dgv_matriz.Location = new System.Drawing.Point(55, 46);
			this.dgv_matriz.Name = "dgv_matriz";
			this.dgv_matriz.RowHeadersVisible = false;
			this.dgv_matriz.Size = new System.Drawing.Size(240, 150);
			this.dgv_matriz.TabIndex = 26;
			this.dgv_matriz.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgv_matrizEditingControlShowing);
			this.dgv_matriz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dgv_matrizKeyPress);
			// 
			// btn_calcular
			// 
			this.btn_calcular.Location = new System.Drawing.Point(353, 149);
			this.btn_calcular.Name = "btn_calcular";
			this.btn_calcular.Size = new System.Drawing.Size(75, 23);
			this.btn_calcular.TabIndex = 32;
			this.btn_calcular.Text = "Calcular";
			this.btn_calcular.UseVisualStyleBackColor = true;
			this.btn_calcular.Click += new System.EventHandler(this.Btn_calcularClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SteelBlue;
			this.label1.Location = new System.Drawing.Point(125, 241);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(279, 23);
			this.label1.TabIndex = 34;
			this.label1.Text = "CUADRO DE VERIFICACION";
			// 
			// lstbx_resultados
			// 
			this.lstbx_resultados.BackColor = System.Drawing.Color.LightSteelBlue;
			this.lstbx_resultados.Enabled = false;
			this.lstbx_resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstbx_resultados.ForeColor = System.Drawing.Color.SteelBlue;
			this.lstbx_resultados.FormattingEnabled = true;
			this.lstbx_resultados.Location = new System.Drawing.Point(34, 267);
			this.lstbx_resultados.Name = "lstbx_resultados";
			this.lstbx_resultados.Size = new System.Drawing.Size(448, 121);
			this.lstbx_resultados.TabIndex = 35;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkRed;
			this.label2.Location = new System.Drawing.Point(191, 416);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(315, 13);
			this.label2.TabIndex = 36;
			this.label2.Text = "ATENCIÓN: Estás en Verificación de Tipo de Matrices";
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// frm_tipomatriz
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(510, 433);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lstbx_resultados);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_calcular);
			this.Controls.Add(this.cmbx_columnas);
			this.Controls.Add(this.cmbx_filas);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dgv_matriz);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "frm_tipomatriz";
			this.Text = "Multiplicación de Matrices";
			((System.ComponentModel.ISupportInitialize)(this.dgv_matriz)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ErrorProvider error;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lstbx_resultados;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_calcular;
		private System.Windows.Forms.DataGridView dgv_matriz;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbx_filas;
		private System.Windows.Forms.ComboBox cmbx_columnas;
	}
}

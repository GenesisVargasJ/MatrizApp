/*
 * Created by SharpDevelop.
 * User: genesis
 * Date: 16/06/2013
 * Time: 16:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace matriz
{
	partial class frm_muestra
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
			this.label1 = new System.Windows.Forms.Label();
			this.dgv_opuesta = new System.Windows.Forms.DataGridView();
			this.dgv_traspuesta = new System.Windows.Forms.DataGridView();
			this.dgv_matriz = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.btn_calcular = new System.Windows.Forms.Button();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgv_opuesta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_traspuesta)).BeginInit();
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
			this.cmbx_columnas.Location = new System.Drawing.Point(251, 14);
			this.cmbx_columnas.Name = "cmbx_columnas";
			this.cmbx_columnas.Size = new System.Drawing.Size(41, 21);
			this.cmbx_columnas.TabIndex = 24;
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
			this.cmbx_filas.Location = new System.Drawing.Point(184, 14);
			this.cmbx_filas.Name = "cmbx_filas";
			this.cmbx_filas.Size = new System.Drawing.Size(41, 21);
			this.cmbx_filas.TabIndex = 23;
			this.cmbx_filas.SelectedIndexChanged += new System.EventHandler(this.Cmbx_filasSelectedIndexChanged);
			this.cmbx_filas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmbx_filasKeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(231, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(14, 13);
			this.label6.TabIndex = 22;
			this.label6.Text = "X";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(65, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "Dimensión de la matriz:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.SteelBlue;
			this.label3.Location = new System.Drawing.Point(268, 227);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(224, 23);
			this.label3.TabIndex = 20;
			this.label3.Text = "MATRIZ TRASPUESTA";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.SteelBlue;
			this.label4.Location = new System.Drawing.Point(201, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 23);
			this.label4.TabIndex = 19;
			this.label4.Text = "MATRIZ ";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SteelBlue;
			this.label1.Location = new System.Drawing.Point(42, 228);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(189, 23);
			this.label1.TabIndex = 18;
			this.label1.Text = "MATRIZ OPUESTA";
			// 
			// dgv_opuesta
			// 
			this.dgv_opuesta.AllowUserToAddRows = false;
			this.dgv_opuesta.BackgroundColor = System.Drawing.Color.LightSteelBlue;
			this.dgv_opuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_opuesta.ColumnHeadersVisible = false;
			this.dgv_opuesta.Enabled = false;
			this.dgv_opuesta.Location = new System.Drawing.Point(12, 254);
			this.dgv_opuesta.Name = "dgv_opuesta";
			this.dgv_opuesta.RowHeadersVisible = false;
			this.dgv_opuesta.Size = new System.Drawing.Size(240, 150);
			this.dgv_opuesta.TabIndex = 17;
			// 
			// dgv_traspuesta
			// 
			this.dgv_traspuesta.AllowUserToAddRows = false;
			this.dgv_traspuesta.BackgroundColor = System.Drawing.Color.LightSteelBlue;
			this.dgv_traspuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_traspuesta.ColumnHeadersVisible = false;
			this.dgv_traspuesta.Enabled = false;
			this.dgv_traspuesta.Location = new System.Drawing.Point(258, 254);
			this.dgv_traspuesta.Name = "dgv_traspuesta";
			this.dgv_traspuesta.RowHeadersVisible = false;
			this.dgv_traspuesta.Size = new System.Drawing.Size(240, 150);
			this.dgv_traspuesta.TabIndex = 16;
			// 
			// dgv_matriz
			// 
			this.dgv_matriz.AllowUserToAddRows = false;
			this.dgv_matriz.BackgroundColor = System.Drawing.Color.LightSteelBlue;
			this.dgv_matriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_matriz.ColumnHeadersVisible = false;
			this.dgv_matriz.Location = new System.Drawing.Point(131, 70);
			this.dgv_matriz.Name = "dgv_matriz";
			this.dgv_matriz.RowHeadersVisible = false;
			this.dgv_matriz.Size = new System.Drawing.Size(240, 150);
			this.dgv_matriz.TabIndex = 15;
			this.dgv_matriz.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgv_matrizEditingControlShowing);
			this.dgv_matriz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dgv_matrizKeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.DarkRed;
			this.label7.Location = new System.Drawing.Point(260, 416);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(246, 13);
			this.label7.TabIndex = 25;
			this.label7.Text = "ATENCIÓN: Estás en Muestra de Matrices";
			// 
			// btn_calcular
			// 
			this.btn_calcular.Location = new System.Drawing.Point(325, 12);
			this.btn_calcular.Name = "btn_calcular";
			this.btn_calcular.Size = new System.Drawing.Size(75, 23);
			this.btn_calcular.TabIndex = 33;
			this.btn_calcular.Text = "Calcular";
			this.btn_calcular.UseVisualStyleBackColor = true;
			this.btn_calcular.Click += new System.EventHandler(this.Btn_calcularClick);
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// frm_muestra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(510, 433);
			this.Controls.Add(this.btn_calcular);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cmbx_columnas);
			this.Controls.Add(this.cmbx_filas);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgv_opuesta);
			this.Controls.Add(this.dgv_traspuesta);
			this.Controls.Add(this.dgv_matriz);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frm_muestra";
			this.Text = "muestra";
			((System.ComponentModel.ISupportInitialize)(this.dgv_opuesta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_traspuesta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_matriz)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ErrorProvider error;
		private System.Windows.Forms.Button btn_calcular;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dgv_matriz;
		private System.Windows.Forms.DataGridView dgv_traspuesta;
		private System.Windows.Forms.DataGridView dgv_opuesta;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbx_filas;
		private System.Windows.Forms.ComboBox cmbx_columnas;
	}
}

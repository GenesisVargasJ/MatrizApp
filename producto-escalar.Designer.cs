namespace matriz
{
    partial class frm_producto_escalar
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
        	this.components = new System.ComponentModel.Container();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.dgv_resultado = new System.Windows.Forms.DataGridView();
        	this.dgv_matriz = new System.Windows.Forms.DataGridView();
        	this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.btn_calcular = new System.Windows.Forms.Button();
        	this.txt_escalar = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.cmbx_columnas = new System.Windows.Forms.ComboBox();
        	this.cmbx_filas = new System.Windows.Forms.ComboBox();
        	this.label6 = new System.Windows.Forms.Label();
        	this.label7 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.error = new System.Windows.Forms.ErrorProvider(this.components);
        	((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.dgv_matriz)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// label3
        	// 
        	this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.ForeColor = System.Drawing.Color.SteelBlue;
        	this.label3.Location = new System.Drawing.Point(314, 209);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(128, 23);
        	this.label3.TabIndex = 14;
        	this.label3.Text = "RESULTADO";
        	// 
        	// label4
        	// 
        	this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.ForeColor = System.Drawing.Color.SteelBlue;
        	this.label4.Location = new System.Drawing.Point(112, 18);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(92, 23);
        	this.label4.TabIndex = 13;
        	this.label4.Text = "MATRIZ";
        	// 
        	// dgv_resultado
        	// 
        	this.dgv_resultado.AllowUserToAddRows = false;
        	this.dgv_resultado.BackgroundColor = System.Drawing.Color.LightSteelBlue;
        	this.dgv_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgv_resultado.ColumnHeadersVisible = false;
        	this.dgv_resultado.Enabled = false;
        	this.dgv_resultado.Location = new System.Drawing.Point(258, 236);
        	this.dgv_resultado.Name = "dgv_resultado";
        	this.dgv_resultado.RowHeadersVisible = false;
        	this.dgv_resultado.Size = new System.Drawing.Size(240, 150);
        	this.dgv_resultado.TabIndex = 12;
        	// 
        	// dgv_matriz
        	// 
        	this.dgv_matriz.AllowUserToAddRows = false;
        	this.dgv_matriz.BackgroundColor = System.Drawing.Color.LightSteelBlue;
        	this.dgv_matriz.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
        	this.dgv_matriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgv_matriz.ColumnHeadersVisible = false;
        	this.dgv_matriz.ContextMenuStrip = this.contextMenuStrip1;
        	this.dgv_matriz.Location = new System.Drawing.Point(42, 45);
        	this.dgv_matriz.Name = "dgv_matriz";
        	this.dgv_matriz.RowHeadersVisible = false;
        	this.dgv_matriz.Size = new System.Drawing.Size(240, 150);
        	this.dgv_matriz.TabIndex = 11;
        	this.dgv_matriz.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgv_matrizEditingControlShowing);
        	this.dgv_matriz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dgv_matrizKeyPress);
        	// 
        	// contextMenuStrip1
        	// 
        	this.contextMenuStrip1.Name = "contextMenuStrip1";
        	this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
        	// 
        	// btn_calcular
        	// 
        	this.btn_calcular.Location = new System.Drawing.Point(112, 335);
        	this.btn_calcular.Name = "btn_calcular";
        	this.btn_calcular.Size = new System.Drawing.Size(75, 23);
        	this.btn_calcular.TabIndex = 15;
        	this.btn_calcular.Text = "Calcular";
        	this.btn_calcular.UseVisualStyleBackColor = true;
        	this.btn_calcular.Click += new System.EventHandler(this.Btn_calcularClick);
        	// 
        	// txt_escalar
        	// 
        	this.txt_escalar.ContextMenuStrip = this.contextMenuStrip1;
        	this.txt_escalar.Location = new System.Drawing.Point(94, 296);
        	this.txt_escalar.Name = "txt_escalar";
        	this.txt_escalar.Size = new System.Drawing.Size(100, 20);
        	this.txt_escalar.TabIndex = 20;
        	this.txt_escalar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_escalarKeyPress);
        	// 
        	// label2
        	// 
        	this.label2.Location = new System.Drawing.Point(42, 254);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(200, 28);
        	this.label2.TabIndex = 21;
        	this.label2.Text = "Digita el numero escalar que quieres multiplicar por la matriz:";
        	this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
        	this.cmbx_columnas.Location = new System.Drawing.Point(389, 116);
        	this.cmbx_columnas.Name = "cmbx_columnas";
        	this.cmbx_columnas.Size = new System.Drawing.Size(41, 21);
        	this.cmbx_columnas.TabIndex = 25;
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
        	this.cmbx_filas.Location = new System.Drawing.Point(322, 116);
        	this.cmbx_filas.Name = "cmbx_filas";
        	this.cmbx_filas.Size = new System.Drawing.Size(41, 21);
        	this.cmbx_filas.TabIndex = 24;
        	this.cmbx_filas.SelectedIndexChanged += new System.EventHandler(this.Cmbx_filasSelectedIndexChanged);
        	this.cmbx_filas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmbx_filasKeyPress);
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(369, 121);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(14, 13);
        	this.label6.TabIndex = 23;
        	this.label6.Text = "X";
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Location = new System.Drawing.Point(310, 89);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(132, 13);
        	this.label7.TabIndex = 22;
        	this.label7.Text = "Dimensión de las matrices:";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.Color.DarkRed;
        	this.label1.Location = new System.Drawing.Point(131, 416);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(376, 13);
        	this.label1.TabIndex = 26;
        	this.label1.Text = "ATENCIÓN: Estás en Multiplicación de una Matriz por un Escalar";
        	// 
        	// error
        	// 
        	this.error.ContainerControl = this;
        	// 
        	// frm_producto_escalar
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.White;
        	this.ClientSize = new System.Drawing.Size(510, 433);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.cmbx_columnas);
        	this.Controls.Add(this.cmbx_filas);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.txt_escalar);
        	this.Controls.Add(this.btn_calcular);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.dgv_resultado);
        	this.Controls.Add(this.dgv_matriz);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.MaximizeBox = false;
        	this.Name = "frm_producto_escalar";
        	this.Text = "Producto x Escalar";
        	((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.dgv_matriz)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbx_filas;
        private System.Windows.Forms.ComboBox cmbx_columnas;

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_resultado;
        private System.Windows.Forms.DataGridView dgv_matriz;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_escalar;
        private System.Windows.Forms.Label label2;
    }
}
namespace matriz
{
    partial class frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.pnl_body = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tool_anunciador = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_header = new System.Windows.Forms.Panel();
            this.pcbx_manual = new System.Windows.Forms.PictureBox();
            this.pcbx_link = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_tipos = new System.Windows.Forms.Button();
            this.btn_producto = new System.Windows.Forms.Button();
            this.btn_productoescalar = new System.Windows.Forms.Button();
            this.btn_sumayresta = new System.Windows.Forms.Button();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_manual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_link)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.Color.White;
            this.pnl_body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_body.Location = new System.Drawing.Point(141, 102);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(510, 433);
            this.pnl_body.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "MatrizAPP";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(109, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 49);
            this.label2.TabIndex = 11;
            this.label2.Text = "Aplicación Para El Cálculo De Matrices\r\nVersion: 1.0.0\r\nAutor: Genesis Vargas J.";
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_header.Controls.Add(this.pcbx_manual);
            this.pnl_header.Controls.Add(this.label2);
            this.pnl_header.Controls.Add(this.label1);
            this.pnl_header.Controls.Add(this.pcbx_link);
            this.pnl_header.Controls.Add(this.pictureBox1);
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(659, 96);
            this.pnl_header.TabIndex = 13;
            // 
            // pcbx_manual
            // 
            this.pcbx_manual.BackColor = System.Drawing.Color.Transparent;
            this.pcbx_manual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbx_manual.Image = ((System.Drawing.Image)(resources.GetObject("pcbx_manual.Image")));
            this.pcbx_manual.Location = new System.Drawing.Point(607, 51);
            this.pcbx_manual.Name = "pcbx_manual";
            this.pcbx_manual.Size = new System.Drawing.Size(44, 34);
            this.pcbx_manual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbx_manual.TabIndex = 13;
            this.pcbx_manual.TabStop = false;
            this.tool_anunciador.SetToolTip(this.pcbx_manual, "ABRIR EL MANUAL DE USUARIO");
            this.pcbx_manual.Click += new System.EventHandler(this.Pcbx_manualClick);
            // 
            // pcbx_link
            // 
            this.pcbx_link.BackColor = System.Drawing.Color.Transparent;
            this.pcbx_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbx_link.Image = ((System.Drawing.Image)(resources.GetObject("pcbx_link.Image")));
            this.pcbx_link.Location = new System.Drawing.Point(607, 9);
            this.pcbx_link.Name = "pcbx_link";
            this.pcbx_link.Size = new System.Drawing.Size(44, 34);
            this.pcbx_link.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbx_link.TabIndex = 12;
            this.pcbx_link.TabStop = false;
            this.tool_anunciador.SetToolTip(this.pcbx_link, "ABRIR LA PAGINA WEB DEL DESARROLLADOR");
            this.pcbx_link.Click += new System.EventHandler(this.Pcbx_linkClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_crear
            // 
            this.btn_crear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_crear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_crear.FlatAppearance.BorderSize = 0;
            this.btn_crear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_crear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear.ForeColor = System.Drawing.Color.Black;
            this.btn_crear.Image = ((System.Drawing.Image)(resources.GetObject("btn_crear.Image")));
            this.btn_crear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_crear.Location = new System.Drawing.Point(5, 450);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(130, 80);
            this.btn_crear.TabIndex = 9;
            this.btn_crear.Text = "Mostrar Matriz";
            this.btn_crear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_crear.UseVisualStyleBackColor = false;
            this.btn_crear.Click += new System.EventHandler(this.Btn_crearClick);
            // 
            // btn_tipos
            // 
            this.btn_tipos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_tipos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tipos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_tipos.FlatAppearance.BorderSize = 0;
            this.btn_tipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_tipos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_tipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tipos.ForeColor = System.Drawing.Color.Black;
            this.btn_tipos.Image = ((System.Drawing.Image)(resources.GetObject("btn_tipos.Image")));
            this.btn_tipos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_tipos.Location = new System.Drawing.Point(5, 364);
            this.btn_tipos.Name = "btn_tipos";
            this.btn_tipos.Size = new System.Drawing.Size(130, 80);
            this.btn_tipos.TabIndex = 8;
            this.btn_tipos.Text = "Tipo de Matriz";
            this.btn_tipos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_tipos.UseVisualStyleBackColor = false;
            this.btn_tipos.Click += new System.EventHandler(this.Btn_tiposClick);
            // 
            // btn_producto
            // 
            this.btn_producto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_producto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_producto.FlatAppearance.BorderSize = 0;
            this.btn_producto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_producto.ForeColor = System.Drawing.Color.Black;
            this.btn_producto.Image = ((System.Drawing.Image)(resources.GetObject("btn_producto.Image")));
            this.btn_producto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_producto.Location = new System.Drawing.Point(5, 278);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(130, 80);
            this.btn_producto.TabIndex = 7;
            this.btn_producto.Text = "Multiplicación";
            this.btn_producto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_producto.UseVisualStyleBackColor = false;
            this.btn_producto.Click += new System.EventHandler(this.Btn_productoClick);
            // 
            // btn_productoescalar
            // 
            this.btn_productoescalar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_productoescalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_productoescalar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_productoescalar.FlatAppearance.BorderSize = 0;
            this.btn_productoescalar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_productoescalar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_productoescalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productoescalar.ForeColor = System.Drawing.Color.Black;
            this.btn_productoescalar.Image = ((System.Drawing.Image)(resources.GetObject("btn_productoescalar.Image")));
            this.btn_productoescalar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_productoescalar.Location = new System.Drawing.Point(5, 192);
            this.btn_productoescalar.Name = "btn_productoescalar";
            this.btn_productoescalar.Size = new System.Drawing.Size(130, 80);
            this.btn_productoescalar.TabIndex = 6;
            this.btn_productoescalar.Text = "Producto por un Escalar";
            this.btn_productoescalar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_productoescalar.UseVisualStyleBackColor = false;
            this.btn_productoescalar.Click += new System.EventHandler(this.Btn_productoescalarClick);
            // 
            // btn_sumayresta
            // 
            this.btn_sumayresta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_sumayresta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sumayresta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sumayresta.FlatAppearance.BorderSize = 0;
            this.btn_sumayresta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_sumayresta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_sumayresta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sumayresta.ForeColor = System.Drawing.Color.Black;
            this.btn_sumayresta.Image = ((System.Drawing.Image)(resources.GetObject("btn_sumayresta.Image")));
            this.btn_sumayresta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sumayresta.Location = new System.Drawing.Point(5, 106);
            this.btn_sumayresta.Name = "btn_sumayresta";
            this.btn_sumayresta.Size = new System.Drawing.Size(130, 80);
            this.btn_sumayresta.TabIndex = 5;
            this.btn_sumayresta.Text = "Suma y Resta";
            this.btn_sumayresta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sumayresta.UseVisualStyleBackColor = false;
            this.btn_sumayresta.Click += new System.EventHandler(this.Btn_sumayrestaClick);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(656, 542);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_tipos);
            this.Controls.Add(this.btn_producto);
            this.Controls.Add(this.btn_productoescalar);
            this.Controls.Add(this.btn_sumayresta);
            this.Controls.Add(this.pnl_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatrizAPP";
            this.pnl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_manual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_link)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.PictureBox pcbx_manual;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.ToolTip tool_anunciador;
        private System.Windows.Forms.PictureBox pcbx_link;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_tipos;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Button btn_producto;
        private System.Windows.Forms.Button btn_productoescalar;
        private System.Windows.Forms.Button btn_sumayresta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel pnl_body;

        #endregion

    }
}
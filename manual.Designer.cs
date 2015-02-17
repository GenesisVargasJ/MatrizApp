/*
 * Created by SharpDevelop.
 * User: genesis
 * Date: 17/06/2013
 * Time: 12:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace matriz
{
	partial class frm_manual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_manual));
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.PcbxPagina = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PcbxPagina)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiguiente.ForeColor = System.Drawing.Color.White;
            this.BtnSiguiente.Location = new System.Drawing.Point(83, 636);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(75, 34);
            this.BtnSiguiente.TabIndex = 1;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = false;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnterior.ForeColor = System.Drawing.Color.White;
            this.BtnAnterior.Location = new System.Drawing.Point(2, 636);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(75, 34);
            this.BtnAnterior.TabIndex = 2;
            this.BtnAnterior.Text = "Anterior";
            this.BtnAnterior.UseVisualStyleBackColor = false;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // PcbxPagina
            // 
            this.PcbxPagina.BackgroundImage = global::matriz.Properties.Resources.Imagen1;
            this.PcbxPagina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PcbxPagina.Location = new System.Drawing.Point(0, 0);
            this.PcbxPagina.Name = "PcbxPagina";
            this.PcbxPagina.Size = new System.Drawing.Size(544, 630);
            this.PcbxPagina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbxPagina.TabIndex = 0;
            this.PcbxPagina.TabStop = false;
            // 
            // frm_manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(544, 672);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.PcbxPagina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_manual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.PcbxPagina)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.PictureBox PcbxPagina;
	}
}

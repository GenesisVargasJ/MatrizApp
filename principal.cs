using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace matriz
{
    public partial class frm_principal : Form
    {
    	funciones fun = new funciones();
    	
    	public frm_principal()
        {
            InitializeComponent();
        }
    	        
        void Btn_sumayrestaClick(object sender, EventArgs e)
        {
        	abrir_en_panel(new frm_sumayresta());
        }
        
        void Btn_productoescalarClick(object sender, EventArgs e)
        {
        	abrir_en_panel(new frm_producto_escalar());
        }
        
        void Btn_productoClick(object sender, EventArgs e)
        {
        	abrir_en_panel(new frm_multiplicacion());
        }
        
        void Btn_tiposClick(object sender, EventArgs e)
        {
        	abrir_en_panel(new frm_tipomatriz());
        }
        
        void Btn_crearClick(object sender, EventArgs e)
        {
        	abrir_en_panel(new frm_muestra());
        }
        
        public void abrir_en_panel(object formulario)
        {
       		pnl_body.Controls.Clear();
        	Form form = formulario as Form;
        	form.TopLevel = false;
        	pnl_body.Controls.Add(form);
        	form.Show();
        }
        
        void Pcbx_linkClick(object sender, EventArgs e)
        {
        	System.Diagnostics.Process.Start("http://www.genesisvargasj.com");
        }
        
        void Pcbx_manualClick(object sender, EventArgs e)
        {
            frm_manual frm = new frm_manual();
            frm.Show();
        }
    }
}

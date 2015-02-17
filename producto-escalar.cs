/*
 * Created by SharpDevelop.
 * User: genesis
 * Date: 14/06/2013
 * Time: 0:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace matriz
{
    public partial class frm_producto_escalar : Form
    {
        int esc, m, n;
        funciones fun = new funciones();

        public frm_producto_escalar()
        {
            InitializeComponent();
        }
        
        void Cmbx_filasSelectedIndexChanged(object sender, EventArgs e)
        {
        	if (cmbx_columnas.Text == "") 
        	{
				m = Convert.ToInt32(cmbx_filas.Text);
        		fun.crearmatriz(m, n, dgv_matriz);
			}
			else
			{
				m = Convert.ToInt32(cmbx_filas.Text);
				n = Convert.ToInt32(cmbx_columnas.Text);
        		fun.crearmatriz(m, n, dgv_matriz);	
        		fun.crearmatriz(m, n, dgv_resultado);
			}
        }
        
        void Cmbx_columnasSelectedIndexChanged(object sender, EventArgs e)
        {
        	if (cmbx_filas.Text != "") 
        	{
        		m = Convert.ToInt32(cmbx_filas.Text);
        		n = Convert.ToInt32(cmbx_columnas.Text);
        		fun.crearmatriz(m, n, dgv_matriz);
        		fun.crearmatriz(m, n, dgv_resultado);
        		fun.error(error, dgv_matriz,"");
        	}
        	else
        	{
        		fun.error(error, dgv_matriz,"NO HA ESCOGIDO EL NUMERO DE FILAS");
        	}
        }
        
        void Btn_calcularClick(object sender, EventArgs e)
        {
        	if (cmbx_columnas.Text != "") 
        	{
        		fun.error(error, dgv_matriz, "");
        		if (txt_escalar.Text != "" && dgv_matriz.Rows.Count != 0 && !fun.celdas_vacias(dgv_matriz))
        		{
        			fun.error(error, dgv_matriz,"");
        			esc = Convert.ToInt32(txt_escalar.Text);
        			fun.producto_escalar(m, n, dgv_matriz, dgv_resultado, esc); 
        		}
        		else
        		{
        			fun.error(error, dgv_matriz,"NO HA DIGITADO EL NUMERO ESCALAR, NO SE HAN CONSTRUIDO LAS MATRICES, HAY CELDAS VACIAS, O ESTAS DIGITANDO MAL LOS NUMEROS NEGATIVOS");
        		}
			}	
			else
			{
				fun.error(error, dgv_matriz,"AÚN NO HAS ESCOGIDO LAS COLUMNAS");
			}
        }
        
        void Txt_escalarKeyPress(object sender, KeyPressEventArgs e)
        {
        	fun.solo_numeros(dgv_matriz, e);
        }
        
        void Dgv_matrizKeyPress(object sender, KeyPressEventArgs e)
        {
        	fun.solo_numeros(dgv_matriz, e);
        }
        
        void Cmbx_filasKeyPress(object sender, KeyPressEventArgs e)
        {
        	fun.ninguna_tecla(e);
        }
        
        void Cmbx_columnasKeyPress(object sender, KeyPressEventArgs e)
        {
        	fun.ninguna_tecla(e);
        }
        
        void Dgv_matrizEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        	TextBox celda = e.Control as TextBox;
            celda.KeyPress -= new KeyPressEventHandler(Dgv_matrizKeyPress);
            celda.KeyPress += new KeyPressEventHandler(Dgv_matrizKeyPress);
        }  
    }
}
    
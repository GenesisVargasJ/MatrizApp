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
    public partial class frm_sumayresta : Form
    {
        int m, n;
        funciones fun = new funciones();

        public frm_sumayresta()
        {
            InitializeComponent();
        }
        
        void Cmbx_filasSelectedIndexChanged(object sender, EventArgs e)
        {
        	if (cmbx_columnas.Text == "")
        	{
				m = Convert.ToInt32(cmbx_filas.Text);
        		fun.crearmatriz(m, n, dgv_matriz1);
        		fun.crearmatriz(m, n, dgv_matriz2);	
			}
			else
			{
				m = Convert.ToInt32(cmbx_filas.Text);
				n = Convert.ToInt32(cmbx_columnas.Text);
        		fun.crearmatriz(m, n, dgv_matriz1);	
        		fun.crearmatriz(m, n, dgv_matriz2);	
			}
        }
        
        void Cmbx_columnasSelectedIndexChanged(object sender, EventArgs e)
        {
        	if (cmbx_columnas.Text == cmbx_filas.Text && cmbx_filas.Text != "") 
        	{
        		m = Convert.ToInt32(cmbx_filas.Text);
        		n = Convert.ToInt32(cmbx_columnas.Text);
        		fun.crearmatriz(m, n, dgv_matriz1);
        		fun.crearmatriz(m, n, dgv_matriz2);
        		fun.error(error, dgv_matriz1,"");
        	}
        	else
        	{
        		fun.error(error, dgv_matriz1,"EL NÚMERO DE FILAS DEBEN SER IGUALES QUE EL NÚMERO DE LAS COLUMNAS");
        	}
        }
        
        void btn_calcular_Click(object sender, EventArgs e)
        {
        	if (cmbx_columnas.Text == cmbx_filas.Text && cmbx_filas.Text != "") 
        	{
        		fun.error(error, dgv_matriz1, "");
        		if (dgv_matriz1.Rows.Count != 0 && dgv_matriz2.Rows.Count != 0 && !fun.celdas_vacias(dgv_matriz1) && !fun.celdas_vacias(dgv_matriz2))
        		{
        			fun.error(error, dgv_suma,"");
        			fun.crearmatriz(m, n, dgv_suma);
        			fun.crearmatriz(m, n, dgv_resta);
        			fun.sumayresta(m, n, dgv_matriz1, dgv_matriz2, dgv_suma, dgv_resta);  
        		}
        		else
        		{
        			fun.error(error, dgv_suma, "NO SE HAN CONSTRUIDO LAS MATRICES, HAY CELDAS VACIAS, O ESTAS DIGITANDO MAL LOS NUMEROS NEGATIVOS");
            	}
        	}
        	else 
        	{
        		fun.error(error, dgv_matriz1, "EL NÚMERO DE FILAS DEBEN SER IGUALES QUE EL NÚMERO DE LAS COLUMNAS");
        	}            	
        }
   
        void Dgv_matriz1KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.solo_numeros(dgv_matriz1, e);
        }
        
        void Dgv_matriz2KeyPress(object sender, KeyPressEventArgs e)
        {
        	fun.solo_numeros(dgv_matriz2, e);
        }
        
        void Cmbx_filasKeyPress(object sender, KeyPressEventArgs e)
        {
        	fun.ninguna_tecla(e);
        }
        
        void Cmbx_columnasKeyPress(object sender, KeyPressEventArgs e)
        {
        	fun.ninguna_tecla(e);
        }

        void Dgv_matriz1EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        	TextBox celda = e.Control as TextBox;
            celda.KeyPress -= new KeyPressEventHandler(Dgv_matriz1KeyPress);
            celda.KeyPress += new KeyPressEventHandler(Dgv_matriz1KeyPress);            
        }
         
        void Dgv_matriz2EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        	TextBox celda = e.Control as TextBox;
            celda.KeyPress -= new KeyPressEventHandler(Dgv_matriz2KeyPress);
            celda.KeyPress += new KeyPressEventHandler(Dgv_matriz2KeyPress); 
        }
    }
}

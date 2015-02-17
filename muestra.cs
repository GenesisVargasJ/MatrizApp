/*
 * Created by SharpDevelop.
 * User: genesis
 * Date: 16/06/2013
 * Time: 16:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace matriz
{
	/// <summary>
	/// Description of muestra.
	/// </summary>
	public partial class frm_muestra : Form
	{
		int m, n;
		funciones fun = new funciones();
		
		public frm_muestra()
		{
			InitializeComponent();
		}
		
		void Cmbx_filasSelectedIndexChanged(object sender, EventArgs e)
		{	if (cmbx_columnas.Text == "") 
        	{
				m = Convert.ToInt32(cmbx_filas.Text);
        		fun.crearmatriz(m, n, dgv_matriz);
			}
			else
			{
				m = Convert.ToInt32(cmbx_filas.Text);
				n = Convert.ToInt32(cmbx_columnas.Text);
        		fun.crearmatriz(m, n, dgv_matriz);
				fun.crearmatriz(m, n, dgv_opuesta);
        		fun.crearmatriz(n, m, dgv_traspuesta);	
			}
		}
		
		void Cmbx_columnasSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbx_filas.Text != "") 
        	{
        		m = Convert.ToInt32(cmbx_filas.Text);
				n = Convert.ToInt32(cmbx_columnas.Text);
				fun.crearmatriz(m, n,dgv_matriz);
				fun.crearmatriz(m, n, dgv_opuesta);
        		fun.crearmatriz(n, m, dgv_traspuesta);
				fun.error(error, dgv_matriz,"");
        	}
        	else
        	{
        		fun.error(error, dgv_matriz,"NO HA ESCOGIDO EL NUMERO DE FILAS DE LA MATRIZ");
        	}
		}
		
		void Btn_calcularClick(object sender, EventArgs e)
		{
			if (cmbx_columnas.Text != "") 
        	{
        		fun.error(error, dgv_matriz, "");
        		if (dgv_matriz.Rows.Count != 0 && !fun.celdas_vacias(dgv_matriz))
        		{
					fun.error(error, dgv_matriz,"");
					fun.opuesta(m, n, dgv_matriz, dgv_opuesta);
					fun.traspuesta(m, n, dgv_matriz, dgv_traspuesta);
        		}
        		else
        		{
        			fun.error(error, dgv_matriz,"NO SE HAN CONSTRUIDO LAS MATRICES, HAY CELDAS VACIAS, O ESTAS DIGITANDO MAL LOS NUMEROS NEGATIVOS");
        		}
        	}
        	else 
        	{
        		fun.error(error, dgv_matriz, "AÚN NO HAS ESCOGIDO LAS COLUMNAS");
        	}         
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

/*
 * Created by SharpDevelop.
 * User: genesis
 * Date: 14/06/2013
 * Time: 0:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace matriz
{
	/// <summary>
	/// Description of multiplicacion.
	/// </summary>
	public partial class frm_multiplicacion : Form
	{
		int m, n, m2, n2;
        funciones fun = new funciones();
        	
		public frm_multiplicacion()
		{
			InitializeComponent();
		}
		
		void Cmbx_filasSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbx_columnas.Text == "")
        	{
				m = Convert.ToInt32(cmbx_filas.Text);
        		fun.crearmatriz(m, n, dgv_matriz1);
			}
			else
			{
				m = Convert.ToInt32(cmbx_filas.Text);
				n = Convert.ToInt32(cmbx_columnas.Text);
        		fun.crearmatriz(m, n, dgv_matriz1);	
			}
		}
		
		void Cmbx_columnasSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbx_filas.Text != "") 
        	{
				m = Convert.ToInt32(cmbx_filas.Text);
        		n = Convert.ToInt32(cmbx_columnas.Text);
        		fun.crearmatriz(m, n, dgv_matriz1);
				fun.error(error, dgv_matriz1,"");
        	}
        	else
        	{
        		fun.error(error, dgv_matriz1,"NO HA ESCOGIDO EL NUMERO DE FILAS DE LA MATRIZ");
        	}
		}
		
		void Cmbx_filas2SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbx_columnas2.Text == "")
        	{
				m2 = Convert.ToInt32(cmbx_filas2.Text);
        		fun.crearmatriz(m2, n2, dgv_matriz2);	
			}
			else
			{
				m2 = Convert.ToInt32(cmbx_filas2.Text);
				n2 = Convert.ToInt32(cmbx_columnas2.Text);
        		fun.crearmatriz(m2, n2, dgv_matriz2);	
			}
		}
		
		void Cmbx_columnas2SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbx_filas2.Text != "") 
        	{
				m2 = Convert.ToInt32(cmbx_filas2.Text);
        		n2 = Convert.ToInt32(cmbx_columnas2.Text);
        		fun.crearmatriz(m2, n2, dgv_matriz2);
				fun.error(error, dgv_matriz2,"");
        	}
        	else
        	{
        		fun.error(error, dgv_matriz2,"NO HA ESCOGIDO EL NUMERO DE FILAS DE LA MATRIZ");
        	}
		}
		
		void Btn_calcularClick(object sender, EventArgs e)
		{
			if (dgv_matriz1.Rows.Count != 0 && dgv_matriz2.Rows.Count != 0 && cmbx_columnas.Text == cmbx_filas2.Text && !fun.celdas_vacias(dgv_matriz1) && !fun.celdas_vacias(dgv_matriz2))
        	{
				fun.error(error, dgv_matriz1,"");
				fun.crearmatriz(m, n2, dgv_resultado);
				fun.multiplicacion(m, n, n2, dgv_matriz1, dgv_matriz2, dgv_resultado);
        	}
        	else
        	{
        		fun.error(error, dgv_matriz1,"LAS COLUMNAS DE LA PRIMERA MATRIZ DEBEN SER IGUALES A LAS FILAS DE LA SEGUNDA MATRIZ, NO SE HAN CONSTRUIDO LAS MATRICES, HAY CELDAS VACIAS, O ESTAS DIGITANDO MAL LOS NUMEROS NEGATIVOS");
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
		
		void Cmbx_filas2KeyPress(object sender, KeyPressEventArgs e)
		{
			fun.ninguna_tecla(e);
		}
		
		void Cmbx_columnas2KeyPress(object sender, KeyPressEventArgs e)
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

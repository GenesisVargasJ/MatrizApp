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
	/// Description of producto.
	/// </summary>
	public partial class frm_tipomatriz : Form
	{
		int m, n;
		funciones fun = new funciones();
		
		public frm_tipomatriz()
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
			}
		}
		
		void Cmbx_columnasSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbx_filas.Text != "") 
        	{
        		m = Convert.ToInt32(cmbx_filas.Text);
        		n = Convert.ToInt32(cmbx_columnas.Text);
        		fun.crearmatriz(m, n, dgv_matriz);
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
				fun.error(error, dgv_matriz,"");
				if (!fun.celdas_vacias(dgv_matriz))
				{
					lstbx_resultados.Items.Clear();
					if (!fun.es_cuadrada(m, n))
					{	
						lstbx_resultados.Items.Add("LA MATRIZ ES RECTANGULAR");
					}
					else
					{
						lstbx_resultados.Items.Add("LA MATRIZ ES CUADRADA");
					}
					if (fun.es_nula(m, n, dgv_matriz))
					{
						lstbx_resultados.Items.Add("LA MATRIZ ES NULA");
					}
					if (fun.es_identidad(m, n, dgv_matriz))
					{
						lstbx_resultados.Items.Add("LA MATRIZ ES DE IDENTIDAD");
					}
					if (fun.es_diagonal(m, n, dgv_matriz))
					{
						lstbx_resultados.Items.Add("LA MATRIZ ES DIAGONAL");
					}
					if (fun.es_simetrica(m, n, dgv_matriz))
					{
						lstbx_resultados.Items.Add("LA MATRIZ ES SIMETRICA");
					}
					if (fun.es_antisimetrica(m, n, dgv_matriz))
					{
						lstbx_resultados.Items.Add("LA MATRIZ ES ANTISIMETRICA");
					}
					if (fun.es_escalar(m, n, dgv_matriz))
					{
						lstbx_resultados.Items.Add("LA MATRIZ ES ESCALAR");
					}
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

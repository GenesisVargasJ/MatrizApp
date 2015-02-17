using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace matriz
{
	public class funciones
    {
    	int i, j, k;
    	
    	//funcion par permitir solo números positivos y negativos y la tecla borrar
    	public KeyPressEventArgs solo_numeros(DataGridView m, KeyPressEventArgs e)
		{
    		//comparo si el caracter es numero, control o negativo y lo habilito
    		if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == Convert.ToChar("-"))
       		{
           		e.Handled = false;
       		}
       		else
        	{
            	e.Handled = true;            	
           	}
        	return e;
		}
       	
       	//funcion para no permitir teclas
       	public KeyPressEventArgs ninguna_tecla(KeyPressEventArgs e) 
		{
       		//controlo el evento keypresseventargs para todas las teclas
       		e.Handled = true;
        	return e;
		}
       	
       	//metodo para mostrar errores
       	public void error(ErrorProvider error, DataGridView m, string mensaje)
       	{
       		//establezco en el error: primero, el control asociado y segundo el mensaje como tipo string
       		error.SetError(m, mensaje);
       	}
       	
       	//metodo para crear matrices dependeiendo si hay filas y columnas seleccionadas los en datagridviews
       	public void crearmatriz(int f,int c, DataGridView m1) 
       	{
       		//verifico si las columnas estan vacias
       		if(c != 1 && c != 2 && c != 3 && c != 4 && c != 5 && c!= 6 && c != 7 && c!= 8 && c!= 9 && c != 10)
       		{
       			//borro las columnas del datagridview
       			m1.Columns.Clear();
       		 	for (i = 0; i < 1; i++)
            	{
               		// Creo una columna
               		DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
               		col1.Width = 30;
               		col1.Name = "columna";
               		col1.MaxInputLength = 2;
               		col1.Resizable = DataGridViewTriState.False;
               		ContextMenuStrip menu = new ContextMenuStrip();
               		col1.ContextMenuStrip = menu;
               		m1.Columns.Add(col1);
    	    	}
            	m1.Rows.Add(f);
       		}
       		else 
       		{
       			//borro las columnas del datagridview
       			m1.Columns.Clear();
            	for (i = 0; i < c; i++)
            	{
               		//creo una columna
               		DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
               		col1.Width = 30;
               		col1.Name = "columna";
               		col1.MaxInputLength = 2;
               		col1.Resizable = DataGridViewTriState.False;
               		ContextMenuStrip menu = new ContextMenuStrip();
               		menu.IsAccessible = false;
               		col1.ContextMenuStrip = menu;
               		m1.Columns.Add(col1);
    	    	}
            	m1.Rows.Add(f);
       		}
       	}
       	
       	//funcion para ver si hay celdas vacias o hay numeros mal digitados
        /*utilizo el for each porque con el for me queda mas dificil saber si la celda es vacía
		ya que en c# no se puede hacer lo que se me ocurrio primero: if (m[i,j]="")... ademas
       	un  for each hace el recorrido de manera completa sin importar el numero de filas o columnas*/
       	public bool celdas_vacias(DataGridView m)
        {
            bool vacia;
            vacia = false;
            foreach (DataGridViewRow fila in m.Rows) 
            {
				//recorro las celdas de cada fila
				foreach (DataGridViewCell celda in fila.Cells) 
				{
					// declaro un objeto y le asigno el valor de cada celda
					object valor = celda.Value;
					//comparo si ese valor es nulo o si el valor es de tipo dbnull
					if ((valor == null) || (object.ReferenceEquals(valor, DBNull.Value)) || valor.ToString() == "-"  || valor.ToString() == "--" || valor.ToString() == "1-"  || valor.ToString() == "2-" || valor.ToString() == "3-"  || valor.ToString() == "4-" || valor.ToString() == "5-"  || valor.ToString() == "6-" || valor.ToString() == "7-"  || valor.ToString() == "8-" || valor.ToString() == "9-"  || valor.ToString() == "0-")
					{
						vacia = true;
					}
				}
            }
            return vacia;
        }
       	      	
       	//metodo para sumar matrices
       	public void sumayresta(int f, int c, DataGridView m1, DataGridView m2, DataGridView sum, DataGridView res) 
       	{
       		for (i = 0; i < f; i++)
            {
                for (j = 0; j < c; j++)
                {
                	sum[j,i].Value = Convert.ToInt32(m1[j,i].Value) + Convert.ToInt32(m2[j,i].Value);
                	res[j,i].Value = Convert.ToInt32(m1[j,i].Value) - Convert.ToInt32(m2[j,i].Value);
                }
       		}
       	}
       	
       	//metodo para multiplicar matriz por un escalar
       	public void producto_escalar(int f, int c, DataGridView m1, DataGridView res, int num) 
       	{
       		for (i = 0; i < f; i++)
            {
                for (j = 0; j < c; j++)
                {
                	res[j,i].Value = Convert.ToInt32(m1[j,i].Value) * num;
                }
       		}
       	}
       	
       	//funcion para multiplicar matrices
       	public DataGridView multiplicacion (int f, int c, int c2, DataGridView m1, DataGridView m2, DataGridView res) 
       	{
       		for (i = 0; i < f; i++)
            {
                for (j = 0; j < c2; j++)
                {
                	res[j,i].Value = 0;
                	for (k = 0; k < c; k++)
                	{
                		res[j,i].Value = Convert.ToInt32(res[j,i].Value) + Convert.ToInt32(m1[k,i].Value) * Convert.ToInt32(m2[j,k].Value);
                	}
                }
       		}
       		return res;
       	}
       	
       	//funcion para verificar que una matriz es cuadrada
       	public bool es_cuadrada (int f, int c) 
       	{
       		bool cuad;
       		if (f != c)
       		{
       			cuad = false; 
       		}
       		else
       		{
       			cuad = true;
       		}
       		return cuad;
       	}
       	
       	//funcion para verificar que una matriz es nula
       	public bool es_nula (int f, int c, DataGridView m) 
       	{
       		int nul=0 , valm = 0;
       		bool nulo;
       		for(i=0; i<f; i++)
       		{
       			for(j=0; j<c; j++)
       			{
       				valm = Convert.ToInt32(m[j,i].Value);
       				if(valm == 0)
       				{
       					nul += 1;
       				}
       			}
       		}
       		if (nul == f * c)
       		{
       			nulo = true; 
       		}
       		else
       		{
       			nulo = false;
       		}
       		return nulo;
       	}

       	//funcion para verificar que una matriz es de identidad
       	public bool es_identidad (int f, int c, DataGridView m) 
       	{
       		int ceros=0 , unos = 0, valm = 0;
       		bool identi;
       		if (f == c)
       		{
       			for(i=0; i<f; i++)
       			{
       				for(j=0; j<c; j++)
       				{
       					valm = Convert.ToInt32(m[j,i].Value );
       					if(i == j && valm == 1)
       					{
       						unos += 1;
       					}
       					else if(i != j && valm == 0)
       					{
       						ceros += 1;
       					}
       				}
       			}
       			if (ceros == f * c - f && unos == f)
       			{
       				identi = true; 
       			}
       			else
       			{
       				identi = false;
       			}       		
       		}
			else 
			{
				identi = false;
			}
			return identi;
       	}
       	
       	//funcion para verificar que una matriz es diagonal
       	public bool es_diagonal (int f, int c, DataGridView m) 
       	{
       		int ceros=0, num=0, valm = 0;
       		bool diago;
       		if (f == c)
       		{
       			for(i=0; i<f; i++)
       			{
       				for(j=0; j<c; j++)
       				{
       					valm = Convert.ToInt32(m[j,i].Value );
       					if(i == j && valm != 0)
       					{
       						num += 1;
       					}
       					else if(i != j && valm == 0)
       					{
       						ceros += 1;
       					}
       				}
       			}
       			if (ceros == f * c - f && num == f)
       			{
       				diago = true; 
       			}
       			else
       			{
       				diago = false;
       			}       		
       		}
			else 
			{
				diago = false;
			}
			return diago;
       	}
       	
       	//funcion para verificar que una matriz es escalar
       	public bool es_escalar (int f, int c, DataGridView m) 
       	{
       		int ceros=0, num, acum=0, valm = 0;
       		num = Convert.ToInt32(m[0,0].Value);
       		bool esc;
       		if (f == c)
       		{
       			for(i=0; i<f; i++)
       			{
       				for(j=0; j<c; j++)
       				{
       					valm = Convert.ToInt32(m[j,i].Value );
       					if(j == i && valm == num)
       					{
       						acum += 1;
       					}
       					else if(i != j && valm == 0)
       					{
       						ceros += 1;
       					}
       				}
       			}
       			if (ceros == f * c - f && acum == f)
       			{
       				esc = true; 
       			}
       			else
       			{
       				esc = false;
       			}       		
       		}
			else 
			{
				esc = false;
			}
			return esc;
       	}
       	
       	//funcion para verificar que una matriz es simetrica
       	public bool es_simetrica(int f, int c, DataGridView m) 
       	{
       		int valm = 0, valmsim = 0;
       		bool sime = true;
       		if (f == c)
       		{
       			for(i=0; i<f; i++)
       			{
       				for(j=0; j<c; j++)
       				{
       					valm = Convert.ToInt32(m[i,j].Value);
       					valmsim = Convert.ToInt32(m[j,i].Value);
       					if(valm != valmsim)
       					{
       						sime = false;
       						i = f;
       						j=c;
       					}
       				}
       			}     		
       		}
			else 
			{
				sime = false;
			}
			return sime;
       	}
       	
       	//funcion para verificar que una matriz es anti-simetrica
       	public bool es_antisimetrica(int f, int c, DataGridView m) 
       	{
       		int valm = 0, valmantisim = 0;
       		bool antisime = true;
       		if (f == c)
       		{
       			for(i=0; i<f; i++)
       			{
       				for(j=0; j<c; j++)
       				{
       					valm = Convert.ToInt32(m[i,j].Value);
       					valmantisim = Convert.ToInt32(m[j,i].Value);
       					if(valmantisim != -valm)
       					{
       						antisime = false;
       						i = f;
       						j=c;
       					}
       				}
       			}     		
       		}
			else 
			{
				antisime = false;
			}
			return antisime;
       	}
       	
       	//funcion para mostrar una matriz opuesta
       	public DataGridView opuesta (int f, int c, DataGridView m, DataGridView res) 
       	{
       		for(i=0; i<f; i++)
       		{
       			for(j=0; j<c; j++)
       			{
       				res[j,i].Value = Convert.ToInt32(m[j,i].Value) * -1 ;
       			}
       		}
       		return res;
       	}
       	
       	//funcion para mostrar una matriz traspuesta
       	public DataGridView traspuesta (int f, int c, DataGridView m, DataGridView res) 
       	{
       		for(i=0; i<f; i++)
       		{
       			for(j=0; j<c; j++)
       			{
       				res[i,j].Value = Convert.ToInt32(m[j,i].Value);
       			}
       		}
       		return res;
       	}
    }
}
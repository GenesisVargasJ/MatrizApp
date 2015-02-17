/*
 * Created by SharpDevelop.
 * User: genesis
 * Date: 17/06/2013
 * Time: 12:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace matriz
{
	/// <summary>
	/// Description of manual.
	/// </summary>
	public partial class frm_manual : Form
	{
        int contador = 1;

        public frm_manual()
		{
			InitializeComponent();
            PcbxPagina.BackgroundImage = Properties.Resources.Imagen1;
            PcbxPagina.BackgroundImageLayout = ImageLayout.Stretch;
		}
        
        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if(contador > 1 && contador <=6)
            {
                contador -= 1;
                if (contador == 1)
                {
                    PcbxPagina.BackgroundImage = Properties.Resources.Imagen1;
                    PcbxPagina.BackgroundImageLayout = ImageLayout.Stretch;
                } 
                if (contador == 2)
                {
                    PcbxPagina.BackgroundImage = Properties.Resources.Imagen2;
                    PcbxPagina.BackgroundImageLayout = ImageLayout.Stretch;
                }
                if (contador == 3)
                {
                    PcbxPagina.BackgroundImage = Properties.Resources.Imagen3;
                    PcbxPagina.BackgroundImageLayout = ImageLayout.Stretch;
                }
                if (contador == 4)
                {
                    PcbxPagina.BackgroundImage = Properties.Resources.Imagen4;
                    PcbxPagina.BackgroundImageLayout = ImageLayout.Stretch;
                }
                if (contador == 5)
                {
                    PcbxPagina.BackgroundImage = Properties.Resources.Imagen5;
                    PcbxPagina.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (contador >= 1 && contador < 6)
            {
                contador += 1;
                if (contador == 2)
                {
                    PcbxPagina.BackgroundImage = Properties.Resources.Imagen2;
                    PcbxPagina.BackgroundImageLayout = ImageLayout.Stretch;
                }
                if (contador == 3)
                {
                    PcbxPagina.BackgroundImage = Properties.Resources.Imagen3;
                    PcbxPagina.BackgroundImageLayout = ImageLayout.Stretch;
                }
                if (contador == 4)
                {
                    PcbxPagina.BackgroundImage = Properties.Resources.Imagen4;
                    PcbxPagina.BackgroundImageLayout = ImageLayout.Stretch;
                }
                if (contador == 5)
                {
                    PcbxPagina.BackgroundImage = Properties.Resources.Imagen5;
                    PcbxPagina.BackgroundImageLayout = ImageLayout.Stretch;
                }
                if (contador == 6)
                {
                    PcbxPagina.BackgroundImage = Properties.Resources.Imagen6;
                    PcbxPagina.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpers
{

    static public class Helper
    {
        static public void cargarImagen(string url, PictureBox contenedor)
        {
			try
			{
				contenedor.ImageLocation = url;
				contenedor.Load();
			}
			catch (Exception ex)
			{
				contenedor.Load("https://ih1.redbubble.net/image.32745528.9447/raf,360x360,075,t,fafafa:ca443f4786.jpg");
			}
        }
        static public void ocultarColumna(DataGridView dgv, string columna)
        {
            dgv.Columns[columna].Visible = false;
        }
    }
}

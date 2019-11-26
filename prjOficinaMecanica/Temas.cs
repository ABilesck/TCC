using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjOficinaMecanica
{
    class Temas
    {
        public static void AplicarTema(Control control, Color fundo, Color fonte)
        {
            foreach (var item in control.Controls)
            {
                if (item is Label)
                {
                    ((Label)item).ForeColor = fonte;
                }
                if (item is MenuStrip)
                {
                    ((MenuStrip)item).BackColor = fundo;
                    ((MenuStrip)item).ForeColor = fonte;
                }
                if (item is StatusStrip)
                {
                    ((StatusStrip)item).BackColor = fundo;
                    ((StatusStrip)item).ForeColor = fonte;
                }
                if (item is ToolStrip)
                {
                    ((ToolStrip)item).BackColor = fundo;
                    ((ToolStrip)item).ForeColor = fonte;
                }
                if(item is Button)
                {
                    ((Button)item).BackColor = fundo;
                    ((Button)item).ForeColor = fonte;
                }
                if(item is DataGridView)
                {
                    ((DataGridView)item).EnableHeadersVisualStyles = false;
                    ((DataGridView)item).DefaultCellStyle.ForeColor = fonte;
                    ((DataGridView)item).DefaultCellStyle.BackColor = fundo;
                    ((DataGridView)item).ColumnHeadersDefaultCellStyle.BackColor = fundo;
                    ((DataGridView)item).ColumnHeadersDefaultCellStyle.ForeColor = fonte;
                }
            }
            control.BackColor = fundo;
            control.ForeColor = fonte;
        }
    }
}

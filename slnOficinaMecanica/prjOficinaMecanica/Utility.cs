using System.Windows.Forms;

namespace prjOficinaMecanica
{
    class Utility
    {
        public void HabilitaCampos(Control control, bool hab)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = hab;
                }
                if (c is ComboBox)
                {
                    c.Enabled = hab;
                }
                if (c is MaskedTextBox)
                {
                    c.Enabled = hab;
                }
                if(c is NumericUpDown)
                {
                    c.Enabled = hab;
                }
            }
        }
        public void LimpaCampos(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                if (c is ComboBox)
                {
                    c.Text = "";
                }
                if (c is MaskedTextBox)
                {
                    c.Text = "";
                }
            }
        }
        public void HabilitaBotoes(Control control, bool hab)
        {
            foreach (Control c in control.Controls)
            {
                if (c is Button)
                {
                    if (c.Name.Equals("btnNovo"))
                    {
                        c.Enabled = !hab;
                    }
                    else
                    {
                        c.Enabled = hab;
                    }
                }
            }
        }
    }

    public enum Operacao
    {
        incluir,
        alterar
    }
}

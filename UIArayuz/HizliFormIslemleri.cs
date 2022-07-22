using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIArayuz
{
    public static class HizliFormIslemleri
    {
        public static void FormTemizle(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is GroupBox)
                {
                    foreach (var item in control.Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Text = string.Empty;
                        }
                        else if (item is MaskedTextBox)
                        {
                            ((MaskedTextBox)item).Text = string.Empty;
                        }
                        else if (item is ComboBox)
                        {
                            ((ComboBox)item).SelectedIndex = -1;
                        }
                    }
                }
            }
        }       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseController3
{
    public class InputValidator
    {
        public static bool ValidateDecimal(string input, out decimal output)
        {
            if (decimal.TryParse(input, out output)) {
                return true;
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun");
                return false;
                }
        }

        public static bool ValidateInt(string input, out int output)
        {
            if (int.TryParse(input, out output))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun");
                return false;
            }
        }
        public static bool ValidateDateTime(string input, out DateTime output)
        {
            if (DateTime.TryParse(input, out output))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun");
                return false;
            }
        }
        public static bool ValidateString(string input, out string output)
        {
            if (!string.IsNullOrEmpty(input))
            {
                output = input;
                return true;
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun");
                output = null;
                return false;
            }
        }
        public static bool ValidateBoolean(string input, out bool output)
        {
            if (bool.TryParse(input, out output))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun");
                return false;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace BaseConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateResult(object sender, EventArgs e)
        {
            string result;
            try
            {
                result = ToBase(FromBase(sourceNumber.Text, (int)fromBase.Value), (int)toBase.Value);
            }
            catch (ArgumentOutOfRangeException)
            {
                result = "Invalid Result";
            }
            resultLabel.Text = result;
        }

        private BigInteger FromBase(string number, int b)
        {
            if (b > 10 + 26 + 26 || b < 2)
                throw new ArgumentOutOfRangeException("b", b, "Not enough characters to properly convert");
            
            BigInteger Pow(int e, int p)
            {
                BigInteger r = 1;
                while (p-- > 0)
                    r *= e;
                return r;
            }

            BigInteger result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int temp = -1;
                if (number[i] >= '0' && number[i] <= '9')
                    temp = number[i] - '0';
                else if (number[i] >= 'a' && number[i] <= 'z')
                    temp = number[i] - 'a' + 10;
                else if (number[i] >= 'A' && number[i] <= 'Z')
                    temp = number[i] - 'A' + 26 + 10;

                if (temp < 0 || temp >= b)
                    throw new ArgumentOutOfRangeException("number", number, "Invalid character for base");

                result += temp * Pow(b, number.Length - i - 1);
            }
            return result;
        }

        private string ToBase(BigInteger number, int b)
        {
            string result = "";
            char[] letters = {
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A',
                'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
                'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W',
                'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
                'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
                't', 'u', 'v', 'w', 'x', 'y', 'z'
            };
            if (b > letters.Length || b < 2)
                throw new ArgumentOutOfRangeException("b", b, "Not enough characters to properly convert");

            int counter = 0;
            while (number > 0)
            {
                if (counter++ >= 3)
                {
                    counter -= 3;
                    result = ',' + result;
                }
                int temp = (int)(number % b);
                result = letters[temp] + result;
                number /= b;
            }
            return result;
        }
    }
}

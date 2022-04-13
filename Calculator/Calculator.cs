using System.Diagnostics;
using System.Windows.Forms;
namespace Calculator
{
    public partial class Calculator : Form
    {
        
        private decimal Loperand = 0;
        private decimal Roperand = 0;
        private string operation = "=";
        private bool IsNewNum = false;
        
        public Calculator()
        {
            InitializeComponent();
            NumberBox.TextAlign = ContentAlignment.MiddleRight;
            OperationBox.TextAlign= ContentAlignment.MiddleRight;
            KeyPreview = true;
           // CalculatorTab.SelectedIndexChanged += CalculatorTab_SelectedIndexChanged;
        }

    

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                equal.PerformClick();
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }



        private void Num0_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                NumberBox.Text = "0";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if(OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }

            if (NumberBox.Text != "0")
            {
                NumberBox.Text += "0";
            }
            
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                NumberBox.Text = "1";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            if(NumberBox.Text != "0")
            NumberBox.Text += "1";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                NumberBox.Text = "2";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            if (NumberBox.Text != "0")
                NumberBox.Text += "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                NumberBox.Text = "3";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            if (NumberBox.Text != "0")
                NumberBox.Text += "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                NumberBox.Text = "4";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            if (NumberBox.Text != "0")
                NumberBox.Text += "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                NumberBox.Text = "5";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            if (NumberBox.Text != "0")
                NumberBox.Text += "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                NumberBox.Text = "6";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            if (NumberBox.Text != "0")
                NumberBox.Text += "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                NumberBox.Text = "7";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            if (NumberBox.Text != "0")
                NumberBox.Text += "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                NumberBox.Text = "8";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            if (NumberBox.Text != "0")
                NumberBox.Text += "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                NumberBox.Text = "9";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            if (NumberBox.Text != "0")
                NumberBox.Text += "9";
        }

        private void Point_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            
            if (NumberBox.Text =="")
            {
                NumberBox.Text = "0.";
            }
            else
            {
                if (!NumberBox.Text.Contains('.'))
                {

                    NumberBox.Text += ".";
                }
            }

        }

        private void Plus_Click(object sender, EventArgs e)
        {
            
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                IsNewNum = true;
                return;
            }
            
            if (NumberBox.Text == "" && OperationBox.Text == "")
            {
                return;
            }else if (IsNewNum==true && OperationBox.Text !="" )
            {
                Loperand = decimal.Parse(NumberBox.Text);
                operation = "+";
                OperationBox.Text = $"{Normalize(Loperand)} {operation}";
            }else if (NumberBox.Text != "")
            {
                IsNewNum = true;
                if (operation == "=")
                {
                    Loperand = Normalize(decimal.Parse(NumberBox.Text));
                    operation = "+";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }else if (operation == "+")
                {
                    Loperand = Normalize(Loperand + decimal.Parse(NumberBox.Text));
                    operation = "+";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "-")
                {
                    Loperand = Normalize(Loperand - decimal.Parse(NumberBox.Text));
                    operation = "+";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "¡¿")
                {
                    Loperand = Normalize(Loperand * decimal.Parse(NumberBox.Text));
                    operation = "+";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "¡À")
                {
                    if (decimal.Parse(NumberBox.Text) == 0)
                    {
                        NumberBox.Text = "Can't divide by 0";
                        return;
                    }
                    Loperand = Normalize(Loperand / decimal.Parse(NumberBox.Text));
                    operation = "+";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            IsNewNum = true;
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                IsNewNum = true;
                return;
            }
            if (NumberBox.Text == "" && OperationBox.Text == "")
            {
                return;
            }
            else if (IsNewNum == true && OperationBox.Text != "")
            {
                Loperand = decimal.Parse(NumberBox.Text);
                operation = "-";
                OperationBox.Text = $"{Normalize(Loperand)} {operation}";
            }
            else if (NumberBox.Text != "")
            {
                IsNewNum = true;
                if (operation == "=")
                {
                    Loperand = Normalize(decimal.Parse(NumberBox.Text));
                    operation = "-";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "+")
                {
                    Loperand = Normalize(Loperand + decimal.Parse(NumberBox.Text));
                    operation = "-";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "-")
                {
                    Loperand = Normalize(Loperand - decimal.Parse(NumberBox.Text));
                    operation = "-";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "¡¿")
                {
                    Loperand = Normalize(Loperand * decimal.Parse(NumberBox.Text));
                    operation = "-";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "¡À")
                {
                    if (decimal.Parse(NumberBox.Text) == 0)
                    {
                        NumberBox.Text = "Can't divide by 0";
                        return;
                    }
                    Loperand = Normalize(Loperand / decimal.Parse(NumberBox.Text));
                    operation = "-";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                IsNewNum = true;
                return;
            }
            if (NumberBox.Text == "" && OperationBox.Text == "")
            {
                return;
            }
            else if (IsNewNum = true && OperationBox.Text != "")
            {
                Loperand = decimal.Parse(NumberBox.Text);
                operation = "¡¿";
                OperationBox.Text = $"{Normalize(Loperand)} {operation}";
            }
            else if (NumberBox.Text != "")
            {
                IsNewNum = true;
                if (operation == "=")
                {
                    Loperand = Normalize(decimal.Parse(NumberBox.Text));
                    operation = "¡¿";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "+")
                {
                    Loperand = Normalize(Loperand + decimal.Parse(NumberBox.Text));
                    operation = "¡¿";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "-")
                {
                    Loperand = Normalize(Loperand - decimal.Parse(NumberBox.Text));
                    operation = "¡¿";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "¡¿")
                {
                    Loperand = Normalize(Loperand * decimal.Parse(NumberBox.Text));
                    operation = "¡¿";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "¡À")
                {
                    if (decimal.Parse(NumberBox.Text) == 0)
                    {
                        NumberBox.Text = "Can't divide by 0";
                        return;
                    }
                    Loperand = Normalize(Loperand / decimal.Parse(NumberBox.Text));
                    operation = "¡¿";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                IsNewNum = true;
                return;
            }
            if (NumberBox.Text == "" && OperationBox.Text == "")
            {
                return;
            }
            else if (IsNewNum = true&& OperationBox.Text != "")
            {
                Loperand = decimal.Parse(NumberBox.Text);
                operation = "¡À";
                OperationBox.Text = $"{Normalize(Loperand)} {operation}";
            }
            else if (NumberBox.Text != "")
            {
                IsNewNum = true;
                if (operation == "=")
                {
                    Loperand = Normalize(decimal.Parse(NumberBox.Text));
                    operation = "¡À";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "+")
                {
                    Loperand = Normalize(Loperand + decimal.Parse(NumberBox.Text));
                    operation = "¡À";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "-")
                {
                    Loperand = Normalize(Loperand - decimal.Parse(NumberBox.Text));
                    operation = "¡À";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "¡¿")
                {
                    Loperand = Normalize(Loperand * decimal.Parse(NumberBox.Text));
                    operation = "¡À";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "¡À")
                {
                    if (decimal.Parse(NumberBox.Text) == 0)
                    {
                        NumberBox.Text = "Can't divide by 0";
                        return;
                    }
                    Loperand = Normalize(Loperand / decimal.Parse(NumberBox.Text));
                    operation = "¡À";
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            IsNewNum = true;
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                return;
            }
            if (NumberBox.Text == "")
            {
                return;
            }else if (NumberBox.Text != "")
            {
                if (operation == "=")
                {
                    Loperand = Normalize(decimal.Parse(NumberBox.Text));
                    OperationBox.Text = $"{Normalize(Loperand)} {operation}";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "+")
                {
                    Roperand = Normalize(decimal.Parse(NumberBox.Text));
                    OperationBox.Text = $"{Normalize(Loperand)} {operation} {Roperand} =";
                    Loperand = Normalize(Loperand + Roperand);
                    operation = "=";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "-")
                {
                    Roperand = Normalize(decimal.Parse(NumberBox.Text));
                    OperationBox.Text = $"{Normalize(Loperand)} {operation} {Roperand} =";
                    Loperand = Normalize(Loperand - Roperand);
                    operation = "=";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "¡¿")
                {
                    Roperand = Normalize(decimal.Parse(NumberBox.Text));
                    OperationBox.Text = $"{Normalize(Loperand)} {operation} {Roperand} =";
                    Loperand = Normalize(Loperand * Roperand);
                    operation = "=";
                    NumberBox.Text = $"{Loperand}";
                }
                else if (operation == "¡À")
                {
                    if (decimal.Parse(NumberBox.Text) == 0)
                    {
                        NumberBox.Text = "Can't divide by 0";
                        return;
                    }
                    Roperand = Normalize(decimal.Parse(NumberBox.Text));
                    OperationBox.Text = $"{Normalize(Loperand)} {operation} {Roperand} =";
                    Loperand = Normalize(Loperand / Roperand);
                    operation = "=";
                    NumberBox.Text = $"{Loperand}";
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            IsNewNum = true;

            OperationBox.Text = "";
            NumberBox.Text = "";
            Loperand = 0;
            Roperand = 0;
            operation = "=";
           
        }

        private void Opposite_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text == "")
            {
                return;
            }
            IsNewNum = true;
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                return;
            }

            if (NumberBox.Text == "0")
                return;

            decimal temp = decimal.Parse(NumberBox.Text);
            NumberBox.Text = $"{-temp}";
            operation = "=";
        }

        private void square_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text == "")
            {
                return;
            }
            IsNewNum = true;
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                return;
            }
            var x = decimal.Parse(NumberBox.Text);
            OperationBox.Text = $"Sqr({x}) =";
            NumberBox.Text = $"{x * x}";
            operation = "=";
        }

        private void reciprocal_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text == "")
            {
                return;
            }
            IsNewNum = true;
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC" || NumberBox.Text =="")
            {
                Reset.PerformClick();
                return;
            }

            if (NumberBox.Text == "0")
            {
                NumberBox.Text = "Can't divide by 0";
                return;
            }
            var x = decimal.Parse(NumberBox.Text);

            OperationBox.Text = $"1 / {x} =";
            NumberBox.Text = $"{1 / x}";
            operation = "=";
        }

        private void Root_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text == "")
            {
                return;
            }
            IsNewNum = true;
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                Reset.PerformClick();
                return;
            }
            double x = double.Parse(NumberBox.Text);
            OperationBox.Text = $"¡î({x}) =";
            NumberBox.Text = $"{Math.Sqrt(x)}";
            operation = "=";
        }
        private void Bin_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text == "")
            {
                return;
            }
            if (NumberBox.Text == "Error" || NumberBox.Text== "Can't divide by 0" || NumberBox.Text == "0")
            {
                Reset.PerformClick();
                return;
            }

            if (OperationBox.Text == "BIN")
            {
                return;
            }

           

            if (OperationBox.Text == "LOC")
            {
                // using ASCII code 
                int lengh = NumberBox.Text.Length;
                string temp = NumberBox.Text.ToString();
                NumberBox.Text = "";
                double result = 0;


                for (int i = lengh - 1; i >= 0; i--)
                {
                    int pow = (int)temp[i] - 97;
                    result += Math.Pow(2, pow);
                }
                NumberBox.Text = ConvertDecToBin(result).ToString();
                
                OperationBox.Text = "BIN";
            }
            else
            {
                if (NumberBox.Text.Contains('.') || decimal.Parse(NumberBox.Text) < 0)
                {
                    NumberBox.Text = "Error";
                    return;
                }
                double num = double.Parse(NumberBox.Text);
                NumberBox.Text = ConvertDecToBin(num).ToString();
                
                OperationBox.Text = "BIN";
            }
            
          
        }

        private void Dec_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text == "")
            {
                return;
            }
            if (NumberBox.Text == "Error" || NumberBox.Text == "Can't divide by 0" || NumberBox.Text == "0")
            {
                NumberBox.Text = "0";
                return;
            }

            if (NumberBox.Text.Any(i => char.IsLetter(i)))
            {
                int lengh = NumberBox.Text.Length;
                string temp = NumberBox.Text.ToString();
                double result = 0;


                for (int i = lengh - 1; i >= 0; i--)
                {
                    int pow = (int)temp[i] - 97;
                    result += Math.Pow(2, pow);
                }
                NumberBox.Text = result.ToString();
                OperationBox.Text = "";
            }
            else if (NumberBox.Text.Contains('.') || decimal.Parse(NumberBox.Text) < 0)
            {
                NumberBox.Text = "Error";

            }
            else
            {
               
                double Dec = 0;
                for (int i = 0; i < NumberBox.Text.Length; i++)
                {
                    Dec += double.Parse(NumberBox.Text[NumberBox.Text.Length - 1 - i].ToString())* Math.Pow(2, i);
                }
                NumberBox.Text = Dec.ToString();
                OperationBox.Text = "";
            }
        }

        private void Loc_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text == "")
            {
                return;
            }
            if (OperationBox.Text == "LOC")
            {
                return;
            }

            if (NumberBox.Text.Any(i => char.IsLetter(i)) || NumberBox.Text=="0")
            {
                NumberBox.Text = "0";
                return;
            }

            if (NumberBox.Text.Contains('.') || decimal.Parse(NumberBox.Text) < 0)
            {
                NumberBox.Text = "Error";

            }else if(OperationBox.Text == "BIN")
            {
                var length = NumberBox.Text.Count();
                var BinString = NumberBox.Text;
                NumberBox.Text = "";
                for (int i = 0; i < length; i++)
                {
                    if (BinString[i] == '1')
                    {
                        NumberBox.Text += (char)(length - 1 - i + 97);
                    }
                }
                var charArr = NumberBox.Text.ToCharArray();
                Array.Reverse(charArr);
                NumberBox.Text = new String(charArr);
                
                OperationBox.Text = "LOC";
            }
            else
            {
                double num = double.Parse(NumberBox.Text);
                NumberBox.Text = "";
                int maxExponent = 0;

                while (Math.Pow(2, maxExponent) <= num)
                {
                    maxExponent++;
                }

                for (int i = maxExponent - 1; i >= 0; i--)
                {
                    if (num >= Math.Pow(2, i))
                    {
                        num = num - Math.Pow(2, i);
                        int ascii = i + 97;
                        NumberBox.Text += $"{(char)ascii}";
                    }
                    
                }
                var charArr = NumberBox.Text.ToCharArray();
                if (charArr.All(a=> char.IsLetter(a)))
                {
                    Array.Reverse(charArr);
                    NumberBox.Text = new String(charArr);
                    
                    OperationBox.Text = "LOC";
                }else
                {
                    OperationBox.Text = "";
                    NumberBox.Text = "Error";
                }
            }
        }


        private double ConvertDecToBin(double num)
        {
            string BinString = "";
            double result = 0;
            int maxExponent = 0;

            while (Math.Pow(2, maxExponent) <= num)
            {
                maxExponent++;
            }

            for (int i = maxExponent - 1; i >= 0; i--)
            {
                if (num >= Math.Pow(2, i))
                {
                    num = num - Math.Pow(2, i);
                    BinString += "1";
                }
                else
                {
                    BinString += "0";
                }
            }
            result = double.Parse(BinString);
            return result;
        }
        private decimal Normalize(decimal value)
        {
            return value / 1.000000000000000000000000000000000m;
        }
        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    return;                
            //}
            switch (e.KeyCode)
            {
                case Keys.D0:
                    Num0.PerformClick();
                    break;
                case Keys.D1:
                    Num1.PerformClick();
                    break;
                case Keys.D2:
                    Num2.PerformClick();
                    break;
                case Keys.D3:
                    Num3.PerformClick();
                    break;
                case Keys.D4:
                    Num4.PerformClick();
                    break;
                case Keys.D5:
                    Num5.PerformClick();
                    break;
                case Keys.D6:
                    Num6.PerformClick();
                    break;
                case Keys.D7:
                    Num7.PerformClick();
                    break;
                case Keys.D8:
                    Num8.PerformClick();
                    break;
                case Keys.D9:
                    Num9.PerformClick();
                    break;
                case Keys.NumPad0:
                    Num0.PerformClick();
                    break;
                case Keys.NumPad1:
                    Num1.PerformClick();
                    break;
                case Keys.NumPad2:
                    Num2.PerformClick();
                    break;
                case Keys.NumPad3:
                    Num3.PerformClick();
                    break;
                case Keys.NumPad4:
                    Num4.PerformClick();
                    break;
                case Keys.NumPad5:
                    Num5.PerformClick();
                    break;
                case Keys.NumPad6:
                    Num6.PerformClick();
                    break;
                case Keys.NumPad7:
                    Num7.PerformClick();
                    break;
                case Keys.NumPad8:
                    Num8.PerformClick();
                    break;
                case Keys.NumPad9:
                    Num9.PerformClick();
                    break;
                case Keys.Add:
                    Plus.PerformClick();
                    break;
                case Keys.Subtract:
                    Minus.PerformClick();
                    break;
                case Keys.Multiply:
                    Multiply.PerformClick();
                    break;
                case Keys.Divide:
                    Divide.PerformClick();
                    break;
                case Keys.Decimal:
                    Point.PerformClick();
                    break;
                case Keys.Enter:
                    equal.PerformClick();
                    break;
                default:
                    break;

            }
        }

        private void CalculatorTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    Decimal.PerformClick();
                    break;
                case 1:
                    Bin_NumberBox.PerformClick();
                    Bin_NumberBox.Text = NumberBox.Text;
                    Bin_Operation.Text = OperationBox.Text;
                    break;
                case 2:
                    Loc_NumberBox.PerformClick();
                    Loc_NumberBox.Text= NumberBox.Text;
                    Loc_Operation.Text = OperationBox.Text;
                    break;
            }
        }

        private void Bin_NumberBox_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text == "")
            {
                return;
            }
            if (NumberBox.Text == "Error" || NumberBox.Text == "Can't divide by 0" || NumberBox.Text == "0")
            {
                Reset.PerformClick();
                return;
            }

            if (OperationBox.Text == "BIN")
            {
                return;
            }



            if (OperationBox.Text == "LOC")
            {
                // using ASCII code 
                int lengh = NumberBox.Text.Length;
                string temp = NumberBox.Text.ToString();
                NumberBox.Text = "";
                double result = 0;


                for (int i = lengh - 1; i >= 0; i--)
                {
                    int pow = (int)temp[i] - 97;
                    result += Math.Pow(2, pow);
                }
                
                NumberBox.Text = ConvertDecToBin(result).ToString();
                OperationBox.Text = "BIN";
            }
            else
            {
                if (NumberBox.Text.Contains('.') || decimal.Parse(NumberBox.Text) < 0)
                {
                    NumberBox.Text = "Error";
                    return;
                }
                double num = double.Parse(NumberBox.Text);
                
                NumberBox.Text = ConvertDecToBin(num).ToString();
                OperationBox.Text = "BIN";
            }
        }

        private void Loc_NumberBox_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text == "")
            {
                return;
            }
            if (OperationBox.Text == "LOC")
            {
                return;
            }

            if (NumberBox.Text.Any(i => char.IsLetter(i)) || NumberBox.Text == "0")
            {
                NumberBox.Text = "0";
                return;
            }

            if (NumberBox.Text.Contains('.') || decimal.Parse(NumberBox.Text) < 0)
            {
                NumberBox.Text = "Error";

            }
            else if (OperationBox.Text == "BIN")
            {
                var length = NumberBox.Text.Count();
                var BinString = NumberBox.Text;
                NumberBox.Text = "";
                for (int i = 0; i < length; i++)
                {
                    if (BinString[i] == '1')
                    {
                        NumberBox.Text += (char)(length - 1 - i + 97);
                    }
                }
                var charArr = NumberBox.Text.ToCharArray();
                Array.Reverse(charArr);
                NumberBox.Text = new String(charArr);

                OperationBox.Text = "LOC";
            }
            else
            {
                double num = double.Parse(NumberBox.Text);
                NumberBox.Text = "";
                int maxExponent = 0;

                while (Math.Pow(2, maxExponent) <= num)
                {
                    maxExponent++;
                }

                for (int i = maxExponent - 1; i >= 0; i--)
                {
                    if (num >= Math.Pow(2, i))
                    {
                        num = num - Math.Pow(2, i);
                        int ascii = i + 97;
                        NumberBox.Text += $"{(char)ascii}";
                    }

                }
                var charArr = NumberBox.Text.ToCharArray();
                if (charArr.All(a => char.IsLetter(a)))
                {
                    Array.Reverse(charArr);
                    NumberBox.Text = new String(charArr);

                    OperationBox.Text = "LOC";
                }
                else
                {
                    OperationBox.Text = "";
                    NumberBox.Text = "Error";
                }
            }
        }


        /////Tab

    }
}
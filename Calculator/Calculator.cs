namespace Calculator
{
    public partial class Calculator : Form
    {
        private string input = "0";
        private decimal Loperand = 0;
        private decimal Roperand = 0;
        private string operation = "=";
        private bool IsNewNum = false;
        public Calculator()
        {
            InitializeComponent();
            NumberBox.TextAlign = HorizontalAlignment.Right;
            OperationBox.TextAlign = HorizontalAlignment.Right;
            NumberBox.Text = "";
        }





        private void Num0_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
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
                NumberBox.Text = "1";
                OperationBox.Text = "";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            NumberBox.Text += "1";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "2";
                OperationBox.Text = "";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            NumberBox.Text += "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "3";
                OperationBox.Text = "";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            NumberBox.Text += "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "4";
                OperationBox.Text = "";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            NumberBox.Text += "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "5";
                OperationBox.Text = "";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            NumberBox.Text += "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "6";
                OperationBox.Text = "";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            NumberBox.Text += "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "7";
                OperationBox.Text = "";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            NumberBox.Text += "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "8";
                OperationBox.Text = "";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            NumberBox.Text += "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "9";
                OperationBox.Text = "";
                return;
            }
            if (IsNewNum == true)
            {
                NumberBox.Text = "";
                IsNewNum = false;
                if (OperationBox.Text.Contains("="))
                    OperationBox.Text = "";
            }
            NumberBox.Text += "9";
        }

        private void Point_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
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
            IsNewNum = true;
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "";
                OperationBox.Text = "";
                return;
            }
            IsNewNum=true;
            if (NumberBox.Text == "" && OperationBox.Text == "")
            {
                return;
            }else if (NumberBox.Text == "" && OperationBox.Text !="")
            {
                operation = "+";
                OperationBox.Text = $"{Normalize(Loperand)} {operation}";
            }else if (NumberBox.Text != "")
            {
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
                NumberBox.Text = "";
                OperationBox.Text = "";
                return;
            }
            if (NumberBox.Text == "" && OperationBox.Text == "")
            {
                return;
            }
            else if (NumberBox.Text == "" && OperationBox.Text != "")
            {
                operation = "-";
                OperationBox.Text = $"{Normalize(Loperand)} {operation}";
            }
            else if (NumberBox.Text != "")
            {
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
            IsNewNum = true;
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "";
                OperationBox.Text = "";
                return;
            }
            if (NumberBox.Text == "" && OperationBox.Text == "")
            {
                return;
            }
            else if (NumberBox.Text == "" && OperationBox.Text != "")
            {
                operation = "¡¿";
                OperationBox.Text = $"{Normalize(Loperand)} {operation}";
            }
            else if (NumberBox.Text != "")
            {
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
            IsNewNum = true;
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "";
                OperationBox.Text = "";
                return;
            }
            if (NumberBox.Text == "" && OperationBox.Text == "")
            {
                return;
            }
            else if (NumberBox.Text == "" && OperationBox.Text != "")
            {
                operation = "¡À";
                OperationBox.Text = $"{Normalize(Loperand)} {operation}";
            }
            else if (NumberBox.Text != "")
            {
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
                NumberBox.Text = "";
                OperationBox.Text = "";
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
            IsNewNum = true;
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }

            if (NumberBox.Text == "0")
                return;

            decimal temp = decimal.Parse(NumberBox.Text);
            NumberBox.Text = $"{-temp}";
        }

        private void square_Click(object sender, EventArgs e)
        {
            IsNewNum = true;
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }
            var x = decimal.Parse(NumberBox.Text);
            OperationBox.Text = $"Sqr({x}) =";
            NumberBox.Text = $"{x * x}";
        }

        private void reciprocal_Click(object sender, EventArgs e)
        {
            IsNewNum = true;
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
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
        }

        private void Root_Click(object sender, EventArgs e)
        {
            IsNewNum = true;
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }
            double x = double.Parse(NumberBox.Text);
            OperationBox.Text = $"¡î({x}) =";
            NumberBox.Text = $"{Math.Sqrt(x)}";
        }
        private void Bin_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text == "Error" || NumberBox.Text== "Can't divide by 0" || NumberBox.Text == "0")
            {
                NumberBox.Text = "0";
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
                Array.Reverse(charArr);
                NumberBox.Text =  new String(charArr);
                OperationBox.Text = "LOC";
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

       

        
    }
}
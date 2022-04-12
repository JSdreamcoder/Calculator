namespace Calculator
{
    public partial class Calculator : Form
    {
        private string input = "0";
        
        public Calculator()
        {
            InitializeComponent();
            NumberBox.TextAlign = HorizontalAlignment.Right;
            OperationBox.TextAlign = HorizontalAlignment.Right;
            NumberBox.Text = "0";
        }





        private void Num0_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }
                

            if (OperationBox.Text.Split(' ').Count() == 4)
            {
                OperationBox.Text = "";
                input = "0";
                NumberBox.Text = input;
            }
            if (input =="0")
            {
                NumberBox.Text = input;
            }
            else
            {
                input += "0";
                NumberBox.Text = input;
            }
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }

            if (OperationBox.Text.Split(' ').Count() == 4)
            {
                OperationBox.Text = "";
            }
            if (input == "0")
            {
                input = "1";
                NumberBox.Text = input;
            }
            else
            {
                input += "1";
                NumberBox.Text = input;
            }
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }

            if (OperationBox.Text.Split(' ').Count() == 4)
            {
                OperationBox.Text = "";
            }
            if (input == "0")
            {
                input = "2";
                NumberBox.Text = input;
            }
            else
            {
                input += "2";
                NumberBox.Text = input;
            }
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }

            if (OperationBox.Text.Split(' ').Count() == 4)
            {
                OperationBox.Text = "";
            }
            if (input == "0")
            {
                input = "3";
                NumberBox.Text = input;
            }
            else
            {
                input += "3";
                NumberBox.Text = input;
            }
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }

            if (OperationBox.Text.Split(' ').Count() == 4)
            {
                OperationBox.Text = "";
            }
            if (input == "0")
            {
                input = "4";
                NumberBox.Text = input;
            }
            else
            {
                input += "4";
                NumberBox.Text = input;
            }
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }

            if (OperationBox.Text.Split(' ').Count() == 4)
            {
                OperationBox.Text = "";
            }
            if (input == "0")
            {
                input = "5";
                NumberBox.Text = input;
            }
            else
            {
                input += "5";
                NumberBox.Text = input;
            }
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }

            if (OperationBox.Text.Split(' ').Count() == 4)
            {
                OperationBox.Text = "";
            }
            if (input == "0")
            {
                input = "6";
                NumberBox.Text = input;
            }
            else
            {
                input += "6";
                NumberBox.Text = input;
            }
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }

            if (OperationBox.Text.Split(' ').Count() == 4)
            {
                OperationBox.Text = "";
            }
            if (input == "0")
            {
                input = "7";
                NumberBox.Text = input;
            }
            else
            {
                input += "7";
                NumberBox.Text = input;
            }
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }

            if (OperationBox.Text.Split(' ').Count() == 4)
            {
                OperationBox.Text = "";
            }
            if (input == "0")
            {
                input = "8";
                NumberBox.Text = input;
            }
            else
            {
                input += "8";
                NumberBox.Text = input;
            }
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }

            if (OperationBox.Text.Split(' ').Count() == 4)
            {
                OperationBox.Text = "";
            }
            if (input == "0")
            {
                input = "9";
                NumberBox.Text = input;
            }
            else
            {
                input += "9";
                NumberBox.Text = input;
            }
        }

        private void Point_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }

            if (OperationBox.Text.Split(' ').Count() == 4)
            {
                OperationBox.Text = "";
            }
            if (input == "0")
            {
                input = "0.";
                NumberBox.Text = input;
            }
            else
            {
                if (!input.Contains('.'))
                {
                  input += ".";
                  NumberBox.Text = input;
                }
            }

        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }

            Decimal num = decimal.Parse(NumberBox.Text);
           
            if (OperationBox.Text == "")
            {
                OperationBox.Text = $"{num} +";
                NumberBox.Text = $"{num}";
                
            }
            else if(OperationBox.Text.Split(' ').Count() == 2)
            {
                if (input == "0")
                    return;
                var storedOperand = decimal.Parse(OperationBox.Text.Split(' ')[0]);
                var storedOperation = OperationBox.Text.Split(' ')[1];
                if (num == 0)
                {
                    OperationBox.Text = $"{normalize(storedOperand + num) } +";
                    return;
                }
                if (storedOperation == "+")
                {
                   OperationBox.Text = $"{normalize(storedOperand + num) } +";
                   NumberBox.Text = $"{normalize(storedOperand + num)}";
                } 
                else if(storedOperation == "-")
                {
                    OperationBox.Text = $"{normalize(storedOperand - num) } +";
                    NumberBox.Text = $"{normalize(storedOperand - num)}";
                }
                else if (storedOperation == "x")
                {
                    OperationBox.Text = $"{normalize(storedOperand * num) } +";
                    NumberBox.Text = $"{normalize(storedOperand * num)}";
                }
                else if (storedOperation == "/")
                {
                    if (num == 0)
                    {
                        NumberBox.Text = "Can't divide by 0";
                        return;
                    }
                    OperationBox.Text = $"{normalize(storedOperand / num) } +";
                    NumberBox.Text = $"{normalize(storedOperand / num)}";
                }else if (storedOperation == "=")
                {
                    OperationBox.Text = $"{normalize(storedOperand)} +";
                    NumberBox.Text = $"{normalize(storedOperand)}";
                }
                
            }else if (OperationBox.Text.Split(' ').Count() ==4)
            {
                var previousNum = decimal.Parse(NumberBox.Text);
                OperationBox.Text = $"{normalize(previousNum)} +";
                NumberBox.Text = $"{normalize(previousNum)}";
            }
            input = "0";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }

            Decimal num = decimal.Parse(NumberBox.Text);
            
            if (OperationBox.Text == "")
            {
                OperationBox.Text = $"{num} -";
                NumberBox.Text = $"{num}";
                input = "0";
            }
            else if (OperationBox.Text.Split(' ').Count() == 2)
            {
                if (input == "0")
                    return;
                var storedOperand = decimal.Parse(OperationBox.Text.Split(' ')[0]);
                var storedOperation = OperationBox.Text.Split(' ')[1];
                if (num == 0)
                {
                    OperationBox.Text = $"{normalize(storedOperand + num) } -";
                    return;
                }
                if (storedOperation == "+")
                {
                    OperationBox.Text = $"{normalize(storedOperand + num) } -";
                    NumberBox.Text = $"{normalize(storedOperand + num)}";
                }
                else if (storedOperation == "-")
                {
                    OperationBox.Text = $"{normalize(storedOperand - num) } -";
                    NumberBox.Text = $"{normalize(storedOperand - num)}";
                }
                else if (storedOperation == "x")
                {
                    OperationBox.Text = $"{normalize(storedOperand * num) } -";
                    NumberBox.Text = $"{normalize(storedOperand * num)}";
                }
                else if (storedOperation == "/")
                {
                    if (num == 0)
                    {
                        NumberBox.Text = "Can't divide by 0";
                        return;
                    }
                    OperationBox.Text = $"{normalize(storedOperand / num) } -";
                    NumberBox.Text = $"{normalize(storedOperand / num)}";
                }
                else if (storedOperation == "=")
                {
                    OperationBox.Text = $"{normalize(storedOperand)} -";
                    NumberBox.Text = $"{normalize(storedOperand)}";
                }

            }
            else if (OperationBox.Text.Split(' ').Count() == 4)
            {
                var previousNum = decimal.Parse(NumberBox.Text);
                OperationBox.Text = $"{previousNum} -";
                NumberBox.Text = $"{previousNum}";
            }
            input = "0";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }

            Decimal num = decimal.Parse(NumberBox.Text);
           
            if (OperationBox.Text == "")
            {
                OperationBox.Text = $"{num} x";
                NumberBox.Text = $"{num}";
            }
            else if (OperationBox.Text.Split(' ').Count() == 2)
            {
                if (input == "0")
                    return;
                var storedOperand = decimal.Parse(OperationBox.Text.Split(' ')[0]);
                var storedOperation = OperationBox.Text.Split(' ')[1];
                if (num == 0)
                {
                    OperationBox.Text = $"{normalize(storedOperand + num) } x";
                    return;
                }
                if (storedOperation == "+")
                {
                    OperationBox.Text = $"{normalize(storedOperand + num) } x";
                    NumberBox.Text = $"{normalize(storedOperand + num)}";
                }
                else if (storedOperation == "-")
                {
                    OperationBox.Text = $"{normalize(storedOperand - num) } x";
                    NumberBox.Text = $"{normalize(storedOperand - num)}";
                }
                else if (storedOperation == "x")
                {
                    OperationBox.Text = $"{normalize(storedOperand * num) } x";
                    NumberBox.Text = $"{normalize(storedOperand * num)}";
                }
                else if (storedOperation == "/")
                {
                    if (num == 0)
                    {
                        NumberBox.Text = "Can't divide by 0";
                        return;
                    }
                    OperationBox.Text = $"{normalize(storedOperand / num) } x";
                    NumberBox.Text = $"{normalize(storedOperand / num)}";
                }
                else if (storedOperation == "=")
                {
                    OperationBox.Text = $"{normalize(storedOperand)} x";
                    NumberBox.Text = $"{normalize(storedOperand)}";
                }

            }
            else if (OperationBox.Text.Split(' ').Count() == 4)
            {
                var previousNum = decimal.Parse(NumberBox.Text);
                OperationBox.Text = $"{normalize(previousNum)} x";
                NumberBox.Text = $"{normalize(previousNum)}";
            }
            input = "0";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }

            Decimal num = decimal.Parse(NumberBox.Text);
           
            if (OperationBox.Text == "")
            {
                OperationBox.Text = $"{num} /";
                NumberBox.Text = $"{num}";
                input = "0";
            }
            else if (OperationBox.Text.Split(' ').Count() == 2)
            {
                if (input == "0")
                    return;
                var storedOperand = decimal.Parse(OperationBox.Text.Split(' ')[0]);
                var storedOperation = OperationBox.Text.Split(' ')[1];
                if (num == 0)
                {
                    OperationBox.Text = $"{normalize(storedOperand) } /";
                    return;
                }
                if (storedOperation == "+")
                {
                    OperationBox.Text = $"{normalize(storedOperand + num )} /";
                    NumberBox.Text = $"{normalize(storedOperand + num)}";
                }
                else if (storedOperation == "-")
                {
                    OperationBox.Text = $"{normalize(storedOperand - num) } /";
                    NumberBox.Text = $"{normalize(storedOperand - num)}";
                }
                else if (storedOperation == "x")
                {
                    OperationBox.Text = $"{normalize(storedOperand * num) } /";
                    NumberBox.Text = $"{normalize(storedOperand * num)}";
                }
                else if (storedOperation == "/")
                {
                    if (num == 0)
                    {
                        NumberBox.Text = "Can't divide by 0";
                        return;
                    }
                    OperationBox.Text = $"{normalize(storedOperand / num) } /";
                    NumberBox.Text = $"{normalize(storedOperand / num)}";
                }
                else if (storedOperation == "=")
                {
                    OperationBox.Text = $"{normalize(storedOperand)} /";
                    NumberBox.Text = $"{normalize(storedOperand)}";
                }

            }
            else if (OperationBox.Text.Split(' ').Count() == 4)
            {
                var previousNum = decimal.Parse(NumberBox.Text);
                OperationBox.Text = $"{previousNum} /";
                NumberBox.Text = $"{previousNum}";
              
            }
            input = "0";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }

            Decimal num = decimal.Parse(NumberBox.Text);
           
            if (OperationBox.Text == "")
            {
                OperationBox.Text = $"{num} =";
                NumberBox.Text = $"{num}";
                
            }
            else if(OperationBox.Text.Split(' ').Count() ==2)
            {
                var storedOperand = decimal.Parse(OperationBox.Text.Split(' ')[0]);
                var storedOperation = OperationBox.Text.Split(' ')[1];
                
                if (storedOperation == "+")
                {
                    OperationBox.Text = $"{storedOperand} + {num} =";
                    NumberBox.Text = $"{normalize(storedOperand + num)}";
                }
                else if (storedOperation == "-")
                {
                    OperationBox.Text = $"{storedOperand} - {num} =";
                    NumberBox.Text = $"{normalize(storedOperand - num)}";
                }
                else if (storedOperation == "x")
                {
                    OperationBox.Text = $"{storedOperand} x {num} =";
                    NumberBox.Text = $"{normalize(storedOperand * num)}";
                }
                else if (storedOperation == "/")
                {
                    if (num == 0)
                    {
                        NumberBox.Text = "Can't divide by 0";
                        return;
                    }
                    OperationBox.Text = $"{storedOperand} / {num} =";
                    NumberBox.Text = $"{normalize(storedOperand / num)}";
                }
                
            }
            else if (OperationBox.Text.Split(' ').Count() == 4)
            {
                var storedOperand = decimal.Parse(OperationBox.Text.Split(' ')[0]);
                var storedOperation = OperationBox.Text.Split(' ')[1];
                var storedOperand2 = decimal.Parse(OperationBox.Text.Split(' ')[2]);

                if (storedOperation == "+")
                {
                    OperationBox.Text = $"{num} + {storedOperand2} =";
                    NumberBox.Text = $"{normalize(num + storedOperand2)}";
                }
                else if (storedOperation == "-")
                {
                    OperationBox.Text = $"{num} - {storedOperand2} =";
                    NumberBox.Text = $"{normalize(num - storedOperand2)}";
                }
                else if (storedOperation == "x")
                {
                    OperationBox.Text = $"{num} x {storedOperand2} =";
                    NumberBox.Text = $"{normalize(num *storedOperand)}";
                }
                else if (storedOperation == "/")
                {
                    if (num == 0)
                    {
                        NumberBox.Text = "Can't divide by 0";
                        return;
                    }
                    OperationBox.Text = $"{num} / {storedOperand2} =";
                    NumberBox.Text = $"{normalize(num / storedOperand2) }";
                }
            }
            input = "0";
        }

        private void Reset_Click(object sender, EventArgs e)
        {
          
            input = "0";
            OperationBox.Text = "";
            NumberBox.Text = "0";
           
        }

        private void Opposite_Click(object sender, EventArgs e)
        {
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
            if (NumberBox.Text.Any(i => char.IsLetter(i)) || OperationBox.Text == "BIN" || OperationBox.Text == "LOC")
            {
                NumberBox.Text = "0";
                OperationBox.Text = "";
                return;
            }
            var x = decimal.Parse(NumberBox.Text);
            OperationBox.Text = $"{x} x {x} =";
            NumberBox.Text = $"{x * x}";
        }

        private void reciprocal_Click(object sender, EventArgs e)
        {
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
        private decimal normalize(decimal value)
        {
            return value / 1.000000000000000000000000000000000m;
        }

        //private void Calculator_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
        //    {
        //        NumberBox.Text = "success";
        //    }
        //}


    }
}
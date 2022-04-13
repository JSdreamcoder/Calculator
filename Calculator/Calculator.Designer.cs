namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button Opposite;
            this.Divide = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.reciprocal = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.Binary = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.Location = new System.Windows.Forms.Button();
            this.Root = new System.Windows.Forms.Button();
            this.NumberBox = new System.Windows.Forms.Button();
            this.OperationBox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CalculatorTab = new System.Windows.Forms.TabControl();
            this.DecTab = new System.Windows.Forms.TabPage();
            this.BinTab = new System.Windows.Forms.TabPage();
            this.Bin_NumberBox = new System.Windows.Forms.Button();
            this.Bin_Operation = new System.Windows.Forms.Button();
            this.LocTab = new System.Windows.Forms.TabPage();
            this.Loc_NumberBox = new System.Windows.Forms.Button();
            this.Loc_Operation = new System.Windows.Forms.Button();
            Opposite = new System.Windows.Forms.Button();
            this.CalculatorTab.SuspendLayout();
            this.DecTab.SuspendLayout();
            this.BinTab.SuspendLayout();
            this.LocTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Opposite
            // 
            Opposite.Location = new System.Drawing.Point(121, 402);
            Opposite.Name = "Opposite";
            Opposite.Size = new System.Drawing.Size(84, 45);
            Opposite.TabIndex = 19;
            Opposite.Text = "+/-";
            Opposite.UseVisualStyleBackColor = true;
            Opposite.Click += new System.EventHandler(this.Opposite_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(391, 198);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(84, 45);
            this.Divide.TabIndex = 2;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Reset.Location = new System.Drawing.Point(121, 198);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(84, 45);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "C";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // reciprocal
            // 
            this.reciprocal.Location = new System.Drawing.Point(301, 198);
            this.reciprocal.Name = "reciprocal";
            this.reciprocal.Size = new System.Drawing.Size(84, 45);
            this.reciprocal.TabIndex = 4;
            this.reciprocal.Text = "1/x";
            this.reciprocal.UseVisualStyleBackColor = true;
            this.reciprocal.Click += new System.EventHandler(this.reciprocal_Click);
            // 
            // Num9
            // 
            this.Num9.Location = new System.Drawing.Point(301, 249);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(84, 45);
            this.Num9.TabIndex = 5;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = true;
            this.Num9.Click += new System.EventHandler(this.Num9_Click);
            // 
            // Num8
            // 
            this.Num8.Location = new System.Drawing.Point(211, 249);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(84, 45);
            this.Num8.TabIndex = 6;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = true;
            this.Num8.Click += new System.EventHandler(this.Num8_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(211, 198);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(84, 45);
            this.Square.TabIndex = 7;
            this.Square.Text = "x^2";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.square_Click);
            // 
            // Num7
            // 
            this.Num7.Location = new System.Drawing.Point(121, 249);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(84, 45);
            this.Num7.TabIndex = 8;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = true;
            this.Num7.Click += new System.EventHandler(this.Num7_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(391, 249);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(84, 45);
            this.Multiply.TabIndex = 9;
            this.Multiply.Text = "x";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Num4
            // 
            this.Num4.Location = new System.Drawing.Point(121, 300);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(84, 45);
            this.Num4.TabIndex = 10;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = true;
            this.Num4.Click += new System.EventHandler(this.Num4_Click);
            // 
            // Num5
            // 
            this.Num5.Location = new System.Drawing.Point(211, 300);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(84, 45);
            this.Num5.TabIndex = 11;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = true;
            this.Num5.Click += new System.EventHandler(this.Num5_Click);
            // 
            // Num6
            // 
            this.Num6.Location = new System.Drawing.Point(301, 300);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(84, 45);
            this.Num6.TabIndex = 12;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = true;
            this.Num6.Click += new System.EventHandler(this.Num6_Click);
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(211, 351);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(84, 45);
            this.Num2.TabIndex = 13;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = true;
            this.Num2.Click += new System.EventHandler(this.Num2_Click);
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(121, 351);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(84, 45);
            this.Num1.TabIndex = 14;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = true;
            this.Num1.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(391, 351);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(84, 45);
            this.Plus.TabIndex = 15;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Num3
            // 
            this.Num3.Location = new System.Drawing.Point(301, 351);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(84, 45);
            this.Num3.TabIndex = 16;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = true;
            this.Num3.Click += new System.EventHandler(this.Num3_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(391, 300);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(84, 45);
            this.Minus.TabIndex = 17;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Point
            // 
            this.Point.Location = new System.Drawing.Point(301, 402);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(84, 45);
            this.Point.TabIndex = 21;
            this.Point.Text = ".";
            this.Point.UseVisualStyleBackColor = true;
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.NavajoWhite;
            this.equal.Location = new System.Drawing.Point(391, 402);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(84, 45);
            this.equal.TabIndex = 20;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Num0
            // 
            this.Num0.Location = new System.Drawing.Point(211, 402);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(84, 45);
            this.Num0.TabIndex = 18;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = true;
            this.Num0.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Binary
            // 
            this.Binary.Location = new System.Drawing.Point(211, 147);
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(84, 45);
            this.Binary.TabIndex = 25;
            this.Binary.Text = "BIN";
            this.Binary.UseVisualStyleBackColor = true;
            this.Binary.Click += new System.EventHandler(this.Bin_Click);
            // 
            // Decimal
            // 
            this.Decimal.Location = new System.Drawing.Point(301, 147);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(84, 45);
            this.Decimal.TabIndex = 24;
            this.Decimal.Text = "DEC";
            this.Decimal.UseVisualStyleBackColor = true;
            this.Decimal.Click += new System.EventHandler(this.Dec_Click);
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(121, 147);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(84, 45);
            this.Location.TabIndex = 23;
            this.Location.Text = "LOC";
            this.Location.UseVisualStyleBackColor = true;
            this.Location.Click += new System.EventHandler(this.Loc_Click);
            // 
            // Root
            // 
            this.Root.Location = new System.Drawing.Point(391, 147);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(84, 45);
            this.Root.TabIndex = 22;
            this.Root.Text = "√x";
            this.Root.UseVisualStyleBackColor = true;
            this.Root.Click += new System.EventHandler(this.Root_Click);
            // 
            // NumberBox
            // 
            this.NumberBox.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberBox.Location = new System.Drawing.Point(121, 94);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(354, 47);
            this.NumberBox.TabIndex = 26;
            this.NumberBox.UseVisualStyleBackColor = true;
            // 
            // OperationBox
            // 
            this.OperationBox.Location = new System.Drawing.Point(121, 76);
            this.OperationBox.Name = "OperationBox";
            this.OperationBox.Size = new System.Drawing.Size(354, 23);
            this.OperationBox.TabIndex = 27;
            this.OperationBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(221, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Demo Calculator";
            // 
            // CalculatorTab
            // 
            this.CalculatorTab.Controls.Add(this.DecTab);
            this.CalculatorTab.Controls.Add(this.BinTab);
            this.CalculatorTab.Controls.Add(this.LocTab);
            this.CalculatorTab.Location = new System.Drawing.Point(12, 12);
            this.CalculatorTab.Name = "CalculatorTab";
            this.CalculatorTab.SelectedIndex = 0;
            this.CalculatorTab.Size = new System.Drawing.Size(619, 554);
            this.CalculatorTab.TabIndex = 29;
            this.CalculatorTab.SelectedIndexChanged += new System.EventHandler(this.CalculatorTab_SelectedIndexChanged);
            // 
            // DecTab
            // 
            this.DecTab.Controls.Add(this.OperationBox);
            this.DecTab.Controls.Add(this.label1);
            this.DecTab.Controls.Add(this.Divide);
            this.DecTab.Controls.Add(this.Reset);
            this.DecTab.Controls.Add(this.NumberBox);
            this.DecTab.Controls.Add(this.reciprocal);
            this.DecTab.Controls.Add(this.Binary);
            this.DecTab.Controls.Add(this.Num9);
            this.DecTab.Controls.Add(this.Decimal);
            this.DecTab.Controls.Add(this.Num8);
            this.DecTab.Controls.Add(this.Location);
            this.DecTab.Controls.Add(this.Square);
            this.DecTab.Controls.Add(this.Root);
            this.DecTab.Controls.Add(this.Num7);
            this.DecTab.Controls.Add(this.Point);
            this.DecTab.Controls.Add(this.Multiply);
            this.DecTab.Controls.Add(this.equal);
            this.DecTab.Controls.Add(this.Num4);
            this.DecTab.Controls.Add(Opposite);
            this.DecTab.Controls.Add(this.Num5);
            this.DecTab.Controls.Add(this.Num0);
            this.DecTab.Controls.Add(this.Num6);
            this.DecTab.Controls.Add(this.Minus);
            this.DecTab.Controls.Add(this.Num2);
            this.DecTab.Controls.Add(this.Num3);
            this.DecTab.Controls.Add(this.Num1);
            this.DecTab.Controls.Add(this.Plus);
            this.DecTab.Location = new System.Drawing.Point(4, 24);
            this.DecTab.Name = "DecTab";
            this.DecTab.Padding = new System.Windows.Forms.Padding(3);
            this.DecTab.Size = new System.Drawing.Size(611, 526);
            this.DecTab.TabIndex = 0;
            this.DecTab.Text = "DEC";
            this.DecTab.UseVisualStyleBackColor = true;
            // 
            // BinTab
            // 
            this.BinTab.Controls.Add(this.Bin_NumberBox);
            this.BinTab.Controls.Add(this.Bin_Operation);
            this.BinTab.Location = new System.Drawing.Point(4, 24);
            this.BinTab.Name = "BinTab";
            this.BinTab.Padding = new System.Windows.Forms.Padding(3);
            this.BinTab.Size = new System.Drawing.Size(611, 526);
            this.BinTab.TabIndex = 1;
            this.BinTab.Text = "BIN";
            this.BinTab.UseVisualStyleBackColor = true;
            // 
            // Bin_NumberBox
            // 
            this.Bin_NumberBox.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bin_NumberBox.Location = new System.Drawing.Point(135, 99);
            this.Bin_NumberBox.Name = "Bin_NumberBox";
            this.Bin_NumberBox.Size = new System.Drawing.Size(325, 47);
            this.Bin_NumberBox.TabIndex = 1;
            this.Bin_NumberBox.UseVisualStyleBackColor = true;
            this.Bin_NumberBox.Click += new System.EventHandler(this.Bin_NumberBox_Click);
            // 
            // Bin_Operation
            // 
            this.Bin_Operation.Location = new System.Drawing.Point(135, 79);
            this.Bin_Operation.Name = "Bin_Operation";
            this.Bin_Operation.Size = new System.Drawing.Size(325, 23);
            this.Bin_Operation.TabIndex = 0;
            this.Bin_Operation.UseVisualStyleBackColor = true;
            // 
            // LocTab
            // 
            this.LocTab.Controls.Add(this.Loc_NumberBox);
            this.LocTab.Controls.Add(this.Loc_Operation);
            this.LocTab.Location = new System.Drawing.Point(4, 24);
            this.LocTab.Name = "LocTab";
            this.LocTab.Padding = new System.Windows.Forms.Padding(3);
            this.LocTab.Size = new System.Drawing.Size(611, 526);
            this.LocTab.TabIndex = 2;
            this.LocTab.Text = "LOC";
            this.LocTab.UseVisualStyleBackColor = true;
            // 
            // Loc_NumberBox
            // 
            this.Loc_NumberBox.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Loc_NumberBox.Location = new System.Drawing.Point(133, 104);
            this.Loc_NumberBox.Name = "Loc_NumberBox";
            this.Loc_NumberBox.Size = new System.Drawing.Size(330, 43);
            this.Loc_NumberBox.TabIndex = 1;
            this.Loc_NumberBox.UseVisualStyleBackColor = true;
            this.Loc_NumberBox.Click += new System.EventHandler(this.Loc_NumberBox_Click);
            // 
            // Loc_Operation
            // 
            this.Loc_Operation.Location = new System.Drawing.Point(133, 84);
            this.Loc_Operation.Name = "Loc_Operation";
            this.Loc_Operation.Size = new System.Drawing.Size(330, 23);
            this.Loc_Operation.TabIndex = 0;
            this.Loc_Operation.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AccessibleDescription = "Demo Calculator";
            this.AccessibleName = "Demo Calculator";
            this.ClientSize = new System.Drawing.Size(642, 587);
            this.Controls.Add(this.CalculatorTab);
            this.Name = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.CalculatorTab.ResumeLayout(false);
            this.DecTab.ResumeLayout(false);
            this.DecTab.PerformLayout();
            this.BinTab.ResumeLayout(false);
            this.LocTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button Divide;
        private Button Reset;
        private Button reciprocal;
        private Button Num9;
        private Button Num8;
        private Button Square;
        private Button Num7;
        private Button Multiply;
        private Button Num4;
        private Button Num5;
        private Button Num6;
        private Button Num2;
        private Button Num1;
        private Button Plus;
        private Button Num3;
        private Button Minus;
        private Button Point;
        private Button equal;
        private Button Opposite;
        private Button Num0;
        private Button Binary;
        private Button Decimal;
        private Button Location;
        private Button Root;
        private Button NumberBox;
        private Button OperationBox;
        private Label label1;
        private TabControl CalculatorTab;
        private TabPage DecTab;
        private TabPage BinTab;
        private TabPage LocTab;
        private Button Bin_NumberBox;
        private Button Bin_Operation;
        private Button Loc_NumberBox;
        private Button Loc_Operation;
    }
}
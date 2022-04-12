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
            this.OperationBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.reciprocal = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            Opposite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Opposite
            // 
            Opposite.Location = new System.Drawing.Point(223, 483);
            Opposite.Name = "Opposite";
            Opposite.Size = new System.Drawing.Size(84, 45);
            Opposite.TabIndex = 19;
            Opposite.Text = "+/-";
            Opposite.UseVisualStyleBackColor = true;
            Opposite.Click += new System.EventHandler(this.Opposite_Click);
            // 
            // OperationBox
            // 
            this.OperationBox.Location = new System.Drawing.Point(223, 152);
            this.OperationBox.Name = "OperationBox";
            this.OperationBox.Size = new System.Drawing.Size(354, 23);
            this.OperationBox.TabIndex = 0;
            // 
            // NumberBox
            // 
            this.NumberBox.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberBox.Location = new System.Drawing.Point(223, 181);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(354, 43);
            this.NumberBox.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "/";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Divide_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(223, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Reset_Click);
            // 
            // reciprocal
            // 
            this.reciprocal.Location = new System.Drawing.Point(403, 279);
            this.reciprocal.Name = "reciprocal";
            this.reciprocal.Size = new System.Drawing.Size(84, 45);
            this.reciprocal.TabIndex = 4;
            this.reciprocal.Text = "1/x";
            this.reciprocal.UseVisualStyleBackColor = true;
            this.reciprocal.Click += new System.EventHandler(this.reciprocal_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(403, 330);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 45);
            this.button7.TabIndex = 5;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Num9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(313, 330);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 45);
            this.button8.TabIndex = 6;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Num8_Click);
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(313, 279);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(84, 45);
            this.square.TabIndex = 7;
            this.square.Text = "x^2";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(223, 330);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 45);
            this.button10.TabIndex = 8;
            this.button10.Text = "7";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Num7_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(493, 330);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(84, 45);
            this.button11.TabIndex = 9;
            this.button11.Text = "x";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(223, 381);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(84, 45);
            this.button12.TabIndex = 10;
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Num4_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(313, 381);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(84, 45);
            this.button13.TabIndex = 11;
            this.button13.Text = "5";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Num5_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(403, 381);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(84, 45);
            this.button14.TabIndex = 12;
            this.button14.Text = "6";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Num6_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(313, 432);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(84, 45);
            this.button15.TabIndex = 13;
            this.button15.Text = "2";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Num2_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(223, 432);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(84, 45);
            this.button16.TabIndex = 14;
            this.button16.Text = "1";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Num1_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(493, 432);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(84, 45);
            this.button17.TabIndex = 15;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Plus_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(403, 432);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(84, 45);
            this.button18.TabIndex = 16;
            this.button18.Text = "3";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.Num3_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(493, 381);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(84, 45);
            this.button19.TabIndex = 17;
            this.button19.Text = "-";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.Minus_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(403, 483);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(84, 45);
            this.button20.TabIndex = 21;
            this.button20.Text = ".";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.Point_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(493, 483);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(84, 45);
            this.button21.TabIndex = 20;
            this.button21.Text = "=";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Num0
            // 
            this.Num0.Location = new System.Drawing.Point(313, 483);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(84, 45);
            this.Num0.TabIndex = 18;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = true;
            this.Num0.Click += new System.EventHandler(this.Num0_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 45);
            this.button1.TabIndex = 25;
            this.button1.Text = "BIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Bin_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(403, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 45);
            this.button3.TabIndex = 24;
            this.button3.Text = "DEC";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Dec_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(223, 228);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 45);
            this.button5.TabIndex = 23;
            this.button5.Text = "LOC";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Loc_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(493, 228);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(84, 45);
            this.button22.TabIndex = 22;
            this.button22.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.ClientSize = new System.Drawing.Size(762, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(Opposite);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.square);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.reciprocal);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.OperationBox);
            this.Name = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private Button Bin;
        //private Button Reset;
        //private Button Num7;
        //private Button Num9;
        //private Button Num6;
        //private Button Num8;
        //private Button Dec;
        //private TextBox NumberBox;
        //private TextBox OperationBox;
        //private Button Num5;
        //private Button Num4;
        //private Button Plus;
        //private Button Minus;
        //private Button Multiply;
        //private Button Divide;
        //private Button Num1;
        //private Button Num2;
        //private Button Num3;
        //private Button Point;
        //private Button Num0;
        //private Button Opposite;
        //private Button Equal;
        //private Button button1;
        //private Button button3;
        //private Button Loc;
        //private Button button5;
        private TextBox OperationBox;
        private TextBox NumberBox;
        private Button button2;
        private Button button4;
        private Button reciprocal;
        private Button button7;
        private Button button8;
        private Button square;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button Opposite;
        private Button Num0;
        private Button button1;
        private Button button3;
        private Button button5;
        private Button button22;
    }
}
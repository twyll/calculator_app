namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstArgument = new System.Windows.Forms.TextBox();
            this.secondArgument = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.addition = new System.Windows.Forms.Button();
            this.substraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cos = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.remainder = new System.Windows.Forms.Button();
            this.cot = new System.Windows.Forms.Button();
            this.hyperbola = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.arctan = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.geometric = new System.Windows.Forms.Button();
            this.negative = new System.Windows.Forms.Button();
            this.arcsin = new System.Windows.Forms.Button();
            this.arccos = new System.Windows.Forms.Button();
            this.arithmetic = new System.Windows.Forms.Button();
            this.integerDivision = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.tenPowerOf = new System.Windows.Forms.Button();
            this.twoPowerOf = new System.Windows.Forms.Button();
            this.naturalLogarithm = new System.Windows.Forms.Button();
            this.logTwo = new System.Windows.Forms.Button();
            this.logTen = new System.Windows.Forms.Button();
            this.sqr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstArgument
            // 
            this.firstArgument.Location = new System.Drawing.Point(32, 46);
            this.firstArgument.Margin = new System.Windows.Forms.Padding(4);
            this.firstArgument.Name = "firstArgument";
            this.firstArgument.Size = new System.Drawing.Size(99, 22);
            this.firstArgument.TabIndex = 0;
            this.firstArgument.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // secondArgument
            // 
            this.secondArgument.Location = new System.Drawing.Point(208, 46);
            this.secondArgument.Margin = new System.Windows.Forms.Padding(4);
            this.secondArgument.Name = "secondArgument";
            this.secondArgument.Size = new System.Drawing.Size(99, 22);
            this.secondArgument.TabIndex = 1;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(383, 46);
            this.result.Margin = new System.Windows.Forms.Padding(4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(227, 22);
            this.result.TabIndex = 2;
            this.result.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(32, 95);
            this.addition.Margin = new System.Windows.Forms.Padding(4);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(100, 28);
            this.addition.TabIndex = 3;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.OpertionForTwoArgument);
            // 
            // substraction
            // 
            this.substraction.Location = new System.Drawing.Point(32, 145);
            this.substraction.Margin = new System.Windows.Forms.Padding(4);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(100, 28);
            this.substraction.TabIndex = 4;
            this.substraction.Text = "-";
            this.substraction.UseVisualStyleBackColor = true;
            this.substraction.Click += new System.EventHandler(this.OpertionForTwoArgument);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(160, 95);
            this.multiplication.Margin = new System.Windows.Forms.Padding(4);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(100, 28);
            this.multiplication.TabIndex = 5;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.OpertionForTwoArgument);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(160, 145);
            this.division.Margin = new System.Windows.Forms.Padding(4);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(100, 28);
            this.division.TabIndex = 6;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.OpertionForTwoArgument);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Число A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Число B";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Результат";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(148, 335);
            this.cos.Margin = new System.Windows.Forms.Padding(4);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(100, 28);
            this.cos.TabIndex = 10;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(31, 335);
            this.sin.Margin = new System.Windows.Forms.Padding(4);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(100, 28);
            this.sin.TabIndex = 11;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // remainder
            // 
            this.remainder.Location = new System.Drawing.Point(31, 198);
            this.remainder.Margin = new System.Windows.Forms.Padding(4);
            this.remainder.Name = "remainder";
            this.remainder.Size = new System.Drawing.Size(100, 28);
            this.remainder.TabIndex = 12;
            this.remainder.Text = "mod";
            this.remainder.UseVisualStyleBackColor = true;
            // 
            // cot
            // 
            this.cot.Location = new System.Drawing.Point(148, 385);
            this.cot.Margin = new System.Windows.Forms.Padding(4);
            this.cot.Name = "cot";
            this.cot.Size = new System.Drawing.Size(100, 28);
            this.cot.TabIndex = 13;
            this.cot.Text = "cotan";
            this.cot.UseVisualStyleBackColor = true;
            // 
            // hyperbola
            // 
            this.hyperbola.Location = new System.Drawing.Point(319, 145);
            this.hyperbola.Margin = new System.Windows.Forms.Padding(4);
            this.hyperbola.Name = "hyperbola";
            this.hyperbola.Size = new System.Drawing.Size(100, 28);
            this.hyperbola.TabIndex = 14;
            this.hyperbola.Text = "1/x";
            this.hyperbola.UseVisualStyleBackColor = true;
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(31, 385);
            this.tan.Margin = new System.Windows.Forms.Padding(4);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(100, 28);
            this.tan.TabIndex = 15;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            // 
            // arctan
            // 
            this.arctan.Location = new System.Drawing.Point(265, 385);
            this.arctan.Margin = new System.Windows.Forms.Padding(4);
            this.arctan.Name = "arctan";
            this.arctan.Size = new System.Drawing.Size(100, 28);
            this.arctan.TabIndex = 16;
            this.arctan.Text = "arctan";
            this.arctan.UseVisualStyleBackColor = true;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(436, 352);
            this.min.Margin = new System.Windows.Forms.Padding(4);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(100, 28);
            this.min.TabIndex = 17;
            this.min.Text = "min";
            this.min.UseVisualStyleBackColor = true;
            // 
            // geometric
            // 
            this.geometric.Location = new System.Drawing.Point(566, 397);
            this.geometric.Margin = new System.Windows.Forms.Padding(4);
            this.geometric.Name = "geometric";
            this.geometric.Size = new System.Drawing.Size(100, 28);
            this.geometric.TabIndex = 18;
            this.geometric.Text = "geometric";
            this.geometric.UseVisualStyleBackColor = true;
            this.geometric.Click += new System.EventHandler(this.OpertionForTwoArgument);
            // 
            // negative
            // 
            this.negative.Location = new System.Drawing.Point(436, 145);
            this.negative.Margin = new System.Windows.Forms.Padding(4);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(100, 28);
            this.negative.TabIndex = 19;
            this.negative.Text = "-x";
            this.negative.UseVisualStyleBackColor = true;
            this.negative.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // arcsin
            // 
            this.arcsin.Location = new System.Drawing.Point(31, 438);
            this.arcsin.Margin = new System.Windows.Forms.Padding(4);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(100, 28);
            this.arcsin.TabIndex = 20;
            this.arcsin.Text = "arcsin";
            this.arcsin.UseVisualStyleBackColor = true;
            // 
            // arccos
            // 
            this.arccos.Location = new System.Drawing.Point(148, 438);
            this.arccos.Margin = new System.Windows.Forms.Padding(4);
            this.arccos.Name = "arccos";
            this.arccos.Size = new System.Drawing.Size(100, 28);
            this.arccos.TabIndex = 21;
            this.arccos.Text = "arccos";
            this.arccos.UseVisualStyleBackColor = true;
            // 
            // arithmetic
            // 
            this.arithmetic.Location = new System.Drawing.Point(436, 397);
            this.arithmetic.Margin = new System.Windows.Forms.Padding(4);
            this.arithmetic.Name = "arithmetic";
            this.arithmetic.Size = new System.Drawing.Size(100, 28);
            this.arithmetic.TabIndex = 22;
            this.arithmetic.Text = "average";
            this.arithmetic.UseVisualStyleBackColor = true;
            this.arithmetic.Click += new System.EventHandler(this.OpertionForTwoArgument);
            // 
            // integerDivision
            // 
            this.integerDivision.Location = new System.Drawing.Point(162, 198);
            this.integerDivision.Margin = new System.Windows.Forms.Padding(4);
            this.integerDivision.Name = "integerDivision";
            this.integerDivision.Size = new System.Drawing.Size(100, 28);
            this.integerDivision.TabIndex = 23;
            this.integerDivision.Text = "div";
            this.integerDivision.UseVisualStyleBackColor = true;
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(566, 352);
            this.max.Margin = new System.Windows.Forms.Padding(4);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(100, 28);
            this.max.TabIndex = 24;
            this.max.Text = "max";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.OpertionForTwoArgument);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(553, 145);
            this.exp.Margin = new System.Windows.Forms.Padding(4);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(100, 28);
            this.exp.TabIndex = 25;
            this.exp.Text = "exp";
            this.exp.UseVisualStyleBackColor = true;
            // 
            // tenPowerOf
            // 
            this.tenPowerOf.Location = new System.Drawing.Point(553, 235);
            this.tenPowerOf.Margin = new System.Windows.Forms.Padding(4);
            this.tenPowerOf.Name = "tenPowerOf";
            this.tenPowerOf.Size = new System.Drawing.Size(100, 28);
            this.tenPowerOf.TabIndex = 26;
            this.tenPowerOf.Text = "10^x";
            this.tenPowerOf.UseVisualStyleBackColor = true;
            this.tenPowerOf.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // twoPowerOf
            // 
            this.twoPowerOf.Location = new System.Drawing.Point(436, 235);
            this.twoPowerOf.Margin = new System.Windows.Forms.Padding(4);
            this.twoPowerOf.Name = "twoPowerOf";
            this.twoPowerOf.Size = new System.Drawing.Size(100, 28);
            this.twoPowerOf.TabIndex = 27;
            this.twoPowerOf.Text = "2^x";
            this.twoPowerOf.UseVisualStyleBackColor = true;
            this.twoPowerOf.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // naturalLogarithm
            // 
            this.naturalLogarithm.Location = new System.Drawing.Point(319, 190);
            this.naturalLogarithm.Margin = new System.Windows.Forms.Padding(4);
            this.naturalLogarithm.Name = "naturalLogarithm";
            this.naturalLogarithm.Size = new System.Drawing.Size(100, 28);
            this.naturalLogarithm.TabIndex = 28;
            this.naturalLogarithm.Text = "ln";
            this.naturalLogarithm.UseVisualStyleBackColor = true;
            this.naturalLogarithm.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // logTwo
            // 
            this.logTwo.Location = new System.Drawing.Point(436, 190);
            this.logTwo.Margin = new System.Windows.Forms.Padding(4);
            this.logTwo.Name = "logTwo";
            this.logTwo.Size = new System.Drawing.Size(100, 28);
            this.logTwo.TabIndex = 29;
            this.logTwo.Text = "log2";
            this.logTwo.UseVisualStyleBackColor = true;
            this.logTwo.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // logTen
            // 
            this.logTen.Location = new System.Drawing.Point(553, 190);
            this.logTen.Margin = new System.Windows.Forms.Padding(4);
            this.logTen.Name = "logTen";
            this.logTen.Size = new System.Drawing.Size(100, 28);
            this.logTen.TabIndex = 30;
            this.logTen.Text = "log10";
            this.logTen.UseVisualStyleBackColor = true;
            this.logTen.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // sqr
            // 
            this.sqr.Location = new System.Drawing.Point(319, 235);
            this.sqr.Margin = new System.Windows.Forms.Padding(4);
            this.sqr.Name = "sqr";
            this.sqr.Size = new System.Drawing.Size(100, 28);
            this.sqr.TabIndex = 31;
            this.sqr.Text = "x^2";
            this.sqr.UseVisualStyleBackColor = true;
            this.sqr.Click += new System.EventHandler(this.OpertionForOneArgument);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 490);
            this.Controls.Add(this.sqr);
            this.Controls.Add(this.logTen);
            this.Controls.Add(this.logTwo);
            this.Controls.Add(this.naturalLogarithm);
            this.Controls.Add(this.twoPowerOf);
            this.Controls.Add(this.tenPowerOf);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.max);
            this.Controls.Add(this.integerDivision);
            this.Controls.Add(this.arithmetic);
            this.Controls.Add(this.arccos);
            this.Controls.Add(this.arcsin);
            this.Controls.Add(this.negative);
            this.Controls.Add(this.geometric);
            this.Controls.Add(this.min);
            this.Controls.Add(this.arctan);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.hyperbola);
            this.Controls.Add(this.cot);
            this.Controls.Add(this.remainder);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.substraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.result);
            this.Controls.Add(this.secondArgument);
            this.Controls.Add(this.firstArgument);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstArgument;
        private System.Windows.Forms.TextBox secondArgument;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button substraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;

        

       

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button remainder;
        private System.Windows.Forms.Button cot;
        private System.Windows.Forms.Button hyperbola;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button arctan;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button geometric;
        private System.Windows.Forms.Button negative;
        private System.Windows.Forms.Button arcsin;
        private System.Windows.Forms.Button arccos;
        private System.Windows.Forms.Button arithmetic;
        private System.Windows.Forms.Button integerDivision;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button tenPowerOf;
        private System.Windows.Forms.Button twoPowerOf;
        private System.Windows.Forms.Button naturalLogarithm;
        private System.Windows.Forms.Button logTwo;
        private System.Windows.Forms.Button logTen;
        private System.Windows.Forms.Button sqr;
    }
}


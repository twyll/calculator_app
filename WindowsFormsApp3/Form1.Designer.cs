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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.addition = new System.Windows.Forms.Button();
            this.substraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(208, 46);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(57, 224);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(227, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(32, 95);
            this.addition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(100, 28);
            this.addition.TabIndex = 3;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.buttonClick);
            // 
            // substraction
            // 
            this.substraction.Location = new System.Drawing.Point(32, 145);
            this.substraction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(100, 28);
            this.substraction.TabIndex = 4;
            this.substraction.Text = "-";
            this.substraction.UseVisualStyleBackColor = true;
            this.substraction.Click += new System.EventHandler(this.buttonClick);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(208, 95);
            this.multiplication.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(100, 28);
            this.multiplication.TabIndex = 5;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.buttonClick);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(208, 145);
            this.division.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(100, 28);
            this.division.TabIndex = 6;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.buttonClick);
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
            this.label3.Location = new System.Drawing.Point(132, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 279);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.substraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button substraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;

        

        //public static double add(double a, double b)
        //{
        //    return a + b;
        //}
        //public static double substr(double a, double b)
        //{
        //    return a - b;
        //}
        //public static double multiply(double a, double b)
        //{
        //    return a * b;
        //}
        //public static double div(double a, double b)
        //{
        //    return a / b;
        //}

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


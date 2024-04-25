namespace Calculadora
{
    partial class Form1
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
            calcular = new Button();
            Nota1 = new TextBox();
            Nota3 = new TextBox();
            result = new TextBox();
            sit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Nota2 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // calcular
            // 
            calcular.Location = new Point(389, 276);
            calcular.Name = "calcular";
            calcular.Size = new Size(120, 40);
            calcular.TabIndex = 0;
            calcular.Text = "Calcule";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += Calcular_Click;
            // 
            // Nota1
            // 
            Nota1.Location = new Point(141, 63);
            Nota1.Name = "Nota1";
            Nota1.Size = new Size(108, 23);
            Nota1.TabIndex = 1;
            // 
            // Nota3
            // 
            Nota3.Location = new Point(141, 252);
            Nota3.Name = "Nota3";
            Nota3.Size = new Size(108, 23);
            Nota3.TabIndex = 2;
            // 
            // result
            // 
            result.Location = new Point(666, 63);
            result.Name = "result";
            result.Size = new Size(108, 23);
            result.TabIndex = 3;
            // 
            // sit
            // 
            sit.Location = new Point(666, 252);
            sit.Name = "sit";
            sit.Size = new Size(108, 23);
            sit.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 45);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 5;
            label1.Text = "Insira a formativa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 234);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 6;
            label2.Text = "Insira a somativa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(697, 45);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Média";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(697, 234);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 8;
            label4.Text = "situação";
            // 
            // Nota2
            // 
            Nota2.Location = new Point(141, 172);
            Nota2.Name = "Nota2";
            Nota2.Size = new Size(108, 23);
            Nota2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 141);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 10;
            label5.Text = "Insira a diversificada";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 439);
            Controls.Add(label5);
            Controls.Add(Nota2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sit);
            Controls.Add(result);
            Controls.Add(Nota3);
            Controls.Add(Nota1);
            Controls.Add(calcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calcular;
        private TextBox Nota1;
        private TextBox Nota3;
        private TextBox result;
        private TextBox sit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Nota2;
        private Label label5;
    }
}

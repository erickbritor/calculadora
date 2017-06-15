namespace Calculadora.Formulario
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSomar = new System.Windows.Forms.Button();
            this.buttonSubtrair = new System.Windows.Forms.Button();
            this.buttonMultiplicar = new System.Windows.Forms.Button();
            this.buttondividir = new System.Windows.Forms.Button();
            this.buttonmaior = new System.Windows.Forms.Button();
            this.buttonMenor = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSomar
            // 
            this.buttonSomar.Location = new System.Drawing.Point(241, 22);
            this.buttonSomar.Name = "buttonSomar";
            this.buttonSomar.Size = new System.Drawing.Size(75, 23);
            this.buttonSomar.TabIndex = 0;
            this.buttonSomar.Text = "Somar";
            this.buttonSomar.UseVisualStyleBackColor = true;
            this.buttonSomar.Click += new System.EventHandler(this.buttonSomar_Click);
            // 
            // buttonSubtrair
            // 
            this.buttonSubtrair.Location = new System.Drawing.Point(241, 51);
            this.buttonSubtrair.Name = "buttonSubtrair";
            this.buttonSubtrair.Size = new System.Drawing.Size(75, 23);
            this.buttonSubtrair.TabIndex = 1;
            this.buttonSubtrair.Text = "Subtrair";
            this.buttonSubtrair.UseVisualStyleBackColor = true;
            this.buttonSubtrair.Click += new System.EventHandler(this.buttonSubtrair_Click);
            // 
            // buttonMultiplicar
            // 
            this.buttonMultiplicar.Location = new System.Drawing.Point(241, 80);
            this.buttonMultiplicar.Name = "buttonMultiplicar";
            this.buttonMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiplicar.TabIndex = 2;
            this.buttonMultiplicar.Text = "Multiplicar";
            this.buttonMultiplicar.UseVisualStyleBackColor = true;
            // 
            // buttondividir
            // 
            this.buttondividir.Location = new System.Drawing.Point(241, 109);
            this.buttondividir.Name = "buttondividir";
            this.buttondividir.Size = new System.Drawing.Size(75, 23);
            this.buttondividir.TabIndex = 3;
            this.buttondividir.Text = "Dividir";
            this.buttondividir.UseVisualStyleBackColor = true;
            // 
            // buttonmaior
            // 
            this.buttonmaior.Location = new System.Drawing.Point(241, 138);
            this.buttonmaior.Name = "buttonmaior";
            this.buttonmaior.Size = new System.Drawing.Size(75, 23);
            this.buttonmaior.TabIndex = 4;
            this.buttonmaior.Text = "Maior";
            this.buttonmaior.UseVisualStyleBackColor = true;
            // 
            // buttonMenor
            // 
            this.buttonMenor.Location = new System.Drawing.Point(241, 167);
            this.buttonMenor.Name = "buttonMenor";
            this.buttonMenor.Size = new System.Drawing.Size(75, 23);
            this.buttonMenor.TabIndex = 5;
            this.buttonMenor.Text = "Menor";
            this.buttonMenor.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 196);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(304, 41);
            this.button7.TabIndex = 6;
            this.button7.Text = "=";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Informe os numeros";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(85, 165);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(122, 20);
            this.textBoxTotal.TabIndex = 11;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 319);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonMenor);
            this.Controls.Add(this.buttonmaior);
            this.Controls.Add(this.buttondividir);
            this.Controls.Add(this.buttonMultiplicar);
            this.Controls.Add(this.buttonSubtrair);
            this.Controls.Add(this.buttonSomar);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSomar;
        private System.Windows.Forms.Button buttonSubtrair;
        private System.Windows.Forms.Button buttonMultiplicar;
        private System.Windows.Forms.Button buttondividir;
        private System.Windows.Forms.Button buttonmaior;
        private System.Windows.Forms.Button buttonMenor;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTotal;
    }
}
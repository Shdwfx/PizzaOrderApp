
namespace PizzaOrderApp
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
            this.Boyut = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Tür = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.Ekstralar = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Boyut.SuspendLayout();
            this.Tür.SuspendLayout();
            this.Ekstralar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Boyut
            // 
            this.Boyut.Controls.Add(this.radioButton3);
            this.Boyut.Controls.Add(this.radioButton2);
            this.Boyut.Controls.Add(this.radioButton1);
            this.Boyut.Location = new System.Drawing.Point(27, 50);
            this.Boyut.Name = "Boyut";
            this.Boyut.Size = new System.Drawing.Size(177, 132);
            this.Boyut.TabIndex = 0;
            this.Boyut.TabStop = false;
            this.Boyut.Text = "Boyut Seçiniz";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 90);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(96, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Büyük - 30 TL";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Orta - 16 TL";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Küçük - 11 TL";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Tür
            // 
            this.Tür.Controls.Add(this.radioButton4);
            this.Tür.Controls.Add(this.radioButton5);
            this.Tür.Controls.Add(this.radioButton6);
            this.Tür.Location = new System.Drawing.Point(210, 50);
            this.Tür.Name = "Tür";
            this.Tür.Size = new System.Drawing.Size(177, 132);
            this.Tür.TabIndex = 1;
            this.Tür.TabStop = false;
            this.Tür.Text = "Tür Seçiniz";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 90);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(104, 19);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Sebzeli - + 2 TL";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 65);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(76, 19);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Margarita";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 40);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(87, 19);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Bol Sucuklu";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // Ekstralar
            // 
            this.Ekstralar.Controls.Add(this.radioButton7);
            this.Ekstralar.Controls.Add(this.radioButton8);
            this.Ekstralar.Controls.Add(this.radioButton9);
            this.Ekstralar.Location = new System.Drawing.Point(393, 50);
            this.Ekstralar.Name = "Ekstralar";
            this.Ekstralar.Size = new System.Drawing.Size(177, 132);
            this.Ekstralar.TabIndex = 2;
            this.Ekstralar.TabStop = false;
            this.Ekstralar.Text = "Ekstralar";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 90);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(94, 19);
            this.radioButton7.TabIndex = 5;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Mısır - + 2 TL";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(6, 65);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(120, 19);
            this.radioButton8.TabIndex = 4;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Ekstra Sos - + 3 TL";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(6, 40);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(122, 19);
            this.radioButton9.TabIndex = 3;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Bol Kekikli - + 2 TL";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fiyat: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ekstralar);
            this.Controls.Add(this.Tür);
            this.Controls.Add(this.Boyut);
            this.Name = "Form1";
            this.Text = "Pizza Fiyat Hesaplayıcısı";
            this.Boyut.ResumeLayout(false);
            this.Boyut.PerformLayout();
            this.Tür.ResumeLayout(false);
            this.Tür.PerformLayout();
            this.Ekstralar.ResumeLayout(false);
            this.Ekstralar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Boyut;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox Tür;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox Ekstralar;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}


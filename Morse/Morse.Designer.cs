namespace Morse
{
    partial class Morse
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
            this.textInput1 = new System.Windows.Forms.TextBox();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.textBoxOutput1 = new System.Windows.Forms.TextBox();
            this.textBoxOutput2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textInput1
            // 
            this.textInput1.Location = new System.Drawing.Point(12, 69);
            this.textInput1.Multiline = true;
            this.textInput1.Name = "textInput1";
            this.textInput1.Size = new System.Drawing.Size(325, 49);
            this.textInput1.TabIndex = 0;
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Location = new System.Drawing.Point(463, 69);
            this.textBoxInput2.Multiline = true;
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(325, 49);
            this.textBoxInput2.TabIndex = 1;
            // 
            // textBoxOutput1
            // 
            this.textBoxOutput1.Location = new System.Drawing.Point(12, 124);
            this.textBoxOutput1.Multiline = true;
            this.textBoxOutput1.Name = "textBoxOutput1";
            this.textBoxOutput1.Size = new System.Drawing.Size(325, 49);
            this.textBoxOutput1.TabIndex = 2;
            // 
            // textBoxOutput2
            // 
            this.textBoxOutput2.Location = new System.Drawing.Point(463, 124);
            this.textBoxOutput2.Multiline = true;
            this.textBoxOutput2.Name = "textBoxOutput2";
            this.textBoxOutput2.Size = new System.Drawing.Size(325, 49);
            this.textBoxOutput2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxOutput2);
            this.Controls.Add(this.textBoxOutput1);
            this.Controls.Add(this.textBoxInput2);
            this.Controls.Add(this.textInput1);
            this.Name = "Form1";
            this.Text = "*– ––** –*** **– –*– *– –– ––– *–* ––** *";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInput1;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.TextBox textBoxOutput1;
        private System.Windows.Forms.TextBox textBoxOutput2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


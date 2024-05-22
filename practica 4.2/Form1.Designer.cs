namespace practica_4._2
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.tripleButton = new System.Windows.Forms.Button();
            this.charTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox1 = new System.Windows.Forms.TextBox();
            this.resultTextBox2 = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(3, 12);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(818, 22);
            this.inputTextBox.TabIndex = 0;
            // 
            // tripleButton
            // 
            this.tripleButton.Location = new System.Drawing.Point(3, 68);
            this.tripleButton.Name = "tripleButton";
            this.tripleButton.Size = new System.Drawing.Size(416, 36);
            this.tripleButton.TabIndex = 1;
            this.tripleButton.Text = "Запуск устроения";
            this.tripleButton.UseVisualStyleBackColor = true;
            this.tripleButton.Click += new System.EventHandler(this.tripleButton_Click);
            // 
            // charTextBox
            // 
            this.charTextBox.Location = new System.Drawing.Point(3, 40);
            this.charTextBox.Name = "charTextBox";
            this.charTextBox.Size = new System.Drawing.Size(818, 22);
            this.charTextBox.TabIndex = 2;
            // 
            // resultTextBox1
            // 
            this.resultTextBox1.Location = new System.Drawing.Point(3, 110);
            this.resultTextBox1.Name = "resultTextBox1";
            this.resultTextBox1.Size = new System.Drawing.Size(818, 22);
            this.resultTextBox1.TabIndex = 3;
            // 
            // resultTextBox2
            // 
            this.resultTextBox2.Location = new System.Drawing.Point(3, 138);
            this.resultTextBox2.Name = "resultTextBox2";
            this.resultTextBox2.Size = new System.Drawing.Size(818, 22);
            this.resultTextBox2.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(425, 68);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(396, 36);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Очистка результатов";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 165);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultTextBox2);
            this.Controls.Add(this.resultTextBox1);
            this.Controls.Add(this.charTextBox);
            this.Controls.Add(this.tripleButton);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button tripleButton;
        private System.Windows.Forms.TextBox charTextBox;
        private System.Windows.Forms.TextBox resultTextBox1;
        private System.Windows.Forms.TextBox resultTextBox2;
        private System.Windows.Forms.Button clearButton;
    }
}


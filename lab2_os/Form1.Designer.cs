namespace lab2_os
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
            this.StartButton = new System.Windows.Forms.Button();
            this.readersAmount = new System.Windows.Forms.NumericUpDown();
            this.writersAmount = new System.Windows.Forms.NumericUpDown();
            this.readersAmountLabel = new System.Windows.Forms.Label();
            this.writersAmountLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.readersAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.writersAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 123);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Начать";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartProcess);
            // 
            // readersAmount
            // 
            this.readersAmount.Location = new System.Drawing.Point(12, 36);
            this.readersAmount.Name = "readersAmount";
            this.readersAmount.Size = new System.Drawing.Size(120, 20);
            this.readersAmount.TabIndex = 1;
            // 
            // writersAmount
            // 
            this.writersAmount.Location = new System.Drawing.Point(12, 87);
            this.writersAmount.Name = "writersAmount";
            this.writersAmount.Size = new System.Drawing.Size(120, 20);
            this.writersAmount.TabIndex = 2;
            // 
            // readersAmountLabel
            // 
            this.readersAmountLabel.AutoSize = true;
            this.readersAmountLabel.Location = new System.Drawing.Point(12, 17);
            this.readersAmountLabel.Name = "readersAmountLabel";
            this.readersAmountLabel.Size = new System.Drawing.Size(120, 13);
            this.readersAmountLabel.TabIndex = 3;
            this.readersAmountLabel.Text = "Количество читателей";
            // 
            // writersAmountLabel
            // 
            this.writersAmountLabel.AutoSize = true;
            this.writersAmountLabel.Location = new System.Drawing.Point(12, 71);
            this.writersAmountLabel.Name = "writersAmountLabel";
            this.writersAmountLabel.Size = new System.Drawing.Size(122, 13);
            this.writersAmountLabel.TabIndex = 4;
            this.writersAmountLabel.Text = "Количество писателей";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 174);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(773, 115);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.writersAmountLabel);
            this.Controls.Add(this.readersAmountLabel);
            this.Controls.Add(this.writersAmount);
            this.Controls.Add(this.readersAmount);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCloseHandle);
            ((System.ComponentModel.ISupportInitialize)(this.readersAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.writersAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown readersAmount;
        private System.Windows.Forms.NumericUpDown writersAmount;
        private System.Windows.Forms.Label readersAmountLabel;
        private System.Windows.Forms.Label writersAmountLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


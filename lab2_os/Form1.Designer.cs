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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenFolderBrowserDialog);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}


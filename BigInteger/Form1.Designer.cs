namespace BigInteger
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.richTextBoxNum = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPow = new System.Windows.Forms.RichTextBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelPow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(287, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculating";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(12, 144);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(784, 509);
            this.richTextBoxResult.TabIndex = 1;
            this.richTextBoxResult.Text = "";
            // 
            // richTextBoxNum
            // 
            this.richTextBoxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxNum.Location = new System.Drawing.Point(158, 12);
            this.richTextBoxNum.Name = "richTextBoxNum";
            this.richTextBoxNum.Size = new System.Drawing.Size(638, 35);
            this.richTextBoxNum.TabIndex = 2;
            this.richTextBoxNum.Text = "";
            // 
            // richTextBoxPow
            // 
            this.richTextBoxPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxPow.Location = new System.Drawing.Point(158, 53);
            this.richTextBoxPow.Name = "richTextBoxPow";
            this.richTextBoxPow.Size = new System.Drawing.Size(638, 35);
            this.richTextBoxPow.TabIndex = 2;
            this.richTextBoxPow.Text = "";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum.Location = new System.Drawing.Point(35, 12);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(100, 24);
            this.labelNum.TabIndex = 3;
            this.labelNum.Text = "Big Integer";
            // 
            // labelPow
            // 
            this.labelPow.AutoSize = true;
            this.labelPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPow.Location = new System.Drawing.Point(36, 56);
            this.labelPow.Name = "labelPow";
            this.labelPow.Size = new System.Drawing.Size(64, 24);
            this.labelPow.TabIndex = 3;
            this.labelPow.Text = "Power";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 665);
            this.Controls.Add(this.labelPow);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.richTextBoxPow);
            this.Controls.Add(this.richTextBoxNum);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "BigInteger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.RichTextBox richTextBoxNum;
        private System.Windows.Forms.RichTextBox richTextBoxPow;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelPow;
    }
}


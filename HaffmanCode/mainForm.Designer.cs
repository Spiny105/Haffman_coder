namespace HaffmanCoder
{
    partial class mainForm
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
            this.Source_textBox = new System.Windows.Forms.TextBox();
            this.Source_Code_textBox = new System.Windows.Forms.TextBox();
            this.tranceived_Code_textBox = new System.Windows.Forms.TextBox();
            this.tranceived_textBox = new System.Windows.Forms.TextBox();
            this.code_button = new System.Windows.Forms.Button();
            this.tranceive_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Source_textBox
            // 
            this.Source_textBox.Location = new System.Drawing.Point(13, 13);
            this.Source_textBox.Name = "Source_textBox";
            this.Source_textBox.Size = new System.Drawing.Size(189, 20);
            this.Source_textBox.TabIndex = 0;
            // 
            // Source_Code_textBox
            // 
            this.Source_Code_textBox.Location = new System.Drawing.Point(13, 40);
            this.Source_Code_textBox.Name = "Source_Code_textBox";
            this.Source_Code_textBox.Size = new System.Drawing.Size(189, 20);
            this.Source_Code_textBox.TabIndex = 1;
            // 
            // tranceived_Code_textBox
            // 
            this.tranceived_Code_textBox.Location = new System.Drawing.Point(13, 98);
            this.tranceived_Code_textBox.Name = "tranceived_Code_textBox";
            this.tranceived_Code_textBox.ReadOnly = true;
            this.tranceived_Code_textBox.Size = new System.Drawing.Size(189, 20);
            this.tranceived_Code_textBox.TabIndex = 2;
            // 
            // tranceived_textBox
            // 
            this.tranceived_textBox.Location = new System.Drawing.Point(13, 125);
            this.tranceived_textBox.Name = "tranceived_textBox";
            this.tranceived_textBox.ReadOnly = true;
            this.tranceived_textBox.Size = new System.Drawing.Size(189, 20);
            this.tranceived_textBox.TabIndex = 3;
            // 
            // code_button
            // 
            this.code_button.Location = new System.Drawing.Point(209, 13);
            this.code_button.Name = "code_button";
            this.code_button.Size = new System.Drawing.Size(93, 23);
            this.code_button.TabIndex = 4;
            this.code_button.Text = "Закодировать";
            this.code_button.UseVisualStyleBackColor = true;
            this.code_button.Click += new System.EventHandler(this.code_button_Click);
            // 
            // tranceive_button
            // 
            this.tranceive_button.Location = new System.Drawing.Point(209, 98);
            this.tranceive_button.Name = "tranceive_button";
            this.tranceive_button.Size = new System.Drawing.Size(93, 23);
            this.tranceive_button.TabIndex = 5;
            this.tranceive_button.Text = "Исправить";
            this.tranceive_button.UseVisualStyleBackColor = true;
            this.tranceive_button.Click += new System.EventHandler(this.tranceive_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Испоганить";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Исходное число";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 155);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tranceive_button);
            this.Controls.Add(this.code_button);
            this.Controls.Add(this.tranceived_textBox);
            this.Controls.Add(this.tranceived_Code_textBox);
            this.Controls.Add(this.Source_Code_textBox);
            this.Controls.Add(this.Source_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "Код Хафмана";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Source_textBox;
        private System.Windows.Forms.TextBox Source_Code_textBox;
        private System.Windows.Forms.TextBox tranceived_Code_textBox;
        private System.Windows.Forms.TextBox tranceived_textBox;
        private System.Windows.Forms.Button code_button;
        private System.Windows.Forms.Button tranceive_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


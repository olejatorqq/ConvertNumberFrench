
namespace ConvertNumberFrench
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
            this.textBoxFrench = new System.Windows.Forms.TextBox();
            this.textBoxArab = new System.Windows.Forms.TextBox();
            this.textBoxRus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.textBoxErrors = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxFrench
            // 
            this.textBoxFrench.Location = new System.Drawing.Point(36, 45);
            this.textBoxFrench.Name = "textBoxFrench";
            this.textBoxFrench.Size = new System.Drawing.Size(299, 20);
            this.textBoxFrench.TabIndex = 0;
            this.textBoxFrench.TextChanged += new System.EventHandler(this.textBoxFrench_TextChanged);
            // 
            // textBoxArab
            // 
            this.textBoxArab.Location = new System.Drawing.Point(39, 122);
            this.textBoxArab.Name = "textBoxArab";
            this.textBoxArab.Size = new System.Drawing.Size(209, 20);
            this.textBoxArab.TabIndex = 1;
            // 
            // textBoxRus
            // 
            this.textBoxRus.Location = new System.Drawing.Point(36, 195);
            this.textBoxRus.Name = "textBoxRus";
            this.textBoxRus.Size = new System.Drawing.Size(209, 20);
            this.textBoxRus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Текстовое представление числа";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Числовое представление (Арабские цифры)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Числовое представление (Старорусские цифры)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ошибки";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(266, 228);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(110, 108);
            this.buttonConvert.TabIndex = 10;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // textBoxErrors
            // 
            this.textBoxErrors.Location = new System.Drawing.Point(8, 304);
            this.textBoxErrors.Name = "textBoxErrors";
            this.textBoxErrors.Size = new System.Drawing.Size(232, 20);
            this.textBoxErrors.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 355);
            this.Controls.Add(this.textBoxErrors);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRus);
            this.Controls.Add(this.textBoxArab);
            this.Controls.Add(this.textBoxFrench);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFrench;
        private System.Windows.Forms.TextBox textBoxArab;
        private System.Windows.Forms.TextBox textBoxRus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox textBoxErrors;
    }
}



namespace Exercise_1_СreateReceipt
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.radioRound1 = new System.Windows.Forms.RadioButton();
            this.radioRound2 = new System.Windows.Forms.RadioButton();
            this.radioRound3 = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(5, 151);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(675, 379);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(675, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Генерировать и вывести";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioRound1
            // 
            this.radioRound1.AutoSize = true;
            this.radioRound1.Location = new System.Drawing.Point(5, 44);
            this.radioRound1.Name = "radioRound1";
            this.radioRound1.Size = new System.Drawing.Size(331, 29);
            this.radioRound1.TabIndex = 4;
            this.radioRound1.TabStop = true;
            this.radioRound1.Text = "Математическое округление";
            this.radioRound1.UseVisualStyleBackColor = true;
            this.radioRound1.CheckedChanged += new System.EventHandler(this.radioRound1_CheckedChanged);
            // 
            // radioRound2
            // 
            this.radioRound2.AutoSize = true;
            this.radioRound2.Location = new System.Drawing.Point(5, 79);
            this.radioRound2.Name = "radioRound2";
            this.radioRound2.Size = new System.Drawing.Size(277, 29);
            this.radioRound2.TabIndex = 5;
            this.radioRound2.TabStop = true;
            this.radioRound2.Text = "Округление до 5 копеек";
            this.radioRound2.UseVisualStyleBackColor = true;
            this.radioRound2.CheckedChanged += new System.EventHandler(this.radioRound2_CheckedChanged);
            // 
            // radioRound3
            // 
            this.radioRound3.AutoSize = true;
            this.radioRound3.Location = new System.Drawing.Point(5, 114);
            this.radioRound3.Name = "radioRound3";
            this.radioRound3.Size = new System.Drawing.Size(289, 29);
            this.radioRound3.TabIndex = 6;
            this.radioRound3.TabStop = true;
            this.radioRound3.Text = "Округление до 10 копеек";
            this.radioRound3.UseVisualStyleBackColor = true;
            this.radioRound3.CheckedChanged += new System.EventHandler(this.radioRound3_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(5, 533);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(230, 36);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранение";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(234, 533);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(232, 36);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Очистка";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(461, 533);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(5);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(219, 36);
            this.buttonLoad.TabIndex = 9;
            this.buttonLoad.Text = "Загрузка";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 573);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.radioRound3);
            this.Controls.Add(this.radioRound2);
            this.Controls.Add(this.radioRound1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Чековая лента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioRound1;
        private System.Windows.Forms.RadioButton radioRound2;
        private System.Windows.Forms.RadioButton radioRound3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonLoad;
    }
}


namespace Обработка_изображения
{
    partial class Main_Form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGray = new System.Windows.Forms.Button();
            this.buttonContours = new System.Windows.Forms.Button();
            this.buttonContrastEnhancement = new System.Windows.Forms.Button();
            this.labelContours = new System.Windows.Forms.Label();
            this.maskedTextBoxContours = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 564);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGray
            // 
            this.buttonGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGray.Location = new System.Drawing.Point(581, 12);
            this.buttonGray.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGray.Name = "buttonGray";
            this.buttonGray.Size = new System.Drawing.Size(112, 27);
            this.buttonGray.TabIndex = 4;
            this.buttonGray.Text = "Оттенки серого";
            this.buttonGray.UseVisualStyleBackColor = true;
            // 
            // buttonContours
            // 
            this.buttonContours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContours.Location = new System.Drawing.Point(581, 69);
            this.buttonContours.Margin = new System.Windows.Forms.Padding(2);
            this.buttonContours.Name = "buttonContours";
            this.buttonContours.Size = new System.Drawing.Size(112, 38);
            this.buttonContours.TabIndex = 5;
            this.buttonContours.Text = "Выделение контуров";
            this.buttonContours.UseVisualStyleBackColor = true;
            this.buttonContours.Click += new System.EventHandler(this.GetContours);
            // 
            // buttonContrastEnhancement
            // 
            this.buttonContrastEnhancement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContrastEnhancement.Location = new System.Drawing.Point(581, 111);
            this.buttonContrastEnhancement.Margin = new System.Windows.Forms.Padding(2);
            this.buttonContrastEnhancement.Name = "buttonContrastEnhancement";
            this.buttonContrastEnhancement.Size = new System.Drawing.Size(112, 39);
            this.buttonContrastEnhancement.TabIndex = 7;
            this.buttonContrastEnhancement.Text = "Повышение контрастности";
            this.buttonContrastEnhancement.UseVisualStyleBackColor = true;
            // 
            // labelContours
            // 
            this.labelContours.AutoSize = true;
            this.labelContours.Location = new System.Drawing.Point(582, 47);
            this.labelContours.Name = "labelContours";
            this.labelContours.Size = new System.Drawing.Size(55, 13);
            this.labelContours.TabIndex = 40;
            this.labelContours.Text = "Порог, %:";
            // 
            // maskedTextBoxContours
            // 
            this.maskedTextBoxContours.Location = new System.Drawing.Point(643, 44);
            this.maskedTextBoxContours.Mask = "00";
            this.maskedTextBoxContours.Name = "maskedTextBoxContours";
            this.maskedTextBoxContours.Size = new System.Drawing.Size(24, 20);
            this.maskedTextBoxContours.TabIndex = 41;
            this.maskedTextBoxContours.Text = "30";
            this.maskedTextBoxContours.ValidatingType = typeof(int);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 588);
            this.Controls.Add(this.maskedTextBoxContours);
            this.Controls.Add(this.labelContours);
            this.Controls.Add(this.buttonContrastEnhancement);
            this.Controls.Add(this.buttonContours);
            this.Controls.Add(this.buttonGray);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Л/р 4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGray;
        private System.Windows.Forms.Button buttonContours;
        private System.Windows.Forms.Button buttonContrastEnhancement;
        private System.Windows.Forms.Label labelContours;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxContours;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


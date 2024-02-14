namespace Fractalization {
	partial class MainForm {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
            this.primoPictureBox = new System.Windows.Forms.PictureBox();
            this.paintButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.primoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // primoPictureBox
            // 
            this.primoPictureBox.BackColor = System.Drawing.Color.Cornsilk;
            this.primoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.primoPictureBox.Location = new System.Drawing.Point(39, 13);
            this.primoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.primoPictureBox.Name = "primoPictureBox";
            this.primoPictureBox.Size = new System.Drawing.Size(700, 550);
            this.primoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.primoPictureBox.TabIndex = 0;
            this.primoPictureBox.TabStop = false;
            // 
            // paintButton
            // 
            this.paintButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.paintButton.Font = new System.Drawing.Font("Peace Sans", 11F);
            this.paintButton.Location = new System.Drawing.Point(283, 582);
            this.paintButton.Margin = new System.Windows.Forms.Padding(4);
            this.paintButton.Name = "paintButton";
            this.paintButton.Size = new System.Drawing.Size(204, 51);
            this.paintButton.TabIndex = 4;
            this.paintButton.Text = "Нарисовать";
            this.paintButton.UseVisualStyleBackColor = false;
            this.paintButton.Click += new System.EventHandler(this.paintButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.primoPictureBox);
            this.Controls.Add(this.paintButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Гижевская";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.primoPictureBox)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox primoPictureBox;
        private System.Windows.Forms.Button paintButton;
    }
}


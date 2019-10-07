namespace labComGraf2
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
            this.fractalPictureBox = new System.Windows.Forms.PictureBox();
            this.drawFractalButton = new System.Windows.Forms.Button();
            this.maxOperationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxIterationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fractalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxOperationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fractalPictureBox
            // 
            this.fractalPictureBox.Location = new System.Drawing.Point(216, 124);
            this.fractalPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.fractalPictureBox.Name = "fractalPictureBox";
            this.fractalPictureBox.Size = new System.Drawing.Size(550, 500);
            this.fractalPictureBox.TabIndex = 0;
            this.fractalPictureBox.TabStop = false;
            // 
            // drawFractalButton
            // 
            this.drawFractalButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.drawFractalButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawFractalButton.Location = new System.Drawing.Point(841, 60);
            this.drawFractalButton.Margin = new System.Windows.Forms.Padding(4);
            this.drawFractalButton.Name = "drawFractalButton";
            this.drawFractalButton.Size = new System.Drawing.Size(153, 39);
            this.drawFractalButton.TabIndex = 0;
            this.drawFractalButton.Text = "Пуск";
            this.drawFractalButton.UseVisualStyleBackColor = true;
            this.drawFractalButton.Click += new System.EventHandler(this.DrawFractalButton_Click);
            // 
            // maxOperationNumericUpDown
            // 
            this.maxOperationNumericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxOperationNumericUpDown.Location = new System.Drawing.Point(616, 68);
            this.maxOperationNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.maxOperationNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxOperationNumericUpDown.Name = "maxOperationNumericUpDown";
            this.maxOperationNumericUpDown.Size = new System.Drawing.Size(126, 26);
            this.maxOperationNumericUpDown.TabIndex = 1;
            this.maxOperationNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // maxIterationLabel
            // 
            this.maxIterationLabel.AutoSize = true;
            this.maxIterationLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxIterationLabel.Location = new System.Drawing.Point(135, 70);
            this.maxIterationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxIterationLabel.Name = "maxIterationLabel";
            this.maxIterationLabel.Size = new System.Drawing.Size(314, 19);
            this.maxIterationLabel.TabIndex = 2;
            this.maxIterationLabel.Text = "Введите максимальное количество итераций";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 698);
            this.Controls.Add(this.maxIterationLabel);
            this.Controls.Add(this.maxOperationNumericUpDown);
            this.Controls.Add(this.drawFractalButton);
            this.Controls.Add(this.fractalPictureBox);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Треугольник Серпинского";
            ((System.ComponentModel.ISupportInitialize)(this.fractalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxOperationNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fractalPictureBox;
        private System.Windows.Forms.Button drawFractalButton;
        private System.Windows.Forms.NumericUpDown maxOperationNumericUpDown;
        private System.Windows.Forms.Label maxIterationLabel;
    }
}


namespace neuros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TeachButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPictureButton = new System.Windows.Forms.Button();
            this.RecognizeButton = new System.Windows.Forms.Button();
            this.DirectoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar1.ForeColor = System.Drawing.Color.Green;
            this.progressBar1.Location = new System.Drawing.Point(177, 22);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(478, 35);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 36;
            this.progressBar1.Visible = false;
            // 
            // TeachButton
            // 
            this.TeachButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TeachButton.BackgroundImage")));
            this.TeachButton.Location = new System.Drawing.Point(177, 22);
            this.TeachButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TeachButton.Name = "TeachButton";
            this.TeachButton.Size = new System.Drawing.Size(478, 35);
            this.TeachButton.TabIndex = 33;
            this.TeachButton.Text = "Обучить";
            this.TeachButton.UseVisualStyleBackColor = true;
            this.TeachButton.Click += new System.EventHandler(this.TeachButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(335, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(19, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.BackColor = System.Drawing.Color.White;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerLabel.Location = new System.Drawing.Point(277, 154);
            this.AnswerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(34, 29);
            this.AnswerLabel.TabIndex = 29;
            this.AnswerLabel.Text = "   ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(172, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ответ:";
            // 
            // AddPictureButton
            // 
            this.AddPictureButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPictureButton.BackgroundImage")));
            this.AddPictureButton.Location = new System.Drawing.Point(177, 112);
            this.AddPictureButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddPictureButton.Name = "AddPictureButton";
            this.AddPictureButton.Size = new System.Drawing.Size(478, 35);
            this.AddPictureButton.TabIndex = 27;
            this.AddPictureButton.Text = "Добавить картинку";
            this.AddPictureButton.UseVisualStyleBackColor = true;
            this.AddPictureButton.Click += new System.EventHandler(this.AddPictureButton_Click);
            // 
            // RecognizeButton
            // 
            this.RecognizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RecognizeButton.BackgroundImage")));
            this.RecognizeButton.Location = new System.Drawing.Point(177, 67);
            this.RecognizeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RecognizeButton.Name = "RecognizeButton";
            this.RecognizeButton.Size = new System.Drawing.Size(478, 35);
            this.RecognizeButton.TabIndex = 26;
            this.RecognizeButton.Text = "Распознать";
            this.RecognizeButton.UseVisualStyleBackColor = true;
            this.RecognizeButton.Click += new System.EventHandler(this.RecognizeButton_Click);
            // 
            // DirectoryLabel
            // 
            this.DirectoryLabel.AutoSize = true;
            this.DirectoryLabel.BackColor = System.Drawing.Color.White;
            this.DirectoryLabel.Location = new System.Drawing.Point(447, 163);
            this.DirectoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DirectoryLabel.Name = "DirectoryLabel";
            this.DirectoryLabel.Size = new System.Drawing.Size(0, 20);
            this.DirectoryLabel.TabIndex = 37;
            this.DirectoryLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 204);
            this.Controls.Add(this.DirectoryLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPictureButton);
            this.Controls.Add(this.RecognizeButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.TeachButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button TeachButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddPictureButton;
        private System.Windows.Forms.Button RecognizeButton;
        private System.Windows.Forms.Label DirectoryLabel;
    }
}


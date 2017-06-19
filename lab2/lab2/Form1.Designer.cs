namespace lab2
{
    partial class pyramidDecButton
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openImageFile = new System.Windows.Forms.Button();
            this.pyrDecButton = new System.Windows.Forms.Button();
            this.findContoursButton = new System.Windows.Forms.Button();
            this.thresholdButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openImageFile
            // 
            this.openImageFile.Location = new System.Drawing.Point(12, 425);
            this.openImageFile.Name = "openImageFile";
            this.openImageFile.Size = new System.Drawing.Size(98, 29);
            this.openImageFile.TabIndex = 3;
            this.openImageFile.Text = "Open Image";
            this.openImageFile.UseVisualStyleBackColor = true;
            this.openImageFile.Click += new System.EventHandler(this.openImageFile_Click);
            // 
            // pyrDecButton
            // 
            this.pyrDecButton.Location = new System.Drawing.Point(116, 425);
            this.pyrDecButton.Name = "pyrDecButton";
            this.pyrDecButton.Size = new System.Drawing.Size(265, 29);
            this.pyrDecButton.TabIndex = 4;
            this.pyrDecButton.Text = "Apply gaussian pyramid decomposition";
            this.pyrDecButton.UseVisualStyleBackColor = true;
            this.pyrDecButton.Click += new System.EventHandler(this.pyrDecButton_Click);
            // 
            // findContoursButton
            // 
            this.findContoursButton.Location = new System.Drawing.Point(12, 496);
            this.findContoursButton.Name = "findContoursButton";
            this.findContoursButton.Size = new System.Drawing.Size(115, 29);
            this.findContoursButton.TabIndex = 5;
            this.findContoursButton.Text = "Find Contours";
            this.findContoursButton.UseVisualStyleBackColor = true;
            this.findContoursButton.Click += new System.EventHandler(this.findContoursButton_Click);
            // 
            // thresholdButton
            // 
            this.thresholdButton.Location = new System.Drawing.Point(234, 461);
            this.thresholdButton.Name = "thresholdButton";
            this.thresholdButton.Size = new System.Drawing.Size(147, 29);
            this.thresholdButton.TabIndex = 6;
            this.thresholdButton.Text = "Apply Threshold";
            this.thresholdButton.UseVisualStyleBackColor = true;
            this.thresholdButton.Click += new System.EventHandler(this.thresholdButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Threshold:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 461);
            this.textBox1.MinimumSize = new System.Drawing.Size(4, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 22);
            this.textBox1.TabIndex = 8;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 13);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(528, 389);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(557, 12);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(532, 390);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Triangles",
            "Rectangles",
            "Circles"});
            this.comboBox1.Location = new System.Drawing.Point(426, 428);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 499);
            this.textBox2.MinimumSize = new System.Drawing.Size(4, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 29);
            this.textBox2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "minArea:";
            // 
            // pyramidDecButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 581);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thresholdButton);
            this.Controls.Add(this.findContoursButton);
            this.Controls.Add(this.pyrDecButton);
            this.Controls.Add(this.openImageFile);
            this.Name = "pyramidDecButton";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openImageFile;
        private System.Windows.Forms.Button pyrDecButton;
        private System.Windows.Forms.Button findContoursButton;
        private System.Windows.Forms.Button thresholdButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}


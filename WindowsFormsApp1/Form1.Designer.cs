namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.showImageBtn = new System.Windows.Forms.Button();
            this.convertToGrayBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.splitImageBtn = new System.Windows.Forms.Button();
            this.sobelImageBtn = new System.Windows.Forms.Button();
            this.deleteImageBtn = new System.Windows.Forms.Button();
            this.gauseFilterBtn = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.resizeGroupBox = new System.Windows.Forms.GroupBox();
            this.resizedListBox = new System.Windows.Forms.ListBox();
            this.resizeButton = new System.Windows.Forms.Button();
            this.newSizeLabel = new System.Windows.Forms.Label();
            this.newSizeList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.resizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // showImageBtn
            // 
            this.showImageBtn.Location = new System.Drawing.Point(27, 493);
            this.showImageBtn.Name = "showImageBtn";
            this.showImageBtn.Size = new System.Drawing.Size(201, 44);
            this.showImageBtn.TabIndex = 0;
            this.showImageBtn.Text = "Show Image";
            this.showImageBtn.UseVisualStyleBackColor = true;
            this.showImageBtn.Click += new System.EventHandler(this.show_image_btn);
            // 
            // convertToGrayBtn
            // 
            this.convertToGrayBtn.Enabled = false;
            this.convertToGrayBtn.Location = new System.Drawing.Point(27, 543);
            this.convertToGrayBtn.Name = "convertToGrayBtn";
            this.convertToGrayBtn.Size = new System.Drawing.Size(201, 44);
            this.convertToGrayBtn.TabIndex = 2;
            this.convertToGrayBtn.Text = "Convert to Gray";
            this.convertToGrayBtn.UseVisualStyleBackColor = true;
            this.convertToGrayBtn.Click += new System.EventHandler(this.convert_to_gray_btn);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Open File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.open_file_btn);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 439);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "C:\\Users\\malco\\OneDrive\\Pictures\\_DSC2173.JPG";
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 368);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(556, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(447, 368);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // splitImageBtn
            // 
            this.splitImageBtn.Enabled = false;
            this.splitImageBtn.Location = new System.Drawing.Point(281, 493);
            this.splitImageBtn.Name = "splitImageBtn";
            this.splitImageBtn.Size = new System.Drawing.Size(197, 44);
            this.splitImageBtn.TabIndex = 7;
            this.splitImageBtn.Text = "Split Image";
            this.splitImageBtn.UseVisualStyleBackColor = true;
            this.splitImageBtn.Click += new System.EventHandler(this.split_image_btn);
            // 
            // sobelImageBtn
            // 
            this.sobelImageBtn.Enabled = false;
            this.sobelImageBtn.Location = new System.Drawing.Point(281, 543);
            this.sobelImageBtn.Name = "sobelImageBtn";
            this.sobelImageBtn.Size = new System.Drawing.Size(197, 44);
            this.sobelImageBtn.TabIndex = 8;
            this.sobelImageBtn.Text = "Sobel";
            this.sobelImageBtn.UseVisualStyleBackColor = true;
            this.sobelImageBtn.Click += new System.EventHandler(this.sobel_btn);
            // 
            // deleteImageBtn
            // 
            this.deleteImageBtn.Enabled = false;
            this.deleteImageBtn.Location = new System.Drawing.Point(27, 593);
            this.deleteImageBtn.Name = "deleteImageBtn";
            this.deleteImageBtn.Size = new System.Drawing.Size(201, 44);
            this.deleteImageBtn.TabIndex = 9;
            this.deleteImageBtn.Text = "Delete Image";
            this.deleteImageBtn.UseVisualStyleBackColor = true;
            this.deleteImageBtn.Click += new System.EventHandler(this.delete_image_btn);
            // 
            // gauseFilterBtn
            // 
            this.gauseFilterBtn.Enabled = false;
            this.gauseFilterBtn.Location = new System.Drawing.Point(281, 593);
            this.gauseFilterBtn.Name = "gauseFilterBtn";
            this.gauseFilterBtn.Size = new System.Drawing.Size(197, 44);
            this.gauseFilterBtn.TabIndex = 10;
            this.gauseFilterBtn.Text = "Gause Filter";
            this.gauseFilterBtn.UseVisualStyleBackColor = true;
            this.gauseFilterBtn.Click += new System.EventHandler(this.gause_filter_btn);
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Enabled = false;
            this.R.Location = new System.Drawing.Point(641, 441);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(38, 20);
            this.R.TabIndex = 12;
            this.R.Text = "R";
            this.R.UseVisualStyleBackColor = true;
            this.R.CheckedChanged += new System.EventHandler(this.R_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(718, 441);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(38, 20);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.Text = "G";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(790, 441);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 20);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "B";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(876, 441);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 20);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "RGB";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(906, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(556, 481);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(314, 56);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(906, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // resizeGroupBox
            // 
            this.resizeGroupBox.Controls.Add(this.resizedListBox);
            this.resizeGroupBox.Controls.Add(this.resizeButton);
            this.resizeGroupBox.Controls.Add(this.newSizeLabel);
            this.resizeGroupBox.Controls.Add(this.newSizeList);
            this.resizeGroupBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.resizeGroupBox.Enabled = false;
            this.resizeGroupBox.Location = new System.Drawing.Point(556, 537);
            this.resizeGroupBox.Name = "resizeGroupBox";
            this.resizeGroupBox.Size = new System.Drawing.Size(447, 100);
            this.resizeGroupBox.TabIndex = 16;
            this.resizeGroupBox.TabStop = false;
            this.resizeGroupBox.Text = "Resize";
            // 
            // resizedListBox
            // 
            this.resizedListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.resizedListBox.FormattingEnabled = true;
            this.resizedListBox.ItemHeight = 16;
            this.resizedListBox.Location = new System.Drawing.Point(274, 16);
            this.resizedListBox.Name = "resizedListBox";
            this.resizedListBox.Size = new System.Drawing.Size(120, 84);
            this.resizedListBox.TabIndex = 3;
            this.resizedListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // resizeButton
            // 
            this.resizeButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.resizeButton.Location = new System.Drawing.Point(131, 59);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(75, 23);
            this.resizeButton.TabIndex = 2;
            this.resizeButton.Text = "Resize";
            this.resizeButton.UseVisualStyleBackColor = true;
            this.resizeButton.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // newSizeLabel
            // 
            this.newSizeLabel.AutoSize = true;
            this.newSizeLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.newSizeLabel.Location = new System.Drawing.Point(6, 29);
            this.newSizeLabel.Name = "newSizeLabel";
            this.newSizeLabel.Size = new System.Drawing.Size(63, 16);
            this.newSizeLabel.TabIndex = 1;
            this.newSizeLabel.Text = "New Size";
            // 
            // newSizeList
            // 
            this.newSizeList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.newSizeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newSizeList.FormattingEnabled = true;
            this.newSizeList.Items.AddRange(new object[] {
            "100x100",
            "200x200",
            "300x300"});
            this.newSizeList.Location = new System.Drawing.Point(85, 29);
            this.newSizeList.Name = "newSizeList";
            this.newSizeList.Size = new System.Drawing.Size(121, 24);
            this.newSizeList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 684);
            this.Controls.Add(this.resizeGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.R);
            this.Controls.Add(this.gauseFilterBtn);
            this.Controls.Add(this.deleteImageBtn);
            this.Controls.Add(this.sobelImageBtn);
            this.Controls.Add(this.splitImageBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.convertToGrayBtn);
            this.Controls.Add(this.showImageBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Image";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.resizeGroupBox.ResumeLayout(false);
            this.resizeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showImageBtn;
        private System.Windows.Forms.Button convertToGrayBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button splitImageBtn;
        private System.Windows.Forms.Button sobelImageBtn;
        private System.Windows.Forms.Button deleteImageBtn;
        private System.Windows.Forms.Button gauseFilterBtn;
        private System.Windows.Forms.RadioButton R;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox resizeGroupBox;
        private System.Windows.Forms.ComboBox newSizeList;
        private System.Windows.Forms.Label newSizeLabel;
        private System.Windows.Forms.Button resizeButton;
        private System.Windows.Forms.ListBox resizedListBox;
    }
}


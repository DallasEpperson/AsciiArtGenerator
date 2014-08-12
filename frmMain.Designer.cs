namespace AsciiArtGenerator
{
    partial class frmMain
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblCharactersPrepared = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblImagePrepared = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFontWeight = new System.Windows.Forms.Label();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.lblFontName = new System.Windows.Forms.Label();
            this.btnChooseFont = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.picInput = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(201, 220);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(64, 19);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblCharactersPrepared
            // 
            this.lblCharactersPrepared.AutoSize = true;
            this.lblCharactersPrepared.Location = new System.Drawing.Point(230, 164);
            this.lblCharactersPrepared.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCharactersPrepared.Name = "lblCharactersPrepared";
            this.lblCharactersPrepared.Size = new System.Drawing.Size(104, 13);
            this.lblCharactersPrepared.TabIndex = 13;
            this.lblCharactersPrepared.Text = "Characters Prepared";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox2.Location = new System.Drawing.Point(202, 159);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 19);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // lblImagePrepared
            // 
            this.lblImagePrepared.AutoSize = true;
            this.lblImagePrepared.Location = new System.Drawing.Point(230, 137);
            this.lblImagePrepared.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImagePrepared.Name = "lblImagePrepared";
            this.lblImagePrepared.Size = new System.Drawing.Size(82, 13);
            this.lblImagePrepared.TabIndex = 11;
            this.lblImagePrepared.Text = "Image Prepared";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Location = new System.Drawing.Point(202, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFontWeight);
            this.groupBox2.Controls.Add(this.lblFontSize);
            this.groupBox2.Controls.Add(this.lblFontName);
            this.groupBox2.Controls.Add(this.btnChooseFont);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(212, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(156, 89);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Font Parameters";
            // 
            // lblFontWeight
            // 
            this.lblFontWeight.AutoSize = true;
            this.lblFontWeight.Location = new System.Drawing.Point(57, 45);
            this.lblFontWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFontWeight.Name = "lblFontWeight";
            this.lblFontWeight.Size = new System.Drawing.Size(35, 13);
            this.lblFontWeight.TabIndex = 6;
            this.lblFontWeight.Text = "label4";
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(43, 30);
            this.lblFontSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(35, 13);
            this.lblFontSize.TabIndex = 5;
            this.lblFontSize.Text = "label4";
            // 
            // lblFontName
            // 
            this.lblFontName.AutoSize = true;
            this.lblFontName.Location = new System.Drawing.Point(51, 16);
            this.lblFontName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFontName.Name = "lblFontName";
            this.lblFontName.Size = new System.Drawing.Size(35, 13);
            this.lblFontName.TabIndex = 4;
            this.lblFontName.Text = "label4";
            // 
            // btnChooseFont
            // 
            this.btnChooseFont.Location = new System.Drawing.Point(95, 63);
            this.btnChooseFont.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseFont.Name = "btnChooseFont";
            this.btnChooseFont.Size = new System.Drawing.Size(56, 19);
            this.btnChooseFont.TabIndex = 3;
            this.btnChooseFont.Text = "Choose...";
            this.btnChooseFont.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseImage);
            this.groupBox1.Controls.Add(this.picInput);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 167);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Image";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(5, 144);
            this.btnBrowseImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(56, 19);
            this.btnBrowseImage.TabIndex = 1;
            this.btnBrowseImage.Text = "Browse...";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            // 
            // picInput
            // 
            this.picInput.Location = new System.Drawing.Point(5, 18);
            this.picInput.Margin = new System.Windows.Forms.Padding(2);
            this.picInput.Name = "picInput";
            this.picInput.Size = new System.Drawing.Size(140, 95);
            this.picInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInput.TabIndex = 0;
            this.picInput.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 248);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblCharactersPrepared);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblImagePrepared);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblCharactersPrepared;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblImagePrepared;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFontWeight;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.Label lblFontName;
        private System.Windows.Forms.Button btnChooseFont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.PictureBox picInput;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}


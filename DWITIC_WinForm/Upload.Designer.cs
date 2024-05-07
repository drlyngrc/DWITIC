namespace DWITIC_WinForm
{
    partial class Upload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upload));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClassify = new System.Windows.Forms.Button();
            this.btnUploadNow = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(26, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(446, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(764, 150);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 400);
            this.textBox1.TabIndex = 2;
            // 
            // btnClassify
            // 
            this.btnClassify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClassify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassify.Image = global::DWITIC_WinForm.Properties.Resources.icons8_catalog_25;
            this.btnClassify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassify.Location = new System.Drawing.Point(238, 91);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnClassify.Size = new System.Drawing.Size(135, 44);
            this.btnClassify.TabIndex = 5;
            this.btnClassify.Text = "      CLASSIFY";
            this.btnClassify.UseVisualStyleBackColor = true;
            this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // btnUploadNow
            // 
            this.btnUploadNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadNow.Image = global::DWITIC_WinForm.Properties.Resources.icons8_upload_24;
            this.btnUploadNow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadNow.Location = new System.Drawing.Point(81, 91);
            this.btnUploadNow.Name = "btnUploadNow";
            this.btnUploadNow.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUploadNow.Size = new System.Drawing.Size(135, 44);
            this.btnUploadNow.TabIndex = 4;
            this.btnUploadNow.Text = "    UPLOAD";
            this.btnUploadNow.UseVisualStyleBackColor = true;
            this.btnUploadNow.Click += new System.EventHandler(this.btnUploadNow_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Image = global::DWITIC_WinForm.Properties.Resources.icons8_back_50;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(55, 55);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DWITIC_WinForm.Properties.Resources._440054786_792038046192240_5215925064332758294_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1188, 656);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnClassify);
            this.Controls.Add(this.btnUploadNow);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Upload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DWITIC | UPLOAD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClassify;
        private System.Windows.Forms.Button btnUploadNow;
        private System.Windows.Forms.Button btnReturn;
    }
}
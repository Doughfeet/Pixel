namespace FindPixel
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
            this.PictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.PictureBoxFind = new System.Windows.Forms.PictureBox();
            this.BtnFindObject = new System.Windows.Forms.Button();
            this.BtnOpenPicture = new System.Windows.Forms.Button();
            this.BtnCompare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFind)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxOriginal
            // 
            this.PictureBoxOriginal.Location = new System.Drawing.Point(99, 114);
            this.PictureBoxOriginal.Name = "PictureBoxOriginal";
            this.PictureBoxOriginal.Size = new System.Drawing.Size(539, 523);
            this.PictureBoxOriginal.TabIndex = 0;
            this.PictureBoxOriginal.TabStop = false;
            // 
            // PictureBoxFind
            // 
            this.PictureBoxFind.Location = new System.Drawing.Point(715, 114);
            this.PictureBoxFind.Name = "PictureBoxFind";
            this.PictureBoxFind.Size = new System.Drawing.Size(539, 523);
            this.PictureBoxFind.TabIndex = 0;
            this.PictureBoxFind.TabStop = false;
            // 
            // BtnFindObject
            // 
            this.BtnFindObject.Location = new System.Drawing.Point(715, 672);
            this.BtnFindObject.Name = "BtnFindObject";
            this.BtnFindObject.Size = new System.Drawing.Size(262, 75);
            this.BtnFindObject.TabIndex = 1;
            this.BtnFindObject.Text = "Open Object";
            this.BtnFindObject.UseVisualStyleBackColor = true;
            this.BtnFindObject.Click += new System.EventHandler(this.BtnFindObject_Click);
            // 
            // BtnOpenPicture
            // 
            this.BtnOpenPicture.Location = new System.Drawing.Point(99, 672);
            this.BtnOpenPicture.Name = "BtnOpenPicture";
            this.BtnOpenPicture.Size = new System.Drawing.Size(262, 75);
            this.BtnOpenPicture.TabIndex = 1;
            this.BtnOpenPicture.Text = "Open Picture";
            this.BtnOpenPicture.UseVisualStyleBackColor = true;
            this.BtnOpenPicture.Click += new System.EventHandler(this.BtnOpenPicture_Click);
            // 
            // BtnCompare
            // 
            this.BtnCompare.Location = new System.Drawing.Point(552, 894);
            this.BtnCompare.Name = "BtnCompare";
            this.BtnCompare.Size = new System.Drawing.Size(262, 75);
            this.BtnCompare.TabIndex = 1;
            this.BtnCompare.Text = "Compare";
            this.BtnCompare.UseVisualStyleBackColor = true;
            this.BtnCompare.Click += new System.EventHandler(this.BtnCompare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 1120);
            this.Controls.Add(this.BtnOpenPicture);
            this.Controls.Add(this.BtnCompare);
            this.Controls.Add(this.BtnFindObject);
            this.Controls.Add(this.PictureBoxFind);
            this.Controls.Add(this.PictureBoxOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxOriginal;
        private System.Windows.Forms.PictureBox PictureBoxFind;
        private System.Windows.Forms.Button BtnFindObject;
        private System.Windows.Forms.Button BtnOpenPicture;
        private System.Windows.Forms.Button BtnCompare;
    }
}


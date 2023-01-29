namespace QMS
{
    partial class CompleteScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompleteScreen));
            this.lbl_DashHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundedbtn1 = new QMS.roundedbtn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DashHeader
            // 
            this.lbl_DashHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_DashHeader.AutoSize = true;
            this.lbl_DashHeader.Font = new System.Drawing.Font("Inter Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DashHeader.Location = new System.Drawing.Point(262, 55);
            this.lbl_DashHeader.Name = "lbl_DashHeader";
            this.lbl_DashHeader.Size = new System.Drawing.Size(275, 25);
            this.lbl_DashHeader.TabIndex = 27;
            this.lbl_DashHeader.Text = "Thank You For Using QMS";
            this.lbl_DashHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(245, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 262);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // roundedbtn1
            // 
            this.roundedbtn1.BackColor = System.Drawing.Color.MidnightBlue;
            this.roundedbtn1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.roundedbtn1.BorderColor = System.Drawing.Color.Tomato;
            this.roundedbtn1.BorderRadius = 23;
            this.roundedbtn1.BorderSize = 0;
            this.roundedbtn1.FlatAppearance.BorderSize = 0;
            this.roundedbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedbtn1.Font = new System.Drawing.Font("Inter Medium", 12.5F, System.Drawing.FontStyle.Bold);
            this.roundedbtn1.ForeColor = System.Drawing.Color.White;
            this.roundedbtn1.Location = new System.Drawing.Point(332, 342);
            this.roundedbtn1.Name = "roundedbtn1";
            this.roundedbtn1.Size = new System.Drawing.Size(122, 50);
            this.roundedbtn1.TabIndex = 28;
            this.roundedbtn1.Text = "Log Back";
            this.roundedbtn1.TextColor = System.Drawing.Color.White;
            this.roundedbtn1.UseVisualStyleBackColor = false;
            this.roundedbtn1.Click += new System.EventHandler(this.roundedbtn1_Click);
            // 
            // CompleteScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundedbtn1);
            this.Controls.Add(this.lbl_DashHeader);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompleteScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompleteScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DashHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private roundedbtn roundedbtn1;
    }
}
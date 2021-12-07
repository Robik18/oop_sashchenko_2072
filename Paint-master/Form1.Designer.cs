namespace _1.draw
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorlbl = new System.Windows.Forms.Label();
            this.linebtn = new System.Windows.Forms.Button();
            this.circlebtn = new System.Windows.Forms.Button();
            this.rectbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(124, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1025, 565);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // colorlbl
            // 
            this.colorlbl.BackColor = System.Drawing.Color.Red;
            this.colorlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorlbl.Location = new System.Drawing.Point(16, 9);
            this.colorlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorlbl.Name = "colorlbl";
            this.colorlbl.Size = new System.Drawing.Size(25, 20);
            this.colorlbl.TabIndex = 1;
            this.colorlbl.Click += new System.EventHandler(this.colorlbl_Click);
            // 
            // linebtn
            // 
            this.linebtn.BackColor = System.Drawing.SystemColors.Info;
            this.linebtn.Location = new System.Drawing.Point(13, 142);
            this.linebtn.Margin = new System.Windows.Forms.Padding(4);
            this.linebtn.Name = "linebtn";
            this.linebtn.Size = new System.Drawing.Size(100, 79);
            this.linebtn.TabIndex = 2;
            this.linebtn.Text = "Line";
            this.linebtn.UseVisualStyleBackColor = false;
            this.linebtn.Click += new System.EventHandler(this.linebtn_Click);
            // 
            // circlebtn
            // 
            this.circlebtn.BackColor = System.Drawing.SystemColors.Info;
            this.circlebtn.Location = new System.Drawing.Point(13, 250);
            this.circlebtn.Margin = new System.Windows.Forms.Padding(4);
            this.circlebtn.Name = "circlebtn";
            this.circlebtn.Size = new System.Drawing.Size(100, 79);
            this.circlebtn.TabIndex = 3;
            this.circlebtn.Text = "Circle";
            this.circlebtn.UseVisualStyleBackColor = false;
            this.circlebtn.Click += new System.EventHandler(this.circlebtn_Click);
            // 
            // rectbtn
            // 
            this.rectbtn.BackColor = System.Drawing.SystemColors.Info;
            this.rectbtn.Location = new System.Drawing.Point(13, 355);
            this.rectbtn.Margin = new System.Windows.Forms.Padding(4);
            this.rectbtn.Name = "rectbtn";
            this.rectbtn.Size = new System.Drawing.Size(100, 75);
            this.rectbtn.TabIndex = 4;
            this.rectbtn.Text = "Rectangle";
            this.rectbtn.UseVisualStyleBackColor = false;
            this.rectbtn.Click += new System.EventHandler(this.rectbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1163, 631);
            this.Controls.Add(this.rectbtn);
            this.Controls.Add(this.circlebtn);
            this.Controls.Add(this.linebtn);
            this.Controls.Add(this.colorlbl);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(378, 352);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint++";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label colorlbl;
        private System.Windows.Forms.Button linebtn;
        private System.Windows.Forms.Button circlebtn;
        private System.Windows.Forms.Button rectbtn;
    }
}


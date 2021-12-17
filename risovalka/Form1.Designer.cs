namespace task_paint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FormClear = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.Cirlce = new System.Windows.Forms.RadioButton();
            this.Wagon = new System.Windows.Forms.RadioButton();
            this.WagonCoal = new System.Windows.Forms.RadioButton();
            this.Train = new System.Windows.Forms.RadioButton();
            this.Move = new System.Windows.Forms.RadioButton();
            this.Height = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.MinimumSize = new System.Drawing.Size(1333, 615);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1999, 1230);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // FormClear
            // 
            this.FormClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormClear.Location = new System.Drawing.Point(16, 12);
            this.FormClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FormClear.Name = "FormClear";
            this.FormClear.Size = new System.Drawing.Size(160, 58);
            this.FormClear.TabIndex = 10;
            this.FormClear.Text = "Очистить";
            this.FormClear.UseVisualStyleBackColor = false;
            this.FormClear.Click += new System.EventHandler(this.FormClear_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(403, 15);
            this.Rectangle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(130, 21);
            this.Rectangle.TabIndex = 11;
            this.Rectangle.TabStop = true;
            this.Rectangle.Text = "Прямоугольник";
            this.Rectangle.UseVisualStyleBackColor = true;
            // 
            // Cirlce
            // 
            this.Cirlce.AutoSize = true;
            this.Cirlce.Location = new System.Drawing.Point(551, 15);
            this.Cirlce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cirlce.Name = "Cirlce";
            this.Cirlce.Size = new System.Drawing.Size(58, 21);
            this.Cirlce.TabIndex = 12;
            this.Cirlce.TabStop = true;
            this.Cirlce.Text = "Круг";
            this.Cirlce.UseVisualStyleBackColor = true;
            // 
            // Wagon
            // 
            this.Wagon.AutoSize = true;
            this.Wagon.Location = new System.Drawing.Point(623, 15);
            this.Wagon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Wagon.Name = "Wagon";
            this.Wagon.Size = new System.Drawing.Size(67, 21);
            this.Wagon.TabIndex = 13;
            this.Wagon.TabStop = true;
            this.Wagon.Text = "Вагон";
            this.Wagon.UseVisualStyleBackColor = true;
            // 
            // WagonCoal
            // 
            this.WagonCoal.AutoSize = true;
            this.WagonCoal.Location = new System.Drawing.Point(704, 15);
            this.WagonCoal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WagonCoal.Name = "WagonCoal";
            this.WagonCoal.Size = new System.Drawing.Size(129, 21);
            this.WagonCoal.TabIndex = 14;
            this.WagonCoal.TabStop = true;
            this.WagonCoal.Text = "Вагон с песком";
            this.WagonCoal.UseVisualStyleBackColor = true;
            // 
            // Train
            // 
            this.Train.AutoSize = true;
            this.Train.Location = new System.Drawing.Point(852, 15);
            this.Train.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(70, 21);
            this.Train.TabIndex = 15;
            this.Train.TabStop = true;
            this.Train.Text = "Поезд";
            this.Train.UseVisualStyleBackColor = true;
            // 
            // Move
            // 
            this.Move.AutoSize = true;
            this.Move.Location = new System.Drawing.Point(936, 15);
            this.Move.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(123, 21);
            this.Move.TabIndex = 16;
            this.Move.TabStop = true;
            this.Move.Text = "Перемещение";
            this.Move.UseVisualStyleBackColor = true;
            // 
            // Height
            // 
            this.Height.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Height.Location = new System.Drawing.Point(192, 46);
            this.Height.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(60, 22);
            this.Height.TabIndex = 17;
            this.Height.Text = "100";
            // 
            // Width
            // 
            this.Width.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Width.Location = new System.Drawing.Point(260, 46);
            this.Width.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(60, 22);
            this.Width.TabIndex = 18;
            this.Width.Text = "200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Высота";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ширина";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1067, 594);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Move);
            this.Controls.Add(this.Train);
            this.Controls.Add(this.WagonCoal);
            this.Controls.Add(this.Wagon);
            this.Controls.Add(this.Cirlce);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.FormClear);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FormClear;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.RadioButton Cirlce;
        private System.Windows.Forms.RadioButton Wagon;
        private System.Windows.Forms.RadioButton WagonCoal;
        private System.Windows.Forms.RadioButton Train;
        private System.Windows.Forms.RadioButton Move;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


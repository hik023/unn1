namespace lab
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
            this.tbX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.lWidth = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.lHeight = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.lRadius = new System.Windows.Forms.Label();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.cbFigure = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDrawCircles = new System.Windows.Forms.Button();
            this.btnDrawAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(107, 38);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(52, 20);
            this.tbX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(107, 64);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(52, 20);
            this.tbY.TabIndex = 2;
            // 
            // lWidth
            // 
            this.lWidth.AutoSize = true;
            this.lWidth.Enabled = false;
            this.lWidth.Location = new System.Drawing.Point(12, 165);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(46, 13);
            this.lWidth.TabIndex = 5;
            this.lWidth.Text = "Ширина";
            // 
            // tbWidth
            // 
            this.tbWidth.Enabled = false;
            this.tbWidth.Location = new System.Drawing.Point(63, 162);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(52, 20);
            this.tbWidth.TabIndex = 4;
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Enabled = false;
            this.lHeight.Location = new System.Drawing.Point(13, 191);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(45, 13);
            this.lHeight.TabIndex = 7;
            this.lHeight.Text = "Высота";
            // 
            // tbHeight
            // 
            this.tbHeight.Enabled = false;
            this.tbHeight.Location = new System.Drawing.Point(63, 188);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(52, 20);
            this.tbHeight.TabIndex = 6;
            // 
            // lRadius
            // 
            this.lRadius.AutoSize = true;
            this.lRadius.Enabled = false;
            this.lRadius.Location = new System.Drawing.Point(134, 178);
            this.lRadius.Name = "lRadius";
            this.lRadius.Size = new System.Drawing.Size(43, 13);
            this.lRadius.TabIndex = 9;
            this.lRadius.Text = "Радиус";
            // 
            // tbRadius
            // 
            this.tbRadius.Enabled = false;
            this.tbRadius.Location = new System.Drawing.Point(183, 175);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(52, 20);
            this.tbRadius.TabIndex = 8;
            // 
            // cbFigure
            // 
            this.cbFigure.FormattingEnabled = true;
            this.cbFigure.Items.AddRange(new object[] {
            "Окружность",
            "Прямоугольник"});
            this.cbFigure.Location = new System.Drawing.Point(93, 112);
            this.cbFigure.Name = "cbFigure";
            this.cbFigure.Size = new System.Drawing.Size(121, 21);
            this.cbFigure.TabIndex = 10;
            this.cbFigure.SelectedIndexChanged += new System.EventHandler(this.cbFigure_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Фигура";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(93, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDrawCircles
            // 
            this.btnDrawCircles.Location = new System.Drawing.Point(44, 290);
            this.btnDrawCircles.Name = "btnDrawCircles";
            this.btnDrawCircles.Size = new System.Drawing.Size(174, 23);
            this.btnDrawCircles.TabIndex = 13;
            this.btnDrawCircles.Text = "Нарисовать окружности";
            this.btnDrawCircles.UseVisualStyleBackColor = true;
            this.btnDrawCircles.Click += new System.EventHandler(this.btnDrawCircles_Click);
            // 
            // btnDrawAll
            // 
            this.btnDrawAll.Location = new System.Drawing.Point(73, 319);
            this.btnDrawAll.Name = "btnDrawAll";
            this.btnDrawAll.Size = new System.Drawing.Size(113, 23);
            this.btnDrawAll.TabIndex = 14;
            this.btnDrawAll.Text = "Нарисовать всё";
            this.btnDrawAll.UseVisualStyleBackColor = true;
            this.btnDrawAll.Click += new System.EventHandler(this.btnDrawAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 357);
            this.Controls.Add(this.btnDrawAll);
            this.Controls.Add(this.btnDrawCircles);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbFigure);
            this.Controls.Add(this.lRadius);
            this.Controls.Add(this.tbRadius);
            this.Controls.Add(this.lHeight);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.lWidth);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label lWidth;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label lRadius;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.ComboBox cbFigure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDrawCircles;
        private System.Windows.Forms.Button btnDrawAll;
    }
}


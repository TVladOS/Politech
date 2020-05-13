namespace lab4
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.x1NameBox = new System.Windows.Forms.TextBox();
            this.x1Label = new System.Windows.Forms.Label();
            this.xyLabel1 = new System.Windows.Forms.Label();
            this.x1TextBox = new System.Windows.Forms.TextBox();
            this.y1TextBox = new System.Windows.Forms.TextBox();
            this.savePointBtn = new System.Windows.Forms.Button();
            this.Triengle = new System.Windows.Forms.PictureBox();
            this.y2TextBox = new System.Windows.Forms.TextBox();
            this.xyLabel2 = new System.Windows.Forms.Label();
            this.x2TextBox = new System.Windows.Forms.TextBox();
            this.x2label = new System.Windows.Forms.Label();
            this.x2NameBox = new System.Windows.Forms.TextBox();
            this.y3TextBox = new System.Windows.Forms.TextBox();
            this.xyLabel3 = new System.Windows.Forms.Label();
            this.x3TextBox = new System.Windows.Forms.TextBox();
            this.x3label = new System.Windows.Forms.Label();
            this.x3NameBox = new System.Windows.Forms.TextBox();
            this.richTextTriengleInfo = new System.Windows.Forms.RichTextBox();
            this.RndFillBtn = new System.Windows.Forms.Button();
            this.AmoutLabel = new System.Windows.Forms.Label();
            this.AmoutTextBox = new System.Windows.Forms.TextBox();
            this.InitAmoutBtn = new System.Windows.Forms.Button();
            this.TriangleNumLabel = new System.Windows.Forms.Label();
            this.TriangleNumBox = new System.Windows.Forms.TextBox();
            this.TabCosBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Triengle)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Location = new System.Drawing.Point(739, 33);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(96, 41);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // x1NameBox
            // 
            this.x1NameBox.Enabled = false;
            this.x1NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x1NameBox.Location = new System.Drawing.Point(161, 36);
            this.x1NameBox.Name = "x1NameBox";
            this.x1NameBox.Size = new System.Drawing.Size(30, 29);
            this.x1NameBox.TabIndex = 7;
            // 
            // x1Label
            // 
            this.x1Label.AutoSize = true;
            this.x1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x1Label.Location = new System.Drawing.Point(162, 20);
            this.x1Label.Name = "x1Label";
            this.x1Label.Size = new System.Drawing.Size(29, 13);
            this.x1Label.TabIndex = 2;
            this.x1Label.Text = "Имя";
            // 
            // xyLabel1
            // 
            this.xyLabel1.AutoSize = true;
            this.xyLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xyLabel1.Location = new System.Drawing.Point(213, 16);
            this.xyLabel1.Name = "xyLabel1";
            this.xyLabel1.Size = new System.Drawing.Size(35, 17);
            this.xyLabel1.TabIndex = 4;
            this.xyLabel1.Text = "(x,y)";
            // 
            // x1TextBox
            // 
            this.x1TextBox.Enabled = false;
            this.x1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x1TextBox.Location = new System.Drawing.Point(197, 36);
            this.x1TextBox.Name = "x1TextBox";
            this.x1TextBox.Size = new System.Drawing.Size(28, 29);
            this.x1TextBox.TabIndex = 9;
            // 
            // y1TextBox
            // 
            this.y1TextBox.Enabled = false;
            this.y1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y1TextBox.Location = new System.Drawing.Point(231, 36);
            this.y1TextBox.Name = "y1TextBox";
            this.y1TextBox.Size = new System.Drawing.Size(28, 29);
            this.y1TextBox.TabIndex = 11;
            // 
            // savePointBtn
            // 
            this.savePointBtn.Enabled = false;
            this.savePointBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savePointBtn.Location = new System.Drawing.Point(296, 437);
            this.savePointBtn.Name = "savePointBtn";
            this.savePointBtn.Size = new System.Drawing.Size(116, 42);
            this.savePointBtn.TabIndex = 16;
            this.savePointBtn.Text = "Сохранить ";
            this.savePointBtn.UseVisualStyleBackColor = true;
            this.savePointBtn.Click += new System.EventHandler(this.savePointBtn_Click);
            // 
            // Triengle
            // 
            this.Triengle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Triengle.BackgroundImage")));
            this.Triengle.Location = new System.Drawing.Point(12, 70);
            this.Triengle.Name = "Triengle";
            this.Triengle.Size = new System.Drawing.Size(400, 301);
            this.Triengle.TabIndex = 0;
            this.Triengle.TabStop = false;
            // 
            // y2TextBox
            // 
            this.y2TextBox.Enabled = false;
            this.y2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y2TextBox.Location = new System.Drawing.Point(84, 352);
            this.y2TextBox.Name = "y2TextBox";
            this.y2TextBox.Size = new System.Drawing.Size(28, 29);
            this.y2TextBox.TabIndex = 5;
            // 
            // xyLabel2
            // 
            this.xyLabel2.AutoSize = true;
            this.xyLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xyLabel2.Location = new System.Drawing.Point(66, 332);
            this.xyLabel2.Name = "xyLabel2";
            this.xyLabel2.Size = new System.Drawing.Size(35, 17);
            this.xyLabel2.TabIndex = 10;
            this.xyLabel2.Text = "(x,y)";
            // 
            // x2TextBox
            // 
            this.x2TextBox.Enabled = false;
            this.x2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x2TextBox.Location = new System.Drawing.Point(50, 352);
            this.x2TextBox.Name = "x2TextBox";
            this.x2TextBox.Size = new System.Drawing.Size(28, 29);
            this.x2TextBox.TabIndex = 3;
            // 
            // x2label
            // 
            this.x2label.AutoSize = true;
            this.x2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x2label.Location = new System.Drawing.Point(15, 336);
            this.x2label.Name = "x2label";
            this.x2label.Size = new System.Drawing.Size(29, 13);
            this.x2label.TabIndex = 8;
            this.x2label.Text = "Имя";
            // 
            // x2NameBox
            // 
            this.x2NameBox.Enabled = false;
            this.x2NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x2NameBox.Location = new System.Drawing.Point(14, 352);
            this.x2NameBox.Name = "x2NameBox";
            this.x2NameBox.Size = new System.Drawing.Size(30, 29);
            this.x2NameBox.TabIndex = 1;
            // 
            // y3TextBox
            // 
            this.y3TextBox.Enabled = false;
            this.y3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y3TextBox.Location = new System.Drawing.Point(404, 381);
            this.y3TextBox.Name = "y3TextBox";
            this.y3TextBox.Size = new System.Drawing.Size(28, 29);
            this.y3TextBox.TabIndex = 16;
            // 
            // xyLabel3
            // 
            this.xyLabel3.AutoSize = true;
            this.xyLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xyLabel3.Location = new System.Drawing.Point(386, 361);
            this.xyLabel3.Name = "xyLabel3";
            this.xyLabel3.Size = new System.Drawing.Size(35, 17);
            this.xyLabel3.TabIndex = 15;
            this.xyLabel3.Text = "(x,y)";
            // 
            // x3TextBox
            // 
            this.x3TextBox.Enabled = false;
            this.x3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x3TextBox.Location = new System.Drawing.Point(370, 381);
            this.x3TextBox.Name = "x3TextBox";
            this.x3TextBox.Size = new System.Drawing.Size(28, 29);
            this.x3TextBox.TabIndex = 14;
            // 
            // x3label
            // 
            this.x3label.AutoSize = true;
            this.x3label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x3label.Location = new System.Drawing.Point(335, 365);
            this.x3label.Name = "x3label";
            this.x3label.Size = new System.Drawing.Size(29, 13);
            this.x3label.TabIndex = 13;
            this.x3label.Text = "Имя";
            // 
            // x3NameBox
            // 
            this.x3NameBox.Enabled = false;
            this.x3NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x3NameBox.Location = new System.Drawing.Point(334, 381);
            this.x3NameBox.Name = "x3NameBox";
            this.x3NameBox.Size = new System.Drawing.Size(30, 29);
            this.x3NameBox.TabIndex = 12;
            // 
            // richTextTriengleInfo
            // 
            this.richTextTriengleInfo.Location = new System.Drawing.Point(463, 80);
            this.richTextTriengleInfo.Name = "richTextTriengleInfo";
            this.richTextTriengleInfo.ReadOnly = true;
            this.richTextTriengleInfo.Size = new System.Drawing.Size(372, 347);
            this.richTextTriengleInfo.TabIndex = 17;
            this.richTextTriengleInfo.Text = "";
            // 
            // RndFillBtn
            // 
            this.RndFillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RndFillBtn.Location = new System.Drawing.Point(463, 33);
            this.RndFillBtn.Name = "RndFillBtn";
            this.RndFillBtn.Size = new System.Drawing.Size(261, 41);
            this.RndFillBtn.TabIndex = 18;
            this.RndFillBtn.Text = "Рандомное заполнение";
            this.RndFillBtn.UseVisualStyleBackColor = true;
            this.RndFillBtn.Click += new System.EventHandler(this.RndFillBtn_Click);
            // 
            // AmoutLabel
            // 
            this.AmoutLabel.AutoSize = true;
            this.AmoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmoutLabel.Location = new System.Drawing.Point(30, 451);
            this.AmoutLabel.Name = "AmoutLabel";
            this.AmoutLabel.Size = new System.Drawing.Size(90, 17);
            this.AmoutLabel.TabIndex = 19;
            this.AmoutLabel.Text = "Количество:";
            // 
            // AmoutTextBox
            // 
            this.AmoutTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmoutTextBox.Location = new System.Drawing.Point(118, 448);
            this.AmoutTextBox.Name = "AmoutTextBox";
            this.AmoutTextBox.Size = new System.Drawing.Size(32, 23);
            this.AmoutTextBox.TabIndex = 20;
            this.AmoutTextBox.Text = "   ";
            // 
            // InitAmoutBtn
            // 
            this.InitAmoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InitAmoutBtn.Location = new System.Drawing.Point(156, 444);
            this.InitAmoutBtn.Name = "InitAmoutBtn";
            this.InitAmoutBtn.Size = new System.Drawing.Size(69, 31);
            this.InitAmoutBtn.TabIndex = 21;
            this.InitAmoutBtn.Text = "Ввод";
            this.InitAmoutBtn.UseVisualStyleBackColor = true;
            this.InitAmoutBtn.Click += new System.EventHandler(this.InitAmoutBtn_Click);
            // 
            // TriangleNumLabel
            // 
            this.TriangleNumLabel.AutoSize = true;
            this.TriangleNumLabel.Location = new System.Drawing.Point(9, 20);
            this.TriangleNumLabel.Name = "TriangleNumLabel";
            this.TriangleNumLabel.Size = new System.Drawing.Size(113, 13);
            this.TriangleNumLabel.TabIndex = 22;
            this.TriangleNumLabel.Text = "Номер треугольника";
            // 
            // TriangleNumBox
            // 
            this.TriangleNumBox.Enabled = false;
            this.TriangleNumBox.Location = new System.Drawing.Point(20, 36);
            this.TriangleNumBox.Name = "TriangleNumBox";
            this.TriangleNumBox.ReadOnly = true;
            this.TriangleNumBox.Size = new System.Drawing.Size(81, 20);
            this.TriangleNumBox.TabIndex = 23;
            // 
            // TabCosBtn
            // 
            this.TabCosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabCosBtn.Location = new System.Drawing.Point(504, 439);
            this.TabCosBtn.Name = "TabCosBtn";
            this.TabCosBtn.Size = new System.Drawing.Size(296, 40);
            this.TabCosBtn.TabIndex = 24;
            this.TabCosBtn.Text = "Полная таблица косинуса";
            this.TabCosBtn.UseVisualStyleBackColor = true;
            this.TabCosBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Enabled = false;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetBtn.Location = new System.Drawing.Point(334, 36);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(78, 29);
            this.ResetBtn.TabIndex = 25;
            this.ResetBtn.Text = "Сброс";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click_1);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "6";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 491);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.TabCosBtn);
            this.Controls.Add(this.TriangleNumBox);
            this.Controls.Add(this.TriangleNumLabel);
            this.Controls.Add(this.InitAmoutBtn);
            this.Controls.Add(this.AmoutTextBox);
            this.Controls.Add(this.AmoutLabel);
            this.Controls.Add(this.RndFillBtn);
            this.Controls.Add(this.richTextTriengleInfo);
            this.Controls.Add(this.y3TextBox);
            this.Controls.Add(this.xyLabel3);
            this.Controls.Add(this.x3TextBox);
            this.Controls.Add(this.x3label);
            this.Controls.Add(this.x3NameBox);
            this.Controls.Add(this.y2TextBox);
            this.Controls.Add(this.xyLabel2);
            this.Controls.Add(this.x2TextBox);
            this.Controls.Add(this.x2label);
            this.Controls.Add(this.x2NameBox);
            this.Controls.Add(this.Triengle);
            this.Controls.Add(this.savePointBtn);
            this.Controls.Add(this.y1TextBox);
            this.Controls.Add(this.xyLabel1);
            this.Controls.Add(this.x1TextBox);
            this.Controls.Add(this.x1Label);
            this.Controls.Add(this.x1NameBox);
            this.Controls.Add(this.ExitBtn);
            this.Name = "Form1";
            this.Text = "Triangle";
            ((System.ComponentModel.ISupportInitialize)(this.Triengle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox x1NameBox;
        private System.Windows.Forms.Label x1Label;
        private System.Windows.Forms.Label xyLabel1;
        private System.Windows.Forms.TextBox x1TextBox;
        private System.Windows.Forms.TextBox y1TextBox;
        private System.Windows.Forms.Button savePointBtn;
        private System.Windows.Forms.PictureBox Triengle;
        private System.Windows.Forms.TextBox y2TextBox;
        private System.Windows.Forms.Label xyLabel2;
        private System.Windows.Forms.TextBox x2TextBox;
        private System.Windows.Forms.Label x2label;
        private System.Windows.Forms.TextBox x2NameBox;
        private System.Windows.Forms.TextBox y3TextBox;
        private System.Windows.Forms.Label xyLabel3;
        private System.Windows.Forms.TextBox x3TextBox;
        private System.Windows.Forms.Label x3label;
        private System.Windows.Forms.TextBox x3NameBox;
        private System.Windows.Forms.RichTextBox richTextTriengleInfo;
        private System.Windows.Forms.Button RndFillBtn;
        private System.Windows.Forms.Label AmoutLabel;
        private System.Windows.Forms.TextBox AmoutTextBox;
        private System.Windows.Forms.Button InitAmoutBtn;
        private System.Windows.Forms.Label TriangleNumLabel;
        private System.Windows.Forms.TextBox TriangleNumBox;
        private System.Windows.Forms.Button TabCosBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


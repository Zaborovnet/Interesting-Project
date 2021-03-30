namespace ilaba1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtlabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Расч = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Диаметр кружности";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_1);
            // 
            // txtlabel
            // 
            this.txtlabel.Location = new System.Drawing.Point(321, 158);
            this.txtlabel.Multiline = true;
            this.txtlabel.Name = "txtlabel";
            this.txtlabel.Size = new System.Drawing.Size(147, 20);
            this.txtlabel.TabIndex = 1;
            this.txtlabel.Tag = "txtlabel";
            this.txtlabel.TextChanged += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите радиус";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Расч
            // 
            this.Расч.AutoSize = true;
            this.Расч.Location = new System.Drawing.Point(355, 78);
            this.Расч.Name = "Расч";
            this.Расч.Size = new System.Drawing.Size(0, 13);
            this.Расч.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 76);
            this.button2.TabIndex = 4;
            this.button2.Text = "Площадь окружности";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 527);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Расч);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Диаметр и площадь окружности";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Расч;
        private System.Windows.Forms.Button button2;
    }
}


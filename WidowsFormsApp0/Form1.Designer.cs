namespace WidowsFormsApp0
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
            this.labelDistance = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTime = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSpeed = new System.Windows.Forms.RichTextBox();
            this.textBoxAnswerTime = new System.Windows.Forms.TextBox();
            this.textBoxAnswerSpeed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDistance.Location = new System.Drawing.Point(56, 97);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(46, 26);
            this.labelDistance.TabIndex = 1;
            this.labelDistance.Text = "s  =";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeed.Location = new System.Drawing.Point(56, 143);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(49, 26);
            this.labelSpeed.TabIndex = 2;
            this.labelSpeed.Text = "v  =";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(59, 187);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(43, 26);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "t  =";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.Black;
            this.buttonCalculate.Location = new System.Drawing.Point(286, 247);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(131, 40);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.BackColor = System.Drawing.Color.White;
            this.textBoxDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDistance.Location = new System.Drawing.Point(117, 101);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(100, 22);
            this.textBoxDistance.TabIndex = 6;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSpeed.Location = new System.Drawing.Point(117, 143);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 22);
            this.textBoxSpeed.TabIndex = 7;
            // 
            // textBoxTime
            // 
            this.textBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTime.Location = new System.Drawing.Point(117, 189);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 22);
            this.textBoxTime.TabIndex = 8;
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.richTextBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxResult.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxResult.Location = new System.Drawing.Point(56, 31);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.ReadOnly = true;
            this.richTextBoxResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxResult.Size = new System.Drawing.Size(528, 40);
            this.richTextBoxResult.TabIndex = 13;
            this.richTextBoxResult.Text = "";
            // 
            // richTextBoxTime
            // 
            this.richTextBoxTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.richTextBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxTime.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxTime.Location = new System.Drawing.Point(64, 333);
            this.richTextBoxTime.Name = "richTextBoxTime";
            this.richTextBoxTime.ReadOnly = true;
            this.richTextBoxTime.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxTime.Size = new System.Drawing.Size(79, 33);
            this.richTextBoxTime.TabIndex = 14;
            this.richTextBoxTime.Text = "";
            // 
            // richTextBoxSpeed
            // 
            this.richTextBoxSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.richTextBoxSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxSpeed.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxSpeed.Location = new System.Drawing.Point(245, 334);
            this.richTextBoxSpeed.Name = "richTextBoxSpeed";
            this.richTextBoxSpeed.ReadOnly = true;
            this.richTextBoxSpeed.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxSpeed.Size = new System.Drawing.Size(100, 29);
            this.richTextBoxSpeed.TabIndex = 15;
            this.richTextBoxSpeed.Text = "";
            // 
            // textBoxAnswerTime
            // 
            this.textBoxAnswerTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAnswerTime.Location = new System.Drawing.Point(136, 335);
            this.textBoxAnswerTime.Name = "textBoxAnswerTime";
            this.textBoxAnswerTime.Size = new System.Drawing.Size(64, 22);
            this.textBoxAnswerTime.TabIndex = 16;
            // 
            // textBoxAnswerSpeed
            // 
            this.textBoxAnswerSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAnswerSpeed.Location = new System.Drawing.Point(310, 333);
            this.textBoxAnswerSpeed.Name = "textBoxAnswerSpeed";
            this.textBoxAnswerSpeed.Size = new System.Drawing.Size(64, 22);
            this.textBoxAnswerSpeed.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAnswerSpeed);
            this.Controls.Add(this.textBoxAnswerTime);
            this.Controls.Add(this.richTextBoxSpeed);
            this.Controls.Add(this.richTextBoxTime);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelDistance);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.RichTextBox richTextBoxTime;
        private System.Windows.Forms.RichTextBox richTextBoxSpeed;
        private System.Windows.Forms.TextBox textBoxAnswerTime;
        private System.Windows.Forms.TextBox textBoxAnswerSpeed;
    }
}


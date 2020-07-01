namespace Calc
{
    partial class Calc
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
            this.InputLine = new System.Windows.Forms.Label();
            this.Plus_but = new System.Windows.Forms.Button();
            this.Minus_but = new System.Windows.Forms.Button();
            this.Multiply_but = new System.Windows.Forms.Button();
            this.Divide_but = new System.Windows.Forms.Button();
            this.Equally_but = new System.Windows.Forms.Button();
            this.Clear_line = new System.Windows.Forms.Button();
            this.Delete_symbol = new System.Windows.Forms.Button();
            this.LeftBracket = new System.Windows.Forms.Button();
            this.RightBracket = new System.Windows.Forms.Button();
            this.History_text = new System.Windows.Forms.Label();
            this.CalcHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputLine
            // 
            this.InputLine.AutoSize = true;
            this.InputLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputLine.Location = new System.Drawing.Point(65, 26);
            this.InputLine.Name = "InputLine";
            this.InputLine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InputLine.Size = new System.Drawing.Size(0, 20);
            this.InputLine.TabIndex = 0;
            this.InputLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Plus_but
            // 
            this.Plus_but.Location = new System.Drawing.Point(258, 48);
            this.Plus_but.Name = "Plus_but";
            this.Plus_but.Size = new System.Drawing.Size(54, 42);
            this.Plus_but.TabIndex = 1;
            this.Plus_but.Text = "+";
            this.Plus_but.UseVisualStyleBackColor = true;
            this.Plus_but.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // Minus_but
            // 
            this.Minus_but.Location = new System.Drawing.Point(258, 97);
            this.Minus_but.Name = "Minus_but";
            this.Minus_but.Size = new System.Drawing.Size(54, 42);
            this.Minus_but.TabIndex = 2;
            this.Minus_but.Text = "-";
            this.Minus_but.UseVisualStyleBackColor = true;
            this.Minus_but.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // Multiply_but
            // 
            this.Multiply_but.Location = new System.Drawing.Point(258, 144);
            this.Multiply_but.Name = "Multiply_but";
            this.Multiply_but.Size = new System.Drawing.Size(54, 42);
            this.Multiply_but.TabIndex = 3;
            this.Multiply_but.Text = "*";
            this.Multiply_but.UseVisualStyleBackColor = true;
            this.Multiply_but.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // Divide_but
            // 
            this.Divide_but.Location = new System.Drawing.Point(258, 192);
            this.Divide_but.Name = "Divide_but";
            this.Divide_but.Size = new System.Drawing.Size(54, 42);
            this.Divide_but.TabIndex = 4;
            this.Divide_but.Text = "/";
            this.Divide_but.UseVisualStyleBackColor = true;
            this.Divide_but.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // Equally_but
            // 
            this.Equally_but.Location = new System.Drawing.Point(318, 144);
            this.Equally_but.Name = "Equally_but";
            this.Equally_but.Size = new System.Drawing.Size(114, 90);
            this.Equally_but.TabIndex = 5;
            this.Equally_but.Text = "=";
            this.Equally_but.UseVisualStyleBackColor = true;
            this.Equally_but.Click += new System.EventHandler(this.Equally_but_Click);
            // 
            // Clear_line
            // 
            this.Clear_line.Location = new System.Drawing.Point(318, 48);
            this.Clear_line.Name = "Clear_line";
            this.Clear_line.Size = new System.Drawing.Size(54, 42);
            this.Clear_line.TabIndex = 6;
            this.Clear_line.Text = "C";
            this.Clear_line.UseVisualStyleBackColor = true;
            this.Clear_line.Click += new System.EventHandler(this.Clear_line_Click);
            // 
            // Delete_symbol
            // 
            this.Delete_symbol.Location = new System.Drawing.Point(378, 48);
            this.Delete_symbol.Name = "Delete_symbol";
            this.Delete_symbol.Size = new System.Drawing.Size(54, 42);
            this.Delete_symbol.TabIndex = 7;
            this.Delete_symbol.Text = "<-";
            this.Delete_symbol.UseVisualStyleBackColor = true;
            this.Delete_symbol.Click += new System.EventHandler(this.Delete_symbol_Click);
            // 
            // LeftBracket
            // 
            this.LeftBracket.Location = new System.Drawing.Point(318, 97);
            this.LeftBracket.Name = "LeftBracket";
            this.LeftBracket.Size = new System.Drawing.Size(54, 42);
            this.LeftBracket.TabIndex = 8;
            this.LeftBracket.Text = "(";
            this.LeftBracket.UseVisualStyleBackColor = true;
            this.LeftBracket.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // RightBracket
            // 
            this.RightBracket.Location = new System.Drawing.Point(378, 96);
            this.RightBracket.Name = "RightBracket";
            this.RightBracket.Size = new System.Drawing.Size(54, 42);
            this.RightBracket.TabIndex = 9;
            this.RightBracket.Text = ")";
            this.RightBracket.UseVisualStyleBackColor = true;
            this.RightBracket.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // History_text
            // 
            this.History_text.AutoSize = true;
            this.History_text.Location = new System.Drawing.Point(509, 29);
            this.History_text.Name = "History_text";
            this.History_text.Size = new System.Drawing.Size(52, 17);
            this.History_text.TabIndex = 10;
            this.History_text.Text = "History";
            // 
            // CalcHistory
            // 
            this.CalcHistory.AutoSize = true;
            this.CalcHistory.Location = new System.Drawing.Point(509, 48);
            this.CalcHistory.Name = "CalcHistory";
            this.CalcHistory.Size = new System.Drawing.Size(0, 17);
            this.CalcHistory.TabIndex = 11;
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 384);
            this.Controls.Add(this.CalcHistory);
            this.Controls.Add(this.History_text);
            this.Controls.Add(this.RightBracket);
            this.Controls.Add(this.LeftBracket);
            this.Controls.Add(this.Delete_symbol);
            this.Controls.Add(this.Clear_line);
            this.Controls.Add(this.Equally_but);
            this.Controls.Add(this.Divide_but);
            this.Controls.Add(this.Multiply_but);
            this.Controls.Add(this.Minus_but);
            this.Controls.Add(this.Plus_but);
            this.Controls.Add(this.InputLine);
            this.Name = "Calc";
            this.Text = "Calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLine;
        private System.Windows.Forms.Button Plus_but;
        private System.Windows.Forms.Button Minus_but;
        private System.Windows.Forms.Button Multiply_but;
        private System.Windows.Forms.Button Divide_but;
        private System.Windows.Forms.Button Equally_but;
        private System.Windows.Forms.Button Clear_line;
        private System.Windows.Forms.Button Delete_symbol;
        private System.Windows.Forms.Button LeftBracket;
        private System.Windows.Forms.Button RightBracket;
        private System.Windows.Forms.Label History_text;
        private System.Windows.Forms.Label CalcHistory;
    }
}


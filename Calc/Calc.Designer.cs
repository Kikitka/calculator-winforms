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
            this.PlusBut = new System.Windows.Forms.Button();
            this.MinusBut = new System.Windows.Forms.Button();
            this.MultiplyBut = new System.Windows.Forms.Button();
            this.DivideBut = new System.Windows.Forms.Button();
            this.EquallyBut = new System.Windows.Forms.Button();
            this.ClearLine = new System.Windows.Forms.Button();
            this.DeleteSymbol = new System.Windows.Forms.Button();
            this.LeftBracket = new System.Windows.Forms.Button();
            this.RightBracket = new System.Windows.Forms.Button();
            this.HistoryText = new System.Windows.Forms.Label();
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
            // PlusBut
            // 
            this.PlusBut.Location = new System.Drawing.Point(258, 48);
            this.PlusBut.Name = "PlusBut";
            this.PlusBut.Size = new System.Drawing.Size(54, 42);
            this.PlusBut.TabIndex = 1;
            this.PlusBut.Text = "+";
            this.PlusBut.UseVisualStyleBackColor = true;
            this.PlusBut.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // MinusBut
            // 
            this.MinusBut.Location = new System.Drawing.Point(258, 97);
            this.MinusBut.Name = "MinusBut";
            this.MinusBut.Size = new System.Drawing.Size(54, 42);
            this.MinusBut.TabIndex = 2;
            this.MinusBut.Text = "-";
            this.MinusBut.UseVisualStyleBackColor = true;
            this.MinusBut.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // MultiplyBut
            // 
            this.MultiplyBut.Location = new System.Drawing.Point(258, 144);
            this.MultiplyBut.Name = "MultiplyBut";
            this.MultiplyBut.Size = new System.Drawing.Size(54, 42);
            this.MultiplyBut.TabIndex = 3;
            this.MultiplyBut.Text = "*";
            this.MultiplyBut.UseVisualStyleBackColor = true;
            this.MultiplyBut.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // DivideBut
            // 
            this.DivideBut.Location = new System.Drawing.Point(258, 192);
            this.DivideBut.Name = "DivideBut";
            this.DivideBut.Size = new System.Drawing.Size(54, 42);
            this.DivideBut.TabIndex = 4;
            this.DivideBut.Text = "/";
            this.DivideBut.UseVisualStyleBackColor = true;
            this.DivideBut.Click += new System.EventHandler(this.ButtonOnClick);
            // 
            // EquallyBut
            // 
            this.EquallyBut.Location = new System.Drawing.Point(318, 144);
            this.EquallyBut.Name = "EquallyBut";
            this.EquallyBut.Size = new System.Drawing.Size(114, 90);
            this.EquallyBut.TabIndex = 5;
            this.EquallyBut.Text = "=";
            this.EquallyBut.UseVisualStyleBackColor = true;
            this.EquallyBut.Click += new System.EventHandler(this.EquallyButClick);
            // 
            // ClearLine
            // 
            this.ClearLine.Location = new System.Drawing.Point(318, 48);
            this.ClearLine.Name = "ClearLine";
            this.ClearLine.Size = new System.Drawing.Size(54, 42);
            this.ClearLine.TabIndex = 6;
            this.ClearLine.Text = "C";
            this.ClearLine.UseVisualStyleBackColor = true;
            this.ClearLine.Click += new System.EventHandler(this.ClearLineClick);
            // 
            // DeleteSymbol
            // 
            this.DeleteSymbol.Location = new System.Drawing.Point(378, 48);
            this.DeleteSymbol.Name = "DeleteSymbol";
            this.DeleteSymbol.Size = new System.Drawing.Size(54, 42);
            this.DeleteSymbol.TabIndex = 7;
            this.DeleteSymbol.Text = "<-";
            this.DeleteSymbol.UseVisualStyleBackColor = true;
            this.DeleteSymbol.Click += new System.EventHandler(this.DeleteSymbolClick);
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
            // HistoryText
            // 
            this.HistoryText.AutoSize = true;
            this.HistoryText.Location = new System.Drawing.Point(509, 29);
            this.HistoryText.Name = "HistoryText";
            this.HistoryText.Size = new System.Drawing.Size(52, 17);
            this.HistoryText.TabIndex = 10;
            this.HistoryText.Text = "History";
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
            this.Controls.Add(this.HistoryText);
            this.Controls.Add(this.RightBracket);
            this.Controls.Add(this.LeftBracket);
            this.Controls.Add(this.DeleteSymbol);
            this.Controls.Add(this.ClearLine);
            this.Controls.Add(this.EquallyBut);
            this.Controls.Add(this.DivideBut);
            this.Controls.Add(this.MultiplyBut);
            this.Controls.Add(this.MinusBut);
            this.Controls.Add(this.PlusBut);
            this.Controls.Add(this.InputLine);
            this.Name = "Calc";
            this.Text = "Calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLine;
        private System.Windows.Forms.Button PlusBut;
        private System.Windows.Forms.Button MinusBut;
        private System.Windows.Forms.Button MultiplyBut;
        private System.Windows.Forms.Button DivideBut;
        private System.Windows.Forms.Button EquallyBut;
        private System.Windows.Forms.Button ClearLine;
        private System.Windows.Forms.Button DeleteSymbol;
        private System.Windows.Forms.Button LeftBracket;
        private System.Windows.Forms.Button RightBracket;
        private System.Windows.Forms.Label HistoryText;
        private System.Windows.Forms.Label CalcHistory;
    }
}


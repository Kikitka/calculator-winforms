namespace Calc
{
    partial class CalculatorForm
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
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.ClearLine = new System.Windows.Forms.Button();
            this.DeleteSymbol = new System.Windows.Forms.Button();
            this.LeftBracket = new System.Windows.Forms.Button();
            this.RightBracket = new System.Windows.Forms.Button();
            this.HistoryText = new System.Windows.Forms.Label();
            this.CalculatorHistory = new System.Windows.Forms.Label();
            this.InputLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(258, 48);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(54, 42);
            this.PlusButton.TabIndex = 1;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.EditInputLine);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(258, 97);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(54, 42);
            this.MinusButton.TabIndex = 2;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.EditInputLine);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(258, 144);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(54, 42);
            this.MultiplyButton.TabIndex = 3;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.EditInputLine);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(258, 192);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(54, 42);
            this.DivideButton.TabIndex = 4;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.EditInputLine);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Location = new System.Drawing.Point(318, 144);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(114, 90);
            this.EqualsButton.TabIndex = 5;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EquallyButtonClick);
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
            this.LeftBracket.Click += new System.EventHandler(this.EditInputLine);
            // 
            // RightBracket
            // 
            this.RightBracket.Location = new System.Drawing.Point(378, 96);
            this.RightBracket.Name = "RightBracket";
            this.RightBracket.Size = new System.Drawing.Size(54, 42);
            this.RightBracket.TabIndex = 9;
            this.RightBracket.Text = ")";
            this.RightBracket.UseVisualStyleBackColor = true;
            this.RightBracket.Click += new System.EventHandler(this.EditInputLine);
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
            // CalculatorHistory
            // 
            this.CalculatorHistory.AutoSize = true;
            this.CalculatorHistory.Location = new System.Drawing.Point(509, 48);
            this.CalculatorHistory.Name = "CalculatorHistory";
            this.CalculatorHistory.Size = new System.Drawing.Size(0, 17);
            this.CalculatorHistory.TabIndex = 11;
            // 
            // InputLine
            // 
            this.InputLine.AutoSize = true;
            this.InputLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputLine.Location = new System.Drawing.Point(49, 26);
            this.InputLine.Name = "InputLine";
            this.InputLine.Size = new System.Drawing.Size(0, 20);
            this.InputLine.TabIndex = 12;
            this.InputLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 384);
            this.Controls.Add(this.InputLine);
            this.Controls.Add(this.CalculatorHistory);
            this.Controls.Add(this.HistoryText);
            this.Controls.Add(this.RightBracket);
            this.Controls.Add(this.LeftBracket);
            this.Controls.Add(this.DeleteSymbol);
            this.Controls.Add(this.ClearLine);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Name = "CalculatorForm";
            this.Text = "Calc";
            this.Load += new System.EventHandler(this.CalculatorFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button ClearLine;
        private System.Windows.Forms.Button DeleteSymbol;
        private System.Windows.Forms.Button LeftBracket;
        private System.Windows.Forms.Button RightBracket;
        private System.Windows.Forms.Label HistoryText;
        private System.Windows.Forms.Label CalculatorHistory;
        private System.Windows.Forms.Label InputLine;
    }
}


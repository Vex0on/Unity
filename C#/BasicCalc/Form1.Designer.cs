namespace BasicCalc
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.clearButton = new System.Windows.Forms.Button();
            this.CalcDisplay = new System.Windows.Forms.Label();
            this.squareButton = new System.Windows.Forms.Button();
            this.squarerootButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearButton.Location = new System.Drawing.Point(6, 58);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 47);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "AC";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // CalcDisplay
            // 
            this.CalcDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalcDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.CalcDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CalcDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.CalcDisplay.Location = new System.Drawing.Point(8, 5);
            this.CalcDisplay.Name = "CalcDisplay";
            this.CalcDisplay.Size = new System.Drawing.Size(289, 50);
            this.CalcDisplay.TabIndex = 1;
            this.CalcDisplay.Text = "0";
            // 
            // squareButton
            // 
            this.squareButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.squareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.squareButton.Location = new System.Drawing.Point(78, 58);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(75, 47);
            this.squareButton.TabIndex = 2;
            this.squareButton.Text = "x²";
            this.squareButton.UseVisualStyleBackColor = false;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // squarerootButton
            // 
            this.squarerootButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.squarerootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.squarerootButton.Location = new System.Drawing.Point(150, 58);
            this.squarerootButton.Name = "squarerootButton";
            this.squarerootButton.Size = new System.Drawing.Size(75, 47);
            this.squarerootButton.TabIndex = 3;
            this.squarerootButton.Text = "√x";
            this.squarerootButton.UseVisualStyleBackColor = false;
            this.squarerootButton.Click += new System.EventHandler(this.squarerootButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.divideButton.Location = new System.Drawing.Point(222, 58);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 47);
            this.divideButton.TabIndex = 4;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sevenButton.Location = new System.Drawing.Point(6, 102);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(75, 47);
            this.sevenButton.TabIndex = 5;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eightButton.Location = new System.Drawing.Point(78, 102);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(75, 47);
            this.eightButton.TabIndex = 6;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nineButton.Location = new System.Drawing.Point(150, 102);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(75, 47);
            this.nineButton.TabIndex = 7;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fourButton.Location = new System.Drawing.Point(6, 146);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(75, 47);
            this.fourButton.TabIndex = 8;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fiveButton.Location = new System.Drawing.Point(78, 146);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(75, 47);
            this.fiveButton.TabIndex = 9;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sixButton.Location = new System.Drawing.Point(150, 146);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(75, 47);
            this.sixButton.TabIndex = 10;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oneButton.Location = new System.Drawing.Point(6, 190);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(75, 47);
            this.oneButton.TabIndex = 11;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.twoButton.Location = new System.Drawing.Point(78, 190);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(75, 47);
            this.twoButton.TabIndex = 12;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.threeButton.Location = new System.Drawing.Point(150, 190);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(75, 47);
            this.threeButton.TabIndex = 13;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zeroButton.Location = new System.Drawing.Point(6, 234);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(147, 47);
            this.zeroButton.TabIndex = 14;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decimalButton.Location = new System.Drawing.Point(150, 234);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(75, 47);
            this.decimalButton.TabIndex = 15;
            this.decimalButton.Text = ",";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equalButton.Location = new System.Drawing.Point(222, 234);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(75, 47);
            this.equalButton.TabIndex = 16;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minusButton.Location = new System.Drawing.Point(222, 190);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(75, 47);
            this.minusButton.TabIndex = 17;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusButton.Location = new System.Drawing.Point(222, 146);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(75, 47);
            this.plusButton.TabIndex = 18;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multiplyButton.Location = new System.Drawing.Point(222, 102);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 47);
            this.multiplyButton.TabIndex = 19;
            this.multiplyButton.Text = "×";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 288);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.squarerootButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.CalcDisplay);
            this.Controls.Add(this.clearButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label CalcDisplay;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button squarerootButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button multiplyButton;
    }
}


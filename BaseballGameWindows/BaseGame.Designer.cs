namespace BaseballGameWindows
{
    partial class BaseGame
    {
        // Label == TextView
        // TextBox == TextEdit


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tNumber1 = new System.Windows.Forms.TextBox();
            this.tNumber2 = new System.Windows.Forms.TextBox();
            this.tNumber3 = new System.Windows.Forms.TextBox();
            this.bInput = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.numberList = new System.Windows.Forms.ListBox();
            this.numberLimit = new System.Windows.Forms.Label();
            this.numberLimitBox = new System.Windows.Forms.GroupBox();
            this.numberLimitBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tNumber1
            // 
            this.tNumber1.Location = new System.Drawing.Point(13, 13);
            this.tNumber1.Name = "tNumber1";
            this.tNumber1.Size = new System.Drawing.Size(100, 21);
            this.tNumber1.TabIndex = 0;
            // 
            // tNumber2
            // 
            this.tNumber2.Location = new System.Drawing.Point(13, 41);
            this.tNumber2.Name = "tNumber2";
            this.tNumber2.Size = new System.Drawing.Size(100, 21);
            this.tNumber2.TabIndex = 1;
            // 
            // tNumber3
            // 
            this.tNumber3.Location = new System.Drawing.Point(13, 69);
            this.tNumber3.Name = "tNumber3";
            this.tNumber3.Size = new System.Drawing.Size(100, 21);
            this.tNumber3.TabIndex = 2;
            // 
            // bInput
            // 
            this.bInput.Location = new System.Drawing.Point(13, 97);
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(100, 81);
            this.bInput.TabIndex = 3;
            this.bInput.Text = "Play";
            this.bInput.UseVisualStyleBackColor = true;
            this.bInput.Click += new System.EventHandler(this.bInput_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(138, 16);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(63, 12);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Play Ball!!";
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(140, 97);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(102, 81);
            this.bClear.TabIndex = 5;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // numberList
            // 
            this.numberList.FormattingEnabled = true;
            this.numberList.ItemHeight = 12;
            this.numberList.Location = new System.Drawing.Point(140, 39);
            this.numberList.Name = "numberList";
            this.numberList.Size = new System.Drawing.Size(102, 52);
            this.numberList.TabIndex = 6;
            // 
            // numberLimit
            // 
            this.numberLimit.AutoSize = true;
            this.numberLimit.Location = new System.Drawing.Point(41, 37);
            this.numberLimit.Name = "numberLimit";
            this.numberLimit.Size = new System.Drawing.Size(17, 12);
            this.numberLimit.TabIndex = 7;
            this.numberLimit.Text = "10";
            // 
            // numberLimitBox
            // 
            this.numberLimitBox.Controls.Add(this.numberLimit);
            this.numberLimitBox.Location = new System.Drawing.Point(264, 13);
            this.numberLimitBox.Name = "numberLimitBox";
            this.numberLimitBox.Size = new System.Drawing.Size(98, 77);
            this.numberLimitBox.TabIndex = 9;
            this.numberLimitBox.TabStop = false;
            this.numberLimitBox.Text = "횟수 제한";
            // 
            // BaseGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 190);
            this.Controls.Add(this.numberLimitBox);
            this.Controls.Add(this.numberList);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.bInput);
            this.Controls.Add(this.tNumber3);
            this.Controls.Add(this.tNumber2);
            this.Controls.Add(this.tNumber1);
            this.Name = "BaseGame";
            this.Text = "BaseGame";
            this.numberLimitBox.ResumeLayout(false);
            this.numberLimitBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNumber1;
        private System.Windows.Forms.TextBox tNumber2;
        private System.Windows.Forms.TextBox tNumber3;
        private System.Windows.Forms.Button bInput;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.ListBox numberList;
        private System.Windows.Forms.Label numberLimit;
        private System.Windows.Forms.GroupBox numberLimitBox;
    }
}
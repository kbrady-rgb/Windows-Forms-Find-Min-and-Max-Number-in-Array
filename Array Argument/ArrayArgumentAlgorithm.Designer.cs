namespace Array_Argument
{
    partial class ArrayArgumentAlgorithmForm
    {
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
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.goButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.findMaxBtn = new System.Windows.Forms.Button();
            this.findMinBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 16;
            this.outputListBox.Location = new System.Drawing.Point(57, 15);
            this.outputListBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(249, 260);
            this.outputListBox.TabIndex = 0;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(129, 283);
            this.goButton.Margin = new System.Windows.Forms.Padding(4);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(100, 28);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "&Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(188, 411);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 28);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // findMaxBtn
            // 
            this.findMaxBtn.Location = new System.Drawing.Point(80, 347);
            this.findMaxBtn.Name = "findMaxBtn";
            this.findMaxBtn.Size = new System.Drawing.Size(100, 28);
            this.findMaxBtn.TabIndex = 3;
            this.findMaxBtn.Text = "&Find Max";
            this.findMaxBtn.UseVisualStyleBackColor = true;
            this.findMaxBtn.Click += new System.EventHandler(this.FindMaxBtn_Click);
            // 
            // findMinBtn
            // 
            this.findMinBtn.Location = new System.Drawing.Point(186, 347);
            this.findMinBtn.Name = "findMinBtn";
            this.findMinBtn.Size = new System.Drawing.Size(102, 28);
            this.findMinBtn.TabIndex = 4;
            this.findMinBtn.Text = "Find &Min";
            this.findMinBtn.UseVisualStyleBackColor = true;
            this.findMinBtn.Click += new System.EventHandler(this.FindMinBtn_Click);
            // 
            // ArrayArgumentAlgorithmForm
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(367, 465);
            this.Controls.Add(this.findMinBtn);
            this.Controls.Add(this.findMaxBtn);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.outputListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ArrayArgumentAlgorithmForm";
            this.Text = "Array Argument Algorithm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button findMaxBtn;
        private System.Windows.Forms.Button findMinBtn;
    }
}


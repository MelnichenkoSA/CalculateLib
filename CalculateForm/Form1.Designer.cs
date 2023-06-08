
namespace CalculateForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.EpsBox = new System.Windows.Forms.TextBox();
            this.XBox = new System.Windows.Forms.TextBox();
            this.FunctionLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.EpsLabel = new System.Windows.Forms.Label();
            this.ResultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultBox
            // 
            this.ResultBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultBox.Location = new System.Drawing.Point(39, 61);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(357, 156);
            this.ResultBox.TabIndex = 0;
            this.ResultBox.TextChanged += new System.EventHandler(this.ResultBox_TextChanged);
            // 
            // EpsBox
            // 
            this.EpsBox.Location = new System.Drawing.Point(207, 306);
            this.EpsBox.Name = "EpsBox";
            this.EpsBox.Size = new System.Drawing.Size(49, 23);
            this.EpsBox.TabIndex = 1;
            this.EpsBox.TextChanged += new System.EventHandler(this.EpsBox_TextChanged);
            // 
            // XBox
            // 
            this.XBox.Location = new System.Drawing.Point(207, 261);
            this.XBox.Name = "XBox";
            this.XBox.Size = new System.Drawing.Size(49, 23);
            this.XBox.TabIndex = 2;
            this.XBox.TextChanged += new System.EventHandler(this.XBox_TextChanged);
            // 
            // FunctionLabel
            // 
            this.FunctionLabel.AutoSize = true;
            this.FunctionLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FunctionLabel.Location = new System.Drawing.Point(39, 13);
            this.FunctionLabel.Name = "FunctionLabel";
            this.FunctionLabel.Size = new System.Drawing.Size(111, 45);
            this.FunctionLabel.TabIndex = 3;
            this.FunctionLabel.Text = "Ln (1 + x) / x";
            this.FunctionLabel.Click += new System.EventHandler(this.FunctionLabel_Click);
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XLabel.Location = new System.Drawing.Point(39, 247);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(100, 45);
            this.XLabel.TabIndex = 4;
            this.XLabel.Text = "Введите Х";
            this.XLabel.Click += new System.EventHandler(this.XLabel_Click);
            // 
            // EpsLabel
            // 
            this.EpsLabel.AutoSize = true;
            this.EpsLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EpsLabel.Location = new System.Drawing.Point(39, 292);
            this.EpsLabel.Name = "EpsLabel";
            this.EpsLabel.Size = new System.Drawing.Size(162, 45);
            this.EpsLabel.TabIndex = 5;
            this.EpsLabel.Text = "Введите Точность";
            this.EpsLabel.Click += new System.EventHandler(this.EpsLabel_Click);
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(39, 351);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(75, 23);
            this.ResultButton.TabIndex = 6;
            this.ResultButton.Text = "Вычислить";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 516);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.EpsLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.FunctionLabel);
            this.Controls.Add(this.XBox);
            this.Controls.Add(this.EpsBox);
            this.Controls.Add(this.ResultBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.TextBox EpsBox;
        private System.Windows.Forms.TextBox XBox;
        private System.Windows.Forms.Label FunctionLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label EpsLabel;
        private System.Windows.Forms.Button ResultButton;
    }
}


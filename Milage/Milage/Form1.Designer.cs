namespace Milage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Total = new Label();
            CalcBtn = new Button();
            startMi = new NumericUpDown();
            endMi = new NumericUpDown();
            button1 = new Button();
            changeRate = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)startMi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)endMi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)changeRate).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 45);
            label1.TabIndex = 0;
            label1.Text = "Milage Claculator:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 66);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "Starting Milage:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 103);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Ending Milage:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 149);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 3;
            label4.Text = "Amount Owed:";
            // 
            // Total
            // 
            Total.Location = new Point(156, 149);
            Total.Name = "Total";
            Total.Size = new Size(263, 20);
            Total.TabIndex = 4;
            Total.Text = "Total";
            // 
            // CalcBtn
            // 
            CalcBtn.Location = new Point(36, 181);
            CalcBtn.Name = "CalcBtn";
            CalcBtn.Size = new Size(108, 29);
            CalcBtn.TabIndex = 5;
            CalcBtn.Text = "Calc";
            CalcBtn.UseVisualStyleBackColor = true;
            CalcBtn.Click += CalcBtn_Click;
            // 
            // startMi
            // 
            startMi.Location = new Point(156, 66);
            startMi.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            startMi.Name = "startMi";
            startMi.Size = new Size(118, 27);
            startMi.TabIndex = 6;
            // 
            // endMi
            // 
            endMi.Location = new Point(156, 101);
            endMi.Maximum = new decimal(new int[] { -1593835520, 466537709, 54210, 0 });
            endMi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            endMi.Name = "endMi";
            endMi.Size = new Size(118, 27);
            endMi.TabIndex = 7;
            endMi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(156, 181);
            button1.Name = "button1";
            button1.Size = new Size(118, 29);
            button1.TabIndex = 8;
            button1.Text = "Display Miles";
            button1.UseVisualStyleBackColor = true;
            // 
            // changeRate
            // 
            changeRate.Location = new Point(399, 24);
            changeRate.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            changeRate.Name = "changeRate";
            changeRate.Size = new Size(118, 27);
            changeRate.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(300, 24);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 9;
            label5.Text = "Change Rate";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(changeRate);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(endMi);
            Controls.Add(startMi);
            Controls.Add(CalcBtn);
            Controls.Add(Total);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)startMi).EndInit();
            ((System.ComponentModel.ISupportInitialize)endMi).EndInit();
            ((System.ComponentModel.ISupportInitialize)changeRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Total;
        private Button CalcBtn;
        private NumericUpDown startMi;
        private NumericUpDown endMi;
        private Button button1;
        private NumericUpDown changeRate;
        private Label label5;
    }
}
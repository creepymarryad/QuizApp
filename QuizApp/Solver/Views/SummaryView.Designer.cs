namespace Solver.Views
{
    partial class SummaryView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_Summary = new Label();
            label_QuizTitle = new Label();
            label_Score = new Label();
            label_Time = new Label();
            rtb_Review = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label_Summary
            // 
            label_Summary.AutoSize = true;
            label_Summary.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Summary.Location = new Point(449, 43);
            label_Summary.Name = "label_Summary";
            label_Summary.Size = new Size(553, 96);
            label_Summary.TabIndex = 3;
            label_Summary.Text = "Quiz Summary";
            // 
            // label_QuizTitle
            // 
            label_QuizTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_QuizTitle.Location = new Point(3, 245);
            label_QuizTitle.Name = "label_QuizTitle";
            label_QuizTitle.Size = new Size(1414, 70);
            label_QuizTitle.TabIndex = 4;
            label_QuizTitle.Text = "Title";
            label_QuizTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Score
            // 
            label_Score.AutoSize = true;
            label_Score.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Score.Location = new Point(411, 323);
            label_Score.Name = "label_Score";
            label_Score.Size = new Size(132, 48);
            label_Score.TabIndex = 5;
            label_Score.Text = "Score: ";
            // 
            // label_Time
            // 
            label_Time.AutoSize = true;
            label_Time.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Time.Location = new Point(800, 323);
            label_Time.Name = "label_Time";
            label_Time.Size = new Size(113, 48);
            label_Time.TabIndex = 6;
            label_Time.Text = "Time:";
            // 
            // rtb_Review
            // 
            rtb_Review.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtb_Review.Location = new Point(25, 415);
            rtb_Review.Name = "rtb_Review";
            rtb_Review.ReadOnly = true;
            rtb_Review.Size = new Size(1376, 396);
            rtb_Review.TabIndex = 7;
            rtb_Review.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(548, 871);
            button1.Name = "button1";
            button1.Size = new Size(299, 56);
            button1.TabIndex = 8;
            button1.Text = "Back to Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnReturn_Click;
            // 
            // SummaryView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(rtb_Review);
            Controls.Add(label_Time);
            Controls.Add(label_Score);
            Controls.Add(label_QuizTitle);
            Controls.Add(label_Summary);
            Name = "SummaryView";
            Size = new Size(1420, 951);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Summary;
        private Label label_QuizTitle;
        private Label label_Score;
        private Label label_Time;
        private RichTextBox rtb_Review;
        private Button button1;
    }
}

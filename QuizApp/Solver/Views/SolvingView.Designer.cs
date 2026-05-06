namespace Solver.Views
{
    partial class SolvingView
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
            label_QuizTitle = new Label();
            label_Timer = new Label();
            label_QuestionText = new Label();
            button_Next = new Button();
            btnPrevious = new Button();
            button2 = new Button();
            label_Progress = new Label();
            answersPanel = new TableLayoutPanel();
            SuspendLayout();
            // 
            // label_QuizTitle
            // 
            label_QuizTitle.AutoSize = true;
            label_QuizTitle.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_QuizTitle.Location = new Point(532, 54);
            label_QuizTitle.MaximumSize = new Size(500, 0);
            label_QuizTitle.Name = "label_QuizTitle";
            label_QuizTitle.Size = new Size(379, 96);
            label_QuizTitle.TabIndex = 1;
            label_QuizTitle.Text = "Quiz Title";
            label_QuizTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Timer
            // 
            label_Timer.AutoSize = true;
            label_Timer.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Timer.Location = new Point(1086, 35);
            label_Timer.Name = "label_Timer";
            label_Timer.Size = new Size(117, 45);
            label_Timer.TabIndex = 2;
            label_Timer.Text = "Timer:";
            // 
            // label_QuestionText
            // 
            label_QuestionText.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_QuestionText.Location = new Point(3, 300);
            label_QuestionText.Name = "label_QuestionText";
            label_QuestionText.Size = new Size(1414, 149);
            label_QuestionText.TabIndex = 3;
            label_QuestionText.Text = "Question";
            label_QuestionText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Next
            // 
            button_Next.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Next.Location = new Point(1210, 837);
            button_Next.Name = "button_Next";
            button_Next.Size = new Size(171, 46);
            button_Next.TabIndex = 5;
            button_Next.Text = "Next";
            button_Next.UseVisualStyleBackColor = true;
            button_Next.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrevious.Location = new Point(31, 837);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(171, 46);
            btnPrevious.TabIndex = 6;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(618, 821);
            button2.Name = "button2";
            button2.Size = new Size(204, 70);
            button2.TabIndex = 7;
            button2.Text = "STOP";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnStop_Click;
            // 
            // label_Progress
            // 
            label_Progress.AutoSize = true;
            label_Progress.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Progress.Location = new Point(1086, 170);
            label_Progress.Name = "label_Progress";
            label_Progress.Size = new Size(160, 45);
            label_Progress.TabIndex = 8;
            label_Progress.Text = "Progress:";
            // 
            // answersPanel
            // 
            answersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            answersPanel.AutoSize = true;
            answersPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            answersPanel.ColumnCount = 2;
            answersPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            answersPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            answersPanel.Location = new Point(31, 485);
            answersPanel.Name = "answersPanel";
            answersPanel.RowCount = 2;
            answersPanel.RowStyles.Add(new RowStyle());
            answersPanel.RowStyles.Add(new RowStyle());
            answersPanel.Size = new Size(1350, 0);
            answersPanel.TabIndex = 4;
            // 
            // SolvingView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label_Progress);
            Controls.Add(button2);
            Controls.Add(btnPrevious);
            Controls.Add(button_Next);
            Controls.Add(answersPanel);
            Controls.Add(label_QuestionText);
            Controls.Add(label_Timer);
            Controls.Add(label_QuizTitle);
            Name = "SolvingView";
            Size = new Size(1420, 951);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_QuizTitle;
        private Label label_Timer;
        private Label label_QuestionText;
        private Button button_Next;
        private Button btnPrevious;
        private Button button2;
        private Label label_Progress;
        private TableLayoutPanel answersPanel;
    }
}

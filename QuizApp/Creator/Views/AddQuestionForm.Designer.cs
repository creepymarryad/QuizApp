namespace Creator.Views
{
    partial class AddQuestionForm
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
            AddBtn = new Button();
            CancelBtn = new Button();
            panel2 = new Panel();
            QuestionAnswer1TextBox = new TextBox();
            IsCorrectAnswer1CheckBox = new CheckBox();
            QuestionTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            AddQuestionLabel = new Label();
            label5 = new Label();
            panel5 = new Panel();
            QuestionAnswer4TextBox = new TextBox();
            IsCorrectAnswer4CheckBox = new CheckBox();
            label4 = new Label();
            panel4 = new Panel();
            QuestionAnswer3TextBox = new TextBox();
            IsCorrectAnswer3CheckBox = new CheckBox();
            panel3 = new Panel();
            QuestionAnswer2TextBox = new TextBox();
            IsCorrectAnswer2CheckBox = new CheckBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Cursor = Cursors.Hand;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.ForeColor = SystemColors.Control;
            AddBtn.Location = new Point(75, 491);
            AddBtn.Name = "AddBtn";
            AddBtn.Padding = new Padding(0, 0, 0, 5);
            AddBtn.Size = new Size(318, 55);
            AddBtn.TabIndex = 10;
            AddBtn.Text = "Save";
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            CancelBtn.Cursor = Cursors.Hand;
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.ForeColor = SystemColors.Control;
            CancelBtn.Location = new Point(455, 491);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Padding = new Padding(0, 0, 0, 5);
            CancelBtn.Size = new Size(318, 55);
            CancelBtn.TabIndex = 11;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(QuestionAnswer1TextBox);
            panel2.Controls.Add(IsCorrectAnswer1CheckBox);
            panel2.Location = new Point(65, 274);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 30, 0);
            panel2.Size = new Size(320, 50);
            panel2.TabIndex = 14;
            // 
            // QuestionAnswer1TextBox
            // 
            QuestionAnswer1TextBox.BackColor = Color.DimGray;
            QuestionAnswer1TextBox.BorderStyle = BorderStyle.None;
            QuestionAnswer1TextBox.Dock = DockStyle.Fill;
            QuestionAnswer1TextBox.ForeColor = SystemColors.Window;
            QuestionAnswer1TextBox.Location = new Point(0, 0);
            QuestionAnswer1TextBox.Multiline = true;
            QuestionAnswer1TextBox.Name = "QuestionAnswer1TextBox";
            QuestionAnswer1TextBox.Size = new Size(286, 46);
            QuestionAnswer1TextBox.TabIndex = 2;
            // 
            // IsCorrectAnswer1CheckBox
            // 
            IsCorrectAnswer1CheckBox.AutoSize = true;
            IsCorrectAnswer1CheckBox.Cursor = Cursors.Hand;
            IsCorrectAnswer1CheckBox.Location = new Point(294, 17);
            IsCorrectAnswer1CheckBox.Name = "IsCorrectAnswer1CheckBox";
            IsCorrectAnswer1CheckBox.Size = new Size(18, 17);
            IsCorrectAnswer1CheckBox.TabIndex = 6;
            IsCorrectAnswer1CheckBox.UseVisualStyleBackColor = true;
            // 
            // QuestionTextBox
            // 
            QuestionTextBox.BackColor = Color.DimGray;
            QuestionTextBox.ForeColor = SystemColors.Window;
            QuestionTextBox.Location = new Point(65, 117);
            QuestionTextBox.Multiline = true;
            QuestionTextBox.Name = "QuestionTextBox";
            QuestionTextBox.ScrollBars = ScrollBars.Vertical;
            QuestionTextBox.Size = new Size(698, 100);
            QuestionTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(255, 255, 85);
            label1.Location = new Point(65, 242);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 10;
            label1.Text = "Answer 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(255, 255, 85);
            label2.Location = new Point(443, 242);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 11;
            label2.Text = "Answer 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(255, 255, 85);
            label3.Location = new Point(65, 338);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 12;
            label3.Text = "Answer 3";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(AddQuestionLabel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(QuestionTextBox);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(8, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(828, 449);
            panel1.TabIndex = 12;
            // 
            // AddQuestionLabel
            // 
            AddQuestionLabel.AutoSize = true;
            AddQuestionLabel.BackColor = Color.Transparent;
            AddQuestionLabel.ForeColor = Color.White;
            AddQuestionLabel.Location = new Point(103, 0);
            AddQuestionLabel.Name = "AddQuestionLabel";
            AddQuestionLabel.Size = new Size(146, 20);
            AddQuestionLabel.TabIndex = 19;
            AddQuestionLabel.Text = "Question constructor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(255, 255, 85);
            label5.Location = new Point(65, 84);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 18;
            label5.Text = "Question content";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DimGray;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(QuestionAnswer4TextBox);
            panel5.Controls.Add(IsCorrectAnswer4CheckBox);
            panel5.Location = new Point(445, 370);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 0, 30, 0);
            panel5.Size = new Size(320, 50);
            panel5.TabIndex = 17;
            // 
            // QuestionAnswer4TextBox
            // 
            QuestionAnswer4TextBox.BackColor = Color.DimGray;
            QuestionAnswer4TextBox.BorderStyle = BorderStyle.None;
            QuestionAnswer4TextBox.Dock = DockStyle.Fill;
            QuestionAnswer4TextBox.ForeColor = SystemColors.Window;
            QuestionAnswer4TextBox.Location = new Point(0, 0);
            QuestionAnswer4TextBox.Multiline = true;
            QuestionAnswer4TextBox.Name = "QuestionAnswer4TextBox";
            QuestionAnswer4TextBox.Size = new Size(286, 46);
            QuestionAnswer4TextBox.TabIndex = 2;
            // 
            // IsCorrectAnswer4CheckBox
            // 
            IsCorrectAnswer4CheckBox.AutoSize = true;
            IsCorrectAnswer4CheckBox.Cursor = Cursors.Hand;
            IsCorrectAnswer4CheckBox.Location = new Point(292, 15);
            IsCorrectAnswer4CheckBox.Name = "IsCorrectAnswer4CheckBox";
            IsCorrectAnswer4CheckBox.Size = new Size(18, 17);
            IsCorrectAnswer4CheckBox.TabIndex = 6;
            IsCorrectAnswer4CheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(255, 255, 85);
            label4.Location = new Point(443, 338);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 16;
            label4.Text = "Answer 4";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(QuestionAnswer3TextBox);
            panel4.Controls.Add(IsCorrectAnswer3CheckBox);
            panel4.Location = new Point(67, 370);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 0, 30, 0);
            panel4.Size = new Size(320, 50);
            panel4.TabIndex = 15;
            // 
            // QuestionAnswer3TextBox
            // 
            QuestionAnswer3TextBox.BackColor = Color.DimGray;
            QuestionAnswer3TextBox.BorderStyle = BorderStyle.None;
            QuestionAnswer3TextBox.Dock = DockStyle.Fill;
            QuestionAnswer3TextBox.ForeColor = SystemColors.Window;
            QuestionAnswer3TextBox.Location = new Point(0, 0);
            QuestionAnswer3TextBox.Multiline = true;
            QuestionAnswer3TextBox.Name = "QuestionAnswer3TextBox";
            QuestionAnswer3TextBox.Size = new Size(286, 46);
            QuestionAnswer3TextBox.TabIndex = 2;
            // 
            // IsCorrectAnswer3CheckBox
            // 
            IsCorrectAnswer3CheckBox.AutoSize = true;
            IsCorrectAnswer3CheckBox.Cursor = Cursors.Hand;
            IsCorrectAnswer3CheckBox.Location = new Point(292, 15);
            IsCorrectAnswer3CheckBox.Name = "IsCorrectAnswer3CheckBox";
            IsCorrectAnswer3CheckBox.Size = new Size(18, 17);
            IsCorrectAnswer3CheckBox.TabIndex = 6;
            IsCorrectAnswer3CheckBox.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(QuestionAnswer2TextBox);
            panel3.Controls.Add(IsCorrectAnswer2CheckBox);
            panel3.Location = new Point(443, 276);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 30, 0);
            panel3.Size = new Size(320, 50);
            panel3.TabIndex = 15;
            // 
            // QuestionAnswer2TextBox
            // 
            QuestionAnswer2TextBox.BackColor = Color.DimGray;
            QuestionAnswer2TextBox.BorderStyle = BorderStyle.None;
            QuestionAnswer2TextBox.Dock = DockStyle.Fill;
            QuestionAnswer2TextBox.ForeColor = SystemColors.Window;
            QuestionAnswer2TextBox.Location = new Point(0, 0);
            QuestionAnswer2TextBox.Multiline = true;
            QuestionAnswer2TextBox.Name = "QuestionAnswer2TextBox";
            QuestionAnswer2TextBox.Size = new Size(286, 46);
            QuestionAnswer2TextBox.TabIndex = 2;
            // 
            // IsCorrectAnswer2CheckBox
            // 
            IsCorrectAnswer2CheckBox.AutoSize = true;
            IsCorrectAnswer2CheckBox.Cursor = Cursors.Hand;
            IsCorrectAnswer2CheckBox.Location = new Point(294, 15);
            IsCorrectAnswer2CheckBox.Name = "IsCorrectAnswer2CheckBox";
            IsCorrectAnswer2CheckBox.Size = new Size(18, 17);
            IsCorrectAnswer2CheckBox.TabIndex = 6;
            IsCorrectAnswer2CheckBox.UseVisualStyleBackColor = true;
            // 
            // AddQuestionForm
            // 
            AcceptButton = AddBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new Size(846, 574);
            Controls.Add(CancelBtn);
            Controls.Add(AddBtn);
            Controls.Add(panel1);
            Name = "AddQuestionForm";
            Text = "Add Question";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button AddBtn;
        private Button CancelBtn;
        private Panel panel2;
        private TextBox QuestionAnswer1TextBox;
        private CheckBox IsCorrectAnswer1CheckBox;
        private TextBox QuestionTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel5;
        private TextBox QuestionAnswer4TextBox;
        private CheckBox IsCorrectAnswer4CheckBox;
        private Label label4;
        private Panel panel4;
        private TextBox QuestionAnswer3TextBox;
        private CheckBox IsCorrectAnswer3CheckBox;
        private Panel panel3;
        private TextBox QuestionAnswer2TextBox;
        private CheckBox IsCorrectAnswer2CheckBox;
        private Label label5;
        private Label AddQuestionLabel;
    }
}
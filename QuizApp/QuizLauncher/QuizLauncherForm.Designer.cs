namespace QuizLauncher
{
    partial class QuizLauncherForm
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
            RunCreatorBtn = new Button();
            RunSolverBtn = new Button();
            LauncherLabel = new Label();
            SuspendLayout();
            // 
            // RunCreatorBtn
            // 
            RunCreatorBtn.BackColor = Color.FromArgb(170, 170, 170);
            RunCreatorBtn.BackgroundImageLayout = ImageLayout.Stretch;
            RunCreatorBtn.Cursor = Cursors.Hand;
            RunCreatorBtn.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            RunCreatorBtn.FlatAppearance.BorderSize = 0;
            RunCreatorBtn.FlatStyle = FlatStyle.Flat;
            RunCreatorBtn.Font = new Font("Monocraft", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RunCreatorBtn.ForeColor = Color.White;
            RunCreatorBtn.Location = new Point(45, 187);
            RunCreatorBtn.Name = "RunCreatorBtn";
            RunCreatorBtn.Padding = new Padding(0, 0, 0, 10);
            RunCreatorBtn.Size = new Size(711, 105);
            RunCreatorBtn.TabIndex = 0;
            RunCreatorBtn.Text = "Quiz Creator";
            RunCreatorBtn.UseVisualStyleBackColor = false;
            RunCreatorBtn.Click += RunCreatorBtn_Click;
            // 
            // RunSolverBtn
            // 
            RunSolverBtn.BackColor = Color.FromArgb(170, 170, 170);
            RunSolverBtn.BackgroundImageLayout = ImageLayout.Stretch;
            RunSolverBtn.Cursor = Cursors.Hand;
            RunSolverBtn.FlatAppearance.BorderSize = 0;
            RunSolverBtn.FlatStyle = FlatStyle.Flat;
            RunSolverBtn.Font = new Font("Monocraft", 19.7999973F);
            RunSolverBtn.ForeColor = Color.White;
            RunSolverBtn.Location = new Point(45, 311);
            RunSolverBtn.Name = "RunSolverBtn";
            RunSolverBtn.Padding = new Padding(0, 0, 0, 10);
            RunSolverBtn.Size = new Size(711, 105);
            RunSolverBtn.TabIndex = 1;
            RunSolverBtn.Text = "Quiz Solver";
            RunSolverBtn.UseVisualStyleBackColor = false;
            RunSolverBtn.Click += RunSolverBtn_Click;
            // 
            // LauncherLabel
            // 
            LauncherLabel.AutoSize = true;
            LauncherLabel.BackColor = Color.Transparent;
            LauncherLabel.Font = new Font("Monocraft", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LauncherLabel.ForeColor = Color.White;
            LauncherLabel.Location = new Point(193, 95);
            LauncherLabel.Name = "LauncherLabel";
            LauncherLabel.Size = new Size(431, 66);
            LauncherLabel.TabIndex = 2;
            LauncherLabel.Text = "Quiz Launcher";
            // 
            // QuizLauncherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(LauncherLabel);
            Controls.Add(RunSolverBtn);
            Controls.Add(RunCreatorBtn);
            DoubleBuffered = true;
            Name = "QuizLauncherForm";
            Text = "Launcher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RunCreatorBtn;
        private Button RunSolverBtn;
        private Label LauncherLabel;
    }
}

namespace Solver
{
    partial class ShellForm
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
            panel_MainContainer = new Panel();
            SuspendLayout();
            // 
            // panel_MainContainer
            // 
            panel_MainContainer.Dock = DockStyle.Fill;
            panel_MainContainer.Location = new Point(0, 0);
            panel_MainContainer.Name = "panel_MainContainer";
            panel_MainContainer.Size = new Size(1414, 960);
            panel_MainContainer.TabIndex = 0;
            // 
            // ShellForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 960);
            Controls.Add(panel_MainContainer);
            Name = "ShellForm";
            Text = "QuizSolver";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_MainContainer;
    }
}

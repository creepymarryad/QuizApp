namespace Solver
{
    public partial class ShellForm : Form
    {
        public ShellForm()
        {
            InitializeComponent();
        }

        public void SetView(UserControl view)
        {
            panel_MainContainer.Controls.Clear();
            view.Dock = DockStyle.Fill;
            panel_MainContainer.Controls.Add(view);
        }
    }
}

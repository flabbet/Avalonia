using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Sandbox
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.AttachDevTools();
            this.Activated += MainWindow_Activated;
        }

        private void MainWindow_Activated(object sender, System.EventArgs e)
        {
            JetBrains.Profiler.Api.MeasureProfiler.SaveData();
            Program.sw.Stop();
            Title = Program.sw.Elapsed.ToString();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

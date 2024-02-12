using System.Windows;

namespace WpfApp1;

public partial class MainWindow : Window
{
    private bool running = false;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnToggleRun_OnClick(object sender, RoutedEventArgs e)
    {
        if (running)
        {
            // stop
            TbStatus.Text = "Stopped";
            BtnToggleRun.Content = "Run";
        }
        else
        {
            // run
            TbStatus.Text = "Running";
            BtnToggleRun.Content = "Stop";
        }

        running = !running;
    }
}
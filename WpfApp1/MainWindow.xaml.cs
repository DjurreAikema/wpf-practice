using System.Windows;

namespace WpfApp1;

public partial class MainWindow : Window
{
    private bool _running = false;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnToggleRun_OnClick(object sender, RoutedEventArgs e)
    {
        if (_running)
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

        _running = !_running;
    }
}
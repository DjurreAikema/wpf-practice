using System.Windows;
using WinForms = System.Windows.Forms;

namespace WpfApp1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnFire_OnClick(object sender, RoutedEventArgs e)
    {
        WinForms.FolderBrowserDialog dialog = new FolderBrowserDialog();
        dialog.InitialDirectory = "C:\\Programming\\Projects\\wpf-practice";
        WinForms.DialogResult result = dialog.ShowDialog();

        if (result == WinForms.DialogResult.OK)
        {
            string folder = dialog.SelectedPath;
        }
    }
}
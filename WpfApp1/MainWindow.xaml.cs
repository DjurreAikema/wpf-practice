using System.Windows;
using Microsoft.Win32;

namespace WpfApp1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnFire_OnClick(object sender, RoutedEventArgs e)
    {
        OpenFileDialog fileDialog = new OpenFileDialog();
        fileDialog.Filter = "C# Source Files | *.cs";
        fileDialog.InitialDirectory = "C:\\Programming\\Projects\\wpf-practice";
        fileDialog.Title = "Please pick CS source file(s).";
        // fileDialog.Multiselect = true;

        bool? success = fileDialog.ShowDialog();
        if (success == true)
        {
            string path = fileDialog.FileName;
            string fileName = fileDialog.SafeFileName;

            tbInfo.Text = fileName;
        }
        else
        {
            // didnt pick anything
        }
    }
}
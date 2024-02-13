using System.Windows;

namespace WpfApp1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnFire_OnClick(object sender, RoutedEventArgs e)
    {
        //MessageBox.Show("Could not open file.", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);

        MessageBoxResult result = MessageBox.Show("Do you agree?", "Agreement", MessageBoxButton.YesNo, MessageBoxImage.Error);

        if (result == MessageBoxResult.Yes)
        {
            tbInfo.Text = "Agreed";
        }
        else
        {
            tbInfo.Text = "Not Agreed";
        }
    }
}
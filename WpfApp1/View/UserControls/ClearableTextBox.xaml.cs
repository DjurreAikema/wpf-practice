using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.View.UserControls;

public partial class ClearableTextBox : UserControl
{

    private string placeholder;

    public string Placeholder
    {
        get { return placeholder; }
        set
        {
            placeholder = value;
            // Do not do this V
            tbPlaceholder.Text = placeholder;
        }
    }

    public ClearableTextBox()
    {
        InitializeComponent();
    }

    // --- Input
    private void TxtInput_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        tbPlaceholder.Visibility = string.IsNullOrEmpty(txtInput.Text) ? Visibility.Visible : Visibility.Hidden;
    }


    // --- Placeholder

    // --- Clear
    private void BtnClear_OnClick(object sender, RoutedEventArgs e)
    {
        txtInput.Clear();
        txtInput.Focus();
    }
}
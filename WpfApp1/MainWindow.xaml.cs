using System.Collections;
using System.Windows;

namespace WpfApp1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        lvEntries.Items.Add("a");
        lvEntries.Items.Add("b");
        lvEntries.Items.Add("c");
    }

    private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
    {
        lvEntries.Items.Add(txtEntry.Text);
        txtEntry.Clear();
    }

    private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
    {
        // int index = lvEntries.SelectedIndex;
        // lvEntries.Items.RemoveAt(index);

        // object item = lvEntries.SelectedItem;
        // MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete: {item}?", "Sure?", MessageBoxButton.YesNo);
        // if (result == MessageBoxResult.Yes)
        //     lvEntries.Items.Remove(item);

        var items = lvEntries.SelectedItems;
        MessageBoxResult result = MessageBox.Show($"Are you sure you want to delete: {items.Count} items?", "Sure?", MessageBoxButton.YesNo);
        if (result == MessageBoxResult.Yes)
        {
            var itemsList = new ArrayList(items);
            foreach (var item in itemsList)
                lvEntries.Items.Remove(item);
        }
    }

    private void BtnClear_OnClick(object sender, RoutedEventArgs e)
    {
        lvEntries.Items.Clear();
    }
}
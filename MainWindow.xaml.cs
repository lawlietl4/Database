using Database.DataSet1TableAdapters;
using System.Windows;

namespace Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private GameTableAdapter gameTableAdapter = new();
        private DataSet1 dataSet = new();
        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gameTableAdapter.Fill(dataSet.Game);
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            gameTableAdapter.Update(dataSet);
        }
    }
}

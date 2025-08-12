using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Fondo_Revolvente.Controls.MainSideBar
{
    public partial class SidebarControl : UserControl
    {
        public event EventHandler<string>? MenuItemSelected;

        public SidebarControl()
        {
            InitializeComponent();
            UpdateButtonSelection(DashboardButton);
        }

        private void DashboardButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateButtonSelection(DashboardButton);
            MenuItemSelected?.Invoke(this, "Dashboard");
        }

        private void MinistracionesButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateButtonSelection(MinistracionesButton);
            MenuItemSelected?.Invoke(this, "Ministraciones");
        }

        private void UpdateButtonSelection(Button selectedButton)
        {
            DashboardButton.Background = Brushes.Transparent;
            MinistracionesButton.Background = Brushes.Transparent;
            
            selectedButton.Background = new SolidColorBrush(Color.FromRgb(26, 188, 156));
        }
    }
}
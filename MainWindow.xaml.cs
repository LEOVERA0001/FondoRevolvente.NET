using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fondo_Revolvente;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        try
        {
            InitializeComponent();
            // Mostrar Dashboard por defecto
            ShowDashboard();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al inicializar: {ex.Message}\n\nDetalles: {ex.ToString()}",
                           "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    // Evento que maneja la selección del sidebar
    private void Sidebar_MenuItemSelected(object sender, string menuItem)
    {
        switch (menuItem.ToLower())
        {
            case "dashboard":
                ShowDashboard();
                break;
            case "ministraciones":
                ShowMinistraciones();
                break;
        }
    }

    private void ShowDashboard()
    {
        // Actualizar el título del header
        HeaderTitle.Text = "Dashboard";

        // Crear contenido para Dashboard
        var dashboardContent = new StackPanel();

        var welcomeText = new TextBlock
        {
            Text = "Bienvenido al Dashboard",
            FontSize = 20,
            FontWeight = FontWeights.SemiBold,
            Foreground = new SolidColorBrush(Color.FromRgb(52, 73, 94)), // #34495E
            Margin = new Thickness(0, 0, 0, 20)
        };

        var locationText = new TextBlock
        {
            Text = "Estás en la vista: Dashboard",
            FontSize = 16,
            Foreground = new SolidColorBrush(Color.FromRgb(127, 140, 141)), // #7F8C8D
            Margin = new Thickness(0, 0, 0, 10)
        };

        var descriptionText = new TextBlock
        {
            Text = "Aquí podrás ver un resumen general del sistema, estadísticas y accesos rápidos.",
            FontSize = 14,
            Foreground = new SolidColorBrush(Color.FromRgb(127, 140, 141)),
            TextWrapping = TextWrapping.Wrap
        };

        dashboardContent.Children.Add(welcomeText);
        dashboardContent.Children.Add(locationText);
        dashboardContent.Children.Add(descriptionText);

        // Asignar el contenido al ContentControl
        MainContent.Content = dashboardContent;
    }

    private void ShowMinistraciones()
    {
        // Actualizar el título del header
        HeaderTitle.Text = "Ministraciones";

        // Crear contenido para Ministraciones
        var ministracionesContent = new StackPanel();

        var welcomeText = new TextBlock
        {
            Text = "Gestión de Ministraciones",
            FontSize = 20,
            FontWeight = FontWeights.SemiBold,
            Foreground = new SolidColorBrush(Color.FromRgb(52, 73, 94)), // #34495E
            Margin = new Thickness(0, 0, 0, 20)
        };

        var locationText = new TextBlock
        {
            Text = "Estás en la vista: Ministraciones",
            FontSize = 16,
            Foreground = new SolidColorBrush(Color.FromRgb(127, 140, 141)), // #7F8C8D
            Margin = new Thickness(0, 0, 0, 10)
        };

        var descriptionText = new TextBlock
        {
            Text = "En esta sección podrás administrar las ministraciones del fondo revolvente: crear, editar, consultar y gestionar los desembolsos.",
            FontSize = 14,
            Foreground = new SolidColorBrush(Color.FromRgb(127, 140, 141)),
            TextWrapping = TextWrapping.Wrap
        };

        ministracionesContent.Children.Add(welcomeText);
        ministracionesContent.Children.Add(locationText);
        ministracionesContent.Children.Add(descriptionText);

        // Asignar el contenido al ContentControl
        MainContent.Content = ministracionesContent;
    }

}
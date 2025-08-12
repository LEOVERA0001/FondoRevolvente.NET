using System.Configuration;
using System.Data;
using System.Windows;

namespace Fondo_Revolvente;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        // Capturar excepciones no manejadas
        this.DispatcherUnhandledException += App_DispatcherUnhandledException;
        
        base.OnStartup(e);
    }
    
    private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
    {
        MessageBox.Show($"Error no manejado: {e.Exception.Message}\n\nDetalles: {e.Exception.ToString()}", 
                       "Error Fatal", MessageBoxButton.OK, MessageBoxImage.Error);
        e.Handled = true;
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RIAB_Restaurent_Management_System
{
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            String innerMessage = "Error: \r\n";
            innerMessage+="Inner Exception: \r\n";
            innerMessage += e.Exception.InnerException.InnerException;
            innerMessage += "\r\n";
            innerMessage += "Stack Trace: \r\n";
            innerMessage += e.Exception.StackTrace;
            innerMessage += "\r\n";

            MessageBox.Show(innerMessage, "Exception", MessageBoxButton.OK, MessageBoxImage.Information);
            e.Handled = true;
        }
    }
}

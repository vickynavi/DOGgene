using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_LoginForm
{
    /// <summary>
    /// Lógica de interacción para Resultados.xaml
    /// </summary>
    public partial class Resultados : Window
    {

        public Resultados(string nombreperro, string nombrehumano)
        {
            InitializeComponent();
            resultadosnombre.Text= resultadosnombre.Text + nombreperro;
            resultadoshumano.Text = $"Hello {nombrehumano}, " + resultadoshumano.Text;
        }


        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }

}

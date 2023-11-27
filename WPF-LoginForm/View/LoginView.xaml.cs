using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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


namespace WPF_LoginForm.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        public Dictionary<string, string> ExecuteCommand()
        {
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + $"blastn -db FENOTIPO -query {Variables.filePath} -outfmt \"10 stitle pident\" -task dc-megablast -template_length 16 -template_type optimal -max_hsps 1 -perc_identity 100");
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            proc.WaitForExit();
            string result = proc.StandardOutput.ReadToEnd();
            string[] valores = result.Split(new[] { '\n', }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, string> Blast =
                      valores.ToDictionary(s => s.Split(',')[0], s => s.Split(',')[1]);
            Variables.Blast1 = Blast;
            return Variables.Blast1;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            ExecuteCommand();
            string nombreperro = dogsnametb.Text.ToString();
            string nombrehumano = ownersnametb.Text.ToString();
            Resultados resultados = new Resultados(nombreperro, nombrehumano);
            this.Close();
            resultados.Show();
        }

        private void seq_Click(object sender, RoutedEventArgs e)
        {         
            OpenFileDialog openFileDialog = new OpenFileDialog();            
            if (openFileDialog.ShowDialog() == true)
            {
                Variables.filePath = openFileDialog.FileName;
            }
        }
        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

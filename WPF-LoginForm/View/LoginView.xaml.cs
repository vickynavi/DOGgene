using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
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
        ArrayList lista = new ArrayList();
    
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
        public void ExecuteCommand()
        {
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + "blastn -db FENOTIPO -query sujeto.fasta -outfmt \"10 stitle pident\" -task dc-megablast -template_length 16 -template_type optimal");
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            proc.WaitForExit();
            string result = proc.StandardOutput.ReadToEnd();
            string[] valores = result.Split(new[] { '\n', }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, string> dictionary =
                      valores.ToDictionary(s => s.Split(',')[0], s => s.Split(',')[1]);
            label1.Content= dictionary["Cistinuria1"];
            textBox1.Text = result;
        }
        public void Main()
        {
            ExecuteCommand();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Main();

        }

        private void seq_Click(object sender, RoutedEventArgs e)
        {
            string filePath;
            string line;
            
            OpenFileDialog openFileDialog = new OpenFileDialog();            
            if (openFileDialog.ShowDialog() == true)
            {
                filePath = openFileDialog.FileName;

                StreamReader sr = new StreamReader(filePath);
                line = sr.ReadLine();
                while (line != null)
                {
                    lista.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                //label1.Content = "" + lista[20000];
            }
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

using System;
using System.Collections;
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
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        public Resultados(string nombreperro, string nombrehumano)
        {
            InitializeComponent();
            resultadosnombre.Text= resultadosnombre.Text + nombreperro;
            resultadoshumano.Text = $"Hello {nombrehumano}, " + resultadoshumano.Text;

            if (Variables.Blast1.ContainsKey("ShortCoat1"))
                Variables.contsc += 20;
            if (Variables.Blast1.ContainsKey("ShortCoat2"))
                Variables.contsc += 20;
            if (Variables.Blast1.ContainsKey("ShortCoat3"))
                Variables.contsc += 20;
            if (Variables.Blast1.ContainsKey("ProgressiveRetinalAtrophy"))
                Variables.contpra += 100;
            if (Variables.Blast1.ContainsKey("HeatTolerance"))
                Variables.contht += 50;
            if (Variables.Blast1.ContainsKey("Narcolepsy"))
                Variables.contnar += 25;
            if (Variables.Blast1.ContainsKey("Cystinuria1"))
                Variables.contc += 33;
            if (Variables.Blast1.ContainsKey("Cystinuria2"))
                Variables.contc += 33;
            if (Variables.Blast1.ContainsKey("Cystinuria3"))
                Variables.contc += 33;
            if (Variables.Blast1.ContainsKey("HipDysplasia1"))
                Variables.conthd += 25;
            if (Variables.Blast1.ContainsKey("HipDysplasia2"))
                Variables.conthd += 25;
            if (Variables.Blast1.ContainsKey("CongenitalDeafness"))
                Variables.contcd += 100;
            if (Variables.Blast1.ContainsKey("ElongatedMuzzle"))
                Variables.contem += 60;
            if (Variables.Blast1.ContainsKey("LargeBones1"))
                Variables.contlb += 33;
            if (Variables.Blast1.ContainsKey("LargeBones2"))
                Variables.contlb += 33;
            if (Variables.Blast1.ContainsKey("LargeBones3"))
                Variables.contlb += 33;
            if (Variables.Blast1.ContainsKey("Agressive"))
                Variables.contag += 40;

            List<string> probabilidades = new List<string>() { Variables.contsc.ToString(), Variables.contpra.ToString(), Variables.contag.ToString(), Variables.contht.ToString(), Variables.contnar.ToString(), Variables.contc.ToString(), Variables.conthd.ToString(), Variables.contcd.ToString(), Variables.contem.ToString(), Variables.contlb.ToString() };
            for (int i = 0; i < probabilidades.Count; i++)
            {
                if (probabilidades[i] == "0")
                    probabilidades[i] = "Can't be determinated";

                else probabilidades[i] = probabilidades[i] + "%";
            }

            Cystinuriatb.Text = probabilidades[5]; if (probabilidades[5]=="Can't be determinated") { Cystinuriatb.Foreground = Brushes.Fuchsia; }
            ShortCoattb.Text= probabilidades[0]; if (probabilidades[0] == "Can't be determinated") { ShortCoattb.Foreground = Brushes.Fuchsia; }
            ProgressiveRetinalAtrophytb.Text= probabilidades[1]; if (probabilidades[1] == "Can't be determinated") { ProgressiveRetinalAtrophytb.Foreground = Brushes.Fuchsia; }
            HeatTolerancetb.Text= probabilidades[3]; if (probabilidades[3] == "Can't be determinated") { HeatTolerancetb.Foreground = Brushes.Fuchsia; }
            Narcolepsytb.Text= probabilidades[4]; if (probabilidades[4] == "Can't be determinated") { Narcolepsytb.Foreground = Brushes.Fuchsia; }
            HipDysplasiatb.Text= probabilidades[6]; if (probabilidades[6] == "Can't be determinated") { HipDysplasiatb.Foreground = Brushes.Fuchsia; }
            CongenitalDeafnesstb.Text= probabilidades[7]; if (probabilidades[7] == "Can't be determinated") { CongenitalDeafnesstb.Foreground = Brushes.Fuchsia; }
            ElongatedMuzzletb.Text= probabilidades[8]; if (probabilidades[8] == "Can't be determinated") { ElongatedMuzzletb.Foreground = Brushes.Fuchsia; }
            LargeBonestb.Text= probabilidades[9]; if (probabilidades[9] == "Can't be determinated") { LargeBonestb.Foreground = Brushes.Fuchsia; }
            Agressivetb.Text = probabilidades[2]; if (probabilidades[2] == "Can't be determinated") { Agressivetb.Foreground = Brushes.Fuchsia; }

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

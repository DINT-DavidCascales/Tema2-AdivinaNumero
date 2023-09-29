using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_AdivinaNúmero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();
        private int numeroAdivinar;

        public MainWindow()
        {
            numeroAdivinar = r.Next(0, 101);
            InitializeComponent();

        }

        private void reiniciar_Click(object sender, RoutedEventArgs e)
        {
            numeroAdivinar=r.Next(0, 101);
            respuesta.Text = "";
        }

        private void comprobar_Click(object sender, RoutedEventArgs e)
        {

            int num = Int32.Parse(numero.Text);

           if (num == numeroAdivinar) { respuesta.Text = "Has acertado"; }
           if (num > numeroAdivinar) { respuesta.Text = "Te has pasado"; }
           if(num < numeroAdivinar) { respuesta.Text = "Te has quedado corto"; }


        }

        private void numero_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

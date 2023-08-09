using System;
using System.Windows;

namespace Proyectos_de_Sistemas_Practica1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            int suma = 0;
            string conteo = "";

            for (int i = 1; i < Int32.Parse(longitud.Text) ; i++)
            {
                if (i % Int32.Parse(boxUno.Text) == 0 || i % Int32.Parse(boxDos.Text) == 0)
                {
                    conteo += i.ToString() + " ";
                    suma += i;
                }
            }

            this.suma.Text = suma.ToString();
            this.conteo.Text = conteo;
        }

       

        private void ButtonBase1_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
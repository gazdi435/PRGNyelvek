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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public List<Nyelv> nyelvLista = new List<Nyelv>();
        public nyelvCsalad ujNyelvCsalad;
        public MainWindow()
        {
            InitializeComponent();

            
        }


        private void rogzit(object sender, RoutedEventArgs e)
        {

            switch (cmbNyelvCsalad.Text)
            {
                default:
                    ujNyelvCsalad = nyelvCsalad.funkcionális;
                    break;
                case "funkcionális":
                    ujNyelvCsalad = nyelvCsalad.funkcionális;
                    break;
                case "strukturális":
                    ujNyelvCsalad = nyelvCsalad.strukturális;
                    break;
                case "moduláris":
                    ujNyelvCsalad = nyelvCsalad.moduláris;
                    break;
                case "objektumOrientált":
                    ujNyelvCsalad = nyelvCsalad.objektumOrientált;
                    break;
            }

            Nyelv ujNyelv = new Nyelv(txtbNev.Text, ujNyelvCsalad, rdbFordito.IsChecked == true, Convert.ToInt32(txtbMegjelenes.Text), rdbMagasSzintu.IsChecked==true, Convert.ToInt32(slNepszeruseg.Value));
            nyelvLista.Add(ujNyelv);
            dtgMegjelenit.ItemsSource = nyelvLista;
        }
    }
}
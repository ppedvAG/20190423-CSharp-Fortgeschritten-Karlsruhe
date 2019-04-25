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

namespace WPFMitSpeichern
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Film Film;
        public MainWindow()
        {
            InitializeComponent();
            Film = new Film();
            DataContext = Film;
        }

        private void Speichern_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Film.Titel.ToString());
            MessageBox.Show(Film.Länge.ToString());
            MessageBox.Show(Film.Regisseur.ToString());
            MessageBox.Show(Film.FSK.ToString());
            MessageBox.Show(Film.Vor2000.ToString());
        }
    }
}

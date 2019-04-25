using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
using System.Xml;
using System.Xml.Serialization;
using Path = System.IO.Path;

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
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Film.xml";
            saveFileDialog.Filter = "XML|*.xml";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.InitialDirectory = System.Environment.CurrentDirectory;
            if (saveFileDialog.ShowDialog() == true)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Film));
                Stream stream = new FileStream(Path.GetFullPath(saveFileDialog.FileName), FileMode.Create, FileAccess.Write);
                XmlWriter xmlWriter = XmlWriter.Create(stream);
                xmlSerializer.Serialize(stream, Film);

                stream.Close();
            }
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Film));
            Stream stream = new FileStream("Film.txt", FileMode.Open, FileAccess.Read);
            Film = (Film)xmlSerializer.Deserialize(stream);

            DataContext = Film;
            stream.Close();
        }
    }
}

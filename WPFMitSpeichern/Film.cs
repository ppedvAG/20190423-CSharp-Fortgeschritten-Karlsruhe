using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WPFMitSpeichern
{
    public class Film
    {
        public string Titel { get; set; }
        public string Länge { get; set; }
        public string Regisseur { get; set; }
        public int FSK { get; set; }
        [XmlElement("AlterFilm")]
        public bool Vor2000 { get; set; }
    }
}

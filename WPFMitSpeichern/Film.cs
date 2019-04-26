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

		// Der Override hier ist optional damit das Objekt in der Liste nicht als WPFMitSpeichern.Film angezeigt wird, sondern
		// den Text anzeigt, den wir hier zurückgeben (in diesem Fall der Titel)
		// Alternativ können wir auch in der Liste sagen, dass wir den Titel anzeigen lassen wollen über Binding Film.Titel
		// Wir können den Text so gestalten wie wir es wollen.
		// Der Override hat den Nachteil, dass wir der ListBox nun manuell mitteilen müssen, dass sich etwas an den relevanten Daten verändert hat

		//public override string ToString()
		//{
		//	return Titel;
		//}
	}
}

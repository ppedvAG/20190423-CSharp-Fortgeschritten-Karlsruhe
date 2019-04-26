using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMitSpeichern
{
	public class Filme
	{
		// Damit das Databinding funktioniert, muss die Liste eine Property sein
		public List<Film> FilmListe { get; set; }
    }
}

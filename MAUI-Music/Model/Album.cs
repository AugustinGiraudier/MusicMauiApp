using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Music.Model
{
    public class Album
    {

        public string Name { get; set; }
        public string Author { get; set; }
        public string Image { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Date { get; set; }
        public List<Music> Musics { get; set; }

    }
}

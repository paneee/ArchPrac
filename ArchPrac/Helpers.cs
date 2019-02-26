using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchPrac
{
    public class Konfiguracja
    {
        public string sciezkaTotalCommander { get; set; }
        public string sciezkaFolderArchiwum { get; set; }
        public string nazwaPlikuTag { get; set; } 
    }

    public class Dane
    {
        public string Folder { get; set; }
        public string Tagi { get; set; }
    }

    static class Helpers
    {
        static IEnumerable<Dane> SortByLength(IEnumerable<Dane> e)
        { 
            var sorted = from s in e
                         orderby s.Folder.Length ascending
                         select s;
            return sorted;
        }
    }
}

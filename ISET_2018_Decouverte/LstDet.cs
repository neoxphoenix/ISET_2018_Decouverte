using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISET_2018_Decouverte
{
    class LstDet
    {
        private string Nom;
        private List<string> Lst;

        public LstDet(string nom, List<string> liste)
        {
            this.Nom = nom;
            this.Lst = liste;
        }

        public string Nom1 { get => Nom; set => Nom = value; }
        public List<string> Lst1 { get => Lst; set => Lst = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelAccesDate
{
    public interface IStocareData
    {
        void AddMasina(Masina s);
        void Stergere();
        Masina[] GetMasini(out int nrMasini);
        Masina GetMasina(string numeVanzator, string tip);
    }
}

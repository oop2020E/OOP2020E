using System;
using System.Collections.Generic;

namespace KundeDb
{
    public class KundeEfDAL : IKundeDAL
    {
        public bool Create(Kunde nyKunde)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Kunde eksisterendeKunde)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Kunde> Read(Func<Kunde, bool> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Kunde> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Kunde ReadSingle(Func<Kunde, bool> filter)
        {
            throw new NotImplementedException();
        }

        public bool Update(Kunde eksisterendeKunde)
        {
            throw new NotImplementedException();
        }
    }


}

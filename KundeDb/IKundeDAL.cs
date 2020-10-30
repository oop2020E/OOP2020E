using System;
using System.Collections.Generic;

namespace KundeDb
{
    public interface IKundeDAL
    {
        bool Create(Kunde nyKunde);
        bool Update(Kunde eksisterendeKunde);
        bool Delete(Kunde eksisterendeKunde);
        //Hent alle kunder
        IEnumerable<Kunde> ReadAll();
        //Hent kunder der opfylder prædikat
        IEnumerable<Kunde> Read(Func<Kunde, bool> filter);
        //Hent den enkelte kunde der opfylder prædikatet
        Kunde ReadSingle(Func<Kunde, bool> filter);
    }


}

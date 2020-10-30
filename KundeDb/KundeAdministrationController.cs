using System.Collections.Generic;

namespace KundeDb
{

    public class KundeAdministrationController
    {
        IKundeDAL _kundeDAL; //Data Access Layer - vores eksterne afhængighed
        List<Kunde> _lokaleKunder; //Lokalt indlæste kunder

        public KundeAdministrationController() : this(new KundeEfDAL()) { } //Normalt bruger vi Entity Framework

        public KundeAdministrationController(IKundeDAL kundeDAL)
        {
            this._kundeDAL = kundeDAL;
            _lokaleKunder = new List<Kunde>(_kundeDAL.ReadAll());
        }


        //Returnerer hvorvidt kunden blev oprettet
        public bool OpretKunde(Kunde k)
        {
            bool oprettet = false;
            if (k != null && !_lokaleKunder.Contains(k))
            {
                try
                {
                    //Create() kan finde på at smide KundeAlreadyExistsException
                    if (_kundeDAL.Create(k))
                    {
                        _lokaleKunder.Add(k);
                        oprettet = true;
                    }
                }
                catch (KundeAlreadyExistsException) { }
            }

            return oprettet;
        }

        //Flere metoder…
    }


}

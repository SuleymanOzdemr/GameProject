using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.MernisServiceReference1;

namespace GameProject.Adapter
{
    public class MernisServiceAdapter:IUserValidationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64((gamer.Id)) , gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateofBirth.Year);

        }
    }
}

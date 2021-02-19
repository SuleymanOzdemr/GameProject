using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    //MicroService Yani baska bir servis kullanılacak
    class GamerManager:IGamerService
    {
        public IUserValidationService _validationService;

        public GamerManager(IUserValidationService validationService)
        {
            _validationService = validationService;
        }


        public void Add(Gamer gamer)
        {
            if (_validationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " oyuncusu eklendi");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt Başarısız.");
            }
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " oyuncusu güncellendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " oyuncusu silindi");
        }
    }
}

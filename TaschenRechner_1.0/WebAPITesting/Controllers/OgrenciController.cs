using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITesting.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class OgrenciController : ControllerBase
    {

        static List<Ogrenci> ogrenciler = new List<Ogrenci> {
            new Ogrenci { id = 1 , adSoyad="Ahmet Caglar"},
            new Ogrenci { id = 2 , adSoyad="Erdal Caglar"},
            new Ogrenci { id = 3 , adSoyad="Döndü Caglar"}
        };

        [HttpGet]
        public List<Ogrenci> Get()
        {
            //var ogrenciler = new List<Ogrenci>();
            //ogrenciler.Add(new Ogrenci { id = 1 , adSoyad="Ahmet Caglar"});
            //ogrenciler.Add(new Ogrenci { id = 2 , adSoyad="Erdal Caglar"});
            //ogrenciler.Add(new Ogrenci { id = 3 , adSoyad="Döndü Caglar"});

            return ogrenciler;
        }

        [HttpGet("id")]
        public Ogrenci Get(int id)
        {
            return ogrenciler.FirstOrDefault(p => p.id == id);
        }

        [HttpPost]
        public Ogrenci Post(Ogrenci ogrenci)
        {
            ogrenciler.Add(ogrenci);
            return ogrenci;
        }
    }
}

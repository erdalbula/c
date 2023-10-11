using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITesting.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class DavetiyeController : ControllerBase
    {
        static List<Davetli> davetliler = new List<Davetli>{
            new Davetli { ad ="e", soyad="c",cinsiyet="m"},
            new Davetli { ad ="d", soyad="c",cinsiyet="m"},
            new Davetli { ad ="l", soyad="c",cinsiyet="w"},
            new Davetli { ad ="n", soyad="c",cinsiyet="m"},
            new Davetli { ad ="x", soyad="c",cinsiyet="w"}        
        };


        [HttpGet]
        public List<Davetli> Get()
        {
            return davetliler;
        }

        [HttpGet("ad")]
        public Davetli Get(string ad)
        {
            return davetliler.FirstOrDefault(d => d.ad == ad);
        }

        [HttpPost]
        public Davetli Post(Davetli davetli) {
            davetliler.Add(davetli);
            return davetli;
        }


    }
}

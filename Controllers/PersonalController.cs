using ApiSederhana.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ApiSederhana.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalController : ControllerBase
    {
        private static List<Personal> personal = new List<Personal>()
        {
            new Personal()
            {
                Umur = 28,
                Name = "Yanti PWK", 
                //Alamat = "Ciamis",
                Address = new Alamat{Kecamatan = "Kawali", Kota = "Ciamis", Provinsi = "Jawa Barat" },
                Skill = new List<string>{"javascript","Kalkulus"}
            },
            new Personal()
            {
                Umur = 52,
                Name = "Pak Iwan", 
                //Alamat = "Bandung",
                Address = new Alamat{Kecamatan = "Cicendo", Kota = "Bandung", Provinsi = "Jawa Barat" },
                Skill = new List<string>{"Marah-marah","Photograper"}
            },
            new Personal()
            {
                Umur = 30,
                Name = "Pak Nyoman", 
                //Alamat = "Pasteur",
                Address = new Alamat{Kecamatan = "Pasteur", Kota = "Bandung", Provinsi = "Jawa Barat" },
                Skill = new List<string>{ "Keamanan", "Bulu Tangkis"}
            },
            new Personal()
            {
                Umur = 45,
                Name = "Pak Dani", 
                //Alamat = "Cimindi",
                Address = new Alamat{Kecamatan = "Cimindi", Kota = "Bandung", Provinsi = "Jawa Barat" },
                Skill = new List<string>{ "Mudah Ramah", "Mudah Marah"}
            }
        };

        [HttpGet]
        public IEnumerable<Personal> GET()
        {
            return personal;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Personal personal1)
        {
            personal.Add(personal1);
            return Ok(new
            {
                message = "You have successfully logged in", 
                pesan = "Nahh berhasil nambah"
            });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Personal personal1)
        {
            if (id < 0 || id >= personal.Count)
            {
                return BadRequest(new
                {
                    message = "Id tidak valid"
                });
            }

            personal[id] = personal1;
            return Ok(new
            {
                message = "You have successfully Update in",
                pesan = "Nahh berhasil keubah"
            });
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (id < 0 || id >= personal.Count)
            {
                return BadRequest(new
                {
                    message = "Id tidak valid"
                });
            }

            personal.RemoveAt(id);
            return Ok(new
            {
                message = "You have successfully Delete in",
                pesan = "Nahh berhasil kehapus"
            });
        }
    }
}

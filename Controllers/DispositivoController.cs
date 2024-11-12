using _02_Dispositivo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _02_Dispositivo.Controllers
{
    public class DispositivoController : Controller
    {
        public IActionResult Index()
        {
            List<DispositivoEletronico> dispositivos = new List<DispositivoEletronico>
            {
                new Computador { Marca = "Dell", Modelo = "Inspirion", AnoFabricacao = 2021, EhLaptop = true, MemoriaRam = 16, SistemaOperacional = "Windows 11"},
                new Computador { Marca = "Samsung", Modelo = "Inspirion", AnoFabricacao = 2021, EhLaptop = true, MemoriaRam = 16, SistemaOperacional = "Windows 11"}
            };
            return View(dispositivos);
        }
    }
}

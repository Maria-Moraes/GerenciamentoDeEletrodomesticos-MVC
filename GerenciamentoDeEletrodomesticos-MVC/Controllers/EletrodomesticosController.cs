using GerenciamentoDeEletrodomesticos_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoDeEletrodomesticos_MVC.Controllers
{
    public class EletrodomesticosController : Controller
    {
        public IActionResult Index()
        {
            List<Eletrodomestico> eletrodomesticos = new List<Eletrodomestico>
            {
                new Geladeira {Marca = "Brastemp", Modelo = "French Door 3 Portas", ConsumoEnergetico = 56.6, CapacidadeLitros = 554, TemFreezer = true},
                new Televisor {Marca = "Samsung", Modelo = "SmartTV", ConsumoEnergetico = 45, TamanhoTela = 65, EhSmart = true },
                new Geladeira {Marca = "Eletrolux", Modelo = "Frost Free", ConsumoEnergetico = 35.5, CapacidadeLitros = 554, TemFreezer = true },
            };
            return View(eletrodomesticos);
        }
    }
}

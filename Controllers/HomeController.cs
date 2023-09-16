using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Instâncias de clientes
        Cliente cliente1 = new Cliente(1, "Lucas", "123.456.789-00", "lucasfalcao@teste.com.br", "Hércules");
        Cliente cliente2 = new Cliente(2, "Elvis Presley", "123.456.888-00", "elvis@presley.com.br", "Rock");
        Cliente cliente3 = new Cliente(3, "Ada Lovelace", "555.333.222-00", "adalovelace@teste.com.br", "Byron");        
        Cliente cliente4 = new Cliente(4, "Linus Torvalds", "444.222.789-00", "olamundo@teste.com.br", "Pinguim");
        Cliente cliente5 = new Cliente(5, "Arthur Ferreira", "666.456.111-00", "arthur@senai.com.br", "Madruga");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        // Instâncias de fornecedores
        Fornecedor fornecedor1 = new Fornecedor(1, "Olá mundo pet", "11.182.111/0001-00", "olamundo@bol.com.br");
        Fornecedor fornecedor2 = new Fornecedor(2, "Ctrl alt dog", "11.444.122/0001-00", "ctrlaltdog@bol.com.br");
        Fornecedor fornecedor3 = new Fornecedor(3, "Bookspet inc", "12.182.144/0001-00", "bookspet@pets.com");
        Fornecedor fornecedor4 = new Fornecedor(4, "Petz", "44.188.141/0001-00", "petzw3@petz.com.br");
        Fornecedor fornecedor5 = new Fornecedor(5, "Au que mia", "24.223.121/0001-00", "au@quemia.com.br");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>(); 
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

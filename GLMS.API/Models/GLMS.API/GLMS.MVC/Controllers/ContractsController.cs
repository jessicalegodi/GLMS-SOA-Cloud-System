using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using GLMS.MVC.Models;

public class ContractsController : Controller
{
    private readonly HttpClient _client;

    public ContractsController(IHttpClientFactory factory)
    {
        _client = factory.CreateClient();
    }

    public async Task<IActionResult> Index()
    {
        var response = await _client.GetAsync("https://localhost:5001/api/contracts");

        var json = await response.Content.ReadAsStringAsync();

        var data = JsonConvert.DeserializeObject<List<Contract>>(json);

        return View(data);
    }
}

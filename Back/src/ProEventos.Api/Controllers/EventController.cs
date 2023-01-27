using Microsoft.AspNetCore.Mvc;
using ProEventos.Api.Models;

namespace ProEventos.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class EventController : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento()
            {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Belo Horizonte",
                Lote = "1º lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
            },
            new Evento()
            {
                EventoId = 2,
                Tema = "Angular 12",
                Local = "Rio de Janeiro",
                Lote = "1º lote",
                QtdPessoas = 300,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto2.png"
            }
        };
    public EventController()
    {

    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id){
        return _evento.Where(evento => evento.EventoId == id);
    }


    [HttpPost]
    public string Post()
    {
        return "exemplo de post";
    }


    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"exemplo de put com id = {id}";
    }


    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"exemplo de delete com id = {id}";
    }
}

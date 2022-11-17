using dpilacuan_api_net.Application;
using dpilacuan_api_net.Domain;
using Microsoft.AspNetCore.Mvc;

namespace dpilacuan_api_net.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RickAndMortyController:ControllerBase
{
    private readonly IRickAndMortyAppService rickAndMortyAppService;

    RickAndMortyController(IRickAndMortyAppService rickAndMortyAppService)
    {
        this.rickAndMortyAppService=rickAndMortyAppService;
    }

    [HttpGet("personajes")]
    public ICollection<ClasePersonaje> obtenerPersonajes()
    {
        return rickAndMortyAppService.GetResult();
    }

}

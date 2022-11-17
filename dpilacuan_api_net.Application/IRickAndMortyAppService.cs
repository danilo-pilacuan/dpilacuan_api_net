using dpilacuan_api_net.Domain;

namespace dpilacuan_api_net.Application;

public interface IRickAndMortyAppService
{
    ICollection<ClasePersonaje> GetResult();
}

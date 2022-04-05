using RoofSnap.Interview.DTO;

namespace RoofSnap.Interview.HttpClients;

public interface IBeerClient
{
    public Task<IEnumerable<BeerData>?> GetBeersAsync();
}
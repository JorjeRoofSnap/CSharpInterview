using RoofSnap.Interview.DTO;

namespace RoofSnap.Interview.HttpClients.Decorators
{
    public interface ISortByIBUDecorator
    {
        Task<IEnumerable<BeerData>?> GetBeersAsync();
    }

    // TODO: Make sure this class is registered in IoC
    public class SortByIBUDecorator : IBeerClient, ISortByIBUDecorator
    {
        private readonly IBeerClient _client;

        public SortByIBUDecorator(IBeerClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<BeerData>?> GetBeersAsync()
        {
            var beers = await _client.GetBeersAsync();

            var sortedBeers = beers; // TODO: Use linq to sort this list by IBU.

            return sortedBeers;
        }
    }
}

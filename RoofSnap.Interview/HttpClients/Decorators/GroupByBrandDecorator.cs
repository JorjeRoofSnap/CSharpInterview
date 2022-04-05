using RoofSnap.Interview.DTO;

namespace RoofSnap.Interview.HttpClients.Decorators
{
    public interface IGroupByBrandDecorator
    {
        Task<IEnumerable<BeerData>?> GetBeersAsync();
    }

    // TODO: Make sure this class is registered in IoC
    public class GroupByBrandDecorator : IBeerClient, IGroupByBrandDecorator

    {
        private readonly IBeerClient _client;

        public GroupByBrandDecorator(IBeerClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<BeerData>?> GetBeersAsync()
        {
            var beers = await _client.GetBeersAsync();

            var groupBeers = beers; // TODO: Use linq to group this list by brand.

            return groupBeers;
        }
    }
}

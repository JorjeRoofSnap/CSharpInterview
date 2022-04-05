using RoofSnap.Interview.DTO;

namespace RoofSnap.Interview.HttpClients
{
    public class BeerClient : IBeerClient
    {
        private static IEnumerable<BeerData>? _cache; // TODO: Can you make use of this variable so all the decorators get the same data?

        public Task<IEnumerable<BeerData>?> GetBeersAsync()
        {
            // TODO: Implement this method using this api: https://random-data-api.com/api/beer/random_beer?size=25

            var fakeData = new List<BeerData>
            {
                new()
                {
                    Brand = "Not a brand",
                    Name = "Please implement me",
                    IBU = "Not an IBU",
                    Style = "Not implemented"
                }
            }.AsEnumerable();

            return Task.FromResult(fakeData);
        }
    }
}
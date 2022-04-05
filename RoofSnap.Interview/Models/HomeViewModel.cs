using RoofSnap.Interview.DTO;

namespace RoofSnap.Interview.Models
{
    public class HomeViewModel
    {
        public IEnumerable<BeerData>? RawBeerData { get; set; }

        public IEnumerable<BeerData>? SortedByIBU { get; set; }

        public IEnumerable<BeerData>? GroupedByBrand { get; set; }
    }
}

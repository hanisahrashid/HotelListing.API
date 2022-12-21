using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Models.Country
{
    public class ViewCountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string shortName { get; set; }
        public List<ViewHotelDto> Hotels { get; set; }
    }
}

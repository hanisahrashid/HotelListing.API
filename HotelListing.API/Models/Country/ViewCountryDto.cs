using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Models.Country
{
    public class ViewCountryDto : BaseCountryDto
    {
        public int Id { get; set; }
        public List<ViewHotelDto> Hotels { get; set; }
    }
}

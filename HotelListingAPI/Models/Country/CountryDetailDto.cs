using System;
using HotelListingAPI.Models.Hotel;

namespace HotelListingAPI.Models.Country
{
    public class CountryDetailsDto : BaseCountryDto
    {
        public int Id { get; set; }

        public List<HotelDto> Hotels { get; set; }

    }
}


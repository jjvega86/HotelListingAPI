﻿using System;
using AutoMapper;
using HotelListingAPI.Data;
using HotelListingAPI.Models.Country;
using HotelListingAPI.Models.Hotel;

namespace HotelListingAPI.Configurations
{
	public class MapperConfig : Profile
	{
		public MapperConfig()
		{
			CreateMap<Country, CreateCountryDto>().ReverseMap();
			CreateMap<Country, GetCountryDto>().ReverseMap();
			CreateMap<Country, CountryDetailsDto>().ReverseMap();
			CreateMap<Country, UpdateCountryDto>().ReverseMap();

			CreateMap<Hotel, HotelDto>().ReverseMap();
		}
	}
}


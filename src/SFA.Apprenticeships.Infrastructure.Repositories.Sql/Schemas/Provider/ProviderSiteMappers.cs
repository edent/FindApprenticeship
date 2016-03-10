﻿namespace SFA.Apprenticeships.Infrastructure.Repositories.Sql.Schemas.Provider
{
    using Infrastructure.Common.Mappers;
    using Vacancy;
    using DomainPostalAddress = Domain.Entities.Raa.Locations.PostalAddress;
    using DatabaseProviderSite = Entities.ProviderSite;
    using DomainProviderSite = Domain.Entities.Raa.Parties.ProviderSite;

    public class ProviderSiteMappers : MapperEngine
    {
        public override void Initialise()
        {
            Mapper.CreateMap<DatabaseProviderSite, DomainProviderSite>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(source => source.FullName))
                .IgnoreMember(dest => dest.Address)
                .AfterMap((source, dest) =>
                {
                    dest.Address = new DomainPostalAddress
                    {
                        AddressLine1 = source.AddressLine1,
                        AddressLine2 = source.AddressLine2,
                        AddressLine3 = source.AddressLine3,
                        AddressLine4 = source.AddressLine4,
                        AddressLine5 = source.AddressLine5,
                        Postcode = source.PostCode,
                        Town = source.Town
                    };

                    if (source.Latitude.HasValue && source.Longitude.HasValue)
                    {
                        dest.Address.GeoPoint = new Domain.Entities.Raa.Locations.GeoPoint
                        {
                            Latitude = (double)source.Latitude.Value,
                            Longitude = (double)source.Longitude.Value
                        };
                    }
                });

            Mapper.CreateMap<DomainProviderSite, DatabaseProviderSite>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(source => source.Name))
                .IgnoreMember(dest => dest.CountyId)
                .IgnoreMember(dest => dest.GeocodeEasting)
                .IgnoreMember(dest => dest.GeocodeNorthing)
                .MapMemberFrom(dest => dest.AddressLine1, source => source.Address.AddressLine1)
                .MapMemberFrom(dest => dest.AddressLine2, source => source.Address.AddressLine2)
                .MapMemberFrom(dest => dest.AddressLine3, source => source.Address.AddressLine3)
                .MapMemberFrom(dest => dest.AddressLine4, source => source.Address.AddressLine4)
                .MapMemberFrom(dest => dest.AddressLine5, source => source.Address.AddressLine5)
                .MapMemberFrom(dest => dest.PostCode, source => source.Address.Postcode)
                .MapMemberFrom(dest => dest.Town, source => source.Address.Town)
                .MapMemberFrom(dest => dest.Latitude, source => (decimal)source.Address.GeoPoint.Latitude) // use a converter?
                .MapMemberFrom(dest => dest.Longitude, source => (decimal)source.Address.GeoPoint.Longitude); // use a converter?
        }
    }
}

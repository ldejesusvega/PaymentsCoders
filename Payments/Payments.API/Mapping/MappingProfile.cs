using AutoMapper;
using Payment.Domain;

namespace Payments.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<PaymentD, PaymentResource>();

            // Resource to Domain
            CreateMap<PaymentResource, PaymentD>();

            CreateMap<SavePaymentResource, PaymentD>();
        }
    }
}
using AutoMapper;
using Lab4.Models;
using Lab4.ViewModels;
namespace Lab4
{
    public class Mapping
    {
        public void Create()
        {
            Mapper.CreateMap<Car, CarViewModel>();
            Mapper.CreateMap<CarViewModel, Car>();

            Mapper.CreateMap<Reservation, ReservationViewModel>();
            Mapper.CreateMap<ReservationViewModel, Reservation>();
        }
    }
}

using AutoMapper;
using Core.Dto;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MapperProfiles
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<MenuDto, Menu>().ReverseMap();
            CreateMap<CreateMenuDto, Menu>();
            CreateMap<EditMenuDto, Menu>();
            CreateMap<BreadDto, Bread>().ReverseMap();
            CreateMap<CreateBreadDto, Bread>();
            CreateMap<EditBreadDto, Bread>();
            CreateMap<DrinkcDto, Drinkc>().ReverseMap();
            CreateMap<CreateDrinkcDto, Drinkc>();
            CreateMap<EditDrinkcDto, Drinkc>();
            CreateMap<FirstDishesDto, FirstDishes>().ReverseMap();
            CreateMap<CreateFirstDishesDto, FirstDishes>();
            CreateMap<EditFirstDishesDto, FirstDishes>();
            CreateMap<GarnishDto, Garnish>().ReverseMap();
            CreateMap<CreateGarnishDto, Garnish>();
            CreateMap<EditGarnishDto, Garnish>();
            CreateMap<MeatDishesDto, MeatDishes>().ReverseMap();
            CreateMap<CreateMeatDishesDto, MeatDishes>();
            CreateMap<EditMeatDishesDto, MeatDishes>();
            CreateMap<SaladDto, Salad>().ReverseMap();
            CreateMap<CreateSaladDto, Salad>();
            CreateMap<EditSaladDto, Salad>();

        }
    }
}

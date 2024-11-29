using AutoMapper;
using Core.Dto;
using Core.Interfaces;
using Data.Entities;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class FirstDishesServices : IFirstDishesServices
    {
        public readonly IMapper mapper;
        public readonly IRepository<FirstDishes> repositoryF;
        //public readonly DiningRoomDbContext cxt;
        public FirstDishesServices(IMapper mapper, IRepository<FirstDishes> repositoryF)
        {
            this.mapper = mapper;
            this.repositoryF = repositoryF;
        }
        public async Task Create(CreateFirstDishesDto model)
        {
            await repositoryF.Insert(mapper.Map<FirstDishes>(model));
            await repositoryF.Save(); ;
        }

        public async Task Delete(int id)
        {
            var firstDishes = await repositoryF.GetById(id);
            //if (bread == null) throw new HttpException("Doctor not faund", HttpStatusCode.NotFound); // TODO: exception

            await repositoryF.Delete(firstDishes);
            await repositoryF.Save();
        }

        public async Task Edit(EditFirstDishesDto model)
        {
            await repositoryF.Update(mapper.Map<FirstDishes>(model));
            await repositoryF.Save();
        }

        public async Task<FirstDishesDto?> Get(int id)
        {
            var firstDishes = await repositoryF.GetById(id);
            //if (bread == null) //return null;
            //    throw new HttpException("Doctor not faund", HttpStatusCode.NotFound);
            // load related table data
            //   await ctx.Entry(doctor).Reference(x => x.Category).LoadAsync();

            return mapper.Map<FirstDishesDto>(firstDishes);
        }

        public async Task<IEnumerable<FirstDishesDto>> GetAll()
        {
            return mapper.Map<List<FirstDishesDto>>(await repositoryF.GetAll());
        }
    }
}

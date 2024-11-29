using AutoMapper;
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
    public class MeatDishesServices : IMeatDishesServices
    {
        public readonly IMapper mapper;
        public readonly IRepository<MeatDishes> repositoryM;
        //public readonly DiningRoomDbContext cxt;
        public MeatDishesServices(IMapper mapper, IRepository<MeatDishes> repositoryM)
        {
            this.mapper = mapper;
            this.repositoryM = repositoryM;
        }
        public async Task Create(CreateMeatDishesDto model)
        {
            await repositoryM.Insert(mapper.Map<MeatDishes>(model));
            await repositoryM.Save(); ;
        }


        public async Task Delete(int id)
        {
            var bread = await repositoryM.GetById(id);
            //if (bread == null) throw new HttpException("Doctor not faund", HttpStatusCode.NotFound); // TODO: exception

            await repositoryM.Delete(bread);
            await repositoryM.Save();
        }

        public async Task Edit(EditMeatDishesDto model)
        {
            await repositoryM.Update(mapper.Map<MeatDishes>(model));
            await repositoryM.Save();
        }

        public async Task<MeatDishesDto?> Get(int id)
        {
            var bread = await repositoryM.GetById(id);
            //if (bread == null) //return null;
            //    throw new HttpException("Doctor not faund", HttpStatusCode.NotFound);
            // load related table data
            //   await ctx.Entry(doctor).Reference(x => x.Category).LoadAsync();

            return mapper.Map<MeatDishesDto>(bread);
        }

        public async Task<IEnumerable<MeatDishesDto>> GetAll()
        {
            return mapper.Map<List<MeatDishesDto>>(await repositoryM.GetAll());
        }
    }
}

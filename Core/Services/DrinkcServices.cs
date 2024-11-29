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
    public class DrinkcServices : IDrinkcServices
    {
        public readonly IMapper mapper;
        public readonly IRepository<Drinkc> repositoryD;
        //public readonly DiningRoomDbContext cxt;
        public DrinkcServices(IMapper mapper, IRepository<Drinkc> repositoryD)
        {
            this.mapper = mapper;
            this.repositoryD = repositoryD;
        }
        public async Task Create(CreateDrinkcDto model)
        {
            await repositoryD.Insert(mapper.Map<Drinkc>(model));
            await repositoryD.Save(); ;
        }

        public async Task Delete(int id)
        {
            var drinkc = await repositoryD.GetById(id);
            //if (bread == null) throw new HttpException("Doctor not faund", HttpStatusCode.NotFound); // TODO: exception

            await repositoryD.Delete(drinkc);
            await repositoryD.Save();
        }

        public async Task Edit(EditDrinkcDto model)
        {
            await repositoryD.Update(mapper.Map<Drinkc>(model));
            await repositoryD.Save();
        }

        public async Task<DrinkcDto?> Get(int id)
        {
            var drinkc = await repositoryD.GetById(id);
            //if (bread == null) //return null;
            //    throw new HttpException("Doctor not faund", HttpStatusCode.NotFound);
            // load related table data
            //   await ctx.Entry(doctor).Reference(x => x.Category).LoadAsync();

            return mapper.Map<DrinkcDto>(drinkc);
        }

        public async Task<IEnumerable<DrinkcDto>> GetAll()
        {
            return mapper.Map<List<DrinkcDto>>(await repositoryD.GetAll());
        }

        
    }
}

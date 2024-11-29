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
    public class SaladServices : ISaladServices
    {
        public readonly IMapper mapper;
        public readonly IRepository<Salad> repositoryS;
        //public readonly DiningRoomDbContext cxt;
        public SaladServices(IMapper mapper, IRepository<Salad> repositoryS)
        {
            this.mapper = mapper;
            this.repositoryS = repositoryS;
        }
        public async Task Create(CreateSaladDto model)
        {
            await repositoryS.Insert(mapper.Map<Salad>(model));
            await repositoryS.Save(); ;
        }

        public async Task Delete(int id)
        {
            var bread = await repositoryS.GetById(id);
            //if (bread == null) throw new HttpException("Doctor not faund", HttpStatusCode.NotFound); // TODO: exception

            await repositoryS.Delete(bread);
            await repositoryS.Save();
        }

        public async Task Edit(EditSaladDto model)
        {
            await repositoryS.Update(mapper.Map<Salad>(model));
            await repositoryS.Save();
        }

        public async Task<SaladDto?> Get(int id)
        {
            var bread = await repositoryS.GetById(id);
            //if (bread == null) //return null;
            //    throw new HttpException("Doctor not faund", HttpStatusCode.NotFound);
            // load related table data
            //   await ctx.Entry(doctor).Reference(x => x.Category).LoadAsync();

            return mapper.Map<SaladDto>(bread);
        }

        public async Task<IEnumerable<SaladDto>> GetAll()
        {
            return mapper.Map<List<SaladDto>>(await repositoryS.GetAll());
        }
    }
}

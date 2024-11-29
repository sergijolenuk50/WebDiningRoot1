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
    public class GarnishServices : IGarnishServices
    {
        public readonly IMapper mapper;
        public readonly IRepository<Garnish> repositoryG;
        //public readonly DiningRoomDbContext cxt;
        public GarnishServices(IMapper mapper, IRepository<Garnish> repositoryG)
        {
            this.mapper = mapper;
            this.repositoryG = repositoryG;
        }
        public async Task Create(CreateGarnishDto model)
        {
            await repositoryG.Insert(mapper.Map<Garnish>(model));
            await repositoryG.Save(); ;
        }

        public async Task Delete(int id)
        {
            var garnish = await repositoryG.GetById(id);
            //if (bread == null) throw new HttpException("Doctor not faund", HttpStatusCode.NotFound); // TODO: exception

            await repositoryG.Delete(garnish);
            await repositoryG.Save();
        }

        public async Task Edit(EditGarnishDto model)
        {
            await repositoryG.Update(mapper.Map<Garnish>(model));
            await repositoryG.Save();
        }

        public async Task<GarnishDto?> Get(int id)
        {
            var garnish = await repositoryG.GetById(id);
            //if (bread == null) //return null;
            //    throw new HttpException("Doctor not faund", HttpStatusCode.NotFound);
            // load related table data
            //   await ctx.Entry(doctor).Reference(x => x.Category).LoadAsync();

            return mapper.Map<GarnishDto>(garnish);
        }

        public async Task<IEnumerable<GarnishDto>> GetAll()
        {
            return mapper.Map<List<GarnishDto>>(await repositoryG.GetAll());
        }
    }
}

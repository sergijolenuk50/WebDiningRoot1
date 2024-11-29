using AutoMapper;
using Core.Dto;
using Core.Interfaces;
using Data.Data;
using Data.Entities;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class BreadServices : IBreadServices
    {
        public readonly IMapper mapper;
        public readonly IRepository<Bread> repositoryB;
        //public readonly DiningRoomDbContext cxt;
        public BreadServices(IMapper mapper, IRepository<Bread> repositoryB)
        {
            this.mapper = mapper;
            this.repositoryB = repositoryB;
        }
        public async Task Create(CreateBreadDto model)
        {
            await repositoryB.Insert(mapper.Map<Bread>(model));
            await repositoryB.Save(); ;
        }

        public async Task Delete(int id)
        {
            var bread = await repositoryB.GetById(id);
            //if (bread == null) throw new HttpException("Doctor not faund", HttpStatusCode.NotFound); // TODO: exception

            await repositoryB.Delete(bread);
            await repositoryB.Save();
        }

        public async Task Edit(EditBreadDto model)
        {
           await repositoryB.Update(mapper.Map<Bread>(model));
            await repositoryB.Save();
        }

        public async Task<BreadDto?> Get(int id)
        {
            var bread = await repositoryB.GetById(id);
            //if (bread == null) //return null;
            //    throw new HttpException("Doctor not faund", HttpStatusCode.NotFound);
            // load related table data
            //   await ctx.Entry(doctor).Reference(x => x.Category).LoadAsync();

            return mapper.Map<BreadDto>(bread);
        }

        public async Task<IEnumerable<BreadDto>> GetAll()
        {
            return mapper.Map<List<BreadDto>>(await repositoryB.GetAll());
        }
    }
}

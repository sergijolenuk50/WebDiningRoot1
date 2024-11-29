using AutoMapper;
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
    public class MenuServices : IMenuServices
    {

        public readonly IMapper mapper;
        public readonly IRepository<Menu> repositoryM;
        //public readonly DiningRoomDbContext cxt;
        public MenuServices(IMapper mapper, IRepository<Menu> repositoryM, DiningRoomDbContext cxt)
        {
            this .mapper = mapper;
            this .repositoryM = repositoryM;
            //this .cxt = cxt;
        }
        public async Task Archive(int id)
        {
            var menu = await repositoryM.GetById(id);
            //if (menu == null)
            //    throw new HttpException("Doctors not faund", HttpStatusCode.NotFound); // TODO: exception

            menu.Archived = true;
            await repositoryM.Save();
        }

        public async Task Create(CreateMenuDto model)
        {
            await repositoryM.Insert(mapper.Map<Menu>(model));
            await repositoryM.Save(); ;
        }

        public async Task Delete(int id)
        {
            var menu = await repositoryM.GetById(id);
            //if (menu == null) throw new HttpException("Doctor not faund", HttpStatusCode.NotFound); // TODO: exception

            await repositoryM.Delete(menu);
            await repositoryM.Save();
        }

        public async Task Edit(EditMenuDto model)
        {
            await repositoryM.Update(mapper.Map<Menu>(model));
            await repositoryM.Save();
        }

        public async Task<MenuDto?> Get(int id)
        {
            var menu = await repositoryM.GetById(id);
            //if (menu == null) //return null;
            //    throw new HttpException("Doctor not faund", HttpStatusCode.NotFound);
            // load related table data
            //   await ctx.Entry(doctor).Reference(x => x.Category).LoadAsync();

            //return mapper.Map<MenuDto>(menu);
            return mapper.Map<MenuDto>((await repositoryM.Get(filter: x => x.Id == id, includeProperties: "Salad,Bread,FirstDishes,Garnish,MeatDishes,Drinkc")).First());

        }

        public async Task<IEnumerable<MenuDto>> GetAll()
        {
            return mapper.Map<List<MenuDto>>(await repositoryM.Get(includeProperties: "Salad,Bread,FirstDishes,Garnish,MeatDishes,Drinkc"));

        }

        public async Task Restore(int id)
        {
            var menu = await repositoryM.GetById(id);
            //if (menu == null) //return; // TODO: exception
            //    throw new HttpException("Doctor not faund", HttpStatusCode.NotFound);
            menu.Archived = false;
            await repositoryM.Save();
        }
    }
}

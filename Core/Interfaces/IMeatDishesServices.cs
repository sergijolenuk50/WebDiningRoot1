using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IMeatDishesServices
    {
        Task<IEnumerable<MeatDishesDto>> GetAll();
        Task<MeatDishesDto?> Get(int id);
        Task Edit(EditMeatDishesDto model);
        Task Create(CreateMeatDishesDto model);
        Task Delete(int id);
    }
}

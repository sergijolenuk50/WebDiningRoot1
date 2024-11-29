using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IMenuServices
    {
        Task<IEnumerable<MenuDto>> GetAll();
        Task<MenuDto?> Get(int id);
        Task Edit(EditMenuDto model);
        Task Create(CreateMenuDto model);
        Task Delete(int id);
        Task Archive(int id);
        Task Restore(int id);
    }
}

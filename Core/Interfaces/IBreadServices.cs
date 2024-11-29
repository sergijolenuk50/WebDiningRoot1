using Core.Dto;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IBreadServices
    {
        Task<IEnumerable<BreadDto>> GetAll();
        Task<BreadDto?> Get(int id);
        Task Edit(EditBreadDto model);
        Task Create(CreateBreadDto model);
        Task Delete(int id);
    }
}

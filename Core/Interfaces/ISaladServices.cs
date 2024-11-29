using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ISaladServices
    {
        Task<IEnumerable<SaladDto>> GetAll();
        Task<SaladDto?> Get(int id);
        Task Edit(EditSaladDto model);
        Task Create(CreateSaladDto model);
        Task Delete(int id);
    }
}

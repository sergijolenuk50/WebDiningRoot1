using Core.Dto;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IDrinkcServices
    {
        Task<IEnumerable<DrinkcDto>> GetAll();
        Task<DrinkcDto?> Get(int id);
        Task Edit(EditDrinkcDto model);
        Task Create(CreateDrinkcDto model);
        Task Delete(int id);
    }
}

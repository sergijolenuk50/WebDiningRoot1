using Core.Dto;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IFirstDishesServices
    {
        Task<IEnumerable<FirstDishesDto>> GetAll();
        Task<FirstDishesDto?> Get(int id);
        Task Edit(EditFirstDishesDto model);
        Task Create(CreateFirstDishesDto model);
        Task Delete(int id);
    }
}

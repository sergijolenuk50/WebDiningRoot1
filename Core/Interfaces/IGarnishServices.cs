using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGarnishServices
    {
        Task<IEnumerable<GarnishDto>> GetAll();
        Task<GarnishDto?> Get(int id);
        Task Edit(EditGarnishDto model);
        Task Create(CreateGarnishDto model);
        Task Delete(int id);
    }
}

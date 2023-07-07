using SteamCloneApp.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamCloneApp.DataAccess.Repositories
{
    public interface IImageRepository : IEntityRepository<Image>
    {
        Task AddRange(IEnumerable<Image> images);
        Task RemoveRange(IEnumerable<Image> images);
    }
}

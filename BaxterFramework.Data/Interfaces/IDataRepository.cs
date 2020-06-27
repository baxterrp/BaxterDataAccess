using BaxterFramework.Common;
using BaxterFramework.Data.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaxterFramework.Data.Interfaces
{
    public interface IDataRepository<TDataEntity> where TDataEntity : BaseResource
    {
        Task<TDataEntity> Add(TDataEntity dataEntity);
        Task<TDataEntity> Update(TDataEntity dataEntity);
        Task Delete(string entityId);
        Task<TDataEntity> FindById(string entityId);
        Task<IEnumerable<TDataEntity>> Search(IEnumerable<SearchParameter> searchParameters);
    }
}

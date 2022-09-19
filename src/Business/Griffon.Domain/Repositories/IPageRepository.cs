using Griffon.Domain.Entities;
using Griffon.Domain.Repositories.Base;

namespace Griffon.Domain.Repositories
{
    public interface IPageRepository : IBaseRepository<Guid, Page>
    {
    }
}

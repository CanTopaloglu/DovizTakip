using DovizTakipServer.Domain.Entities;
using DovizTakipServer.Domain.Repositories;
using DovizTakipServer.Infrastructure.Context;
using GenericRepository;

namespace DovizTakipServer.Infrastructure.Repositories;
internal sealed class CurrencyRepositories : Repository<Currency, ApplicationDbContext>, ICurrencyRepository
{
    public CurrencyRepositories(ApplicationDbContext context) : base(context)
    {
    }
}

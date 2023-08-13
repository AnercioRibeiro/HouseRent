using HouseRent_API.Data;
using HouseRent_API.Repository.IRepository;

namespace HouseRent_API.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public ICountyRepository Counties { get; private set; }

        public IOwnerRepository Owners { get; private set; }

        public IPropertyRepository Properties { get; private set; }

        public IProvinceRepository Provincies { get; private set; }

        public IPublicationRepository Publications { get; private set; }

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Counties = new CountyRepository(_dbContext);
            Owners = new OwnerRepository(_dbContext);
            Properties = new PropertyRepository(_dbContext);
            Provincies = new ProvinceRepository(_dbContext);
            Publications = new PublicationRepository(_dbContext);

            _dbContext.Database.EnsureCreated();
        }
        public int Complete()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}

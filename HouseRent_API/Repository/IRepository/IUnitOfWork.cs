namespace HouseRent_API.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
       ICountyRepository Counties { get; }
       IOwnerRepository Owners { get; }
       IPropertyRepository Properties { get; }
       IProvinceRepository Provincies { get; }
       IPublicationRepository Publications { get; }
       int Complete();

    }
}

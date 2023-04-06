using DelegateFactory.Model;

namespace DelegateFactory.Factory
{
  public interface IFactory
  {
    IPerson GetPerson(PersonType type);
  }

  public class PersonFactory : IFactory
  {
    public IPerson GetPerson(PersonType type)
    {
      switch (type)
      {
        case PersonType.Rural:
          return new Villager();
        case PersonType.Urban:
          return new CityPerson();
        default:
          throw new NotSupportedException();
      }
    }
  }
}
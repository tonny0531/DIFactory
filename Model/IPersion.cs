namespace DelegateFactory.Model
{

  public interface IPerson
  {
    string GetName();
  }

  public class Villager : IPerson
  {
    public string GetName()
    {
      return "Village Person";
    }
  }

  public class CityPerson : IPerson
  {
    public string GetName()
    {
      return "City Person";
    }
  }

  public enum PersonType
  {
    Rural,
    Urban
  }
}
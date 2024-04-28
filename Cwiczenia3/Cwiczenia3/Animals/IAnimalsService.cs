namespace Cwiczenia3.Animals;

public interface IAnimalsService
{
    IEnumerable<Animal> GetAnimals(string orderValue);
    int CreateAnimal(Animal animal);
    Animal? GetAnimal(int idAnimal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int idAnimal);
}
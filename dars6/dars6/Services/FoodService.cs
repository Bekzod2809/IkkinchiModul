using dars6.Dtos;
using dars6.Model;

namespace dars6.Services;

public class FoodService : IFoodService
{
    List<Food> Foods;
    public FoodService()
    {
        Foods = new List<Food>();
    }
    public Guid AddFood(FoodCreateDtos foodCreateDtos)
    {
        var food = new Food
        {
            FoodId = Guid.NewGuid(),
            Name = foodCreateDtos.Name,
            Price = foodCreateDtos.Price,
            Description = foodCreateDtos.Description,
            Calories = foodCreateDtos.Calories
        };
        Foods.Add(food);
        return food.FoodId;
    }

    public bool DeleteFood(Guid foodId)
    {
        foreach (var food in Foods)
        {
            if (food.FoodId == foodId)
            {
                Foods.Remove(food);
                return true;
            }
        }
        return false;
    }

    public List<FoodGetDto> GetAllFood()
    {
        throw new NotImplementedException();
    }

    public FoodGetDto? GetFoodById(Guid foodId)
    {
        throw new NotImplementedException();
    }

    public FoodGetDto? GetFoodWithMaxPrice()
    {
        throw new NotImplementedException();
    }

    public FoodGetDto? GetFoodWithMinPrice()
    {
        throw new NotImplementedException();
    }

    public bool UpdateFood(Guid foodId, FoodUpdateDto foodUpdateDto)
    {
        throw new NotImplementedException();
    }   
}

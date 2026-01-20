using dars6.Dtos;

namespace dars6.Services;

public interface IFoodService
{
    public Guid AddFood(FoodCreateDtos foodCreateDtos);
    public FoodGetDto? GetFoodById(Guid foodId);
    public List<FoodGetDto> GetAllFood();
    public bool DeleteFood(Guid foodId);
    public bool UpdateFood(Guid foodId, FoodUpdateDto foodUpdateDto);
    public FoodGetDto? GetFoodWithMaxPrice();
    public FoodGetDto? GetFoodWithMinPrice();
}
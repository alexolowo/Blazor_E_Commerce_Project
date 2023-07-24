// Defining categories interface for category service class
namespace BlazorEcommerce.Client.Services.CategoryService
{
	public interface ICategoryService
	{
		List<Category> Categories { get; set; }

		Task GetCategories();
	}
}

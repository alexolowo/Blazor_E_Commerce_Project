namespace BlazorEcommerce.Server.Services.CategoryService
{
	public interface ICategoryService
	{
		//Note: All methods are asynchronous, no need for Async at the end of methoids
		Task<ServiceResponse<List<Category>>> GetCategories();
	}
}

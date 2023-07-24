namespace BlazorEcommerce.Server.Services.CategoryService
{
	public class CategoryService : ICategoryService
	{
		private readonly DataContext _context;

		public CategoryService(DataContext context)
		{
			_context = context;
		}
		async Task<ServiceResponse<List<Category>>> ICategoryService.GetCategories()
		{
			var categories = await _context.Categories.ToListAsync();
			return new ServiceResponse<List<Category>>
			{
				Data = categories
			};
		}
	}
}

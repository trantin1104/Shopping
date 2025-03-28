﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Shopping.Repository.Components
{

	public class BrandsViewComponent :ViewComponent
	{
		private readonly DataContext _dataContext;
		public BrandsViewComponent(DataContext Context)
		{
			_dataContext = Context;
		}
		public async Task<IViewComponentResult> InvokeAsync() => View(await _dataContext.Brands.ToListAsync());

	}
}

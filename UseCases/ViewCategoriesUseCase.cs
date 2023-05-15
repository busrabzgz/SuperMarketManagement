﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
	public  class ViewCategoriesUseCase: IViewCategoryUseCase
	{
		private readonly ICategoryRepository categoryRepository;

		public ViewCategoriesUseCase(ICategoryRepository categoryRepository)
		{
			this.categoryRepository = categoryRepository;
		}
		public IEnumerable<Category> Execute()
		{
			return categoryRepository.GetCategories();

		}
	}


}
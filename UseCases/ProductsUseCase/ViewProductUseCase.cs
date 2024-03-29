﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCasesInterfaces;

namespace UseCases.ProductsUseCase
{
    public class ViewProductUseCase : IViewProductUseCase
    {
        private IProductRepository productRepository;
        public ViewProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IEnumerable<Product> ViewAllProducts()
        {
            return productRepository.GetAllProducts();
        }

    }
}

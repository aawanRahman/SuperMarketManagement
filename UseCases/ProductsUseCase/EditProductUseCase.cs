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
    public class EditProductUseCase : IEditProductUseCase
    {
        private IProductRepository productRepository;
        public EditProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public void editProduct(Product product)
        {
            productRepository.editProduct(product);
        }
    }
}

﻿using Anti_Corona.Business.Abstract;
using Anti_Corona.Data.Abstract;
using Anti_Corona.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anti_Corona.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Create(Product entity)
        {
            _productRepository.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }
    }
}
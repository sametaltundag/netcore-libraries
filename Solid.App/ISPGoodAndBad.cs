﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.ISPGoodAndBad
{
    // 1. Class Library Read Impl
    // 2. Class Library Create/Update/Delete Impl


    // 1. Class Library
    public class ReadProductRepo : IReadRepo
    {
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }
    }

    // 2. Class Library
    public class WriteProductRepo : IWriteRepo
    {
        public Product Create(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException();
        }
    }


    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    // Bad way
    /*
    public interface IProductRepository
    {
        List<Product> GetList();
        Product GetById(int id);

        Product Create(Product product);
        Product Update(Product product);
        Product Delete(int id);
    }
    */


    // Good way
    public interface IReadRepo
    {
        List<Product> GetList();
        Product GetById(int id);
    }

    public interface IWriteRepo
    {
        Product Create(Product product);
        Product Update(Product product);
        Product Delete(int id);
    }
}

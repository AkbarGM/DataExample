using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExample
{
    class ProductsRepository
    {
        SqlConnect sqlConnect;
        public ProductsRepository()
        {
            sqlConnect = new SqlConnect();
        }
        public void GetProducts()
        {
            string str = "SELECT * FROM Products";
            sqlConnect.Open();
            sqlConnect.Get(str);
            sqlConnect.Close();
        }
        public void GetProductsById(int Id)
        {
            string str = $"SELECT * FROM Products WHERE ID={Id}";
            sqlConnect.Open();
            sqlConnect.Get(str);
            sqlConnect.Close();
        }
        public void PutProducts(string name,decimal price)
        {
            string str = $"INSERT INTO Products VALUES ('{name}','{price}')";
            sqlConnect.Open();
            sqlConnect.Insert(str);
            sqlConnect.Close();
        }
        public void DeleteProducts(int Id)
        {
            string str = $"DELETE Products WHERE ID={Id}";
            sqlConnect.Open();
            sqlConnect.Delete(str);
            sqlConnect.Close();
        }


    }
}

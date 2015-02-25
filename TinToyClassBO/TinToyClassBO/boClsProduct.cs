using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;

namespace TinToy
{
    public class boClsProduct
    {
        private doClsProduct doProduct;
        private bool ValidateProduct(Product _product, ref ErrorMessage _errorMessage)
        {
            if (_product.Name == "") { _errorMessage.Message += "Name "; };
            if (_product.Description == "") { _errorMessage.Message += "Description "; };
            if (_product.Price == 0) { _errorMessage.Message += "Price "; };
            if (_product.Availability == 0) { _errorMessage.Message += "Availability "; };
            if (_errorMessage.Message != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public boClsProduct()
        {
            doProduct = new doClsProduct();
        }    
        public Product GetProductByID(int ID, ref ErrorMessage _errorMessage)
        {
            Product _product = new Product();
            DataTable dt = doProduct.GetProductByID(ID);
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    _product.ID = Int32.Parse(dr["ID"].ToString());
                    _product.Name = dr["Name"].ToString();
                    _product.Description = dr["Description"].ToString();
                    if (dr["Image"] != DBNull.Value)
                    {
                        _product.Image = (byte[])dr["Image"];
                    }
                    _product.Price = Decimal.Parse(dr["Price"].ToString());
                    _product.Availability = Int32.Parse(dr["Availability"].ToString());
                }
            }
            else
            {
                _errorMessage.Message = "Product " + ID.ToString() + " does not exist.";
            }
            return _product;
        }
        public int CreateProduct(Product _product, ref ErrorMessage _errorMessage)
        {
            if (ValidateProduct(_product, ref _errorMessage))
            {
                int newProd = doProduct.CreateProduct(_product);
                if (newProd == 0)
                {
                    _errorMessage.Message += "Data Access Layer: 'CreateProduct' fails!";
                    _errorMessage.Message += _errorMessage.CheckLogFile;
                    return 0;
                }
                else
                {
                    return newProd;
                }
            }
            _errorMessage.Message += " BO: Product not validated";
            return 0;
        }
        public bool UpdateProduct(Product _product, ref ErrorMessage _errorMessage)
        {
            if (ValidateProduct(_product, ref _errorMessage))
            {
                bool success = doProduct.UpdateProduct(_product);
                if (!success)
                {
                    _errorMessage.Message += "Data Access Layer: 'UpdateProoduct' fails!";
                    _errorMessage.Message += _errorMessage.CheckLogFile;
                    return false;
                }
                else
                {
                    return true;
                }
            }
            _errorMessage.Message += " Business Layer: Product not validated";
            return false;
        }
        public bool DeactivateProduct(int Id, ref ErrorMessage _errorMessage)
        {
            if (Id != 0)
            {
                bool success = doProduct.DeactivateProduct(Id);
                if (!success)
                {
                    _errorMessage.Message += "Data Access Layer: 'DeactivateProduct' fails!";
                    _errorMessage.Message += _errorMessage.CheckLogFile;
                    return false;
                }
                else
                {
                    return true;
                }
            }
            _errorMessage.Message += " Business Layer: Invalid Product ID";
            return false;
        }    
        public DataTable SearchProduct(Product prod, ref ErrorMessage _errorMessage)
        {
            DataTable dt = doProduct.SearchProduct(prod);
            if (dt == null)
            {
                _errorMessage.Message += "Data Access Layer: 'SearchProduct' fails!";
                _errorMessage.Message += _errorMessage.CheckLogFile;
            }
            return dt;
        }
    }
}

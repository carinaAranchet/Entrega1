using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega1
{
    public class ProductoVendido
    {
        protected int id;
        protected int prodId;
        protected int stock;
        protected int saleId;

        public ProductoVendido(int id, int prodId, int stock, int saleId)
        {
            this.id = id;
            this.prodId = prodId;
            this.stock = stock;
            this.saleId = saleId;
        }

        public int getId()
        {
            return id;
        }
        public void setId(int unId)
        {
            this.id = unId;
        }
        public int getProdId()
        {
            return prodId;
        }
        public void setProdId(int unProdId)
        {
            this.prodId = unProdId;
        }

        public int getStock()
        {
            return stock;
        }
        public void setStock(int unStock)
        {
            this.id = unStock;
        }

        public int getIdVenta()
        {
            return saleId;
        }
        public void setIdVenta(int unIdVenta)
        {
            this.saleId = unIdVenta;
        }

    }
}

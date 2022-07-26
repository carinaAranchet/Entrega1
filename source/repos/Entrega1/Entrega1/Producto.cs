using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega1
{
    public class Producto
    {
        protected int id;
        protected string description;
        protected double price;
        protected double priceSoul;
        protected int stock;
        protected int usrId;

        public Producto(int id, string description, double price, string priceSoul, int stock, int usrId)
        {
            id = id;
            description = description;
            price = price;
            priceSoul = priceSoul;
            stock = stock;
            usrId = usrId;
        }

        public Producto()
        {
            id = 0;
            description = string.Empty;
            price = 0;
            priceSoul = 0;
            stock = 0;
            usrId = 0;
        }

        public int getId()
        {
            return id;
        }
        public void setId(int unId)
        {
            this.id = unId;
        }

        public string getDescripcion()
        {
            return description;
        }

        public void setDescripcion( string unaDesc)
        {
            this.description = unaDesc;
        }

        public double getCosto()
        {
            return price;
        }

        public void setCosto( double unCosto)
        {
            this.price = unCosto;
        }

        public double getCostoVenta()
        {
            return priceSoul;
        }

        public void setCostoVenta(double unCostoVe)
        {
            this.priceSoul = unCostoVe;
        }
        public int getStock()
        {
            return stock;
        }
        public void setStock(int unStock)
        {
            this.id = unStock;
        }

        public int getIdUsr()
        {
            return usrId;
        }
        public void setIdUsr(int unIdUser)
        {
            this.usrId = unIdUser;
        }

    }

      
}

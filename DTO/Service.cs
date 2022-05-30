using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Final_Project_2022.DTO
{
    public class Service
    {
        int id;
        string servicename;
        string unit;
        float price;

        public Service() { }

        public Service(DataRow data)
        {
            Id = (int)data["id"];
            serviceName = data["ServiceName"].ToString();
            Unit = data["Unit"].ToString();
            Price = (int)data["Price"];
        }

        public bool Equals(Service servicePre)
        {
            if (servicePre == null) return false;
            if (servicePre.unit != this.unit) return false;
            if (servicePre.servicename != this.servicename) return false;
            if (servicePre.price != this.price) return false;
            return true;
        }


        public int Id { get => id; set => id = value; }
        public string serviceName { get => serviceName; set => serviceName = value; }
        public string Unit { get => Unit; set => Unit = value; }
        public int Price { get => Price; set => Price = value; }
    }
}

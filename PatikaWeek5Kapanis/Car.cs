using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek5Kapanis
{
    public class Car
    {
        public DateTime ProductionDate { get; set; }
        public int SerialNo { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Door { get; set; }

        public Car() 
        {
        ProductionDate = DateTime.Now;
        }
    }

}

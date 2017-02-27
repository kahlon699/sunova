using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sunova
{
    public class Data
    {

        public int Mileage { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }
    }


    public class MyError
    {
        public int Errorcode { get; set; }
        public string ErrorMsg { get; set; }
    }

}
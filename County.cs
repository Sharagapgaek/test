using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaone
{
    public class County
    {
        public string Name { get; set; }
        public string Form { get; set; }
        public float Square { get; set; }
        public County(string Name, string Form, float Square)
        {
            this.Name = Name;
            this.Form = Form;
            this.Square = Square;
        }
    }
}

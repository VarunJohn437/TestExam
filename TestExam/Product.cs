using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExam
{
    internal class Product
    {
        public int Id { get; set; }

        private string _name = "";

        public string Name { 
            get { return _name;}
            set { 
                if(value != null) {
                    _name = value;
                }
            }
        }

        public string Description { get; set; }

    }
}

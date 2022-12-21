using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks12._21._2022
{
    public class Book
    {
        public string Name { get; set; }
        public  static int Count { get; set; } = 0;

        public Book()
        {
            Count++;
           
        }
        
    }
    
}

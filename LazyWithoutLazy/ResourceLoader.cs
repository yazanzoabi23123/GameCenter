using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyWithoutLazy
{
    internal class ResourceLoader
    {
        private string _data;
        private string loadData()
        {
            Thread.Sleep(1000);
            return "MY_DATA";
        }
    }
}

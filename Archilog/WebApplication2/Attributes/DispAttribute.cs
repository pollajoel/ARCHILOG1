using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace WebApplication2.Attributes
{

    [AttributeUsage( AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = false)]
    public class DispAttribute:Attribute
    {
        private bool display;

        public DispAttribute(bool display)
        {
            this.display = display;
        }


        public bool Display
        {
            get
            {
                return this.display;
            }

            set
            {
                this.display = value;
            }
        }
       
        
    }
}

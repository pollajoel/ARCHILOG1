using System;
using System.Collections.Generic;
using System.Text;

namespace APILibbrary.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property , AllowMultiple = false)]
    public class NotJsonAttribute: Attribute
    {
    }
}

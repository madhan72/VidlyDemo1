using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyDemo.Models;

namespace VidlyDemo.ViewModel
{
    public class VM_RandomMovie
    {
        public Movies Movie { get; set; }
        public List<Customer> Customer { get; set; }

    }
}
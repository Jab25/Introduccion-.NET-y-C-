using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_HolaMundo
{
    [DataContract]
    public class Alumno
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
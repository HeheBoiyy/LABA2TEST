using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace LABA2TEST
{
    public class A{
        public int firstproperty { get; set; }
        public int secondproperty { get; set; }
        public A(int fs,int ss)
        {
            this.firstproperty = fs; this.secondproperty = ss;
        }
    }
    public class B
    {
        public int firstproperty { get; set; }
        public string secondproperty { get; set; }
        public B(int fs,string ss)
        {
            firstproperty = fs;
            secondproperty = ss;
        }
    }
    public class C
    {
        public int firstproperty { get; set; }
        public string secondproperty { get; set; }
        public C(int firstproperty, string secondproperty)
        {
            this.firstproperty = firstproperty;
            this.secondproperty = secondproperty;
        }
    }
    public class D
    {
        public int firstproperty { get; set; }
        public int secondproperty { get; set; }
        public D(int firstproperty, int secondproperty)
        {
            this.firstproperty = firstproperty;
            this.secondproperty = secondproperty;
        }
    }
}

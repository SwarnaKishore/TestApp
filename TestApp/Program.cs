using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
          //  var leftRotationsObject = new ArrayLeftRotation();
            //leftRotationsObject.leftRotations();

            var makingAnagrams = new MakingAnagrams();
            makingAnagrams.makeAnagram();
            //var baseClassObject = new BaseVisa();
            //BaseVisa derivedClassObject = new B2Visa();

            //baseClassObject.IsApproved();
            //derivedClassObject.IsApproved();
          
            Console.ReadLine();

        }

        //class BaseVisa
        //{
        //    public string PassportNumber = "";

        //    public bool IsApproved()
        //    {
        //        return PassportNumber.Length > 0;
        //    }
        //}

        //class B2Visa: BaseVisa
        //{
        //    public bool IsApproved()
        //    {
        //        return PassportNumber.Length > 0 
        //            && DateTime.Now > new DateTime(2016, 09, 15);
        //    }

        //    public void CheckAddress()
        //    {

        //    }
        //}
    }
}

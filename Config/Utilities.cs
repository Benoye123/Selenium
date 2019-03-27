
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.Config
{
    class Utilities
    {
         IList<bool> result = new List<bool>();
 
        public void softAssert(bool condition)
        {
            
            try
            {
                Assert.IsTrue(condition);
            }
            catch(AssertionException e)
            {
                result.Add(false);
                Console.WriteLine(e);
            }
        }

        public void assertAll()
        {
            foreach (var actualResult in result)
            {
                Console.WriteLine(actualResult);
                Assert.IsTrue(actualResult);
             

            }
        }
    }
}

using RazorPagePro.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestRazorPageProject
{
  
    public  class SumTest
    {
        [Theory]
        [InlineData(5,5,10)]
        [InlineData(10, 0, 10)]
        public void SumTwoNumber(int value1 , int value2 , int SumTwoNumber)
        {
            Sum sum = new Sum();
            var result = sum.Excute(value1, value2);

            Assert.Equal(SumTwoNumber, result);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaximumProblemUsingGenerics;

namespace MaximumProblemUsingGenerics
{
        
        public class UnitTest1
        {
            // Givens the maximum number first position.     
            
            public void GivenMaxNumber_FirstPosition()
            {
                int result = MaxNumCheck.MaximumIntegerNumber(40, 20, 30);
                int maxNumber = 40;
                Assert.AreEqual(maxNumber, result);
            }
            /// Givens the maximum number second position.

            
            public void GivenMaxNumber_SecondPosition()
            {
                int result = MaxNumCheck.MaximumIntegerNumber(10, 40, 30);
                int maxNumber = 40;
                Assert.AreEqual(maxNumber, result);
            }
            /// Givens the maximum number third position.

           
            public void GivenMaxNumber_ThirdPosition()
            {
                int result = MaxNumCheck.MaximumIntegerNumber(10, 20, 40);
                int maxNumber = 40;
                Assert.AreEqual(maxNumber, result);
            }
        }
}

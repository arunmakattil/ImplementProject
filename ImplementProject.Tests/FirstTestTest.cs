using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementProject.Tests
{
    public class FirstTestTest
    {
        [Fact]
        public void FirstTest_SendMessage_ReturnString()
        {
            //Arrange
            FirstTest pingMsg = new FirstTest();
            //Act
            string ressult = FirstTest.SendMessage();
            //Assert

        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console.Test
{
    [TestFixture]
    public class SpecialClassTest
    {
        [Test]
        public void IsPalindrome_WithUserString_ReturnsFlag()
        {
            //arange
            var instance = new SpecialClass();

            //act
            var result = instance.IsPalindrome("rada    r");

            //assert
            Assert.AreEqual(true, result);
        }
    }
}

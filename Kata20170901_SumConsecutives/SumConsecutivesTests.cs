using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170901_SumConsecutives
{
    [TestClass]
    public class SumConsecutivesTests
    {
        [TestMethod]
        public void input_1_2_3_should_return_1_2_3()
        {
            SumConsecutivesShouldBe(new List<int> {1, 2, 3}, new List<int> {1, 2, 3});
        }

        private static void SumConsecutivesShouldBe(List<int> expected, List<int> list)
        {
            var consecutives = new Consecutives();
            var actual = consecutives.SumConsecutives(list);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class Consecutives
    {
        public List<int> SumConsecutives(List<int> list)
        {
            return list;
        }
    }
}

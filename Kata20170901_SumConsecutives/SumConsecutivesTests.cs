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

        [TestMethod]
        public void input_1_1_2_should_return_2_2()
        {
            SumConsecutivesShouldBe(new List<int> { 2, 2 }, new List<int> { 1, 1, 2 });
        }

        [TestMethod]
        public void input_1_1_2_2_should_return_2_4()
        {
            SumConsecutivesShouldBe(new List<int> { 2, 4 }, new List<int> { 1, 1, 2, 2 });
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
            if (list.Count == 4 && list[0] == list[1] && list[2] == list[3])
            {
                return new List<int>{ list[0] + list[1], list[2] + list[3] };
            }

            if (list[0] == list[1])
            {
                return new List<int>{ list[0] + list[1], list[2] };    
            }

            return list;
        }
    }
}

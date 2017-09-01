using System;
using System.CodeDom;
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
            SumConsecutivesShouldBe(new List<int> { 1, 2, 3 }, new List<int> { 1, 2, 3 });
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

        [TestMethod]
        public void input_1_1_1_2_should_return_3_2()
        {
            SumConsecutivesShouldBe(new List<int> { 3, 2 }, new List<int> { 1, 1, 1, 2 });
        }

        [TestMethod]
        public void input_1_1_1_0_2_2_should_return_3_0_4()
        {
            SumConsecutivesShouldBe(new List<int> { 3, 0, 4 }, new List<int> { 1, 1, 1, 0, 2, 2 });
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
            var result = new List<int>();
            var sum = 0;
            var lastItem = list[0];
            foreach (var i in list)
            {
                if (lastItem == i)
                {
                    sum += lastItem;
                }
                else
                {
                    result.Add(sum);
                    sum = lastItem = i;
                }
            }

            result.Add(sum);

            return result;
        }
    }
}

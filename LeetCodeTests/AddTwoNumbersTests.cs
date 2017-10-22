using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using static LeetCode.AddTwoNumbersSolution;

namespace LeetCode.Tests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class AddTwoNumbersTests
    {
        [TestMethod]
        public void Add_Two_Equal_Length_Arrays()
        {
            var l1 = new ListNode(2) { next = new ListNode(4) { next = new ListNode(3) } };
            var l2 = new ListNode(5) { next = new ListNode(5) { next = new ListNode(4) } };
            var expected = new ListNode(7) { next = new ListNode(9) { next = new ListNode(7) } };
            var sut = new AddTwoNumbersSolution();
            var actual = sut.AddTwoNumbers(l1, l2);
            LinkedListTestHelper(expected, actual);
        }

        [TestMethod]
        public void Add_Creates_Carry()
        {
            var l1 = new ListNode(2) { next = new ListNode(4) { next = new ListNode(3) } };
            var l2 = new ListNode(5) { next = new ListNode(6) { next = new ListNode(4) } };
            var expected = new ListNode(7) { next = new ListNode(0) { next = new ListNode(8) } };
            var sut = new AddTwoNumbersSolution();
            var actual = sut.AddTwoNumbers(l1, l2);
            LinkedListTestHelper(expected, actual);
        }

        [TestMethod]
        public void Add_Skewed_Length_Arrays()
        {
            var l1 = new ListNode(1) { next = new ListNode(9) };
            var l2 = new ListNode(5);
            var expected = new ListNode(6) { next = new ListNode(9) };
            var sut = new AddTwoNumbersSolution();
            var actual = sut.AddTwoNumbers(l1, l2);
            LinkedListTestHelper(expected, actual);
        }

        [TestMethod]
        public void Add_Creates_New_Node()
        {
            var l1 = new ListNode(5);
            var l2 = new ListNode(5);
            var expected = new ListNode(0) { next = new ListNode(1) };
            var sut = new AddTwoNumbersSolution();
            var actual = sut.AddTwoNumbers(l1, l2);
            LinkedListTestHelper(expected, actual);
        }

        [TestMethod]
        public void Add_Multiple_Carryover()
        {
            var l1 = new ListNode(1);
            var l2 = new ListNode(9) { next = new ListNode(9) };
            var expected = new ListNode(0) { next = new ListNode(0) { next = new ListNode(1) } };
            var sut = new AddTwoNumbersSolution();
            var actual = sut.AddTwoNumbers(l1, l2);
            LinkedListTestHelper(expected, actual);
        }

        private void LinkedListTestHelper(ListNode expected, ListNode actual)
        {
            if (expected != null && actual != null)
            {
                LinkedListTestHelper(expected?.next, actual?.next);
            }

            Assert.AreEqual(expected?.val, actual?.val);
        }
    }
}

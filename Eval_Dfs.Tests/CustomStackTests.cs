using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Eval_Dfs.Tests
{
    [TestClass]
    public class CustomStackTests
    {
        [TestMethod]
        public void Count_EmptyStack_ReturnsZero()
        {
            
            var stack = new CustomStack();

           
            var count = stack.Count();

           
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void Push_SingleElement_IncreasesCount()
        {
        
            var stack = new CustomStack();

        
            stack.Push(10);
            var count = stack.Count();

          
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void Push_MultipleElements_IncreasesCountCorrectly()
        {
          
            var stack = new CustomStack();

           
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            var count = stack.Count();

       
            Assert.AreEqual(3, count);
        }

        [TestMethod]
        public void Pop_SingleElement_ReturnsElementAndDecreasesCount()
        {
       
            var stack = new CustomStack();
            stack.Push(42);

        
            var popped = stack.Pop();
            var count = stack.Count();

        
            Assert.AreEqual(42, popped);
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void Pop_MultipleElements_ReturnsCorrectOrder()
        {

            var stack = new CustomStack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

  
            var popped1 = stack.Pop();
            var popped2 = stack.Pop();
            var popped3 = stack.Pop();

    
            Assert.AreEqual(30, popped1);
            Assert.AreEqual(20, popped2);
            Assert.AreEqual(10, popped3);
        }

        [TestMethod]
        [ExpectedException(typeof(CustomStack.StackCantBeEmptyException))]
        public void Pop_EmptyStack_ThrowsException()
        {
       
            var stack = new CustomStack();

         
            stack.Pop(); 
        }
    }
}

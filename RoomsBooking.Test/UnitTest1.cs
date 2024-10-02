using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoomsBookings;

namespace RoomsBooking.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_BookRooms_3A_5C()
        {
            var Result = BooksRooms.Solution(3, 5);
            Assert.AreEqual(2, Result.Count);
            Assert.AreEqual("Room 1: Adult = 2, Children = 2", Result[0]);
            Assert.AreEqual("Room 2: Adult = 1, Children = 3", Result[1]);
        }

        [TestMethod]
        public void Test_BookRooms_4A_5C()
        {
            var Result = BooksRooms.Solution(4, 5);
            Assert.AreEqual(3, Result.Count);
            Assert.AreEqual("Room 1: Adult = 2, Children = 2", Result[0]);
            Assert.AreEqual("Room 2: Adult = 2, Children = 1", Result[1]);
            Assert.AreEqual("Room 3: Adult = 0, Children = 2", Result[2]);
        }

        [TestMethod]
        public void Test_BookRooms_4A_6C()
        {
            var Result = BooksRooms.Solution(4, 6);
            Assert.AreEqual(4, Result.Count);
            Assert.AreEqual("Room 1: Adult = 2, Children = 2", Result[0]);
            Assert.AreEqual("Room 2: Adult = 2, Children = 2", Result[1]);
            Assert.AreEqual("Room 3: Adult = 0, Children = 2", Result[2]);
            Assert.AreEqual("Room 4: Adult = 0, Children = 0", Result[3]);
        }

        [TestMethod]
        public void Test_BookRooms_3A_8C()
        {
            var Result = BooksRooms.Solution(3, 8);
            Assert.AreEqual(4, Result.Count);
            Assert.AreEqual("Room 1: Adult = 2, Children = 2", Result[0]);
            Assert.AreEqual("Room 2: Adult = 1, Children = 1", Result[1]);
            Assert.AreEqual("Room 3: Adult = 0, Children = 3", Result[2]);
            Assert.AreEqual("Room 4: Adult = 0, Children = 0", Result[3]);
        }

        [TestMethod]
        public void Test_BookRooms_1A_0C()
        {
            var Result = BooksRooms.Solution(1, 0);
            Assert.AreEqual(1, Result.Count);
            Assert.AreEqual("Room 1: Adult = 1, Children = 0", Result[0]);
        }

        [TestMethod]
        public void Test_BookRooms_1A_1C()
        {
            var Result = BooksRooms.Solution(1, 1);
            Assert.AreEqual(1, Result.Count);
            Assert.AreEqual("Room 1: Adult = 1, Children = 1", Result[0]);
        }

        [TestMethod]
        public void Test_BookRooms_4A_0C()
        {
            var Result = BooksRooms.Solution(4, 0);
            Assert.AreEqual(2, Result.Count);
            Assert.AreEqual("Room 1: Adult = 2, Children = 0", Result[0]);
            Assert.AreEqual("Room 2: Adult = 2, Children = 0", Result[1]);
        }

        [TestMethod]
        public void Test_BookRooms_0A_0C()
        {
            var Result = BooksRooms.Solution(0, 0);
            Assert.AreEqual(0, Result.Count);
        }

        [TestMethod]
        public void Test_BookRooms_10A_10C()
        {
            var Result = BooksRooms.Solution(10, 10);
            Assert.AreEqual(1, Result.Count);
            Assert.AreEqual("Guest Limited..!!", Result[0]);
        }

        [TestMethod]
        public void Test_BookRooms_2A_8C()
        {
            var Result = BooksRooms.Solution(2, 8);
            Assert.AreEqual(4, Result.Count);
            Assert.AreEqual("Room 1: Adult = 2, Children = 2", Result[0]);
            Assert.AreEqual("Room 2: Adult = 0, Children = 2", Result[1]);
            Assert.AreEqual("Room 3: Adult = 0, Children = 0", Result[2]);
            Assert.AreEqual("Room 4: Adult = 0, Children = 0", Result[3]);
        }
    }
}

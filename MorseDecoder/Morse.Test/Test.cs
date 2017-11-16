using Microsoft.VisualStudio.TestTools.UnitTesting;
using Morse.Library;
using System;

namespace Morse.Test
{
    [TestClass]
    public class UnitTest1
    {
        private MorseDecoder morse = new MorseDecoder();

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void TestExceptionInvalidCharacter()
        {
            morse.getMorseFromLetter(".");
        }

        [TestMethod]
        public void TestLetterToMorseCode()
        {
            string codeIst = morse.getMorseFromLetter("A");
            string codeSoll = ".-";

            Assert.AreEqual(codeIst, codeSoll);
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void TestFilePaths()
        {
            Program.readFromFile(null, null);
        }

        [TestMethod]
        public void TestListFilling()
        {
            int listLengthSoll = 36;
            int listLengthIst = this.morse.list.Count;

            Assert.AreEqual(listLengthSoll, listLengthIst);
        }

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod]
        public void TestNullLetter()
        {
            Letter letter = new Letter("Ü", null);
            this.morse.list.Add(letter);

            string help = this.morse.getMorseFromLetter("Ü");
        }
    }
}

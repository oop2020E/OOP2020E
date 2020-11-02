using Microsoft.VisualStudio.TestTools.UnitTesting;
using KG07Exercises;
using System;
using System.Collections.Generic;
using System.Text;

namespace KG07Exercises.Tests
{
    [TestClass()]
    public class ExerciseClassTests
    {
        [TestMethod]
        public void JoinAllStringsTest_abcWithUnderscoreFunction_a_b_c()
        {
            List<string> strings = new List<string>() { "a", "b", "c" };
            ExerciseClass c = new ExerciseClass();
            string expected = "a_b_c";
            string joinfunction(string s1, string s2) => $"{s1}_{s2}";

            var result = c.JoinAllStrings(strings, joinfunction);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void JoinAllStringsTest_joinEmptyString_ThrowsException()
        {
            List<string> emptyList = new List<string>();
            ExerciseClass c = new ExerciseClass();

            Assert.ThrowsException<ArgumentException>(() =>
            {
                c.JoinAllStrings(emptyList, (s1, s2) => s1 + s2);
            });
        }

        [TestMethod]
        public void TwiceTest_ExampleFromExercise_WorksAsSpecifiedInExercise()
        {
            ExerciseClass c = new ExerciseClass();
            int inputFunction(int x) => x * 2;
            int expected = 4;
            int inputvalue = 1;

            int result = c.Twice(inputFunction, inputvalue);

            Assert.AreEqual(expected, result);
        }
    }
}
using Intersection.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intersection.MS.Testing
{
    [TestClass]
    public class PositiveCase
    {
        #region Default Declaractino

        string[] strArray;
        string expected;

        #endregion Default Declaraction

        #region Test Initialize
        /// <summary>
        /// Initialize Value for object and variable
        /// </summary>
        [TestInitialize]
        public void PositiveInit()
        {
            strArray = new string[] { "1, 3, 9, 10, 17, 18", "1, 4, 9, 10" };
            expected = "1,9,10";
        }

        #endregion Test Initialize 

        #region Test Method
        /// <summary>
        /// Test Business Method or Function using Test Method
        /// </summary>
        [TestMethod]
        public void PositiveTesting()
        {
            // Act
            var arrayInterSection = new ArrayInterSection();
            string actual = arrayInterSection.GetInterSection(strArray);

            // Assert
            Assert.IsTrue(expected.Equals(actual));
        }

        #endregion Test Method

        #region Clear Up
        /// <summary>
        /// Clean uses object during testcase
        /// </summary>
        [TestCleanup]
        public void ClearUpObject()
        {
            strArray = null;
            expected = string.Empty;
        }
        #endregion Clear Up
    }
}

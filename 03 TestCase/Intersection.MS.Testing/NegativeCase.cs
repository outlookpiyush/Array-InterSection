using Intersection.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intersection.MS.Testing
{
    [TestClass]
    public class NegativeCase
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
        public void NegativeInit()
        {
            strArray = new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" };
            expected = "1,4,12";
        }

        #endregion Test Initialize 

        #region Test Method
        /// <summary>
        /// Test Business Method or Function using Test Method
        /// </summary>
        [TestMethod]
        public void NegativeTesting()
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

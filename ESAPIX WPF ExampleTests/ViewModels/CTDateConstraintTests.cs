using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESAPX_StarterUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESAPX_StarterUI.ViewModels.Tests
{
    [TestClass()]
    public class CTDateConstraintTests
    {
        [TestMethod()]
        public void CTDateFailCorrectly()
        {
            //Arange
            var ctDate = DateTime.Now.AddDays(-61);

            // Act
            var actual = new CTDateConstraint().ConstraintCTDate(ctDate).ResultType;

            //Assert
            
            Assert.AreEqual(expected, actual);
        }
        public void CTDatePassCorrectly()
        {
            //Arange





            Assert.Fail();
        }
    }
}
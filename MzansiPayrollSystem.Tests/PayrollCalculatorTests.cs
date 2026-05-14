using Microsoft.VisualStudio.TestTools.UnitTesting;
using MzansiPayrollSystem;

namespace MzansiPayrollSystem.Tests
{
    [TestClass]
    public class PayrollCalculatorTests
    {
        private PayrollCalculator _calculator;
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void SetUp()
        {
            _calculator = new PayrollCalculator();
        }

        // ════════════════════════════════════════════════════════
        //  UNIT TESTS
        // ════════════════════════════════════════════════════════

        [TestMethod]
        [TestCategory("Unit Test")]
        public void GrossPay_ShouldReturnR38000_WhenHoursWorkedIs40()
        {
            // Arrange
            double hours = 40;
            double expected = 38000.00;

            // Act
            double actual = _calculator.CalculateGrossPay(hours);

            // Log
            TestContext.WriteLine("=== Gross Pay Unit Test ===");
            TestContext.WriteLine($"Input Hours:    {hours}");
            TestContext.WriteLine($"Expected: R{expected:N2}");
            TestContext.WriteLine($"Actual:   R{actual:N2}");

            // Assert
            Assert.AreEqual(expected, actual, 0.01,
                "Gross Pay calculation is incorrect.");
        }

        [TestMethod]
        [TestCategory("Unit Test")]
        public void UIF_ShouldReturnR380_WhenGrossPayIsR38000()
        {
            // Arrange
            double grossPay = 38000.00;
            double expected = 380.00;

            // Act
            double actual = _calculator.CalculateUIF(grossPay);

            // Log
            TestContext.WriteLine("=== UIF Unit Test ===");
            TestContext.WriteLine($"Gross Pay:       R{grossPay:N2}");
            TestContext.WriteLine($"Expected UIF 1%: R{expected:N2}");
            TestContext.WriteLine($"Actual UIF:      R{actual:N2}");

            // Assert
            Assert.AreEqual(expected, actual, 0.01,
                "UIF calculation is incorrect.");
        }

        [TestMethod]
        [TestCategory("Unit Test")]
        public void MembershipFee_ShouldReturnR4940_WhenGrossPayIsR38000()
        {
            // Arrange
            double grossPay = 38000.00;
            double expected = 4940.00;

            // Act
            double actual = _calculator.CalculateMembershipFee(grossPay);

            // Log
            TestContext.WriteLine("=== Membership Fee Unit Test ===");
            TestContext.WriteLine($"Gross Pay:                  R{grossPay:N2}");
            TestContext.WriteLine($"Expected Membership (13%):  R{expected:N2}");
            TestContext.WriteLine($"Actual Membership:          R{actual:N2}");

            // Assert
            Assert.AreEqual(expected, actual, 0.01,
                "Membership Fee calculation is incorrect.");
        }

        [TestMethod]
        [TestCategory("Unit Test")]
        public void PAYE_ShouldReturnR8407_50_WhenGrossPayIsR38000AndDependentsIs2()
        {
            // Arrange
            // Formula: (38000 - (38000 * 0.0575 * 2)) * 0.25
            //        = (38000 - 4370) * 0.25
            //        = 33630 * 0.25 = 8407.50
            double grossPay = 38000.00;
            int deps = 2;
            double expected = 8407.50;

            // Act
            double actual = _calculator.CalculatePAYE(grossPay, deps);

            // Log
            TestContext.WriteLine("=== PAYE Unit Test ===");
            TestContext.WriteLine($"Gross Pay:      R{grossPay:N2}");
            TestContext.WriteLine($"Dependents:     {deps}");
            TestContext.WriteLine($"Expected PAYE:  R{expected:N2}");
            TestContext.WriteLine($"Actual PAYE:    R{actual:N2}");

            // Assert
            Assert.AreEqual(expected, actual, 0.01,
                "PAYE calculation is incorrect.");
        }

        [TestMethod]
        [TestCategory("Unit Test")]
        public void NetPay_ShouldReturnR24272_50_WhenAllDeductionsProvided()
        {
            // Arrange
            double grossPay = 38000.00;
            double uif = 380.00;
            double paye = 8407.50;
            double membership = 4940.00;
            double expected = 24272.50;

            // Act
            double actual = _calculator.CalculateNetPay(grossPay, uif, paye, membership);

            // Log
            TestContext.WriteLine("=== Net Pay Unit Test ===");
            TestContext.WriteLine($"Gross Pay:        R{grossPay:N2}");
            TestContext.WriteLine($"UIF:              R{uif:N2}");
            TestContext.WriteLine($"PAYE:             R{paye:N2}");
            TestContext.WriteLine($"Membership Fee:   R{membership:N2}");
            TestContext.WriteLine($"Expected Net Pay: R{expected:N2}");
            TestContext.WriteLine($"Actual Net Pay:   R{actual:N2}");

            // Assert
            Assert.AreEqual(expected, actual, 0.01,
                "Net Pay calculation is incorrect.");
        }

        // ════════════════════════════════════════════════════════
        //  INTEGRATION TEST
        // ════════════════════════════════════════════════════════

        [TestMethod]
        [TestCategory("Integration Test")]
        public void NetPay_ShouldReturnR24272_50_WhenAllDeductionsAreAppliedEndToEnd()
        {
            // Simulates the full payroll flow: input → calculation → output
            // Arrange
            double hours = 40;
            int deps = 2;

            // Act — chain every method the way the form does
            double grossPay = _calculator.CalculateGrossPay(hours);
            double uif = _calculator.CalculateUIF(grossPay);
            double membershipFee = _calculator.CalculateMembershipFee(grossPay);
            double paye = _calculator.CalculatePAYE(grossPay, deps);
            double totalDeductions = _calculator.CalculateTotalDeductions(uif, paye, membershipFee);
            double netPay = _calculator.CalculateNetPay(grossPay, uif, paye, membershipFee);

            double expectedNet = 24272.50;
            double expectedTotal = 13727.50;

            // Log
            TestContext.WriteLine("=== End-to-End Integration Test ===");
            TestContext.WriteLine($"Hours Worked:     {hours}");
            TestContext.WriteLine($"Dependents:       {deps}");
            TestContext.WriteLine($"Gross Pay:        R{grossPay:N2}");
            TestContext.WriteLine($"UIF:              R{uif:N2}");
            TestContext.WriteLine($"Membership Fee:   R{membershipFee:N2}");
            TestContext.WriteLine($"PAYE:             R{paye:N2}");
            TestContext.WriteLine($"Total Deductions: R{totalDeductions:N2}");
            TestContext.WriteLine($"Net Pay:          R{netPay:N2}");

            // Assert
            Assert.AreEqual(expectedNet, netPay, 0.01,
                "Integration: Net Pay is incorrect.");
            Assert.AreEqual(expectedTotal, totalDeductions, 0.01,
                "Integration: Total Deductions is incorrect.");
        }
    }
}
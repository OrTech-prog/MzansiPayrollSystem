namespace MzansiPayrollSystem
{
    public class PayrollCalculator
    {
        public const double HourlyRate = 950.00;

        public double CalculateGrossPay(double hoursWorked)
        {
            return hoursWorked * HourlyRate;
        }

        public double CalculateUIF(double grossPay)
        {
            return grossPay * 0.01;
        }

        public double CalculateMembershipFee(double grossPay)
        {
            return grossPay * 0.13;
        }

        public double CalculatePAYE(double grossPay, int numberOfDependents)
        {
            return (grossPay - (grossPay * 0.0575 * numberOfDependents)) * 0.25;
        }

        public double CalculateTotalDeductions(double uif, double paye, double membershipFee)
        {
            return uif + paye + membershipFee;
        }

        public double CalculateNetPay(double grossPay, double uif, double paye, double membershipFee)
        {
            return grossPay - uif - paye - membershipFee;
        }
    }
}
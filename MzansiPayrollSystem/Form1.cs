using System;
using System.Windows.Forms;

namespace MzansiPayrollSystem
{
    public partial class Form1 : Form
    {
        private readonly PayrollCalculator _calculator = new PayrollCalculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // ── Validate Contractor Name ─────────────────────────────────────────
            if (string.IsNullOrWhiteSpace(txtContractorName.Text))
            {
                MessageBox.Show("Contractor name cannot be empty.",
                    "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContractorName.Focus();
                return;
            }

            // ── Validate Hours Worked ────────────────────────────────────────────
            if (!double.TryParse(txtHoursWorked.Text, out double hours))
            {
                MessageBox.Show("Hours worked must be a valid number.",
                    "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoursWorked.Focus();
                return;
            }
            if (hours < 0)
            {
                MessageBox.Show("Hours worked cannot be negative.",
                    "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoursWorked.Focus();
                return;
            }

            // ── Validate Dependents ──────────────────────────────────────────────
            if (!int.TryParse(txtDependents.Text, out int dependents))
            {
                MessageBox.Show("Number of dependents must be a whole number.",
                    "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDependents.Focus();
                return;
            }
            if (dependents < 0)
            {
                MessageBox.Show("Number of dependents cannot be negative.",
                    "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDependents.Focus();
                return;
            }
            if (dependents > 10)
            {
                MessageBox.Show("Number of dependents cannot exceed 10.",
                    "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDependents.Focus();
                return;
            }

            // ── Calculations ─────────────────────────────────────────────────────
            double grossPay = _calculator.CalculateGrossPay(hours);
            double uif = _calculator.CalculateUIF(grossPay);
            double membershipFee = _calculator.CalculateMembershipFee(grossPay);
            double paye = _calculator.CalculatePAYE(grossPay, dependents);
            double totalDeductions = _calculator.CalculateTotalDeductions(uif, paye, membershipFee);
            double netPay = _calculator.CalculateNetPay(grossPay, uif, paye, membershipFee);

            // ── Display Results ──────────────────────────────────────────────────
            txtGrossPay.Text = $"R{grossPay:N2}";
            txtPAYE.Text = $"R{paye:N2}";
            txtUIF.Text = $"R{uif:N2}";
            txtMembership.Text = $"R{membershipFee:N2}";
            txtTotalDeductions.Text = $"R{totalDeductions:N2}";
            txtNetPay.Text = $"R{netPay:N2}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear input fields
            txtContractorName.Clear();
            txtHoursWorked.Clear();
            txtDependents.Clear();

            // Clear output fields
            txtGrossPay.Clear();
            txtPAYE.Clear();
            txtUIF.Clear();
            txtMembership.Clear();
            txtTotalDeductions.Clear();
            txtNetPay.Clear();

            txtContractorName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
namespace MzansiPayrollSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblContractorName = new System.Windows.Forms.Label();
            this.txtContractorName = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.lblDependents = new System.Windows.Forms.Label();
            this.txtDependents = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelDivider = new System.Windows.Forms.Panel();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.lblPAYE = new System.Windows.Forms.Label();
            this.txtPAYE = new System.Windows.Forms.TextBox();
            this.lblUIF = new System.Windows.Forms.Label();
            this.txtUIF = new System.Windows.Forms.TextBox();
            this.lblMembership = new System.Windows.Forms.Label();
            this.txtMembership = new System.Windows.Forms.TextBox();
            this.lblTotalDeductions = new System.Windows.Forms.Label();
            this.txtTotalDeductions = new System.Windows.Forms.TextBox();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // ── FORM ──────────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 400);
            this.BackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.Text = "Mzansi Tech Contractors Payroll System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);

            // ── TITLE LABEL ──────────────────────────────────────────────────────
            this.lblTitle.Text = "Mzansi Tech Contractors";
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Size = new System.Drawing.Size(760, 62);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(8, 18, 38);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── DIVIDER LINE ─────────────────────────────────────────────────────
            this.panelDivider.Location = new System.Drawing.Point(375, 67);
            this.panelDivider.Size = new System.Drawing.Size(2, 310);
            this.panelDivider.BackColor = System.Drawing.Color.FromArgb(0, 120, 180);

            // ── LEFT SIDE: INPUTS ────────────────────────────────────────────────
            System.Drawing.Font inputLabelFont = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font inputBoxFont = new System.Drawing.Font("Segoe UI", 10F);

            this.lblContractorName.Text = "Contractor Name";
            this.lblContractorName.Location = new System.Drawing.Point(25, 78);
            this.lblContractorName.Size = new System.Drawing.Size(160, 22);
            this.lblContractorName.ForeColor = System.Drawing.Color.White;
            this.lblContractorName.Font = inputLabelFont;

            this.txtContractorName.Location = new System.Drawing.Point(25, 100);
            this.txtContractorName.Size = new System.Drawing.Size(335, 28);
            this.txtContractorName.Font = inputBoxFont;

            this.lblHoursWorked.Text = "Hours Worked";
            this.lblHoursWorked.Location = new System.Drawing.Point(25, 145);
            this.lblHoursWorked.Size = new System.Drawing.Size(160, 22);
            this.lblHoursWorked.ForeColor = System.Drawing.Color.White;
            this.lblHoursWorked.Font = inputLabelFont;

            this.txtHoursWorked.Location = new System.Drawing.Point(25, 167);
            this.txtHoursWorked.Size = new System.Drawing.Size(335, 28);
            this.txtHoursWorked.Font = inputBoxFont;

            this.lblDependents.Text = "Number of Dependents";
            this.lblDependents.Location = new System.Drawing.Point(25, 212);
            this.lblDependents.Size = new System.Drawing.Size(200, 22);
            this.lblDependents.ForeColor = System.Drawing.Color.White;
            this.lblDependents.Font = inputLabelFont;

            this.txtDependents.Location = new System.Drawing.Point(25, 234);
            this.txtDependents.Size = new System.Drawing.Size(335, 28);
            this.txtDependents.Font = inputBoxFont;

            // ── BUTTONS ──────────────────────────────────────────────────────────
            System.Drawing.Font btnFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.btnCalculate.Text = "Calculate Net Pay";
            this.btnCalculate.Location = new System.Drawing.Point(25, 295);
            this.btnCalculate.Size = new System.Drawing.Size(145, 36);
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(0, 102, 153);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Font = btnFont;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            this.btnReset.Text = "Reset";
            this.btnReset.Location = new System.Drawing.Point(180, 295);
            this.btnReset.Size = new System.Drawing.Size(85, 36);
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(30, 110, 60);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Font = btnFont;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            this.btnExit.Text = "Exit";
            this.btnExit.Location = new System.Drawing.Point(275, 295);
            this.btnExit.Size = new System.Drawing.Size(85, 36);
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(153, 30, 30);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Font = btnFont;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // ── RIGHT SIDE: OUTPUTS ──────────────────────────────────────────────
            System.Drawing.Color outputBg = System.Drawing.Color.FromArgb(255, 190, 190);
            System.Drawing.Font outputFont = new System.Drawing.Font("Segoe UI", 10F);
            int lblX = 390;
            int txtX = 565;
            int txtW = 180;

            // Gross Pay
            this.lblGrossPay.Text = "Gross Pay:";
            this.lblGrossPay.Location = new System.Drawing.Point(lblX, 82);
            this.lblGrossPay.Size = new System.Drawing.Size(165, 22);
            this.lblGrossPay.ForeColor = System.Drawing.Color.White;
            this.lblGrossPay.Font = outputFont;

            this.txtGrossPay.Location = new System.Drawing.Point(txtX, 79);
            this.txtGrossPay.Size = new System.Drawing.Size(txtW, 28);
            this.txtGrossPay.ReadOnly = true;
            this.txtGrossPay.BackColor = outputBg;
            this.txtGrossPay.Font = outputFont;
            this.txtGrossPay.TabStop = false;

            // PAYE
            this.lblPAYE.Text = "PAYE Deductions:";
            this.lblPAYE.Location = new System.Drawing.Point(lblX, 122);
            this.lblPAYE.Size = new System.Drawing.Size(165, 22);
            this.lblPAYE.ForeColor = System.Drawing.Color.White;
            this.lblPAYE.Font = outputFont;

            this.txtPAYE.Location = new System.Drawing.Point(txtX, 119);
            this.txtPAYE.Size = new System.Drawing.Size(txtW, 28);
            this.txtPAYE.ReadOnly = true;
            this.txtPAYE.BackColor = outputBg;
            this.txtPAYE.Font = outputFont;
            this.txtPAYE.TabStop = false;

            // UIF
            this.lblUIF.Text = "UIF Deduction:";
            this.lblUIF.Location = new System.Drawing.Point(lblX, 162);
            this.lblUIF.Size = new System.Drawing.Size(165, 22);
            this.lblUIF.ForeColor = System.Drawing.Color.White;
            this.lblUIF.Font = outputFont;

            this.txtUIF.Location = new System.Drawing.Point(txtX, 159);
            this.txtUIF.Size = new System.Drawing.Size(txtW, 28);
            this.txtUIF.ReadOnly = true;
            this.txtUIF.BackColor = outputBg;
            this.txtUIF.Font = outputFont;
            this.txtUIF.TabStop = false;

            // Membership Fee
            this.lblMembership.Text = "Membership Fee:";
            this.lblMembership.Location = new System.Drawing.Point(lblX, 202);
            this.lblMembership.Size = new System.Drawing.Size(165, 22);
            this.lblMembership.ForeColor = System.Drawing.Color.White;
            this.lblMembership.Font = outputFont;

            this.txtMembership.Location = new System.Drawing.Point(txtX, 199);
            this.txtMembership.Size = new System.Drawing.Size(txtW, 28);
            this.txtMembership.ReadOnly = true;
            this.txtMembership.BackColor = outputBg;
            this.txtMembership.Font = outputFont;
            this.txtMembership.TabStop = false;

            // Total Deductions
            this.lblTotalDeductions.Text = "Total Deductions:";
            this.lblTotalDeductions.Location = new System.Drawing.Point(lblX, 242);
            this.lblTotalDeductions.Size = new System.Drawing.Size(165, 22);
            this.lblTotalDeductions.ForeColor = System.Drawing.Color.White;
            this.lblTotalDeductions.Font = outputFont;

            this.txtTotalDeductions.Location = new System.Drawing.Point(txtX, 239);
            this.txtTotalDeductions.Size = new System.Drawing.Size(txtW, 28);
            this.txtTotalDeductions.ReadOnly = true;
            this.txtTotalDeductions.BackColor = outputBg;
            this.txtTotalDeductions.Font = outputFont;
            this.txtTotalDeductions.TabStop = false;

            // Net Pay
            this.lblNetPay.Text = "Net Pay:";
            this.lblNetPay.Location = new System.Drawing.Point(lblX, 282);
            this.lblNetPay.Size = new System.Drawing.Size(165, 22);
            this.lblNetPay.ForeColor = System.Drawing.Color.White;
            this.lblNetPay.Font = outputFont;

            this.txtNetPay.Location = new System.Drawing.Point(txtX, 279);
            this.txtNetPay.Size = new System.Drawing.Size(txtW, 28);
            this.txtNetPay.ReadOnly = true;
            this.txtNetPay.BackColor = outputBg;
            this.txtNetPay.Font = outputFont;
            this.txtNetPay.TabStop = false;

            // ── ADD ALL CONTROLS ─────────────────────────────────────────────────
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle,
                this.panelDivider,
                this.lblContractorName,  this.txtContractorName,
                this.lblHoursWorked,     this.txtHoursWorked,
                this.lblDependents,      this.txtDependents,
                this.btnCalculate,       this.btnReset,           this.btnExit,
                this.lblGrossPay,        this.txtGrossPay,
                this.lblPAYE,            this.txtPAYE,
                this.lblUIF,             this.txtUIF,
                this.lblMembership,      this.txtMembership,
                this.lblTotalDeductions, this.txtTotalDeductions,
                this.lblNetPay,          this.txtNetPay
            });

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ── CONTROL DECLARATIONS ─────────────────────────────────────────────────
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblContractorName;
        private System.Windows.Forms.TextBox txtContractorName;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label lblDependents;
        private System.Windows.Forms.TextBox txtDependents;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelDivider;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.Label lblPAYE;
        private System.Windows.Forms.TextBox txtPAYE;
        private System.Windows.Forms.Label lblUIF;
        private System.Windows.Forms.TextBox txtUIF;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.TextBox txtMembership;
        private System.Windows.Forms.Label lblTotalDeductions;
        private System.Windows.Forms.TextBox txtTotalDeductions;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.TextBox txtNetPay;
    }
}
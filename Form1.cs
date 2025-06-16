using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BankingApp
{
    // Class to store transaction details
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public decimal BalanceAfter { get; set; }

        public override string ToString()
        {
            return $"{Date:yyyy-MM-dd HH:mm:ss}: {Type} ${Amount:F2}, Balance: ${BalanceAfter:F2}";
        }
    }

    public partial class Form1 : Form
    {
        private readonly string validUsername = "user1";
        private readonly string validPassword = "Atm2025@ind";
        private string currentPin = "101204"; // Default PIN
        private bool isLoggedIn = false;
        private decimal balance = 1000m; // Initial balance
        private List<Transaction> transactions = new List<Transaction>(); // Transaction history

        public Form1()
        {
            InitializeComponent();
            InitializeFormState();
        }

        // Initialize form to show login controls and hide others
        private void InitializeFormState()
        {
            // Show login controls
            lblUsername.Visible = true;
            txtUsername.Visible = true;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            lblPinPrompt.Visible = true;
            txtPin.Visible = true;
            btnSubmit.Visible = true;

            // Hide post-login controls
            btnNewPin.Visible = false;
            btnCheckPinStrength.Visible = false;
            btnLogout.Visible = false;
            btnWithdraw.Visible = false;
            btnDeposit.Visible = false;
            btnTransfer.Visible = false;
            btnCheckBalance.Visible = false;
            btnViewMiniStatement.Visible = false;
        }

        // Event handler for Submit button (login)
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text.Trim();
            string enteredPassword = txtPassword.Text.Trim();
            string enteredPin = txtPin.Text.Trim();

            if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword) || string.IsNullOrEmpty(enteredPin))
            {
                MessageBox.Show("Please enter username, password, and PIN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (enteredUsername != validUsername || enteredPassword != validPassword)
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (enteredPin.Length != 6 || !int.TryParse(enteredPin, out _) || enteredPin != currentPin)
            {
                MessageBox.Show("PIN must be the 6-digit number 101204.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Login successful
            isLoggedIn = true;
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Hide login controls
            lblUsername.Visible = false;
            txtUsername.Visible = false;
            lblPassword.Visible = false;
            txtPassword.Visible = false;
            lblPinPrompt.Visible = false;
            txtPin.Visible = false;
            btnSubmit.Visible = false;

            // Show post-login controls
            btnNewPin.Visible = true;
            btnCheckPinStrength.Visible = true;
            btnLogout.Visible = true;
            btnWithdraw.Visible = true;
            btnDeposit.Visible = true;
            btnTransfer.Visible = true;
            btnCheckBalance.Visible = true;
            btnViewMiniStatement.Visible = true;

            // Clear input fields
            txtUsername.Clear();
            txtPassword.Clear();
            txtPin.Clear();
        }

        // Event handler for New PIN button
        private void btnNewPin_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newPin = PromptForInput("Enter new 6-digit PIN:");
            if (newPin == null) return; // User canceled

            if (newPin.Length != 6 || !int.TryParse(newPin, out _))
            {
                MessageBox.Show("New PIN must be a 6-digit number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string confirmPin = PromptForInput("Confirm new PIN:");
            if (confirmPin == null) return; // User canceled

            if (newPin != confirmPin)
            {
                MessageBox.Show("PINs do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentPin = newPin;
            MessageBox.Show("New PIN set successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler for Check PIN Strength button
        private void btnCheckPinStrength_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string pinStrength = EvaluatePinStrength(currentPin);
            MessageBox.Show($"Your PIN is {pinStrength}.", "PIN Strength", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler for Withdraw button
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string amount = PromptForInput("Enter amount to withdraw:");
            if (amount == null) return; // User canceled

            if (!decimal.TryParse(amount, out decimal withdrawAmount) || withdrawAmount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (withdrawAmount > balance)
            {
                MessageBox.Show("Insufficient funds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            balance -= withdrawAmount;
            transactions.Add(new Transaction
            {
                Date = DateTime.Now,
                Type = "Withdrawal",
                Amount = withdrawAmount,
                BalanceAfter = balance
            });

            MessageBox.Show($"Withdrawal of ${withdrawAmount:F2} processed successfully! New balance: ${balance:F2}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler for Deposit button
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string amount = PromptForInput("Enter amount to deposit:");
            if (amount == null) return; // User canceled

            if (!decimal.TryParse(amount, out decimal depositAmount) || depositAmount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            balance += depositAmount;
            transactions.Add(new Transaction
            {
                Date = DateTime.Now,
                Type = "Deposit",
                Amount = depositAmount,
                BalanceAfter = balance
            });

            MessageBox.Show($"Deposit of ${depositAmount:F2} processed successfully! New balance: ${balance:F2}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler for Transfer button
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string amount = PromptForInput("Enter amount to transfer:");
            if (amount == null) return; // User canceled

            if (!decimal.TryParse(amount, out decimal transferAmount) || transferAmount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (transferAmount > balance)
            {
                MessageBox.Show("Insufficient funds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string account = PromptForInput("Enter recipient account number:");
            if (account == null) return; // User canceled

            balance -= transferAmount;
            transactions.Add(new Transaction
            {
                Date = DateTime.Now,
                Type = $"Transfer to {account}",
                Amount = transferAmount,
                BalanceAfter = balance
            });

            MessageBox.Show($"Transfer of ${transferAmount:F2} to account {account} processed successfully! New balance: ${balance:F2}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler for Check Balance button
        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Current balance: ${balance:F2}", "Balance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler for View Mini Statement button
        private void btnViewMiniStatement_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!transactions.Any())
            {
                MessageBox.Show("No transactions available.", "Mini Statement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var lastTransactions = transactions.OrderByDescending(t => t.Date).Take(5);
            string statement = "Mini Statement:\n\n" + string.Join("\n", lastTransactions);
            MessageBox.Show(statement, "Mini Statement", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler for Logout button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            isLoggedIn = false;
            InitializeFormState();
            MessageBox.Show("Logged out successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Helper method to evaluate PIN strength
        private string EvaluatePinStrength(string pin)
        {
            if (pin.Length < 4 || pin.All(c => c == pin[0]))
            {
                return "Weak";
            }
            else if (pin.Length == 6 && pin.Distinct().Count() >= 3)
            {
                return "Strong";
            }
            else
            {
                return "Moderate";
            }
        }

        // Helper method to prompt user for input
        private string PromptForInput(string prompt)
        {
            Form promptForm = new Form()
            {
                Width = 300,
                Height = 150,
                Text = "Input",
                StartPosition = FormStartPosition.CenterParent
            };

            Label lblPrompt = new Label() { Left = 20, Top = 20, Text = prompt, Width = 260 };
            TextBox txtInput = new TextBox() { Left = 20, Top = 50, Width = 240 };
            Button btnOk = new Button() { Text = "OK", Left = 100, Top = 80, DialogResult = DialogResult.OK };
            Button btnCancel = new Button() { Text = "Cancel", Left = 180, Top = 80, DialogResult = DialogResult.Cancel };

            // Use PasswordChar for PIN input only
            if (prompt.Contains("PIN")) txtInput.PasswordChar = '*';

            promptForm.Controls.AddRange(new Control[] { lblPrompt, txtInput, btnOk, btnCancel });
            promptForm.AcceptButton = btnOk;
            promptForm.CancelButton = btnCancel;

            DialogResult result = promptForm.ShowDialog();
            return result == DialogResult.OK ? txtInput.Text.Trim() : null;
        }
    }
}
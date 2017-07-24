using StudentService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StudentService.StudentReader;

namespace SmileBase
{
    public partial class Form1 : Form
    {
        private StudentImport currentStudentInComboBox;
        private DataTable balancesTable;
        private DataTable appointmentOverviewTable;
        private string importFileName;
        private long importRefId;

        public Form1()
        {
            InitializeComponent();
        }

        private void StudenImportCommand_Click(object sender, EventArgs e)
        {
            StudentImporter studentImporter = new StudentImporter();
            studentImporter.ImportToEntities();
        }

        private void readStudentSheetButton_Click(object sender, EventArgs e)
        {
            AccountLoader accountLoader = new AccountLoader();
            try
            {
                ResetStatusLabel();
                importFileName = accountLoader.GetExcelSheetFullPath(currentStudentInComboBox.CustomerNo);
                var dataSet = accountLoader.ExcelToDataSet(currentStudentInComboBox);
                appointmentOverviewTable = dataSet.Tables["Terminübersicht"];
                balancesTable = dataSet.Tables["Saldenliste"];
                appointmentsGridView.DataSource = appointmentOverviewTable;
                balanceGridView.DataSource = balancesTable;
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.ToString();
            }
        }

        private void ResetStatusLabel()
        {
            statusLabel.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var studentReader = new StudentReader();
            studentsComboBox.DataSource = studentReader.GetActiveStudentsForComboBox();
            studentsComboBox.DisplayMember = "MatchCode";
            studentsComboBox.ValueMember = "Id";
        }

        private void studentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var studentReader = new StudentReader();
            var currentSelectedItem = studentsComboBox.SelectedItem;
            if (currentSelectedItem is StudentImport)
                currentStudentInComboBox = (StudentImport)currentSelectedItem;
            else
                throw new Exception("Selected Item is no student!");

            var currentStudent = StudentReader.GetStudentsByCustomerNo((currentStudentInComboBox.CustomerNo));

            StudentTextBox.Text = currentStudent.FirstOrDefault().ToAddressString();
            importRefId = currentStudentInComboBox.Id;
        }

        private void ImportAccountingButton_Click(object sender, EventArgs e)
        {
            var balanceImporter = new BalanceImporter(balancesTable);
            var debitEntries = balanceImporter.ReadDebits(currentStudentInComboBox.CustomerNo, importFileName, importRefId);
            debitsGridView.DataSource = debitEntries;

            var paymentEntries = balanceImporter.ReadPayments(currentStudentInComboBox.CustomerNo, importFileName, importRefId);
            paymentsGridView.DataSource = paymentEntries;

            tabControl1.SelectedTab = AccountingTabPage;
        }

        private void ImportAllAccountingsButton_Click(object sender, EventArgs e)
        {
            var studentReader = new StudentReader();
            var debitWriter = new DebitWriter();
            var paymentWriter = new PaymentWriter();
            var sb = new StringBuilder();

            var allStudents = studentReader.GetActiveStudentsForComboBox();
            try
            {
                foreach (var customer in allStudents)
                {
                    var accountLoader = new AccountLoader();
                    var excelFilePath = accountLoader.GetExcelSheetFullPath(customer.CustomerNo);
                    if (excelFilePath.Contains("not found"))
                    {
                        sb.AppendLine(excelFilePath);
                        continue;
                    }
                    var dataSet = accountLoader.ExcelToDataSet(excelFilePath);
                    balancesTable = dataSet.Tables["Saldenliste"];
                    var balanceImporter = new BalanceImporter(balancesTable);
                    var debitEntries = balanceImporter.ReadDebits(customer.CustomerNo, excelFilePath, customer.Id);
                    foreach (var debit in debitEntries)
                    {
                        debitWriter.AddDebit(debit);
                    }

                    var paymentEntries = balanceImporter.ReadPayments(customer.CustomerNo, excelFilePath, customer.Id);
                    foreach (var payment in paymentEntries)
                    {
                        paymentWriter.AddPayment(payment);
                    }
                }
            }
            finally
            {
                Console.WriteLine(sb.ToString());
                informationsTextBox.Text = sb.ToString();
            }
        }

        private void importGeorgeAccountEntriesButton_Click(object sender, EventArgs e)
        {
            var georgeFilePath = georgeFilePathTextBox.Text;
            var accountLoader = new AccountLoader();
            var bankAccountList = accountLoader.CsvToGeorgeAccountList(georgeFilePath, ',');
            var bankAccountWriter = new BankAccountWriter();
            foreach (var entry in bankAccountList)
            {
                try
                {
                    bankAccountWriter.AddGeorgeAccountEntry(entry);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    //throw;
                }
            }
        }

        private void FindGeorgeFileButton_Click(object sender, EventArgs e)
        {
            if (georgeOpenFileDialog.ShowDialog() == DialogResult.OK)
                georgeFilePathTextBox.Text = georgeOpenFileDialog.FileName;
        }

        private void OpenMainFormButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
using System;
using System.Windows.Forms;

using DevExpress.XtraReports.UI;
// ...

namespace XtraReport_PrintingCS {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create a report.
            XtraReport1 report = new XtraReport1();

            // Invoke the Print dialog to print the report.
            report.PrintDialog();

            // Send the report directly to the default printer.
            report.Print();
        }

    }
    
}
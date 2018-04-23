Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Imports DevExpress.XtraReports.UI
' ...

Namespace XtraReport_PrintingCS
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' Create a report.
			Dim report As XtraReport1 = New XtraReport1()

			' Invoke the Print dialog to print the report.
			report.PrintDialog()

			' Send the report directly to the default printer.
			report.Print()
		End Sub

	End Class

End Namespace
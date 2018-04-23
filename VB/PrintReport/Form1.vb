Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace PrintReport
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' Create a report instance, assigned to a Print Tool.
			Dim pt As New ReportPrintTool(New XtraReport1())

			' Invoke the Print dialog.
			pt.PrintDialog()

			' Send the report to the default printer.
			pt.Print()

			' Send the report to the specified printer.
			pt.Print("myPrinter")
		End Sub

	End Class
End Namespace

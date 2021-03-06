Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace Aspose.Cells.Examples.Articles
    Public Class LoadSpecificSheetsExample
        Public Shared Sub Main()
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
            'Define a new Workbook.
            Dim workbook As Workbook

            'Set the load data option with selected sheet(s).
            Dim dataOption As New LoadDataOption()
            dataOption.SheetNames = New String() {"Sheet2"}

            'Load the workbook with the spcified worksheet only.
            Dim loadOptions As New LoadOptions(LoadFormat.Xlsx)
            loadOptions.LoadDataOptions = dataOption
            loadOptions.LoadDataAndFormatting = True

            'Creat the workbook.
            workbook = New Workbook(dataDir & "TestData.xlsx", loadOptions)

            'Perform your desired task.

            'Save the workbook.
            workbook.Save(dataDir & "outputFile.out.xlsx")


        End Sub
    End Class
End Namespace
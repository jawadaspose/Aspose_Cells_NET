Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells
Imports Aspose.Cells.Rendering

Namespace Aspose.Cells.Examples.Articles.ConvertingWorksheetToImage
    Public Class ConvertWorksheetToImageByPage
        Public Shared Sub Main(ByVal args() As String)
            ' The path to the documents directory.
            Dim dataDir As String = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

            Dim book As New Workbook(dataDir & "TestData.xlsx")
            Dim sheet As Worksheet = book.Worksheets(0)
            Dim options As New Global.Aspose.Cells.Rendering.ImageOrPrintOptions()
            options.HorizontalResolution = 200
            options.VerticalResolution = 200
            options.ImageFormat = System.Drawing.Imaging.ImageFormat.Tiff

            'Sheet2Image By Page conversion
            Dim sr As New SheetRender(sheet, options)
            For j As Integer = 0 To sr.PageCount - 1

                sr.ToImage(j, dataDir & "test" & sheet.Name & " Page" & (j + 1) & ".out.tif")
            Next j



        End Sub
    End Class
End Namespace
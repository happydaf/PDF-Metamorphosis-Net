Imports System
Imports System.IO

Namespace Sample
    Friend Class Test

        Shared Sub Main(ByVal args() As String)
            Dim p As New SautinSoft.PdfMetamorphosis()

            ' After purchasing the license, please insert your serial number here to activate the component.
            'p.Serial = "XXXXXXXXXXX";	

            If p IsNot Nothing Then
                Dim docxPath As String = "..\..\example.docx"
                Dim pdfPath As String = Path.ChangeExtension(docxPath, ".pdf")
                Dim docx() As Byte = File.ReadAllBytes(docxPath)

                ' 2. Convert DOCX to PDF in memory                
                Dim pdf() As Byte = p.DocxToPdfConvertByte(docx)

                If pdf IsNot Nothing Then
                    ' 3. Save the PDF document to a file for a viewing purpose.
                    File.WriteAllBytes(pdfPath, pdf)
					System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(pdfPath) With {.UseShellExecute = True})
                Else
                    System.Console.WriteLine("Conversion failed!")
                    Console.ReadLine()
                End If
            End If
        End Sub
    End Class
End Namespace
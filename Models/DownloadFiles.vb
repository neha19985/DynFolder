Imports System.IO
Imports System.Web.Hosting

Namespace Models
    Public Class DownloadFiles
        Public Function GetFiles() As List(Of DownloadFileInformation)
            Dim lstFiles As New List(Of DownloadFileInformation)()
            Dim dirInfo As New DirectoryInfo(HostingEnvironment.MapPath("~/Files/"))

            Dim i As Integer = 0
            For Each item In dirInfo.GetFiles()

                lstFiles.Add(New DownloadFileInformation() With {
                    .FileId = i + 1,
                   .FileName = item.Name,  'changes by Neha, Vidit
                   .FilePath = dirInfo.FullName + "\" + item.Name
                })
                i = i + 1
            Next
            Return lstFiles
        End Function
    End Class

End Namespace

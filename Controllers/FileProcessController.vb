Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports Dynfolder.Models

Namespace Controllers
    Public Class FileProcessController
        Inherits Controller

        Private obj As DownloadFiles
        Public Sub New()
            obj = New DownloadFiles()
        End Sub

        Public Function Index() As ActionResult
            Dim filesCollection = obj.GetFiles()
            Return View(filesCollection)
        End Function

        Public Function Download(FileID As String) As FileResult
            Dim CurrentFileID As Integer = Convert.ToInt32(FileID)
            Dim filesCol = obj.GetFiles()
            Dim CurrentFileName As String = (From fls In filesCol Where fls.FileId = CurrentFileID Select fls.FilePath).First()
            Dim contentType As String = String.Empty
            If CurrentFileName.Contains(".pdf") Then
                contentType = "application/pdf"

            ElseIf CurrentFileName.Contains(".docx") Then
                contentType = "application/docx"
            ElseIf CurrentFileName.Contains(".txt") Then
                contentType = "application/txt"
            End If
            Return File(CurrentFileName, contentType, CurrentFileName)
        End Function

        Public Function Upload() As ActionResult
            Return View()
        End Function

        <HttpPost>
        Function Upload(fc As FormCollection, res As HttpPostedFileBase) As ActionResult

            Dim folderPath As String = Server.MapPath("~/Files/")

            'Check whether Directory (Folder) exists.
            If Not Directory.Exists(folderPath) Then
                'If Directory (Folder) does not exists. Create it.
                Directory.CreateDirectory(folderPath)
            End If

            'Save the File to the Directory (Folder).
            res.SaveAs(folderPath & Path.GetFileName(res.FileName))

            'Display the success message.
            ViewData("Message") = Path.GetFileName(res.FileName) + " has been uploaded."
            Return View()
        End Function
    End Class
End Namespace
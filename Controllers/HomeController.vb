Imports System.IO

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
    <HttpPost>
    Function Contact(fc As FormCollection, res As HttpPostedFileBase) As ActionResult
        ViewData("Message") = "Your contact page."
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

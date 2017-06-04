@ModelType IEnumerable(Of Dynfolder.Models.DownloadFileInformation)
@Code
ViewData("Title") = "Index"
End Code

<h2>INDEX</h2>

<p>
    @Html.ActionLink("UploadNew", "Upload")
    
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.FileId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FileName)
        </th>
        @*<th>
            @Html.DisplayNameFor(Function(model) model.FilePath)
        </th>*@
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FileId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FileName)
        </td>
        @*<td>
            @Html.DisplayFor(Function(modelItem) item.FilePath)
        </td>*@
        <td>
            @Html.ActionLink("download", "download", New With {.FileID = item.FileId}) 
            @*@Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
        </td>
    </tr>
Next

  
</table>

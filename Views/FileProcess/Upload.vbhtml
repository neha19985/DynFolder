@Code
    ViewData("Title") = "Upload"
End Code

<h2>Upload</h2>
<p>Only upload pdf,txt and docx files</p>
<form action="@Url.Action("Upload")" method="post" enctype="multipart/form-data">
    <div Class="row">
        <div Class="col-md-6">
            <div Class="form-group">                                          
                        <div Class="upload-control"><input type="file" name="res" id="res" accept="doc/*" class="form-control  form-control-sm"></div>                                                      
            </div>
        </div>       
            <div Class="col-md-6">
                <div Class="form-group">
                        <div ><input type="Submit" value="Upload" class="btn btn-default"></div>                 
            </div>
        </div>
        </div>
</form>
<p style="color:green;">@ViewData("Message")</p>
@Html.ActionLink("Download Files", "Index", New With {.class = "btn btn-default"})
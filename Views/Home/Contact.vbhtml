@Code
    ViewData("Title") = "Contact"
End Code

<h2>@ViewData("Title").</h2>
<h3>@ViewData("Message")</h3>

<address>
    One Microsoft Way<br />
    Redmond, WA 98052-6399<br />
    <abbr title="Phone">P:</abbr>
    425.555.0100
</address>

<address>
    <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
    <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
</address>
<form action="@Url.Action("Contact")" method="post" enctype="multipart/form-data">
    <div Class="col-md-6">
        <div Class="form-group">
            <label>Resume</label>
            <div>
                <div class="row">
                    <div Class="col-md-5 upload-control"><input type="file" name="res" id="res" accept="doc/*" class="form-control  form-control-sm"></div>
                    @*<div Class="col-md-1"><input type="button" value="Upload" name="UploadRes" id="UploadRes" class="btn btn-default" onclick="window.location.href='@Url.Action("UploadRes", "Home")';" style="display :none" />@ViewData("Message")
            </div>*@
                </div>
            </div>
        </div>
    </div>
    <div Class="row">
        <div Class="col-md-12">
            <div Class="form-group">
                <div>
                    <div Class="text-center"><input type="Submit" value="Submit"  class="btn btn-default"><a href="@Url.Action("Cancel")" style="margin-left:20px;" class="btn btn-default">Cancel</a></div>
                    <div Class="text-center"></div>
                </div>
            </div>
        </div>
    </div>
 </form>
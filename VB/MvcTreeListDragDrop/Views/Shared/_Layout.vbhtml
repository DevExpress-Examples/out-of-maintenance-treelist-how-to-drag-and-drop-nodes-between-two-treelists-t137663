<!DOCTYPE html>

<html>
<head>
    <title>@ViewBag.Title</title>
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
    <script src="~/Scripts/MyDragHelper.js"></script>
    @Html.DevExpress().GetStyleSheets(New StyleSheet With {.ExtensionSuite = ExtensionSuite.TreeList})
    @Html.DevExpress().GetScripts(New Script With {.ExtensionSuite = ExtensionSuite.TreeList})
</head>

<body>
    @RenderBody()
</body>
</html>

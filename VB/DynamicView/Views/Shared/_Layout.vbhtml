<!DOCTYPE html>

<html>
<head>
    <title>@ViewBag.Title</title>
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />

    <script src="@Url.Content("~/Scripts/jquery-1.6.2.min.js")" type="text/javascript"></script>

    <script src="@Url.Content("~/Scripts/jquery.validate.min.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js")" type="text/javascript"></script>


    @Html.DevExpress().GetStyleSheets(new StyleSheet With { .ExtensionSuite = ExtensionSuite.All })
    @Html.DevExpress().GetScripts(new Script With { .ExtensionSuite = ExtensionSuite.All })
</head>

<body>
    @RenderBody()
</body>
</html>

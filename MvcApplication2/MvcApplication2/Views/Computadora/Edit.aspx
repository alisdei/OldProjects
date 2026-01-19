<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcApplication2.Models.TBL_PRODUCTOS>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Edit</title>
</head>
<body>
    <script src="<%: Url.Content("~/Scripts/jquery-1.7.1.min.js") %>"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"></script>
    
    <% using (Html.BeginForm()) { %>
        <%: Html.ValidationSummary(true) %>
    
        <fieldset>
            <legend>TBL_PRODUCTOS</legend>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IDPRODUCTO) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.IDPRODUCTO) %>
                <%: Html.ValidationMessageFor(model => model.IDPRODUCTO) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.DESCRIPCION) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.DESCRIPCION) %>
                <%: Html.ValidationMessageFor(model => model.DESCRIPCION) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.MARCA) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.MARCA) %>
                <%: Html.ValidationMessageFor(model => model.MARCA) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.CANTIDAD) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.CANTIDAD) %>
                <%: Html.ValidationMessageFor(model => model.CANTIDAD) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.PRECIO) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.PRECIO) %>
                <%: Html.ValidationMessageFor(model => model.PRECIO) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IDTIPO) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.IDTIPO) %>
                <%: Html.ValidationMessageFor(model => model.IDTIPO) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.ESTADO) %>
            </div>
            <div class="editor-field">
                <%: Html.CheckBoxFor(model => model.ESTADO.Value) %>
                <%: Html.ValidationMessageFor(model => model.ESTADO) %>
            </div>
    
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>
    <% } %>
    
    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>
</body>
</html>

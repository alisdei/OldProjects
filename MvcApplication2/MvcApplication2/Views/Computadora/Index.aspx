<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MvcApplication2.Models.TBL_PRODUCTOS>>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>
    <table>
        <tr>
            <th>
                <%: Html.DisplayNameFor(model => model.IDPRODUCTO) %>
            </th>
            <th>
                <%: Html.DisplayNameFor(model => model.DESCRIPCION) %>
            </th>
            <th>
                <%: Html.DisplayNameFor(model => model.MARCA) %>
            </th>
            <th>
                <%: Html.DisplayNameFor(model => model.CANTIDAD) %>
            </th>
            <th>
                <%: Html.DisplayNameFor(model => model.PRECIO) %>
            </th>
            <th>
                <%: Html.DisplayNameFor(model => model.IDTIPO) %>
            </th>
            <th>
                <%: Html.DisplayNameFor(model => model.ESTADO) %>
            </th>
            <th></th>
        </tr>
    
    <% foreach (var item in Model) { %>
        <tr>
            <td>
                <%: Html.DisplayFor(modelItem => item.IDPRODUCTO) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.DESCRIPCION) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.MARCA) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.CANTIDAD) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.PRECIO) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.IDTIPO) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.ESTADO) %>
            </td>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new {  id=item.IDPRODUCTO }) %> |
                <%: Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }) %> |
                <%: Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }) %>
            </td>
        </tr>
    <% } %>
    
    </table>
</body>
</html>

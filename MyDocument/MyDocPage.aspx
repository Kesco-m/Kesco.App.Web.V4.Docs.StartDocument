<%@ Page Language="C#" CodeBehind="MyDocPage.aspx.cs" Inherits="Kesco.App.Web.Docs.MyDocument.MyDocPage"%>
<%@ Register TagPrefix="v4control" Namespace="Kesco.Lib.Web.Controls.V4" Assembly="Controls.V4" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
</head>
<body>
<%= RenderDocumentHeader() %>
<div class="v4formContainer">
    <% RenderDocNumDateNameRows(Response.Output); %>

    <v4control:TextBox ID="MyFormField" runat="server" OnChanged="MyFormField_Changed"></v4control:TextBox>

    <% StartRenderVariablePart(Response.Output); %>
    <% EndRenderVariablePart(Response.Output); %>
</div>
</body>
</html>
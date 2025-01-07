<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Select.aspx.cs" Inherits="ZeroFour.Select2.Select" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <link href="https://cdn.jsdelivr.net/npm/select2@4.1.0-rc.0/dist/css/select2.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="miSelect" runat="server" CssClass="form-control"></asp:DropDownList>
            <br/>
            <asp:DropDownList ID="ddlEstudiante" CssClass="form-control" OnSelectedIndexChanged="ddlEstudiante_SelectedIndexChanged" runat="server"></asp:DropDownList>
            <br/>
            <asp:TextBox ID="txtResult" runat="server" CssClass="form-control" ></asp:TextBox>
        </div>
        <!--Scripts-->
        <script>
            $(document).ready(function () {
                $('#miSelect').select2({
                    placeholder: 'Seleccione una opción',
                    allowClear: true // Permite limpiar la selección
                });
            });

            $(document).ready(function () {
                $('#ddlEstudiante').select2({
                    placeholder: 'Seleccione una opción',
                    allowClear: true // Permite limpiar la selección
                });
            });
        </script>
        <!----------->
    </form>
    <script src="https://cdn.jsdelivr.net/npm/select2@4.1.0-rc.0/dist/js/select2.min.js"></script>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ZeroThree.UIL._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!--HEAD-->
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Varios</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <style>
        body {
            background: #8e9eab; /* fallback for old browsers */
            background: -webkit-linear-gradient(to right, #eef2f3, #8e9eab); /* Chrome 10-25, Safari 5.1-6 */
            background: linear-gradient(to right, #eef2f3, #8e9eab); /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
        }
    </style>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <!---->
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--Encabezado-->
            <div>
                <div class="pricing-header p-3 pb-md-4 mx-auto text-center">
                    <h1 class="display-4 fw-normal text-body-emphasis">Varios</h1>
                    <p class="fs-5 text-body-secondary">Bienvenido</p>
                </div>
            </div>
            <!---->
            <!--Cuerpo-->
            <div class="container py-4">
                <<div class="container mt-5">
                    <!-- Fila para Usuario (Formulario y GridView) -->
                    <div class="row mb-5">
                        <div class="col-md-6">
                            <div class="card mb-4">
                                <div class="card-header text-center color1 text-white">
                                    <h2>Registro de Alumnos</h2>
                                </div>
                                <div class="card-body table-responsive">
                                    <div class="container">
                                        <!-- Campos del formulario para la tabla Usuario -->
                                        <div class="mb-3">
                                            <asp:Label runat="server" Text="Carne" AssociatedControlID="txtCarne" />
                                            <asp:TextBox runat="server" ID="txtCarne" CssClass="form-control" Enabled="false" />
                                        </div>
                                        <div class="mb-3">
                                            <asp:Label runat="server" Text="Nombre 1" AssociatedControlID="txtNombre1" />
                                            <asp:TextBox runat="server" ID="txtNombre1" CssClass="form-control" />
                                        </div>
                                        <div class="mb-3">
                                            <asp:Label runat="server" Text="Nombre 2" AssociatedControlID="txtNombre2" />
                                            <asp:TextBox runat="server" ID="txtNombre2" CssClass="form-control" />
                                        </div>
                                        <div class="mb-3">
                                            <asp:Label runat="server" Text="Apelllido 1" AssociatedControlID="txtApellido1" />
                                            <asp:TextBox runat="server" ID="txtApellido1" CssClass="form-control" />
                                        </div>
                                        <div class="mb-3">
                                            <asp:Label runat="server" Text="Apellido 2" AssociatedControlID="txtApellido2" />
                                            <asp:TextBox runat="server" ID="txtApellido2" CssClass="form-control" />
                                        </div>
                                        <div class="mb-3">
                                            <asp:Label runat="server" Text="Fecha Nacimiento" AssociatedControlID="txtFechaNac" />
                                            <asp:TextBox runat="server" ID="txtFechaNac" TextMode="DateTime" CssClass="form-control" />
                                        </div>
                                        <div class="mb-3">
                                            <asp:Label runat="server" Text="Celular" AssociatedControlID="txtCelular" />
                                            <asp:TextBox runat="server" ID="txtCelular" CssClass="form-control" />
                                        </div>
                                        <div class="mb-3">
                                            <asp:Label runat="server" Text="Email" AssociatedControlID="txtEmail" />
                                            <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" />
                                        </div>
                                        <div class="mb-3">
                                            <asp:Label runat="server" Text="Estado" AssociatedControlID="chkEstado" />
                                            <asp:CheckBox runat="server" ID="chkEstado" CssClass="form-check-input" />
                                        </div>
                                        <div class="text-center">
                                            <asp:Button ID="ButtonGuardarAlumno" runat="server" Text="Guardar Alumno" CssClass="btn btn-primary" OnClick="ButtonGuardarAlumno_Click" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- GridView de Usuario -->
                        <div class="col-md-6">
                            <div class="card mb-4">
                                <div class="card-header text-center color1 text-white">
                                    <h2>Listado de Alumnos</h2>
                                </div>
                                <div class="card-body table-responsive">
                                    <asp:GridView ID="gvAlumno" runat="server" CssClass="table table-bordered table-striped table-responsive" AutoGenerateColumns="False"
                                        DataKeyNames="Carne"
                                        OnRowEditing="gvAlumno_RowEditing"
                                        OnRowCancelingEdit="gvAlumno_RowCancelingEdit"
                                        OnRowUpdating="gvAlumno_RowUpdating">
                                        <Columns>
                                            <asp:BoundField DataField="Carne" HeaderText="Carne" ReadOnly="True" />

                                            <asp:TemplateField HeaderText="Nombre 1">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblNombre1" runat="server" Text='<%# Bind("Nombre1") %>'></asp:Label>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtNombre1" runat="server" Text='<%# Bind("Nombre1") %>' CssClass="form-control"></asp:TextBox>
                                                </EditItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Nombre 2">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblNombre2" runat="server" Text='<%# Bind("Nombre2") %>'></asp:Label>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtNombre2" runat="server" Text='<%# Bind("Nombre2") %>' CssClass="form-control"></asp:TextBox>
                                                </EditItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Apellido 1">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblApellido1" runat="server" Text='<%# Bind("Apellido1") %>'></asp:Label>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtApellido1" runat="server" Text='<%# Bind("Apellido1") %>' CssClass="form-control"></asp:TextBox>
                                                </EditItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Apellido 2">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblApellido2" runat="server" Text='<%# Bind("Apellido2") %>'></asp:Label>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtApellido2" runat="server" Text='<%# Bind("Apellido2") %>' CssClass="form-control"></asp:TextBox>
                                                </EditItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Fecha Nacimiento">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblFechaNac" runat="server" Text='<%# Bind("Fecha_Nac", "{0:yyyy-MM-dd}") %>'></asp:Label>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtFechaNac" runat="server" Text='<%# Bind("FechaNac", "{0:yyyy-MM-dd}") %>' TextMode="Date" CssClass="form-control"></asp:TextBox>
                                                </EditItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Celular">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblCelular" runat="server" Text='<%# Bind("Celular") %>'></asp:Label>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtCelular" runat="server" Text='<%# Bind("Celular") %>' CssClass="form-control"></asp:TextBox>
                                                </EditItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Email">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblEmail" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtEmail" runat="server" Text='<%# Bind("Email") %>' CssClass="form-control"></asp:TextBox>
                                                </EditItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Estado">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblEstado" runat="server" Text='<%# Bind("Estado") %>'></asp:Label>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:CheckBox ID="chkEstadoEdit" runat="server" Checked='<%# Bind("Estado") %>' CssClass="form-check-input" />
                                                </EditItemTemplate>
                                            </asp:TemplateField>

                                            <asp:CommandField ShowEditButton="True" ButtonType="Button" />
                                        </Columns>
                                    </asp:GridView>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!---->
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>

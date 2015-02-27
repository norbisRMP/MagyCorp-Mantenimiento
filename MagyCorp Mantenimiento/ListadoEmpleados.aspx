<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoEmpleados.aspx.cs" Inherits="MagyCorp_Mantenimiento.ListadoEmpleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style5 {
            font-size: small;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="lblID">
            <h2 style="text-align: center">GESTION DE PERSONAL</h2>
            <fieldset>
                <legend>LISTADO EMPLEADO</legend>
                <asp:TextBox ID="txbID" runat="server" Width="155px" CssClass="auto-style5" Visible="false"></asp:TextBox>
                <table>
                    <tr>
                        <td>Nombre:</td>
                        <td>
                            <asp:TextBox ID="txbNombre" runat="server" Width="300px" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txbNombre" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txbNombre" ErrorMessage="Solo letras A-Z" ValidationExpression="[a-z A-Z]+"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Apellido:</td>
                        <td>
                            <asp:TextBox ID="txbApellido" runat="server" Style="margin-left: 0px" Width="300px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txbApellido" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txbApellido" ErrorMessage="Solor letras A-Z" ValidationExpression="[a-z A-Z]+"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Pusto:</td>
                        <td>
                            <asp:TextBox ID="txbPuesto" runat="server" Width="300px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txbPuesto" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txbPuesto" ErrorMessage="Solo letras A-Z" ValidationExpression="[a-z A-Z]+"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Sueldo:</td>
                        <td>
                            <asp:TextBox ID="txbSueldo" runat="server" Width="300px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txbSueldo" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txbSueldo" ErrorMessage="Solo numeros" ValidationExpression="[0-9-,-.]+"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Telefono:</td>
                        <td>
                            <asp:TextBox ID="txbTelefono" runat="server" Width="300px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="Button3" runat="server" Text="Nuevo" OnClick="Button3_Click" Width="95px" />
                            &nbsp;
                            <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="ibtnAdd_Click" Width="95px" />
                            &nbsp;
                            <asp:Button ID="Button2" runat="server" Text="Eliminar" OnClick="ibtnEliminar_Click" Width="100px" /></td>
                    </tr>
                </table>

                <hr />
                <asp:GridView ID="GV" runat="server" PageSize="20" Width="730px" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GV_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" BorderColor="#FFCC00" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            </fieldset>



            <br />


            


            <br />

        </div>
    </form>
</body>
</html>

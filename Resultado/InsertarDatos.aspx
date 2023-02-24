<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarDatos.aspx.cs" Inherits="Resultado.InsertarDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            INSERTAR</div>
        <asp:Label ID="Label1" runat="server" Text="Nombre_Completo"></asp:Label>
        <asp:TextBox ID="Txtnombre" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="Txtusuario" runat="server" Width="136px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Correo_Electronico"></asp:Label>
            <asp:TextBox ID="TxtCorreo" runat="server" Height="16px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Numero_Celular"></asp:Label>
            <asp:TextBox ID="TxtNumero" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Puesto"></asp:Label>
            <asp:TextBox ID="TxtPuesto" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="AGREGAR" />
        </p>
    </form>
</body>
</html>

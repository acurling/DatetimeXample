<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication26.CapaPresentacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <br />
        <div class="form-group">
            <label for="exampleInputEmail1">Codigo:</label>
            <asp:TextBox ID="tcodigo"  class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleInputPassword1">Nombre:</label>
            <asp:TextBox ID="tnombre"  class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleInputPassword1">Fecha:</label>
             <asp:TextBox ID="tfecha" type="date" class="form-control" runat="server"></asp:TextBox>
        </div>
        <br />
        <br />
        <br />
        <asp:Button ID="bAgregar" class="btn btn-primary" runat="server" Text="Agregar" OnClick="bAgregar_Click" />
          <asp:Button ID="bEliminar" class="btn btn-primary" runat="server" Text="Elminar" OnClick="bEliminar_Click" />
 

    </form>
</body>
</html>

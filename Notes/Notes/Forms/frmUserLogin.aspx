<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmUserLogin.aspx.cs" ValidateRequest="false" Inherits="Notes.Forms.frmUserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />    
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-lg-2">
                    <div class="panel panel-success">
                        <div class="panel-heading"></div>
                        <div class="panel-body">
                            <label>User Name:</label>
                            <asp:TextBox CssClass="form-control" ID="txtUerName" runat="server"></asp:TextBox>
                            <br />
                            <label>Password:</label>
                            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
                                                      
                            <br />
                            <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-block btn-success" Text="Submit" OnClick="btnSubmit_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

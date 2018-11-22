<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmNotes.aspx.cs" ValidateRequest="false" Inherits="Notes.frmNotes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>G Notes</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />  
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td style="vertical-align:top;">
                    <asp:GridView ID="gvNotes" Width="90%" runat="server" AutoGenerateColumns="False" DataKeyNames="id">  
                    <Columns>  
                    <asp:TemplateField HeaderText=""> 
                    <ItemTemplate>  
                    <asp:Label ID="lblTitle" runat="server" Text='<%#Bind("Title") %>'></asp:Label>  
                        <br />
                        <asp:Label ID="lblBody" runat="server" Text='<%#Bind("Body") %>'></asp:Label>  
                    </ItemTemplate>  
                    </asp:TemplateField>  
                    </Columns>  
                    </asp:GridView>
                </td>
                <td>
                    <table style="width:100%">
                        <tr>
                            <td style="text-align:right;"><label>Title</label></td>
                            <td><asp:TextBox CssClass="form-control" ID="txtTitle" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="text-align:right;vertical-align: top;"><label>Body</label></td>
                            <td><asp:TextBox ID="txtBody" TextMode="MultiLine" Height="200" runat="server" CssClass="form-control" style="height:200px;margin-top: 7px;"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td></td>
                <td><asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-block btn-success" Text="Submit" OnClick="btnSubmit_Click" /> </td>
            </tr>
                    </table>
                </td>
            </tr>
            
        </table>  
    </form>
</body>
</html>

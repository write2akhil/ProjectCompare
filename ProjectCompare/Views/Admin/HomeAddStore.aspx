<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeAddStore.aspx.cs" Inherits="ProjectCompare.Views.Admin.AddStore" %>

<!DOCTYPE html>
<html>
<head>
    <title>Bootstrap 101 Template</title>
    <%--<asp:ContentPlaceHolder ID="ContentPlaceHolder2" runat="server">
    </asp:ContentPlaceHolder>--%>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <!-- Bootstrap -->
    <!-- Latest compiled and minified CSS -->
    <%--<link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css">--%>
    <link href="../../css/bootstrap.css" rel="stylesheet" />
    <!-- Optional theme -->
    <%--<link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap-theme.min.css">--%>
    <link href="../../css/bootstrap-theme.css" rel="stylesheet" />
    <link href='http://fonts.googleapis.com/css?family=Lato:300' rel='stylesheet' type='text/css'>
    <link href="../../css/ProjectVegetable.css" rel="stylesheet" />
    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="../../assets/js/html5shiv.js"></script>
      <script src="../../assets/js/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="row">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <table>
                <tr>
                    <td>
                        Store Name:
                    </td>
                    <td>
                        <asp:TextBox ID="storeName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <tr>
                            <td>
                                Country:
                            </td>
                            <td>
                                <asp:DropDownList ID="country" AutoPostBack="true" OnSelectedIndexChanged="Country_Selected" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                State:
                            </td>
                            <td>
                                <asp:DropDownList ID="state" AutoPostBack="true" OnSelectedIndexChanged="State_Changed" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                City:
                            </td>
                            <td>
                                <asp:DropDownList ID="city"  runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <tr>
                    <td>
                        Address:
                    </td>
                    <td>
                        <asp:TextBox ID="address" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Phone:
                    </td>
                    <td>
                        <asp:TextBox ID="phone" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        mobile:
                    </td>
                    <td>
                        <asp:TextBox ID="mobile" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="save" runat="server" Text="Save" onclick="save_Click" />
                    </td>
                    <td>
                        <asp:Button ID="reset" runat="server" Text="Reset" />
                    </td>
                </tr>
            </table>
            </div>
    </div>
    </form>
</body>
</html>

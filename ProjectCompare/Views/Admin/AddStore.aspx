<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStore.aspx.cs" Inherits="ProjectCompare.Views.Admin.AddStore" %>

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
    <link href="../../css/Admin.css" rel="stylesheet" type="text/css" />
    <link href="../../css/ProjectVegetable.css" rel="stylesheet" type="text/css" />
    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="../../assets/js/html5shiv.js"></script>
      <script src="../../assets/js/respond.min.js"></script>
    <![endif]-->
</head>
<body style="background-color: rgb(232,232,232);">
    <div class="navbar navbar-default navbar-fixed-top" style="background: none repeat scroll 0% 0% rgb(188, 26, 188);">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar">
                    </span>
                </button>
                <a class="navbar-brand active" href="#" style="color: white; font-size: 30px;">PriceGreen.com
                    Admin Panel</a>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li style="font-size: 20px;"><a href="AddItems.aspx">+ Item</a></li>
                    <li><a href="AddAgent.aspx" style="font-size: 20px;">+ Agent</a></li>
                    <li><a href="AddStore.aspx" class="active" style="font-size: 20px;">+ Store</a></li>
                </ul>
            </div>
            <!--/.nav-collapse -->
        </div>
    </div>
    <div class="container">
        <form class="form-signin" runat="server" id="form1">
        <h2 class="form-signin-heading" style="font-family: Lato;">
            Add Store</h2>
        <input id="storeNameTextBox" runat="server" type="text" class="form-control" placeholder="Store Name"
            style="border-radius: 0px;">
        <div class="col-md-12" style="min-height: 30px;">
            <div class="dropdown clearfix">
                <asp:DropDownList ID="stateListDropdownlist" runat="server" CssClass="dropdown-menu"
                    Style="display: block; border-radius: 0px; margin: 0px; width: 111%; margin-left: -15px;
                    padding: 9px; word-wrap: break-word;">
                    <asp:ListItem>U.P.</asp:ListItem>
                    <asp:ListItem>Delhi</asp:ListItem>
                    <asp:ListItem>H.R.</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="col-md-12" style="min-height: 30px;">
            <div class="dropdown clearfix">
                <asp:DropDownList ID="cityListDropdownlist" runat="server" CssClass="dropdown-menu"
                    Style="display: block; border-radius: 0px; margin: 9px; width: 111%; margin-left: -15px;
                    padding: 9px; word-wrap: break-word;">
                    <asp:ListItem>Sahibabad</asp:ListItem>
                    <asp:ListItem>Ghaziabad</asp:ListItem>
                    <asp:ListItem>Noida</asp:ListItem>
                    <asp:ListItem>South Delhi</asp:ListItem>
                    <asp:ListItem>North Delhi</asp:ListItem>
                    <asp:ListItem>West Delhi</asp:ListItem>
                    <asp:ListItem>East Delhi</asp:ListItem>
                    <asp:ListItem>Gurgoan</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <input id="storeAddressTextBox" runat="server" type="text" class="form-control" placeholder="Store Address"
            style="border-radius: 0px; margin: 19px 0px;">
        <input id="storePincodeTextBox" runat="server" type="text" class="form-control" placeholder="Store Pincode"
            style="border-radius: 0px; margin-top: -19px;">
        <input id="storeContactTextBox" runat="server" type="text" class="form-control" placeholder="Store Contact Number"
            style="border-radius: 0px;">
        <div class="col-md-12" style="min-height: 57px;">
            <label id="messageStatusLabel" runat="server" class="label-success" style="margin-top: 25px;
                margin-left: 32px;" visible="false">
                Store added successfully!</label>
        </div>
        <%-- <button id="addItems" class="btn btn-lg btn-primary btn-block" type="submit" runat="server">Add Item</button>--%>
        <asp:Button ID="addItems" runat="server" Text="Add" CssClass="btn btn-lg btn-primary btn-block"
            OnClick="AddStores_Click" Style="border-radius: 0px;" />
        </form>
        <div class="row">
            <ul class="breadcrumb" style="margin-bottom: 0px; padding: 15px 22px; border-radius: 0px;
                background-color: rgb(100, 110, 110);">
            </ul>
            <asp:Repeater ID="storeListRepeater" runat="server">
                <HeaderTemplate>
                    <table class="table table-hover table-bordered" style="font-size: 19px;">
                        <thead>
                            <tr>
                                <th>
                                    StoreID
                                </th>
                                <th>
                                    StoreName
                                </th>
                                <th>
                                    State
                                </th>
                                <th>
                                    City
                                </th>
                                <th>
                                    Address
                                </th>
                                <th>
                                    Pincode
                                </th>
                                <th>
                                    Contact No.
                                </th>
                            </tr>
                        </thead>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <%# Eval("StoreID")%>
                        </td>
                        <td>
                            <%# Eval("StoreName")%>
                        </td>
                        <td>
                            <%# Eval("State")%>
                        </td>
                        <td>
                            <%# Eval("City")%>
                        </td>
                        <td>
                            <%# Eval("Address")%>
                        </td>
                        <td>
                            <%# Eval("Pincode")%>
                        </td>
                        <td>
                            <%# Eval("Phone")%>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            </table>
        </div>
    </div>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <%--<script src="//code.jquery.com/jquery.js"></script>--%>
    <script src="../../js/jquery.js" type="text/javascript"></script>
    <!-- Latest compiled and minified JavaScript -->
    <%--<script src="//netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js"></script>--%>
    <script src="../../js/bootstrap.js" type="text/javascript"></script>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddItems.aspx.cs" Inherits="ProjectCompare.Views.Admin.AddItems" %>

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
                    <li style="font-size: 20px;" class="active"><a href="AddItems.aspx">+ Item</a></li>
                    <li><a href="AddAgent.aspx" style="font-size: 20px;">+ Agent</a></li>
                    <li><a href="AddStore.aspx" style="font-size: 20px;">+ Store</a></li>
                </ul>
            </div>
            <!--/.nav-collapse -->
        </div>
    </div>
    <div class="container">
        <form class="form-signin" runat="server" id="form1">
        <h2 class="form-signin-heading" style="font-family: Lato;">
            Add Items</h2>
        <input id="itemENameTextBox" runat="server" type="text" class="form-control" placeholder="Item Engligh Name"
            style="border-radius: 0px;">
        <input id="itemHNameTextBox" runat="server" type="text" class="form-control" placeholder="Item Hindi Name"
            style="border-radius: 0px;">
        <div class="col-md-12" style="min-height: 30px;">
            <label id="messageStatusLabel" runat="server" class="label-success" style="margin-top: 5px;
                margin-left: 32px;" visible="false">
                Item added successfully!</label>
        </div>
        <%-- <button id="addItems" class="btn btn-lg btn-primary btn-block" type="submit" runat="server">Add Item</button>--%>
        <asp:Button ID="addItems" runat="server" Text="Add" CssClass="btn btn-lg btn-primary btn-block"
            OnClick="AddItems_Click" Style="border-radius: 0px;" />
        </form>
        <div class="row">
            <ul class="breadcrumb" style="margin-bottom: 0px; padding: 15px 22px; border-radius: 0px;
                background-color: rgb(100, 110, 110);">
            </ul>
            <asp:Repeater ID="itemListRepeater" runat="server">
                <HeaderTemplate>
                    <table class="table table-hover table-bordered" style="font-size: 19px;">
                        <thead>
                            <tr>
                               
                                <th>
                                    VegetableId
                                </th>
                                <th>
                                    VegeTableEName
                                </th>
                                <th>
                                    VegetableHName
                                </th>
                                 <th>
                                    Image
                                </th>
                            </tr>
                        </thead>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <%# Eval("VegetableId")%>
                        </td>
                        <td>
                            <%# Eval("VegeTableEName")%>
                        </td>
                        <td>
                            <%# Eval("VegetableHName")%>
                        </td>
                        <td>
                            <div class="col-md-2" style="width: 50%;">
                                <div class="thumbnail">
                                    
                                    <img data-src="../js/holder.js/300x200" src="../../img/<%# Eval("VegeTableEName") %>.jpg">
                                </div>
                            </div>
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

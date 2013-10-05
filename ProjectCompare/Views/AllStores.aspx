<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Default.Master" AutoEventWireup="true"
    CodeBehind="AllStores.aspx.cs" Inherits="ProjectCompare.Views.AllStores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row" style="margin-right: 0px; margin-left: 0px; background-color: rgb(240,240,240);">
        <asp:Repeater ID="Repeater1" runat="server"  onitemdatabound="Repeater1_ItemDataBound">
            <HeaderTemplate>
            </HeaderTemplate>
            <ItemTemplate>
                <div class="col-md-3">
                    <div class="thumbnail" style="margin-top: 25px;">
                        <img data-src="../js/holder.js/300x200" src="../img/<%# Eval("VegetableEName") %>.jpg">
                        <asp:HiddenField ID="hfVegName" runat="server" Value='<%#Eval("VegetableEName") %>' />
                        <div class="caption">
                            <h3 class="text-center">
                                <%# Eval("VegetableEName") %>
                            </h3>
                        </div>
                        <asp:Repeater ID="storeListRepeater" runat="server">
                            <HeaderTemplate>  
                            <table class="table" style="background: rgb(249,249,249); margin-bottom: 3px;">
                            </HeaderTemplate>
                            <ItemTemplate>
                          
                                <tr>
                                    <td>
                                        
                                       <%# Eval("StoreName")%>
                                    </td>
                                    <td>
                                        <label class="label label-success">
                                             <%# Eval("Price") %> </label>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                       
                        </table>
                        <label class="label label-success" style="font-size: 17px; margin-left: -1.5%; padding-right: 49%;">
                            Min
                            <%#     Eval("Price") %>
                          
                        </label>
                    </div>
                </div>
            </ItemTemplate>
            <FooterTemplate>
                </div>
            </FooterTemplate>
        </asp:Repeater>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Default.Master" AutoEventWireup="true"
    CodeBehind="Store.aspx.cs" Inherits="ProjectCompare.Views.Store" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="margin-right: 0px; margin-left: 0px; border-bottom: 1px solid rgb(232,232,232);
        border-top: 1px solid rgb(232,232,232);">
        <div class="col-md-2">
        </div>
        <div class="col-md-2">
            <select class="form-control">
                <option>Select Location</option>
                <option>Ghaziabad</option>
                <option>Sahibabad</option>
                <option>Shalimar Garden</option>
                <option>Vaishali</option>
                <option>Indrapuram</option>
                <option>South Delhi</option>
            </select>
        </div>
        <div class="col-md-2">
            <select class="form-control">
                <option>Select Store</option>
                <option>Reliance</option>
                <option>Spencers</option>
                <option>Easy Day</option>
                <option>Big Bazaar</option>
            </select></div>
        <div class="col-md-2">
            <select class="form-control">
                <option>Select Branch</option>
                <option>2</option>
                <option>3</option>
                <option>4</option>
                <option>5</option>
            </select></div>
        <div class="col-md-2">
            <select class="form-control">
                <option>Select Product</option>
                <option>2</option>
                <option>3</option>
                <option>4</option>
                <option>5</option>
            </select></div>
    </div>
    <div class="row" style="margin-right: 0px; margin-left: 0px; background-color: rgb(240,240,240);">
        <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="onItem_dataBound">
            <HeaderTemplate>
            </HeaderTemplate>
            <ItemTemplate>
                <div class="col-md-2">
                    <div class="thumbnail">
                        <img data-src="../js/holder.js/300x200" src="../img/<%# Eval("VegetableEName") %>.jpg">
                        <div class="caption">
                            <h3 class="text-center">
                                <%# Eval("VegetableEName") %>
                            </h3>
                        </div>
                        <label class="label label-success" style="font-size: 17px; margin-left: -2.5%; padding-right: 58%;">
                            <%# Eval("Price") %>
                            Rs/Kg
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

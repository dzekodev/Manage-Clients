<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gestion_Des_Client.aspx.cs" Inherits="Tp_9.Gestion_Des_Client" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 60px;
        }
        .auto-style2 {
            height: 123px;
        }
        .auto-style3 {
            height: 203px;
            text-align: left;
            background-color: #FFCCCC;
        }
        .auto-style4 {
            font-size: xx-large;
            color: #FF0000;
            background-color: #FFFFFF;
        }
        .auto-style5 {
            width: 100%;
        }
        .auto-style6 {
            width: 279px;
        }
        .auto-style8 {
            width: 388px;
        }
        .auto-style9 {
            font-size: x-large;
        }
        .auto-style10 {
            font-size: large;
        }
        .auto-style11 {
            color: #FFFFFF;
            font-weight: bold;
            font-size: large;
            margin-left: 0px;
            background-color: #000099;
        }
        .auto-style12 {
            width: 203px;
        }
        .auto-style13 {
            width: 309px;
        }
        .auto-style14 {
            width: 315px;
        }
        .auto-style15 {
            margin-left: 0px;
            background-color: #FFFF99;
        }
        .auto-style16 {
            width: 100%;
            background-color: #FFCCCC;
        }
        .auto-style17 {
            width: 61%;
            background-color: #FFCCCC;
        }
        .auto-style18 {
            width: 520px;
        }
        .auto-style19 {
            font-size: large;
            color: #FF0000;
            background-color: #99FF99;
        }
        .auto-style20 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <table class="auto-style5">
                <tr>
                    <td class="auto-style18">
            <strong>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style4" Text="Gestion des Clients"></asp:Label>
            </strong>
                    </td>
                    <td class="auto-style20"><strong>
                        <asp:Label ID="lbl_error" runat="server" CssClass="auto-style19"></asp:Label>
                        </strong></td>
                </tr>
            </table>
        </div>
        <div class="auto-style2">
            <table cellpadding="2" cellspacing="3" class="auto-style16">
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label2" runat="server" CssClass="auto-style9" Text="Selectionner un client"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style10" Height="25px" Width="327px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style12"><strong>
                        <asp:Button ID="Update_Btn" runat="server" CssClass="auto-style11" Height="37px" Text="Mettre aJjour" Width="145px" OnClick="Update_Btn_Click" />
                        </strong></td>
                    <td><strong>
                        <asp:Button ID="Delete_Btn" runat="server" CssClass="auto-style11" Height="37px" Text="Supprimer" Width="145px" OnClick="Delete_Btn_Click" />
                        </strong></td>
                </tr>
            </table>
            <table align="center" cellpadding="2" cellspacing="3" class="auto-style17">
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" CssClass="auto-style9" Text="Ou :"></asp:Label>
                    </td>
                    <td class="auto-style13"><strong>
                        <asp:Button ID="Clear_Btn0" runat="server" CssClass="auto-style11" Height="37px" Text="Créer Nouveau" Width="202px" OnClick="Clear_Btn0_Click" />
                        </strong></td>
                    <td><strong>
                        <asp:Button ID="Add_Btn" runat="server" CssClass="auto-style11" Height="37px" Text="Enregistrer" Width="145px" OnClick="Add_Btn_Click" />
                        </strong></td>
                </tr>
            </table>
        </div>
    <div class="auto-style3">
        <table class="auto-style5">
            <tr>
                <td class="auto-style14">
                        <asp:Label ID="Label4" runat="server" CssClass="auto-style9" Text="Nom"></asp:Label>
                    </td>
                <td>
                    <asp:TextBox ID="txt_nom" runat="server" CssClass="auto-style15" Height="26px" Width="204px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                        <asp:Label ID="Label5" runat="server" CssClass="auto-style9" Text="Prenom"></asp:Label>
                    </td>
                <td>
                    <asp:TextBox ID="txt_prenom" runat="server" CssClass="auto-style15" Height="26px" Width="204px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                        <asp:Label ID="Label6" runat="server" CssClass="auto-style9" Text="Adresse"></asp:Label>
                    </td>
                <td>
                    <asp:TextBox ID="txt_adresse" runat="server" CssClass="auto-style15" Height="26px" Width="204px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                        <asp:Label ID="Label7" runat="server" CssClass="auto-style9" Text="Ville"></asp:Label>
                    </td>
                <td>
                    <asp:TextBox ID="txt_ville" runat="server" CssClass="auto-style15" Height="26px" Width="204px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </div>
    </form>
    </body>
</html>

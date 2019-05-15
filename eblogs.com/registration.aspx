<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="registration" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: right;
            width: 228px;
        }
        .auto-style3 {
            width: 228px;
        }
        .auto-style4 {
            text-align: center;
            font-size: xx-large;
            background-color: #CC0000;
        }
        .auto-style5 {
            width: 263px;
        }
        .auto-style6 {
            text-align: right;
            width: 228px;
            height: 26px;
        }
        .auto-style7 {
            width: 263px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
            width: 130px;
        }
        #Button2 {
            height: 0px;
            width: 54px;
        }
        #ButtonHome {
            font-weight: 700;
            color: #FFFFFF;
            background-color: #CC0000;
        }
        .auto-style9 {
            width: 130px;
        }
        .auto-style13 {
            text-align: right;
            width: 228px;
            height: 25px;
        }
        .auto-style14 {
            width: 263px;
            height: 25px;
        }
        .auto-style15 {
            height: 25px;
            width: 130px;
        }
        .auto-style16 {
            text-align: right;
            width: 228px;
            height: 16px;
        }
        .auto-style17 {
            width: 263px;
            height: 16px;
        }
        .auto-style18 {
            height: 16px;
            width: 130px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-image: url('images/root-web-designs-slider-background.jpg'); height: 1793px;">
   
    <div>
    
        <div class="auto-style4">
            <strong style="background-color: #CC0000; color: #FFFFFF">
            <input id="ButtonHome" onclick="window.open('Default.aspx')" type="button" value="Home" style="border-style: none" />&nbsp&nbsp&nbsp Registration Form&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Button ID="Button1" runat="server" OnClick="Button_r_Click" BackColor="#CC0000" BorderColor="#CC0000" BorderStyle="None" Font-Bold="True" ForeColor="White" style="font-size: medium" Text="Done" />
            </strong>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td id="User_id" class="auto-style6" style="color: #FFFFFF">UserName:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBoxUN" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td class="auto-style9"UserName" class="auto-style2" style="color: #FFFFFF">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxUN" ErrorMessage="*Enter Username" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                
                
            </tr>
            <tr>
                <td id="Email" class="auto-style6" style="color: #FFFFFF">Email:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBoxEmail" runat="server" Width="200px" TextMode="Email"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="*Enter Email" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td id="Password" class="auto-style13" style="color: #FFFFFF">Password:</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TextBoxPassword" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style15">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="*Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td id="Country" class="auto-style16" style="color: #FFFFFF">Confirm Password:</td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBoxConfirm" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style18">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxConfirm" ErrorMessage="*Password does not match" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="color: #FFFFFF">&nbsp;</td>
                <td class="auto-style5">
                     &nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td>
                     &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <form id="form1" runat="server">
        <div>
       
        </div>
       
        <p>
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="190px"></asp:TextBox>
           
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Enter Name" ForeColor="Red"></asp:RequiredFieldValidator>
           
        </p>
        <p>
            &nbsp;</p>
        <p>
            Email Id:&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="182px"></asp:TextBox>
           
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Enter email in appropriate format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
           
        </p>
        <p>
            &nbsp;</p>
        <p>
            Phone no:
             <asp:TextBox ID="TextBox3" runat="server" Width="182px"></asp:TextBox>
           
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>First Page</asp:ListItem>
                <asp:ListItem>Others</asp:ListItem>
            </asp:RadioButtonList>
           
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                <asp:ListItem>One Week</asp:ListItem>
                <asp:ListItem>Two Weeks</asp:ListItem>
            </asp:RadioButtonList>
           
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Amount" Width="93px" OnClick="Button2_Click" />
&nbsp;<asp:TextBox ID="TextBox4" runat="server" Width="178px" Visible="false"></asp:TextBox>
           
        </p>
        <p>
            &nbsp;</p>
        <p>
            Upload:&nbsp;&nbsp;&nbsp;&nbsp;
           
         <asp:FileUpload ID="FileUpload1" runat="server" Height="25px" Width="256px" /></p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Pay Now" OnClick="Button1_Click" />
           
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server"></asp:Label>
           
        </p>
    </form>


   


</asp:Content>


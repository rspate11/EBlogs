<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Uploadblog.aspx.cs" Inherits="login1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server">
       
        <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></ajaxToolkit:ToolkitScriptManager>
        <ajaxToolkit:HtmlEditorExtender ID="HtmlEditorExtender1" runat="server" EnableSanitization="false" TargetControlID="Textboxbodytxt"></ajaxToolkit:HtmlEditorExtender>
       
    <asp:Label ID="Label1" runat="server" Text="Welcome" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="Black"></asp:Label>
  
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large"></asp:Label>
        <asp:Label ID="Label3" runat="server" ></asp:Label>
        <br />
        <br />
  
        <asp:Label ID="Titlelabel" runat="server" Text="Title" ForeColor="Black"></asp:Label>
        :<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextboxTitle1" runat="server" OnTextChanged="TextboxTitle1_TextChanged" BorderStyle="Solid"></asp:TextBox>
        
        <p>
            <asp:Label ID="labelblog" runat="server" Text="Blog" ForeColor="Black"></asp:Label>
            :</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Textboxbodytxt" runat="server" Columns="50" Rows="10" TextMode="MultiLine" Height="213px" Width="724px" BorderStyle="Solid"></asp:TextBox>
            &nbsp;</p>
         <p>
             &nbsp;</p>
         <p>
             &nbsp;</p>
         <p>
             &nbsp;</p>
     <p>
            Category:
            <asp:DropDownList ID="DropDownList2" runat="server" Height="22px" style="margin-left: 20px" Width="156px">
                <asp:ListItem>Travelling</asp:ListItem>
               <asp:ListItem>Food</asp:ListItem>
               
                <asp:ListItem>Top Stories</asp:ListItem>
            </asp:DropDownList>
     </p>
     <p>
            &nbsp;</p>
        <asp:Button ID="sub" runat="server" OnClick="sub_Click" Text="Submit" BorderStyle="Solid" />
    
        &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload ad" />
    
        </form>
</asp:Content>


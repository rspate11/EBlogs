<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="readblogs.aspx.cs" Inherits="readblogs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


   
        <form id="form1" runat="server">

   <asp:Label ID="Label1" runat="server" Text="Welcome" Font-Italic="True" ForeColor="Black" Font-Size="XX-Large"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large"></asp:Label>
            <br />
            <br />
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1"  >
         <ItemTemplate>
            <div>
                
                <br />
                <br />
                     <table>
                         <tr>
                             <td>
                <asp:Label ID="Label3" runat="server" ></asp:Label>
                            <p style="color: #800000; font-style: normal; font-family: 'Copperplate Gothic Bold'; font-size: large;"><%#Eval("Username") %></p>
                                 </td>
                       </tr>
                         <tr>
                             <td>
                <asp:Label ID="Label4" runat="server" ></asp:Label>       
                            <p style="font-family: 'Copperplate Gothic Bold'; color: #CC0000; text-decoration: underline overline; font-size: medium"><%#Eval("Title") %></p>
                                 </td>
                       </tr>
                         <tr>
                             <td>
                <asp:Label ID="Label5" runat="server" ></asp:Label>   
                       <p style="font-family: 'Calligrapher';color: #000000;" ><%#Eval("Bodytxt") %></p>
                                 </td>
                       </tr>
                    </table>   
                    
                <asp:Button ID="Button1" runat="server" Text="Like" BackColor="#6666FF" Font-Bold="False" ForeColor="White" Height="23px" Width="71px" /><asp:Label ID="Like" runat="server" ></asp:Label>
 <asp:Button ID="Button2" runat="server" Text="Comment" BackColor="Red" Font-Bold="False" ForeColor="White" OnClick="Button2_Click" Height="24px" Width="98px" />
         
          
            <%--<asp:TextBox ID="TextBox1" runat="server" Height="66px" TextMode="MultiLine" Visible="False" Width="341px"></asp:TextBox>--%>
                             
              
            </div>

         </ItemTemplate>




        </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:LoginConnectionString %>" SelectCommand="SELECT [Id], [Title], [Bodytxt],[Username] FROM [Blogdata]"></asp:SqlDataSource>
    

    
            
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
    


    

            
        </form>
    

</asp:Content>


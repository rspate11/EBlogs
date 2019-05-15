<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="comment.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 150px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form runat="server">
    <div class="alert" runat="server" id="main" style=" background-color:white;width:90%;margin-left:60px ; height:auto; margin-top:20px" >

    <table >
        <tr>
            <td class="auto-style1">&nbsp;<asp:Label ID="Label2" runat="server"></asp:Label>
                <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
            </td>
            <td>&nbsp;&nbsp;&nbsp; &nbsp;</td>
            
        </tr>
       
    </table>
    <hr style="background-color: #2A3A56; border-width: thick" />
     <br />
    
               <div runat="server" id="div1" class="alert" style=" background-color:lightblue;width:90%;margin-left:60px ; margin-top:10px" >
                    
                        <h2><asp:label ID="l2" runat="server" text="Question with Options
                    " CssClass="active"   ></asp:label></h2>  
                    
                </div>
           <!-- all options are also in label take <br> before it for new line-->
      <div id="comments" runat="server"  class="alert" style=" height:auto; width:90%;margin-left:60px ; background-color:#d0ece7; margin-top:10px" >
          
      
    <asp:Label ID="Lcomment" runat="server" Text="<h3>No Comments available!!</h3>"></asp:Label>
      </div>    
    <div id="main2" runat="server"></div>
    
          <div id="d1" class="alert" style=" width:90%;margin-left:60px ; margin-top:10px" ></div>
    <asp:TextBox ID="comment_text" runat="server" placeholder="enter your comment" CssClass="form-control" Width="735px" Font-Size="20px" ></asp:TextBox>
            
    <asp:Button ID="Button2" runat="server" Text="Submit" CssClass="active" BackColor="#293955" ForeColor="#ffffff" OnClick="my" />

   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
   </div> 

    </form>


</asp:Content>


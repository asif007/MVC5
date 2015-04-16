<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyForm.aspx.cs" Inherits="MVC5.WebForm.MyForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server"/>
    <div>
      <p>Here all list of product will display here</p>
        <asp:Label ID="prouctid" runat="server"></asp:Label>
    </div>
         <div>
      <p>two table joining</p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>
    
    <p>some ajax function by update panel</p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
       <ContentTemplate>
           <asp:Label ID="Number1" runat="server"></asp:Label>
           <asp:TextBox ID="textbox1" runat="server"></asp:TextBox><br/>
           <asp:Label ID="Number2" runat="server"></asp:Label>
           <asp:TextBox ID="textbox2" runat="server"></asp:TextBox><br/>
             <asp:Button ID="button" runat="server" Text="submit" OnClick="button_Click" style="height: 26px"/>
       
            
                   <asp:Label ID = "m1" runat= "server" ></asp:Label>
                    <asp:Label ID = "m2" runat= "server" ></asp:Label> 
                    <asp:Label ID = "m3" runat= "server"></asp:Label>
               
                
         
        
            </ContentTemplate>
         
    </asp:UpdatePanel>
    </form>
</body>
</html>

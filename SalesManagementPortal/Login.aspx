﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SalesManagementPortal.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome To Sales Management Portal</title>
    <meta charset="utf-8"/>
    <meta http-equiv="X-UACompatible" content="IE=edge"/>
    <meta name="viewport"  content="width=device-width,initial-scale=1"/>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/signin.css" rel="stylesheet" />


    <style>
        body{
            background-image:url('Images/lib.jpeg')
        }
    </style>

</head>
<body>
    <div class="container">
    <form id="form1" class="form-signin" runat="server">
        <h3 class="alert alert-success">Sales Management</h3>
        <label for="inputEmail" class="sr-only">User Name</label>
        <input type="text" id="inputEmail" class="form-control" placeholder="User Name" runat="server" required autofocus /><br />
        <lable for="inputPassword" class="sr-only">Password</lable>
         <input type="password" id="inputPassword" class="form-control" placeholder="Paaword" runat="server" required />
        <asp:Button CssClass="btn btn-lg btn-success btn-block" ID="btnLogin" runat="server" Text="Sign In" Onclick="btnLogin_Click"/>
        
    </form>
   </div>
</body>
</html>

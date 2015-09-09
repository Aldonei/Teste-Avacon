<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="WebAppCliente.Cliente" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="formCliente" runat="server">
        <div>
            <fieldset style="width:500px">
            <legend>Registro de Clientes</legend>
                <table width="84%" cellpadding="2" cellspacing="2">
                    <tr style="font-weight: normal; color: #000000">
                        <td align="right">
                            <span>Nome(*):</span>
                        </td>
                        <td align="left" style="padding-left: 10px;">
                            <asp:TextBox ID="txtNome" runat="server" CssClass="textbox" Width="300px"
                                MaxLength="80" Height="20px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <span class="TextTitle">CPF/CNPJ(*):</span>
                        </td>
                        <td align="left" style="padding-left: 10px;">
                            <asp:TextBox ID="txtCpfCnpj" runat="server" CssClass="textbox" Width="130px"
                                MaxLength="18" Height="20px"></asp:TextBox>
                            <br />
                        </td>
                    </tr>
                    
                    <tr style="font-weight: normal; color: #000000">
                        <td align="right">
                            <span>Telefone:</span>
                        </td>
                        <td align="left" style="padding-left: 10px;">
                            <asp:TextBox ID="txtTelefone" runat="server" CssClass="textbox" Width="130px"
                                MaxLength="18" Height="20px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr style="font-weight: normal; color: #000000">
                        <td align="right">
                            <span>Logradouro:</span>
                        </td>
                        <td align="left" style="padding-left: 10px;">
                            <asp:TextBox ID="txtLogradouro" runat="server" CssClass="textbox" Width="300px"
                                MaxLength="80" Height="20px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr style="font-weight: normal; color: #000000">
                        <td align="right">
                            <span>Número:</span>
                        </td>
                        <td align="left" style="padding-left: 10px;">
                            <asp:TextBox ID="txtNumero" runat="server" CssClass="textbox" Width="50px"
                                MaxLength="10" Height="20px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr style="font-weight: normal; color: #000000">
                        <td align="right">
                            <span>Cep:</span>
                        </td>
                        <td align="left" style="padding-left: 10px;">
                            <asp:TextBox ID="txtCep" runat="server" CssClass="textbox" Width="80px"
                                MaxLength="10" Height="20px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr style="font-weight: normal; color: #000000">
                        <td align="right">
                            <span>Bairro:</span>
                        </td>
                        <td align="left" style="padding-left: 10px;">
                            <asp:TextBox ID="txtBairro" runat="server" CssClass="textbox" Width="300px"
                                MaxLength="80" Height="20px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr style="font-weight: normal; color: #000000">
                        <td align="right">
                            <span>Cidade:</span>
                        </td>
                        <td align="left" style="padding-left: 10px;">
                            <asp:TextBox ID="txtCidade" runat="server" CssClass="textbox" Width="300px"
                                MaxLength="10" Height="20px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr style="font-weight: normal; color: #000000">
                        <td align="right">
                            <span>UF:</span>
                        </td>
                        <td align="left" style="padding-left: 10px;">
                            <asp:TextBox ID="txtUf" runat="server" CssClass="textbox" Width="20px"
                                MaxLength="2" Height="20px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr style="font-weight: normal; color: #000000">
                        <td align="right">
                            <span>País:</span>
                        </td>
                        <td align="left" style="padding-left: 10px;">
                            <asp:TextBox ID="txtPais" runat="server" CssClass="textbox" Width="300px"
                                MaxLength="80" Height="20px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr align="center">
                        <td>&nbsp;</td>
                        <td class="style1">
                            <asp:Button ID="btnSubmit" runat="server" Text="Enviar"
                                onclick="btnSubmit_Click" />
                            <asp:Button ID="btnCancel" runat="server" Text="Cancelar"
                                onclick="btnCancel_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            <asp:Label ID="lblMensagem" runat="server" Text="" style="color: #FF3300"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <%-- GRID --%>
                    <tr>
                        <td colspan="2">
                            <asp:GridView ID="grdCliente" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" CellPadding="5" ForeColor="#333333"> <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <Columns>
                                    <asp:TemplateField HeaderText="Nome" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                    <ItemTemplate><asp:Label ID="lblNome" runat="server" Text='<%#Eval("Nome")%>'></asp:Label></ItemTemplate></asp:TemplateField>
                                
                                    <asp:TemplateField HeaderText="CPF/CNPJ" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                    <ItemTemplate><asp:Label ID="lblCpfCnpj" runat="server" Text='<%#Eval("CpfCnpj") %>'></asp:Label></ItemTemplate></asp:TemplateField>
                                
                                    <asp:TemplateField HeaderText="Telefone" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                    <ItemTemplate><asp:Label ID="lblTelefone" runat="server" Text='<%#Eval("Telefone") %>'></asp:Label></ItemTemplate></asp:TemplateField>
                                
                                    <%-- Edição --%>
                                    <asp:TemplateField HeaderText="Editar" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="imgBtn" runat="server" CausesValidation="false" CommandArgument='<%#Eval("Id") %>'
                                                OnCommand="imgEdit_Command" ImageUrl="~/Images/icon-edit.png" ToolTip="Editar Registro" />
                                        </ItemTemplate>                                              
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:TemplateField>
                                
                                    <%-- Exclusão --%>
                                    <asp:TemplateField HeaderText="Excluir" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="imgDel" runat="server" CausesValidation="false" CommandArgument='<%#Eval("Id") %>'
                                                CommandName="Delete" OnCommand="imgDel_Command" ImageUrl="~/Images/icon-delete.png" ToolTip="Excluir Registro" 
                                                OnClientClick="return confirm('Deseja realmente Excluir este registro?')"   />
                                        </ItemTemplate>
                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:TemplateField>
                                </Columns>
                            
                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </fieldset>
        </div>
    </form>
</body>
</html>

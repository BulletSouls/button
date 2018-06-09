 <div>
     <h2>Dobrodosli na stranicu!</h2>
         
       <div class="buttons">
       <asp:Button ID="Button1" runat="server" Text="O autoru" Width="747px" OnClick="Button1_Click" BackColor="#00B3B3" BorderStyle="Dotted" Height="31px" />
        <asp:Button ID="Button2" runat="server" Text="Odjava" Width="751px" OnClick="Button2_Click" BackColor="#00B3B3" BorderStyle="Dotted" />
        </div>
       
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/biblioteka.xml"></asp:XmlDataSource>
    </div>
Imports System.Data.SqlClient

Public Class Register
    Shared connectionstring As String = "Data Source=.;Initial Catalog=CTS_DB;Integrated Security=True;TrustServerCertificate=True"

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Dim query As String = "select * from Entity where Type = 'C'"

        Dim con As New SqlConnection(connectionstring)

        con.Open()

        Dim cmd As New SqlCommand(query, con)

        Dim sda As New SqlDataAdapter(cmd)

        Dim ds As New DataSet()

        sda.Fill(ds)

        Dim dtCategory As New DataTable

        dtCategory = ds.Tables(0)

        cmbCategory.DataSource = dtCategory
        cmbCategory.DisplayMember = "Name"
        cmbCategory.ValueMember = "Entity_ID"

        con.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim dtComplaintDt As Date = dtpCompaintDt.Value
        Dim sCategory = cmbCategory.Text.Trim()
        Dim sStatus = txtStatus.Text.Trim()
        Dim sDescription = txtDescription.Text.Trim()

        Dim query As String = "Insert into Complaints(ComplaintDt, Category, Description, TransStatus, TransDT) Values(@ComplaintDt, @Category, @Description, @TransStatus, @TransDT)"

        Dim con As New SqlConnection(connectionstring)

        con.Open()

        Dim cmd As New SqlCommand(query, con)

        cmd.Parameters.AddWithValue("@ComplaintDt", dtComplaintDt)
        cmd.Parameters.AddWithValue("@Category", sCategory)
        cmd.Parameters.AddWithValue("@Description", sDescription)
        cmd.Parameters.AddWithValue("@TransStatus", sStatus)
        cmd.Parameters.AddWithValue("@TransDT", dtComplaintDt)

        cmd.ExecuteNonQuery()

        query = "select @@Identity as LastID from Complaints"

        cmd = New SqlCommand(query, con)

        Dim sda As New SqlDataAdapter(cmd)

        Dim ds As New DataSet()

        sda.Fill(ds)

        Dim dt As New DataTable

        dt = ds.Tables(0)

        Dim iComplaint_id = Convert.ToInt32(dt.Rows(0)("LastID").ToString())

        MessageBox.Show("Your Complaint got registered with ID : " & iComplaint_id)

        con.Close()
    End Sub

End Class
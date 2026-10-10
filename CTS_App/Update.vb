Imports System.Data.SqlClient

Public Class Update
    Shared connectionstring As String = "Data Source=.;Initial Catalog=CTS_DB;Integrated Security=True;TrustServerCertificate=True"

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim sID = txtID.Text.Trim()
        Dim sResolution = txtResolution.Text.Trim()
        Dim sStatus = cmbStatus.Text.Trim()
        Dim dtTransDt = Now()

        Dim query As String = "Update Complaints set Resolution = '" + sResolution + "', TransStatus = '" + sStatus + "', TransDT = '" + dtTransDt + "' Where ID = " + sID

        Dim con As New SqlConnection(connectionstring)

        con.Open()

        Dim cmd As New SqlCommand(query, con)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Your Complaint details updated successfully ")

        query = "insert into Complaints_Log select * from Complaints where ID = " + sID

        con = New SqlConnection(connectionstring)

        con.Open()

        cmd = New SqlCommand(query, con)

        cmd.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim query As String = "select * from Complaints where ID = " + txtID.Text.Trim()

        Dim con As New SqlConnection(connectionstring)

        con.Open()

        Dim cmd As New SqlCommand(query, con)

        Dim sda As New SqlDataAdapter(cmd)

        Dim ds As New DataSet()

        sda.Fill(ds)

        Dim dt As New DataTable

        dt = ds.Tables(0)

        Dim dr As DataRow

        dr = dt.Rows(0)

        cmbCategory.Text = dr("Category").ToString()

        txtComplaintDt.Text = dr("ComplaintDt").ToString()

        cmbStatus.Text = dr("TransStatus").ToString()

        txtDescription.Text = dr("Description").ToString()

        con.Close()

    End Sub


End Class
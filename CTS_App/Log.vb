Imports System.Data.SqlClient

Public Class Log
    Shared connectionstring As String = "Data Source=.;Initial Catalog=CTS_DB;Integrated Security=True;TrustServerCertificate=True"

    Private Sub Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim query As String = "select * from Complaints_Log where ID = " + txtID.Text.Trim()

        Dim con As New SqlConnection(connectionstring)

        con.Open()

        Dim cmd As New SqlCommand(query, con)

        Dim sda As New SqlDataAdapter(cmd)

        Dim ds As New DataSet()

        sda.Fill(ds)

        Dim dt As New DataTable

        dt = ds.Tables(0)

        DataGridView1.DataSource = dt

        con.Close()
    End Sub
End Class
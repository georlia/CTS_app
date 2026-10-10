Imports System.Data.SqlClient

Public Class Assign
    Shared connectionstring As String = "Data Source=.;Initial Catalog=CTS_DB;Integrated Security=True;TrustServerCertificate=True"
    Private Sub Assign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnAssign_Click(sender As Object, e As EventArgs) Handles BtnAssign.Click
        Dim sID = txtID.Text.Trim()
        Dim sAssignTo = cmbAssign.Text
        Dim sStatus = txtStatus.Text.Trim()
        Dim dtTransDt = Now()

        Dim query As String = "Update Complaints set AssignedTo = '" + sAssignTo + "', TransStatus = '" + sStatus + "', TransDT = '" + dtTransDt + "' Where ID = " + sID

        Dim con As New SqlConnection(connectionstring)

        con.Open()

        Dim cmd As New SqlCommand(query, con)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Your Complaint has been assigned successfully ")

        query = "insert into Complaints_Log select * from Complaints where ID = " + sID

        con = New SqlConnection(connectionstring)

        con.Open()

        cmd = New SqlCommand(query, con)

        cmd.ExecuteNonQuery()

        con.Close()


    End Sub
End Class
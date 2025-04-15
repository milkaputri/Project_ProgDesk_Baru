
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateConnection()
    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        Dim sql As String = "select username,password from " & tbluser & " where username='" & tbNamaPengguna.Text & "' and password='" & tbKataSandi.Text & "'"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            myDataReader.Close()
            pengguna = tbNamaPengguna.Text
            ppassword = tbKataSandi.Text
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Username / Password salah!")
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub Login_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            btnMasuk.PerformClick()
        End If
    End Sub

    Private Sub llReset_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llReset.LinkClicked
        tbNamaPengguna.Text = ""
        tbKataSandi.Text = ""
    End Sub
End Class

Imports MySql.Data.MySqlClient

Public Class Form7

    Private passwordVisible As Boolean = True ' Default: password terlihat

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String = "SELECT username, password FROM " & tbluser & " LIMIT 1"
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If

            myCommand = New MySqlCommand(sql, myConn)
            myDataReader = myCommand.ExecuteReader()

            If myDataReader.Read() Then
                tbNamaPengguna.Text = myDataReader("username").ToString()
                tbKataSandi.Text = myDataReader("password").ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data admin: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If myDataReader IsNot Nothing AndAlso Not myDataReader.IsClosed Then
                myDataReader.Close()
            End If
        End Try

        ' Tampilkan password secara default
        tbKataSandi.UseSystemPasswordChar = True
        pbOpenEyes.Visible = True
        pbCloseEyes.Visible = False
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            If String.IsNullOrWhiteSpace(tbKataSandi.Text) Then
                MessageBox.Show("Data tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbKataSandi.Focus()
                Exit Sub
            End If

            Dim sql As String = "UPDATE " & tbluser & " SET username = @username, password = @password LIMIT 1"

            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If

            myCommand = New MySqlCommand(sql, myConn)
            myCommand.Parameters.Clear()
            myCommand.Parameters.AddWithValue("@username", tbNamaPengguna.Text)
            myCommand.Parameters.AddWithValue("@password", tbKataSandi.Text)

            Dim result As Integer = myCommand.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Data admin berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim form As New Form1()
                form.Show()
                Me.Hide()
            Else
                MessageBox.Show("Tidak ada perubahan data.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pbCloseEyes_Click(sender As Object, e As EventArgs) Handles pbCloseEyes.Click
        tbKataSandi.UseSystemPasswordChar = True ' Sembunyikan password
        pbCloseEyes.Visible = False
        pbOpenEyes.Visible = True
    End Sub

    Private Sub pbOpenEyes_Click(sender As Object, e As EventArgs) Handles pbOpenEyes.Click
        tbKataSandi.UseSystemPasswordChar = False ' Tampilkan password
        pbCloseEyes.Visible = True
        pbOpenEyes.Visible = False
    End Sub

    Private Sub llReset_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llReset.LinkClicked
        tbNamaPengguna.Text = ""
        tbKataSandi.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class

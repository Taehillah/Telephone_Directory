Imports System.IO
Public Class Form1

    Dim strDirectories() As String = IO.File.ReadAllLines("Directories.txt")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each directory In strDirectories
            lbPhoneDirectories.Items.Add(directory)
        Next
    End Sub


End Class

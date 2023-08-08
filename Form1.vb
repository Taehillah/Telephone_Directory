Imports System.IO
Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class Form1

    Dim strDirectories() As String = IO.File.ReadAllLines("Directories.txt")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each directory In strDirectories
            lbPhoneDirectories.Items.Add(directory)
        Next
    End Sub

    <Obsolete>
    Private Sub btnCreateNewDirectory_Click(sender As Object, e As EventArgs) Handles btnCreateNewDirectory.Click
        Dim filename = InputBox("Enter the new directory name")
        If Not strDirectories.Contains(filename) Then
            IO.File.Create(filename)
            IO.File.AppendAllText("Directories.txt", filename + vbNewLine)
            strDirectories = IO.File.ReadAllLines("Directories.txt")
            lbPhoneDirectories.Items.Clear()
            For Each directory In strDirectories
                lbPhoneDirectories.Items.Add(directory)
            Next


        End If
    End Sub
End Class

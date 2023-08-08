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

    Private Sub lbPhoneDirectories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPhoneDirectories.SelectedIndexChanged
        txtCurrentDirectory.Text = lbPhoneDirectories.SelectedItem.ToString()
        DisplayData(txtCurrentDirectory.Text)
    End Sub

    Private Sub DisplayData(selectedDirectory As String)
        Dim query = From dir In IO.File.ReadAllLines(selectedDirectory)
                    Let name As String = dir.Split(","c)(0)
                    Let phone As String = dir.Split(","c)(1)
                    Order By name
                    Select name, phone

        dgvDisplayListing.DataSource = query.ToList
        dgvDisplayListing.Columns(0).HeaderText = "Name"
        dgvDisplayListing.Columns(1).HeaderText = "Phone Number"

    End Sub

    Private Sub btnAddListing_Click(sender As Object, e As EventArgs) Handles btnAddListing.Click
        Dim name As String = txtName.Text
        Dim phone As String = txtPhone.Text
        Dim selectedDirectory As String = txtCurrentDirectory.Text

        If name.Trim().Length > 0 And phone.Trim.Length > 0 And selectedDirectory.Trim().Length > 0 Then
            Dim sells As IO.StreamWriter = IO.File.AppendText(selectedDirectory)
            sells.WriteLine(name + "," + phone)
            sells.Close()
            DisplayData(selectedDirectory)
        End If
    End Sub

    Private Sub btnRemoveListing_Click(sender As Object, e As EventArgs) Handles btnRemoveListing.Click

    End Sub

    Private Sub dgvDisplayListing_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDisplayListing.CellContentClick
        Dim selectedRow = dgvDisplayListing.CurrentRow.Index
        txtName.Text = dgvDisplayListing.Item(0, selectedRow).Value.ToString()
        txtPhone.Text = dgvDisplayListing.Item(1, selectedRow).Value.ToString()
    End Sub
End Class

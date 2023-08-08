Imports System.IO
Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class Form1

    ' Array to store directory names read from the "Directories.txt" file
    Dim strDirectories() As String = IO.File.ReadAllLines("Directories.txt")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load directories into the list box on form load
        For Each directory In strDirectories
            lbPhoneDirectories.Items.Add(directory)
        Next
    End Sub

    <Obsolete>
    Private Sub btnCreateNewDirectory_Click(sender As Object, e As EventArgs) Handles btnCreateNewDirectory.Click
        ' Create a new directory
        Dim filename = InputBox("Enter the new directory name")
        If Not strDirectories.Contains(filename) Then
            ' Create the directory file and add the new directory name
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
        ' Update the selected directory in the text box and display its data
        txtCurrentDirectory.Text = lbPhoneDirectories.SelectedItem.ToString()
        DisplayData(txtCurrentDirectory.Text)
    End Sub

    Private Sub DisplayData(selectedDirectory As String)
        ' Display data from the selected directory in the DataGridView
        Dim query = From dir In IO.File.ReadAllLines(selectedDirectory)
                    Let name As String = dir.Split(","c)(0)
                    Let phone As String = dir.Split(","c)(1)
                    Order By name
                    Select name, phone

        ' Populate the DataGridView with the query results
        dgvDisplayListing.DataSource = query.ToList
        dgvDisplayListing.Columns(0).HeaderText = "Name"
        dgvDisplayListing.Columns(1).HeaderText = "Phone Number"
    End Sub

    Private Sub btnAddListing_Click(sender As Object, e As EventArgs) Handles btnAddListing.Click
        ' Add a new listing to the selected directory
        Dim name As String = txtName.Text
        Dim phone As String = txtPhone.Text
        Dim selectedDirectory As String = txtCurrentDirectory.Text
        If name.Trim().Length > 0 And phone.Trim.Length > 0 And selectedDirectory.Trim().Length > 0 Then
            ' Append the new listing to the selected directory's file
            Dim sells As IO.StreamWriter = IO.File.AppendText(selectedDirectory)
            sells.WriteLine(name + "," + phone)
            sells.Close()
            DisplayData(selectedDirectory)
        End If
    End Sub

    Private Sub btnRemoveListing_Click(sender As Object, e As EventArgs) Handles btnRemoveListing.Click
        ' Remove a listing from the selected directory
        Dim deleteName As String = txtName.Text
        Dim selectedDirectory As String = txtCurrentDirectory.Text
        Dim sells As IO.StreamWriter

        If deleteName.Trim().Length > 0 And selectedDirectory.Trim().Length > 0 Then
            ' Create a new directory file without the listing to be removed
            Dim query = From data In IO.File.ReadAllLines(selectedDirectory)
                        Let name As String = data.Split(","c)(0)
                        Let phone As String = data.Split(","c)(1)
                        Where name <> deleteName
                        Let result As String = name + "," + phone
                        Select result
            sells = IO.File.CreateText(selectedDirectory)
            For i As Integer = 0 To query.Count() - 1
                sells.WriteLine(query(i))
            Next
            sells.Close()
            DisplayData(selectedDirectory)
        End If
    End Sub

    Private Sub dgvDisplayListing_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDisplayListing.CellContentClick
        ' Populate the text boxes with data from the selected DataGridView row
        Dim selectedRow = dgvDisplayListing.CurrentRow.Index
        txtName.Text = dgvDisplayListing.Item(0, selectedRow).Value.ToString()
        txtPhone.Text = dgvDisplayListing.Item(1, selectedRow).Value.ToString()
    End Sub

    Private Sub btnDisplayListing_Click(sender As Object, e As EventArgs) Handles btnDisplayListing.Click
        ' Display data from the selected directory
        Dim selectedDirectory As String = txtCurrentDirectory.Text.Trim()
        DisplayData(selectedDirectory)
    End Sub

End Class

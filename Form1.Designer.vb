<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblClickPointer = New Label()
        btnCreateNewDirectory = New Button()
        txtName = New TextBox()
        lblName = New Label()
        lblPhoneNumber = New Label()
        TextBox1 = New TextBox()
        lbPhoneDirectories = New ListBox()
        lblPhoneDirectories = New Label()
        lblCurrentPhoneDirectory = New Label()
        lbCurrentPhoneDirectory = New ListBox()
        btnAddListing = New Button()
        btnRemoveListing = New Button()
        btnDisplayListing = New Button()
        dgvDisplayListing = New DataGridView()
        CType(dgvDisplayListing, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblClickPointer
        ' 
        lblClickPointer.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblClickPointer.Location = New Point(44, 57)
        lblClickPointer.Name = "lblClickPointer"
        lblClickPointer.Size = New Size(258, 35)
        lblClickPointer.TabIndex = 0
        lblClickPointer.Text = "Click on one of the existing phone directories below to make it the current phone directory."
        ' 
        ' btnCreateNewDirectory
        ' 
        btnCreateNewDirectory.Location = New Point(471, 60)
        btnCreateNewDirectory.Name = "btnCreateNewDirectory"
        btnCreateNewDirectory.Size = New Size(238, 32)
        btnCreateNewDirectory.TabIndex = 1
        btnCreateNewDirectory.Text = "Create a New Phone Directory"
        btnCreateNewDirectory.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(471, 173)
        txtName.Name = "txtName"
        txtName.Size = New Size(238, 23)
        txtName.TabIndex = 2
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(410, 181)
        lblName.Name = "lblName"
        lblName.Size = New Size(45, 15)
        lblName.TabIndex = 3
        lblName.Text = "Name: "
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(364, 226)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(91, 15)
        lblPhoneNumber.TabIndex = 4
        lblPhoneNumber.Text = "Phone Number:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(471, 218)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(238, 23)
        TextBox1.TabIndex = 5
        ' 
        ' lbPhoneDirectories
        ' 
        lbPhoneDirectories.FormattingEnabled = True
        lbPhoneDirectories.ItemHeight = 15
        lbPhoneDirectories.Location = New Point(43, 117)
        lbPhoneDirectories.Name = "lbPhoneDirectories"
        lbPhoneDirectories.Size = New Size(259, 124)
        lbPhoneDirectories.TabIndex = 6
        ' 
        ' lblPhoneDirectories
        ' 
        lblPhoneDirectories.AutoSize = True
        lblPhoneDirectories.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblPhoneDirectories.Location = New Point(111, 94)
        lblPhoneDirectories.Name = "lblPhoneDirectories"
        lblPhoneDirectories.Size = New Size(133, 20)
        lblPhoneDirectories.TabIndex = 7
        lblPhoneDirectories.Text = "Phone Directories"
        ' 
        ' lblCurrentPhoneDirectory
        ' 
        lblCurrentPhoneDirectory.AutoSize = True
        lblCurrentPhoneDirectory.Location = New Point(317, 133)
        lblCurrentPhoneDirectory.Name = "lblCurrentPhoneDirectory"
        lblCurrentPhoneDirectory.Size = New Size(138, 15)
        lblCurrentPhoneDirectory.TabIndex = 8
        lblCurrentPhoneDirectory.Text = "Current Phone Directory:"
        ' 
        ' lbCurrentPhoneDirectory
        ' 
        lbCurrentPhoneDirectory.FormattingEnabled = True
        lbCurrentPhoneDirectory.ItemHeight = 15
        lbCurrentPhoneDirectory.Location = New Point(471, 129)
        lbCurrentPhoneDirectory.Name = "lbCurrentPhoneDirectory"
        lbCurrentPhoneDirectory.Size = New Size(238, 19)
        lbCurrentPhoneDirectory.TabIndex = 9
        ' 
        ' btnAddListing
        ' 
        btnAddListing.Location = New Point(44, 265)
        btnAddListing.Name = "btnAddListing"
        btnAddListing.Size = New Size(238, 45)
        btnAddListing.TabIndex = 10
        btnAddListing.Text = "Add a Listing to the Current Directory"
        btnAddListing.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveListing
        ' 
        btnRemoveListing.Location = New Point(288, 265)
        btnRemoveListing.Name = "btnRemoveListing"
        btnRemoveListing.Size = New Size(238, 45)
        btnRemoveListing.TabIndex = 11
        btnRemoveListing.Text = "Remove a Listing from the Current Directory"
        btnRemoveListing.UseVisualStyleBackColor = True
        ' 
        ' btnDisplayListing
        ' 
        btnDisplayListing.Location = New Point(532, 265)
        btnDisplayListing.Name = "btnDisplayListing"
        btnDisplayListing.Size = New Size(238, 45)
        btnDisplayListing.TabIndex = 12
        btnDisplayListing.Text = "Display the Listing in the Current Directory"
        btnDisplayListing.UseVisualStyleBackColor = True
        ' 
        ' dgvDisplayListing
        ' 
        dgvDisplayListing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDisplayListing.Location = New Point(209, 322)
        dgvDisplayListing.Name = "dgvDisplayListing"
        dgvDisplayListing.RowTemplate.Height = 25
        dgvDisplayListing.Size = New Size(401, 108)
        dgvDisplayListing.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvDisplayListing)
        Controls.Add(btnDisplayListing)
        Controls.Add(btnRemoveListing)
        Controls.Add(btnAddListing)
        Controls.Add(lbCurrentPhoneDirectory)
        Controls.Add(lblCurrentPhoneDirectory)
        Controls.Add(lblPhoneDirectories)
        Controls.Add(lbPhoneDirectories)
        Controls.Add(TextBox1)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblName)
        Controls.Add(txtName)
        Controls.Add(btnCreateNewDirectory)
        Controls.Add(lblClickPointer)
        Name = "Form1"
        Text = "Create and Maintain Telephone Directories"
        CType(dgvDisplayListing, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblClickPointer As Label
    Friend WithEvents btnCreateNewDirectory As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbPhoneDirectories As ListBox
    Friend WithEvents lblPhoneDirectories As Label
    Friend WithEvents lblCurrentPhoneDirectory As Label
    Friend WithEvents lbCurrentPhoneDirectory As ListBox
    Friend WithEvents btnAddListing As Button
    Friend WithEvents btnRemoveListing As Button
    Friend WithEvents btnDisplayListing As Button
    Friend WithEvents dgvDisplayListing As DataGridView
End Class

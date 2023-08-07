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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' Button1
        ' 
        Button1.Location = New Point(44, 265)
        Button1.Name = "Button1"
        Button1.Size = New Size(238, 45)
        Button1.TabIndex = 10
        Button1.Text = "Add a Listing to the Current Directory"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(288, 265)
        Button2.Name = "Button2"
        Button2.Size = New Size(238, 45)
        Button2.TabIndex = 11
        Button2.Text = "Remove a Listing from the Current Directory"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(532, 265)
        Button3.Name = "Button3"
        Button3.Size = New Size(238, 45)
        Button3.TabIndex = 12
        Button3.Text = "Display the Listing in the Current Directory"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(209, 322)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(401, 108)
        DataGridView1.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
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
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class

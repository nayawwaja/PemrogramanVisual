<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtkom = New TextBox()
        txtnim = New TextBox()
        txtnama = New TextBox()
        btnkel = New Button()
        btnhps = New Button()
        btntamp = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(131, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 32)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(131, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 32)
        Label2.TabIndex = 1
        Label2.Text = "NIM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(131, 263)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 32)
        Label3.TabIndex = 2
        Label3.Text = "Kom"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(606, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 32)
        Label4.TabIndex = 3
        ' 
        ' txtkom
        ' 
        txtkom.Location = New Point(288, 260)
        txtkom.Name = "txtkom"
        txtkom.Size = New Size(200, 39)
        txtkom.TabIndex = 4
        ' 
        ' txtnim
        ' 
        txtnim.Location = New Point(288, 177)
        txtnim.Name = "txtnim"
        txtnim.Size = New Size(200, 39)
        txtnim.TabIndex = 5
        ' 
        ' txtnama
        ' 
        txtnama.Location = New Point(288, 93)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(200, 39)
        txtnama.TabIndex = 6
        ' 
        ' btnkel
        ' 
        btnkel.Location = New Point(554, 346)
        btnkel.Name = "btnkel"
        btnkel.Size = New Size(150, 46)
        btnkel.TabIndex = 7
        btnkel.Text = "Keluar"
        btnkel.UseVisualStyleBackColor = True
        ' 
        ' btnhps
        ' 
        btnhps.Location = New Point(325, 346)
        btnhps.Name = "btnhps"
        btnhps.Size = New Size(150, 46)
        btnhps.TabIndex = 8
        btnhps.Text = "Hapus"
        btnhps.UseVisualStyleBackColor = True
        ' 
        ' btntamp
        ' 
        btntamp.Location = New Point(102, 346)
        btntamp.Name = "btntamp"
        btntamp.Size = New Size(150, 46)
        btntamp.TabIndex = 9
        btntamp.Text = "Tampilkan"
        btntamp.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btntamp)
        Controls.Add(btnhps)
        Controls.Add(btnkel)
        Controls.Add(txtnama)
        Controls.Add(txtnim)
        Controls.Add(txtkom)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtkom As TextBox
    Friend WithEvents txtnim As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents btnkel As Button
    Friend WithEvents btnhps As Button
    Friend WithEvents btntamp As Button

End Class

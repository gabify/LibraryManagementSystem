<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnTheses = New System.Windows.Forms.Button()
        Me.btnJournal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBooks
        '
        Me.btnBooks.Location = New System.Drawing.Point(12, 38)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(119, 76)
        Me.btnBooks.TabIndex = 0
        Me.btnBooks.Text = "Books"
        Me.btnBooks.UseVisualStyleBackColor = True
        '
        'btnTheses
        '
        Me.btnTheses.Location = New System.Drawing.Point(148, 38)
        Me.btnTheses.Name = "btnTheses"
        Me.btnTheses.Size = New System.Drawing.Size(119, 76)
        Me.btnTheses.TabIndex = 1
        Me.btnTheses.Text = "Theses"
        Me.btnTheses.UseVisualStyleBackColor = True
        '
        'btnJournal
        '
        Me.btnJournal.Location = New System.Drawing.Point(292, 38)
        Me.btnJournal.Name = "btnJournal"
        Me.btnJournal.Size = New System.Drawing.Size(119, 76)
        Me.btnJournal.TabIndex = 2
        Me.btnJournal.Text = "Journals"
        Me.btnJournal.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 146)
        Me.Controls.Add(Me.btnJournal)
        Me.Controls.Add(Me.btnTheses)
        Me.Controls.Add(Me.btnBooks)
        Me.Name = "main"
        Me.Text = "main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBooks As Button
    Friend WithEvents btnTheses As Button
    Friend WithEvents btnJournal As Button
End Class

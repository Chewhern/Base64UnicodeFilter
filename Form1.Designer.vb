<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.OutputBox = New System.Windows.Forms.ListBox()
        Me.ChooseBase64FileBTN = New System.Windows.Forms.Button()
        Me.Base64FileSelector = New System.Windows.Forms.OpenFileDialog()
        Me.RemoveFromPositionTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RemoveEndAtPositionTB = New System.Windows.Forms.TextBox()
        Me.RemoveRangeBTN = New System.Windows.Forms.Button()
        Me.ExportFilteredListToSelectedFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.FilterExportBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OutputBox
        '
        Me.OutputBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.OutputBox.FormattingEnabled = True
        Me.OutputBox.ItemHeight = 37
        Me.OutputBox.Location = New System.Drawing.Point(13, 13)
        Me.OutputBox.Name = "OutputBox"
        Me.OutputBox.Size = New System.Drawing.Size(775, 374)
        Me.OutputBox.TabIndex = 0
        '
        'ChooseBase64FileBTN
        '
        Me.ChooseBase64FileBTN.Location = New System.Drawing.Point(817, 13)
        Me.ChooseBase64FileBTN.Name = "ChooseBase64FileBTN"
        Me.ChooseBase64FileBTN.Size = New System.Drawing.Size(269, 62)
        Me.ChooseBase64FileBTN.TabIndex = 1
        Me.ChooseBase64FileBTN.Text = "Choose Base64 File"
        Me.ChooseBase64FileBTN.UseVisualStyleBackColor = True
        '
        'Base64FileSelector
        '
        Me.Base64FileSelector.FileName = "OpenFileDialog1"
        '
        'RemoveFromPositionTB
        '
        Me.RemoveFromPositionTB.Location = New System.Drawing.Point(817, 111)
        Me.RemoveFromPositionTB.Name = "RemoveFromPositionTB"
        Me.RemoveFromPositionTB.Size = New System.Drawing.Size(269, 26)
        Me.RemoveFromPositionTB.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(817, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Remove From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(817, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Remove End At"
        '
        'RemoveEndAtPositionTB
        '
        Me.RemoveEndAtPositionTB.Location = New System.Drawing.Point(817, 182)
        Me.RemoveEndAtPositionTB.Name = "RemoveEndAtPositionTB"
        Me.RemoveEndAtPositionTB.Size = New System.Drawing.Size(269, 26)
        Me.RemoveEndAtPositionTB.TabIndex = 4
        '
        'RemoveRangeBTN
        '
        Me.RemoveRangeBTN.Location = New System.Drawing.Point(817, 238)
        Me.RemoveRangeBTN.Name = "RemoveRangeBTN"
        Me.RemoveRangeBTN.Size = New System.Drawing.Size(269, 60)
        Me.RemoveRangeBTN.TabIndex = 6
        Me.RemoveRangeBTN.Text = "Remove Range"
        Me.RemoveRangeBTN.UseVisualStyleBackColor = True
        '
        'FilterExportBTN
        '
        Me.FilterExportBTN.Location = New System.Drawing.Point(817, 320)
        Me.FilterExportBTN.Name = "FilterExportBTN"
        Me.FilterExportBTN.Size = New System.Drawing.Size(269, 57)
        Me.FilterExportBTN.TabIndex = 7
        Me.FilterExportBTN.Text = "Filter Export"
        Me.FilterExportBTN.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 493)
        Me.Controls.Add(Me.FilterExportBTN)
        Me.Controls.Add(Me.RemoveRangeBTN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RemoveEndAtPositionTB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RemoveFromPositionTB)
        Me.Controls.Add(Me.ChooseBase64FileBTN)
        Me.Controls.Add(Me.OutputBox)
        Me.Name = "Form1"
        Me.Text = "Filter Unicode From Base64 String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OutputBox As ListBox
    Friend WithEvents ChooseBase64FileBTN As Button
    Friend WithEvents Base64FileSelector As OpenFileDialog
    Friend WithEvents RemoveFromPositionTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RemoveEndAtPositionTB As TextBox
    Friend WithEvents RemoveRangeBTN As Button
    Friend WithEvents ExportFilteredListToSelectedFolder As FolderBrowserDialog
    Friend WithEvents FilterExportBTN As Button
End Class

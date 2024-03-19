<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReelControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReelControl1))
        Me.slotPB = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.slotPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'slotPB
        '
        Me.slotPB.Location = New System.Drawing.Point(0, 0)
        Me.slotPB.Name = "slotPB"
        Me.slotPB.Size = New System.Drawing.Size(224, 224)
        Me.slotPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.slotPB.TabIndex = 0
        Me.slotPB.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "squash.png")
        Me.ImageList1.Images.SetKeyName(1, "vader.jpg")
        Me.ImageList1.Images.SetKeyName(2, "goku.png")
        Me.ImageList1.Images.SetKeyName(3, "Untitled.png")
        Me.ImageList1.Images.SetKeyName(4, "hot.png")
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 250
        '
        'ReelControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.slotPB)
        Me.Name = "ReelControl1"
        Me.Size = New System.Drawing.Size(224, 224)
        CType(Me.slotPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents slotPB As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class

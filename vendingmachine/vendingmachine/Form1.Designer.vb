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
        Me.dimeButton = New System.Windows.Forms.Button()
        Me.nickelButton = New System.Windows.Forms.Button()
        Me.quarterButton = New System.Windows.Forms.Button()
        Me.dollarButton = New System.Windows.Forms.Button()
        Me.totallabel = New System.Windows.Forms.Label()
        Me.coinreturnButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dimeButton
        '
        Me.dimeButton.BackgroundImage = Global.vendingmachine.My.Resources.Resources._2023_roosevelt_dime_uncirculated_reverse_768x768
        Me.dimeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.dimeButton.Location = New System.Drawing.Point(310, 306)
        Me.dimeButton.Name = "dimeButton"
        Me.dimeButton.Size = New System.Drawing.Size(146, 142)
        Me.dimeButton.TabIndex = 3
        Me.dimeButton.UseVisualStyleBackColor = True
        '
        'nickelButton
        '
        Me.nickelButton.BackgroundImage = Global.vendingmachine.My.Resources.Resources._2023_jefferson_nickel_uncirculated_reverse_768x768
        Me.nickelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.nickelButton.Location = New System.Drawing.Point(462, 306)
        Me.nickelButton.Name = "nickelButton"
        Me.nickelButton.Size = New System.Drawing.Size(146, 142)
        Me.nickelButton.TabIndex = 2
        Me.nickelButton.UseVisualStyleBackColor = True
        '
        'quarterButton
        '
        Me.quarterButton.BackgroundImage = Global.vendingmachine.My.Resources.Resources._2019_america_the_beautiful_quarters_W
        Me.quarterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.quarterButton.Location = New System.Drawing.Point(158, 306)
        Me.quarterButton.Name = "quarterButton"
        Me.quarterButton.Size = New System.Drawing.Size(146, 142)
        Me.quarterButton.TabIndex = 1
        Me.quarterButton.UseVisualStyleBackColor = True
        '
        'dollarButton
        '
        Me.dollarButton.BackgroundImage = Global.vendingmachine.My.Resources.Resources._2000_native_american_one_dollar_uncirculated_obverse_768x768
        Me.dollarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.dollarButton.Location = New System.Drawing.Point(6, 306)
        Me.dollarButton.Name = "dollarButton"
        Me.dollarButton.Size = New System.Drawing.Size(146, 142)
        Me.dollarButton.TabIndex = 0
        Me.dollarButton.UseVisualStyleBackColor = True
        '
        'totallabel
        '
        Me.totallabel.AutoSize = True
        Me.totallabel.Location = New System.Drawing.Point(12, 287)
        Me.totallabel.Name = "totallabel"
        Me.totallabel.Size = New System.Drawing.Size(48, 16)
        Me.totallabel.TabIndex = 4
        Me.totallabel.Text = "Label1"
        '
        'coinreturnButton
        '
        Me.coinreturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.coinreturnButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.coinreturnButton.Location = New System.Drawing.Point(614, 306)
        Me.coinreturnButton.Name = "coinreturnButton"
        Me.coinreturnButton.Size = New System.Drawing.Size(146, 142)
        Me.coinreturnButton.TabIndex = 5
        Me.coinreturnButton.Text = "Coin Return"
        Me.coinreturnButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.coinreturnButton)
        Me.Controls.Add(Me.totallabel)
        Me.Controls.Add(Me.dimeButton)
        Me.Controls.Add(Me.nickelButton)
        Me.Controls.Add(Me.quarterButton)
        Me.Controls.Add(Me.dollarButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dollarButton As Button
    Friend WithEvents quarterButton As Button
    Friend WithEvents nickelButton As Button
    Friend WithEvents dimeButton As Button
    Friend WithEvents totallabel As Label
    Friend WithEvents coinreturnButton As Button
End Class

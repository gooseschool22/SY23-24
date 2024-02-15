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
        Me.totallabel = New System.Windows.Forms.Label()
        Me.coinreturnButton = New System.Windows.Forms.Button()
        Me.DimePictureBox = New System.Windows.Forms.PictureBox()
        Me.NickelPictureBox = New System.Windows.Forms.PictureBox()
        Me.QuarterPictureBox = New System.Windows.Forms.PictureBox()
        Me.DollarPictureBox = New System.Windows.Forms.PictureBox()
        Me.dimeButton = New System.Windows.Forms.Button()
        Me.nickelButton = New System.Windows.Forms.Button()
        Me.quarterButton = New System.Windows.Forms.Button()
        Me.dollarButton = New System.Windows.Forms.Button()
        Me.BuyButton = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductPictureBox = New System.Windows.Forms.PictureBox()
        Me.ProductControl13 = New vendingmachine.productControl()
        Me.ProductControl14 = New vendingmachine.productControl()
        Me.ProductControl15 = New vendingmachine.productControl()
        Me.ProductControl16 = New vendingmachine.productControl()
        Me.ProductControl12 = New vendingmachine.productControl()
        Me.ProductControl11 = New vendingmachine.productControl()
        Me.ProductControl10 = New vendingmachine.productControl()
        Me.ProductControl9 = New vendingmachine.productControl()
        Me.ProductControl8 = New vendingmachine.productControl()
        Me.ProductControl7 = New vendingmachine.productControl()
        Me.ProductControl6 = New vendingmachine.productControl()
        Me.ProductControl5 = New vendingmachine.productControl()
        Me.ProductControl4 = New vendingmachine.productControl()
        Me.ProductControl3 = New vendingmachine.productControl()
        Me.ProductControl2 = New vendingmachine.productControl()
        Me.ProductControl1 = New vendingmachine.productControl()
        CType(Me.DimePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NickelPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuarterPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DollarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'totallabel
        '
        Me.totallabel.AutoSize = True
        Me.totallabel.Location = New System.Drawing.Point(12, 108)
        Me.totallabel.Name = "totallabel"
        Me.totallabel.Size = New System.Drawing.Size(48, 16)
        Me.totallabel.TabIndex = 4
        Me.totallabel.Text = "Label1"
        '
        'coinreturnButton
        '
        Me.coinreturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.coinreturnButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.coinreturnButton.Location = New System.Drawing.Point(411, 12)
        Me.coinreturnButton.Name = "coinreturnButton"
        Me.coinreturnButton.Size = New System.Drawing.Size(94, 93)
        Me.coinreturnButton.TabIndex = 5
        Me.coinreturnButton.Text = "Coin Return"
        Me.coinreturnButton.UseVisualStyleBackColor = True
        '
        'DimePictureBox
        '
        Me.DimePictureBox.Image = Global.vendingmachine.My.Resources.Resources._2023_roosevelt_dime_uncirculated_reverse_768x768
        Me.DimePictureBox.Location = New System.Drawing.Point(195, 751)
        Me.DimePictureBox.Name = "DimePictureBox"
        Me.DimePictureBox.Size = New System.Drawing.Size(84, 77)
        Me.DimePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DimePictureBox.TabIndex = 9
        Me.DimePictureBox.TabStop = False
        Me.DimePictureBox.Visible = False
        '
        'NickelPictureBox
        '
        Me.NickelPictureBox.Image = Global.vendingmachine.My.Resources.Resources._2023_jefferson_nickel_uncirculated_reverse_768x768
        Me.NickelPictureBox.Location = New System.Drawing.Point(285, 751)
        Me.NickelPictureBox.Name = "NickelPictureBox"
        Me.NickelPictureBox.Size = New System.Drawing.Size(84, 77)
        Me.NickelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NickelPictureBox.TabIndex = 8
        Me.NickelPictureBox.TabStop = False
        Me.NickelPictureBox.Visible = False
        '
        'QuarterPictureBox
        '
        Me.QuarterPictureBox.Image = Global.vendingmachine.My.Resources.Resources._2019_america_the_beautiful_quarters_W
        Me.QuarterPictureBox.Location = New System.Drawing.Point(105, 751)
        Me.QuarterPictureBox.Name = "QuarterPictureBox"
        Me.QuarterPictureBox.Size = New System.Drawing.Size(84, 77)
        Me.QuarterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuarterPictureBox.TabIndex = 7
        Me.QuarterPictureBox.TabStop = False
        Me.QuarterPictureBox.Visible = False
        '
        'DollarPictureBox
        '
        Me.DollarPictureBox.Image = Global.vendingmachine.My.Resources.Resources._2000_native_american_one_dollar_uncirculated_obverse_768x768
        Me.DollarPictureBox.Location = New System.Drawing.Point(15, 751)
        Me.DollarPictureBox.Name = "DollarPictureBox"
        Me.DollarPictureBox.Size = New System.Drawing.Size(84, 77)
        Me.DollarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DollarPictureBox.TabIndex = 6
        Me.DollarPictureBox.TabStop = False
        Me.DollarPictureBox.Visible = False
        '
        'dimeButton
        '
        Me.dimeButton.BackgroundImage = Global.vendingmachine.My.Resources.Resources._2023_roosevelt_dime_uncirculated_reverse_768x768
        Me.dimeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.dimeButton.Location = New System.Drawing.Point(211, 11)
        Me.dimeButton.Name = "dimeButton"
        Me.dimeButton.Size = New System.Drawing.Size(94, 93)
        Me.dimeButton.TabIndex = 3
        Me.dimeButton.UseVisualStyleBackColor = True
        '
        'nickelButton
        '
        Me.nickelButton.BackgroundImage = Global.vendingmachine.My.Resources.Resources._2023_jefferson_nickel_uncirculated_reverse_768x768
        Me.nickelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.nickelButton.Location = New System.Drawing.Point(311, 11)
        Me.nickelButton.Name = "nickelButton"
        Me.nickelButton.Size = New System.Drawing.Size(94, 93)
        Me.nickelButton.TabIndex = 2
        Me.nickelButton.UseVisualStyleBackColor = True
        '
        'quarterButton
        '
        Me.quarterButton.BackgroundImage = Global.vendingmachine.My.Resources.Resources._2019_america_the_beautiful_quarters_W
        Me.quarterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.quarterButton.Location = New System.Drawing.Point(111, 11)
        Me.quarterButton.Name = "quarterButton"
        Me.quarterButton.Size = New System.Drawing.Size(94, 93)
        Me.quarterButton.TabIndex = 1
        Me.quarterButton.UseVisualStyleBackColor = True
        '
        'dollarButton
        '
        Me.dollarButton.BackgroundImage = Global.vendingmachine.My.Resources.Resources._2000_native_american_one_dollar_uncirculated_obverse_768x768
        Me.dollarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.dollarButton.Location = New System.Drawing.Point(11, 12)
        Me.dollarButton.Name = "dollarButton"
        Me.dollarButton.Size = New System.Drawing.Size(94, 93)
        Me.dollarButton.TabIndex = 0
        Me.dollarButton.UseVisualStyleBackColor = True
        '
        'BuyButton
        '
        Me.BuyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BuyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BuyButton.Location = New System.Drawing.Point(511, 12)
        Me.BuyButton.Name = "BuyButton"
        Me.BuyButton.Size = New System.Drawing.Size(94, 93)
        Me.BuyButton.TabIndex = 26
        Me.BuyButton.Text = "Buy"
        Me.BuyButton.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(611, 12)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(187, 22)
        Me.IDTextBox.TabIndex = 27
        '
        'ProductPictureBox
        '
        Me.ProductPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ProductPictureBox.Location = New System.Drawing.Point(636, 595)
        Me.ProductPictureBox.Name = "ProductPictureBox"
        Me.ProductPictureBox.Size = New System.Drawing.Size(162, 145)
        Me.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductPictureBox.TabIndex = 28
        Me.ProductPictureBox.TabStop = False
        '
        'ProductControl13
        '
        Me.ProductControl13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductControl13.count = 5
        Me.ProductControl13.Location = New System.Drawing.Point(12, 595)
        Me.ProductControl13.Name = "ProductControl13"
        Me.ProductControl13.picture = Global.vendingmachine.My.Resources.Resources._75752803746
        Me.ProductControl13.price = New Decimal(New Integer() {275, 0, 0, 131072})
        Me.ProductControl13.productID = "A4"
        Me.ProductControl13.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl13.TabIndex = 25
        '
        'ProductControl14
        '
        Me.ProductControl14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductControl14.count = 5
        Me.ProductControl14.Location = New System.Drawing.Point(168, 595)
        Me.ProductControl14.Name = "ProductControl14"
        Me.ProductControl14.picture = Global.vendingmachine.My.Resources.Resources._81EUE1oZURL__AC_UF1000_1000_QL80_
        Me.ProductControl14.price = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ProductControl14.productID = "B4"
        Me.ProductControl14.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl14.TabIndex = 24
        '
        'ProductControl15
        '
        Me.ProductControl15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductControl15.count = 5
        Me.ProductControl15.Location = New System.Drawing.Point(324, 595)
        Me.ProductControl15.Name = "ProductControl15"
        Me.ProductControl15.picture = Global.vendingmachine.My.Resources.Resources._816HXqv8UiL
        Me.ProductControl15.price = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.ProductControl15.productID = "C4"
        Me.ProductControl15.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl15.TabIndex = 23
        '
        'ProductControl16
        '
        Me.ProductControl16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductControl16.count = 5
        Me.ProductControl16.Location = New System.Drawing.Point(480, 595)
        Me.ProductControl16.Name = "ProductControl16"
        Me.ProductControl16.picture = Global.vendingmachine.My.Resources.Resources.images
        Me.ProductControl16.price = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.ProductControl16.productID = "D4"
        Me.ProductControl16.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl16.TabIndex = 22
        '
        'ProductControl12
        '
        Me.ProductControl12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductControl12.count = 5
        Me.ProductControl12.Location = New System.Drawing.Point(480, 439)
        Me.ProductControl12.Name = "ProductControl12"
        Me.ProductControl12.picture = Global.vendingmachine.My.Resources.Resources.lay_s_baked_original_potato_chips_6_25_oz_bag
        Me.ProductControl12.price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl12.productID = "D3"
        Me.ProductControl12.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl12.TabIndex = 21
        '
        'ProductControl11
        '
        Me.ProductControl11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductControl11.count = 5
        Me.ProductControl11.Location = New System.Drawing.Point(324, 439)
        Me.ProductControl11.Name = "ProductControl11"
        Me.ProductControl11.picture = Global.vendingmachine.My.Resources.Resources._0757528008680_0_A1C1_0600
        Me.ProductControl11.price = New Decimal(New Integer() {250, 0, 0, 131072})
        Me.ProductControl11.productID = "C3"
        Me.ProductControl11.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl11.TabIndex = 20
        '
        'ProductControl10
        '
        Me.ProductControl10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductControl10.count = 5
        Me.ProductControl10.Location = New System.Drawing.Point(168, 439)
        Me.ProductControl10.Name = "ProductControl10"
        Me.ProductControl10.picture = Global.vendingmachine.My.Resources.Resources.download__1_
        Me.ProductControl10.price = New Decimal(New Integer() {115, 0, 0, 131072})
        Me.ProductControl10.productID = "B3"
        Me.ProductControl10.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl10.TabIndex = 19
        '
        'ProductControl9
        '
        Me.ProductControl9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductControl9.count = 5
        Me.ProductControl9.Location = New System.Drawing.Point(11, 439)
        Me.ProductControl9.Name = "ProductControl9"
        Me.ProductControl9.picture = Global.vendingmachine.My.Resources.Resources.download
        Me.ProductControl9.price = New Decimal(New Integer() {245, 0, 0, 131072})
        Me.ProductControl9.productID = "A3"
        Me.ProductControl9.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl9.TabIndex = 18
        '
        'ProductControl8
        '
        Me.ProductControl8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductControl8.count = 5
        Me.ProductControl8.Location = New System.Drawing.Point(480, 283)
        Me.ProductControl8.Name = "ProductControl8"
        Me.ProductControl8.picture = Global.vendingmachine.My.Resources.Resources._51ce_QI5dIL
        Me.ProductControl8.price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl8.productID = "D2"
        Me.ProductControl8.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl8.TabIndex = 17
        '
        'ProductControl7
        '
        Me.ProductControl7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductControl7.count = 5
        Me.ProductControl7.Location = New System.Drawing.Point(323, 283)
        Me.ProductControl7.Name = "ProductControl7"
        Me.ProductControl7.picture = Global.vendingmachine.My.Resources.Resources._91Q_Hif__IL__SL1500_
        Me.ProductControl7.price = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ProductControl7.productID = "C2"
        Me.ProductControl7.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl7.TabIndex = 16
        '
        'ProductControl6
        '
        Me.ProductControl6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductControl6.count = 5
        Me.ProductControl6.Location = New System.Drawing.Point(167, 283)
        Me.ProductControl6.Name = "ProductControl6"
        Me.ProductControl6.picture = Global.vendingmachine.My.Resources.Resources.GUEST_ad5ad35a_2fe7_4209_ae0d_7f71fa2d8329
        Me.ProductControl6.price = New Decimal(New Integer() {225, 0, 0, 131072})
        Me.ProductControl6.productID = "B2"
        Me.ProductControl6.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl6.TabIndex = 15
        '
        'ProductControl5
        '
        Me.ProductControl5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductControl5.count = 5
        Me.ProductControl5.Location = New System.Drawing.Point(11, 283)
        Me.ProductControl5.Name = "ProductControl5"
        Me.ProductControl5.picture = Global.vendingmachine.My.Resources.Resources._91NjwbVi0_L__AC_UF1000_1000_QL80_
        Me.ProductControl5.price = New Decimal(New Integer() {125, 0, 0, 131072})
        Me.ProductControl5.productID = "A2"
        Me.ProductControl5.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl5.TabIndex = 14
        '
        'ProductControl4
        '
        Me.ProductControl4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductControl4.count = 5
        Me.ProductControl4.Location = New System.Drawing.Point(480, 127)
        Me.ProductControl4.Name = "ProductControl4"
        Me.ProductControl4.picture = Global.vendingmachine.My.Resources.Resources._812tZPyk0fL__AC_UF894_1000_QL80_
        Me.ProductControl4.price = New Decimal(New Integer() {215, 0, 0, 131072})
        Me.ProductControl4.productID = "D1"
        Me.ProductControl4.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl4.TabIndex = 13
        '
        'ProductControl3
        '
        Me.ProductControl3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductControl3.count = 5
        Me.ProductControl3.Location = New System.Drawing.Point(324, 127)
        Me.ProductControl3.Name = "ProductControl3"
        Me.ProductControl3.picture = Global.vendingmachine.My.Resources.Resources._81iUuyr2R7L
        Me.ProductControl3.price = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ProductControl3.productID = "C1"
        Me.ProductControl3.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl3.TabIndex = 12
        '
        'ProductControl2
        '
        Me.ProductControl2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductControl2.count = 5
        Me.ProductControl2.Location = New System.Drawing.Point(168, 127)
        Me.ProductControl2.Name = "ProductControl2"
        Me.ProductControl2.picture = Global.vendingmachine.My.Resources.Resources._61HW2ONPf_L__AC_UF894_1000_QL80_
        Me.ProductControl2.price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl2.productID = "B1"
        Me.ProductControl2.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl2.TabIndex = 11
        '
        'ProductControl1
        '
        Me.ProductControl1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ProductControl1.count = 5
        Me.ProductControl1.Location = New System.Drawing.Point(12, 127)
        Me.ProductControl1.Name = "ProductControl1"
        Me.ProductControl1.picture = Global.vendingmachine.My.Resources.Resources._91M5DIRwhoL__AC_UF894_1000_QL80_
        Me.ProductControl1.price = New Decimal(New Integer() {115, 0, 0, 131072})
        Me.ProductControl1.productID = "A1"
        Me.ProductControl1.Size = New System.Drawing.Size(150, 150)
        Me.ProductControl1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 832)
        Me.Controls.Add(Me.ProductPictureBox)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.BuyButton)
        Me.Controls.Add(Me.ProductControl13)
        Me.Controls.Add(Me.ProductControl14)
        Me.Controls.Add(Me.ProductControl15)
        Me.Controls.Add(Me.ProductControl16)
        Me.Controls.Add(Me.ProductControl12)
        Me.Controls.Add(Me.ProductControl11)
        Me.Controls.Add(Me.ProductControl10)
        Me.Controls.Add(Me.ProductControl9)
        Me.Controls.Add(Me.ProductControl8)
        Me.Controls.Add(Me.ProductControl7)
        Me.Controls.Add(Me.ProductControl6)
        Me.Controls.Add(Me.ProductControl5)
        Me.Controls.Add(Me.ProductControl4)
        Me.Controls.Add(Me.ProductControl3)
        Me.Controls.Add(Me.ProductControl2)
        Me.Controls.Add(Me.ProductControl1)
        Me.Controls.Add(Me.DimePictureBox)
        Me.Controls.Add(Me.NickelPictureBox)
        Me.Controls.Add(Me.QuarterPictureBox)
        Me.Controls.Add(Me.DollarPictureBox)
        Me.Controls.Add(Me.coinreturnButton)
        Me.Controls.Add(Me.totallabel)
        Me.Controls.Add(Me.dimeButton)
        Me.Controls.Add(Me.nickelButton)
        Me.Controls.Add(Me.quarterButton)
        Me.Controls.Add(Me.dollarButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DimePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NickelPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuarterPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DollarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dollarButton As Button
    Friend WithEvents quarterButton As Button
    Friend WithEvents nickelButton As Button
    Friend WithEvents dimeButton As Button
    Friend WithEvents totallabel As Label
    Friend WithEvents coinreturnButton As Button
    Friend WithEvents DollarPictureBox As PictureBox
    Friend WithEvents QuarterPictureBox As PictureBox
    Friend WithEvents NickelPictureBox As PictureBox
    Friend WithEvents DimePictureBox As PictureBox
    Friend WithEvents ProductControl1 As productControl
    Friend WithEvents ProductControl2 As productControl
    Friend WithEvents ProductControl3 As productControl
    Friend WithEvents ProductControl4 As productControl
    Friend WithEvents ProductControl5 As productControl
    Friend WithEvents ProductControl6 As productControl
    Friend WithEvents ProductControl7 As productControl
    Friend WithEvents ProductControl8 As productControl
    Friend WithEvents ProductControl9 As productControl
    Friend WithEvents ProductControl10 As productControl
    Friend WithEvents ProductControl11 As productControl
    Friend WithEvents ProductControl12 As productControl
    Friend WithEvents ProductControl13 As productControl
    Friend WithEvents ProductControl14 As productControl
    Friend WithEvents ProductControl15 As productControl
    Friend WithEvents ProductControl16 As productControl
    Friend WithEvents BuyButton As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents ProductPictureBox As PictureBox
End Class

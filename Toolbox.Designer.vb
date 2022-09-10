<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Toolbox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Toolbox))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tmrHold = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.chkPin = New System.Windows.Forms.CheckBox()
        Me.chkClose = New System.Windows.Forms.Button()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblTB = New System.Windows.Forms.Label()
        Me.pnlTitle.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "pressedpin.ico")
        Me.ImageList1.Images.SetKeyName(1, "unpressedpin.ico")
        '
        'tmrHold
        '
        Me.tmrHold.Interval = 3000
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Toolbox"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrDelay
        '
        Me.tmrDelay.Interval = 10
        '
        'pnlMain
        '
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(25, 19)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(174, 337)
        Me.pnlMain.TabIndex = 5
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.pnlTitle.Controls.Add(Me.Label1)
        Me.pnlTitle.Controls.Add(Me.chkPin)
        Me.pnlTitle.Controls.Add(Me.chkClose)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(25, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(174, 19)
        Me.pnlTitle.TabIndex = 4
        '
        'chkPin
        '
        Me.chkPin.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkPin.Checked = True
        Me.chkPin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPin.Dock = System.Windows.Forms.DockStyle.Right
        Me.chkPin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkPin.ImageIndex = 0
        Me.chkPin.ImageList = Me.ImageList1
        Me.chkPin.Location = New System.Drawing.Point(136, 0)
        Me.chkPin.Name = "chkPin"
        Me.chkPin.Size = New System.Drawing.Size(19, 19)
        Me.chkPin.TabIndex = 1
        Me.chkPin.UseVisualStyleBackColor = True
        '
        'chkClose
        '
        Me.chkClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.chkClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkClose.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkClose.ForeColor = System.Drawing.Color.White
        Me.chkClose.ImageList = Me.ImageList1
        Me.chkClose.Location = New System.Drawing.Point(155, 0)
        Me.chkClose.Name = "chkClose"
        Me.chkClose.Size = New System.Drawing.Size(19, 19)
        Me.chkClose.TabIndex = 5
        Me.chkClose.Text = "X"
        Me.chkClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chkClose.UseVisualStyleBackColor = True
        '
        'pnlLeft
        '
        Me.pnlLeft.Controls.Add(Me.lblTB)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(25, 356)
        Me.pnlLeft.TabIndex = 3
        '
        'lblTB
        '
        Me.lblTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTB.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTB.Image = Global.VijaySridhara.Controls.My.Resources.Resources.lefttoolbox1
        Me.lblTB.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblTB.Location = New System.Drawing.Point(0, 0)
        Me.lblTB.Name = "lblTB"
        Me.lblTB.Size = New System.Drawing.Size(25, 100)
        Me.lblTB.TabIndex = 0
        '
        'Toolbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.pnlLeft)
        Me.Name = "Toolbox"
        Me.Size = New System.Drawing.Size(199, 356)
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents tmrHold As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tmrDelay As System.Windows.Forms.Timer
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents chkPin As System.Windows.Forms.CheckBox
    Friend WithEvents lblTB As System.Windows.Forms.Label
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents chkClose As System.Windows.Forms.Button

End Class

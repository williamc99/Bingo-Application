<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadingScreen
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
        Me.components = New System.ComponentModel.Container()
        Me.prgbLoading = New System.Windows.Forms.ProgressBar()
        Me.timLoading = New System.Windows.Forms.Timer(Me.components)
        Me.btnVIPEntrance = New System.Windows.Forms.Button()
        Me.picBar = New System.Windows.Forms.PictureBox()
        CType(Me.picBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prgbLoading
        '
        Me.prgbLoading.Location = New System.Drawing.Point(12, 422)
        Me.prgbLoading.Name = "prgbLoading"
        Me.prgbLoading.Size = New System.Drawing.Size(817, 39)
        Me.prgbLoading.TabIndex = 2
        '
        'timLoading
        '
        Me.timLoading.Interval = 200
        '
        'btnVIPEntrance
        '
        Me.btnVIPEntrance.BackColor = System.Drawing.Color.Black
        Me.btnVIPEntrance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVIPEntrance.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnVIPEntrance.FlatAppearance.BorderSize = 5
        Me.btnVIPEntrance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVIPEntrance.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVIPEntrance.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVIPEntrance.Location = New System.Drawing.Point(653, 364)
        Me.btnVIPEntrance.Name = "btnVIPEntrance"
        Me.btnVIPEntrance.Size = New System.Drawing.Size(176, 52)
        Me.btnVIPEntrance.TabIndex = 3
        Me.btnVIPEntrance.Text = "VIP Entrance"
        Me.btnVIPEntrance.UseVisualStyleBackColor = False
        '
        'picBar
        '
        Me.picBar.Image = Global.ChiuW_ASSN01_Bingo.My.Resources.Resources.pub_fig
        Me.picBar.Location = New System.Drawing.Point(-1, -6)
        Me.picBar.Name = "picBar"
        Me.picBar.Size = New System.Drawing.Size(842, 484)
        Me.picBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBar.TabIndex = 1
        Me.picBar.TabStop = False
        '
        'frmLoadingScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(841, 473)
        Me.Controls.Add(Me.btnVIPEntrance)
        Me.Controls.Add(Me.prgbLoading)
        Me.Controls.Add(Me.picBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLoadingScreen"
        Me.Text = "Walking Into Bar"
        CType(Me.picBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picBar As PictureBox
    Friend WithEvents prgbLoading As ProgressBar
    Friend WithEvents timLoading As Timer
    Friend WithEvents btnVIPEntrance As Button
End Class

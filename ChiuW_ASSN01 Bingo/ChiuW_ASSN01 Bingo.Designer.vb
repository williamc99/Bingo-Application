<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.picLateNight = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCallingCard = New System.Windows.Forms.Button()
        Me.btnFullBingo = New System.Windows.Forms.Button()
        Me.btnBingo = New System.Windows.Forms.Button()
        Me.picBingo = New System.Windows.Forms.PictureBox()
        CType(Me.picLateNight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBingo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLateNight
        '
        Me.picLateNight.BackColor = System.Drawing.Color.Transparent
        Me.picLateNight.BackgroundImage = Global.ChiuW_ASSN01_Bingo.My.Resources.Resources.neonbingo
        Me.picLateNight.Image = Global.ChiuW_ASSN01_Bingo.My.Resources.Resources.neonlatenight
        Me.picLateNight.Location = New System.Drawing.Point(-20, -11)
        Me.picLateNight.Name = "picLateNight"
        Me.picLateNight.Size = New System.Drawing.Size(365, 94)
        Me.picLateNight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLateNight.TabIndex = 5
        Me.picLateNight.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue
        Me.btnExit.FlatAppearance.BorderSize = 3
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.SlateBlue
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnExit.Location = New System.Drawing.Point(484, 331)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(132, 50)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Walk Out"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCallingCard
        '
        Me.btnCallingCard.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnCallingCard.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue
        Me.btnCallingCard.FlatAppearance.BorderSize = 3
        Me.btnCallingCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCallingCard.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCallingCard.ForeColor = System.Drawing.Color.SlateBlue
        Me.btnCallingCard.Image = CType(resources.GetObject("btnCallingCard.Image"), System.Drawing.Image)
        Me.btnCallingCard.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCallingCard.Location = New System.Drawing.Point(329, 331)
        Me.btnCallingCard.Name = "btnCallingCard"
        Me.btnCallingCard.Size = New System.Drawing.Size(132, 50)
        Me.btnCallingCard.TabIndex = 2
        Me.btnCallingCard.Text = "Calling Card"
        Me.btnCallingCard.UseVisualStyleBackColor = False
        '
        'btnFullBingo
        '
        Me.btnFullBingo.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnFullBingo.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue
        Me.btnFullBingo.FlatAppearance.BorderSize = 3
        Me.btnFullBingo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFullBingo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFullBingo.ForeColor = System.Drawing.Color.SlateBlue
        Me.btnFullBingo.Image = CType(resources.GetObject("btnFullBingo.Image"), System.Drawing.Image)
        Me.btnFullBingo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFullBingo.Location = New System.Drawing.Point(160, 331)
        Me.btnFullBingo.Name = "btnFullBingo"
        Me.btnFullBingo.Size = New System.Drawing.Size(149, 50)
        Me.btnFullBingo.TabIndex = 1
        Me.btnFullBingo.Text = "Play Full Bingo"
        Me.btnFullBingo.UseVisualStyleBackColor = False
        '
        'btnBingo
        '
        Me.btnBingo.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnBingo.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue
        Me.btnBingo.FlatAppearance.BorderSize = 3
        Me.btnBingo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBingo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBingo.ForeColor = System.Drawing.Color.SlateBlue
        Me.btnBingo.Image = Global.ChiuW_ASSN01_Bingo.My.Resources.Resources.neonbingo
        Me.btnBingo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnBingo.Location = New System.Drawing.Point(12, 330)
        Me.btnBingo.Name = "btnBingo"
        Me.btnBingo.Size = New System.Drawing.Size(132, 50)
        Me.btnBingo.TabIndex = 0
        Me.btnBingo.Text = "Play Bingo"
        Me.btnBingo.UseVisualStyleBackColor = False
        '
        'picBingo
        '
        Me.picBingo.Image = Global.ChiuW_ASSN01_Bingo.My.Resources.Resources.neonbingo
        Me.picBingo.Location = New System.Drawing.Point(2, -85)
        Me.picBingo.Name = "picBingo"
        Me.picBingo.Size = New System.Drawing.Size(625, 440)
        Me.picBingo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBingo.TabIndex = 4
        Me.picBingo.TabStop = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(628, 392)
        Me.Controls.Add(Me.picLateNight)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCallingCard)
        Me.Controls.Add(Me.btnFullBingo)
        Me.Controls.Add(Me.btnBingo)
        Me.Controls.Add(Me.picBingo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainMenu"
        Me.Text = "Main Menu"
        CType(Me.picLateNight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBingo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBingo As Button
    Friend WithEvents btnFullBingo As Button
    Friend WithEvents btnCallingCard As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picLateNight As PictureBox
    Friend WithEvents picBingo As PictureBox
End Class

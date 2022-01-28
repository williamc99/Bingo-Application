
'***********************************************************************
'	PROGRAMME NAME	    :	Bingo Assignment: Loading Screen
'
'	PROGRAMME OUTLINE	:	This programme will show a loading
'                           screen with a GIF.  The user
'                           may click the VIP button to skip the loading screen.
'
'	PROGRAMMER		    :	William Chiu
'
'	DATE				:	Oct 25, 2018
'
'***********************************************************************


Public Class frmLoadingScreen
    Private Sub frmLoadingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timLoading.Enabled = True
    End Sub

    Private Sub timLoading_Tick(sender As Object, e As EventArgs) Handles timLoading.Tick
        prgbLoading.Value = prgbLoading.Value + 1
        If prgbLoading.Value = 100 Then
            frmMainMenu.Show()
            timLoading.Enabled = False
            Me.Close()
        End If
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnVIPEntrance.Click
        frmMainMenu.Show()
        Me.Close()
        MessageBox.Show("You have skipped the line!", "VIP Entrance", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
End Class
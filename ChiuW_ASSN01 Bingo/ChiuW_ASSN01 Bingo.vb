
'***********************************************************************
'	PROGRAMME NAME	    :	Bingo Assignment
'
'	PROGRAMME OUTLINE	:	This programme allows the user to 
'                           select either Bingo, Full Bingo or Calling Card.
'                           (More info on each form)
'
'	PROGRAMMER		    :	William Chiu
'
'	DATE				:	Oct 25, 2018
'
'***********************************************************************

Public Class frmMainMenu
    Private Sub btnBingo_Click(sender As Object, e As EventArgs) Handles btnBingo.Click
        frmBingoCard.Show()
    End Sub

    Private Sub btnCallingCard_Click(sender As Object, e As EventArgs) Handles btnCallingCard.Click
        frmCallingCard.Show()
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Hide()
        frmLoadingScreen.Show()
    End Sub

    Private Sub btnFullBingo_Click(sender As Object, e As EventArgs) Handles btnFullBingo.Click
        frmBingoCardFull.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Come back soon!", "Goodbye!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Application.Exit()
    End Sub
End Class

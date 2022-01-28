
'***********************************************************************
'	PROGRAMME NAME	    :	Bingo Assignment: Bingo Card
'
'	PROGRAMME OUTLINE	:	This form allows the user click the generate button,
'                           which will generate a random number from 1-75.  Duplicate
'                           numbers would be omitted and a different number
'                            would be chosen.
'
'	PROGRAMMER		    :	William Chiu
'
'	DATE				:	Oct 25, 2018
'
'***********************************************************************

Public Class frmCallingCard
    Dim buttonCount As Integer

    Private Sub frmCallingCard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim btnNumbers() As Button = {btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20, btn21, btn22, btn23, btn24, btn25, btn26, btn27, btn28, btn29, btn30, btn31, btn32, btn33, btn34, btn35, btn36, btn37, btn38, btn39, btn40, btn41, btn42, btn43, btn44, btn45, btn46, btn47, btn48, btn49, btn50, btn51, btn52, btn53, btn54, btn55, btn56, btn57, btn58, btn59, btn60, btn61, btn62, btn63, btn64, btn65, btn66, btn67, btn68, btn69, btn70, btn71, btn72, btn73, btn74, btn75}

        For index = 1 To 75
            btnNumbers(index).Text = index
            btnNumbers(index).ForeColor = Color.White
            btnNumbers(index).BackColor = Color.Black
            btnNumbers(index).Font = New Font("Microsoft Sans Serif", 16)
        Next

        btn0.Hide()
    End Sub

    Private Sub btnNewNumber_Click(sender As Object, e As EventArgs) Handles btnNewNumber.Click
        Dim btnNumbers() As Button = {btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20, btn21, btn22, btn23, btn24, btn25, btn26, btn27, btn28, btn29, btn30, btn31, btn32, btn33, btn34, btn35, btn36, btn37, btn38, btn39, btn40, btn41, btn42, btn43, btn44, btn45, btn46, btn47, btn48, btn49, btn50, btn51, btn52, btn53, btn54, btn55, btn56, btn57, btn58, btn59, btn60, btn61, btn62, btn63, btn64, btn65, btn66, btn67, btn68, btn69, btn70, btn71, btn72, btn73, btn74, btn75}
        Dim rand As New Random
        Dim randomNum As Integer
        Static buttonNum(76) As Integer
        Static index As Integer


        Do
            randomNum = rand.Next(1, 76)
            index += 1

            If buttonNum.Contains(randomNum) Then
                index -= 1
            Else

                buttonNum(index) = randomNum

                btnNumbers(randomNum).BackColor = Color.White
                btnNumbers(randomNum).FlatAppearance.BorderColor = Color.DeepSkyBlue
                btnNumbers(randomNum).Text = buttonNum(index)
                btnNumbers(randomNum).ForeColor = Color.DeepSkyBlue
                buttonCount += 1

                Select Case randomNum
                    Case 1 To 15
                        btnDisplay.Text = "Current: " & "B " & randomNum
                    Case 16 To 30
                        btnDisplay.Text = "Current: " & "I " & randomNum
                    Case 31 To 45
                        btnDisplay.Text = "Current: " & "N " & randomNum
                    Case 46 To 60
                        btnDisplay.Text = "Current: " & "G " & randomNum
                    Case 61 To 75
                        btnDisplay.Text = "Current: " & "O " & randomNum
                End Select
                Exit Do
            End If
        Loop


        If buttonCount >= 75 Then
            MessageBox.Show("All Numbers Have Been Called!", "All Called!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnNewNumber.Enabled = False
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim btnNumbers() As Button = {btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20, btn21, btn22, btn23, btn24, btn25, btn26, btn27, btn28, btn29, btn30, btn31, btn32, btn33, btn34, btn35, btn36, btn37, btn38, btn39, btn40, btn41, btn42, btn43, btn44, btn45, btn46, btn47, btn48, btn49, btn50, btn51, btn52, btn53, btn54, btn55, btn56, btn57, btn58, btn59, btn60, btn61, btn62, btn63, btn64, btn65, btn66, btn67, btn68, btn69, btn70, btn71, btn72, btn73, btn74, btn75}

        buttonCount = 0
        btnNewNumber.Enabled = True
        btnDisplay.Text = "Current: None"

        For index = 1 To 75
            btnNumbers(index).Text = index
            btnNumbers(index).ForeColor = Color.White
            btnNumbers(index).BackColor = Color.Black
            btnNumbers(index).Font = New Font("Microsoft Sans Serif", 16)
            btnNumbers(index).FlatAppearance.BorderColor = Color.Red
        Next

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub
End Class
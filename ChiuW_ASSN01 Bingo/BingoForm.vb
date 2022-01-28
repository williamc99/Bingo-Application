
'***********************************************************************
'	PROGRAMME NAME	    :	Bingo Assignment: Bingo Card
'
'	PROGRAMME OUTLINE	:	This form allows the user to generate bingo cards and play bingo.
'                           When bingo is achieved, it will show a messagebox and will prompt
'                           the user to clear the card and play again.
'
'	PROGRAMMER		    :	William Chiu
'
'	DATE				:	Oct 25, 2018
'
'***********************************************************************

Public Class frmBingoCard
    Private Sub btnNewCard_Click(sender As Object, e As EventArgs) Handles btnNewCard.Click

        Dim rand As New Random
        Dim btnB() As Button = {btnB1, btnB2, btnB3, btnB4, btnB5}
        Dim btnI() As Button = {btnI1, btnI2, btnI3, btnI4, btnI5}
        Dim btnN() As Button = {btnN1, btnN2, btnN4, btnN5}
        Dim btnG() As Button = {btnG1, btnG2, btnG3, btnG4, btnG5}
        Dim btnO() As Button = {btnO1, btnO2, btnO3, btnO4, btnO5}
        Dim bNum(4) As Integer
        Dim iNum(4) As Integer
        Dim nNum(3) As Integer
        Dim gNum(4) As Integer
        Dim oNum(4) As Integer
        Dim randomNumB, randomNumI, randomNumN, randomNumG, randomNumO As Integer


        randomNumB = rand.Next(1, 16)
        bNum(0) = randomNumB
        btnB(0).Text = bNum(0)

        For index = 1 To bNum.Length - 1

            randomNumB = rand.Next(1, 16)

            If Not bNum.Contains(randomNumB) Then
                bNum(index) = randomNumB
                btnB(index).Text = bNum(index)
            Else
                index -= 1
            End If
        Next


        randomNumI = rand.Next(16, 31)
        iNum(0) = randomNumI
        btnI(0).Text = iNum(0)

        For index = 1 To iNum.Length - 1

            randomNumI = rand.Next(16, 31)

            If Not iNum.Contains(randomNumI) Then
                iNum(index) = randomNumI
                btnI(index).Text = iNum(index)
            Else
                index -= 1
            End If
        Next



        randomNumN = rand.Next(31, 46)
        nNum(0) = randomNumN
        btnN(0).Text = nNum(0)

        For index = 1 To nNum.Length - 1

            randomNumN = rand.Next(31, 46)

            If Not nNum.Contains(randomNumN) Then
                nNum(index) = randomNumN
                btnN(index).Text = nNum(index)
            Else
                index -= 1
            End If
        Next


        randomNumG = rand.Next(46, 61)
        gNum(0) = randomNumG
        btnG(0).Text = gNum(0)


        For index = 1 To gNum.Length - 1

            randomNumG = rand.Next(46, 61)

            If Not gNum.Contains(randomNumG) Then
                gNum(index) = randomNumG
                btnG(index).Text = gNum(index)
            Else
                index -= 1
            End If
        Next


        randomNumO = rand.Next(61, 76)
        oNum(0) = randomNumO
        btnO(0).Text = oNum(0)

        For index = 1 To oNum.Length - 1

            randomNumO = rand.Next(61, 76)

            If Not oNum.Contains(randomNumO) Then
                oNum(index) = randomNumO
                btnO(index).Text = oNum(index)
            Else
                index -= 1
            End If
        Next


    End Sub

    Private Sub btnB1_Click(sender As Object, e As EventArgs) Handles btnB1.Click, btnB2.Click, btnB3.Click, btnB4.Click, btnB5.Click, btnI1.Click, btnI2.Click, btnI3.Click, btnI4.Click, btnI5.Click, btnN1.Click, btnN2.Click, btnN3Free.Click, btnN4.Click, btnN5.Click, btnG1.Click, btnG2.Click, btnG3.Click, btnG4.Click, btnG5.Click, btnO1.Click, btnO2.Click, btnO3.Click, btnO4.Click, btnO5.Click
        Dim btnSender As Button = sender

        If btnSender.BackColor = Color.Black Then
            MessageBox.Show("This number is already marked.", "Play by the Rules!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf btnSender.Text = Nothing Then
            MessageBox.Show("Please Click New Card First!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            btnSender.FlatAppearance.BorderColor = Color.Red
            btnSender.BackColor = Color.Black
            btnSender.ForeColor = Color.Red
        End If


        '*********************************************************Bingo Conditions********************************************************************************

        '                                                             Vertical

        If btnB1.BackColor = Color.Black And btnB2.BackColor = Color.Black And btnB3.BackColor = Color.Black And btnB4.BackColor = Color.Black And btnB5.BackColor = Color.Black Then
            MessageBox.Show("You've gotten Bingo!", "BINGO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnNewCard.Enabled = False
        End If

        If btnI1.BackColor = Color.Black And btnI2.BackColor = Color.Black And btnI3.BackColor = Color.Black And btnI4.BackColor = Color.Black And btnI5.BackColor = Color.Black Then
            MessageBox.Show("You've gotten Bingo!", "BINGO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnNewCard.Enabled = False
        End If

        If btnN1.BackColor = Color.Black And btnN2.BackColor = Color.Black And btnN3Free.BackColor = Color.Black And btnN4.BackColor = Color.Black And btnN5.BackColor = Color.Black Then
            MessageBox.Show("You've gotten Bingo!", "BINGO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnNewCard.Enabled = False
        End If

        If btnG1.BackColor = Color.Black And btnG2.BackColor = Color.Black And btnG3.BackColor = Color.Black And btnG4.BackColor = Color.Black And btnG5.BackColor = Color.Black Then
            MessageBox.Show("You've gotten Bingo!", "BINGO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnNewCard.Enabled = False
        End If

        If btnO1.BackColor = Color.Black And btnO2.BackColor = Color.Black And btnO3.BackColor = Color.Black And btnO4.BackColor = Color.Black And btnO5.BackColor = Color.Black Then
            MessageBox.Show("You've gotten Bingo!", "BINGO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnNewCard.Enabled = False
        End If

        '                                                         Horizontal

        If btnB1.BackColor = Color.Black And btnI1.BackColor = Color.Black And btnN1.BackColor = Color.Black And btnG1.BackColor = Color.Black And btnO1.BackColor = Color.Black Then
            MessageBox.Show("You've gotten Bingo!", "BINGO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnNewCard.Enabled = False
        End If

        If btnB2.BackColor = Color.Black And btnI2.BackColor = Color.Black And btnN2.BackColor = Color.Black And btnG2.BackColor = Color.Black And btnO2.BackColor = Color.Black Then
            MessageBox.Show("You've gotten Bingo!", "BINGO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnNewCard.Enabled = False
        End If

        If btnB3.BackColor = Color.Black And btnI3.BackColor = Color.Black And btnN3Free.BackColor = Color.Black And btnG3.BackColor = Color.Black And btnO3.BackColor = Color.Black Then
            MessageBox.Show("You've gotten Bingo!", "BINGO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnNewCard.Enabled = False
        End If

        If btnB4.BackColor = Color.Black And btnI4.BackColor = Color.Black And btnN4.BackColor = Color.Black And btnG4.BackColor = Color.Black And btnO4.BackColor = Color.Black Then
            MessageBox.Show("You've gotten Bingo!", "BINGO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnNewCard.Enabled = False
        End If

        If btnB5.BackColor = Color.Black And btnI5.BackColor = Color.Black And btnN5.BackColor = Color.Black And btnG5.BackColor = Color.Black And btnO5.BackColor = Color.Black Then
            MessageBox.Show("You've gotten Bingo!", "BINGO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnNewCard.Enabled = False
        End If

        '                                                         Diagonal

        If btnB1.BackColor = Color.Black And btnI2.BackColor = Color.Black And btnN3Free.BackColor = Color.Black And btnG4.BackColor = Color.Black And btnO5.BackColor = Color.Black Then
            MessageBox.Show("You've gotten Bingo!", "BINGO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnNewCard.Enabled = False
        End If

        If btnB5.BackColor = Color.Black And btnI4.BackColor = Color.Black And btnN3Free.BackColor = Color.Black And btnG2.BackColor = Color.Black And btnO1.BackColor = Color.Black Then
            MessageBox.Show("You've gotten Bingo!", "BINGO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnNewCard.Enabled = False
        End If
    End Sub

    Private Sub btnClearCard_Click(sender As Object, e As EventArgs) Handles btnClearCard.Click
        Dim btnAll() As Button = {btnB1, btnB2, btnB3, btnB4, btnB5, btnI1, btnI2, btnI3, btnI4, btnI5, btnN1, btnN2, btnN4, btnN5, btnG1, btnG2, btnG3, btnG4, btnG5, btnO1, btnO2, btnO3, btnO4, btnO5}

        btnNewCard.Enabled = True

        For index = 0 To btnAll.Length - 1
            btnAll(index).Text = Nothing
            btnAll(index).BackColor = Color.Transparent
            btnAll(index).FlatAppearance.BorderColor = Color.Black
            btnAll(index).ForeColor = Color.White
        Next

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class
Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears any entry and sets default choice to cheapest option
        txtGrpSize.Clear()
        lblTotalCost.Text = ""
        radAutographs.Checked = False
        radSuperhero.Checked = False
        radConvention.Checked = True
        txtGrpSize.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clears all entries and sets default to cheapest option(same as btnClear)
        btnClear.PerformClick()
        txtGrpSize.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Calculates the total cost of the convention

        Dim intGrpSize As Integer = 0
        Dim decRegistration As Decimal
        Dim decTotalCost As Decimal
        Dim cdecSuperHero As Decimal = 380D
        Dim cdecAutograph As Decimal = 275D
        Dim cdecConvenetion As Decimal = 209D

        'Determines if the text entry is a number
        If IsNumeric(txtGrpSize.Text) Then
            intGrpSize = Convert.ToInt32(txtGrpSize.Text)

            'Determines if the group size is valid
            If intGrpSize >= 1 And intGrpSize <= 20 Then

                'Series of If's to set the cost of a single registration
                If radSuperhero.Checked Then
                    decRegistration = cdecSuperHero
                ElseIf radAutographs.Checked Then
                    decRegistration = cdecAutograph
                ElseIf radConvention.Checked Then
                    decRegistration = cdecConvenetion
                End If

                'Calculate the total
                decTotalCost = decRegistration * intGrpSize
                lblTotalCost.Text = decTotalCost.ToString("C")
            Else
                'Entry must be outside of the given range to reach this
                MsgBox("Enter a number between 1 and 20",, "Invalid Group Size")
            End If
        Else
            'Entry must be non-numeric to reach this
            MsgBox("Group Size must be a number and between 1 and 20",, "Invalid Entry")
        End If
    End Sub
End Class

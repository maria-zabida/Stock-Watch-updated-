Public Class Form1
    'Maria Zabida Hussain 
    'Visual Studio 
    'Stock Watch
    '09/24/2025

    'Color change and back Stock Name text box 
    Private Sub tbName_Enter(sender As Object, e As EventArgs) Handles tbName.Enter
        tbName.ForeColor = Color.DarkGoldenrod
    End Sub

    Private Sub tbName_Leaves(sender As Object, e As EventArgs) Handles tbName.Leave
        tbName.ForeColor = Color.DarkGray
    End Sub

    'Color change and back Current Price text box
    Private Sub tbCurrent_Enter(sender As Object, e As EventArgs) Handles tbCurrent.Enter
        tbCurrent.ForeColor = Color.DarkGoldenrod
    End Sub

    Private Sub tbCurrent_Leaves(sender As Object, e As EventArgs) Handles tbCurrent.Leave
        tbCurrent.ForeColor = Color.DarkGray
    End Sub

    'Color change and back Original Price text box 
    Private Sub tbOriginal_Enter(sender As Object, e As EventArgs) Handles tbOriginal.Enter
        tbOriginal.ForeColor = Color.DarkGoldenrod
    End Sub

    Private Sub tbOriginal_Leaves(sender As Object, e As EventArgs) Handles tbOriginal.Leave
        tbOriginal.ForeColor = Color.DarkGray
    End Sub

    'Color change and back Number Shares text box 
    Private Sub tbShares_Enter(sender As Object, e As EventArgs) Handles tbShares.Enter
        tbShares.ForeColor = Color.DarkGoldenrod
    End Sub

    Private Sub tbShares_Leaves(sender As Object, e As EventArgs) Handles tbShares.Leave
        tbShares.ForeColor = Color.DarkGray
    End Sub


    ' Working reset button 
    Private Sub lblReset_MouseClick(sender As Object, e As MouseEventArgs) Handles lblReset.MouseClick
        tbShares.Clear()
        tbOriginal.Clear()
        tbCurrent.Clear()
        tbName.Clear()

    End Sub


    'Calculator for net cost
    Private Sub btnCalc_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCalc.MouseClick

        Dim current As String 'turns current price to a variable
        current = CDbl(tbCurrent.Text)

        Dim org As String 'turns original price to a variable
        org = CDbl(tbOriginal.Text)

        Dim share As String 'turns share num to a variable 
        share = CDbl(tbShares.Text)



        lblNet.Text = (current - org) * share 'calcutaions 

        If (((current - org) * share) > 0) Then 'color changes base on output 
            lblNet.ForeColor = Color.Green

        Else
            lblNet.ForeColor = Color.Red
        End If

    End Sub

    Private Sub lblStkName_Click(sender As Object, e As EventArgs)

    End Sub
End Class

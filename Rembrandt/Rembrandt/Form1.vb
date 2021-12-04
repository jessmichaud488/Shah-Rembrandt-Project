Public Class frmMain
    Private Sub btnCalc_Click(ByVal sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim blnEmployeeFullStatus As Boolean = False
        Dim blnCarType As Boolean = False
        Dim intCarsSold As Integer
        Dim blnNumReq As Boolean
        Dim strEmployeeID As String

        Dim dblNum1, dblNum2, dblNum3, dblNum4 As Double
        Static dblTotal1, dblTotal2, dblTotal3, dblTotal4 As Double

        strEmployeeID = txtIDBox.Text
        blnNumReq = Integer.TryParse(txtSoldBox.Text, intCarsSold)

        If blnNumReq <> True Then
            MessageBox.Show("Please enter the units sold as a number.",
                            CStr(MessageBoxButtons.OK))
        Else

            If strEmployeeID Like "###[Nn|Uu][Ff|Pp]" Then
                If strEmployeeID.Contains("N") Or strEmployeeID.Contains("n") Then
                    blnCarType = True

                    Double.TryParse(txtSoldBox.Text, dblNum1)
                    dblTotal1 += dblNum1
                    txtNewCarBox.Text = dblTotal1.ToString

                Else
                    Double.TryParse(txtSoldBox.Text, dblNum2)
                    dblTotal2 += dblNum2
                    txtUsedCarBox.Text = dblTotal2.ToString
                End If

                If strEmployeeID.Contains("F") Or strEmployeeID.Contains("f") Then
                    blnEmployeeFullStatus = True

                    Double.TryParse(txtSoldBox.Text, dblNum3)
                    dblTotal3 += dblNum3
                    txtFullTimeBox.Text = dblTotal3.ToString

                Else
                    Double.TryParse(txtSoldBox.Text, dblNum4)
                    dblTotal4 += dblNum4
                    txtPartTimeBox.Text = dblTotal4.ToString

                End If

            Else
                MessageBox.Show("The employee ID must contain 5 characters. 
                                 The ID should start with three numbers and end 
                                 in a combination of U/N and F/P. Please try again.",
                                CStr(MessageBoxButtons.OK))
            End If

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class


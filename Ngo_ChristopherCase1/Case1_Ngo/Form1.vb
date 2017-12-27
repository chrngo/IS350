Option Strict On
Public Class Form1
    Dim timer As Integer = 0
    Dim result As Double = 0.00
    Dim fvFlag As Boolean = False
    Dim pvFlag As Boolean = False
    Dim nPerFlag As Boolean = False
    Dim rateFlag As Boolean = False
    Dim slnFlag As Boolean = False

    Public Sub ResetFlags()
        fvFlag = False
        pvFlag = False
        nPerFlag = False
        rateFlag = False
        slnFlag = False
    End Sub

    Public Sub InitValues()
        lblAnswer.Text = System.Convert.ToString(0)
        txtRate.Text = System.Convert.ToString(0)
        txtNPer.Text = System.Convert.ToString(0)
        txtPmt.Text = System.Convert.ToString(0)
        txtPV.Text = System.Convert.ToString(0)
        txtLife.Text = System.Convert.ToString(0)
        txtSalvage.Text = System.Convert.ToString(0)
        txtCost.Text = System.Convert.ToString(0)
        result = 0.00
    End Sub

    Public Sub HideAllLabels()
        txtRate.Hide()
        txtNPer.Hide()
        txtPmt.Hide()
        txtPV.Hide()
        lblRate.Hide()
        lblPmt.Hide()
        lblNPer.Hide()
        lblPV.Hide()
        lblLife.Hide()
        lblSalvage.Hide()
        lblCost.Hide()
        txtLife.Hide()
        txtSalvage.Hide()
        txtCost.Hide()
        lblInfo.Show()
        lblCalculate.Hide()
        lblCostCaption.Hide()
        lblLifeCaption.Hide()
        lblNPerCaption.Hide()
        lblPMCaption.Hide()
        lblPVCaption.Hide()
        lblRateCaption.Hide()
        lblSalvageCaption.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy    HH:mm:ss")
        InitValues()
        HideAllLabels()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
        Timer1.Start()
        Timer1.Interval = 1000
        lblSecond.Text = System.Convert.ToString(Val(lblSecond.Text) + Val(1))
        If CInt(lblSecond.Text) = 60 Then
            lblMin.Text = System.Convert.ToString(Val(lblMin.Text) + Val(1))
            lblSecond.Text = System.Convert.ToString(0)
        ElseIf CInt(lblMin.Text) = 60 Then
            lblHour.Text = System.Convert.ToString(Val(lblHour.Text) + Val(1))
            lblMin.Text = System.Convert.ToString(0)
        End If

    End Sub

    Private Sub btnFV_Click(sender As Object, e As EventArgs) Handles btnFV.Click
        HideAllLabels()
        InitValues()
        lblCalculate.Show()
        lblInfo.Hide()
        txtRate.Show()
        lblRate.Show()
        lblRateCaption.Show()
        txtNPer.Show()
        lblNPer.Show()
        lblNPerCaption.Show()
        txtPmt.Show()
        lblPmt.Show()
        lblPMCaption.Show()
        fvFlag = True
    End Sub

    Private Sub btnPV_Click(sender As Object, e As EventArgs) Handles btnPV.Click
        HideAllLabels()
        InitValues()
        lblCalculate.Show()
        lblInfo.Hide()
        txtRate.Show()
        lblRate.Show()
        lblRateCaption.Show()
        txtNPer.Show()
        lblNPer.Show()
        lblNPerCaption.Show()
        txtPmt.Show()
        lblPmt.Show()
        lblPMCaption.Show()
        pvFlag = True
    End Sub

    Private Sub btnNPer_Click(sender As Object, e As EventArgs) Handles btnNPer.Click
        HideAllLabels()
        InitValues()
        lblInfo.Hide()
        lblCalculate.Show()
        txtRate.Show()
        lblRate.Show()
        lblRateCaption.Show()
        txtPV.Show()
        lblPV.Show()
        lblPVCaption.Show()
        txtPmt.Show()
        lblPmt.Show()
        lblPMCaption.Show()
        nPerFlag = True
    End Sub

    Private Sub btnRate_Click(sender As Object, e As EventArgs) Handles btnRate.Click
        HideAllLabels()
        InitValues()
        lblInfo.Hide()
        lblCalculate.Show()
        txtNPer.Show()
        lblNPer.Show()
        lblNPerCaption.Show()
        txtPmt.Show()
        lblPmt.Show()
        lblPMCaption.Show()
        txtPV.Show()
        lblPV.Show()
        lblPVCaption.Show()
        rateFlag = True
    End Sub

    Private Sub btnSln_Click(sender As Object, e As EventArgs) Handles btnSln.Click
        HideAllLabels()
        InitValues()
        lblInfo.Hide()
        lblLife.Show()
        lblCalculate.Show()
        lblSalvage.Show()
        lblSalvageCaption.Show()
        lblCost.Show()
        lblCostCaption.Show()
        txtLife.Show()
        lblLifeCaption.Show()
        txtSalvage.Show()
        txtCost.Show()
        slnFlag = True
    End Sub

    Private Sub btnClearResult_Click(sender As Object, e As EventArgs) Handles btnClearResult.Click
        InitValues()
        HideAllLabels()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblRate, dblPmt, dblNPer, dblPV, dblLife, dblSalvage, dlbCost As Double
        ''Init values and convert to double

        dblRate = System.Convert.ToDouble(txtRate.Text)
        dblPmt = System.Convert.ToDouble(txtPmt.Text)
        dblNPer = System.Convert.ToDouble(txtNPer.Text)
        dblPV = System.Convert.ToDouble(txtPV.Text)
        dblLife = System.Convert.ToDouble(txtLife.Text)
        dblSalvage = System.Convert.ToDouble(txtSalvage.Text)
        dlbCost = System.Convert.ToDouble(txtCost.Text)

        ' Flags for calculating the financial functions
        If fvFlag Then
            result = Financial.FV((dblRate / 1), (dblNPer), -dblPmt)
            'result = System.Math.Round(result, 2)
            lblAnswer.Text = FormatCurrency(result)
        End If

        If pvFlag Then
            result = Financial.PV((dblRate / 1), (dblNPer), -dblPmt)
            'result = System.Math.Round(result, 2)
            lblAnswer.Text = FormatCurrency(result)
        End If

        If nPerFlag Then
            result = Financial.NPer((dblRate / 1), -dblPmt, dblPV)
            result = System.Math.Round(result, 2)
            lblAnswer.Text = System.Convert.ToString(result)
        End If

        If rateFlag Then
            result = Financial.Rate(dblNPer, -(dblPmt), dblPV)
            'result = System.Math.Round(result, 2)
            lblAnswer.Text = FormatPercent(result)
        End If

        If slnFlag Then
            result = Financial.SLN(dlbCost, dblSalvage, dblLife)
            'result = System.Math.Round(result, 2)
            lblAnswer.Text = FormatCurrency(result)
        End If

        'similar to format currency, but wanted to show rouned answer in case for grading rubic purposes. 
        'lblAnswer.Text = System.Convert.ToString(result)
        ResetFlags()
    End Sub


End Class


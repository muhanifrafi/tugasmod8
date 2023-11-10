Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports TempConv

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objConv As New TempConvComp()
        Dim v As Double
        v = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.cToR(v)
        Label1.Text = "Reamur"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objConv As New TempConvComp()
        Dim v As Double
        v = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.cToF(v)
        Label1.Text = "Fahrenheit"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim objConv As New TempConvComp()
        Dim v As Double
        v = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.cToK(v)
        Label1.Text = "Kelvin"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim objConv As New TempConvComp()
        Dim v As Double
        v = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.rToC(v)
        Label1.Text = "Celsius"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim objConv As New TempConvComp()
        Dim v As Double
        v = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.rToF(v)
        Label1.Text = "Fahrenheit"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim objConv As New TempConvComp()
        Dim v As Double
        v = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.rToK(v)
        Label1.Text = "Kelvin"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim objConv As New TempConvComp()
        Dim v As Double
        v = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.fToC(v)
        Label1.Text = "Celsius"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim objConv As New TempConvComp()
        Dim v As Double
        v = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.fToR(v)
        Label1.Text = "Reamur"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim objConv As New TempConvComp()
        Dim v As Double
        v = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.fToK(v)
        Label1.Text = "Kelvin"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim objConv As New TempConvComp()
        Dim v As Double
        v = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.kToC(v)
        Label1.Text = "Celsius"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim objConv As New TempConvComp()
        Dim v As Double
        v = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.kToR(v)
        Label1.Text = "Reamur"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim objConv As New TempConvComp()
        Dim v As Double
        v = CDbl(TextBox1.Text)
        TextBox1.Text = objConv.kToF(v)
        Label1.Text = "Fahrenheit"
    End Sub
End Class

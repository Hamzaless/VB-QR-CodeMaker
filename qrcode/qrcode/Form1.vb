Imports QRCoder
Imports qrcode

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim olustur As New QRCodeGenerator
        Dim qrcodenew = olustur.CreateQrCode(TextBox1.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCoder.QRCode(qrcodenew)
        pc1.Image = code.GetGraphic(20)










    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim yolSec As New SaveFileDialog
        yolSec.Filter = "QR Form's (.QR) | *.png"
        yolSec.Title = "QR Code Maker"
        yolSec.FileName = "QR-Code-Maker"
        If yolSec.ShowDialog = DialogResult.OK Then
            pc1.Image.Save(yolSec.FileName)
        End If
    End Sub
End Class

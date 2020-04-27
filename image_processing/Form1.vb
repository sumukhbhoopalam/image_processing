Imports final.Class1
Imports System.Drawing.Bitmap

Public Class Form1
    Dim obj As final.Class1
    Private Sub btnopen_Click(sender As Object, e As EventArgs) Handles btnopen.Click
        Original.Image = obj.openimage()
    End Sub

    Private Sub btngray_Click(sender As Object, e As EventArgs) Handles btngray.Click

        Result.Image = obj.gray(Original.Image)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Result.Image = obj.negative(Original.Image)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Result.Image = obj.flip(Original.Image)

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Result.Image = obj.AdjustBrightness(Original.Image, TrackBar1.Value)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Result.Image = obj.Crop(Original.Image)
    End Sub
End Class

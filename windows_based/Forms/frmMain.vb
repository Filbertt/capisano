﻿Public Class frmMain
    'fungsi untuk drag form
    Dim IsDraggingForm As Boolean = False
    Private MousePos As New System.Drawing.Point(0, 0)
    Private Sub frmMain_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            IsDraggingForm = True
            MousePos = e.Location
        End If
    End Sub
    Private Sub frmMain_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then IsDraggingForm = False
    End Sub
    Private Sub frmMain_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        If IsDraggingForm Then
            Dim temp As Point = New Point(Me.Location + (e.Location - MousePos))
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        frmLogin.ShowDialog()
    End Sub

    Private Sub timerShow_Tick(sender As Object, e As EventArgs) Handles timerShow.Tick
        If (Me.Opacity = 1) Then
            timerShow.Stop()
        Else
            Me.Opacity = Me.Opacity + 0.01
        End If
    End Sub

    Private Sub lblMin_Click(sender As Object, e As EventArgs) Handles lblMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lblMin_MouseLeave(sender As Object, e As EventArgs) Handles lblMin.MouseLeave
        lblMin.BackColor = panelTop.BackColor
    End Sub

    Private Sub lblMin_MouseMove(sender As Object, e As MouseEventArgs) Handles lblMin.MouseMove
        lblMin.BackColor = Color.White
    End Sub

    Private Sub lblMax_Click(sender As Object, e As EventArgs) Handles lblMax.Click
        If (Me.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub lblMax_MouseLeave(sender As Object, e As EventArgs) Handles lblMax.MouseLeave
        lblMax.BackColor = panelTop.BackColor
    End Sub

    Private Sub lblMax_MouseMove(sender As Object, e As MouseEventArgs) Handles lblMax.MouseMove
        lblMax.BackColor = Color.White
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub

    Private Sub lblExit_MouseLeave(sender As Object, e As EventArgs) Handles lblExit.MouseLeave
        lblExit.BackColor = panelTop.BackColor
    End Sub

    Private Sub lblExit_MouseMove(sender As Object, e As MouseEventArgs) Handles lblExit.MouseMove
        lblExit.BackColor = Color.White
    End Sub

    Private Sub frmMain_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        lblExit.Location = New Point(Me.Width - 30, 0)
        lblMax.Location = New Point(Me.Width - 60, 0)
        lblMin.Location = New Point(Me.Width - 90, 0)
        imgBottom1.Size = New Point(Me.Width, 49)
        imgBottom1.Location = New Point(0, Me.Height - 58)
        lineBottom1.X1 = 0
        lineBottom1.X2 = Me.Width
        lineBottom1.Y1 = Me.Height - 5
        lineBottom1.Y2 = Me.Height - 5
        panelTop.Size = New Point(Me.Width, 80)
        menuMain.Size = New Point(Me.Width, 24)
    End Sub

    Private Sub WebSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebSettingsToolStripMenuItem.Click
        frmServerSettings.Show()
    End Sub

    Private Sub SMSTemplateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SMSTemplateToolStripMenuItem.Click
        frmSMSTemplate.Show()
    End Sub

    Private Sub DaftarItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarItemToolStripMenuItem.Click
        frmDaftarItem.Show()
    End Sub

    Private Sub DaftarMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarMenuToolStripMenuItem.Click
        frmDaftarMenu.Show()
    End Sub

    Private Sub DaftarKategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarKategoriToolStripMenuItem.Click
        frmDaftarKategoriItem.Show()
    End Sub

    Private Sub DaftarKategoriMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarKategoriMenuToolStripMenuItem.Click
        frmDaftarKategoriMenu.Show()
    End Sub
End Class

'***********************************************************************
'Copyright 2005-2022 Vijay Sridhara

'Licensed under the Apache License, Version 2.0 (the "License");
'you may not use this file except in compliance with the License.
'You may obtain a copy of the License at

'http://www.apache.org/licenses/LICENSE-2.0

'Unless required by applicable law or agreed to in writing, software
'distributed under the License is distributed on an "AS IS" BASIS,
'WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'See the License for the specific language governing permissions and
'limitations under the License.
'***********************************************************************
Public Class Toolbox
    Private _DefWidth As Integer
    Private _Title As String

    Event Maximized()
    Event Minimized()
    Event FormOut()
    Event Hidden()
    Event Shown()
    Private Decreasing As Boolean
    Private WithEvents _InnerControl As Control
    Private _isMinimized As Boolean
    Private _isavailable As Boolean = True
    Event DockButtonClicked(forExpand As Boolean)
    Private _DefHeight As Integer = 200
    Public Property Title() As String
        Get
            Return Label1.Text
        End Get
        Set(ByVal value As String)
            Label1.Text = value
        End Set
    End Property
    Public Property IsMinimized() As Boolean
        Get
            Return _isMinimized
        End Get
        Set(ByVal value As Boolean)
            _isMinimized = value
            If value Then
                chkPin.Checked = False
            Else
                chkPin.Checked = True

            End If
        End Set
    End Property
    Public ReadOnly Property IsAvailabletoShow()
        Get
            Return _isavailable
        End Get
    End Property
    Public Property InnerControl() As Control
        Get
            Return _InnerControl
        End Get
        Set(ByVal value As Control)
            Me.pnlMain.Controls.Add(value)
            _InnerControl = value
            InnerControl.Dock = DockStyle.Fill
        End Set
    End Property

    Private Sub chkPin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPin.CheckedChanged
        If chkPin.Checked = False Then
            chkPin.ImageIndex = 1
            pnlLeft.Visible = True
            RaiseEvent DockButtonClicked(False)
            Decreasing = True
            tmrDelay.Enabled = True
            tmrDelay.Start()

        Else
            chkPin.ImageIndex = 0
            pnlLeft.Visible = False
            RaiseEvent DockButtonClicked(True)
            Me.Width = _DefWidth
            tmrDelay.Enabled = False
            tmrHold.Enabled = False
        End If
    End Sub

    Private Sub Dockabletoolbar_DockChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DockChanged
        If Me.Dock = DockStyle.Left Then
            pnlLeft.Dock = DockStyle.Left
            chkPin.Dock = DockStyle.Right
            lblTB.Image = My.Resources.lefttoolbox
            pnlLeft.Width = 25
            lblTB.Dock = DockStyle.Top
            lblTB.Height = 90
        ElseIf Me.Dock = DockStyle.Right Then
            pnlLeft.Dock = DockStyle.Right
            chkPin.Dock = DockStyle.Left
            lblTB.Image = My.Resources.lefttoolbox
            pnlLeft.Width = 25
            lblTB.Height = 90
            lblTB.Dock = DockStyle.Top
        ElseIf Me.Dock = DockStyle.Bottom Then
            pnlLeft.Dock = DockStyle.Bottom
            chkPin.Dock = DockStyle.Right
            lblTB.Image = My.Resources.bottoolbox
            pnlLeft.Height = 25
            lblTB.Width = 90
            lblTB.Dock = DockStyle.Left
            pnlLeft.BringToFront()
        ElseIf Me.Dock = DockStyle.Top Then
            pnlLeft.Dock = DockStyle.Top
            chkPin.Dock = DockStyle.Right
            lblTB.Image = My.Resources.bottoolbox
            lblTB.Dock = DockStyle.Left
            pnlLeft.Height = 25
            pnlLeft.BringToFront()
            lblTB.Width = 90

        End If
    End Sub

    Private Sub Dockabletoolbar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkPin.Checked = True
        _DefWidth = Me.Width
    End Sub

    Private Sub tmrDelay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDelay.Tick
        If Me.Dock = DockStyle.Left Or Me.Dock = DockStyle.Right Then
            If Decreasing = True Then
                Me.Width -= 15
            Else
                Me.Width += 15
            End If
        Else
            If Decreasing = True Then
                Me.Height -= 15
            Else
                Me.Height += 15
            End If
        End If
    End Sub

    Private Sub tmrHold_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrHold.Tick
        tmrDelay.Enabled = True
        tmrDelay.Start()
        tmrHold.Stop()
        Decreasing = True

    End Sub




    Private Sub Dockabletoolbar_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If tmrDelay.Enabled Then
            If Me.Dock = DockStyle.Left Or Me.Dock = DockStyle.Right Then
                If Me.Width >= _DefWidth And Not Decreasing Then
                    Me.Width = _DefWidth
                    tmrDelay.Stop()
                    tmrDelay.Enabled = False
                    tmrHold.Start()
                    RaiseEvent Maximized()
                ElseIf Decreasing And Me.Width <= pnlLeft.Width Then
                    Decreasing = False
                    Me.Width = pnlLeft.Width
                    tmrDelay.Stop()
                    tmrDelay.Enabled = False
                    RaiseEvent Minimized()
                End If

            ElseIf Me.Dock = DockStyle.Top Or Me.Dock = DockStyle.Bottom Then
                If Me.Height >= _DefHeight And Not Decreasing Then
                    Me.Height = _DefHeight
                    tmrDelay.Stop()
                    tmrDelay.Enabled = False
                    tmrHold.Start()
                    RaiseEvent Maximized()
                ElseIf Decreasing And Me.Height <= pnlLeft.Height Then
                    Decreasing = False
                    Me.Height = pnlLeft.Height
                    tmrDelay.Stop()
                    tmrDelay.Enabled = False
                    RaiseEvent Minimized()
                End If
            End If
        Else
            If Me.Dock = DockStyle.Left Or Me.Dock = DockStyle.Right Then
                If pnlLeft.Width < Me.Width Then 'this is needed because every time Form is minimized , it is taking 0 as width
                    _DefWidth = Me.Width

                End If

            Else

                If pnlLeft.height < Me.height Then 'this is needed because every time Form is minimized , it is taking 0 as width
                    _DefHeight = Me.Height

                End If
            End If
        End If
    End Sub

    Private Sub lblTB_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTB.MouseHover
        Decreasing = False
        tmrDelay.Enabled = True
        tmrDelay.Start()

    End Sub

    Private Sub pnlMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlMain.Resize
        On Error Resume Next
        pnlMain.Controls(0).Dock = DockStyle.Fill
    End Sub


    Private WithEvents df As DockForm
    Private Sub Label1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick
        Try
            df = New DockForm(Me.InnerControl, Me)
            df.Width = Me.Width
            df.Height = Me.Height
            df.Text = Me.Title
            df.Location = New Point(Screen.GetBounds(Me).Left, Screen.GetBounds(Me).Top)
            df.Show(Me.Parent)
            Me.Hide()
            RaiseEvent FormOut()
            _isavailable = False
        Catch ex As Exception

        End Try
    End Sub
    Friend Sub FormBack(ByVal permaHide As Boolean)
        Try
            Me.InnerControl = df.Controls(0)
            _isavailable = True
            Me.Width = df.ClientRectangle.Width + 4
            If Not permaHide Then
                Me.Show()
                Me.BringToFront()
                RaiseEvent Shown()
            Else

                RaiseEvent Hidden()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub chkClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkClose.Click
        Try
            Me.Hide()
            RaiseEvent Hidden()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub _InnerControl_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles _InnerControl.MouseEnter
        If chkPin.ImageIndex = 0 Then Exit Sub
        tmrHold.Enabled = False
    End Sub

    Private Sub _InnerControl_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _InnerControl.MouseLeave
        If chkPin.ImageIndex = 0 Then Exit Sub
        tmrHold.Enabled = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

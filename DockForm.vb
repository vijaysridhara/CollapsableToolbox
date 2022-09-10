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



Public Class DockForm
    Private WithEvents _tbx As Toolbox
    Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_NCLBUTTONDBLCLK Then
            _tbx.FormBack(False)

            Me.Close()
        Else
            MyBase.WndProc(m)
        End If

    End Sub
    Public Sub New(ByVal ctl As Control, ByVal tbx As Toolbox)
        InitializeComponent()
        ctl.Dock = DockStyle.Fill
        Me.Controls.Add(ctl)
        Me._tbx = tbx
    End Sub



    Private Sub DockForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
     
        Me.Dispose()
    End Sub


 

    Private Sub DockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
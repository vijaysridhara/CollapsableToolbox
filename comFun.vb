Imports System.Windows.Forms
Friend Module comFun
    Public Function ContainsPoint(ByVal ctl As Control, ByVal pnt As Point) As Boolean
        If pnt = Point.Empty Then Return False
        Dim org As New Point(0, 0)
        Dim ctlrect As New Rectangle(ctl.PointToScreen(org), ctl.Size)
        Return ctlrect.Contains(pnt)
    End Function

End Module

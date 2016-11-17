Imports System.Windows.Forms
Public Class clsDesign
#Region "Variablen Deklaration"
    Public Event clickedClose()
    Public Event clickedMinimize()
    Dim newPoint As New System.Drawing.Point()
    Dim fFont As New Font("Segoe UI", 8)
    Dim GUI_move_a As Integer
    Dim GUI_move_b As Integer
    Private WithEvents Form As Form
    Private sTitle As String = ""
    Private bResize = False
    Private iBorderSize As Integer
    Dim WithEvents pheader As New Panel
    Dim WithEvents pFooter As New Panel
    Dim WithEvents pBody As New Panel
    Dim WithEvents pbMinimize As New PictureBox
    Dim WithEvents pbClose As New PictureBox
    Dim WithEvents lblTitle As New Label
#End Region

    ''' <param name="frm">Reference für die Form die Designed werden muss</param>
    Public Sub New(ByRef frm As Form)
        Form = frm
    End Sub

    ''' <summary>
    ''' Erstellt das komplette Design
    ''' </summary>
    ''' <param name="cBodyColor">Setzt die Farbe des Bodys</param>
    ''' <param name="cBorderColor">Setzt die Farbe des Rahmens</param>
    ''' <param name="sTitleName">Setzt den Titel</param>
    ''' <param name="cTitleColor">Setzt die Schriftfarbe des Titels</param>
    '''  <param name="iTitleSize">Setzt die Schriftgröße des Titels</param>
    '''  <param name="iBorderSize">Setzt die Rahmenbreite</param>
    '''  <param name="iControlBoxIconSize">Setzt die Größe/Breite der Beenden und Minimieren Buttons</param>
    '''  <param name="iControlBoxIconSpace">Setzt den Platz zwischen den Beenden und Minimieren Buttons</param>
    '''  <param name="iHeaderHeight">Setzt die Höhe des Headers</param>
    Public Sub designForm(ByVal cBorderColor As Color, ByVal cBodyColor As Color, ByVal sTitleName As String, ByVal cTitleColor As Color,
                          ByVal iTitleSize As Integer, Optional ByVal iBorderSize As Integer = 12, Optional ByVal iControlBoxIconSize As Integer = 10,
                          Optional ByVal iControlBoxIconSpace As Integer = 1, Optional ByVal iHeaderHeight As Integer = 30)

        Dim oldControl As Control.ControlCollection = Form.Controls

        Dim dClientWidth As Double = Form.ClientSize.Width
        Dim dWidth As Double = Form.ClientSize.Width + iBorderSize * 2
        Dim dClientHeight As Double = Form.ClientSize.Height
        Dim dHeight As Double = Form.ClientSize.Height + iBorderSize + iHeaderHeight

        Me.iBorderSize = iBorderSize
        sTitle = sTitleName

        With Form
            .Font = fFont
            .BackColor = cBorderColor
            .FormBorderStyle = FormBorderStyle.None
            .Width = dWidth
        End With

        With pheader
            .Size = New Size(dWidth, iHeaderHeight)
            .Location = New Point(0, 0)
            .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            .BackColor = cBorderColor
        End With

        With pBody
            .Size = New Size(dClientWidth, dClientHeight)
            .Location = New Point(iBorderSize, pheader.Height)
            .BackColor = cBodyColor
            .Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            .Name = "pBody"
        End With

        With lblTitle
            .Font = New Font(fFont.FontFamily, iTitleSize)
            .Text = sTitleName
            .ForeColor = cTitleColor
            .AutoSize = False
            .Size = New Size(pheader.Width - iControlBoxIconSize * 2 - iControlBoxIconSpace * 2, pheader.Height)
            .Location = New Point(0, 0)
            .TextAlign = ContentAlignment.MiddleLeft
            .Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
        End With

        Form.Height = dHeight

        With pbClose
            .Size = New Size(iControlBoxIconSize, iControlBoxIconSize)
            .Location = New Point(pheader.Width - pbClose.Width - iControlBoxIconSpace, iControlBoxIconSpace)
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.CloseDefault
            .Anchor = AnchorStyles.Top Or AnchorStyles.Right
        End With

        With pbMinimize
            .Size = New Size(iControlBoxIconSize, iControlBoxIconSize)
            .Location = New Point(pheader.Width - pbClose.Width * 2 - iControlBoxIconSpace * 2, iControlBoxIconSpace)
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.MinimizeDefault
            .Anchor = AnchorStyles.Top Or AnchorStyles.Right
        End With

        With pheader
            .Controls.Add(pbClose)
            .Controls.Add(pbMinimize)
            .Controls.Add(lblTitle)
        End With

   


        While oldControl.Count > 0 'Da diese For-Schleife manchmal nur jeden 2ten Control rausgeholt hat habe ich eine Whileschleife hinzugefügt
            For Each c As Control In oldControl
                pBody.Controls.Add(c)
                oldControl.Remove(c)
            Next
        End While

        With Form
            .Controls.Clear()
            .Controls.Add(pBody)
            .Controls.Add(pheader)
        End With

    End Sub

    Public Property Title As String
        Get
            Return sTitle
        End Get
        Set(ByVal value As String)
            sTitle = value
            lblTitle.Text = value
        End Set
    End Property


    Public Property enableResizing As Boolean
        Get
            Return bResize
        End Get
        Set(ByVal value As Boolean)
            bResize = value
        End Set
    End Property

#Region "ETC"
    Private Sub pHeader_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pheader.MouseDown, lblTitle.MouseDown
        GUI_move_a = Control.MousePosition.X - Form.Location.X
        GUI_move_b = Control.MousePosition.Y - Form.Location.Y
    End Sub
    Private Sub pHeader_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pheader.MouseMove, lblTitle.MouseMove
        If e.Button = MouseButtons.Left Then
            newPoint = Control.MousePosition
            newPoint.X = newPoint.X - (GUI_move_a)
            newPoint.Y = newPoint.Y - (GUI_move_b)
            Form.Location = newPoint
        End If
    End Sub

    Private Sub pbClose_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbClose.MouseEnter
        pbClose.BackgroundImage = My.Resources.CloseHover
    End Sub

    Private Sub pbClose_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbClose.MouseLeave
        pbClose.BackgroundImage = My.Resources.CloseDefault
    End Sub

    Private Sub pbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbClose.Click
        Form.Close()
        Application.Exit()
    End Sub

    Private Sub pbMinimize_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbMinimize.MouseEnter
        pbMinimize.BackgroundImage = My.Resources.MinimizeHover
    End Sub
    Private Sub pbMinimize_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbMinimize.MouseLeave
        pbMinimize.BackgroundImage = My.Resources.MinimizeDefault
    End Sub
    Private Sub pbMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbMinimize.Click
        Form.WindowState = FormWindowState.Minimized
    End Sub

#End Region

    'created by Max
End Class

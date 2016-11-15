Module modCommands    
''' <summary>
''' Trennt den Haupt-Command und alle Argumente voneinander und übergibt Sie per Reference
''' </summary>
''' <param name="DATA">Der Command mit allen Argumenten angehangen</param>
''' <param name="command">Hier wird per Reference der eigentliche Command übergeben</param>
    ''' <param name="args">Hier werden per Reference die Argumente als Array übergeben</param>
''' <param name="splitter">Falls der StandartSplitter "|" ersetzt wurde hier den neuen Splitter angeben</param>
    Public Sub SplitCommand(ByVal DATA As String, ByRef command As String, ByRef args() As String, Optional ByVal Splitter As String = "|")
        Dim emptyarray() As String
        If DATA.Contains(Splitter) Then
            command = DATA.Split(Splitter)(0).ToLower
            Dim arglist As New List(Of String)
            For i As Integer = 1 To DATA.Split(Splitter).Length - 1
                arglist.Add(DATA.Split(Splitter)(i).ToLower)
            Next
            args = arglist.ToArray
        Else
            command = DATA.ToLower

            args = emptyarray
        End If
    End Sub

    Public Sub executeCommand(ByVal DATA As String)
        Dim args() As String
        Dim command As String

        SplitCommand(DATA, command, args)

        Select Case command

            'Beispiel
            'DATA wäre in dem Fall => COMMAND|1|2|3
			'Dann würde das Switch Case hier z.B. aussehen:
			'
            'Case "COMMAND"
            'if args(0)= 1 then
            'BeispielFunktion(args(1),args(2))
            'end if

        End Select

    End Sub
End Module
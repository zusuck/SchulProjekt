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

            Case "mars"
        
                If args.length > 2 then
            
                    Select Case args(0)
                 
                
                        Case "ackn"
                            
                            Select Case args(1)
                    
                                Case "received"
                    
                                Case "wait"
                    
                                Case "ready"
                    
                            End Select
                                
                
                        Case "sensorvalue"
                
                            Select Case args(1)
                    
                                Case "all"
                    'arg(2) bis arg(4) sind die values von light temp und switch
                                Case "light"
                    'arg(2) ist die light value
                                Case "temp"
                    'arg(2) ist die temp value
                Case "switch"
                    'arg(2) ist die switch value
                            End Select
                
                    End Select
                    
            
                End If
        
        
            Case "admin"
        
                If args.length > 2 then
            
                    Select Case args(0)
                 
                
                        Case "login"
                            
                            if args(1) == true then
                                
                    'hier müsste sich dann das Admintool öffnen da die anmeldung erfolgreich war
                    
                            else
                    
                    'hier müsste eine fehlermeldung kommen konnte nicht eingeloggt werden etc.
                        End If
                                
                
                        Case "portlist"
                            
                'args.length - 1 ist die user anzahlk
        
                
                    End Select
            
            
                End if
        
        
            Case "connect"
        
        
                if args.length = 1 then
                
            'reconnect on port args(0)
            
                end if
        
        
        
        
            'Beispiel
         'DATA wäre in dem Fall => COMMAND|1|2|3
			'Dann würde das Switch Case hier z.B. aussehen:
			'
            'Case "COMMAND"
        'if args(0)= 1 and args.length=3 then
        'BEISPIELFUNKTION(args(1),args(2))
            'end if

        End Select

    End Sub

    Public Structure UserStatus
        Public Const Offline = 0 '(Port ist mit anderen Worten frei)
        Public Const Connected = 1 'ist mit dem Server verbungen aber controlliert den Roboter nicht!
        Public Const Controlling = 2
    End Structure
End Module
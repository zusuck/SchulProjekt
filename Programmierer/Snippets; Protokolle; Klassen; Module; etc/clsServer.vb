Imports libTCPWrapper
Public Class clsServer
    Private tcpWrapper As clsTCPWrapper
    Private sUserName As String
    Private iPort As Integer
    Private iState As Integer
    Private bUsingAdminMenu As Boolean

    Public Structure strUserStatus
        Public Const Offline = 0 '(Port ist mit anderen Worten frei)
        Public Const Connected = 1 'ist mit dem Server verbungen aber controlliert den Roboter nicht!
        Public Const Controlling = 2
    End Structure

    Sub New(ByVal Port As Integer)
        tcpWrapper = New clsTCPWrapper("Server")
        iPort = Port
        bUsingAdminMenu = False
        iState = strUserStatus.Offline
        sUserName = iPort
        tcpWrapper.SetLocalPort(iPort)
    End Sub

    Property UserName As String
        Get
            Return sUserName
        End Get
        Set(ByVal value As String)
            sUserName = value
        End Set
    End Property

    ReadOnly Property Server As clsTCPWrapper
        Get
            Return tcpWrapper
        End Get
    End Property

    Property Status As Integer
        Get
            Return iState
        End Get
        Set(ByVal value As Integer)
            iState = value
        End Set
    End Property

    Property isUsingAdminTool As Boolean
        Get
            Return bUsingAdminMenu
        End Get
        Set(ByVal value As Boolean)
            bUsingAdminMenu = value
        End Set
    End Property
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verbinden
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Verbinden))
        Me.txtbServerIP = New System.Windows.Forms.TextBox()
        Me.txtbServerPort = New System.Windows.Forms.TextBox()
        Me.lblServerPort = New System.Windows.Forms.Label()
        Me.lblServerIP = New System.Windows.Forms.Label()
        Me.btnVerbinden = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtbServerIP
        '
        Me.txtbServerIP.Location = New System.Drawing.Point(38, 45)
        Me.txtbServerIP.Name = "txtbServerIP"
        Me.txtbServerIP.Size = New System.Drawing.Size(144, 22)
        Me.txtbServerIP.TabIndex = 0
        '
        'txtbServerPort
        '
        Me.txtbServerPort.Location = New System.Drawing.Point(38, 112)
        Me.txtbServerPort.Name = "txtbServerPort"
        Me.txtbServerPort.Size = New System.Drawing.Size(144, 22)
        Me.txtbServerPort.TabIndex = 1
        '
        'lblServerPort
        '
        Me.lblServerPort.AutoSize = True
        Me.lblServerPort.Location = New System.Drawing.Point(68, 83)
        Me.lblServerPort.Name = "lblServerPort"
        Me.lblServerPort.Size = New System.Drawing.Size(84, 17)
        Me.lblServerPort.TabIndex = 2
        Me.lblServerPort.Text = "Server Port:"
        '
        'lblServerIP
        '
        Me.lblServerIP.AutoSize = True
        Me.lblServerIP.Location = New System.Drawing.Point(75, 25)
        Me.lblServerIP.Name = "lblServerIP"
        Me.lblServerIP.Size = New System.Drawing.Size(70, 17)
        Me.lblServerIP.TabIndex = 3
        Me.lblServerIP.Text = "Server IP:"
        '
        'btnVerbinden
        '
        Me.btnVerbinden.Location = New System.Drawing.Point(38, 155)
        Me.btnVerbinden.Name = "btnVerbinden"
        Me.btnVerbinden.Size = New System.Drawing.Size(144, 26)
        Me.btnVerbinden.TabIndex = 4
        Me.btnVerbinden.Text = "Verbinden"
        Me.btnVerbinden.UseVisualStyleBackColor = True
        '
        'Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(221, 208)
        Me.Controls.Add(Me.btnVerbinden)
        Me.Controls.Add(Me.lblServerIP)
        Me.Controls.Add(Me.lblServerPort)
        Me.Controls.Add(Me.txtbServerPort)
        Me.Controls.Add(Me.txtbServerIP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Client"
        Me.Text = "Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbServerIP As System.Windows.Forms.TextBox
    Friend WithEvents txtbServerPort As System.Windows.Forms.TextBox
    Friend WithEvents lblServerPort As System.Windows.Forms.Label
    Friend WithEvents lblServerIP As System.Windows.Forms.Label
    Friend WithEvents btnVerbinden As System.Windows.Forms.Button

End Class

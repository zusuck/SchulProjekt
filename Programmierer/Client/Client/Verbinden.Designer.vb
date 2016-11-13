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
        Me.txtbServerIP.Location = New System.Drawing.Point(28, 37)
        Me.txtbServerIP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbServerIP.Name = "txtbServerIP"
        Me.txtbServerIP.Size = New System.Drawing.Size(109, 20)
        Me.txtbServerIP.TabIndex = 0
        '
        'txtbServerPort
        '
        Me.txtbServerPort.Location = New System.Drawing.Point(28, 91)
        Me.txtbServerPort.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbServerPort.Name = "txtbServerPort"
        Me.txtbServerPort.Size = New System.Drawing.Size(109, 20)
        Me.txtbServerPort.TabIndex = 1
        '
        'lblServerPort
        '
        Me.lblServerPort.AutoSize = True
        Me.lblServerPort.Location = New System.Drawing.Point(51, 67)
        Me.lblServerPort.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblServerPort.Name = "lblServerPort"
        Me.lblServerPort.Size = New System.Drawing.Size(63, 13)
        Me.lblServerPort.TabIndex = 2
        Me.lblServerPort.Text = "Server Port:"
        '
        'lblServerIP
        '
        Me.lblServerIP.AutoSize = True
        Me.lblServerIP.Location = New System.Drawing.Point(56, 20)
        Me.lblServerIP.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblServerIP.Name = "lblServerIP"
        Me.lblServerIP.Size = New System.Drawing.Size(54, 13)
        Me.lblServerIP.TabIndex = 3
        Me.lblServerIP.Text = "Server IP:"
        '
        'btnVerbinden
        '
        Me.btnVerbinden.Location = New System.Drawing.Point(28, 126)
        Me.btnVerbinden.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnVerbinden.Name = "btnVerbinden"
        Me.btnVerbinden.Size = New System.Drawing.Size(108, 21)
        Me.btnVerbinden.TabIndex = 4
        Me.btnVerbinden.Text = "Verbinden"
        Me.btnVerbinden.UseVisualStyleBackColor = True
        '
        'Verbinden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(166, 169)
        Me.Controls.Add(Me.btnVerbinden)
        Me.Controls.Add(Me.lblServerIP)
        Me.Controls.Add(Me.lblServerPort)
        Me.Controls.Add(Me.txtbServerPort)
        Me.Controls.Add(Me.txtbServerIP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Verbinden"
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

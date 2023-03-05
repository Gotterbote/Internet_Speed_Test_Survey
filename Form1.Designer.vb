<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.btnEnterData = New System.Windows.Forms.Button()
        Me.lstContainer = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblAccuracy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrompt.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPrompt.Location = New System.Drawing.Point(386, 67)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(250, 25)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Internet Speed Test Survey"
        '
        'btnEnterData
        '
        Me.btnEnterData.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnEnterData.Location = New System.Drawing.Point(415, 130)
        Me.btnEnterData.Name = "btnEnterData"
        Me.btnEnterData.Size = New System.Drawing.Size(171, 38)
        Me.btnEnterData.TabIndex = 1
        Me.btnEnterData.Text = "Enter Internet Speed"
        Me.btnEnterData.UseVisualStyleBackColor = False
        '
        'lstContainer
        '
        Me.lstContainer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lstContainer.FormattingEnabled = True
        Me.lstContainer.ItemHeight = 21
        Me.lstContainer.Location = New System.Drawing.Point(643, 99)
        Me.lstContainer.Name = "lstContainer"
        Me.lstContainer.ScrollAlwaysVisible = True
        Me.lstContainer.Size = New System.Drawing.Size(98, 109)
        Me.lstContainer.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(455, 423)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Average Internet Speed: "
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblOutput.Location = New System.Drawing.Point(610, 423)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 15)
        Me.lblOutput.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Location = New System.Drawing.Point(610, 462)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(114, 41)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'lblAccuracy
        '
        Me.lblAccuracy.AutoSize = True
        Me.lblAccuracy.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAccuracy.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAccuracy.Location = New System.Drawing.Point(476, 395)
        Me.lblAccuracy.Name = "lblAccuracy"
        Me.lblAccuracy.Size = New System.Drawing.Size(302, 13)
        Me.lblAccuracy.TabIndex = 6
        Me.lblAccuracy.Text = "(Results may not be accurate due to missing data points)"
        Me.lblAccuracy.Visible = False
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEnterData
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(790, 527)
        Me.Controls.Add(Me.lblAccuracy)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstContainer)
        Me.Controls.Add(Me.btnEnterData)
        Me.Controls.Add(Me.lblPrompt)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.Text = "Internet Speed Test Survey for Home Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents btnEnterData As Button
    Friend WithEvents lstContainer As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents lblAccuracy As Label
End Class

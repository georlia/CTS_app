<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ComplaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplaintsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComplaToolStripMenuItem, Me.ReportToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ComplaToolStripMenuItem
        '
        Me.ComplaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.AssignToToolStripMenuItem, Me.UpdateDetailsToolStripMenuItem})
        Me.ComplaToolStripMenuItem.Name = "ComplaToolStripMenuItem"
        Me.ComplaToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.ComplaToolStripMenuItem.Text = "&Complaints"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem2.Text = "&New Complaint"
        '
        'AssignToToolStripMenuItem
        '
        Me.AssignToToolStripMenuItem.Name = "AssignToToolStripMenuItem"
        Me.AssignToToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AssignToToolStripMenuItem.Text = "&Assign To"
        '
        'UpdateDetailsToolStripMenuItem
        '
        Me.UpdateDetailsToolStripMenuItem.Name = "UpdateDetailsToolStripMenuItem"
        Me.UpdateDetailsToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.UpdateDetailsToolStripMenuItem.Text = "&Update Details"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComplaintsToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.ReportToolStripMenuItem.Text = "&Report"
        '
        'ComplaintsToolStripMenuItem
        '
        Me.ComplaintsToolStripMenuItem.Name = "ComplaintsToolStripMenuItem"
        Me.ComplaintsToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ComplaintsToolStripMenuItem.Text = "&Complaint Log"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.ExitToolStripMenuItem.Text = "E&xit!"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Complaints Tracking System - Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ComplaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AssignToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComplaintsToolStripMenuItem As ToolStripMenuItem
End Class

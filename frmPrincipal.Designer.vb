<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Or�amentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NovoOr�amentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaOr�amentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.Or�amentosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(533, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CadastrosToolStripMenuItem.Text = "Cadastros"
        '
        'Or�amentosToolStripMenuItem
        '
        Me.Or�amentosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoOr�amentoToolStripMenuItem, Me.ConsultaOr�amentosToolStripMenuItem})
        Me.Or�amentosToolStripMenuItem.Name = "Or�amentosToolStripMenuItem"
        Me.Or�amentosToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.Or�amentosToolStripMenuItem.Text = "Or�amentos"
        '
        'NovoOr�amentoToolStripMenuItem
        '
        Me.NovoOr�amentoToolStripMenuItem.Name = "NovoOr�amentoToolStripMenuItem"
        Me.NovoOr�amentoToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.NovoOr�amentoToolStripMenuItem.Text = "Novo or�amento"
        '
        'ConsultaOr�amentosToolStripMenuItem
        '
        Me.ConsultaOr�amentosToolStripMenuItem.Name = "ConsultaOr�amentosToolStripMenuItem"
        Me.ConsultaOr�amentosToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ConsultaOr�amentosToolStripMenuItem.Text = "Consulta or�amentos"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 264)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "Menu principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Or�amentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoOr�amentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaOr�amentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

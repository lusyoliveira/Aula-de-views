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
        Me.OršamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NovoOršamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaOršamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.OršamentosToolStripMenuItem})
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
        'OršamentosToolStripMenuItem
        '
        Me.OršamentosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoOršamentoToolStripMenuItem, Me.ConsultaOršamentosToolStripMenuItem})
        Me.OršamentosToolStripMenuItem.Name = "OršamentosToolStripMenuItem"
        Me.OršamentosToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.OršamentosToolStripMenuItem.Text = "Oršamentos"
        '
        'NovoOršamentoToolStripMenuItem
        '
        Me.NovoOršamentoToolStripMenuItem.Name = "NovoOršamentoToolStripMenuItem"
        Me.NovoOršamentoToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.NovoOršamentoToolStripMenuItem.Text = "Novo oršamento"
        '
        'ConsultaOršamentosToolStripMenuItem
        '
        Me.ConsultaOršamentosToolStripMenuItem.Name = "ConsultaOršamentosToolStripMenuItem"
        Me.ConsultaOršamentosToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ConsultaOršamentosToolStripMenuItem.Text = "Consulta oršamentos"
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
    Friend WithEvents OršamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoOršamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaOršamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

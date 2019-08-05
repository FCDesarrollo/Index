<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.tMenu = New System.Windows.Forms.ToolStrip()
        Me.MConfig = New System.Windows.Forms.ToolStripButton()
        Me.tMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tMenu
        '
        Me.tMenu.AutoSize = False
        Me.tMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MConfig})
        Me.tMenu.Location = New System.Drawing.Point(0, 0)
        Me.tMenu.Name = "tMenu"
        Me.tMenu.Size = New System.Drawing.Size(800, 62)
        Me.tMenu.TabIndex = 6
        Me.tMenu.Text = "tMenu"
        '
        'MConfig
        '
        Me.MConfig.AutoSize = False
        Me.MConfig.Image = CType(resources.GetObject("MConfig.Image"), System.Drawing.Image)
        Me.MConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MConfig.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MConfig.Name = "MConfig"
        Me.MConfig.Size = New System.Drawing.Size(85, 60)
        Me.MConfig.Tag = "-1"
        Me.MConfig.Text = "Configuración"
        Me.MConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tMenu)
        Me.Name = "frmPrincipal"
        Me.Text = "Sistema Index"
        Me.tMenu.ResumeLayout(False)
        Me.tMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tMenu As ToolStrip
    Friend WithEvents MConfig As ToolStripButton
End Class

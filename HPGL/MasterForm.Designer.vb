<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.picGraph = New System.Windows.Forms.PictureBox()
        CType(Me.picGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picGraph
        '
        Me.picGraph.Location = New System.Drawing.Point(10, 12)
        Me.picGraph.Name = "picGraph"
        Me.picGraph.Size = New System.Drawing.Size(960, 540)
        Me.picGraph.TabIndex = 0
        Me.picGraph.TabStop = False
        '
        'MasterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 565)
        Me.Controls.Add(Me.picGraph)
        Me.Name = "MasterForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Master"
        CType(Me.picGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picGraph As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartamentosEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartamentosEditar))
        Me.tlpLayoutRoot = New System.Windows.Forms.TableLayoutPanel()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblAssunto = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.tlpLayoutRoot.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpLayoutRoot
        '
        Me.tlpLayoutRoot.ColumnCount = 3
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpLayoutRoot.Controls.Add(Me.lblID, 0, 0)
        Me.tlpLayoutRoot.Controls.Add(Me.txtID, 1, 0)
        Me.tlpLayoutRoot.Controls.Add(Me.lblAssunto, 0, 1)
        Me.tlpLayoutRoot.Controls.Add(Me.txtDescricao, 1, 1)
        Me.tlpLayoutRoot.Controls.Add(Me.btnSalvar, 2, 6)
        Me.tlpLayoutRoot.Controls.Add(Me.btnFechar, 1, 6)
        Me.tlpLayoutRoot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayoutRoot.Location = New System.Drawing.Point(0, 0)
        Me.tlpLayoutRoot.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpLayoutRoot.Name = "tlpLayoutRoot"
        Me.tlpLayoutRoot.RowCount = 7
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.tlpLayoutRoot.Size = New System.Drawing.Size(800, 450)
        Me.tlpLayoutRoot.TabIndex = 1
        '
        'lblID
        '
        Me.lblID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblID.Location = New System.Drawing.Point(4, 0)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(152, 49)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID:"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(164, 12)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4, 12, 4, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(132, 22)
        Me.txtID.TabIndex = 1
        '
        'lblAssunto
        '
        Me.lblAssunto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAssunto.Location = New System.Drawing.Point(4, 49)
        Me.lblAssunto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAssunto.Name = "lblAssunto"
        Me.lblAssunto.Size = New System.Drawing.Size(152, 49)
        Me.lblAssunto.TabIndex = 2
        Me.lblAssunto.Text = "Descrição:"
        Me.lblAssunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(164, 61)
        Me.txtDescricao.Margin = New System.Windows.Forms.Padding(4, 12, 4, 4)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(472, 22)
        Me.txtDescricao.TabIndex = 3
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.disk
        Me.btnSalvar.Location = New System.Drawing.Point(644, 405)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(152, 41)
        Me.btnSalvar.TabIndex = 10
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.door_open_in
        Me.btnFechar.Location = New System.Drawing.Point(467, 405)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(169, 41)
        Me.btnFechar.TabIndex = 10
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'frmDepartamentosEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tlpLayoutRoot)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDepartamentosEditar"
        Me.Text = "Netspeed - Desafio Desenvolvimento"
        Me.tlpLayoutRoot.ResumeLayout(False)
        Me.tlpLayoutRoot.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpLayoutRoot As TableLayoutPanel
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblAssunto As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnFechar As Button
End Class

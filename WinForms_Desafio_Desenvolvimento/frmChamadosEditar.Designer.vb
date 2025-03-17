<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChamadosEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChamadosEditar))
        Me.tlpLayoutRoot = New System.Windows.Forms.TableLayoutPanel()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblAssunto = New System.Windows.Forms.Label()
        Me.lblSolicitante = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblDataAbertura = New System.Windows.Forms.Label()
        Me.txtAssunto = New System.Windows.Forms.TextBox()
        Me.txtSolicitante = New System.Windows.Forms.TextBox()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.dtpDataAbertura = New System.Windows.Forms.DateTimePicker()
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
        Me.tlpLayoutRoot.Controls.Add(Me.lblSolicitante, 0, 2)
        Me.tlpLayoutRoot.Controls.Add(Me.lblDepartamento, 0, 3)
        Me.tlpLayoutRoot.Controls.Add(Me.lblDataAbertura, 0, 4)
        Me.tlpLayoutRoot.Controls.Add(Me.txtAssunto, 1, 1)
        Me.tlpLayoutRoot.Controls.Add(Me.txtSolicitante, 1, 2)
        Me.tlpLayoutRoot.Controls.Add(Me.cmbDepartamento, 1, 3)
        Me.tlpLayoutRoot.Controls.Add(Me.dtpDataAbertura, 1, 4)
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
        Me.tlpLayoutRoot.Size = New System.Drawing.Size(832, 543)
        Me.tlpLayoutRoot.TabIndex = 0
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
        Me.lblAssunto.Text = "Assunto:"
        Me.lblAssunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSolicitante
        '
        Me.lblSolicitante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSolicitante.Location = New System.Drawing.Point(4, 98)
        Me.lblSolicitante.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSolicitante.Name = "lblSolicitante"
        Me.lblSolicitante.Size = New System.Drawing.Size(152, 49)
        Me.lblSolicitante.TabIndex = 4
        Me.lblSolicitante.Text = "Solicitante:"
        Me.lblSolicitante.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDepartamento
        '
        Me.lblDepartamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDepartamento.Location = New System.Drawing.Point(4, 147)
        Me.lblDepartamento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(152, 49)
        Me.lblDepartamento.TabIndex = 6
        Me.lblDepartamento.Text = "Departamento:"
        Me.lblDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDataAbertura
        '
        Me.lblDataAbertura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDataAbertura.Location = New System.Drawing.Point(4, 196)
        Me.lblDataAbertura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataAbertura.Name = "lblDataAbertura"
        Me.lblDataAbertura.Size = New System.Drawing.Size(152, 49)
        Me.lblDataAbertura.TabIndex = 8
        Me.lblDataAbertura.Text = "Data Abertura:"
        Me.lblDataAbertura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAssunto
        '
        Me.txtAssunto.Location = New System.Drawing.Point(164, 61)
        Me.txtAssunto.Margin = New System.Windows.Forms.Padding(4, 12, 4, 4)
        Me.txtAssunto.Name = "txtAssunto"
        Me.txtAssunto.Size = New System.Drawing.Size(503, 22)
        Me.txtAssunto.TabIndex = 3
        '
        'txtSolicitante
        '
        Me.txtSolicitante.Location = New System.Drawing.Point(164, 110)
        Me.txtSolicitante.Margin = New System.Windows.Forms.Padding(4, 12, 4, 4)
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.Size = New System.Drawing.Size(503, 22)
        Me.txtSolicitante.TabIndex = 5
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(164, 159)
        Me.cmbDepartamento.Margin = New System.Windows.Forms.Padding(4, 12, 4, 4)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(265, 24)
        Me.cmbDepartamento.TabIndex = 7
        '
        'dtpDataAbertura
        '
        Me.dtpDataAbertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataAbertura.Location = New System.Drawing.Point(164, 208)
        Me.dtpDataAbertura.Margin = New System.Windows.Forms.Padding(4, 12, 4, 4)
        Me.dtpDataAbertura.Name = "dtpDataAbertura"
        Me.dtpDataAbertura.Size = New System.Drawing.Size(145, 22)
        Me.dtpDataAbertura.TabIndex = 9
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.disk
        Me.btnSalvar.Location = New System.Drawing.Point(676, 498)
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
        Me.btnFechar.Location = New System.Drawing.Point(499, 498)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(169, 41)
        Me.btnFechar.TabIndex = 10
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'frmChamadosEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 543)
        Me.Controls.Add(Me.tlpLayoutRoot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChamadosEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Netspeed - Desafio Desenvolvimento"
        Me.tlpLayoutRoot.ResumeLayout(False)
        Me.tlpLayoutRoot.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpLayoutRoot As TableLayoutPanel
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblAssunto As Label
    Friend WithEvents lblSolicitante As Label
    Friend WithEvents lblDepartamento As Label
    Friend WithEvents lblDataAbertura As Label
    Friend WithEvents txtAssunto As TextBox
    Friend WithEvents txtSolicitante As TextBox
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents dtpDataAbertura As DateTimePicker
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnFechar As Button
End Class

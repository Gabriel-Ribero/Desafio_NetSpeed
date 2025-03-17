Public Class frmChamadosEditar

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim dtDepartamentos As DataTable = Dados.ListarDepartamentos()
        Me.cmbDepartamento.DataSource = dtDepartamentos
        Me.cmbDepartamento.DisplayMember = "Descricao"
        Me.cmbDepartamento.ValueMember = "ID"

        'Extra
        Me.dtpDataAbertura.MinDate = Now

    End Sub

    Public Sub AbrirChamado(ByVal idChamado As Integer)

        'Extra
        Me.dtpDataAbertura.MinDate = New Date(1753, 1, 1)

        Dim drChamado As DataRow = Dados.ObterChamado(idChamado)

        Me.txtID.Text = CInt(drChamado("ID")).ToString()
        Me.txtAssunto.Text = CStr(drChamado("Assunto"))
        Me.txtSolicitante.Text = CStr(drChamado("Solicitante"))

        Me.cmbDepartamento.SelectedValue = CInt(drChamado("Departamento"))

        Dim strDataAbertura As String = CStr(drChamado("DataAbertura"))
        Me.dtpDataAbertura.Value = DateTime.Parse(strDataAbertura)

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        If String.IsNullOrWhiteSpace(txtAssunto.Text) Then
            MessageBox.Show("Informe o assunto do chamado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtSolicitante.Text) Then
            MessageBox.Show("Informe o solicitante do chamado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim ID As Integer = If(String.IsNullOrWhiteSpace(Me.txtID.Text), 0, Integer.Parse(Me.txtID.Text))
        Dim Assunto As String = Me.txtAssunto.Text
        Dim Solicitante As String = Me.txtSolicitante.Text
        Dim Departamento As Integer = CInt(Me.cmbDepartamento.SelectedValue)
        Dim DataAbertura As DateTime = Me.dtpDataAbertura.Value

        Dim sucesso As Boolean = Dados.GravarChamado(ID, Assunto, Solicitante, Departamento, DataAbertura)

        If Not sucesso Then

            MessageBox.Show(Me, "Falha ao gravar o chamado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Cancel

        Else

            Me.DialogResult = DialogResult.OK

        End If

        Me.Close()

    End Sub

    'Extra
    Private Sub txtSolicitante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSolicitante.KeyPress

        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If

    End Sub
End Class
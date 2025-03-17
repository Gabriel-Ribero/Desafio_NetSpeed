Public Class frmDepartamentosEditar
    Public Sub AbrirDepartamento(ByVal idDepartamento As Integer)

        Dim drChamado As DataRow = Dados.ObterDepartamento(idDepartamento)

        Me.txtID.Text = CInt(drChamado("ID")).ToString()
        Me.txtDescricao.Text = CStr(drChamado("Descricao"))

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        If String.IsNullOrWhiteSpace(txtDescricao.Text) Then
            MessageBox.Show("Informe a descrição do departamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim ID As Integer = If(String.IsNullOrWhiteSpace(Me.txtID.Text), 0, Integer.Parse(Me.txtID.Text))
        Dim Departamento As String = Me.txtDescricao.Text

        Dim sucesso As Boolean = Dados.GravarDepartamento(ID, Departamento)

        If Not sucesso Then

            MessageBox.Show(Me, "Falha ao gravar o departamento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Cancel

        Else

            Me.DialogResult = DialogResult.OK

        End If

        Me.Close()

    End Sub

    Private Sub txtDescricao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescricao.KeyPress

        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If

    End Sub
End Class
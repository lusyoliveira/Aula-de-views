Public Class frmOrcamentos
    Dim sql As String
    Dim tborcamentos, tbaux As ADODB.Recordset
    Dim x As Integer

    Private Sub cboCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCliente.GotFocus
        cboCliente.Items.Clear()
        sql = "Select * from tbclientes order by nome"
        tbaux = OpenRecordset(sql)
        If tbaux.RecordCount <> 0 Then
            tbaux.MoveFirst()
            While tbaux.EOF = False
                cboCliente.Items.Add(tbaux.Fields("nome").Value.ToString)
                tbaux.MoveNext()
            End While
        End If
    End Sub

    Private Sub cboCliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCliente.LostFocus
        If cboCliente.Text = "" Then
            Exit Sub
        End If
        sql = "Select * from tbclientes where nome = '" & cboCliente.Text & "'"
        tbaux = OpenRecordset(sql)
        If tbaux.RecordCount = 0 Then
            MsgBox("Atenção: O cliente não existe !")
            cboCliente.Focus()
            Exit Sub
        End If
        cboCliente.Tag = tbaux.Fields("codigo").Value
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCliente.SelectedIndexChanged

    End Sub

    Private Sub txtDesc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.LostFocus
        txtGeral.Text = txtTotal1.Text - txtDesc.Text
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDesc.TextChanged

    End Sub

    Private Sub frmOrcamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = frmPrincipal
        desabilitar()

    End Sub
    Private Sub desabilitar()
        txtData.Enabled = False
        txtDesc.Enabled = False
        cboCliente.Enabled = False
        cboProduto.Enabled = False
        txtGeral.Enabled = False
        txtQtd.Enabled = False
        txtTotal.Enabled = True
        txtTotal1.Enabled = False
        txtunit.Enabled = False

    End Sub
    Private Sub Habilitar()
        txtData.Enabled = True
        txtDesc.Enabled = True
        cboCliente.Enabled = True
        cboProduto.Enabled = True
        txtGeral.Enabled = True
        txtQtd.Enabled = True
        txtTotal.Enabled = True
        txtTotal1.Enabled = True
        txtunit.Enabled = True

    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Sql = "insert into tborcamentos (data) values ('" & Date.Now.Date & "')"
        tborcamentos = OpenRecordset(Sql)
        btnSalvar.Enabled = True
        btnNovo.Enabled = False
        sql = "Select * from tborcamentos order by nrorcamento desc"
        tborcamentos = OpenRecordset(sql)
        tborcamentos.MoveFirst()
        txtOrcamento.Text = tborcamentos.Fields("nrorcamento").Value.ToString
        txtOrcamento.Enabled = False
        Habilitar()
        txtData.Text = Date.Now.Date
        chkAprovado.Checked = False
        chkAprovado.Enabled = False
        cboCliente.Focus()
    End Sub

    Private Sub cboProduto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProduto.GotFocus
        cboProduto.Items.Clear()
        sql = "Select * from tbProdutos order by descricao"
        tbaux = OpenRecordset(sql)
        If tbaux.RecordCount <> 0 Then
            tbaux.MoveFirst()
            While tbaux.EOF = False
                cboProduto.Items.Add(tbaux.Fields("descricao").Value.ToString)
                tbaux.MoveNext()
            End While
        End If
    End Sub

    Private Sub cboProduto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProduto.LostFocus
        If cboProduto.Text = "" Then
            Exit Sub
        End If
        sql = "Select * from tbprodutos where descricao = '" & cboProduto.Text & "'"
        tbaux = OpenRecordset(sql)
        If tbaux.RecordCount = 0 Then
            MsgBox("Atenção: O produto não existe !")
            cboCliente.Focus()
            Exit Sub
        End If
        cboProduto.Tag = tbaux.Fields("codigo").Value
        txtunit.Text = FormatCurrency(tbaux.Fields("valor").Value.ToString)
        txtQtd.Focus()
    End Sub

    Private Sub cboProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduto.SelectedIndexChanged

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        sql = "insert into tborcamentos_dth (nrorcamento,produto,valortotal,qtd,valor) values (" & txtOrcamento.Text & "," & cboProduto.Tag & "," & moeda(txtTotal.Text) & "," & moeda(txtQtd.Text) & "," & moeda(txtunit.Text) & ")"
        tbaux = OpenRecordset(sql)
        sql = "Select sum(valortotal) as Total from tborcamentos_dth where nrorcamento = " & txtOrcamento.Text
        tbaux = OpenRecordset(sql)
        If tbaux.RecordCount <> 0 Then
            txtTotal1.Text = tbaux.Fields("total").Value
        Else
            txtTotal1.Text = 0
        End If


        txtQtd.Text = ""
        txtTotal.Text = ""
        cboProduto.Text = ""
        cboProduto.Focus()
        montar()
    End Sub
    Private Sub montar()
        With Grade
            .Rows.Clear()
            sql = "Select * from vwOrcamento_dth_produtos where nrorcamento = " & txtOrcamento.Text
            tbaux = OpenRecordset(sql)
            If tbaux.RecordCount <> 0 Then
                tbaux.MoveFirst()
                x = 0
                While tbaux.EOF = False
                    .Rows.Add(False)
                    .Item(1, x).Value = tbaux.Fields("produto").Value
                    .Item(2, x).Value = tbaux.Fields("descricao").Value.ToString
                    .Item(3, x).Value = tbaux.Fields("valor").Value
                    .Item(4, x).Value = tbaux.Fields("qtd").Value
                    .Item(5, x).Value = tbaux.Fields("valortotal").Value
                    x += 1
                    tbaux.MoveNext()
                End While
            End If
        End With
    End Sub

    Private Sub txtQtd_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtd.LostFocus
        txtTotal.Text = txtunit.Text * txtQtd.Text

    End Sub

    Private Sub txtQtd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtd.TextChanged

    End Sub

    Private Sub Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sair.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        sql = "update tborcamentos set cliente = " & cboCliente.Tag & ", desconto = " & moeda(txtDesc.Text) & ",valortotal = " & moeda(txtGeral.Text) & ", aprovado = '0', valor = " & moeda(txtTotal1.Text) & " where nrorcamento = " & txtOrcamento.Text
        tbaux = OpenRecordset(sql)
        MsgBox("Orçamento gravado com sucesso !", MsgBoxStyle.Information)
        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        limpar()
    End Sub
    Private Sub limpar()
        Grade.Rows.Clear()
        txtData.Text = ""
        txtDesc.Text = ""
        txtGeral.Text = ""
        txtOrcamento.Text = ""
        txtQtd.Text = ""
        txtTotal.Text = ""
        txtTotal1.Text = ""
        txtunit.Text = ""
        cboCliente.Text = ""
        cboProduto.Text = ""

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        sql = "Select * from vwOrcamento_dth_produtos where nrorcamento = " & txtOrcamento.Text
        tbaux = OpenRecordset(sql)
        If tbaux.RecordCount = 0 Then
            MsgBox("Não existe o orçamento solicitado !", MsgBoxStyle.Information)
            Exit Sub
        End If
        cboCliente.Text = tbaux.Fields("nome").Value.ToString
        txtTotal1.Text = tbaux.Fields("valor_orc").Value
        txtDesc.Text = tbaux.Fields("desconto").Value
        txtGeral.Text = tbaux.Fields("Valortotal_orc").Value
        txtData.Text = tbaux.Fields("data").Value
        chkAprovado.Checked = IIf(tbaux.Fields("aprovado").Value.ToString = "True", True, False)
        montar()
    End Sub

    Private Sub btnAprovar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprovar.Click
        sql = "Select * from vwOrcamento_dth_produtos where nrorcamento = " & txtOrcamento.Text
        tbaux = OpenRecordset(sql)
        If tbaux.RecordCount = 0 Then
            MsgBox("Não existe o orçamento solicitado !", MsgBoxStyle.Information)
            Exit Sub
        End If
        cboCliente.Text = tbaux.Fields("nome").Value.ToString
        txtTotal1.Text = tbaux.Fields("valor_orc").Value
        txtDesc.Text = tbaux.Fields("desconto").Value
        txtGeral.Text = tbaux.Fields("Valortotal_orc").Value
        txtData.Text = tbaux.Fields("data").Value
        chkAprovado.Checked = IIf(tbaux.Fields("aprovado").Value.ToString = "True", True, False)
        montar()
        If MsgBox("Deseja aprovar o orçamento ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        sql = "update tborcamentos set aprovado = '1' where nrorcamento = " & txtOrcamento.Text
        tbaux = OpenRecordset(sql)
        limpar()
    End Sub
End Class
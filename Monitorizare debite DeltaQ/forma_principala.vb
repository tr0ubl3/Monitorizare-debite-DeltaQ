Imports System.Text.RegularExpressions
Imports Microsoft.Data.Sqlite
Public Class fereastra_principala_frm
    Dim nr_marca_valid As Boolean
    Private Function testare_regex(regex_text As String, text As String) As Boolean
        Dim regex_test As New Regex(regex_text)

        Return regex_test.IsMatch(text)
    End Function
    Private Sub adauga_valori_btn_Click(sender As Object, e As EventArgs) Handles adauga_valori_btn.Click
        Me.adauga_valori_pnl.Visible = True
        'setare initiala elemente din panou
        Me.nr_marca_tb.Focus()
        'nr masina eticheta si camp
        Me.nr_masina_lbl.Visible = False
        Me.nr_masina_cb.Visible = False

        'debit Posalux eticheta si camp
        Me.debit_posalux_lbl.Visible = False
        Me.z1_lbl.Visible = False
        Me.z2_lbl.Visible = False
        Me.z3_lbl.Visible = False
        Me.z4_lbl.Visible = False

        Me.z1_tb.Visible = False
        Me.z2_tb.Visible = False
        Me.z3_tb.Visible = False
        Me.z4_tb.Visible = False

        'tabel valori
        Me.tabel_valori_dgv.Visible = False

        'buton salvare
        Me.salveaza_valori_btn.Visible = False
        grafice_pnl.Visible = False

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub nr_marca_tb_TextChanged(sender As Object, e As EventArgs) Handles nr_marca_tb.TextChanged
        Dim regex_text As String = "[5-9]+[0-5]+\d{3}"
        Dim regex_test As New Regex(regex_text)
        If nr_marca_tb.TextLength = 5 Then
            If regex_test.IsMatch(nr_marca_tb.Text) Then
                Me.nr_masina_lbl.Visible = True
                Me.nr_masina_cb.Visible = True
                Me.nr_masina_cb.Focus()
                nr_marca_valid = True
            Else
                Me.nr_masina_lbl.Visible = False
                Me.nr_masina_cb.Visible = False
                Me.nr_masina_cb.Text = Nothing
                Me.z1_tb.Visible = False
                Me.z1_lbl.Visible = False
                Me.z1_tb.Text = Nothing
                Me.debit_posalux_lbl.Visible = False
                nr_marca_valid = False
            End If
        Else
            Me.nr_masina_lbl.Visible = False
            Me.nr_masina_cb.Visible = False
            Me.nr_masina_cb.Text = Nothing
            Me.z1_tb.Visible = False
            Me.z1_lbl.Visible = False
            Me.z1_tb.Text = Nothing
            Me.debit_posalux_lbl.Visible = False
            nr_marca_valid = False
        End If
    End Sub

    Private Sub nr_marca_tb_KeyDown(sender As Object, e As KeyEventArgs) Handles nr_marca_tb.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.nr_masina_cb.Focus()
        End If
    End Sub

    Private Sub nr_masina_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nr_masina_cb.SelectedIndexChanged
        If nr_marca_valid Then
            Me.debit_posalux_lbl.Visible = True
            Me.z1_lbl.Visible = True
            'Me.z2_lbl.Visible = True
            'Me.z3_lbl.Visible = True
            'Me.z4_lbl.Visible = True

            Me.z1_tb.Visible = True
            'Me.z2_tb.Visible = True
            'Me.z3_tb.Visible = True
            'Me.z4_tb.Visible = True

            Me.z1_tb.Focus()

        Else
            Me.debit_posalux_lbl.Visible = False
            Me.z1_lbl.Visible = False
            Me.z1_tb.Visible = False
        End If
    End Sub
    Private Sub z1_tb_TextChanged(sender As Object, e As EventArgs) Handles z1_tb.TextChanged
        Dim regex As String = "^[1-9][0-9]{2}$|^[\*]{1}$"

        If testare_regex(regex, z1_tb.Text) Then
            Me.z2_lbl.Visible = True
            Me.z2_tb.Visible = True
            Me.z2_tb.Focus()
        Else
            Me.z2_lbl.Visible = False
            Me.z2_tb.Visible = False
            Me.z3_lbl.Visible = False
            Me.z3_tb.Visible = False
            Me.z4_lbl.Visible = False
            Me.z4_tb.Visible = False
            Me.z2_tb.Text = Nothing
            Me.z3_tb.Text = Nothing
            Me.z4_tb.Text = Nothing
        End If
    End Sub

    Private Sub z2_tb_TextChanged(sender As Object, e As EventArgs) Handles z2_tb.TextChanged
        Dim regex As String = "^[1-9][0-9]{2}$|^[\*]{1}$"

        If testare_regex(regex, z2_tb.Text) Then
            Me.z3_lbl.Visible = True
            Me.z3_tb.Visible = True
            Me.z3_tb.Focus()
        Else
            Me.z3_lbl.Visible = False
            Me.z3_tb.Visible = False
            Me.z4_lbl.Visible = False
            Me.z4_tb.Visible = False
            Me.z3_tb.Text = Nothing
            Me.z4_tb.Text = Nothing
        End If

        If Me.z2_tb.TextLength = 0 Then
            z1_tb.Focus()
            z1_tb.SelectAll()
            z2_tb.Visible = False
            z2_lbl.Visible = False
        End If
    End Sub

    Private Sub z3_tb_TextChanged(sender As Object, e As EventArgs) Handles z3_tb.TextChanged
        Dim regex As String = "^[1-9][0-9]{2}$|^[\*]{1}$"

        If testare_regex(regex, z3_tb.Text) Then
            Me.z4_lbl.Visible = True
            Me.z4_tb.Visible = True
            Me.z4_tb.Focus()
        Else
            Me.z4_lbl.Visible = False
            Me.z4_tb.Visible = False
            Me.z4_tb.Text = Nothing
        End If

        If Me.z3_tb.TextLength = 0 Then
            z2_tb.Focus()
            z2_tb.SelectAll()
            z3_tb.Visible = False
            z3_lbl.Visible = False
        End If
    End Sub

    Private Sub z4_tb_TextChanged(sender As Object, e As EventArgs) Handles z4_tb.TextChanged
        Dim regex As String = "^[1-9][0-9]{2}$|^[\*]{1}$"

        If testare_regex(regex, z4_tb.Text) Then
            Me.tabel_valori_dgv.Visible = True
            Me.tabel_valori_dgv.Focus()
        Else
            Me.tabel_valori_dgv.Visible = False
        End If

        If Me.z4_tb.TextLength = 0 Then
            z3_tb.Focus()
            z3_tb.SelectAll()
            z4_tb.Visible = False
            z4_lbl.Visible = False
        End If
    End Sub
    Private Sub tabel_valori_dgv_VisibleChanged(sender As Object, e As EventArgs) Handles tabel_valori_dgv.VisibleChanged
        'executare doar daca forma e vizibila
        If tabel_valori_dgv.Visible Then
            Dim conexiune_bd As New SqliteConnection("data source=C:\Users\qzcd5g\Documents\documente\Posalux\OP140\monitorizare debite\Monitorizare debite DeltaQ\Monitorizare debite DeltaQ\DeltaQValues.db")
            Dim continut_bd As New DataSet
            Dim datacurenta As String = String.Format("{0:yyyy-MM-dd}", DateTime.Now)
            conexiune_bd.Open()
            Dim comanda = conexiune_bd.CreateCommand
            comanda.CommandText = "select data, dm, referinta, nr_caseta, debit, delta_q, nr_cuib, rowid from valori where data like'" & "16.05.2019" & "%' order by data asc"
            Dim reader As SqliteDataReader = comanda.ExecuteReader
            Dim rand As String()

            Using reader
                While reader.Read()
                    'MsgBox(reader.GetString(0) & " " & reader.GetString(1) & " " & reader.GetString(2) & " " & reader.GetString(3))
                    'tabel_valori_dgv. = reader.GetString(0)
                    rand = New String() {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetFloat(3), reader.GetFloat(4), reader.GetFloat(5), reader.GetInt16(6), reader.GetInt64(7)}
                    tabel_valori_dgv.Rows.Add(rand)
                End While
            End Using
        End If
        tabel_valori_dgv.ClearSelection()
        salveaza_valori_btn.Visible = False
    End Sub

    'Private Sub tabel_valori_dgv_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_valori_dgv.RowEnter
    'MsgBox("S-a selectat randul " & Convert.ToString(tabel_valori_dgv.CurrentRow.Index))
    'End Sub

    Private Sub tabel_valori_dgv_MouseClick(sender As Object, e As MouseEventArgs) Handles tabel_valori_dgv.MouseClick
        Dim caseta_selectata As String = Convert.ToString(tabel_valori_dgv.Item(3, tabel_valori_dgv.CurrentRow.Index).Value)
        Dim data_ora_selectata As String = tabel_valori_dgv.Item(0, tabel_valori_dgv.CurrentRow.Index).Value
        Dim ora_selectata = DateAndTime.Hour(data_ora_selectata)
        Dim minutul_selectat = DateAndTime.Minute(data_ora_selectata)
        Dim data_ora_urmatoare As String
        Dim ora_urmatoare As Integer
        Dim minutul_urmator As Integer
        Dim val_selectate As Integer = 1
        Dim cuib_urmator As Integer
        Dim cuib_selectat As Integer = tabel_valori_dgv.Item(6, tabel_valori_dgv.CurrentRow.Index).Value
        Dim rand As DataGridViewRow
        Dim z1_prezent, z2_prezent, z3_prezent, z4_prezent, z1_validat, z2_validat, z3_validat, z4_validat As Boolean
        Dim valori_verificate As Integer
        Dim nr_valori_introduse As Integer

        For i = 1 To 3
            If caseta_selectata = tabel_valori_dgv.Item(3, tabel_valori_dgv.CurrentRow.Index + i).Value Then
                If Not tabel_valori_dgv.Rows.Count = tabel_valori_dgv.CurrentRow.Index Then
                    data_ora_urmatoare = tabel_valori_dgv.Item(0, tabel_valori_dgv.CurrentRow.Index + i).Value
                    ora_urmatoare = DateAndTime.Hour(data_ora_urmatoare)
                    minutul_urmator = DateAndTime.Minute(data_ora_urmatoare)
                    cuib_urmator = tabel_valori_dgv.Item(6, tabel_valori_dgv.CurrentRow.Index + i).Value
                    If cuib_urmator >= cuib_selectat + val_selectate And cuib_urmator <= 4 Then
                        If (ora_selectata = ora_urmatoare Or ora_selectata = (ora_urmatoare - 1)) AndAlso (minutul_urmator >= minutul_selectat Or (minutul_urmator <= minutul_selectat And ora_urmatoare > ora_selectata)) AndAlso (minutul_selectat = minutul_urmator Or minutul_selectat = minutul_urmator - 1 Or minutul_selectat = minutul_urmator - 2 Or minutul_selectat = minutul_urmator - 3) Then
                            tabel_valori_dgv.Rows(tabel_valori_dgv.CurrentRow.Index + i).Selected = True
                            val_selectate += 1
                        End If
                    End If
                End If
                'ElseIf caseta_selectata = tabel_valori_dgv.Item(3, tabel_valori_dgv.CurrentRow.Index - i).Value Then
                'If Not tabel_valori_dgv.CurrentRow.Index < i Then
                '    data_ora_urmatoare = tabel_valori_dgv.Item(0, tabel_valori_dgv.CurrentRow.Index - i).Value
                '    ora_urmatoare = DateAndTime.Hour(data_ora_urmatoare)
                '    minutul_urmator = DateAndTime.Minute(data_ora_urmatoare)
                '    cuib_urmator = tabel_valori_dgv.Item(6, tabel_valori_dgv.CurrentRow.Index - i).Value
                '    If cuib_urmator >= cuib_selectat - 1 And cuib_urmator <= 1 Then
                '        'selecteaza randurile de mai sus daca pe randul urmator ora e aceeasi sau daca minutul e mai mare decat cel selectat sau ora mai mare si minutul mai mic
                '        If (ora_selectata = ora_urmatoare Or ora_selectata > ora_urmatoare) AndAlso (minutul_urmator <= minutul_selectat Or (minutul_urmator > minutul_selectat And ora_urmatoare < ora_selectata)) AndAlso (minutul_selectat = minutul_urmator Or minutul_selectat = minutul_urmator + 1 Or minutul_selectat = minutul_urmator + 2 Or minutul_selectat = minutul_urmator + 3) Then
                '            tabel_valori_dgv.Rows(tabel_valori_dgv.CurrentRow.Index - i).Selected = True
                '            val_selectate += 1
                '        End If
                '    End If
                'End If
            End If
        Next

        'verificare daca pentru valorile selectate sunt valori introduse
        For Each rand In tabel_valori_dgv.SelectedRows
            Select Case rand.Cells(6).Value
                Case 1
                    z1_prezent = True
                    If IsNumeric(z1_tb.Text) Then
                        z1_validat = True
                        valori_verificate += 1
                    End If
                Case 2
                    z2_prezent = True
                    If IsNumeric(z2_tb.Text) Then
                        z2_validat = True
                        valori_verificate += 1
                    End If
                Case 3
                    z3_prezent = True
                    If IsNumeric(z3_tb.Text) Then
                        z3_validat = True
                        valori_verificate += 1
                    End If
                Case 4
                    z4_prezent = True
                    If IsNumeric(z4_tb.Text) Then
                        z4_validat = True
                        valori_verificate += 1
                    End If
            End Select
        Next

        If Not z1_tb.Text = "*" Then
            nr_valori_introduse += 1
        End If

        If Not z2_tb.Text = "*" Then
            nr_valori_introduse += 1
        End If

        If Not z3_tb.Text = "*" Then
            nr_valori_introduse += 1
        End If

        If Not z4_tb.Text = "*" Then
            nr_valori_introduse += 1
        End If

        If tabel_valori_dgv.SelectedRows.Count = valori_verificate And tabel_valori_dgv.SelectedRows.Count = nr_valori_introduse Then
            salveaza_valori_btn.Visible = True
        Else
            salveaza_valori_btn.Visible = False
        End If
    End Sub

    Private Sub salveaza_valori_btn_Click(sender As Object, e As EventArgs) Handles salveaza_valori_btn.Click
        Dim testare_regex As New Regex("140\.\d{1,2}")
        Dim rezultat_regex As Match
        Dim conexiune_bd As New SqliteConnection("data source=C:\Users\qzcd5g\Documents\documente\Posalux\OP140\monitorizare debite\Monitorizare debite DeltaQ\Monitorizare debite DeltaQ\DeltaQValues.db")
        Dim comanda = conexiune_bd.CreateCommand
        Dim reader As SqliteDataReader
        Dim id_masina As Integer
        Dim rand As DataGridViewRow
        Dim comanda_executata As Double
        Dim dq_vals(3) As Single
        Dim debit_introdus(3) As String
        Dim dif_max, dif_min, dq_max, dq_min, dif_dq_max, dif_dq_min As Int16
        Dim dif_debit(3) As Single
        Dim debit_masurat(3) As Single
        Dim spc_id As Double
        Dim atentionare_activa As Boolean
        Dim id_atentionare As Double

        debit_introdus(0) = z1_tb.Text
        debit_introdus(1) = z2_tb.Text
        debit_introdus(2) = z3_tb.Text
        debit_introdus(3) = z4_tb.Text
        For i = 0 To 3
            If debit_introdus(i) = "*" Then
            Else
                debit_masurat(i) = tabel_valori_dgv.Item(4, tabel_valori_dgv.CurrentRow.Index + i).Value
                dif_debit(i) = debit_introdus(i) - debit_masurat(i)
            End If
        Next
        'de scos id-ul din tabelul masini pentru a actualiza rowid-urile selectate mai sus cu id-ul masinilor
        rezultat_regex = testare_regex.Match(nr_masina_cb.Text)
        conexiune_bd.Open()
        comanda.CommandText = "select id_masina from masini where nr_operatie = '" & rezultat_regex.Value & "'"
        reader = comanda.ExecuteReader

        'extragere id masina
        Using reader
            While reader.Read()
                'MsgBox(reader.GetString(0) & " " & reader.GetString(1) & " " & reader.GetString(2) & " " & reader.GetString(3))
                'tabel_valori_dgv. = reader.GetString(0)
                id_masina = reader.GetInt16(0)
            End While
        End Using

        'salvare id masina in rezultatele selectatate
        For Each rand In tabel_valori_dgv.SelectedRows
            comanda.CommandText = "update valori set masina = " & id_masina & " where rowid = " & rand.Cells(7).Value
            comanda.ExecuteNonQuery()
        Next

        'salvare rezultat spc in bd
        'comanda.CommandText = "insert into spc_posalux (nr_marca, valoare_z1, valoare_z2, valoare_z3, valoare_z4, referinta, masina) values (" _
        '                       & nr_marca_tb.Text & ", " & If(z1_tb.Text = "*", "", z1_tb.Text) & ", " & If(z2_tb.Text = "*", "", z2_tb.Text) _
        '                      & ", " & If(z3_tb.Text = "*", "", z3_tb.Text) & ", " & If(z4_tb.Text = "*", "", z4_tb.Text) & ", '" _
        '                       & tabel_valori_dgv.Item(2, tabel_valori_dgv.CurrentRow.Index).Value & "'," & id_masina & ")"
        comanda.CommandText = "insert into spc_posalux (nr_marca, valoare_introdusa_z1, valoare_introdusa_z2, valoare_introdusa_z3, valoare_introdusa_z4, diferenta_calculata_z1,
                               diferenta_calculata_z2, diferenta_calculata_z3, diferenta_calculata_z4, diferenta_calculata_min_max_delta_q, referinta, masina) values (@nr_marca, @val_z1, @val_z2,
                               @val_z3, @val_z4, @dif_z1, @dif_z2, @dif_z3, @dif_z4, @dif_dq, @referinta, @masina)"
        comanda.Parameters.AddWithValue("@nr_marca", nr_marca_tb.Text)
        comanda.Parameters.AddWithValue("@val_z1", If(debit_introdus(0) = "*", DBNull.Value, CInt(debit_introdus(0))))
        comanda.Parameters.AddWithValue("@val_z2", If(debit_introdus(1) = "*", DBNull.Value, CInt(debit_introdus(1))))
        comanda.Parameters.AddWithValue("@val_z3", If(debit_introdus(2) = "*", DBNull.Value, CInt(debit_introdus(2))))
        comanda.Parameters.AddWithValue("@val_z4", If(debit_introdus(3) = "*", DBNull.Value, CInt(debit_introdus(3))))
        comanda.Parameters.AddWithValue("@dif_z1", If(debit_introdus(0) = "*", DBNull.Value, dif_debit(0)))
        comanda.Parameters.AddWithValue("@dif_z2", If(debit_introdus(1) = "*", DBNull.Value, dif_debit(1)))
        comanda.Parameters.AddWithValue("@dif_z3", If(debit_introdus(2) = "*", DBNull.Value, dif_debit(2)))
        comanda.Parameters.AddWithValue("@dif_z4", If(debit_introdus(3) = "*", DBNull.Value, dif_debit(3)))
        For i = 0 To 3
            If debit_introdus(i) = "*" Then
                'actions tbd
            Else
                dq_vals(i) = tabel_valori_dgv.Item(5, tabel_valori_dgv.CurrentRow.Index + i).Value
            End If
        Next
        comanda.Parameters.AddWithValue("@dif_dq", dq_vals.Max - dq_vals.Min)
        comanda.Parameters.AddWithValue("@referinta", tabel_valori_dgv.Item(2, tabel_valori_dgv.CurrentRow.Index).Value)
        comanda.Parameters.AddWithValue("@masina", id_masina)
        'Debug.Print("insert into spc_posalux (nr_marca, valoare_z1, valoare_z2, valoare_z3, valoare_z4, referinta, masina) values (" & nr_marca_tb.Text & ", " & If(z1_tb.Text = "*", "", z1_tb.Text) & ", " & If(z2_tb.Text = "*", "", z2_tb.Text) & ", " & If(z3_tb.Text = "*", "", z3_tb.Text) & ", " & If(z4_tb.Text = "*", "", z4_tb.Text) & ", '" & tabel_valori_dgv.Item(2, tabel_valori_dgv.CurrentRow.Index).Value & "'," & id_masina & ")")
        comanda_executata = comanda.ExecuteNonQuery()

        If comanda_executata = 1 Then
            'extrage id-ul spc-ului
            comanda.CommandText = "select last_insert_rowid()"
            spc_id = comanda.ExecuteScalar()
            nr_marca_tb.Text = ""
            adauga_valori_pnl.Visible = False
            'grafice_pnl.Visible = True

            'extragere limite dif, dq si nominal pentru afisare pagina atentionari
            comanda.CommandText = "select diferenta_max, diferenta_min, delta_q_max, delta_q_min, dif_dq_max, dif_dq_min from referinta where nume = '" & tabel_valori_dgv.Item(2, tabel_valori_dgv.CurrentRow.Index).Value & "'"
            reader = comanda.ExecuteReader
            Using reader
                While reader.Read()
                    dif_max = reader.GetInt16(0)
                    dif_min = reader.GetInt16(1)
                    dq_max = reader.GetInt16(2)
                    dq_min = reader.GetInt16(3)
                    dif_dq_max = reader.GetInt16(4)
                    dif_dq_min = reader.GetInt16(5)
                End While
            End Using

            lista_atentionari_pnl.Visible = True
            lista_atentionari_lst.Items.Clear()

            'creare comanda pentru inserare linie in tabelul atentionare
            comanda.CommandText = "insert into atentionare (spc_id, atentionare_activa, z1_atentionare_1, z1_atentionare_2, z1_atentionare_3, z2_atentionare_1, z2_atentionare_2, z2_atentionare_3,
                                   z3_atentionare_1, z3_atentionare_2, z3_atentionare_3, z4_atentionare_1, z4_atentionare_2, z4_atentionare_3) values (@spc_id, @atentionare_activa, @z1_atentionare_1,
                                   @z1_atentionare_2, @z1_atentionare_3, @z2_atentionare_1, @z2_atentionare_2, @z2_atentionare_3, @z3_atentionare_1, @z3_atentionare_2, @z3_atentionare_3,
                                   @z4_atentionare_1, @z4_atentionare_2, @z4_atentionare_3)"

            comanda.Parameters.AddWithValue("@spc_id", spc_id)

            'calcul diferenta debit maxima pentru a verificare daca e mai mare decat limita impusa in referinta
            If dif_debit.Max > dif_max Or dif_debit.Min < dif_min Then
                atentionare_activa = True
                'comanda.Parameters.AddWithValue("@atentionare_activa", True)
                'actiune de implementat
                'lista_atentionari_lst.Items.Add("Diferente de debit mai mari decat " & dif_max & " sau " & dif_min).Group = lista_atentionari_lst.Groups("Verificare 1")
                If dif_debit(0) > dif_max Or dif_debit(0) < dif_min Then
                    comanda.Parameters.AddWithValue("@z1_atentionare_1", True)
                Else
                    comanda.Parameters.AddWithValue("@z1_atentionare_1", False)
                End If

                If dif_debit(1) > dif_max Or dif_debit(1) < dif_min Then
                    comanda.Parameters.AddWithValue("@z2_atentionare_1", True)
                Else
                    comanda.Parameters.AddWithValue("@z2_atentionare_1", False)
                End If

                If dif_debit(2) > dif_max Or dif_debit(2) < dif_min Then
                    comanda.Parameters.AddWithValue("@z3_atentionare_1", True)
                Else
                    comanda.Parameters.AddWithValue("@z3_atentionare_1", False)
                End If

                If dif_debit(3) > dif_max Or dif_debit(3) < dif_min Then
                    comanda.Parameters.AddWithValue("@z4_atentionare_1", True)
                Else
                    comanda.Parameters.AddWithValue("@z4_atentionare_1", False)
                End If
            Else
                comanda.Parameters.AddWithValue("@z1_atentionare_1", False)
                comanda.Parameters.AddWithValue("@z2_atentionare_1", False)
                comanda.Parameters.AddWithValue("@z3_atentionare_1", False)
                comanda.Parameters.AddWithValue("@z4_atentionare_1", False)
            End If

            If dq_vals.Max > dq_max Or dq_vals.Min < dq_min Then
                atentionare_activa = True
                'actiune de implementat atunci cand delta q-urile sunt in afara limitei
                If dq_vals(0) > dq_max Or dq_vals(0) < dq_min Then
                    comanda.Parameters.AddWithValue("@z1_atentionare_2", True)
                Else
                    comanda.Parameters.AddWithValue("@z1_atentionare_2", False)
                End If

                If dq_vals(1) > dq_max Or dq_vals(1) < dq_min Then
                    comanda.Parameters.AddWithValue("@z2_atentionare_2", True)
                Else
                    comanda.Parameters.AddWithValue("@z2_atentionare_2", False)
                End If

                If dq_vals(2) > dq_max Or dq_vals(2) < dq_min Then
                    comanda.Parameters.AddWithValue("@z3_atentionare_2", True)
                Else
                    comanda.Parameters.AddWithValue("@z3_atentionare_2", False)
                End If

                If dq_vals(3) > dq_max Or dq_vals(3) < dq_min Then
                    comanda.Parameters.AddWithValue("@z4_atentionare_2", True)
                Else
                    comanda.Parameters.AddWithValue("@z4_atentionare_2", False)
                End If
            Else
                comanda.Parameters.AddWithValue("@z1_atentionare_2", False)
                comanda.Parameters.AddWithValue("@z2_atentionare_2", False)
                comanda.Parameters.AddWithValue("@z3_atentionare_2", False)
                comanda.Parameters.AddWithValue("@z4_atentionare_2", False)
            End If

            If (dq_vals.Max - dq_vals.Min) > dif_dq_max Then
                atentionare_activa = True
                'actiune de implementat atunci cand diferenta intre delta q-uri este mai mare decat limita impusa
                'afiseaza z-urile cu valoarea minima si maxima
                If dq_vals(0) = dq_vals.Max Or dq_vals(0) = dq_vals.Min Then
                    comanda.Parameters.AddWithValue("@z1_atentionare_3", True)
                Else
                    comanda.Parameters.AddWithValue("@z1_atentionare_3", False)
                End If

                If dq_vals(1) = dq_vals.Max Or dq_vals(1) = dq_vals.Min Then
                    comanda.Parameters.AddWithValue("@z2_atentionare_3", True)
                Else
                    comanda.Parameters.AddWithValue("@z2_atentionare_3", False)
                End If

                If dq_vals(2) = dq_vals.Max Or dq_vals(2) = dq_vals.Min Then
                    comanda.Parameters.AddWithValue("@z3_atentionare_3", True)
                Else
                    comanda.Parameters.AddWithValue("@z3_atentionare_3", False)
                End If

                If dq_vals(3) = dq_vals.Max Or dq_vals(3) = dq_vals.Min Then
                    comanda.Parameters.AddWithValue("@z4_atentionare_3", True)
                Else
                    comanda.Parameters.AddWithValue("@z4_atentionare_3", False)
                End If
            Else
                comanda.Parameters.AddWithValue("@z1_atentionare_3", False)
                comanda.Parameters.AddWithValue("@z2_atentionare_3", False)
                comanda.Parameters.AddWithValue("@z3_atentionare_3", False)
                comanda.Parameters.AddWithValue("@z4_atentionare_3", False)
            End If

            If atentionare_activa Then
                comanda.Parameters.AddWithValue("@atentionare_activa", True)
            Else
                comanda.Parameters.AddWithValue("@atentionare_activa", False)
            End If

            comanda_executata = comanda.ExecuteNonQuery()

            If comanda_executata = 1 Then
                comanda.CommandText = "select last_insert_rowid()"
                id_atentionare = comanda.ExecuteScalar()
            End If
        End If
        conexiune_bd.Close()
        MsgBox(id_atentionare)
    End Sub

    Private Sub grafice_pnl_VisibleChanged(sender As Object, e As EventArgs) Handles grafice_pnl.VisibleChanged
        If grafice_pnl.Visible = True Then
            'grafic = dif_z1_pb.CreateGraphics
            'dif_debit_z1_chart.Visible = True
            Dim limita_max As New DataVisualization.Charting.StripLine
            Dim limita_min As New DataVisualization.Charting.StripLine
            Dim nominal As New DataVisualization.Charting.StripLine
            Dim punct As New DataVisualization.Charting.DataPoint

            limita_max.BorderDashStyle = DataVisualization.Charting.ChartDashStyle.DashDot
            limita_max.BorderColor = Color.Red
            limita_max.BorderWidth = 2
            limita_max.IntervalOffset = 5

            limita_min.BorderDashStyle = DataVisualization.Charting.ChartDashStyle.DashDot
            limita_min.BorderColor = Color.Red
            limita_min.BorderWidth = 2
            limita_min.IntervalOffset = -5

            nominal.BorderDashStyle = DataVisualization.Charting.ChartDashStyle.DashDot
            nominal.BorderColor = Color.Green
            nominal.BorderWidth = 2
            nominal.IntervalOffset = 0

            dif_debit_z1_chart.ChartAreas(0).AxisY.Interval = 2.5
            dif_debit_z1_chart.ChartAreas(0).AxisY.Minimum = -5 - 10 * 0.1 '666 - 72 * 0.1
            dif_debit_z1_chart.ChartAreas(0).AxisY.Maximum = 5 + 10 * 0.1 '738 + 72 * 0.1
            dif_debit_z1_chart.ChartAreas(0).AxisY.IntervalOffset = 1

            dif_debit_z1_chart.ChartAreas(0).AxisY.StripLines.Add(limita_max)
            dif_debit_z1_chart.ChartAreas(0).AxisY.StripLines.Add(limita_min)
            dif_debit_z1_chart.ChartAreas(0).AxisY.StripLines.Add(nominal)

            punct.SetValueY(-5)
            punct.Color = Color.Blue
            punct.ToolTip = "lol"

            dif_debit_z1_chart.Series("valori").Points.Clear()

            dif_debit_z1_chart.Series("valori").Points.Add(punct)
            dif_debit_z1_chart.Series("valori").Points.AddY(-3)
            dif_debit_z1_chart.Series("valori").Points.AddY(0)
            dif_debit_z1_chart.Series("valori").Points.Add(punct)
            dif_debit_z1_chart.Series("valori").Points.AddY(-3)
            dif_debit_z1_chart.Series("valori").Points.AddY(0)
            dif_debit_z1_chart.Series("valori").Points.Add(punct)
            dif_debit_z1_chart.Series("valori").Points.AddY(-3)
            dif_debit_z1_chart.Series("valori").Points.AddY(0)
            dif_debit_z1_chart.Series("valori").Points.AddY(4)

            dif_debit_z1_chart.Series("valori").Points.Add(punct)
            dif_debit_z1_chart.Series("valori").Points.AddY(-3)
            dif_debit_z1_chart.Series("valori").Points.AddY(0)
            dif_debit_z1_chart.Series("valori").Points.Add(punct)
            dif_debit_z1_chart.Series("valori").Points.AddY(-3)
            dif_debit_z1_chart.Series("valori").Points.AddY(0)
            dif_debit_z1_chart.Series("valori").Points.Add(punct)
            dif_debit_z1_chart.Series("valori").Points.AddY(-3)
            dif_debit_z1_chart.Series("valori").Points.AddY(0)
            dif_debit_z1_chart.Series("valori").Points.AddY(4)
        End If
    End Sub

    Private Sub vizualizare_grafice_btn_Click(sender As Object, e As EventArgs) Handles vizualizare_grafice_btn.Click
        grafice_pnl.Visible = True
    End Sub

    Private Sub lista_atentionari_btn_Click(sender As Object, e As EventArgs) Handles lista_atentionari_btn.Click
        grafice_pnl.Visible = False
        adauga_valori_pnl.Visible = False
        lista_atentionari_pnl.Visible = True
    End Sub
End Class
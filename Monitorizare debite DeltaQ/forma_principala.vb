Imports System.Text.RegularExpressions
Imports Microsoft.Data.Sqlite
Public Class fereastra_principala_frm
    Dim nr_marca_valid As Boolean
    Dim locatie_bd As String = Replace(Application.StartupPath, "bin\Debug", "") & "DeltaQValues.db"
    Private Function testare_regex(regex_text As String, text As String) As Boolean
        Dim regex_test As New Regex(regex_text)

        Return regex_test.IsMatch(text)
    End Function
    Private Sub adauga_valori_btn_Click(sender As Object, e As EventArgs) Handles adauga_valori_btn.Click
        vizibilitate_panou(adauga_valori_pnl)

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
        Me.reactualizare_date_btn.Visible = False
        Me.tabel_valori_dgv.Visible = False
        Me.tabel_valori_dgv.Rows.Clear()

        'buton salvare
        Me.salveaza_valori_btn.Visible = False
    End Sub

    Private Sub nr_marca_tb_TextChanged(sender As Object, e As EventArgs) Handles nr_marca_tb.TextChanged
        Dim regex_text As String = "[4-9]+[0-5]+\d{3}"
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
            actualizare_tabel_valori()
            reactualizare_date_btn.Visible = True
        End If
        tabel_valori_dgv.ClearSelection()
        salveaza_valori_btn.Visible = False
    End Sub

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
        Dim rand_curent As Integer = tabel_valori_dgv.CurrentRow.Index

        If tabel_valori_dgv.SelectedRows.Count = 1 Then
            tabel_valori_dgv.Enabled = False
        End If
        For i = 1 To 3
            If rand_curent + i < tabel_valori_dgv.RowCount - 1 Then
                If caseta_selectata = tabel_valori_dgv.Item(3, tabel_valori_dgv.CurrentRow.Index + i).Value Then
                    If Not tabel_valori_dgv.Rows.Count - 1 = tabel_valori_dgv.CurrentRow.Index Then
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
        Dim conexiune_bd As New SqliteConnection("data source=" & locatie_bd)
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
        Dim atentionare_1, atentionare_2, atentionare_3 As Boolean
        Dim item_lista_1, item_lista_2, item_lista_3 As New ListViewItem
        Dim atentionare(11) As Boolean
        Dim nr_valori, nr_dq As Int16
        Dim minim_absolut As Double = -99999.99999
        Dim dq_arr() As Double = {}

        debit_introdus(0) = z1_tb.Text
        debit_introdus(1) = z2_tb.Text
        debit_introdus(2) = z3_tb.Text
        debit_introdus(3) = z4_tb.Text

        For i = 0 To 3
            If IsNumeric(debit_introdus(i)) Then
                'extragere debit daca valoarea masurata este numerica
                If IsNumeric(tabel_valori_dgv.Item(4, tabel_valori_dgv.CurrentRow.Index).Value + nr_valori) Then
                    debit_masurat(i) = tabel_valori_dgv.Item(4, tabel_valori_dgv.CurrentRow.Index + nr_valori).Value
                    dif_debit(i) = debit_introdus(i) - debit_masurat(i)
                    nr_valori += 1
                Else
                    debit_masurat(i) = minim_absolut
                    dif_debit(i) = minim_absolut
                End If

                'extragere delta q daca valoarea masurata este numerica
                If IsNumeric(tabel_valori_dgv.Item(5, tabel_valori_dgv.CurrentRow.Index).Value + nr_dq) Then
                    ReDim Preserve dq_arr(nr_dq)
                    dq_vals(i) = tabel_valori_dgv.Item(5, tabel_valori_dgv.CurrentRow.Index + nr_dq).Value
                    dq_arr(nr_dq) = dq_vals(i)
                    nr_dq += 1
                Else
                    dq_vals(i) = minim_absolut
                End If
            Else
                debit_masurat(i) = minim_absolut
                dif_debit(i) = minim_absolut
                dq_vals(i) = minim_absolut
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
                id_masina = reader.GetInt16(0)
            End While
        End Using
        comanda.Dispose()

        'salvare id masina in rezultatele selectatate
        For Each rand In tabel_valori_dgv.SelectedRows
            comanda.CommandText = "update valori set masina = " & id_masina & " where rowid = " & rand.Cells(7).Value
            comanda.ExecuteNonQuery()
        Next
        comanda.Dispose()

        'salvare rezultat spc in bd
        comanda.CommandText = "insert into spc_posalux (nr_marca, valoare_introdusa_z1, valoare_introdusa_z2, valoare_introdusa_z3, valoare_introdusa_z4, diferenta_calculata_z1,
                               diferenta_calculata_z2, diferenta_calculata_z3, diferenta_calculata_z4, diferenta_calculata_min_max_delta_q, referinta, masina) values (@nr_marca, @val_z1, @val_z2,
                               @val_z3, @val_z4, @dif_z1, @dif_z2, @dif_z3, @dif_z4, @dif_dq, @referinta, @masina)"
        comanda.Parameters.AddWithValue("@nr_marca", nr_marca_tb.Text)

        For i = 0 To 3
            comanda.Parameters.AddWithValue("@val_z" & i + 1, If(debit_introdus(i) = "*", DBNull.Value, (debit_introdus(i))))
            comanda.Parameters.AddWithValue("@dif_z" & i + 1, If(debit_introdus(i) = "*", DBNull.Value, dif_debit(i)))
        Next

        If nr_dq > 1 Then
            comanda.Parameters.AddWithValue("@dif_dq", dq_vals.Max - dq_vals.Min)
        Else
            comanda.Parameters.AddWithValue("@dif_dq", DBNull.Value)
        End If

        comanda.Parameters.AddWithValue("@referinta", tabel_valori_dgv.Item(2, tabel_valori_dgv.CurrentRow.Index).Value)
        comanda.Parameters.AddWithValue("@masina", id_masina)
        comanda_executata = comanda.ExecuteNonQuery()

        If comanda_executata = 1 Then
            'extrage id-ul spc-ului
            comanda.CommandText = "select last_insert_rowid()"
            spc_id = comanda.ExecuteScalar()

            'actualizare tabel valori cu id-ul spcului creat
            For Each rand In tabel_valori_dgv.SelectedRows
                comanda.CommandText = "update valori set spc_id = " & spc_id & " where rowid = " & rand.Cells(7).Value
                comanda.ExecuteNonQuery()
            Next
            comanda.Dispose()

            nr_marca_tb.Text = ""
            adauga_valori_pnl.Visible = False

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
            comanda.Dispose()

            'creare comanda pentru inserare linie in tabelul atentionare
            comanda.CommandText = "insert into atentionare (spc_id, atentionare_activa, z1_atentionare_1, z1_atentionare_2, z1_atentionare_3, z2_atentionare_1, z2_atentionare_2, z2_atentionare_3,
                                   z3_atentionare_1, z3_atentionare_2, z3_atentionare_3, z4_atentionare_1, z4_atentionare_2, z4_atentionare_3) values (@spc_id, @atentionare_activa, @z1_atentionare_1,
                                   @z1_atentionare_2, @z1_atentionare_3, @z2_atentionare_1, @z2_atentionare_2, @z2_atentionare_3, @z3_atentionare_1, @z3_atentionare_2, @z3_atentionare_3,
                                   @z4_atentionare_1, @z4_atentionare_2, @z4_atentionare_3)"

            comanda.Parameters.AddWithValue("@spc_id", spc_id)

            'calcul diferenta debit maxima pentru a verificare daca e mai mare decat limita impusa in referinta
            If dif_debit.Max > dif_max Or dif_debit.Min < dif_min Then
                atentionare_1 = True

                'verifica diferenta debit z1
                For i = 0 To 3
                    If debit_masurat(i) > 0 And (dif_debit(i) > dif_max Or dif_debit(i) < dif_min) Then
                        atentionare(i) = True
                        comanda.Parameters.AddWithValue("@z" & i + 1 & "_atentionare_1", True)
                    Else
                        comanda.Parameters.AddWithValue("@z" & i + 1 & "_atentionare_1", False)
                    End If
                Next
            Else
                comanda.Parameters.AddWithValue("@z1_atentionare_1", False)
                comanda.Parameters.AddWithValue("@z2_atentionare_1", False)
                comanda.Parameters.AddWithValue("@z3_atentionare_1", False)
                comanda.Parameters.AddWithValue("@z4_atentionare_1", False)
            End If

            If dq_vals.Max > dq_max Or dq_vals.Min < dq_min Then
                atentionare_2 = True
                For i = 0 To 3
                    If dq_vals(i) > minim_absolut And (dq_vals(i) > dq_max Or dq_vals(i) < dq_min) Then
                        atentionare(4 + i) = True
                        comanda.Parameters.AddWithValue("@z" & i + 1 & "_atentionare_2", True)
                    Else
                        comanda.Parameters.AddWithValue("@z" & i + 1 & "_atentionare_2", False)
                    End If
                Next
            Else
                comanda.Parameters.AddWithValue("@z1_atentionare_2", False)
                comanda.Parameters.AddWithValue("@z2_atentionare_2", False)
                comanda.Parameters.AddWithValue("@z3_atentionare_2", False)
                comanda.Parameters.AddWithValue("@z4_atentionare_2", False)
            End If

            If nr_dq > 1 And (dq_arr.Max - dq_arr.Min) > dif_dq_max Then
                atentionare_3 = True
                'afiseaza z-urile cu valoarea minima si maxima
                For i = 0 To 3
                    If dq_vals(i) > minim_absolut And (dq_vals(i) = dq_vals.Max Or dq_vals(i) = dq_vals.Min) Then
                        atentionare(8 + i) = True
                        comanda.Parameters.AddWithValue("@z" & i + 1 & "_atentionare_3", True)
                    Else
                        comanda.Parameters.AddWithValue("@z" & i + 1 & "_atentionare_3", False)
                    End If
                Next
            Else
                comanda.Parameters.AddWithValue("@z1_atentionare_3", False)
                comanda.Parameters.AddWithValue("@z2_atentionare_3", False)
                comanda.Parameters.AddWithValue("@z3_atentionare_3", False)
                comanda.Parameters.AddWithValue("@z4_atentionare_3", False)
            End If

            If atentionare_1 Or atentionare_2 Or atentionare_3 Then
                atentionare_activa = True
                comanda.Parameters.AddWithValue("@atentionare_activa", True)
            Else
                comanda.Parameters.AddWithValue("@atentionare_activa", False)
            End If

            comanda_executata = comanda.ExecuteNonQuery()
            comanda.Dispose()
            If comanda_executata = 1 Then
                lista_atentionari_pnl.Tag = id_masina
                vizibilitate_panou(lista_atentionari_pnl)
            End If
        End If
        conexiune_bd.Close()
    End Sub

    Private Sub grafice_pnl_VisibleChanged(sender As Object, e As EventArgs) Handles grafice_pnl.VisibleChanged
        If grafice_pnl.Visible = True Then
            'grafic = dif_z1_pb.CreateGraphics
            'dif_debit_z1_chart.Visible = True
            Dim limita_max As New DataVisualization.Charting.StripLine
            Dim limita_min As New DataVisualization.Charting.StripLine
            Dim nominal As New DataVisualization.Charting.StripLine
            Dim punct As New DataVisualization.Charting.DataPoint

            'de implementat intr-o functie
            Dim conexiune_bd As New SqliteConnection("data source=" & locatie_bd)
            Dim comanda = conexiune_bd.CreateCommand
            Dim reader As SqliteDataReader
            Dim lim_max, lim_min, lim_nom, interval_tol, incr As Integer
            Dim dif() = Nothing, diferenta As Double

            conexiune_bd.Open()
            comanda.CommandText = "select diferenta_max, diferenta_min, diferenta_nominala from referinta where id_referinta = 1"
            reader = comanda.ExecuteReader

            Using reader
                While reader.Read
                    lim_max = reader.GetValue(0)
                    lim_min = reader.GetValue(1)
                    lim_nom = reader.GetValue(2)
                End While
            End Using
            reader.Close()

            limita_max.BorderDashStyle = DataVisualization.Charting.ChartDashStyle.DashDot
            limita_max.BorderColor = Color.Red
            limita_max.BorderWidth = 2
            limita_max.IntervalOffset = lim_max

            limita_min.BorderDashStyle = DataVisualization.Charting.ChartDashStyle.DashDot
            limita_min.BorderColor = Color.Red
            limita_min.BorderWidth = 2
            limita_min.IntervalOffset = lim_min

            nominal.BorderDashStyle = DataVisualization.Charting.ChartDashStyle.DashDot
            nominal.BorderColor = Color.Green
            nominal.BorderWidth = 2
            nominal.IntervalOffset = lim_nom
            interval_tol = (lim_max - lim_min)
            dif_debit_z1_chart.ChartAreas(0).AxisY.Interval = interval_tol / 4
            dif_debit_z1_chart.ChartAreas(0).AxisY.Minimum = lim_min - interval_tol * 0.1 '666 - 72 * 0.1
            dif_debit_z1_chart.ChartAreas(0).AxisY.Maximum = lim_max + interval_tol * 0.1 '738 + 72 * 0.1
            dif_debit_z1_chart.ChartAreas(0).AxisY.IntervalOffset = 1

            dif_debit_z1_chart.ChartAreas(0).AxisY.StripLines.Add(limita_max)
            dif_debit_z1_chart.ChartAreas(0).AxisY.StripLines.Add(limita_min)
            dif_debit_z1_chart.ChartAreas(0).AxisY.StripLines.Add(nominal)


            comanda.CommandText = "select printf('%.1f', diferenta_calculata_z1) from spc_posalux where masina = 7 order by data_creare desc limit 30"
            reader = comanda.ExecuteReader

            Using reader
                While reader.Read
                    ReDim Preserve dif(incr)
                    dif(incr) = reader.GetValue(0)
                    incr += 1
                End While
            End Using
            reader.Close()
            dif_debit_z1_chart.Series("valori").Points.Clear()

            For Each diferenta In dif
                'punct.IsValueShownAsLabel = True
                punct.SetValueY(diferenta)
                punct.ToolTip = diferenta
                If diferenta > lim_max Then
                    punct.Color = Color.Red
                    punct.SetValueY(5.5)
                ElseIf diferenta < lim_min Then
                    punct.Color = Color.Red
                    punct.SetValueY(-5.5)
                ElseIf lim_max > diferenta And diferenta > lim_min Then
                    punct.Color = Color.Black
                End If
                dif_debit_z1_chart.Series("valori").Points.Add(punct)
                punct = New DataVisualization.Charting.DataPoint
            Next

            'dif_debit_z1_chart.Series("valori").Points.AddY(4)
            conexiune_bd.Close()
        End If
    End Sub

    Private Sub vizualizare_grafice_btn_Click(sender As Object, e As EventArgs) Handles vizualizare_grafice_btn.Click
        vizibilitate_panou(grafice_pnl)
    End Sub
    Private Sub lista_atentionari_btn_Click(sender As Object, e As EventArgs) Handles lista_atentionari_btn.Click
        Dim conexiune_bd As New SqliteConnection("data source=" & locatie_bd)
        Dim comanda = conexiune_bd.CreateCommand
        Dim reader As SqliteDataReader
        Dim subelement As Button
        Dim atentionare_activa As Boolean
        Dim referinta As String = ""
        Dim spc_id As Integer
        'Dim id_producator As String

        vizibilitate_panou(lista_masini_pnl)
        If button_flow_pnl.Controls.OfType(Of Button).Count = 0 Then
            conexiune_bd.Open()
            adauga_butoane(button_flow_pnl)

            For Each subelement In Me.button_flow_pnl.Controls
                comanda.CommandText = "select rowid, referinta from spc_posalux where masina=" & subelement.Tag & " order by data_creare desc limit 1"
                reader = comanda.ExecuteReader

                Using reader
                    While reader.Read
                        spc_id = reader.GetValue(0)
                        referinta = reader.GetValue(1)
                    End While
                End Using

                reader.Close()
                comanda.Dispose()

                comanda.CommandText = "select atentionare_activa from atentionare a where 
                                        spc_id = " & spc_id
                reader = comanda.ExecuteReader

                Using reader
                    While reader.Read()
                        atentionare_activa = reader.GetValue(0)
                    End While
                End Using
                reader.Close()
                comanda.Dispose()

                If atentionare_activa Then
                    subelement.BackColor = Color.Red
                Else
                    subelement.BackColor = Color.Green
                End If
                subelement.Text += Environment.NewLine & referinta
            Next
            conexiune_bd.Close()
        End If
    End Sub

    Private Sub buton_masini_click(sender As Object, e As EventArgs)
        Dim id_masina As Integer = CType(sender, Control).Tag

        lista_atentionari_pnl.Tag = id_masina
        vizibilitate_panou(lista_atentionari_pnl)
    End Sub

    Private Function durata(ByRef data_ora As DateTime) As String
        Dim moment_curent As DateTime = DateTime.Now
        Dim ts As TimeSpan
        Dim secunda As Integer = 1
        Dim minut As Integer = 60 * secunda
        Dim ora As Integer = 60 * minut
        Dim zi As Integer = 24 * ora
        Dim secunde As Double

        ts = moment_curent - data_ora
        secunde = ts.TotalSeconds

        Select Case secunde
            Case Is < secunda
                Return "câteva momente"
            Case Is < minut
                Return ts.Seconds & " secunde"
            Case Is < 2 * minut
                Return ts.Minutes & " minut"
            Case Is < 1 * ora
                Return ts.Minutes & " minute"
            Case Is < 2 * ora
                Return "o oră și " & ts.Minutes & " minute"
            Case Is < 1 * zi
                If ts.Minutes = 1 Then
                    Return ts.Hours & " ore și " & ts.Minutes & " minut"
                Else
                    Return ts.Hours & " ore și " & ts.Minutes & " minute"
                End If
            Case Is < 2 * zi
                If ts.Hours = 1 Then
                    Return "o zi și " & ts.Hours & " oră"
                Else
                    Return "o zi și " & ts.Hours & " ore"
                End If
            Case Is < 30 * zi
                Return ts.Days & " zile și " & ts.Hours & " ore"
        End Select

        Return ts.TotalSeconds
    End Function

    Private Function date_atentionare(id_masina As Integer) As Dictionary(Of String, Object)
        Dim conexiune_bd As New SqliteConnection("data source=" & locatie_bd)
        Dim comanda As SqliteCommand = conexiune_bd.CreateCommand
        Dim reader As SqliteDataReader
        Dim incr As Int16

        date_atentionare = New Dictionary(Of String, Object)

        conexiune_bd.Open()
        comanda.CommandText = "select id_atentionare, spc_id, atentionare_activa, z1_atentionare_1, z2_atentionare_1, z3_atentionare_1, z4_atentionare_1,
                                      z1_atentionare_2, z2_atentionare_2, z3_atentionare_2, z4_atentionare_2, z1_atentionare_3, z2_atentionare_3,
                                      z3_atentionare_3, z4_atentionare_3 from atentionare a where 
                                      spc_id = (select rowid from spc_posalux where masina=" & id_masina & " order by data_creare desc limit 1)"
        reader = comanda.ExecuteReader

        Using reader
            While reader.Read()
                date_atentionare.Add("id_atent", reader.GetInt32(0))
                date_atentionare.Add("id_spc", reader.GetInt32(1))
                date_atentionare.Add("atentionare_activa", reader.GetBoolean(2))
                date_atentionare.Add("atentionare_0", reader.GetBoolean(3))
                date_atentionare.Add("atentionare_1", reader.GetBoolean(4))
                date_atentionare.Add("atentionare_2", reader.GetBoolean(5))
                date_atentionare.Add("atentionare_3", reader.GetBoolean(6))
                date_atentionare.Add("atentionare_4", reader.GetBoolean(7))
                date_atentionare.Add("atentionare_5", reader.GetBoolean(8))
                date_atentionare.Add("atentionare_6", reader.GetBoolean(9))
                date_atentionare.Add("atentionare_7", reader.GetBoolean(10))
                date_atentionare.Add("atentionare_8", reader.GetBoolean(11))
                date_atentionare.Add("atentionare_9", reader.GetBoolean(12))
                date_atentionare.Add("atentionare_10", reader.GetBoolean(13))
                date_atentionare.Add("atentionare_11", reader.GetBoolean(14))
            End While
        End Using
        reader.Close()

        If date_atentionare.ContainsKey("id_spc") = False Then
            Exit Function
        End If

        comanda.CommandText = "select diferenta_calculata_z1, diferenta_calculata_z2, diferenta_calculata_z3, diferenta_calculata_z4, diferenta_calculata_min_max_delta_q, 
                                referinta, nr_marca, datetime(data_creare, 'localtime'), valoare_introdusa_z1, valoare_introdusa_z2, valoare_introdusa_z3, valoare_introdusa_z4
                               from spc_posalux where spc_id=" & date_atentionare.Item("id_spc")
        reader = comanda.ExecuteReader

        Using reader
            While reader.Read
                If reader.IsDBNull(0) = False Then
                    date_atentionare.Add("dif_debit_0", reader.GetDouble(0))
                    date_atentionare.Add("valoare_introdusa_z1", reader.GetDouble(8))
                End If

                If reader.IsDBNull(1) = False Then
                    date_atentionare.Add("dif_debit_1", reader.GetDouble(1))
                    date_atentionare.Add("valoare_introdusa_z2", reader.GetDouble(9))
                End If

                If reader.IsDBNull(2) = False Then
                    date_atentionare.Add("dif_debit_2", reader.GetDouble(2))
                    date_atentionare.Add("valoare_introdusa_z3", reader.GetDouble(10))
                End If

                If reader.IsDBNull(3) = False Then
                    date_atentionare.Add("dif_debit_3", reader.GetDouble(3))
                    date_atentionare.Add("valoare_introdusa_z4", reader.GetDouble(11))
                End If

                If reader.IsDBNull(3) = False Then
                    date_atentionare.Add("dif_dq", reader.GetDouble(4))
                End If

                date_atentionare.Add("referinta", reader.GetString(5))
                date_atentionare.Add("nr_marca", reader.GetString(6))
                date_atentionare.Add("data_spc", reader.GetDateTime(7))
            End While
        End Using
        reader.Close()

        comanda.CommandText = "select dm, round(debit, 1), delta_q, nr_cuib from valori where spc_id=" & date_atentionare.Item("id_spc")
        reader = comanda.ExecuteReader

        Using reader
            While reader.Read
                date_atentionare.Add("dm_" & reader.GetInt16(3) - 1, reader.GetString(0))
                date_atentionare.Add("debit_" & reader.GetInt16(3) - 1, reader.GetDouble(1))
                date_atentionare.Add("dq_vals_" & reader.GetInt16(3) - 1, reader.GetDouble(2))
                incr += 1
            End While
        End Using
        reader.Close()

        comanda.CommandText = "select diferenta_max, diferenta_min, delta_q_nominal, delta_q_min, delta_q_max, dif_dq_max from referinta where nume='" & date_atentionare.Item("referinta") & "'"
        reader = comanda.ExecuteReader()

        Using reader
            While reader.Read
                date_atentionare.Add("diferenta_max", reader.GetDouble(0))
                date_atentionare.Add("diferenta_min", reader.GetDouble(1))
                date_atentionare.Add("delta_q_nominal", reader.GetDouble(2))
                date_atentionare.Add("delta_q_min", reader.GetDouble(3))
                date_atentionare.Add("delta_q_max", reader.GetDouble(4))
                date_atentionare.Add("dif_dq_max", reader.GetDouble(5))
            End While
        End Using
        comanda.Dispose()

        comanda.CommandText = "select nr_operatie from masini where id_masina=" & id_masina
        reader = comanda.ExecuteReader()

        Using reader
            While reader.Read
                date_atentionare.Add("nr_operatie", reader.GetString(0))
            End While
        End Using
        comanda.Dispose()

        comanda.CommandText = "select nume from utilizator where nr_marca=" & date_atentionare.Item("nr_marca")
        reader = comanda.ExecuteReader()

        Using reader
            While reader.Read
                date_atentionare.Add("nume_operator", reader.GetString(0))
            End While
        End Using
        comanda.Dispose()
        conexiune_bd.Close()
    End Function

    Private Sub lista_atentionari_pnl_VisibleChanged(sender As Object, e As EventArgs) Handles lista_atentionari_pnl.VisibleChanged
        Dim id_masina As Integer = lista_atentionari_pnl.Tag
        If lista_atentionari_pnl.Visible = True Then
            If lista_atentionari_pnl.Tag IsNot Nothing Then
                Dim item_lista_1, item_lista_2, item_lista_3 As New ListViewItem
                Dim incr As Integer = 0
                Dim date_extrase As IDictionary
                Dim nr_z As String

                date_extrase = date_atentionare(id_masina)

                id_atentionare_lbl.Text = date_extrase.Item("id_atent") '"Atenționare " & date_extrase.Item("id_atent") & " spc masurat acum " & durata(date_extrase.Item("data_spc"))
                data_ora_atentionare_lbl.Text = date_extrase.Item("data_spc") & " " & "(" & durata(date_extrase.Item("data_spc")) & ")"
                referinta_atentionare_lbl.Text = date_extrase.Item("referinta")
                masina_atentionare_lbl.Text = date_extrase.Item("nr_operatie")
                If date_extrase.Item("nume_operator") = Nothing Then
                    date_operator_atentionare_lbl.Text = date_extrase.Item("nr_marca") & " - Nume necunoscut"
                Else
                    date_operator_atentionare_lbl.Text = date_extrase.Item("nr_marca") & " - " & date_extrase.Item("nume_operator")
                End If

                lista_atentionari_lst.Items.Clear()

                lista_atentionari_lst.Groups(0).Header = "Diferențe debit între Posalux și Delta Q (minim " _
                        & date_extrase.Item("diferenta_min") & ", maxim " & date_extrase.Item("diferenta_max") & ")"

                lista_atentionari_lst.Groups(1).Header = "Delta Q în afara toleranței nominal " _
                        & date_extrase.Item("delta_q_nominal") & " (minim " & date_extrase.Item("delta_q_min") & ", maxim " & date_extrase.Item("delta_q_max") & ")"

                nr_z = "Z1"
                If date_extrase.Contains("debit_0") Then
                    item_lista_1.UseItemStyleForSubItems = False
                    item_lista_1.Name = "z1_list"
                    item_lista_1.Text = nr_z
                    item_lista_1.SubItems.Add(date_extrase.Item("dm_0"))
                    item_lista_1.SubItems.Add("OK").BackColor = Color.Green
                    item_lista_1.SubItems.Add(Math.Round(date_extrase.Item("dif_debit_0"), 1) & " ml")
                    item_lista_1.SubItems.Add(date_extrase.Item("valoare_introdusa_z1"))
                    item_lista_1.SubItems.Add(date_extrase.Item("debit_0"))
                    item_lista_1.Group = lista_atentionari_lst.Groups(0)
                    lista_atentionari_lst.Items.Add(item_lista_1)
                Else
                    item_lista_1.UseItemStyleForSubItems = False
                    item_lista_1.Name = "z1_list"
                    item_lista_1.Text = nr_z
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.Group = lista_atentionari_lst.Groups(0)
                    lista_atentionari_lst.Items.Add(item_lista_1)
                End If

                nr_z = "Z2"
                item_lista_1 = New ListViewItem
                If date_extrase.Contains("debit_1") Then
                    item_lista_1.UseItemStyleForSubItems = False
                    item_lista_1.Name = "z2_list"
                    item_lista_1.Text = nr_z
                    item_lista_1.SubItems.Add(date_extrase.Item("dm_1"))
                    item_lista_1.SubItems.Add("OK").BackColor = Color.Green
                    item_lista_1.SubItems.Add(Math.Round(date_extrase.Item("dif_debit_1"), 1) & " ml")
                    item_lista_1.SubItems.Add(date_extrase.Item("valoare_introdusa_z2"))
                    item_lista_1.SubItems.Add(date_extrase.Item("debit_1"))
                    item_lista_1.Group = lista_atentionari_lst.Groups(0)
                    lista_atentionari_lst.Items.Add(item_lista_1)
                Else
                    item_lista_1.UseItemStyleForSubItems = False
                    item_lista_1.Name = "z1_list"
                    item_lista_1.Text = nr_z
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.Group = lista_atentionari_lst.Groups(0)
                    lista_atentionari_lst.Items.Add(item_lista_1)
                End If

                nr_z = "Z3"
                item_lista_1 = New ListViewItem
                If date_extrase.Contains("debit_2") Then
                    item_lista_1.UseItemStyleForSubItems = False
                    item_lista_1.Name = "z3_list"
                    item_lista_1.Text = nr_z
                    item_lista_1.SubItems.Add(date_extrase.Item("dm_2"))
                    item_lista_1.SubItems.Add("OK").BackColor = Color.Green
                    item_lista_1.SubItems.Add(Math.Round(date_extrase.Item("dif_debit_2"), 1) & " ml")
                    item_lista_1.SubItems.Add(date_extrase.Item("valoare_introdusa_z3"))
                    item_lista_1.SubItems.Add(date_extrase.Item("debit_2"))
                    item_lista_1.Group = lista_atentionari_lst.Groups(0)
                    lista_atentionari_lst.Items.Add(item_lista_1)
                Else
                    item_lista_1.UseItemStyleForSubItems = False
                    item_lista_1.Name = "z1_list"
                    item_lista_1.Text = nr_z
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.Group = lista_atentionari_lst.Groups(0)
                    lista_atentionari_lst.Items.Add(item_lista_1)
                End If

                nr_z = "Z4"
                item_lista_1 = New ListViewItem
                If date_extrase.Contains("debit_3") Then
                    item_lista_1.UseItemStyleForSubItems = False
                    item_lista_1.Name = "z4_list"
                    item_lista_1.Text = nr_z
                    item_lista_1.SubItems.Add(date_extrase.Item("dm_3"))
                    item_lista_1.SubItems.Add("OK").BackColor = Color.Green
                    item_lista_1.SubItems.Add(Math.Round(date_extrase.Item("dif_debit_3"), 1) & " ml")
                    item_lista_1.SubItems.Add(date_extrase.Item("valoare_introdusa_z4"))
                    item_lista_1.SubItems.Add(date_extrase.Item("debit_3"))
                    item_lista_1.Group = lista_atentionari_lst.Groups(0)
                    lista_atentionari_lst.Items.Add(item_lista_1)
                Else
                    item_lista_1.UseItemStyleForSubItems = False
                    item_lista_1.Name = "z1_list"
                    item_lista_1.Text = nr_z
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_1.Group = lista_atentionari_lst.Groups(0)
                    lista_atentionari_lst.Items.Add(item_lista_1)
                End If

                item_lista_2.Text = "Z1"
                item_lista_2.UseItemStyleForSubItems = False
                item_lista_2.Name = "z1_list_1"
                If date_extrase.Contains("dq_vals_0") Then
                    item_lista_2.SubItems.Add(date_extrase.Item("dm_0"))
                    item_lista_2.SubItems.Add("OK").BackColor = Color.Green
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add(Math.Round(date_extrase.Item("dq_vals_0"), 1))
                    item_lista_2.Group = lista_atentionari_lst.Groups(1)
                    lista_atentionari_lst.Items.Add(item_lista_2)
                Else
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.Group = lista_atentionari_lst.Groups(1)
                    lista_atentionari_lst.Items.Add(item_lista_2)
                End If

                item_lista_2 = New ListViewItem
                item_lista_2.Text = "Z2"
                item_lista_2.UseItemStyleForSubItems = False
                item_lista_2.Name = "z2_list_1"
                If date_extrase.Contains("dq_vals_1") Then
                    item_lista_2.SubItems.Add(date_extrase.Item("dm_1"))
                    item_lista_2.SubItems.Add("OK").BackColor = Color.Green
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add(Math.Round(date_extrase.Item("dq_vals_1"), 1))
                    item_lista_2.Group = lista_atentionari_lst.Groups(1)
                    lista_atentionari_lst.Items.Add(item_lista_2)
                Else
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.Group = lista_atentionari_lst.Groups(1)
                    lista_atentionari_lst.Items.Add(item_lista_2)
                End If

                item_lista_2 = New ListViewItem
                item_lista_2.Text = "Z3"
                item_lista_2.UseItemStyleForSubItems = False
                item_lista_2.Name = "z3_list_1"
                If date_extrase.Contains("dq_vals_2") Then
                    item_lista_2.SubItems.Add(date_extrase.Item("dm_2"))
                    item_lista_2.SubItems.Add("OK").BackColor = Color.Green
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add(Math.Round(date_extrase.Item("dq_vals_2"), 1))
                    item_lista_2.Group = lista_atentionari_lst.Groups(1)
                    lista_atentionari_lst.Items.Add(item_lista_2)
                Else
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.Group = lista_atentionari_lst.Groups(1)
                    lista_atentionari_lst.Items.Add(item_lista_2)
                End If

                item_lista_2 = New ListViewItem
                item_lista_2.Text = "Z4"
                item_lista_2.UseItemStyleForSubItems = False
                item_lista_2.Name = "z4_list_1"
                If date_extrase.Contains("dq_vals_3") Then
                    item_lista_2.SubItems.Add(date_extrase.Item("dm_3"))
                    item_lista_2.SubItems.Add("OK").BackColor = Color.Green
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add(Math.Round(date_extrase.Item("dq_vals_3"), 1))
                    item_lista_2.Group = lista_atentionari_lst.Groups(1)
                    lista_atentionari_lst.Items.Add(item_lista_2)
                Else
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_2.Group = lista_atentionari_lst.Groups(1)
                    lista_atentionari_lst.Items.Add(item_lista_2)
                End If

                'diferente Delta Q
                lista_atentionari_lst.Groups(2).Header = "Diferența Delta Q dintre minim si maxim este de " & Math.Round(date_extrase.Item("dif_dq"), 1) & " față de maxim " & date_extrase.Item("dif_dq_max")
                item_lista_3.Text = "Z1"
                item_lista_3.UseItemStyleForSubItems = False
                item_lista_3.Name = "z1_list_2"

                If date_extrase.Contains("dq_vals_0") Then
                    item_lista_3.SubItems.Add(date_extrase.Item("dm_0"))
                    item_lista_3.SubItems.Add("OK").BackColor = Color.Green
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add(Math.Round(date_extrase.Item("dq_vals_0"), 1))
                    item_lista_3.Group = lista_atentionari_lst.Groups(2)
                    lista_atentionari_lst.Items.Add(item_lista_3)
                Else
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.Group = lista_atentionari_lst.Groups(2)
                    lista_atentionari_lst.Items.Add(item_lista_3)
                End If

                item_lista_3 = New ListViewItem
                item_lista_3.Text = "Z2"
                item_lista_3.UseItemStyleForSubItems = False
                item_lista_3.Name = "z2_list_2"
                If date_extrase.Contains("dq_vals_1") Then
                    item_lista_3.SubItems.Add(date_extrase.Item("dm_1"))
                    item_lista_3.SubItems.Add("OK").BackColor = Color.Green
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add(Math.Round(date_extrase.Item("dq_vals_1"), 1))
                    item_lista_3.Group = lista_atentionari_lst.Groups(2)
                    lista_atentionari_lst.Items.Add(item_lista_3)
                Else
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.Group = lista_atentionari_lst.Groups(2)
                    lista_atentionari_lst.Items.Add(item_lista_3)
                End If

                item_lista_3 = New ListViewItem
                item_lista_3.Text = "Z3"
                item_lista_3.UseItemStyleForSubItems = False
                item_lista_3.Name = "z3_list_2"
                If date_extrase.Contains("dq_vals_2") Then
                    item_lista_3.SubItems.Add(date_extrase.Item("dm_2"))
                    item_lista_3.SubItems.Add("OK").BackColor = Color.Green
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add(Math.Round(date_extrase.Item("dq_vals_2"), 1))
                    item_lista_3.Group = lista_atentionari_lst.Groups(2)
                    lista_atentionari_lst.Items.Add(item_lista_3)
                Else
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.Group = lista_atentionari_lst.Groups(2)
                    lista_atentionari_lst.Items.Add(item_lista_3)
                End If

                item_lista_3 = New ListViewItem
                item_lista_3.Text = "Z4"
                item_lista_3.UseItemStyleForSubItems = False
                item_lista_3.Name = "z4_list_2"
                If date_extrase.Contains("dq_vals_3") Then
                    item_lista_3.SubItems.Add(date_extrase.Item("dm_3"))
                    item_lista_3.SubItems.Add("OK").BackColor = Color.Green
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add(Math.Round(date_extrase.Item("dq_vals_3"), 1))
                    item_lista_3.Group = lista_atentionari_lst.Groups(2)
                    lista_atentionari_lst.Items.Add(item_lista_3)
                Else
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.SubItems.Add("N/A").BackColor = Color.Gray
                    item_lista_3.Group = lista_atentionari_lst.Groups(2)
                    lista_atentionari_lst.Items.Add(item_lista_3)
                End If

                If date_extrase.Item("atentionare_0") Or date_extrase.Item("atentionare_1") Or date_extrase.Item("atentionare_2") Or date_extrase.Item("atentionare_3") Then
                    'examinare z1
                    If date_extrase.Item("atentionare_0") Then
                        lista_atentionari_lst.Items.Item("z1_list").SubItems().Item(2).Text = "NOK"
                        lista_atentionari_lst.Items.Item("z1_list").SubItems().Item(2).BackColor = Color.Red
                    End If

                    If date_extrase.Item("atentionare_1") Then
                        lista_atentionari_lst.Items.Item("z2_list").SubItems().Item(2).Text = "NOK"
                        lista_atentionari_lst.Items.Item("z2_list").SubItems().Item(2).BackColor = Color.Red
                    End If

                    If date_extrase.Item("atentionare_2") Then
                        lista_atentionari_lst.Items.Item("z3_list").SubItems().Item(2).Text = "NOK"
                        lista_atentionari_lst.Items.Item("z3_list").SubItems().Item(2).BackColor = Color.Red
                    End If

                    If date_extrase.Item("atentionare_3") Then
                        lista_atentionari_lst.Items.Item("z4_list").SubItems().Item(2).Text = "NOK"
                        lista_atentionari_lst.Items.Item("z4_list").SubItems().Item(2).BackColor = Color.Red
                    End If
                End If

                If date_extrase.Item("atentionare_4") Or date_extrase.Item("atentionare_5") Or date_extrase.Item("atentionare_6") Or date_extrase.Item("atentionare_7") Then
                    If date_extrase.Item("atentionare_4") Then
                        lista_atentionari_lst.Items.Item("z1_list_1").SubItems().Item(2).Text = "NOK"
                        lista_atentionari_lst.Items.Item("z1_list_1").SubItems().Item(2).BackColor = Color.Red
                    End If

                    If date_extrase.Item("atentionare_5") Then
                        lista_atentionari_lst.Items.Item("z2_list_1").SubItems().Item(2).Text = "NOK"
                        lista_atentionari_lst.Items.Item("z2_list_1").SubItems().Item(2).BackColor = Color.Red
                    End If

                    If date_extrase.Item("atentionare_6") Then
                        lista_atentionari_lst.Items.Item("z3_list_1").SubItems().Item(2).Text = "NOK"
                        lista_atentionari_lst.Items.Item("z3_list_1").SubItems().Item(2).BackColor = Color.Red
                    End If

                    If date_extrase.Item("atentionare_7") Then
                        lista_atentionari_lst.Items.Item("z4_list_1").SubItems().Item(2).Text = "NOK"
                        lista_atentionari_lst.Items.Item("z4_list_1").SubItems().Item(2).BackColor = Color.Red
                    End If
                End If

                If date_extrase.Item("atentionare_8") Or date_extrase.Item("atentionare_9") Or date_extrase.Item("atentionare_10") Or date_extrase.Item("atentionare_11") Then
                    If date_extrase.Item("atentionare_8") Then
                        lista_atentionari_lst.Items.Item("z1_list_2").SubItems().Item(2).Text = "NOK"
                        lista_atentionari_lst.Items.Item("z1_list_2").SubItems().Item(2).BackColor = Color.Red
                    End If

                    If date_extrase.Item("atentionare_9") Then
                        lista_atentionari_lst.Items.Item("z2_list_2").SubItems().Item(2).Text = "NOK"
                        lista_atentionari_lst.Items.Item("z2_list_2").SubItems().Item(2).BackColor = Color.Red
                    End If

                    If date_extrase.Item("atentionare_10") Then
                        lista_atentionari_lst.Items.Item("z3_list_2").SubItems().Item(2).Text = "NOK"
                        lista_atentionari_lst.Items.Item("z3_list_2").SubItems().Item(2).BackColor = Color.Red
                    End If

                    If date_extrase.Item("atentionare_11") Then
                        lista_atentionari_lst.Items.Item("z4_list_2").SubItems().Item(2).Text = "NOK"
                        lista_atentionari_lst.Items.Item("z4_list_2").SubItems().Item(2).BackColor = Color.Red
                    End If
                End If
            End If
            End If
    End Sub

    Private Sub vizibilitate_panou(panou As Panel)
        Dim element As Panel

        For Each element In Me.Controls.OfType(Of Panel)
            If element.Name = panou.Name Then
                panou.Visible = True
            ElseIf element.Name = "panou_butoane_pnl" Then
                element.Visible = True
            Else
                element.Visible = False
            End If
        Next
    End Sub

    Private Sub lista_masini_pnl_VisibleChanged(sender As Object, e As EventArgs) Handles lista_masini_pnl.VisibleChanged
        If lista_masini_pnl.Visible = False Then
            button_flow_pnl.Controls.Clear()
        End If
    End Sub

    Private Sub fereastra_principala_frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        vizibilitate_panou(New Panel)
    End Sub

    Private Function get_machines() As Dictionary(Of String, String)
        Dim conexiune_bd As New SqliteConnection("data source=" & locatie_bd)
        Dim comanda = conexiune_bd.CreateCommand
        Dim reader As SqliteDataReader
        Dim incr As Integer

        get_machines = New Dictionary(Of String, String)
        conexiune_bd.Open()
        comanda.CommandText = "select nr_producator, nr_operatie, id_masina from masini m where
                                producator = 'Posalux'
                                order by id_masina asc"
        reader = comanda.ExecuteReader()

        Using reader
            While reader.Read()
                get_machines.Add("nr_producator_" & incr, reader.GetString(0))
                get_machines.Add("nr_operatie_" & incr, reader.GetString(1))
                get_machines.Add("id_masina_" & incr, reader.GetInt16(2))
                incr += 1
            End While
        End Using
        comanda.Dispose()
        reader.Close()
    End Function

    Private Sub adauga_butoane(ByRef container_fluid As FlowLayoutPanel)
        Dim buton As Button
        Dim masini As IDictionary
        'Dim id_producator As String

        masini = get_machines()

        For incr = 0 To (masini.Count / 3) - 1
            buton = New Button
            'id_producator = masini.Item("nr_producator_" & incr)
            buton.Text = masini.Item("nr_operatie_" & incr) & Environment.NewLine & "MH." & masini.Item("nr_producator_" & incr).Substring(masini.Item("nr_producator_" & incr).Length - 3)
            buton.Name = masini.Item("id_masina_" & incr) & "_btn"
            buton.Tag = masini.Item("id_masina_" & incr)
            buton.BackColor = Color.CadetBlue
            buton.Location = New System.Drawing.Point(3, 3)
            buton.Size = New System.Drawing.Size(140, 66)
            buton.FlatStyle = FlatStyle.Flat
            'buton.UseVisualStyleBackColor = True
            container_fluid.Controls.Add(buton)
            If container_fluid.Name = "button_flow_pnl" Then
                AddHandler buton.Click, AddressOf buton_masini_click
            ElseIf container_fluid.Name = "" Then
            End If
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If reactualizare_date_btn.Enabled = False Then
            reactualizare_date_btn.Enabled = True
        End If
        Timer1.Stop()
    End Sub

    Private Sub reactualizare_date_btn_Click(sender As Object, e As EventArgs) Handles reactualizare_date_btn.Click
        Timer1.Start()
        reactualizare_date_btn.Enabled = False
        If tabel_valori_dgv.Visible Then
            actualizare_tabel_valori()
        End If
    End Sub

    Private Sub actualizare_tabel_valori()
        tabel_valori_dgv.Rows.Clear()
        Dim conexiune_bd As New SqliteConnection("data source=" & locatie_bd)
        Dim continut_bd As New DataSet
        Dim datacurenta As String = String.Format("{0:yyyy-MM-dd}", DateTime.Now)
        Dim ieri As String = String.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-1))
        Dim moment_curent As DateTime = DateTime.Now
        Dim data_inceput As String = ""
        Dim data_sfarsit As String = ""

        Select Case moment_curent.Hour
            Case 6 To 13
                data_inceput = datacurenta & " " & "06:00:00"
                data_sfarsit = datacurenta & " " & "14:00:00"
            Case 14 To 21
                data_inceput = datacurenta & " " & "14:00:00"
                data_sfarsit = datacurenta & " " & "22:00:00"
            Case 22 To 23
                data_inceput = datacurenta & " " & "22:00:00"
                data_sfarsit = datacurenta & " " & "23:59:59"
            Case 0 To 5
                data_inceput = ieri & " " & "22:00:00"
                data_sfarsit = datacurenta & " " & "06:00:00"
        End Select

        conexiune_bd.Open()
        Dim comanda = conexiune_bd.CreateCommand
        comanda.CommandText = "select data, dm, referinta, nr_caseta, debit, delta_q, nr_cuib, rowid from valori where 
                                   data between '" & data_inceput & "' and '" & data_sfarsit & "' and spc_id is null and referinta like 'L%' order by data asc"
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
        comanda.Dispose()
        conexiune_bd.Close()
    End Sub
End Class


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
            Dim conexiune_bd As New SqliteConnection("data source=D:\working\delphi\OP140\Monitorizare debite DeltaQ\Monitorizare debite DeltaQ\DeltaQValues.db")
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
        Dim conexiune_bd As New SqliteConnection("data source=D:\working\delphi\OP140\Monitorizare debite DeltaQ\Monitorizare debite DeltaQ\DeltaQValues.db")
        Dim comanda = conexiune_bd.CreateCommand
        Dim reader As SqliteDataReader
        Dim id_masina As Integer
        Dim rand As DataGridViewRow
        Dim comanda_executata As Integer

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
        comanda.CommandText = "insert into spc_posalux (nr_marca, valoare_z1, valoare_z2, valoare_z3, valoare_z4, referinta, masina) values (" & nr_marca_tb.Text & ", " & If(z1_tb.Text = "*", "", z1_tb.Text) & ", " & If(z2_tb.Text = "*", "", z2_tb.Text) & ", " & If(z3_tb.Text = "*", "", z3_tb.Text) & ", " & If(z4_tb.Text = "*", "", z4_tb.Text) & ", '" & tabel_valori_dgv.Item(2, tabel_valori_dgv.CurrentRow.Index).Value & "'," & id_masina & ")"
        'Debug.Print("insert into spc_posalux (nr_marca, valoare_z1, valoare_z2, valoare_z3, valoare_z4, referinta, masina) values (" & nr_marca_tb.Text & ", " & If(z1_tb.Text = "*", "", z1_tb.Text) & ", " & If(z2_tb.Text = "*", "", z2_tb.Text) & ", " & If(z3_tb.Text = "*", "", z3_tb.Text) & ", " & If(z4_tb.Text = "*", "", z4_tb.Text) & ", '" & tabel_valori_dgv.Item(2, tabel_valori_dgv.CurrentRow.Index).Value & "'," & id_masina & ")")
        comanda_executata = comanda.ExecuteNonQuery()
        conexiune_bd.Close()

        If comanda_executata = 1 Then
            nr_marca_tb.Text = ""
            adauga_valori_pnl.Visible = False
            grafice_pnl.Visible = True
        End If
    End Sub

    Private Sub grafice_pnl_VisibleChanged(sender As Object, e As EventArgs) Handles grafice_pnl.VisibleChanged
        If grafice_pnl.Visible = True Then
            'grafic = dif_z1_pb.CreateGraphics
        End If
    End Sub

    Private Sub vizualizare_grafice_btn_Click(sender As Object, e As EventArgs) Handles vizualizare_grafice_btn.Click
        grafice_pnl.Visible = True
    End Sub

    Private Sub grafice_pnl_Paint(sender As Object, e As PaintEventArgs) Handles grafice_pnl.Paint

    End Sub

    Private Sub dif_z1_pb_Paint(sender As Object, e As PaintEventArgs) Handles dif_z1_pb.Paint
        Dim inaltime_pb As Int16
        Dim latime_pb As Int16
        Dim Pen As New Pen(Color.Red, 2)
        Dim GraphContextZ1 As BufferedGraphicsContext
        Dim graficZ1 As BufferedGraphics
        Dim surfacePoint As New SolidBrush(Color.Black)

        inaltime_pb = CInt(dif_z1_pb.Height)
        latime_pb = CInt(dif_z1_pb.Width)

        'Pen.DashCap = System.Drawing.Drawing2D.DashCap.Round
        Pen.DashPattern = New Single() {5, 3, 2, 2}

        GraphContextZ1 = BufferedGraphicsManager.Current
        GraphContextZ1.MaximumBuffer = New Size(latime_pb + 1, inaltime_pb + 1)
        graficZ1 = GraphContextZ1.Allocate(dif_z1_pb.CreateGraphics(), New Rectangle(0, 0, latime_pb, inaltime_pb))
        graficZ1.Graphics.FillRectangle(Brushes.WhiteSmoke, 0, 0, latime_pb, inaltime_pb)

        'afisare linie limita maxima diferenta
        graficZ1.Graphics.DrawLine(Pen, New Point(20, inaltime_pb / 2), New Point(latime_pb, inaltime_pb / 2))
        Pen.Color = Color.Green
        graficZ1.Graphics.DrawLine(Pen, New Point(0, 0.1 * inaltime_pb), New Point(latime_pb, 0.1 * inaltime_pb))
        graficZ1.Graphics.DrawLine(Pen, New Point(0, inaltime_pb - 0.1 * inaltime_pb), New Point(latime_pb, inaltime_pb - 0.1 * inaltime_pb))

        'afisare linie nominala diferente debit
        graficZ1.Graphics.DrawString("1", New Font("Consolas", 12, FontStyle.Bold), surfacePoint, New Point(0, inaltime_pb / 2 - 10))

        'afisare puncte valori
        graficZ1.Graphics.FillEllipse(surfacePoint, New Rectangle(25, inaltime_pb / 2.1, 7, 7))
        graficZ1.Render(e.Graphics)
    End Sub
End Class
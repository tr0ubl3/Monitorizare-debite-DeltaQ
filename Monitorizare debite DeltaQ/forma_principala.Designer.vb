<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fereastra_principala_frm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ListViewGroup10 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Diferențe debit între Posalux și Delta Q", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup11 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Delta Q în afara toleranței", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup12 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Diferența Delta Q mai mare decât limita impusă", System.Windows.Forms.HorizontalAlignment.Left)
        Me.panou_butoane_pnl = New System.Windows.Forms.Panel()
        Me.lista_atentionari_btn = New FontAwesome.Sharp.IconButton()
        Me.vizualizare_grafice_btn = New FontAwesome.Sharp.IconButton()
        Me.adauga_valori_btn = New FontAwesome.Sharp.IconButton()
        Me.grafice_pnl = New System.Windows.Forms.Panel()
        Me.dif_debit_z1_chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.adauga_valori_pnl = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.z1_lbl = New System.Windows.Forms.Label()
        Me.z3_lbl = New System.Windows.Forms.Label()
        Me.z4_lbl = New System.Windows.Forms.Label()
        Me.z2_tb = New System.Windows.Forms.TextBox()
        Me.z3_tb = New System.Windows.Forms.TextBox()
        Me.z4_tb = New System.Windows.Forms.TextBox()
        Me.z1_tb = New System.Windows.Forms.TextBox()
        Me.z2_lbl = New System.Windows.Forms.Label()
        Me.tabel_valori_dgv = New System.Windows.Forms.DataGridView()
        Me.data_ora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.referinta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.caseta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delta_q = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nr_cuib = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_rand_rezultate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit_posalux_lbl = New System.Windows.Forms.Label()
        Me.nr_masina_cb = New System.Windows.Forms.ComboBox()
        Me.nr_masina_lbl = New System.Windows.Forms.Label()
        Me.nr_marca_lbl = New System.Windows.Forms.Label()
        Me.nr_marca_tb = New System.Windows.Forms.TextBox()
        Me.salveaza_valori_btn = New FontAwesome.Sharp.IconButton()
        Me.lista_atentionari_pnl = New System.Windows.Forms.Panel()
        Me.lista_masini_pnl = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.id_atentionare = New System.Windows.Forms.Label()
        Me.lista_atentionari_lst = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.panou_butoane_pnl.SuspendLayout()
        Me.grafice_pnl.SuspendLayout()
        CType(Me.dif_debit_z1_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.adauga_valori_pnl.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.tabel_valori_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lista_atentionari_pnl.SuspendLayout()
        Me.lista_masini_pnl.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panou_butoane_pnl
        '
        Me.panou_butoane_pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.panou_butoane_pnl.Controls.Add(Me.lista_atentionari_btn)
        Me.panou_butoane_pnl.Controls.Add(Me.vizualizare_grafice_btn)
        Me.panou_butoane_pnl.Controls.Add(Me.adauga_valori_btn)
        Me.panou_butoane_pnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.panou_butoane_pnl.Location = New System.Drawing.Point(0, 0)
        Me.panou_butoane_pnl.Margin = New System.Windows.Forms.Padding(0)
        Me.panou_butoane_pnl.Name = "panou_butoane_pnl"
        Me.panou_butoane_pnl.Size = New System.Drawing.Size(200, 651)
        Me.panou_butoane_pnl.TabIndex = 0
        '
        'lista_atentionari_btn
        '
        Me.lista_atentionari_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.lista_atentionari_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lista_atentionari_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.lista_atentionari_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lista_atentionari_btn.IconChar = FontAwesome.Sharp.IconChar.Info
        Me.lista_atentionari_btn.IconColor = System.Drawing.Color.Black
        Me.lista_atentionari_btn.IconSize = 42
        Me.lista_atentionari_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lista_atentionari_btn.Location = New System.Drawing.Point(0, 98)
        Me.lista_atentionari_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.lista_atentionari_btn.Name = "lista_atentionari_btn"
        Me.lista_atentionari_btn.Rotation = 0R
        Me.lista_atentionari_btn.Size = New System.Drawing.Size(200, 50)
        Me.lista_atentionari_btn.TabIndex = 3
        Me.lista_atentionari_btn.Text = "Lista atentionari"
        Me.lista_atentionari_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lista_atentionari_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.lista_atentionari_btn.UseVisualStyleBackColor = False
        '
        'vizualizare_grafice_btn
        '
        Me.vizualizare_grafice_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.vizualizare_grafice_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vizualizare_grafice_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.vizualizare_grafice_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.vizualizare_grafice_btn.IconChar = FontAwesome.Sharp.IconChar.ChartArea
        Me.vizualizare_grafice_btn.IconColor = System.Drawing.Color.Black
        Me.vizualizare_grafice_btn.IconSize = 42
        Me.vizualizare_grafice_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.vizualizare_grafice_btn.Location = New System.Drawing.Point(0, 47)
        Me.vizualizare_grafice_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.vizualizare_grafice_btn.Name = "vizualizare_grafice_btn"
        Me.vizualizare_grafice_btn.Rotation = 0R
        Me.vizualizare_grafice_btn.Size = New System.Drawing.Size(200, 50)
        Me.vizualizare_grafice_btn.TabIndex = 2
        Me.vizualizare_grafice_btn.Text = "Vizualizare grafice"
        Me.vizualizare_grafice_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.vizualizare_grafice_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.vizualizare_grafice_btn.UseVisualStyleBackColor = False
        '
        'adauga_valori_btn
        '
        Me.adauga_valori_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.adauga_valori_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adauga_valori_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.adauga_valori_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.adauga_valori_btn.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.adauga_valori_btn.IconColor = System.Drawing.Color.Black
        Me.adauga_valori_btn.IconSize = 42
        Me.adauga_valori_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.adauga_valori_btn.Location = New System.Drawing.Point(0, 149)
        Me.adauga_valori_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.adauga_valori_btn.Name = "adauga_valori_btn"
        Me.adauga_valori_btn.Rotation = 0R
        Me.adauga_valori_btn.Size = New System.Drawing.Size(200, 55)
        Me.adauga_valori_btn.TabIndex = 1
        Me.adauga_valori_btn.Text = "Adaugă valori"
        Me.adauga_valori_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.adauga_valori_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.adauga_valori_btn.UseVisualStyleBackColor = False
        '
        'grafice_pnl
        '
        Me.grafice_pnl.AutoScroll = True
        Me.grafice_pnl.BackColor = System.Drawing.Color.Moccasin
        Me.grafice_pnl.Controls.Add(Me.dif_debit_z1_chart)
        Me.grafice_pnl.Controls.Add(Me.Label3)
        Me.grafice_pnl.Controls.Add(Me.Label2)
        Me.grafice_pnl.Controls.Add(Me.Label1)
        Me.grafice_pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grafice_pnl.Location = New System.Drawing.Point(0, 0)
        Me.grafice_pnl.Name = "grafice_pnl"
        Me.grafice_pnl.Size = New System.Drawing.Size(1024, 651)
        Me.grafice_pnl.TabIndex = 9
        Me.grafice_pnl.Visible = False
        '
        'dif_debit_z1_chart
        '
        Me.dif_debit_z1_chart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea4.AxisX.MinorGrid.LineColor = System.Drawing.Color.White
        ChartArea4.AxisX.ScaleView.Size = 40.0R
        ChartArea4.AxisX2.LineColor = System.Drawing.Color.White
        ChartArea4.AxisY.Interval = 18.0R
        ChartArea4.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea4.AxisY.IsLabelAutoFit = False
        ChartArea4.AxisY.LineColor = System.Drawing.Color.White
        ChartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea4.AxisY.Maximum = 5.0R
        ChartArea4.AxisY.MaximumAutoSize = 85.0!
        ChartArea4.AxisY.Minimum = -5.0R
        ChartArea4.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        ChartArea4.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea4.AxisY2.LineColor = System.Drawing.Color.White
        ChartArea4.BackColor = System.Drawing.Color.WhiteSmoke
        ChartArea4.Name = "ChartArea1"
        Me.dif_debit_z1_chart.ChartAreas.Add(ChartArea4)
        Legend4.Enabled = False
        Legend4.Name = "Legend1"
        Me.dif_debit_z1_chart.Legends.Add(Legend4)
        Me.dif_debit_z1_chart.Location = New System.Drawing.Point(216, 34)
        Me.dif_debit_z1_chart.Name = "dif_debit_z1_chart"
        Me.dif_debit_z1_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series4.Color = System.Drawing.Color.Black
        Series4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Series4.IsVisibleInLegend = False
        Series4.Legend = "Legend1"
        Series4.Name = "valori"
        Me.dif_debit_z1_chart.Series.Add(Series4)
        Me.dif_debit_z1_chart.Size = New System.Drawing.Size(764, 261)
        Me.dif_debit_z1_chart.TabIndex = 10
        Me.dif_debit_z1_chart.Text = "Chart1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(649, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(229, 205)
        Me.Label2.MaximumSize = New System.Drawing.Size(800, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Z1 - valoare Delta Q"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(212, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Z1 - diferență debit Posalux vs Delta Q"
        '
        'adauga_valori_pnl
        '
        Me.adauga_valori_pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.adauga_valori_pnl.Controls.Add(Me.FlowLayoutPanel1)
        Me.adauga_valori_pnl.Controls.Add(Me.TableLayoutPanel1)
        Me.adauga_valori_pnl.Controls.Add(Me.tabel_valori_dgv)
        Me.adauga_valori_pnl.Controls.Add(Me.debit_posalux_lbl)
        Me.adauga_valori_pnl.Controls.Add(Me.nr_masina_cb)
        Me.adauga_valori_pnl.Controls.Add(Me.nr_masina_lbl)
        Me.adauga_valori_pnl.Controls.Add(Me.nr_marca_lbl)
        Me.adauga_valori_pnl.Controls.Add(Me.nr_marca_tb)
        Me.adauga_valori_pnl.Controls.Add(Me.salveaza_valori_btn)
        Me.adauga_valori_pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.adauga_valori_pnl.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.adauga_valori_pnl.Location = New System.Drawing.Point(0, 0)
        Me.adauga_valori_pnl.Margin = New System.Windows.Forms.Padding(0)
        Me.adauga_valori_pnl.Name = "adauga_valori_pnl"
        Me.adauga_valori_pnl.Size = New System.Drawing.Size(1024, 651)
        Me.adauga_valori_pnl.TabIndex = 1
        Me.adauga_valori_pnl.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.FlowLayoutPanel1.TabIndex = 9
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.z1_lbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.z3_lbl, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.z4_lbl, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.z2_tb, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.z3_tb, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.z4_tb, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.z1_tb, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.z2_lbl, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(207, 126)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(502, 93)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'z1_lbl
        '
        Me.z1_lbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.z1_lbl.AutoSize = True
        Me.z1_lbl.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.z1_lbl.Location = New System.Drawing.Point(3, 0)
        Me.z1_lbl.Name = "z1_lbl"
        Me.z1_lbl.Size = New System.Drawing.Size(119, 46)
        Me.z1_lbl.TabIndex = 0
        Me.z1_lbl.Text = "Z1"
        Me.z1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'z3_lbl
        '
        Me.z3_lbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.z3_lbl.AutoSize = True
        Me.z3_lbl.Font = New System.Drawing.Font("Consolas", 20.0!, System.Drawing.FontStyle.Bold)
        Me.z3_lbl.Location = New System.Drawing.Point(253, 0)
        Me.z3_lbl.Name = "z3_lbl"
        Me.z3_lbl.Size = New System.Drawing.Size(119, 46)
        Me.z3_lbl.TabIndex = 2
        Me.z3_lbl.Text = "Z3"
        Me.z3_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'z4_lbl
        '
        Me.z4_lbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.z4_lbl.AutoSize = True
        Me.z4_lbl.Font = New System.Drawing.Font("Consolas", 20.0!, System.Drawing.FontStyle.Bold)
        Me.z4_lbl.Location = New System.Drawing.Point(378, 0)
        Me.z4_lbl.Name = "z4_lbl"
        Me.z4_lbl.Size = New System.Drawing.Size(121, 46)
        Me.z4_lbl.TabIndex = 3
        Me.z4_lbl.Text = "Z4"
        Me.z4_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'z2_tb
        '
        Me.z2_tb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.z2_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.z2_tb.Font = New System.Drawing.Font("Consolas", 22.0!, System.Drawing.FontStyle.Bold)
        Me.z2_tb.Location = New System.Drawing.Point(128, 49)
        Me.z2_tb.MaxLength = 3
        Me.z2_tb.Multiline = True
        Me.z2_tb.Name = "z2_tb"
        Me.z2_tb.Size = New System.Drawing.Size(119, 41)
        Me.z2_tb.TabIndex = 5
        Me.z2_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.z2_tb.WordWrap = False
        '
        'z3_tb
        '
        Me.z3_tb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.z3_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.z3_tb.Font = New System.Drawing.Font("Consolas", 22.0!, System.Drawing.FontStyle.Bold)
        Me.z3_tb.Location = New System.Drawing.Point(253, 49)
        Me.z3_tb.MaxLength = 3
        Me.z3_tb.Multiline = True
        Me.z3_tb.Name = "z3_tb"
        Me.z3_tb.Size = New System.Drawing.Size(119, 41)
        Me.z3_tb.TabIndex = 6
        Me.z3_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.z3_tb.WordWrap = False
        '
        'z4_tb
        '
        Me.z4_tb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.z4_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.z4_tb.Font = New System.Drawing.Font("Consolas", 22.0!, System.Drawing.FontStyle.Bold)
        Me.z4_tb.Location = New System.Drawing.Point(378, 49)
        Me.z4_tb.MaxLength = 3
        Me.z4_tb.Multiline = True
        Me.z4_tb.Name = "z4_tb"
        Me.z4_tb.Size = New System.Drawing.Size(121, 41)
        Me.z4_tb.TabIndex = 7
        Me.z4_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.z4_tb.WordWrap = False
        '
        'z1_tb
        '
        Me.z1_tb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.z1_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.z1_tb.Font = New System.Drawing.Font("Consolas", 22.0!, System.Drawing.FontStyle.Bold)
        Me.z1_tb.Location = New System.Drawing.Point(3, 49)
        Me.z1_tb.MaxLength = 3
        Me.z1_tb.Multiline = True
        Me.z1_tb.Name = "z1_tb"
        Me.z1_tb.Size = New System.Drawing.Size(119, 41)
        Me.z1_tb.TabIndex = 4
        Me.z1_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.z1_tb.WordWrap = False
        '
        'z2_lbl
        '
        Me.z2_lbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.z2_lbl.AutoSize = True
        Me.z2_lbl.Font = New System.Drawing.Font("Consolas", 20.0!, System.Drawing.FontStyle.Bold)
        Me.z2_lbl.Location = New System.Drawing.Point(128, 0)
        Me.z2_lbl.Name = "z2_lbl"
        Me.z2_lbl.Size = New System.Drawing.Size(119, 46)
        Me.z2_lbl.TabIndex = 1
        Me.z2_lbl.Text = "Z2"
        Me.z2_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabel_valori_dgv
        '
        Me.tabel_valori_dgv.AllowUserToAddRows = False
        Me.tabel_valori_dgv.AllowUserToDeleteRows = False
        Me.tabel_valori_dgv.AllowUserToResizeColumns = False
        Me.tabel_valori_dgv.AllowUserToResizeRows = False
        Me.tabel_valori_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.tabel_valori_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabel_valori_dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.data_ora, Me.dm, Me.referinta, Me.caseta, Me.debit, Me.delta_q, Me.nr_cuib, Me.id_rand_rezultate})
        Me.tabel_valori_dgv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabel_valori_dgv.Location = New System.Drawing.Point(210, 225)
        Me.tabel_valori_dgv.Name = "tabel_valori_dgv"
        Me.tabel_valori_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabel_valori_dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.tabel_valori_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.tabel_valori_dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tabel_valori_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabel_valori_dgv.Size = New System.Drawing.Size(802, 315)
        Me.tabel_valori_dgv.TabIndex = 6
        Me.tabel_valori_dgv.Visible = False
        '
        'data_ora
        '
        Me.data_ora.HeaderText = "Data/ora"
        Me.data_ora.Name = "data_ora"
        Me.data_ora.ReadOnly = True
        Me.data_ora.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_ora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.data_ora.Width = 150
        '
        'dm
        '
        Me.dm.HeaderText = "DM"
        Me.dm.Name = "dm"
        Me.dm.ReadOnly = True
        Me.dm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dm.Width = 130
        '
        'referinta
        '
        Me.referinta.HeaderText = "Referinta"
        Me.referinta.Name = "referinta"
        Me.referinta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'caseta
        '
        Me.caseta.HeaderText = "Caseta"
        Me.caseta.Name = "caseta"
        Me.caseta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.caseta.Width = 70
        '
        'debit
        '
        Me.debit.HeaderText = "Debit"
        Me.debit.Name = "debit"
        Me.debit.ReadOnly = True
        Me.debit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.debit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'delta_q
        '
        Me.delta_q.HeaderText = "DeltaQ"
        Me.delta_q.Name = "delta_q"
        Me.delta_q.ReadOnly = True
        Me.delta_q.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.delta_q.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'nr_cuib
        '
        Me.nr_cuib.HeaderText = "Nr cuib"
        Me.nr_cuib.Name = "nr_cuib"
        Me.nr_cuib.ReadOnly = True
        Me.nr_cuib.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'id_rand_rezultate
        '
        Me.id_rand_rezultate.HeaderText = "Id rand rezultate"
        Me.id_rand_rezultate.Name = "id_rand_rezultate"
        Me.id_rand_rezultate.Visible = False
        '
        'debit_posalux_lbl
        '
        Me.debit_posalux_lbl.AutoSize = True
        Me.debit_posalux_lbl.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.debit_posalux_lbl.Location = New System.Drawing.Point(203, 107)
        Me.debit_posalux_lbl.Name = "debit_posalux_lbl"
        Me.debit_posalux_lbl.Size = New System.Drawing.Size(126, 19)
        Me.debit_posalux_lbl.TabIndex = 5
        Me.debit_posalux_lbl.Text = "Debit Posalux"
        '
        'nr_masina_cb
        '
        Me.nr_masina_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nr_masina_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nr_masina_cb.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold)
        Me.nr_masina_cb.FormattingEnabled = True
        Me.nr_masina_cb.Items.AddRange(New Object() {"1 - 140.1", "2 - 140.2", "3 - 140.3", "4 - 140.4", "5 - 140.5", "6 - 140.6", "7 - 140.7", "8 - 140.8", "9 - 140.9", "10 - 140.10", "11 - 140.11", "12 - 140.12", "13 - 140.13", "14 - 140.14"})
        Me.nr_masina_cb.Location = New System.Drawing.Point(345, 61)
        Me.nr_masina_cb.Name = "nr_masina_cb"
        Me.nr_masina_cb.Size = New System.Drawing.Size(364, 36)
        Me.nr_masina_cb.TabIndex = 3
        '
        'nr_masina_lbl
        '
        Me.nr_masina_lbl.AutoSize = True
        Me.nr_masina_lbl.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nr_masina_lbl.Location = New System.Drawing.Point(203, 65)
        Me.nr_masina_lbl.Name = "nr_masina_lbl"
        Me.nr_masina_lbl.Size = New System.Drawing.Size(117, 19)
        Me.nr_masina_lbl.TabIndex = 2
        Me.nr_masina_lbl.Text = "Număr mașină"
        '
        'nr_marca_lbl
        '
        Me.nr_marca_lbl.AutoSize = True
        Me.nr_marca_lbl.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nr_marca_lbl.Location = New System.Drawing.Point(203, 21)
        Me.nr_marca_lbl.Name = "nr_marca_lbl"
        Me.nr_marca_lbl.Size = New System.Drawing.Size(108, 19)
        Me.nr_marca_lbl.TabIndex = 1
        Me.nr_marca_lbl.Text = "Număr marcă"
        '
        'nr_marca_tb
        '
        Me.nr_marca_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nr_marca_tb.Font = New System.Drawing.Font("Consolas", 20.0!, System.Drawing.FontStyle.Bold)
        Me.nr_marca_tb.Location = New System.Drawing.Point(345, 12)
        Me.nr_marca_tb.MaxLength = 5
        Me.nr_marca_tb.Name = "nr_marca_tb"
        Me.nr_marca_tb.Size = New System.Drawing.Size(364, 39)
        Me.nr_marca_tb.TabIndex = 0
        Me.nr_marca_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'salveaza_valori_btn
        '
        Me.salveaza_valori_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.salveaza_valori_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.salveaza_valori_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.salveaza_valori_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.salveaza_valori_btn.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.salveaza_valori_btn.ForeColor = System.Drawing.Color.Black
        Me.salveaza_valori_btn.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.salveaza_valori_btn.IconColor = System.Drawing.Color.Black
        Me.salveaza_valori_btn.IconSize = 32
        Me.salveaza_valori_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.salveaza_valori_btn.Location = New System.Drawing.Point(756, 593)
        Me.salveaza_valori_btn.Name = "salveaza_valori_btn"
        Me.salveaza_valori_btn.Rotation = 0R
        Me.salveaza_valori_btn.Size = New System.Drawing.Size(256, 36)
        Me.salveaza_valori_btn.TabIndex = 7
        Me.salveaza_valori_btn.Text = "Salvează"
        Me.salveaza_valori_btn.UseVisualStyleBackColor = False
        '
        'lista_atentionari_pnl
        '
        Me.lista_atentionari_pnl.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lista_atentionari_pnl.Controls.Add(Me.id_atentionare)
        Me.lista_atentionari_pnl.Controls.Add(Me.lista_atentionari_lst)
        Me.lista_atentionari_pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lista_atentionari_pnl.Location = New System.Drawing.Point(0, 0)
        Me.lista_atentionari_pnl.Name = "lista_atentionari_pnl"
        Me.lista_atentionari_pnl.Size = New System.Drawing.Size(1024, 651)
        Me.lista_atentionari_pnl.TabIndex = 11
        '
        'lista_masini_pnl
        '
        Me.lista_masini_pnl.BackColor = System.Drawing.Color.SlateGray
        Me.lista_masini_pnl.Controls.Add(Me.FlowLayoutPanel2)
        Me.lista_masini_pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lista_masini_pnl.Location = New System.Drawing.Point(0, 0)
        Me.lista_masini_pnl.Name = "lista_masini_pnl"
        Me.lista_masini_pnl.Size = New System.Drawing.Size(1024, 651)
        Me.lista_masini_pnl.TabIndex = 2
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button5)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button6)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button7)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button8)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button9)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button10)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button11)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button12)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button13)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button14)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(217, 57)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(763, 427)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 66)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'id_atentionare
        '
        Me.id_atentionare.AutoSize = True
        Me.id_atentionare.BackColor = System.Drawing.Color.LightSkyBlue
        Me.id_atentionare.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_atentionare.Location = New System.Drawing.Point(213, 21)
        Me.id_atentionare.Name = "id_atentionare"
        Me.id_atentionare.Size = New System.Drawing.Size(108, 19)
        Me.id_atentionare.TabIndex = 1
        Me.id_atentionare.Text = "Atenționare"
        '
        'lista_atentionari_lst
        '
        Me.lista_atentionari_lst.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.lista_atentionari_lst.AutoArrange = False
        Me.lista_atentionari_lst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lista_atentionari_lst.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lista_atentionari_lst.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.lista_atentionari_lst.FullRowSelect = True
        Me.lista_atentionari_lst.GridLines = True
        ListViewGroup10.Header = "Diferențe debit între Posalux și Delta Q"
        ListViewGroup10.Name = "dif_debit"
        ListViewGroup11.Header = "Delta Q în afara toleranței"
        ListViewGroup11.Name = "dq_val"
        ListViewGroup12.Header = "Diferența Delta Q mai mare decât limita impusă"
        ListViewGroup12.Name = "dif_dq"
        Me.lista_atentionari_lst.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup10, ListViewGroup11, ListViewGroup12})
        Me.lista_atentionari_lst.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lista_atentionari_lst.HideSelection = False
        Me.lista_atentionari_lst.LabelWrap = False
        Me.lista_atentionari_lst.Location = New System.Drawing.Point(216, 87)
        Me.lista_atentionari_lst.MultiSelect = False
        Me.lista_atentionari_lst.Name = "lista_atentionari_lst"
        Me.lista_atentionari_lst.Size = New System.Drawing.Size(748, 367)
        Me.lista_atentionari_lst.TabIndex = 0
        Me.lista_atentionari_lst.UseCompatibleStateImageBehavior = False
        Me.lista_atentionari_lst.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Spindle"
        Me.ColumnHeader1.Width = 143
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Rezolutie"
        Me.ColumnHeader2.Width = 240
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(152, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 66)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(301, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 66)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(450, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(143, 66)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(599, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(143, 66)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(3, 75)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(143, 66)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(152, 75)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(143, 66)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(301, 75)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(143, 66)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(450, 75)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(143, 66)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(599, 75)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(143, 66)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(3, 147)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(143, 66)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "Button11"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(152, 147)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(143, 66)
        Me.Button12.TabIndex = 11
        Me.Button12.Text = "Button12"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(301, 147)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(143, 66)
        Me.Button13.TabIndex = 12
        Me.Button13.Text = "Button13"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(450, 147)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(143, 66)
        Me.Button14.TabIndex = 13
        Me.Button14.Text = "Button14"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'fereastra_principala_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 651)
        Me.Controls.Add(Me.panou_butoane_pnl)
        Me.Controls.Add(Me.lista_masini_pnl)
        Me.Controls.Add(Me.lista_atentionari_pnl)
        Me.Controls.Add(Me.grafice_pnl)
        Me.Controls.Add(Me.adauga_valori_pnl)
        Me.MinimumSize = New System.Drawing.Size(1040, 690)
        Me.Name = "fereastra_principala_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adaugă valori"
        Me.panou_butoane_pnl.ResumeLayout(False)
        Me.grafice_pnl.ResumeLayout(False)
        Me.grafice_pnl.PerformLayout()
        CType(Me.dif_debit_z1_chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.adauga_valori_pnl.ResumeLayout(False)
        Me.adauga_valori_pnl.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.tabel_valori_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lista_atentionari_pnl.ResumeLayout(False)
        Me.lista_atentionari_pnl.PerformLayout()
        Me.lista_masini_pnl.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panou_butoane_pnl As Panel
    Friend WithEvents adauga_valori_pnl As Panel
    Friend WithEvents adauga_valori_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents nr_marca_tb As TextBox
    Friend WithEvents nr_marca_lbl As Label
    Friend WithEvents nr_masina_cb As ComboBox
    Friend WithEvents nr_masina_lbl As Label
    Friend WithEvents debit_posalux_lbl As Label
    Friend WithEvents tabel_valori_dgv As DataGridView
    Friend WithEvents salveaza_valori_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents data_ora As DataGridViewTextBoxColumn
    Friend WithEvents dm As DataGridViewTextBoxColumn
    Friend WithEvents referinta As DataGridViewTextBoxColumn
    Friend WithEvents caseta As DataGridViewTextBoxColumn
    Friend WithEvents debit As DataGridViewTextBoxColumn
    Friend WithEvents delta_q As DataGridViewTextBoxColumn
    Friend WithEvents nr_cuib As DataGridViewTextBoxColumn
    Friend WithEvents id_rand_rezultate As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents z1_lbl As Label
    Friend WithEvents z2_lbl As Label
    Friend WithEvents z3_lbl As Label
    Friend WithEvents z1_tb As TextBox
    Friend WithEvents z2_tb As TextBox
    Friend WithEvents z3_tb As TextBox
    Friend WithEvents z4_tb As TextBox
    Friend WithEvents z4_lbl As Label
    Friend WithEvents grafice_pnl As Panel
    Friend WithEvents vizualizare_grafice_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dif_debit_z1_chart As DataVisualization.Charting.Chart
    Friend WithEvents lista_atentionari_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents lista_atentionari_pnl As Panel
    Friend WithEvents lista_atentionari_lst As ListView
    Friend WithEvents id_atentionare As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lista_masini_pnl As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
End Class

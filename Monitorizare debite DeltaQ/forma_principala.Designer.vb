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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Diferențe debit între Posalux și Delta Q", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Delta Q în afara toleranței", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Diferența Delta Q mai mare decât limita impusă", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fereastra_principala_frm))
        Me.panou_butoane_pnl = New System.Windows.Forms.Panel()
        Me.lista_atentionari_btn = New FontAwesome.Sharp.IconButton()
        Me.vizualizare_grafice_btn = New FontAwesome.Sharp.IconButton()
        Me.adauga_valori_btn = New FontAwesome.Sharp.IconButton()
        Me.grafice_pnl = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grafice_tabcontrol = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.delta_q_z1_chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dif_debit_z1_chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dif_debit_z2_chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dif_debit_z3_chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dif_debit_z4_chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.adauga_valori_pnl = New System.Windows.Forms.Panel()
        Me.deblocare_selectie_btn = New FontAwesome.Sharp.IconButton()
        Me.reactualizare_date_btn = New FontAwesome.Sharp.IconButton()
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.operator_lbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.id_atentionare = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.referinta_atentionare_lbl = New System.Windows.Forms.Label()
        Me.masina_atentionare_lbl = New System.Windows.Forms.Label()
        Me.data_ora_atentionare_lbl = New System.Windows.Forms.Label()
        Me.id_atentionare_lbl = New System.Windows.Forms.Label()
        Me.date_operator_atentionare_lbl = New System.Windows.Forms.Label()
        Me.lista_atentionari_lst = New System.Windows.Forms.ListView()
        Me.spindle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.datamatrix = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rezolutie = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.diferenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.val_introd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.val_mas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lista_masini_pnl = New System.Windows.Forms.Panel()
        Me.masini_posalux_lbl = New System.Windows.Forms.Label()
        Me.button_flow_pnl = New System.Windows.Forms.FlowLayoutPanel()
        Me.selectie_val_pnl = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.vizualizare_evolutie_btn = New FontAwesome.Sharp.IconButton()
        Me.lista_referinte_lbx = New System.Windows.Forms.ListBox()
        Me.lista_masina_lbx = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.buton_refresh_ttp = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.delta_q_z2_chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.panou_butoane_pnl.SuspendLayout()
        Me.grafice_pnl.SuspendLayout()
        Me.grafice_tabcontrol.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.delta_q_z1_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dif_debit_z1_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dif_debit_z2_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dif_debit_z3_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dif_debit_z4_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.adauga_valori_pnl.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.tabel_valori_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lista_atentionari_pnl.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.lista_masini_pnl.SuspendLayout()
        Me.selectie_val_pnl.SuspendLayout()
        CType(Me.delta_q_z2_chart, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grafice_pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.grafice_pnl.Controls.Add(Me.Label10)
        Me.grafice_pnl.Controls.Add(Me.grafice_tabcontrol)
        Me.grafice_pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grafice_pnl.Location = New System.Drawing.Point(0, 0)
        Me.grafice_pnl.Name = "grafice_pnl"
        Me.grafice_pnl.Size = New System.Drawing.Size(1024, 651)
        Me.grafice_pnl.TabIndex = 9
        Me.grafice_pnl.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(203, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Masina"
        '
        'grafice_tabcontrol
        '
        Me.grafice_tabcontrol.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grafice_tabcontrol.Controls.Add(Me.TabPage1)
        Me.grafice_tabcontrol.Controls.Add(Me.TabPage2)
        Me.grafice_tabcontrol.Controls.Add(Me.TabPage3)
        Me.grafice_tabcontrol.Controls.Add(Me.TabPage4)
        Me.grafice_tabcontrol.Location = New System.Drawing.Point(203, 70)
        Me.grafice_tabcontrol.Name = "grafice_tabcontrol"
        Me.grafice_tabcontrol.SelectedIndex = 0
        Me.grafice_tabcontrol.Size = New System.Drawing.Size(817, 546)
        Me.grafice_tabcontrol.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.delta_q_z1_chart)
        Me.TabPage1.Controls.Add(Me.dif_debit_z1_chart)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(809, 520)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Z1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.Label11.Location = New System.Drawing.Point(3, 300)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 22)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Delta Q"
        '
        'delta_q_z1_chart
        '
        Me.delta_q_z1_chart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.ScaleView.Size = 30.0R
        ChartArea1.AxisX2.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.Interval = 18.0R
        ChartArea1.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisY.Maximum = 5.0R
        ChartArea1.AxisY.MaximumAutoSize = 85.0!
        ChartArea1.AxisY.Minimum = -5.0R
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        ChartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea1.AxisY2.LineColor = System.Drawing.Color.White
        ChartArea1.BackColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.Name = "ChartArea1"
        Me.delta_q_z1_chart.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.delta_q_z1_chart.Legends.Add(Legend1)
        Me.delta_q_z1_chart.Location = New System.Drawing.Point(2, 325)
        Me.delta_q_z1_chart.Name = "delta_q_z1_chart"
        Me.delta_q_z1_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series1.Color = System.Drawing.Color.Black
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Series1.IsVisibleInLegend = False
        Series1.Legend = "Legend1"
        Series1.Name = "valori"
        Me.delta_q_z1_chart.Series.Add(Series1)
        Me.delta_q_z1_chart.Size = New System.Drawing.Size(767, 263)
        Me.delta_q_z1_chart.TabIndex = 11
        Me.delta_q_z1_chart.Text = "Chart1"
        '
        'dif_debit_z1_chart
        '
        Me.dif_debit_z1_chart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX.ScaleView.Size = 30.0R
        ChartArea2.AxisX2.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY.Interval = 18.0R
        ChartArea2.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea2.AxisY.IsLabelAutoFit = False
        ChartArea2.AxisY.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea2.AxisY.Maximum = 5.0R
        ChartArea2.AxisY.MaximumAutoSize = 85.0!
        ChartArea2.AxisY.Minimum = -5.0R
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        ChartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea2.AxisY2.LineColor = System.Drawing.Color.White
        ChartArea2.BackColor = System.Drawing.Color.WhiteSmoke
        ChartArea2.Name = "ChartArea1"
        Me.dif_debit_z1_chart.ChartAreas.Add(ChartArea2)
        Legend2.Enabled = False
        Legend2.Name = "Legend1"
        Me.dif_debit_z1_chart.Legends.Add(Legend2)
        Me.dif_debit_z1_chart.Location = New System.Drawing.Point(2, 37)
        Me.dif_debit_z1_chart.Name = "dif_debit_z1_chart"
        Me.dif_debit_z1_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series2.Color = System.Drawing.Color.Black
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Series2.IsVisibleInLegend = False
        Series2.Legend = "Legend1"
        Series2.Name = "valori"
        Me.dif_debit_z1_chart.Series.Add(Series2)
        Me.dif_debit_z1_chart.Size = New System.Drawing.Size(767, 263)
        Me.dif_debit_z1_chart.TabIndex = 10
        Me.dif_debit_z1_chart.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Diferență debit Posalux vs Delta Q"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.delta_q_z2_chart)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.dif_debit_z2_chart)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(809, 520)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Z2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(350, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Diferență debit Posalux vs Delta Q"
        '
        'dif_debit_z2_chart
        '
        Me.dif_debit_z2_chart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea4.AxisX.MinorGrid.LineColor = System.Drawing.Color.White
        ChartArea4.AxisX.ScaleView.Size = 30.0R
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
        Me.dif_debit_z2_chart.ChartAreas.Add(ChartArea4)
        Legend4.Enabled = False
        Legend4.Name = "Legend1"
        Me.dif_debit_z2_chart.Legends.Add(Legend4)
        Me.dif_debit_z2_chart.Location = New System.Drawing.Point(2, 37)
        Me.dif_debit_z2_chart.Name = "dif_debit_z2_chart"
        Me.dif_debit_z2_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series4.Color = System.Drawing.Color.Black
        Series4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Series4.IsVisibleInLegend = False
        Series4.Legend = "Legend1"
        Series4.Name = "valori"
        Me.dif_debit_z2_chart.Series.Add(Series4)
        Me.dif_debit_z2_chart.Size = New System.Drawing.Size(767, 263)
        Me.dif_debit_z2_chart.TabIndex = 11
        Me.dif_debit_z2_chart.Text = "Chart1"
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.dif_debit_z3_chart)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(809, 520)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Z3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.Label7.Location = New System.Drawing.Point(3, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(400, 22)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Z3 - diferență debit Posalux vs Delta Q"
        '
        'dif_debit_z3_chart
        '
        Me.dif_debit_z3_chart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea5.AxisX.MinorGrid.LineColor = System.Drawing.Color.White
        ChartArea5.AxisX.ScaleView.Size = 30.0R
        ChartArea5.AxisX2.LineColor = System.Drawing.Color.White
        ChartArea5.AxisY.Interval = 18.0R
        ChartArea5.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea5.AxisY.IsLabelAutoFit = False
        ChartArea5.AxisY.LineColor = System.Drawing.Color.White
        ChartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea5.AxisY.Maximum = 5.0R
        ChartArea5.AxisY.MaximumAutoSize = 85.0!
        ChartArea5.AxisY.Minimum = -5.0R
        ChartArea5.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        ChartArea5.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea5.AxisY2.LineColor = System.Drawing.Color.White
        ChartArea5.BackColor = System.Drawing.Color.WhiteSmoke
        ChartArea5.Name = "ChartArea1"
        Me.dif_debit_z3_chart.ChartAreas.Add(ChartArea5)
        Legend5.Enabled = False
        Legend5.Name = "Legend1"
        Me.dif_debit_z3_chart.Legends.Add(Legend5)
        Me.dif_debit_z3_chart.Location = New System.Drawing.Point(2, 37)
        Me.dif_debit_z3_chart.Name = "dif_debit_z3_chart"
        Me.dif_debit_z3_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series5.Color = System.Drawing.Color.Black
        Series5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Series5.IsVisibleInLegend = False
        Series5.Legend = "Legend1"
        Series5.Name = "valori"
        Me.dif_debit_z3_chart.Series.Add(Series5)
        Me.dif_debit_z3_chart.Size = New System.Drawing.Size(801, 263)
        Me.dif_debit_z3_chart.TabIndex = 12
        Me.dif_debit_z3_chart.Text = "Chart1"
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.dif_debit_z4_chart)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(809, 520)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Z4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.Label9.Location = New System.Drawing.Point(3, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(400, 22)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Z4 - diferență debit Posalux vs Delta Q"
        '
        'dif_debit_z4_chart
        '
        Me.dif_debit_z4_chart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea6.AxisX.MinorGrid.LineColor = System.Drawing.Color.White
        ChartArea6.AxisX.ScaleView.Size = 30.0R
        ChartArea6.AxisX2.LineColor = System.Drawing.Color.White
        ChartArea6.AxisY.Interval = 18.0R
        ChartArea6.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea6.AxisY.IsLabelAutoFit = False
        ChartArea6.AxisY.LineColor = System.Drawing.Color.White
        ChartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea6.AxisY.Maximum = 5.0R
        ChartArea6.AxisY.MaximumAutoSize = 85.0!
        ChartArea6.AxisY.Minimum = -5.0R
        ChartArea6.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        ChartArea6.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea6.AxisY2.LineColor = System.Drawing.Color.White
        ChartArea6.BackColor = System.Drawing.Color.WhiteSmoke
        ChartArea6.Name = "ChartArea1"
        Me.dif_debit_z4_chart.ChartAreas.Add(ChartArea6)
        Legend6.Enabled = False
        Legend6.Name = "Legend1"
        Me.dif_debit_z4_chart.Legends.Add(Legend6)
        Me.dif_debit_z4_chart.Location = New System.Drawing.Point(2, 37)
        Me.dif_debit_z4_chart.Name = "dif_debit_z4_chart"
        Me.dif_debit_z4_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series6.Color = System.Drawing.Color.Black
        Series6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Series6.IsVisibleInLegend = False
        Series6.Legend = "Legend1"
        Series6.Name = "valori"
        Me.dif_debit_z4_chart.Series.Add(Series6)
        Me.dif_debit_z4_chart.Size = New System.Drawing.Size(801, 263)
        Me.dif_debit_z4_chart.TabIndex = 13
        Me.dif_debit_z4_chart.Text = "Chart1"
        '
        'adauga_valori_pnl
        '
        Me.adauga_valori_pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.adauga_valori_pnl.Controls.Add(Me.deblocare_selectie_btn)
        Me.adauga_valori_pnl.Controls.Add(Me.reactualizare_date_btn)
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
        'deblocare_selectie_btn
        '
        Me.deblocare_selectie_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deblocare_selectie_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.deblocare_selectie_btn.IconChar = FontAwesome.Sharp.IconChar.Unlock
        Me.deblocare_selectie_btn.IconColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.deblocare_selectie_btn.IconSize = 32
        Me.deblocare_selectie_btn.Location = New System.Drawing.Point(863, 171)
        Me.deblocare_selectie_btn.Name = "deblocare_selectie_btn"
        Me.deblocare_selectie_btn.Rotation = 0R
        Me.deblocare_selectie_btn.Size = New System.Drawing.Size(68, 45)
        Me.deblocare_selectie_btn.TabIndex = 12
        Me.buton_refresh_ttp.SetToolTip(Me.deblocare_selectie_btn, "Deblochează selecția")
        Me.deblocare_selectie_btn.UseVisualStyleBackColor = True
        '
        'reactualizare_date_btn
        '
        Me.reactualizare_date_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reactualizare_date_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.reactualizare_date_btn.Font = New System.Drawing.Font("Consolas", 20.0!, System.Drawing.FontStyle.Bold)
        Me.reactualizare_date_btn.IconChar = FontAwesome.Sharp.IconChar.Redo
        Me.reactualizare_date_btn.IconColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.reactualizare_date_btn.IconSize = 32
        Me.reactualizare_date_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.reactualizare_date_btn.Location = New System.Drawing.Point(944, 171)
        Me.reactualizare_date_btn.Name = "reactualizare_date_btn"
        Me.reactualizare_date_btn.Rotation = 0R
        Me.reactualizare_date_btn.Size = New System.Drawing.Size(68, 45)
        Me.reactualizare_date_btn.TabIndex = 10
        Me.buton_refresh_ttp.SetToolTip(Me.reactualizare_date_btn, "Reactualizare date tabel")
        Me.reactualizare_date_btn.UseVisualStyleBackColor = True
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
        Me.tabel_valori_dgv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabel_valori_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.tabel_valori_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabel_valori_dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.data_ora, Me.dm, Me.referinta, Me.caseta, Me.debit, Me.delta_q, Me.nr_cuib, Me.id_rand_rezultate})
        Me.tabel_valori_dgv.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabel_valori_dgv.Location = New System.Drawing.Point(210, 225)
        Me.tabel_valori_dgv.MultiSelect = False
        Me.tabel_valori_dgv.Name = "tabel_valori_dgv"
        Me.tabel_valori_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabel_valori_dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
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
        Me.data_ora.Width = 200
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
        Me.lista_atentionari_pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.lista_atentionari_pnl.Controls.Add(Me.TableLayoutPanel2)
        Me.lista_atentionari_pnl.Controls.Add(Me.lista_atentionari_lst)
        Me.lista_atentionari_pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lista_atentionari_pnl.Location = New System.Drawing.Point(0, 0)
        Me.lista_atentionari_pnl.Name = "lista_atentionari_pnl"
        Me.lista_atentionari_pnl.Size = New System.Drawing.Size(1024, 651)
        Me.lista_atentionari_pnl.TabIndex = 11
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.TableLayoutPanel2.Controls.Add(Me.operator_lbl, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.id_atentionare, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.referinta_atentionare_lbl, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.masina_atentionare_lbl, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.data_ora_atentionare_lbl, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.id_atentionare_lbl, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.date_operator_atentionare_lbl, 1, 4)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(210, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(748, 136)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'operator_lbl
        '
        Me.operator_lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.operator_lbl.AutoSize = True
        Me.operator_lbl.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.operator_lbl.Location = New System.Drawing.Point(3, 116)
        Me.operator_lbl.Name = "operator_lbl"
        Me.operator_lbl.Size = New System.Drawing.Size(243, 19)
        Me.operator_lbl.TabIndex = 6
        Me.operator_lbl.Text = "Operator"
        Me.operator_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(243, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Referința"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(3, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(243, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Mașina"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'id_atentionare
        '
        Me.id_atentionare.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.id_atentionare.AutoSize = True
        Me.id_atentionare.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.id_atentionare.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_atentionare.Location = New System.Drawing.Point(3, 87)
        Me.id_atentionare.Name = "id_atentionare"
        Me.id_atentionare.Size = New System.Drawing.Size(243, 19)
        Me.id_atentionare.TabIndex = 1
        Me.id_atentionare.Text = "Atenționare"
        Me.id_atentionare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(3, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(243, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Data și ora"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'referinta_atentionare_lbl
        '
        Me.referinta_atentionare_lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.referinta_atentionare_lbl.AutoSize = True
        Me.referinta_atentionare_lbl.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.referinta_atentionare_lbl.Location = New System.Drawing.Point(252, 0)
        Me.referinta_atentionare_lbl.Name = "referinta_atentionare_lbl"
        Me.referinta_atentionare_lbl.Size = New System.Drawing.Size(493, 19)
        Me.referinta_atentionare_lbl.TabIndex = 5
        Me.referinta_atentionare_lbl.Text = "N/A"
        Me.referinta_atentionare_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'masina_atentionare_lbl
        '
        Me.masina_atentionare_lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.masina_atentionare_lbl.AutoSize = True
        Me.masina_atentionare_lbl.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.masina_atentionare_lbl.Location = New System.Drawing.Point(252, 29)
        Me.masina_atentionare_lbl.Name = "masina_atentionare_lbl"
        Me.masina_atentionare_lbl.Size = New System.Drawing.Size(493, 19)
        Me.masina_atentionare_lbl.TabIndex = 7
        Me.masina_atentionare_lbl.Text = "N/A"
        Me.masina_atentionare_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'data_ora_atentionare_lbl
        '
        Me.data_ora_atentionare_lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.data_ora_atentionare_lbl.AutoSize = True
        Me.data_ora_atentionare_lbl.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.data_ora_atentionare_lbl.Location = New System.Drawing.Point(252, 58)
        Me.data_ora_atentionare_lbl.Name = "data_ora_atentionare_lbl"
        Me.data_ora_atentionare_lbl.Size = New System.Drawing.Size(493, 19)
        Me.data_ora_atentionare_lbl.TabIndex = 8
        Me.data_ora_atentionare_lbl.Text = "N/A"
        Me.data_ora_atentionare_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'id_atentionare_lbl
        '
        Me.id_atentionare_lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.id_atentionare_lbl.AutoSize = True
        Me.id_atentionare_lbl.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.id_atentionare_lbl.Location = New System.Drawing.Point(252, 87)
        Me.id_atentionare_lbl.Name = "id_atentionare_lbl"
        Me.id_atentionare_lbl.Size = New System.Drawing.Size(493, 19)
        Me.id_atentionare_lbl.TabIndex = 9
        Me.id_atentionare_lbl.Text = "N/A"
        Me.id_atentionare_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'date_operator_atentionare_lbl
        '
        Me.date_operator_atentionare_lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.date_operator_atentionare_lbl.AutoSize = True
        Me.date_operator_atentionare_lbl.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.date_operator_atentionare_lbl.Location = New System.Drawing.Point(252, 116)
        Me.date_operator_atentionare_lbl.Name = "date_operator_atentionare_lbl"
        Me.date_operator_atentionare_lbl.Size = New System.Drawing.Size(493, 19)
        Me.date_operator_atentionare_lbl.TabIndex = 10
        Me.date_operator_atentionare_lbl.Text = "N/A"
        Me.date_operator_atentionare_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lista_atentionari_lst
        '
        Me.lista_atentionari_lst.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.lista_atentionari_lst.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lista_atentionari_lst.AutoArrange = False
        Me.lista_atentionari_lst.BackColor = System.Drawing.SystemColors.Window
        Me.lista_atentionari_lst.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lista_atentionari_lst.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.spindle, Me.datamatrix, Me.rezolutie, Me.diferenta, Me.val_introd, Me.val_mas})
        Me.lista_atentionari_lst.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.lista_atentionari_lst.FullRowSelect = True
        Me.lista_atentionari_lst.GridLines = True
        ListViewGroup1.Header = "Diferențe debit între Posalux și Delta Q"
        ListViewGroup1.Name = "dif_debit"
        ListViewGroup2.Header = "Delta Q în afara toleranței"
        ListViewGroup2.Name = "dq_val"
        ListViewGroup3.Header = "Diferența Delta Q mai mare decât limita impusă"
        ListViewGroup3.Name = "dif_dq"
        Me.lista_atentionari_lst.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.lista_atentionari_lst.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lista_atentionari_lst.HideSelection = False
        Me.lista_atentionari_lst.LabelWrap = False
        Me.lista_atentionari_lst.Location = New System.Drawing.Point(210, 163)
        Me.lista_atentionari_lst.MultiSelect = False
        Me.lista_atentionari_lst.Name = "lista_atentionari_lst"
        Me.lista_atentionari_lst.Size = New System.Drawing.Size(748, 367)
        Me.lista_atentionari_lst.TabIndex = 0
        Me.lista_atentionari_lst.UseCompatibleStateImageBehavior = False
        Me.lista_atentionari_lst.View = System.Windows.Forms.View.Details
        '
        'spindle
        '
        Me.spindle.Text = "Spindle"
        Me.spindle.Width = 62
        '
        'datamatrix
        '
        Me.datamatrix.Text = "DM"
        Me.datamatrix.Width = 127
        '
        'rezolutie
        '
        Me.rezolutie.Text = "Rezolutie"
        Me.rezolutie.Width = 81
        '
        'diferenta
        '
        Me.diferenta.Text = "Diferență"
        Me.diferenta.Width = 110
        '
        'val_introd
        '
        Me.val_introd.Text = "Valoare introdusă"
        Me.val_introd.Width = 140
        '
        'val_mas
        '
        Me.val_mas.Text = "Valoare măsurată"
        Me.val_mas.Width = 141
        '
        'lista_masini_pnl
        '
        Me.lista_masini_pnl.BackColor = System.Drawing.Color.SlateGray
        Me.lista_masini_pnl.Controls.Add(Me.masini_posalux_lbl)
        Me.lista_masini_pnl.Controls.Add(Me.button_flow_pnl)
        Me.lista_masini_pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lista_masini_pnl.Location = New System.Drawing.Point(0, 0)
        Me.lista_masini_pnl.Name = "lista_masini_pnl"
        Me.lista_masini_pnl.Size = New System.Drawing.Size(1024, 651)
        Me.lista_masini_pnl.TabIndex = 2
        '
        'masini_posalux_lbl
        '
        Me.masini_posalux_lbl.AutoSize = True
        Me.masini_posalux_lbl.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.masini_posalux_lbl.Location = New System.Drawing.Point(217, 26)
        Me.masini_posalux_lbl.Name = "masini_posalux_lbl"
        Me.masini_posalux_lbl.Size = New System.Drawing.Size(120, 18)
        Me.masini_posalux_lbl.TabIndex = 1
        Me.masini_posalux_lbl.Text = "Mașini Posalux"
        '
        'button_flow_pnl
        '
        Me.button_flow_pnl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_flow_pnl.Location = New System.Drawing.Point(217, 57)
        Me.button_flow_pnl.Name = "button_flow_pnl"
        Me.button_flow_pnl.Size = New System.Drawing.Size(763, 427)
        Me.button_flow_pnl.TabIndex = 0
        '
        'selectie_val_pnl
        '
        Me.selectie_val_pnl.Controls.Add(Me.Label8)
        Me.selectie_val_pnl.Controls.Add(Me.vizualizare_evolutie_btn)
        Me.selectie_val_pnl.Controls.Add(Me.lista_referinte_lbx)
        Me.selectie_val_pnl.Controls.Add(Me.lista_masina_lbx)
        Me.selectie_val_pnl.Controls.Add(Me.Label3)
        Me.selectie_val_pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.selectie_val_pnl.Location = New System.Drawing.Point(0, 0)
        Me.selectie_val_pnl.Name = "selectie_val_pnl"
        Me.selectie_val_pnl.Size = New System.Drawing.Size(1024, 651)
        Me.selectie_val_pnl.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label8.Location = New System.Drawing.Point(387, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 26)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = ">"
        '
        'vizualizare_evolutie_btn
        '
        Me.vizualizare_evolutie_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.vizualizare_evolutie_btn.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight
        Me.vizualizare_evolutie_btn.IconColor = System.Drawing.Color.Black
        Me.vizualizare_evolutie_btn.IconSize = 41
        Me.vizualizare_evolutie_btn.Location = New System.Drawing.Point(609, 65)
        Me.vizualizare_evolutie_btn.Name = "vizualizare_evolutie_btn"
        Me.vizualizare_evolutie_btn.Rotation = 0R
        Me.vizualizare_evolutie_btn.Size = New System.Drawing.Size(97, 48)
        Me.vizualizare_evolutie_btn.TabIndex = 4
        Me.vizualizare_evolutie_btn.UseVisualStyleBackColor = True
        Me.vizualizare_evolutie_btn.Visible = False
        '
        'lista_referinte_lbx
        '
        Me.lista_referinte_lbx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lista_referinte_lbx.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.lista_referinte_lbx.FormattingEnabled = True
        Me.lista_referinte_lbx.ItemHeight = 22
        Me.lista_referinte_lbx.Location = New System.Drawing.Point(444, 65)
        Me.lista_referinte_lbx.Name = "lista_referinte_lbx"
        Me.lista_referinte_lbx.Size = New System.Drawing.Size(135, 286)
        Me.lista_referinte_lbx.TabIndex = 3
        '
        'lista_masina_lbx
        '
        Me.lista_masina_lbx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lista_masina_lbx.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lista_masina_lbx.FormattingEnabled = True
        Me.lista_masina_lbx.ItemHeight = 19
        Me.lista_masina_lbx.Location = New System.Drawing.Point(217, 63)
        Me.lista_masina_lbx.Name = "lista_masina_lbx"
        Me.lista_masina_lbx.Size = New System.Drawing.Size(135, 285)
        Me.lista_masina_lbx.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(212, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(530, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Selecție mașină și referință pentru afișare evoluție"
        '
        'Timer1
        '
        Me.Timer1.Interval = 15000
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.Label12.Location = New System.Drawing.Point(3, 300)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 22)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Delta Q"
        '
        'delta_q_z2_chart
        '
        Me.delta_q_z2_chart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.White
        ChartArea3.AxisX.ScaleView.Size = 30.0R
        ChartArea3.AxisX2.LineColor = System.Drawing.Color.White
        ChartArea3.AxisY.Interval = 18.0R
        ChartArea3.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea3.AxisY.IsLabelAutoFit = False
        ChartArea3.AxisY.LineColor = System.Drawing.Color.White
        ChartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea3.AxisY.Maximum = 5.0R
        ChartArea3.AxisY.MaximumAutoSize = 85.0!
        ChartArea3.AxisY.Minimum = -5.0R
        ChartArea3.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        ChartArea3.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea3.AxisY2.LineColor = System.Drawing.Color.White
        ChartArea3.BackColor = System.Drawing.Color.WhiteSmoke
        ChartArea3.Name = "ChartArea1"
        Me.delta_q_z2_chart.ChartAreas.Add(ChartArea3)
        Legend3.Enabled = False
        Legend3.Name = "Legend1"
        Me.delta_q_z2_chart.Legends.Add(Legend3)
        Me.delta_q_z2_chart.Location = New System.Drawing.Point(3, 325)
        Me.delta_q_z2_chart.Name = "delta_q_z2_chart"
        Me.delta_q_z2_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series3.Color = System.Drawing.Color.Black
        Series3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Series3.IsVisibleInLegend = False
        Series3.Legend = "Legend1"
        Series3.Name = "valori"
        Me.delta_q_z2_chart.Series.Add(Series3)
        Me.delta_q_z2_chart.Size = New System.Drawing.Size(733, 263)
        Me.delta_q_z2_chart.TabIndex = 13
        Me.delta_q_z2_chart.Text = "Chart1"
        '
        'fereastra_principala_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 651)
        Me.Controls.Add(Me.panou_butoane_pnl)
        Me.Controls.Add(Me.grafice_pnl)
        Me.Controls.Add(Me.adauga_valori_pnl)
        Me.Controls.Add(Me.selectie_val_pnl)
        Me.Controls.Add(Me.lista_masini_pnl)
        Me.Controls.Add(Me.lista_atentionari_pnl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1040, 690)
        Me.Name = "fereastra_principala_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adaugă valori"
        Me.panou_butoane_pnl.ResumeLayout(False)
        Me.grafice_pnl.ResumeLayout(False)
        Me.grafice_pnl.PerformLayout()
        Me.grafice_tabcontrol.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.delta_q_z1_chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dif_debit_z1_chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dif_debit_z2_chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dif_debit_z3_chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dif_debit_z4_chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.adauga_valori_pnl.ResumeLayout(False)
        Me.adauga_valori_pnl.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.tabel_valori_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lista_atentionari_pnl.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.lista_masini_pnl.ResumeLayout(False)
        Me.lista_masini_pnl.PerformLayout()
        Me.selectie_val_pnl.ResumeLayout(False)
        Me.selectie_val_pnl.PerformLayout()
        CType(Me.delta_q_z2_chart, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dif_debit_z1_chart As DataVisualization.Charting.Chart
    Friend WithEvents lista_atentionari_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents lista_atentionari_pnl As Panel
    Friend WithEvents lista_atentionari_lst As ListView
    Friend WithEvents id_atentionare As Label
    Friend WithEvents spindle As ColumnHeader
    Friend WithEvents rezolutie As ColumnHeader
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lista_masini_pnl As Panel
    Friend WithEvents button_flow_pnl As FlowLayoutPanel
    Friend WithEvents masini_posalux_lbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents referinta_atentionare_lbl As Label
    Friend WithEvents operator_lbl As Label
    Friend WithEvents masina_atentionare_lbl As Label
    Friend WithEvents data_ora_atentionare_lbl As Label
    Friend WithEvents id_atentionare_lbl As Label
    Friend WithEvents date_operator_atentionare_lbl As Label
    Friend WithEvents data_ora As DataGridViewTextBoxColumn
    Friend WithEvents dm As DataGridViewTextBoxColumn
    Friend WithEvents referinta As DataGridViewTextBoxColumn
    Friend WithEvents caseta As DataGridViewTextBoxColumn
    Friend WithEvents debit As DataGridViewTextBoxColumn
    Friend WithEvents delta_q As DataGridViewTextBoxColumn
    Friend WithEvents nr_cuib As DataGridViewTextBoxColumn
    Friend WithEvents id_rand_rezultate As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents reactualizare_date_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents buton_refresh_ttp As ToolTip
    Friend WithEvents datamatrix As ColumnHeader
    Friend WithEvents val_introd As ColumnHeader
    Friend WithEvents val_mas As ColumnHeader
    Friend WithEvents diferenta As ColumnHeader
    Friend WithEvents deblocare_selectie_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents selectie_val_pnl As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lista_masina_lbx As ListBox
    Friend WithEvents vizualizare_evolutie_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents lista_referinte_lbx As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents grafice_tabcontrol As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dif_debit_z2_chart As DataVisualization.Charting.Chart
    Friend WithEvents dif_debit_z3_chart As DataVisualization.Charting.Chart
    Friend WithEvents dif_debit_z4_chart As DataVisualization.Charting.Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents delta_q_z1_chart As DataVisualization.Charting.Chart
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents delta_q_z2_chart As DataVisualization.Charting.Chart
End Class

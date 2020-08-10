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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panou_butoane_pnl = New System.Windows.Forms.Panel()
        Me.vizualizare_grafice_btn = New FontAwesome.Sharp.IconButton()
        Me.adauga_valori_btn = New FontAwesome.Sharp.IconButton()
        Me.grafice_pnl = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dif_z1_pb = New System.Windows.Forms.PictureBox()
        Me.adauga_valori_pnl = New System.Windows.Forms.Panel()
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
        Me.panou_butoane_pnl.SuspendLayout()
        Me.grafice_pnl.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dif_z1_pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.adauga_valori_pnl.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.tabel_valori_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panou_butoane_pnl
        '
        Me.panou_butoane_pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.panou_butoane_pnl.Controls.Add(Me.vizualizare_grafice_btn)
        Me.panou_butoane_pnl.Controls.Add(Me.adauga_valori_btn)
        Me.panou_butoane_pnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.panou_butoane_pnl.Location = New System.Drawing.Point(0, 0)
        Me.panou_butoane_pnl.Margin = New System.Windows.Forms.Padding(0)
        Me.panou_butoane_pnl.Name = "panou_butoane_pnl"
        Me.panou_butoane_pnl.Size = New System.Drawing.Size(200, 651)
        Me.panou_butoane_pnl.TabIndex = 0
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
        Me.vizualizare_grafice_btn.Location = New System.Drawing.Point(0, 46)
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
        Me.adauga_valori_btn.Location = New System.Drawing.Point(0, 96)
        Me.adauga_valori_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.adauga_valori_btn.Name = "adauga_valori_btn"
        Me.adauga_valori_btn.Rotation = 0R
        Me.adauga_valori_btn.Size = New System.Drawing.Size(200, 50)
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
        Me.grafice_pnl.Controls.Add(Me.Label2)
        Me.grafice_pnl.Controls.Add(Me.Label1)
        Me.grafice_pnl.Controls.Add(Me.PictureBox4)
        Me.grafice_pnl.Controls.Add(Me.PictureBox3)
        Me.grafice_pnl.Controls.Add(Me.PictureBox2)
        Me.grafice_pnl.Controls.Add(Me.dif_z1_pb)
        Me.grafice_pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grafice_pnl.Location = New System.Drawing.Point(0, 0)
        Me.grafice_pnl.Name = "grafice_pnl"
        Me.grafice_pnl.Size = New System.Drawing.Size(1024, 651)
        Me.grafice_pnl.TabIndex = 9
        Me.grafice_pnl.Visible = False
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
        Me.Label1.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(229, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Z1 - diferență debit Posalux vs Delta Q"
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox4.Location = New System.Drawing.Point(232, 583)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(747, 157)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(232, 408)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(747, 157)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(232, 225)
        Me.PictureBox2.MinimumSize = New System.Drawing.Size(232, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(747, 157)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'dif_z1_pb
        '
        Me.dif_z1_pb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dif_z1_pb.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dif_z1_pb.Location = New System.Drawing.Point(232, 32)
        Me.dif_z1_pb.MinimumSize = New System.Drawing.Size(232, 0)
        Me.dif_z1_pb.Name = "dif_z1_pb"
        Me.dif_z1_pb.Size = New System.Drawing.Size(747, 157)
        Me.dif_z1_pb.TabIndex = 0
        Me.dif_z1_pb.TabStop = False
        '
        'adauga_valori_pnl
        '
        Me.adauga_valori_pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(209, Byte), Integer))
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
        'fereastra_principala_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 651)
        Me.Controls.Add(Me.panou_butoane_pnl)
        Me.Controls.Add(Me.grafice_pnl)
        Me.Controls.Add(Me.adauga_valori_pnl)
        Me.MinimumSize = New System.Drawing.Size(1040, 690)
        Me.Name = "fereastra_principala_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adaugă valori"
        Me.panou_butoane_pnl.ResumeLayout(False)
        Me.grafice_pnl.ResumeLayout(False)
        Me.grafice_pnl.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dif_z1_pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.adauga_valori_pnl.ResumeLayout(False)
        Me.adauga_valori_pnl.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.tabel_valori_dgv, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dif_z1_pb As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents vizualizare_grafice_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

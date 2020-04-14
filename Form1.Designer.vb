<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBoxRX = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusConexao = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusPorta = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusVelocidade = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBitsDados = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusParidade = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBitsParada = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusNomePrograma = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelRX = New System.Windows.Forms.Label()
        Me.LabelTX = New System.Windows.Forms.Label()
        Me.PanelConfiguracoes = New System.Windows.Forms.Panel()
        Me.ComboBoxBitsParada = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPorta = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxParidade = New System.Windows.Forms.ComboBox()
        Me.ComboBoxVelocidade = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxBitsDados = New System.Windows.Forms.ComboBox()
        Me.ButtonAbrirPorta = New System.Windows.Forms.Button()
        Me.ButtonFecharPorta = New System.Windows.Forms.Button()
        Me.ButtonSobre = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonSair = New System.Windows.Forms.Button()
        Me.PanelControle = New System.Windows.Forms.Panel()
        Me.ButtonEnviar = New System.Windows.Forms.Button()
        Me.CheckBoxIncluirCRLF = New System.Windows.Forms.CheckBox()
        Me.CheckBoxEnviarAuto = New System.Windows.Forms.CheckBox()
        Me.TextBoxTX = New System.Windows.Forms.TextBox()
        Me.LabelNomePrograma = New System.Windows.Forms.Label()
        Me.ButtonSalvarRX = New System.Windows.Forms.Button()
        Me.ButtonLimparRX = New System.Windows.Forms.Button()
        Me.ButtonLimparTX = New System.Windows.Forms.Button()
        Me.ButtonSalvarTX = New System.Windows.Forms.Button()
        Me.ButtonX = New System.Windows.Forms.Button()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.PanelConfiguracoes.SuspendLayout()
        Me.PanelControle.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxRX
        '
        Me.TextBoxRX.BackColor = System.Drawing.SystemColors.Window
        Me.TextBoxRX.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxRX.Location = New System.Drawing.Point(12, 75)
        Me.TextBoxRX.Multiline = True
        Me.TextBoxRX.Name = "TextBoxRX"
        Me.TextBoxRX.ReadOnly = True
        Me.TextBoxRX.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxRX.Size = New System.Drawing.Size(323, 139)
        Me.TextBoxRX.TabIndex = 0
        Me.TextBoxRX.TabStop = False
        Me.TextBoxRX.WordWrap = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusConexao, Me.StatusPorta, Me.StatusVelocidade, Me.StatusBitsDados, Me.StatusParidade, Me.StatusBitsParada, Me.StatusNomePrograma})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 440)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(470, 24)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusConexao
        '
        Me.StatusConexao.AutoSize = False
        Me.StatusConexao.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StatusConexao.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.StatusConexao.Name = "StatusConexao"
        Me.StatusConexao.Size = New System.Drawing.Size(82, 19)
        Me.StatusConexao.Text = "Desconectado"
        Me.StatusConexao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusPorta
        '
        Me.StatusPorta.AutoSize = False
        Me.StatusPorta.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StatusPorta.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.StatusPorta.Name = "StatusPorta"
        Me.StatusPorta.Size = New System.Drawing.Size(42, 19)
        '
        'StatusVelocidade
        '
        Me.StatusVelocidade.AutoSize = False
        Me.StatusVelocidade.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StatusVelocidade.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.StatusVelocidade.Name = "StatusVelocidade"
        Me.StatusVelocidade.Size = New System.Drawing.Size(43, 19)
        '
        'StatusBitsDados
        '
        Me.StatusBitsDados.AutoSize = False
        Me.StatusBitsDados.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StatusBitsDados.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.StatusBitsDados.Name = "StatusBitsDados"
        Me.StatusBitsDados.Size = New System.Drawing.Size(20, 19)
        '
        'StatusParidade
        '
        Me.StatusParidade.AutoSize = False
        Me.StatusParidade.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StatusParidade.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.StatusParidade.Name = "StatusParidade"
        Me.StatusParidade.Size = New System.Drawing.Size(52, 19)
        '
        'StatusBitsParada
        '
        Me.StatusBitsParada.AutoSize = False
        Me.StatusBitsParada.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StatusBitsParada.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.StatusBitsParada.Name = "StatusBitsParada"
        Me.StatusBitsParada.Size = New System.Drawing.Size(22, 19)
        '
        'StatusNomePrograma
        '
        Me.StatusNomePrograma.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StatusNomePrograma.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.StatusNomePrograma.Name = "StatusNomePrograma"
        Me.StatusNomePrograma.Size = New System.Drawing.Size(194, 19)
        Me.StatusNomePrograma.Spring = True
        Me.StatusNomePrograma.Text = "GComSerial v1.0"
        '
        'LabelRX
        '
        Me.LabelRX.AutoSize = True
        Me.LabelRX.Location = New System.Drawing.Point(12, 59)
        Me.LabelRX.Name = "LabelRX"
        Me.LabelRX.Size = New System.Drawing.Size(127, 13)
        Me.LabelRX.TabIndex = 2
        Me.LabelRX.Text = "RX - Recebe Mensagem:"
        '
        'LabelTX
        '
        Me.LabelTX.AutoSize = True
        Me.LabelTX.Location = New System.Drawing.Point(9, 225)
        Me.LabelTX.Name = "LabelTX"
        Me.LabelTX.Size = New System.Drawing.Size(115, 13)
        Me.LabelTX.TabIndex = 4
        Me.LabelTX.Text = "TX - Envia Mensagem:"
        '
        'PanelConfiguracoes
        '
        Me.PanelConfiguracoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelConfiguracoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelConfiguracoes.Controls.Add(Me.ComboBoxBitsParada)
        Me.PanelConfiguracoes.Controls.Add(Me.ComboBoxPorta)
        Me.PanelConfiguracoes.Controls.Add(Me.Label7)
        Me.PanelConfiguracoes.Controls.Add(Me.Label3)
        Me.PanelConfiguracoes.Controls.Add(Me.Label4)
        Me.PanelConfiguracoes.Controls.Add(Me.ComboBoxParidade)
        Me.PanelConfiguracoes.Controls.Add(Me.ComboBoxVelocidade)
        Me.PanelConfiguracoes.Controls.Add(Me.Label5)
        Me.PanelConfiguracoes.Controls.Add(Me.Label6)
        Me.PanelConfiguracoes.Controls.Add(Me.ComboBoxBitsDados)
        Me.PanelConfiguracoes.Location = New System.Drawing.Point(346, 75)
        Me.PanelConfiguracoes.Name = "PanelConfiguracoes"
        Me.PanelConfiguracoes.Size = New System.Drawing.Size(113, 216)
        Me.PanelConfiguracoes.TabIndex = 5
        '
        'ComboBoxBitsParada
        '
        Me.ComboBoxBitsParada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBitsParada.FormattingEnabled = True
        Me.ComboBoxBitsParada.Items.AddRange(New Object() {"1", "1.5", "2"})
        Me.ComboBoxBitsParada.Location = New System.Drawing.Point(12, 181)
        Me.ComboBoxBitsParada.Name = "ComboBoxBitsParada"
        Me.ComboBoxBitsParada.Size = New System.Drawing.Size(83, 21)
        Me.ComboBoxBitsParada.TabIndex = 16
        Me.ComboBoxBitsParada.TabStop = False
        '
        'ComboBoxPorta
        '
        Me.ComboBoxPorta.AccessibleDescription = ""
        Me.ComboBoxPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPorta.FormattingEnabled = True
        Me.ComboBoxPorta.IntegralHeight = False
        Me.ComboBoxPorta.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15"})
        Me.ComboBoxPorta.Location = New System.Drawing.Point(12, 21)
        Me.ComboBoxPorta.Name = "ComboBoxPorta"
        Me.ComboBoxPorta.Size = New System.Drawing.Size(83, 21)
        Me.ComboBoxPorta.TabIndex = 0
        Me.ComboBoxPorta.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Bits de Parada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Porta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Velocidade"
        '
        'ComboBoxParidade
        '
        Me.ComboBoxParidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxParidade.FormattingEnabled = True
        Me.ComboBoxParidade.Items.AddRange(New Object() {"Nenhum", "Par", "Ímpar", "Marca", "Espaço"})
        Me.ComboBoxParidade.Location = New System.Drawing.Point(12, 141)
        Me.ComboBoxParidade.Name = "ComboBoxParidade"
        Me.ComboBoxParidade.Size = New System.Drawing.Size(83, 21)
        Me.ComboBoxParidade.TabIndex = 14
        Me.ComboBoxParidade.TabStop = False
        '
        'ComboBoxVelocidade
        '
        Me.ComboBoxVelocidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVelocidade.FormattingEnabled = True
        Me.ComboBoxVelocidade.IntegralHeight = False
        Me.ComboBoxVelocidade.Items.AddRange(New Object() {"300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "56000", "57600", "115200", "128000", "230400", "256000", "460800", "921600"})
        Me.ComboBoxVelocidade.Location = New System.Drawing.Point(12, 61)
        Me.ComboBoxVelocidade.Name = "ComboBoxVelocidade"
        Me.ComboBoxVelocidade.Size = New System.Drawing.Size(83, 21)
        Me.ComboBoxVelocidade.TabIndex = 11
        Me.ComboBoxVelocidade.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Bits de Dados"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Paridade"
        '
        'ComboBoxBitsDados
        '
        Me.ComboBoxBitsDados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBitsDados.FormattingEnabled = True
        Me.ComboBoxBitsDados.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.ComboBoxBitsDados.Location = New System.Drawing.Point(12, 101)
        Me.ComboBoxBitsDados.Name = "ComboBoxBitsDados"
        Me.ComboBoxBitsDados.Size = New System.Drawing.Size(83, 21)
        Me.ComboBoxBitsDados.TabIndex = 12
        Me.ComboBoxBitsDados.TabStop = False
        '
        'ButtonAbrirPorta
        '
        Me.ButtonAbrirPorta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAbrirPorta.Location = New System.Drawing.Point(12, 10)
        Me.ButtonAbrirPorta.Name = "ButtonAbrirPorta"
        Me.ButtonAbrirPorta.Size = New System.Drawing.Size(83, 23)
        Me.ButtonAbrirPorta.TabIndex = 17
        Me.ButtonAbrirPorta.TabStop = False
        Me.ButtonAbrirPorta.Text = "Abrir Porta"
        Me.ButtonAbrirPorta.UseVisualStyleBackColor = True
        '
        'ButtonFecharPorta
        '
        Me.ButtonFecharPorta.Enabled = False
        Me.ButtonFecharPorta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFecharPorta.Location = New System.Drawing.Point(12, 38)
        Me.ButtonFecharPorta.Name = "ButtonFecharPorta"
        Me.ButtonFecharPorta.Size = New System.Drawing.Size(83, 23)
        Me.ButtonFecharPorta.TabIndex = 18
        Me.ButtonFecharPorta.TabStop = False
        Me.ButtonFecharPorta.Text = "Fechar Porta"
        Me.ButtonFecharPorta.UseVisualStyleBackColor = True
        '
        'ButtonSobre
        '
        Me.ButtonSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSobre.Location = New System.Drawing.Point(12, 66)
        Me.ButtonSobre.Name = "ButtonSobre"
        Me.ButtonSobre.Size = New System.Drawing.Size(83, 23)
        Me.ButtonSobre.TabIndex = 19
        Me.ButtonSobre.TabStop = False
        Me.ButtonSobre.Text = "Sobre"
        Me.ButtonSobre.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(343, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Configurações"
        '
        'ButtonSair
        '
        Me.ButtonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSair.Location = New System.Drawing.Point(12, 94)
        Me.ButtonSair.Name = "ButtonSair"
        Me.ButtonSair.Size = New System.Drawing.Size(83, 23)
        Me.ButtonSair.TabIndex = 20
        Me.ButtonSair.TabStop = False
        Me.ButtonSair.Text = "Sair"
        Me.ButtonSair.UseVisualStyleBackColor = True
        '
        'PanelControle
        '
        Me.PanelControle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelControle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelControle.Controls.Add(Me.ButtonAbrirPorta)
        Me.PanelControle.Controls.Add(Me.ButtonSair)
        Me.PanelControle.Controls.Add(Me.ButtonFecharPorta)
        Me.PanelControle.Controls.Add(Me.ButtonSobre)
        Me.PanelControle.Location = New System.Drawing.Point(346, 290)
        Me.PanelControle.Name = "PanelControle"
        Me.PanelControle.Size = New System.Drawing.Size(113, 129)
        Me.PanelControle.TabIndex = 21
        '
        'ButtonEnviar
        '
        Me.ButtonEnviar.Enabled = False
        Me.ButtonEnviar.Location = New System.Drawing.Point(15, 385)
        Me.ButtonEnviar.Name = "ButtonEnviar"
        Me.ButtonEnviar.Size = New System.Drawing.Size(83, 23)
        Me.ButtonEnviar.TabIndex = 21
        Me.ButtonEnviar.TabStop = False
        Me.ButtonEnviar.Text = "Enviar"
        Me.ButtonEnviar.UseVisualStyleBackColor = True
        '
        'CheckBoxIncluirCRLF
        '
        Me.CheckBoxIncluirCRLF.AutoSize = True
        Me.CheckBoxIncluirCRLF.Checked = True
        Me.CheckBoxIncluirCRLF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxIncluirCRLF.Location = New System.Drawing.Point(104, 385)
        Me.CheckBoxIncluirCRLF.Name = "CheckBoxIncluirCRLF"
        Me.CheckBoxIncluirCRLF.Size = New System.Drawing.Size(189, 17)
        Me.CheckBoxIncluirCRLF.TabIndex = 22
        Me.CheckBoxIncluirCRLF.TabStop = False
        Me.CheckBoxIncluirCRLF.Text = "Incluir CR/LF no fim da mensagem"
        Me.CheckBoxIncluirCRLF.UseVisualStyleBackColor = True
        '
        'CheckBoxEnviarAuto
        '
        Me.CheckBoxEnviarAuto.AutoSize = True
        Me.CheckBoxEnviarAuto.Location = New System.Drawing.Point(104, 408)
        Me.CheckBoxEnviarAuto.Name = "CheckBoxEnviarAuto"
        Me.CheckBoxEnviarAuto.Size = New System.Drawing.Size(182, 17)
        Me.CheckBoxEnviarAuto.TabIndex = 23
        Me.CheckBoxEnviarAuto.TabStop = False
        Me.CheckBoxEnviarAuto.Text = "Enviar caracter automaticamente"
        Me.CheckBoxEnviarAuto.UseVisualStyleBackColor = True
        '
        'TextBoxTX
        '
        Me.TextBoxTX.Enabled = False
        Me.TextBoxTX.Location = New System.Drawing.Point(12, 240)
        Me.TextBoxTX.Multiline = True
        Me.TextBoxTX.Name = "TextBoxTX"
        Me.TextBoxTX.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxTX.Size = New System.Drawing.Size(323, 139)
        Me.TextBoxTX.TabIndex = 24
        Me.TextBoxTX.TabStop = False
        Me.TextBoxTX.WordWrap = False
        '
        'LabelNomePrograma
        '
        Me.LabelNomePrograma.AutoSize = True
        Me.LabelNomePrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelNomePrograma.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNomePrograma.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LabelNomePrograma.Location = New System.Drawing.Point(23, 18)
        Me.LabelNomePrograma.Name = "LabelNomePrograma"
        Me.LabelNomePrograma.Size = New System.Drawing.Size(181, 34)
        Me.LabelNomePrograma.TabIndex = 25
        Me.LabelNomePrograma.Text = "GComSerial"
        '
        'ButtonSalvarRX
        '
        Me.ButtonSalvarRX.FlatAppearance.BorderSize = 0
        Me.ButtonSalvarRX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSalvarRX.Location = New System.Drawing.Point(194, 51)
        Me.ButtonSalvarRX.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonSalvarRX.Name = "ButtonSalvarRX"
        Me.ButtonSalvarRX.Size = New System.Drawing.Size(76, 21)
        Me.ButtonSalvarRX.TabIndex = 21
        Me.ButtonSalvarRX.TabStop = False
        Me.ButtonSalvarRX.Text = "Salvar"
        Me.ButtonSalvarRX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonSalvarRX.UseVisualStyleBackColor = True
        '
        'ButtonLimparRX
        '
        Me.ButtonLimparRX.FlatAppearance.BorderSize = 0
        Me.ButtonLimparRX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLimparRX.Location = New System.Drawing.Point(270, 51)
        Me.ButtonLimparRX.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonLimparRX.Name = "ButtonLimparRX"
        Me.ButtonLimparRX.Size = New System.Drawing.Size(70, 21)
        Me.ButtonLimparRX.TabIndex = 26
        Me.ButtonLimparRX.TabStop = False
        Me.ButtonLimparRX.Text = "Limpar RX"
        Me.ButtonLimparRX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonLimparRX.UseVisualStyleBackColor = True
        '
        'ButtonLimparTX
        '
        Me.ButtonLimparTX.FlatAppearance.BorderSize = 0
        Me.ButtonLimparTX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLimparTX.Location = New System.Drawing.Point(265, 216)
        Me.ButtonLimparTX.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonLimparTX.Name = "ButtonLimparTX"
        Me.ButtonLimparTX.Size = New System.Drawing.Size(70, 21)
        Me.ButtonLimparTX.TabIndex = 28
        Me.ButtonLimparTX.TabStop = False
        Me.ButtonLimparTX.Text = "Limpar TX"
        Me.ButtonLimparTX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonLimparTX.UseVisualStyleBackColor = True
        '
        'ButtonSalvarTX
        '
        Me.ButtonSalvarTX.FlatAppearance.BorderSize = 0
        Me.ButtonSalvarTX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSalvarTX.Location = New System.Drawing.Point(189, 216)
        Me.ButtonSalvarTX.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonSalvarTX.Name = "ButtonSalvarTX"
        Me.ButtonSalvarTX.Size = New System.Drawing.Size(76, 21)
        Me.ButtonSalvarTX.TabIndex = 27
        Me.ButtonSalvarTX.TabStop = False
        Me.ButtonSalvarTX.Text = "Salvar"
        Me.ButtonSalvarTX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonSalvarTX.UseVisualStyleBackColor = True
        '
        'ButtonX
        '
        Me.ButtonX.FlatAppearance.BorderSize = 0
        Me.ButtonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonX.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX.Location = New System.Drawing.Point(449, 0)
        Me.ButtonX.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonX.Name = "ButtonX"
        Me.ButtonX.Size = New System.Drawing.Size(21, 21)
        Me.ButtonX.TabIndex = 29
        Me.ButtonX.TabStop = False
        Me.ButtonX.Text = "X"
        Me.ButtonX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonX.UseVisualStyleBackColor = True
        '
        'ButtonMinimizar
        '
        Me.ButtonMinimizar.FlatAppearance.BorderSize = 0
        Me.ButtonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinimizar.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMinimizar.Location = New System.Drawing.Point(428, 0)
        Me.ButtonMinimizar.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonMinimizar.Name = "ButtonMinimizar"
        Me.ButtonMinimizar.Size = New System.Drawing.Size(21, 21)
        Me.ButtonMinimizar.TabIndex = 30
        Me.ButtonMinimizar.TabStop = False
        Me.ButtonMinimizar.Text = "-"
        Me.ButtonMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonMinimizar.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(470, 464)
        Me.Controls.Add(Me.ButtonMinimizar)
        Me.Controls.Add(Me.ButtonX)
        Me.Controls.Add(Me.ButtonLimparTX)
        Me.Controls.Add(Me.ButtonSalvarTX)
        Me.Controls.Add(Me.ButtonLimparRX)
        Me.Controls.Add(Me.ButtonSalvarRX)
        Me.Controls.Add(Me.LabelNomePrograma)
        Me.Controls.Add(Me.TextBoxTX)
        Me.Controls.Add(Me.CheckBoxEnviarAuto)
        Me.Controls.Add(Me.CheckBoxIncluirCRLF)
        Me.Controls.Add(Me.ButtonEnviar)
        Me.Controls.Add(Me.PanelControle)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PanelConfiguracoes)
        Me.Controls.Add(Me.LabelTX)
        Me.Controls.Add(Me.LabelRX)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TextBoxRX)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GComSerial"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.PanelConfiguracoes.ResumeLayout(False)
        Me.PanelConfiguracoes.PerformLayout()
        Me.PanelControle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxRX As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LabelRX As System.Windows.Forms.Label
    Friend WithEvents StatusConexao As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusPorta As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusVelocidade As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusBitsDados As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusParidade As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusBitsParada As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusNomePrograma As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LabelTX As System.Windows.Forms.Label
    Friend WithEvents PanelConfiguracoes As System.Windows.Forms.Panel
    Friend WithEvents ComboBoxBitsParada As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxPorta As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxParidade As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxVelocidade As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxBitsDados As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonAbrirPorta As System.Windows.Forms.Button
    Friend WithEvents ButtonFecharPorta As System.Windows.Forms.Button
    Friend WithEvents ButtonSobre As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ButtonSair As System.Windows.Forms.Button
    Friend WithEvents PanelControle As System.Windows.Forms.Panel
    Friend WithEvents ButtonEnviar As System.Windows.Forms.Button
    Friend WithEvents CheckBoxIncluirCRLF As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxEnviarAuto As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxTX As System.Windows.Forms.TextBox
    Friend WithEvents LabelNomePrograma As System.Windows.Forms.Label
    Friend WithEvents ButtonSalvarRX As System.Windows.Forms.Button
    Friend WithEvents ButtonLimparRX As System.Windows.Forms.Button
    Friend WithEvents ButtonLimparTX As System.Windows.Forms.Button
    Friend WithEvents ButtonSalvarTX As System.Windows.Forms.Button
    Friend WithEvents ButtonX As System.Windows.Forms.Button
    Friend WithEvents ButtonMinimizar As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class

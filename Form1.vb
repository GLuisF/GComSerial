Imports System.IO
Imports System.Text

Public Class Form1

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <Runtime.InteropServices.DllImport("user32.dll")> _
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <Runtime.InteropServices.DllImport("user32.dll")> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Form1_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        SerialPort1.Close()
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, PanelConfiguracoes.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctrl As Control
        Dim Botoes As String = "ButtomX,ButtonMinimizar,ButtomSalvarRX,ButtomSalvarTX,ButtomLimparRX,ButtomLimparTX"
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is Label Or TypeOf ctrl Is CheckBox Or Botoes.Contains(ctrl.Name) Then
                ctrl.BackColor = Color.Transparent
            End If
        Next
        For Each ctrl In Me.PanelConfiguracoes.Controls
            If TypeOf ctrl Is Label Then
                ctrl.BackColor = Color.Transparent
            End If
        Next
        For Each ctrl In Me.PanelControle.Controls
            If TypeOf ctrl Is Label Then
                ctrl.BackColor = Color.Transparent
            End If
        Next
        ComboBoxPorta.SelectedIndex = 0
        ComboBoxVelocidade.SelectedIndex = 5
        ComboBoxBitsDados.SelectedIndex = 3
        ComboBoxParidade.SelectedIndex = 0
        ComboBoxBitsParada.SelectedIndex = 0
        Me.Text = " - Comunicação com a Porta Serial."
    End Sub

    Delegate Sub meumetodo(ByVal [text] As String)
    Dim subrotinaSTR As New meumetodo(AddressOf TratamentoSTR)
    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        If SerialPort1.IsOpen() Then
            Dim string1 As String = SerialPort1.ReadExisting()
            Invoke(subrotinaSTR, string1)
        End If
    End Sub
    Sub TratamentoSTR(ByVal meustring As String)
        TextBoxRX.Text &= meustring
    End Sub

    Private Sub ButtonX_Click(sender As Object, e As EventArgs) Handles ButtonX.Click
        End
    End Sub

    Private Sub ButtonSair_Click(sender As Object, e As EventArgs) Handles ButtonSair.Click
        End
    End Sub

    Private Sub ButtonAbrirPorta_Click(sender As Object, e As EventArgs) Handles ButtonAbrirPorta.Click
        Try
            SerialPort1.PortName = ComboBoxPorta.SelectedItem
            SerialPort1.BaudRate = CInt(ComboBoxVelocidade.SelectedItem)
            SerialPort1.DataBits = CInt(ComboBoxBitsDados.SelectedItem)
            SerialPort1.Parity = ComboBoxParidade.SelectedIndex
            SerialPort1.StopBits = ComboBoxBitsParada.SelectedIndex + 1
            SerialPort1.Open()
        Catch ex As Exception

        End Try

        If SerialPort1.IsOpen Then
            ButtonAbrirPorta.Enabled = False
            ButtonFecharPorta.Enabled = True
            ButtonEnviar.Enabled = True
            TextBoxTX.Enabled = True
            PanelConfiguracoes.Enabled = False
            StatusConexao.Text = "Conectado"
            StatusPorta.Text = ComboBoxPorta.SelectedItem
            StatusVelocidade.Text = ComboBoxVelocidade.SelectedItem
            StatusBitsDados.Text = ComboBoxBitsDados.SelectedItem
            StatusParidade.Text = ComboBoxParidade.SelectedItem
            StatusBitsParada.Text = ComboBoxBitsParada.SelectedItem
            TextBoxTX.Focus()

        Else
            MessageBox.Show("Um outro programa já está usando a Porta," + vbLf + "ou a mesma não existe !", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ButtonFecharPorta_Click(sender As Object, e As EventArgs) Handles ButtonFecharPorta.Click
        SerialPort1.Close()
        ButtonAbrirPorta.Enabled = True
        ButtonFecharPorta.Enabled = False
        ButtonEnviar.Enabled = False
        TextBoxTX.Enabled = False
        PanelConfiguracoes.Enabled = True
        StatusConexao.Text = "Desconectado"
        StatusPorta.Text = ""
        StatusVelocidade.Text = ""
        StatusBitsDados.Text = ""
        StatusParidade.Text = ""
        StatusBitsParada.Text = ""
    End Sub

    Private Sub TextBoxTX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTX.KeyPress
        If CheckBoxEnviarAuto.Checked Then
            SerialPort1.Write(e.KeyChar)
        End If
    End Sub

    Private Sub ButtonEnviar_Click(sender As Object, e As EventArgs) Handles ButtonEnviar.Click
        'TextBoxTX.Focus()
        SerialPort1.Write(TextBoxTX.Text)
        If CheckBoxIncluirCRLF.Checked Then SerialPort1.Write(vbCrLf)
        TextBoxTX.Text = ""
    End Sub

    Private Sub CheckBoxEnviarAuto_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxEnviarAuto.CheckedChanged
        If ButtonFecharPorta.Enabled Then
            If CheckBoxEnviarAuto.Checked Then
                ButtonEnviar.Enabled = False
            Else
                ButtonEnviar.Enabled = True
            End If
        End If
    End Sub

    Private Sub ButtonLimparRX_Click(sender As Object, e As EventArgs) Handles ButtonLimparRX.Click
        TextBoxRX.Text = ""
    End Sub

    Private Sub ButtonLimparTX_Click(sender As Object, e As EventArgs) Handles ButtonLimparTX.Click
        TextBoxTX.Text = ""
    End Sub

    Private Sub ButtonSalvarRX_Click(sender As Object, e As EventArgs) Handles ButtonSalvarRX.Click
        SaveFileDialog1.Filter = "*.txt|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fs As StreamWriter = File.CreateText(SaveFileDialog1.FileName)
            fs.Write(TextBoxRX.Text)
            fs.Close()
        End If
    End Sub

    Private Sub ButtonSalvarTX_Click(sender As Object, e As EventArgs) Handles ButtonSalvarTX.Click
        SaveFileDialog1.Filter = "*.txt|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fs As StreamWriter = File.CreateText(SaveFileDialog1.FileName)
            fs.Write(TextBoxTX.Text)
            fs.Close()
        End If
    End Sub

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ButtonSobre_Click(sender As Object, e As EventArgs) Handles ButtonSobre.Click
        MessageBox.Show("Comunicação com a Porta Serial para Windows Vista/7/8/8.1 e 10" & vbLf & _
                        "Copyright(c) 2020, GLUISFCOM" & vbLf & _
                        "By Giovani Luis Franco" & vbLf & _
                        "www.github.com/GLuisF" & vbLf & _
                        "gluisf@gmail.com", "GComSerial v1.0 Freeware")
    End Sub

    Private Sub TextBoxTX_LostFocus(sender As Object, e As EventArgs) Handles TextBoxTX.LostFocus
        If TextBoxTX.Enabled Then TextBoxTX.Focus()
    End Sub

    Private Sub TextBoxRX_MouseDown(sender As Object, e As MouseEventArgs) Handles TextBoxRX.MouseDown
        If TextBoxTX.Enabled Then TextBoxRX.Cursor = Cursors.No
    End Sub

    Private Sub TextBoxRX_MouseUp(sender As Object, e As MouseEventArgs) Handles TextBoxRX.MouseUp
        TextBoxRX.Cursor = Cursors.Arrow
    End Sub
End Class

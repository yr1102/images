Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows フォーム デザイナで生成されたコード "

    Public Sub New()
        MyBase.New()

        ' この呼び出しは Windows フォーム デザイナで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後に初期化を追加します。

    End Sub

    ' Form は dispose をオーバーライドしてコンポーネント一覧を消去します。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    ' メモ : 以下のプロシージャは、Windows フォーム デザイナで必要です。
    ' Windows フォーム デザイナを使って変更してください。  
    ' コード エディタは使用しないでください。
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IDNUM As System.Windows.Forms.ComboBox
    Friend WithEvents DevOpen As System.Windows.Forms.Button
    Friend WithEvents DevClose As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DevOpen = New System.Windows.Forms.Button()
        Me.DevClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDNUM = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DevOpen
        '
        Me.DevOpen.Location = New System.Drawing.Point(517, 412)
        Me.DevOpen.Name = "DevOpen"
        Me.DevOpen.Size = New System.Drawing.Size(88, 32)
        Me.DevOpen.TabIndex = 8
        Me.DevOpen.Text = "Dev_Open"
        '
        'DevClose
        '
        Me.DevClose.Location = New System.Drawing.Point(729, 411)
        Me.DevClose.Name = "DevClose"
        Me.DevClose.Size = New System.Drawing.Size(88, 32)
        Me.DevClose.TabIndex = 9
        Me.DevClose.Text = "Dev_Close"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(621, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ID"
        '
        'IDNUM
        '
        Me.IDNUM.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"})
        Me.IDNUM.Location = New System.Drawing.Point(665, 424)
        Me.IDNUM.Name = "IDNUM"
        Me.IDNUM.Size = New System.Drawing.Size(48, 20)
        Me.IDNUM.TabIndex = 11
        Me.IDNUM.Text = "ComboBox1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 68)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 37)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "現在の状態"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(665, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 44)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(663, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 12)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "パトライト状態"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(665, 126)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 44)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(665, 166)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(132, 44)
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(663, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "赤点灯"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(663, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "黄点灯"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(533, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "赤点灯回数"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(533, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 12)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "黄色点灯回数"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(849, 464)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.IDNUM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DevClose)
        Me.Controls.Add(Me.DevOpen)
        Me.Name = "Form1"
        Me.Text = "USB-PIO 入力結果"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '***フォームの表示開始時の初期化処理***
        Function_Disable() '***
        IDNUM.SelectedIndex = 0 '***初期選択IDを0にする
    End Sub
    Private Sub Function_Disable()
        '***オープンとID選択ボタン以外の各ボタン機能を無効にする***
        DevClose.Enabled = False '***クローズボタン無効
        DevOpen.Enabled = True '***オープンボタン有効
        IDNUM.Enabled = True '***ID選択ボタン有効
        '***以下のボタンすべて無効
    End Sub
    Private Sub Function_Enable()
        '***オープンとID選択ボタンのみを無効にする。***
        DevOpen.Enabled = False '***オープンボタン無効
        DevClose.Enabled = True '***クローズボタン有効
        IDNUM.Enabled = False '***ID選択ボタン無効
        '***以下のボタンすべて有効
    End Sub

    Private Sub DevOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevOpen.Click
        '***デバイスのオープン***
        If (sacomUsbIoOpen(IDNUM.SelectedIndex) = True) Then
            Function_Enable() '***各機能ボタンを有効にする
        Else
            MsgBox("オープンできませんでした") '***オープンに失敗した場合
        End If
    End Sub

    Private Sub DevClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevClose.Click
        '***デバイスのクローズ***
        sacomUsbIoClose(IDNUM.SelectedIndex) '***デバイスクローズ
        Function_Disable() '***ボタンの有効無効切り替え12
    End Sub

    Private Sub LowDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '***下位バイトの入出力方向設定
        Dim Ret As String
        Dim Dir As Byte
        Ret = InputBox("下位バイトの入出力定義値を入力してください(HEX)", "Pio_LowDirection", "0")
        If Ret.Length > 0 Then '***OKで返ってきているか
            If IsNumeric("&h" & Ret) Then
                Dir = CByte("&h" & Ret)
                If (Dir >= 0 And Dir <= &HFFS) Then '*** データの範囲にあるか
                    If sacomUsbIoDirL(IDNUM.SelectedIndex, Dir) <> True Then '***DLL関数の実行
                        MsgBox("DLL関数の実行に失敗しました。デバイスをクローズします。") '***書きこみに失敗
                        DevClose_Click(DevClose, New System.EventArgs())
                    End If
                Else
                    MsgBox("データの範囲は0～FF(HEX)です。")
                End If
            Else
                MsgBox("データの入力形式が間違っています->[" & Ret & "]")
            End If
        End If
    End Sub

    Private Sub HighDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '***上位バイトの入出力方向設定
        Dim Ret As String
        Dim Dir As Byte
        Ret = InputBox("上位バイトの入出力定義値を入力してください(HEX)", "Pio_HighDirection", "0")
        If Ret.Length > 0 Then '***OKで返ってきているか
            If IsNumeric("&h" & Ret) Then
                Dir = CByte("&h" & Ret)
                If (Dir >= 0 And Dir <= &HFFS) Then '*** データの範囲にあるか
                    If sacomUsbIoDirH(IDNUM.SelectedIndex, Dir) <> True Then '***DLL関数の実行
                        MsgBox("DLL関数の実行に失敗しました。デバイスをクローズします。") '***書きこみに失敗
                        DevClose_Click(DevClose, New System.EventArgs())
                    End If
                Else
                    MsgBox("データの範囲は0～FF(HEX)です。")
                End If
            Else
                MsgBox("データの入力形式が間違っています->[" & Ret & "]")
            End If
        End If
    End Sub

    Private Sub LowWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '***下位バイトの出力
        Dim Ret As String
        Dim Dir As Byte
        Ret = InputBox("下位バイトの出力値を入力してください(HEX)", "Pio_LowByteWrite", "0")
        If Ret.Length > 0 Then '***OKで返ってきているか
            If IsNumeric("&h" & Ret) Then
                Dir = CByte("&h" & Ret)
                If (Dir >= 0 And Dir <= &HFFS) Then '*** データの範囲にあるか
                    If sacomUsbIoWriteL(IDNUM.SelectedIndex, Dir) <> True Then '***DLL関数の実行
                        MsgBox("DLL関数の実行に失敗しました。デバイスをクローズします。") '***書きこみに失敗
                        DevClose_Click(DevClose, New System.EventArgs())
                    End If
                Else
                    MsgBox("データの範囲は0～FF(HEX)です。")
                End If
            Else
                MsgBox("データの入力形式が間違っています->[" & Ret & "]")
            End If
        End If
    End Sub

    Private Sub HighWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '***上位バイトの出力
        Dim Ret As String
        Dim Dir As Byte
        Ret = InputBox("上位バイトの出力値を入力してください(HEX)", "Pio_HighByteWrite", "0")
        If Ret.Length > 0 Then '***OKで返ってきているか
            If IsNumeric("&h" & Ret) Then
                Dir = CByte("&h" & Ret)
                If (Dir >= 0 And Dir <= &HFFS) Then '*** データの範囲にあるか
                    If sacomUsbIoWriteH(IDNUM.SelectedIndex, Dir) <> True Then '***DLL関数の実行
                        MsgBox("DLL関数の実行に失敗しました。デバイスをクローズします。") '***書きこみに失敗
                        DevClose_Click(DevClose, New System.EventArgs())
                    End If
                Else
                    MsgBox("データの範囲は0～FF(HEX)です。")
                End If
            Else
                MsgBox("データの入力形式が間違っています->[" & Ret & "]")
            End If
        End If
    End Sub

    Private Sub LowRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '***下位バイトの入力データの取得
        Dim dat As Byte
        If sacomUsbIoReadL(IDNUM.SelectedIndex, dat) <> True Then '***DLL関数の実行
            MsgBox("DLL関数の実行に失敗しました。デバイスをクローズします。") '***書きこみ失敗
            DevClose_Click(DevClose, New System.EventArgs())
        Else
            MsgBox("下位バイト入力値は " & Hex(dat) & "(HEX) です")
        End If
    End Sub

    Private Sub HighRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '***上位バイトの入力データの取得
        Dim dat As Byte
        If sacomUsbIoReadH(IDNUM.SelectedIndex, dat) <> True Then '***DLL関数の実行
            MsgBox("DLL関数の実行に失敗しました。デバイスをクローズします。") '***書きこみ失敗
            DevClose_Click(DevClose, New System.EventArgs())
        Else
            MsgBox("上位バイト入力値は " & Hex(dat) & "(HEX) です")
        End If
    End Sub

    Private Sub WordWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '***ワード出力
        Dim Ret As String
        Dim Dir As Integer
        Ret = InputBox("出力値を入力してください(HEX)", "Pio_WordWrite", "0")
        If Ret.Length > 0 Then '***OKで返ってきているか
            If IsNumeric("&h" & Ret) Then
                Dir = CInt("&h" & Ret)
                If (Dir >= 0 And Dir <= &HFFFF) Then '*** データの範囲にあるか
                    If sacomUsbIoWrite(IDNUM.SelectedIndex, Dir) <> True Then '***DLL関数の実行
                        MsgBox("DLL関数の実行に失敗しました。デバイスをクローズします。") '***書きこみに失敗
                        DevClose_Click(DevClose, New System.EventArgs())
                    End If
                Else
                    MsgBox("データの範囲は0～FFFF(HEX)です。")
                End If
            Else
                MsgBox("データの入力形式が間違っています->[" & Ret & "]")
            End If
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dat As Integer
        If sacomUsbIoRead(IDNUM.SelectedIndex, dat) <> True Then '***DLL関数の実行
            MsgBox("DLL関数の実行に失敗しました。デバイスをクローズします。") '***書きこみ失敗
            DevClose_Click(DevClose, New System.EventArgs())
        Else
            MsgBox("ワード入力値は " & (dat) & "(HEX) です")
        End If

    End Sub


    Private cntred As Integer       '赤点灯の回数をカウントしておく
    Private cntyellow As Integer    '黄点灯の回数をカウントしておく
    Private flag_light As String          '連続点灯かどうかの監視フラグ

    Private Sub Form1_Load2(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown, MyBase.Load
        'ここから
        'Timer1の設定
        Label2.Text = "表示します。"
        Timer1.Interval = 10 '.1秒のインターバルで情報を更新
        Timer1.Enabled = True 'タイマーを有効にする



    End Sub
    'Timer
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim dat As Integer
        Dim dathex As String   'HEX化したdatを文字列として格納しておくための変数　String定義じゃないとendswithが使えないってのもある


        sacomUsbIoRead(IDNUM.SelectedIndex, dat)
        Label2.Text = Hex(dat)                  'ラベル2に現在の8byte情報を16進数で表示
        dathex = Hex(dat)

        Label4.Text = cntred
        Label5.Text = cntyellow



        PictureBox1.BackColor = Color.DarkGreen                             'ピクチャーボックスに疑似パトライトを描画dark色を使って非点灯時を表現
        PictureBox2.BackColor = Color.DarkGoldenrod                         'なぜかdarkyellowが無い、代わりにgoldを使ってみたが思ったよりもしっくり
        PictureBox3.BackColor = Color.DarkRed                               'darkred基本的にこの状態のままであってほしい

        '～～～～～以下エラー時の点灯処理　今回の回路はデフォルトがFのため点灯すればするほど数が小さくなる～～

        If dathex.EndsWith("8") Then
            PictureBox1.BackColor = Color.LightGreen
            PictureBox2.BackColor = Color.Yellow
            PictureBox3.BackColor = Color.Red

            flag_light = "8"


        ElseIf dathex.EndsWith("9") Then
            PictureBox2.BackColor = Color.Yellow
            PictureBox3.BackColor = Color.Red

            If flag_light <> "9" Then
                If flag_light = "B" Then
                    cntyellow += 1
                    flag_light = "9"
                ElseIf flag_light = "A" Then
                    cntyellow += 1
                    flag_light = "9"
                ElseIf flag_light <> "9" Then
                    cntred += 1
                End If

                flag_light = "9"
            End If

            flag_light = "9"

        ElseIf dathex.EndsWith("A") Then
            PictureBox1.BackColor = Color.LightGreen
            PictureBox3.BackColor = Color.Red


            If flag_light <> "A" Then
                If flag_light = "B" Then
                    flag_light = "A"
                ElseIf flag_light = "9" Then
                    flag_light = "A"
                ElseIf flag_light = "8" Then
                    flag_light = "A"
                ElseIf flag_light <> "A" Then
                    cntred += 1
                End If
                flag_light = "A"

            End If

        ElseIf dathex.EndsWith("B") Then
            PictureBox3.BackColor = Color.Red

            If flag_light <> "B" Then
                If flag_light = "A" Then
                    flag_light = "B"
                ElseIf flag_light = "9" Then
                    flag_light = "B"
                ElseIf flag_light = "8" Then
                    flag_light = "B"
                ElseIf flag_light <> "B" Then
                    cntred += 1
                End If
                flag_light = "B"

            End If

        ElseIf dathex.EndsWith("C") Then
            PictureBox1.BackColor = Color.LightGreen
            PictureBox2.BackColor = Color.Yellow


            If flag_light <> "C" Then
                cntyellow += 1
            End If
            flag_light = "C"


        ElseIf dathex.EndsWith("D") Then
            PictureBox2.BackColor = Color.Yellow

            If flag_light <> "D" Then
                cntyellow += 1
            End If
            flag_light = "D"

        ElseIf dathex.EndsWith("E") Then
            PictureBox1.BackColor = Color.LightGreen

            flag_light = "E"


        End If

        '～～～～～～～～～～～～～～～～～～～ここまで～～～～～～～～～～～～～～～～～～～～～～～～～～

        'エラーのカウントテスト



    End Sub
End Class

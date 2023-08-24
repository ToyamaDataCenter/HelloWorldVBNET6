'// 注意 : デバッグの練習用です。実際に階乗を計算する処理として利用しないでください。

'// このオプションは解説のため定義している
Option Strict On

Public Class Form1

    ''' <summary>
    ''' [計算] をクリックすると発生します。
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        '// ---------------------------------------------------------------
        '// ---- 階乗を計算する

        '// Try-Catch ブロックはこのブロック内でエラーが発生すると Catch に移動する
        '// ** やってみよう : 実行して、階乗テキストボックスに空や数字以外を入力して計算する
        Try
            '// ---------------------------------------------------------------
            '// ---- 入力されたテキストを数値に変換
            '// Integer は別名 Int32
            Dim nFactorial As Integer
            nFactorial = CInt(Me.txtFactorial.Text)
            '// これはできない
            '// nFactorial = Me.txtFactorial.Text

            '// ---------------------------------------------------------------
            '// ---- 1 から指定された数までの整数を用意する
            '// List は (Of なんとか) で指定されたモノを記録できる。こういうのをコレクションと呼ぶ。
            '// List は数字や文字列と違うので、使うには New が必要。
            '// ** やってみよう : コードエディターで Integer と List にカーソルを合わせてみよう。
            '//                   比べて違いを見つけよう。
            Dim pnNumbers As List(Of Integer)
            pnNumbers = New List(Of Integer)()

            '// For は指定された値になるまで Next のあいだを繰り返す
            '// 書式
            '//     For [変数名] = [最初の数] To [この数を含む終わりの数]
            For nStart = 1 To nFactorial
                '// pnNumbers リストに 1 からの数を追加 (Add) する
                pnNumbers.Add(nStart)

                '// 変数の寿命
                '// nStart は For と Next のあいだのみ使える
                '// 外側のブロック Try-Catch で使えない。
                '// pnNumbers は外側のブロックで宣言されているため、内側のブロックでも使える。
                '//     (詳細は、このセクションの範囲を超えるため割愛)
            Next

            '// ---------------------------------------------------------------
            '// ---- 答えを求める
            Dim nAnswer As Integer
            '// 別の場所で定義したメソッド (関数) で答えを求める
            nAnswer = Me.MultipleAll(pnNumbers)
            '// *** やってみよう : コードエディターで nAnser = の行の左端をクリックしてみよう。
            '//                    行が赤くなった状態で実行しよう。
            '//                    実行が一時停止した状態で、いろいろな変数名にカーソルを合わせてみよう。

            '// ---------------------------------------------------------------
            '// ---- 答えを表示する
            '// 文字列で $ から始めると { } (中かっこ) でくくった変数の内容をテキストで出力できる
            '// もっと正確には [変数名].ToString() の内容を出力する
            Me.txtAnswer.Text = $"{nAnswer}"


            '// *** やってみよう : 階乗に 13 を入力して計算してみよう。
            '//                    (発生するエラーの対処方法は、このセクションの範囲を超えるため割愛)

        Catch ex As Exception
            '// 発生したエラーを表示する
            MessageBox.Show(
                Me,
                ex.Message,
                "階乗を求める",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                )

            '// Visual Studio に詳細なメッセージを出力
            Debug.WriteLine(
                $"{ex}"
                )

        End Try
    End Sub

    ''' <summary>
    ''' 指定されたコレクションにある値をすべて掛け算する。
    ''' </summary>
    ''' <param name="pnNumbers">
    ''' 掛け算をする値を持つコレクション。
    ''' </param>
    ''' <returns>
    ''' 掛け算した答え。
    ''' </returns>
    Private Function MultipleAll(pnNumbers As List(Of Int32)) As Int32

        '// 書式
        '//     {Public/Protected/Private} [Sub/Function] [名前] {( [引数名] As [引数の型], ... )} {As [関数の戻り値型]}
        '// 計算結果を返す必要があるときは Function、ないときは Sub を指定する。
        '// 同じフォーム内で同じ名前をつけることはできない。
        '//     (特定のルールを守れば可能だが、このセクションの範囲を超えるため割愛)
        '// 引数名が他の場所と同じ名前にしても、引き継ぐことはできない。

        Dim nMultipled As Int32
        '// 最初の値 (0 だと掛け算の答えが常に 0 になる)
        nMultipled = 1

        '// For Each はコレクションから 1 つずつ取り出しながら Next のあいだを繰り返す
        '// 書式
        '//     For Each [受け取る変数名] In [コレクションの変数名]
        For Each nNumber In pnNumbers
            '// 前回の計算結果に掛け算をする
            nMultipled = nMultipled * nNumber
            '// このように書いても同じ計算ができる
            '// nMultipled *= nNumber
        Next

        '// 関数なので、値を返す
        Return nMultipled
    End Function

End Class

# Hello, World! Visual Basic .NET with .NET6
このリポジトリーは弊社で開催した 2023 年度インターンシップで利用したものです。
内容は「Visual Basic .NET ではじめてのコーディング体験」です。

# 使い方
1. Visual Studio を起動
1. メニューバーから \[Git\] \- \[リポジトリのクローン\] をクリック
1. \[リポジトリの場所\] に `https://` と入力
1. \[クローン\] をクリック

おめでとうございます!! 初めてのプロジェクトを作成しました!!

# 試してみよう
 - \[F5\] キーを押して実行しよう
## 試せない!?
 - 周りのみんなに聞いてみよう。

# 機能を追加しよう

## ボタンを追加しよう
1. \[ソリューション エクスプローラー\] から \[Form1.vb\] をダブルクリック
1. 左側 \[ルールボックス\] をクリック
1. 一覧から \[共通コントロール\] \- \[Button\] をクリック
1. \[Form1\] の好きなところをクリック
1. \[試してみよう\] をもう一度

おめでとうございます!! デザイナーでコントロールを配置することができました!!  


## メッセージを表示しよう
1. \[ソリューション エクスプローラー\] から \[Form1.vb\] をダブルクリック  
すでに開いているときは次へ
2. 配置したボタンをダブルクリックしよう
3. コードエディターで `Private Sub Button1_Click(...` と `End Sub` のあいだに次のコードを入力しよう
```
MessageBox.Show("Hello,world!")
```

4. \[試してみよう\] をもう一度  
ボタンをしてみよう。

### ヒント
コードエディターに文字を入力すると「入力補間 \(インテリジェンス\)」が動き出すよ。マウスや上下キーで選んで、\[Tab\] キーで入力できるよ。

おめでとうございます!! \[Hello,World!\] を完了できました!!  


## テキスト入力を追加しよう
1. \[ソリューション エクスプローラー\] から \[Form1.vb\] をダブルクリック  
すでに開いているときは次へ
1. 左側 \[ルールボックス\] をクリック
1. 一覧から \[共通コントロール\] \- \[TextBox\] をクリック
1. \[Form1\] の好きなところをクリック
1. 配置したボタンをダブルクリックしよう
3. コードエディターで `MessageBox.Show(...` を次のコードに書き換えよう
```
MessageBox.Show("Hello,world!"+TextBox1.Text)
```

4. \[試してみよう\] をもう一度  
ボタンをしてみよう。

おめでとうございます!! テキストの入力ができました!!  

# もっと知りたいですか?
[Microsoft Learn](https://learn.microsoft.com/ja-jp/dotnet/visual-basic/) でさらに学習できます。

# ライセンス
MIT ランセンス

# 著作権 Copyright
Copyright &copy; 株式会社トヤマデータセンター

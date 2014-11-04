#WpfXamlAnimations
XAML だけで色々やってみる  

##HoverAnimationDemo  
CSS3 ライクなホバーエフェクトを XAML だけで実装してみた  

###概要  
こちらの記事「[CSSのみで実装するボタンデザインやホバーエフェクト 20＋α](http://www.nxworld.net/tips/css-only-button-design-and-hover-effects.html)」を見て CSS3 の実力に感動し、ふとこれを XAML だけで再現してみようと思い勢いで実装しました(しています)。 
  
###使い方
自分のアプリに埋め込みたいという人がいたら、ResourceDictionary にしてあるので HoverAnimationResources.xaml を抜き出して使ってください。  
  
###進捗
上記のサイトの 5 を除く 1~11 のアニメーションは実装済みです。
  
  
  
##HorrorControls
ちょっと怖い UserControl や Style を作ってみた

###概要  
目がぐりぐり動いたりするちょっと怖い UserControl や Style を XAML だけで作りました。  
実装次第ちょくちょく更新していきます。  

###使い方
* HorrorEye.xaml  
マウスドラッグで移動可能な、目の UserControl です。ぐりぐり動きます。  
利用には dll ディレクトリ内のファイルを参照に追加してください。  
* HorrorEyeNoDrag.xaml  
上記のマウスドラッグで移動できない版です。参照は不要です。  
* HorrorResources.xaml  
色々と Style が定義されていますがまともに使えるのは HorrorControlStyleKey1 くらいです。  
  
  
  
##MagicCircle
魔法陣です。
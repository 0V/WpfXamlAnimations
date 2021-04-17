# WpfXamlAnimations
Only XAML WPF Animation Library  
jp: XAML だけで色々やってみる  

This repository contains the following projects.  
jp: このリポジトリは次のプロジェクトを含んでいます。 

- HoverAnimatio
- MagicCircle
- HorrorControls


## HoverAnimationDemo Project
the CSS3-like hover effect implemented by XAML only  

jp: CSS3 ライクなホバーエフェクトを XAML だけで実装してみた  

### What's this?
This project is to reproduce the CSS3-like hover animation inspired by this article (http://www.nxworld.net/tips/css-only-button-design-and-hover-effects.html).  

jp: こちらの記事「[CSSのみで実装するボタンデザインやホバーエフェクト 20＋α](http://www.nxworld.net/tips/css-only-button-design-and-hover-effects.html)」を見て CSS3 の実力に感動し、ふとこれを XAML だけで再現してみようと思い実装しています。  
  
![demo](https://raw.github.com/wiki/0V/WpfXamlAnimations/demo/WPFXAMLANIME.gif)

### Usage

1. Import ''HoverAnimationResources.xaml and DefineColor.xaml'' to your project.  
jp: HoverAnimationResources.xaml と DefineColor.xaml をあなたのプロジェクトにインポートしてください。

2. Write the following code at the beginning of your XAML code.  
jp: 下のコードをXAMLの冒頭に書きます。

```
    <Window.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="HoverAnimationResources.xaml"/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Window.Resources>
```

3. Add property to control for applying hover animation style.  
jp: 属性を追加してスタイルを適用します。
```
Style="{StaticResource HoverButtonStyleKey1}"
```

  
## MagicCircle Project

### What's this?
This is a magic circle. Enjoy!  

jp: 魔法陣です。いえい！  


![demo](https://raw.github.com/wiki/0V/WpfXamlAnimations/demo/MagicCircle.gif)

## HorrorControls Project
ちょっと怖い UserControl や Style を作ってみた  

### 概要  
目がぐりぐり動いたりするちょっと怖い UserControl や Style を XAML だけで作りました。  

### 使い方
* HorrorEye.xaml  
マウスドラッグで移動可能な、目の UserControl です。ぐりぐり動きます。  
利用には dll ディレクトリ内のファイルを参照に追加してください。  
* HorrorEyeNoDrag.xaml  
上記のマウスドラッグで移動できない版です。参照は不要です。  
* HorrorResources.xaml  
色々と Style が定義されていますがまともに使えるのは HorrorControlStyleKey1 くらいです。  
  
  

![](https://ae01.alicdn.com/kf/Hb198cd0b3630451881c7238dab6f5499S.jpg)

# CloudEmoticon

[“云颜文字”](https://emoticon.moe)桌面版**非官方**客户端。

~~一两年前自己做这个东西时，编程的姿势水平还是非常低下，代码混乱无比，这东西能跑起来真是个奇迹（逃~~

因为自己也有在电脑上输入颜文字的需求，然而[官方的桌面版客户端](https://github.com/labs7in0/cloudemoji_win)：
* 年久失修（最近一次 Commit 还是在 2014 年）
* 有较多 BUG（载入文件时按了“取消”都会崩溃）
* 仅支持 XML 格式颜文字库（新版已经统一使用 JSON 格式了）
* 没有预编译版（并不是所有人都有安装 Visual Studio……）
* ~~界面不够美观（主观判断）~~
* ……

于是就自己尝试着做了一个桌面版客户端⁽⁽꜀(:3꜂ ꜆)꜄⁾⁾

## 使用截图

![](https://ae01.alicdn.com/kf/Udb8e6ddf2abb45edbd4753d587e057c4q.gif)

## 使用方法

按下 <kbd>Ctrl+Shift+E</kbd> 显示界面，按下数字键（非小键盘）的 <kbd>0</kbd> 到 <kbd>9</kbd>输入内容。

显示界面时，可以按下 <kbd>-</kbd> 和 <kbd>=</kbd> 进行翻页，使用 <kbd>[</kbd> 和 <kbd>]</kbd>切换分组，**就像使用输入法一样**。

> 启动程序后，第一次输入时，**需要点击一下窗体以获取焦点**，否则无法响应快捷键。

右键点击托盘上的图标，在菜单里可以选择读取词库文件、更换皮肤或进行其它设定。

## “云颜文字”词库格式

词库以 JSON 存储，可以使用内置的**词库编辑器**进行编辑。

*内置词库编辑器只支持读取、设置第一条说明。*

``` json
{
    "alias":"词库名称",
    "categories":[
        {
            "entries":[
                {
                    "description":"可以省略的说明",
                    "emoticon":"输入的文本"
                },
                {
                    "description":"",
                    "emoticon":""
                }
            ],
            "name":"分组名称"
        },
        {
            "entries":[
                ...
            ],
            "name":""
        },
        ...
    ],
    "information":[
        "可以省略的说明1",
        "可以省略的说明2",
        ...
    ]
}
```

也可以按照下面的示例，将颜文字以**一行一个**的形式使用 **UTF-8 编码**保存在文本文档中，通过托盘里的“从文本转换”转换为 JSON 格式的颜文字词库，然后读取。

```plain
(・ω・｀ll)
(｀＾´)ノ
(`へ´*)ノ
(*/∇＼*)
(ﾉ∀｀)
(*ﾉωﾉ)
(/ω＼)
...
```

以下的颜文字词库示例，可以保存到本地后读取，也可以复制链接后进行在线读取。

* [“云颜文字”官方词库源](https://emoticon.moe/store) 以下词库来自官方源，已转存至 [Catbox](https://catbox.moe)。
* [KT's favorites](https://files.catbox.moe/ckkp9j.json)
* [A岛颜文字汇集](https://files.catbox.moe/6p6rb2.json)
* [雅诗poi](https://files.catbox.moe/2ykcz0.json)
* [ლ(｡◕ˇ‿ˇ◕｡ლ)](https://files.catbox.moe/u5x8c8.json)
* [CIA](https://files.catbox.moe/gv0spm.json)
* [TransparentLC's Emoticon Collection](https://raw.githubusercontent.com/TransparentLC/CloudEmoticon/master/TransparentLC's%20Emoticon%20Collection.json) 自己收集的将近五百个颜文字。

## 使用的开源库

* [Dotnet Transitions](https://github.com/UweKeim/dot-net-transitions) ![](https://img.shields.io/github/stars/UweKeim/dot-net-transitions?style=social)
* [Json.NET](https://github.com/JamesNK/Newtonsoft.Json) ![](https://img.shields.io/github/stars/JamesNK/Newtonsoft.Json?style=social)
# InterfacePractice
## OO(OOP)物件導向特性
### 類別＆物件
    類別是定義、是設計圖、是描述；物件是類別產生的實體、是實際上的執行者
### 建構式＆多載
    建構式也就是建立這個物件時執行的函式。
    多載的好處在於：同個目標的函式可以根據傳入的參數不同做不一樣的處理。
### 封裝
    封裝的概念並不僅僅只是對屬性定義存取範圍如此而已，提高類別內的內聚性，降低對外的耦合性，隱藏複雜資訊才是最重要的方針
### 繼承
    繼承是一種「is-a」的關係。當你能說出Ａ是一個Ｂ的時候，就代表你認為Ａ可以繼承自Ｂ。
### 多型
    用子類別實作出各式各樣不同的方法，藉此讓父類別的方法藉此達到延伸和多樣化的效果。
### 抽象＆覆寫
    有些類別就是負責定義共通的那些特性，然而它們本身不應該被實體化成一個物件，這種類別我們就應該把它們標記為抽象類別。
    抽象類別在 C# 裡用 abstract 這個修飾詞來表示。
    而方法也能宣告成抽象方法：繼承的子類別一定要實作。
    及虛擬方法：繼承的子類別不一定要實作。
    子類別覆寫虛擬方法可用override或New，預設為New。
### 介面
    如果說繼承是用來表明物件「屬於什麼」；那麼介面就是用來表明物件「能做什麼」。
    如果說封裝是將物件視作一個整體，是隱藏複雜度；那麼介面就是封裝精神的體現。
    如果說多型是指藉著繼承後能實作不同的行為的可能性達到擴展的彈性；那麼介面就是在實作多型。
    核心概念：『我不在乎你是誰，我只在乎你能做什麼。』
### 內聚＆耦合
    內聚代表的是該模組的獨立性，當這個模組可以獨力完成工作，就代表我們能夠重複使用它，且不需要擔心影響到其他模組。
    「如果模組和另一個模組有關聯，那這兩者之間就耦合」
## SOLID五大原則
### 依賴反轉
用公司、不同種類工程師的例子練習。
依賴反轉搭配控制反轉、依賴注入實現。

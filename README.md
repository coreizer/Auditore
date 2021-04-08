# Auditore!

[![Build Status](https://travis-ci.org/coreizer/FoxPrite.svg?branch=master)](https://travis-ci.org/coreizer/FoxPrite)

## 機能
- 棒読みちゃんが実行中かどうかを確認する
- 独自のミュート機能
- 音量, 話速,トーン
- 実行中のタスク数
- 全タスクの削除

## 使用例
```C#
AuditoreClient client = new AuditoreClient();
client.Volume = 100;
client.SpeechSpeed = 50;

// タスクにメッセージを追加する
int taskId = this.client.Push("こんにちは！");

Debug.WriteLine($"追加されたタスクId: { taskId }");

// 全タスク削除
client.ClaerAll(); // or client.Reset();
```

## 作成者
Coreizer

## ライセンス
[Public License v3.0](LICENSE)

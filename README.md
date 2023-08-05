# Auditore

[![build](https://github.com/coreizer/Auditore/actions/workflows/dotnet.yml/badge.svg)](https://github.com/coreizer/Auditore/actions/workflows/dotnet.yml)

## 👀 機能

- 棒読みちゃんが実行中かどうかを確認する
- 独自のミュート機能
- 音量, 話速,トーン
- 実行中のタスク数
- 全タスクの削除

## 📦 使用例

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

## 🔗 コンタクト

- [coreizer.dev](https://www.coreizer.dev)
- [Twitter](https://www.twitter.com/coreizer)

## 👷 作成者

- coreizer

## ⚖️ ライセンス

このプロジェクトは[GPL 3.0](https://opensource.org/license/lgpl-3-0/)に基づいてライセンスされています。詳細については、[ライセンスファイル](LICENSE)を参考してください。

# ForestRunUnity

Forest run ゲーム

ゲーム内容
・プレイヤーをキーボードから操作して板の上を進んでいき、制限時間内に最後にある白い球に触れたらゴール

途中のオブジェクトの説明
・動く木目模様のオブジェクト ・・・ あたってもOK
・動く真っ黒の四角いオブジェクト ・・・ 当たったらゲームオーバー
・真っ黒の円柱のオブジェクト ・・・ 一定の範囲内でプレーヤーを追跡する。当たったらゲームオーバー。


操作方法
矢印キー　上下 ・・・ プレイヤーの前後移動
矢印キー　左右 ・・・ プレイヤーの左右の向き変更
Spaceキー ・・・ ジャンプ


ゲームオーバーの条件
・プレイヤーが黒色のオブジェクトに当たる
・プレイヤーが板から落ちる。
・ゴールにたどりつく制限時間がたつ

工夫点
・森をできるかぎりリアルに再現したこと。板の下に川を設置することで落ちてはいけない状況をよりリアルに再現した
・シンプルなゲームだが、オブジェクトによって当たり判定の有無を分けたり追跡するオブジェクトの存在など、場面によってプレイヤーの緊張感の波をある程度作れた
・現在は階層 は 二つ だが、難易度を上げるために何重にも階層を作ることが可能なため、改良時にはよりオリジナリティーを反映させることが可能。
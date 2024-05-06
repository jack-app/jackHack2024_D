using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{
public string[,] QuestionSen =
            {
            {"Pic001", "女性「席埋まってるんですけど…隣の席座ってもいいですか？」", "「いいですよ！どうぞ！」", "「友達が座る予定なのでごめんなさい…」", "A" },
{ "Pic002", "女性「ありがとう！サークルとかってどこに入っているんですか？」", "バドミントンサークルのBAD B〇YSです。", "バスケットボールサークルです。", "B" },
{ "Pic003", "あなた「せっかくだし連絡先交換しよう！交換するのは……」", "住所", "LINE", "B" },
{ "Pic004", "女性「せっかくだしこれから学食行かない？好きなメニューとかある？」", "からあげ定食", "串ガエル 2種盛り", "A" },
{ "Pic005", "数日後- あなた「今度一緒に遊びに行かない？行き先は……」", "水族館", "霊園", "A" },
{ "Pic006", "女性「いいよ！いつ水族館行く？」", "次の日曜日", "来年の正月", "A" },
{ "Pic007", "当日- あなた「どんな服装で行こう…」", "シンプルなジャケットとパーカー", "セーラー服", "A" },
{ "Pic008", "女性「こんにちは！見たい魚とかあるの？」", "キリン", "クラゲ", "B" },
{ "Pic009", "女性「魚かわいかったね！お昼ご飯なんか食べたいのある？」", "イタリアン", "サンマの塩焼き", "A" },
{ "Pic010", "女性「イタリアン美味しかったね～！お支払いどうしよう？」", "お前が全部払え！", "僕が払うよ！", "B" },
{ "Pic011", "帰宅後-- 女性「今日はありがとう！楽しかった？(LINEで)」", "普通だった。", "楽しかったよ！また今度行こう！", "B" },
{ "Pic012", "男性「今度行きたいところがあるんだけど…えっとね……」", "映画見に行こう！", "廃病院行きたいな～！", "A" },
{ "Pic013", "女性「映画か～！見たい映画でもあるの？」", "恋愛ものの映画", "幼児向けアニメの映画", "A" },
{ "Pic014", "当日- 女性「映画久しぶりだな～。なんか食べながら見る～？」", "蟹", "ポップコーン", "B" },
{ "Pic015", "上映中- 女性「(涙を流しながら見ている)」", "女性の手を握る", "「泣くな！」と怒鳴りつける", "A" },
{ "Pic016", "女性「いい映画だったね～。この後どうしよう…。」", "良かったら夜ご飯食べない？", "丑の刻参りしようよ！", "A" },
{ "Pic017", "あなた「(今日は告白をするぞ…！) あ、あの…」", "月100万稼げるセミナーに行きませんか？", "夜景が見えるところに行きましょう。", "B" },
{ "Pic018", "女性「夜景きれいだね～。ねえ、話って何？」", "夜景に比べると君は霞んで見えるね。", "僕と…付き合ってください！", "B" },
{"Pic019","女性「えっ…？私のどこを好きになってくれたの？」","顔","君の全て","B"},
{"Pic020","女性「喜んで！ねぇねぇ、私のことなんて呼んでくれる？」","ゴブリン","君はなんて呼んでほしいの？","B"},
{"Pic021","数日後…　あなた「彼女のために何か僕はできないだろうか…」","男磨き","彼女を守るためにGPSをつける","A"},
{"Pic022","あなた「筋トレをしよう。どこを鍛えよう……」","顎の筋肉","腕の筋肉","B"},
{"Pic023","あなた「服も新しいのを買おう。どんな服にしよう……」","流行りを取り入れたコーディネート","サンバの服","A"},
{"Pic024","あなた「美容院行くかぁ。髪型どうしよう。」","爽やかな髪型","赤いモヒカン","A"},
{"Pic025","あなた「男磨き終わった！彼女とどこで今度会おう……」","大阪の西成地区","彼女の家に行く","B"},
{"Pic026","数時間後- 女性「こんにちは！あれ？雰囲気変わった？」","ちょっと男磨いてただけだよ。","君の目が腐ったんじゃないの？","A"},
{"Pic027","女性「前の方が好きだったな…。別れましょう。」","無言で殴りかかる","君のために修業したんだよ…","B"},
{"Pic028","女性「でも今のままのあなたはあなたらしくない……」","前の僕のどこが良かったの？","髪を掴んで女性を壁に打ち付ける","A"},
{"Pic029","女性「髪の毛が短いあなたが好き。」","じゃあまた髪切るよ。","じゃあお前も坊主になれよ！","A"},
{"Pic030","男性「あ…あの…」","そんな趣味の君は危機感持った方が良い。","仲直りして、またやり直そう。","B"},

        };
    // Start is called before the first frame update
    void Start()
    {
        //int QueNumber
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

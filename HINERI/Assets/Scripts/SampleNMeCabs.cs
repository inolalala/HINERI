using System.Collections;
using System.Collections.Generic;
using NMeCab;
using UnityEngine;

public class SampleNMeCabs : MonoBehaviour
{
   
    void Start()
    {
        //辞書を指定
        MeCabParam param = new MeCabParam();
        param.DicDir = @"Assets/NMeCab/dic/ipadic";
        
        MeCabTagger tagger = MeCabTagger.Create(param);
        string text = "現在地から一番近い象を呼び寄せる事ができるシェアリングエレファントアプリ「PAOOOOON」";
        MeCabNode node = tagger.ParseToNode(text);
        while (node != null)
        {
            // 文頭と文末にIDのない空ノードがあるためそれ以外を対象とする
            if (node.PosId != 0)
            {
                Debug.Log(node.Surface + "," + node.Feature);
            }
        }

        node = node.Next;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

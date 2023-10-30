using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoaController : MonoBehaviour
{
    //スコアを表示するテキスト
    private GameObject scoaText;

    //現在のスコア
    int totalScoa = 0;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のScoaTextオブジェクトを取得
        this.scoaText = GameObject.Find("ScoaText");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //衝突時にスコアを加算
    private void OnCollisionEnter(Collision collision)
    {
        //衝突したゲームオブジェクトによって別の得点を加算する
        if(collision.gameObject.tag == "SmallStarTag")
        {
            this.totalScoa += 10;
        }
        else if(collision.gameObject.tag == "LargeStarTag")
        {
            this.totalScoa += 20;
        }
        else if(collision.gameObject.tag == "SmallCloudTag")
        {
            this.totalScoa += 15;
        }
        else if(collision.gameObject.tag == "LargeCloudTag")
        {
            this.totalScoa += 30;
        }

        this.scoaText.GetComponent<Text>().text = "Scoa " + totalScoa;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoaController : MonoBehaviour
{
    //�X�R�A��\������e�L�X�g
    private GameObject scoaText;

    //���݂̃X�R�A
    int totalScoa = 0;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������ScoaText�I�u�W�F�N�g���擾
        this.scoaText = GameObject.Find("ScoaText");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�Փˎ��ɃX�R�A�����Z
    private void OnCollisionEnter(Collision collision)
    {
        //�Փ˂����Q�[���I�u�W�F�N�g�ɂ���ĕʂ̓��_�����Z����
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

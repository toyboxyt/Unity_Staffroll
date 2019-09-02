using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staffroll : MonoBehaviour {
    //　テキストのスクロールスピード
    [SerializeField]
    private float textScrollSpeed = 30;
    //　テキストの制限位置
    [SerializeField]
    private float limitPosition = 730f;


    // Use this for initialization
    void Start () {
        StartCoroutine(scrollText());
	}
	
	// Update is called once per frame
	void Update () {
    }

    IEnumerator scrollText()
    {
        bool isStopEndRoll = false;
        
        while (!isStopEndRoll)
        {
            //　エンドロール用テキストがリミットを越えるまで動かす
            if (transform.position.y <= limitPosition)
            {
                float _textScrollSpeed = textScrollSpeed;
                if (Input.anyKey)
                {
                    _textScrollSpeed = textScrollSpeed * 10.0f;
                }
                transform.position = new Vector2(transform.position.x, transform.position.y + _textScrollSpeed * Time.deltaTime);
            }
            else
            {
                isStopEndRoll = true;
            }
            yield return null;
        }

        

        yield return null;
    }

}

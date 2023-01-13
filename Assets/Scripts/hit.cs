using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // 当たった時に呼ばれる関数
    // 当たり判定
    void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Hit"); // ログを表示する
            Debug.Log(collision.gameObject.name); // ぶつかった相手の名前を表示
            Debug.Log(collision.gameObject.tag); //ぶつかった相手のタグを表示
            
            //壁にぶつかった場合、missに遷移
            if (collision.gameObject.tag == "wall")
            {
                SceneManager.LoadScene("miss");
            }
            else if (collision.gameObject.tag == "Finish")
            {
                SceneManager.LoadScene("finish");
            }
            else
            {
                ;
            }


            

        }

        

}


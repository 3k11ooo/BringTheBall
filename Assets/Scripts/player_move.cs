using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    //Forceでキューブを動かすスクリプト
    public Rigidbody rb;
    //ボールの位置座標を取得するスクリプト
    public GameObject boll;
    //位置座標
    private Vector3 position;
    //スクリーン座標に変換した位置座標
    private Vector3 screenToWorldPointPosition;

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbodyコンポーネントを取得する
        rb = GetComponent<Rigidbody>();
        //ワールド内のボールの情報取得
        boll = GameObject.Find("boll_player");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールの位置座標を取得する
        Vector3 boll_position = boll.transform.position;
        //ボールの位置座標のX,Zを変数化
        float boll_position_x = boll_position.x;
        float boll_position_z = boll_position.z;
        // Vector3でマウス位置座標を取得する
        position = Input.mousePosition;
        // z軸修正
        position.z = 10f;
        // マウス位置座標をスクリーン座標からワールド座標に変換する
        screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
        //Debug.Log("マウスくん" + screenToWorldPointPosition);
        //マウスの位置座標のX,Zを変数化
        float mouse_position_x = screenToWorldPointPosition.x;
        float mouse_position_z = screenToWorldPointPosition.z;
        //マウスの移動とボールの移動
        if (Input.GetMouseButton(0)) 
        {
            //Debug.Log("左ボタンが押されている");
            //ボールの座標とマウスの座標の照らし合わせ
            if (mouse_position_x == boll_position_x && mouse_position_z == boll_position_z)
            {
                Debug.Log("重なってます。");
                // ワールド座標に変換されたマウス座標を代入
                //gameObject.transform.position = screenToWorldPointPosition;
            }
            else
            {
                Debug.Log("重なってません。");
                //Debug.Log("マウス" + screenToWorldPointPosition);
                //Debug.Log("ボール" + boll_position);
            }
              

                
        }


    }
        

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableBoll : MonoBehaviour 
{
    //Forceでキューブを動かすスクリプト
    public Rigidbody rb;
    //ボールの位置座標を取得するスクリプト
    public GameObject boll;
    //位置座標
    private Vector3 mousePos;
    //スクリーン座標に変換した位置座標
    private Vector3 screenToWorldPointPosition;
    //ray
    private bool beRay = false;

    // Use this for initialization
    void Start () 
    {
        // Rigidbodyコンポーネントを取得する
        rb = GetComponent<Rigidbody>();
        //ワールド内のボールの情報取得
        boll = GameObject.Find("boll_player");
    }

    // Update is called once per frame
    void Update () 
    {
        //マウスの左ボタン押し込み時に反応
        if (Input.GetMouseButtonDown(0)) 
        {
            RayCheck();
        }
        if (beRay) {
            MovePoisition();
        }
        //左ボタンを離すと解除
        if (Input.GetMouseButtonUp(0)) {
            beRay = false;
        }
        //ボールの位置座標を取得する
        Vector3 boll_position = boll.transform.position;
        Debug.Log("ボールくん" + boll_position);
    }

    private void RayCheck() {
        Ray ray = new Ray();
        RaycastHit hit = new RaycastHit();
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity) && hit.collider == gameObject.GetComponent<Collider>()) {
            beRay = true;
        } else {
            beRay = false;
        }

    }

    private void MovePoisition() {
        // Vector3でマウス位置座標を取得する
        mousePos = Input.mousePosition;
        // z軸修正
        mousePos.z = 10f;
        // マウス位置座標をスクリーン座標からワールド座標に変換する
        screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(mousePos);
        //マウスの位置座標のX,Zを変数化
        float mouse_position_x = screenToWorldPointPosition.x;
        float mouse_position_z = screenToWorldPointPosition.z;
        //マウスのy座標固定
        // ワールド座標に変換されたマウス座標を代入
        boll.transform.position = new Vector3(mouse_position_x, 0.5f, mouse_position_z);
        Debug.Log("マウスくん" + screenToWorldPointPosition);
    }
}



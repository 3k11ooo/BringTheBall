using UnityEngine;
using System.Collections;

public class lightpos : MonoBehaviour {
    //位置情報を取得するためのスクリプト
    public GameObject boll_lighting;
    public GameObject lightpostion;
    
    void Start () {
        //ワールド内のボールの情報取得
        boll_lighting = GameObject.Find("boll_player");
        //ワールド内のライトの情報取得
        lightpostion = GameObject.Find("Spot Light");
    }

    void Update () {
        //ボールの位置情報を取得する
        Vector3 boll_position = boll_lighting.transform.position;
        //Debug.Log(boll_position);
        float boll_position_x = boll_position.x;
        float boll_position_z = boll_position.z;
        Vector3 light_move = lightpostion.transform.position;
        //Debug.Log(light_move);
        float light_position_y = light_move.y;
        
        //ボールの位置情報をもとにライトを移動させる
       transform.position = new Vector3(boll_position_x, light_position_y ,boll_position_z);
    }
}
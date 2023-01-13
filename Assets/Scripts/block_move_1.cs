using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block_move_1 : MonoBehaviour
{
    // Start is called before the first frame update

    //上昇値を変数化
    float x = 0;
    //float z = 0.1f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        x += 2f * Time.deltaTime;
        transform.position = new Vector3 (Mathf.Abs(Mathf.Sin(x))+0.5f, 0.5f, 0.5f);
        //Debug.Log(transform.position);
    }
}

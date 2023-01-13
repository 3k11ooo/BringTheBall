using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block_move : MonoBehaviour
{
    // Start is called before the first frame update

    //上昇値を変数化
    //float x = 0;
    float z = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        z += 1f * Time.deltaTime;
        transform.position = new Vector3 (3.5f, 0.5f, Mathf.Abs(Mathf.Sin(z))+1.5f);
        //Debug.Log(transform.position);
        
    }
}

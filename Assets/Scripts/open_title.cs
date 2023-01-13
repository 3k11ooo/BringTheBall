using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class open_title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) // マウスの左ボタンでシーン遷移する
        {
            SceneManager.LoadScene("title"); // ここに遷移先のシーン名を入れる
        }
    }
}

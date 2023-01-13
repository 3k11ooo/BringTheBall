using UnityEngine;
using System.Collections;
using System.Collections.Generic;
 
public class GetClickedGameObject : MonoBehaviour {
 
    GameObject clickedGameObject;
 
    void Update () {
 
        if (Input.GetMouseButtonDown(0)) {
            
            Debug.Log("作動中");

            clickedGameObject = null;
 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
 
            if (Physics.Raycast(ray, out hit)) {
                clickedGameObject = hit.collider.gameObject;
            }
 
            Debug.Log(clickedGameObject);
        }
    }
}
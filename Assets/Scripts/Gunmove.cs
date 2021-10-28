using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //마우스 조준
        //Vector3 mousePos = new Vector3(Input.mousePosition.z,Input.mousePosition.x,4f); 
        Vector3 target = new Vector3(Input.mousePosition.x,Input.mousePosition.y,Input.mousePosition.z);//위아래
        Vector3 target2 = new Vector3(Input.mousePosition.x,Input.mousePosition.z,Input.mousePosition.y);//좌우로 움직이긴하나 불안함
        Vector3 target3 = new Vector3(Input.mousePosition.z,Input.mousePosition.x,Input.mousePosition.y); //위아래
        Vector3 target4 = new Vector3(Input.mousePosition.y,Input.mousePosition.z,Input.mousePosition.x); // 좌우가 반전됨
        Vector3 target5 = new Vector3(Input.mousePosition.x,Input.mousePosition.z,Input.mousePosition.x); //위를향해서쏨
        Vector3 target6 = new Vector3(Input.mousePosition.x,Input.mousePosition.z,Input.mousePosition.z); // 우측상단 고정됨
        Vector3 target7 = new Vector3(Input.mousePosition.x,Input.mousePosition.z,Input.mousePosition.y);
        
        Debug.Log("x좌표"+Input.mousePosition.y);
        //Debug.Log("z좌표"+Input.mousePosition.z);

        transform.LookAt(target7);
        // if(Input.mousePosition.x > 350 && Input.mousePosition.x < 1050 ){
        //     transform.LookAt(-target7);
        // }else{
            
    
        // };
        
        
    }
}

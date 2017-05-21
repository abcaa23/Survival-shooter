using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    int layer;
   // public GameObject gun;
    
    private bool isHaveGun = false;
	// Use this for initialization
	void Start () {
        layer = LayerMask.GetMask("gun");
         
        print(layer);
		
	}
	
	// Update is called once per frame
	void Update () {
       // if(isHaveGun == true)
      // {
       //   gun.transform.position = transform.position;
        
      // }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit, 5f, layer))
        {
            if (isHaveGun==false)
            {
                if (Input.GetKey(KeyCode.F))
                {

                      GameObject oj = GameObject.Find("main_weapon001");
                     oj.GetComponent<MeshRenderer>().enabled = true;

                  //  gun = Instantiate(gun, transform.position, transform.rotation);
                   // gun.transform.Rotate(30, 180, 30);
                    // hit.transform.position = transform.position;
                    isHaveGun = true;

                    Vector3 offet = new Vector3(100, 100, 0);
                    hit.transform.position = hit.transform.position + offet;


                }
            }
           

          
        }
		
	}
}

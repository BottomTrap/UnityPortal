using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPortal : MonoBehaviour {
    

    public GameObject firstPortal;
    public GameObject secondPortal;

    GameObject charCamera;
	// Use this for initialization
	void Start () {
		charCamera= GameObject.FindWithTag("MainCamera"); 
	}
	void shoot (GameObject portal){
		int x = Screen.width /2;
		int y = Screen.height /2;

		Ray ray = charCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit)){
			//Quaternion hitObjectRotation = Quaternion.LookRotation(hit.normal);
			portal.transform.position = hit.point;
			//portal.transform.rotation = hitObjectRotation;
		}
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Debug.Log("firstportal");
			shoot(firstPortal);

		}
		if (Input.GetMouseButtonDown(1)){
            Debug.Log("secondportal");
		    shoot(secondPortal);
		}
	}

}

using UnityEngine;
using System.Collections;

public class RayCheck : MonoBehaviour {

    private RaycastHit hit;
    public static bool startEvent = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        
        if (Physics.Raycast(transform.position, fwd, out hit, 100))
        {
            if (hit.collider.tag == "rayTrigger")
            {
                startEvent = true;
                Destroy(hit.collider);
                Debug.Log("HIT");
            }
        }
            

    }
}

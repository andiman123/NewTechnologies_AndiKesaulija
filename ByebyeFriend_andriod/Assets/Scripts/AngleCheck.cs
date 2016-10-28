using UnityEngine;
using System.Collections;

public class AngleCheck : MonoBehaviour {

    public float angleY , angleX;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        Vector3 euler = transform.eulerAngles;

        print(angleX);
        angleY = euler.y;
        angleX = euler.x;

    }
}

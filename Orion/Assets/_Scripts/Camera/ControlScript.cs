using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour {

    public GameObject playerModel;
    public GameObject camera;

    private Rigidbody movement;
    private Transform camPos;

	// Use this for initialization
	void Start () {
        movement = playerModel.GetComponent<Rigidbody>();
        camPos = camera.transform;
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 vector = new Vector3(-y, 0, x) * 2.0f;
        movement.velocity = vector;

        camPos.position = movement.position + new Vector3(10, 5, 0);
        camPos.LookAt(movement.position, new Vector3(0, 1, 0));
	}
}

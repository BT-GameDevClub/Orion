using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour {

    public GameObject playerModel;
    public GameObject camera;
    public LayerMask mask;

    private Rigidbody movement;
    private Transform camPos;



	// Use this for initialization
	void Start () {
        movement = playerModel.GetComponent<Rigidbody>();
        camPos = camera.transform;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePosition = Input.mousePosition;

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 vector = new Vector3(-y, 0, x) * 2.0f;
        movement.velocity = vector;

        Ray aiming = camera.GetComponent<Camera>().ScreenPointToRay(mousePosition);
        RaycastHit hit;
        Debug.DrawRay(aiming.origin, aiming.origin + 10000 * aiming.direction);
        //LayerMask mask = LayerMask.GetMask("MouseHit");
        bool hasHit = Physics.Raycast(aiming, out hit, 1000, mask);

        if (hasHit) {
            Vector3 forward = (hit.point - movement.position);
            movement.rotation = Quaternion.LookRotation(new Vector3(forward.x, 0, forward.z), new Vector3(0, 1, 0));
        }

        camPos.position = movement.position + new Vector3(10, 10, 0);
        camPos.LookAt(movement.position, new Vector3(0, 1, 0));
	}
}

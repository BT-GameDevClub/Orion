using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveTest : MonoBehaviour
{
    // SCRIPT IS FOR TESTING ONLY, NOT TO BE USED FOR PLAYER MOVEMENT



    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 input = GetInput();
        rb.AddForce(input * 25);
    }

    private Vector3 GetInput() {
        return new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }
}

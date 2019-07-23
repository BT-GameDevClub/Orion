using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptedDoor : MonoBehaviour // Change to universal component in the future
{
    [Range(0,1)]
    public float speed;
    public Vector3 displacement;

    // <!-- Door Properties --!> //
    private Vector3 openPos;
    private Vector3 closedPos;

    public DoorState initialState;
    private DoorState state;

    private Vector3 velocity;

    // <!-- Testing --!> //
    public bool toggleDoor;

    void Start()
    {
        state = initialState;
        UpdateEndPositions();
    }

    // <!-- Public Methods --!> //

    // Called by outside trigger to initiate door open/close
    public void ToggleDoor()
    {
        switch (state)
        {
            case DoorState.OPEN:
                state = DoorState.CLOSING;
                break;
            case DoorState.CLOSED:
                state = DoorState.OPENING;
                break;
            default:
                // Door is either opening or closing
                break;
        }

    }

    // Sets a new end position for the door when opened.
    public void UpdateEndPositions()
    {
        openPos = transform.position - displacement;
        closedPos = transform.position;
    }

    // <!-- Update Loops --!> //

    private void FixedUpdate()
    {
        if (toggleDoor)
        {
            toggleDoor = false;
            ToggleDoor();
        }
        UpdateDoor();
    }


    // <!-- Private Methods --!> //

    // Opens/Closes the door
    private void UpdateDoor()
    {
        // Holders
        Vector3 endPos;
        DoorState endState;

        // Sets values for holders based on state
        switch (state)
        {
            case DoorState.OPENING:
                endPos = openPos;
                endState = DoorState.OPEN;
                break;
            case DoorState.CLOSING:
                endPos = closedPos;
                endState = DoorState.CLOSED;
                break;
            default:
                // Door is either open or closed
                return;
        }

        // Snaps and ends execution if door is within acceptable range
        if (Mathf.Abs(Vector3.Distance(transform.position, endPos)) < 0.05f)
        {
            transform.position = endPos;
            state = endState;
            return;
        }

        // Moves the door across displacement
        transform.position = Vector3.SmoothDamp(transform.position,endPos,ref velocity, speed);

    }

}

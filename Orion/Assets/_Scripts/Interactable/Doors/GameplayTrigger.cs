using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayTrigger : MonoBehaviour
{
    public ScriptedDoor door;

    private void OnTriggerEnter()
    {
        door.ToggleDoor();
    }
}

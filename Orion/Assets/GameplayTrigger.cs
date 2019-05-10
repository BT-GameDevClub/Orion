using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayTrigger : MonoBehaviour
{
    public ScriptedDoor door;

    void OnTriggerEnter() {
        door.Open();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speed = 2.5f;

    private void OnTriggerEnter(Collider other) {
        FirstPersonMovement player = other.GetComponent<FirstPersonMovement>();

        if(player ) {
            player.runSpeed *= speed;
        }
    }

    private void OnTriggerExit(Collider other) {
        FirstPersonMovement player = other.GetComponent<FirstPersonMovement>();

        if(player ) {
            player.runSpeed /= speed;
        }
    }
}

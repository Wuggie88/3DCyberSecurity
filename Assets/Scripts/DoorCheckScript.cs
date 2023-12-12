using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorCheckScript : MonoBehaviour
{

    public GameObject statusTextHolder;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            statusTextHolder.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            statusTextHolder.SetActive(false);
        }
    }
}

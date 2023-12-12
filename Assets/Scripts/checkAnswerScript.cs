using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class checkAnswerScript : MonoBehaviour
{
    public int answerCorrect = 1;

    [Header("UI Text")]
    [SerializeField] public TMP_Text statusText;


    private void Start() {
        checkSwitch();
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("answerCube")) {
            //Code to check the cubes state
            if (other.gameObject.GetComponent<answerCubeScript>().correctAnswer) {
                answerCorrect = 2;
                checkSwitch();
            } else {
                answerCorrect = 3;
                checkSwitch();
            }
        }
    }

    void checkSwitch() {
        switch (answerCorrect) {
            case 1:
                statusText.text = "placer den rigtige firkant på bordet med skærmen";
                break;
            case 2:
                statusText.text = "Tillykke, du valgte den rigtige firkant!";
                break;
            case 3:
                statusText.text = "Desværre, dette er ikke den rigtige firkant, prøv igen";
                break;
            default:
                statusText.text = "placer den rigtige firkant på bordet med skærmen";
                break;
        }
    }



}

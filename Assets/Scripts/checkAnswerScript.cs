using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkAnswerScript : MonoBehaviour
{
    public bool answerCorrect = false;

    /*TODO:
     * Make a lot of prefabs for correct and wrong answer cubes,
     * Make the monitor update depending on what the correct answer is
     * make sure the correct cubes spawn, depending on what the right answer is
     * */
    

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("answerCube")) {
            //Code to check the cubes state
            if (other.gameObject.GetComponent<answerCubeScript>().correctAnswer) {
                Debug.Log("Correct Cube");
            } else {
                Debug.Log("Wrong Cube");
            }
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class gameManager : MonoBehaviour
{
    public int assignmentPicked;

    public GameObject[] A1;
    public GameObject[] A2;
    public GameObject[] A3;

    public GameObject lossScreen;
    public GameObject player;

    public TMP_Text assText;
    public TMP_Text timerText;
    public TMP_Text statusText;

    public float timeRemaining = 90;
    private bool timeIsRunning = false;
    public float minutes;
    public float seconds;
    public float miliSeconds;

    void Awake() {
        assignmentPicked = Random.Range(1, 4);
    }
    void Start()
    {
        timeIsRunning = true;
        switch (assignmentPicked) {
            case 1:
                for (int i = 0; i < A1.Length; i++) {
                    Instantiate(A1[i], new Vector3(11, 1.745f, 1 + i), Quaternion.identity);
                    assText.text = "sdu.dk";
                };
                break;
            case 2:
                for (int i = 0; i < A2.Length; i++) {
                    Instantiate(A2[i], new Vector3(11, 1.745f, 1 + i), Quaternion.identity);
                    assText.text = "digst.dk";
                };
                break;
            case 3:
                for (int i = 0; i < A3.Length; i++) {
                    Instantiate(A3[i], new Vector3(11, 1.745f, 1 + i), Quaternion.identity);
                    assText.text = "digitalsikkerhed.dk";
                };
                break;
            default:
                for (int i = 0; i < A1.Length; i++) {
                    Instantiate(A1[i], new Vector3(11, 1.745f, 1 + i), Quaternion.identity);
                    assText.text = "sdu.dk";
                };
                break;
        }
    }

    private void Update() {
        if (timeIsRunning) {
            if (timeRemaining > 0) {
                if (statusText.text != "Tillykke, du valgte den rigtige firkant!") {
                    timeRemaining -= Time.deltaTime;
                    displayTime(timeRemaining);
                } else {
                    displayTime(timeRemaining);
                }
            } else {
                lossScreen.SetActive(true);
                timeIsRunning = false;
                timeRemaining = 0;
                player.GetComponent<PMovement>().enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
        
    }

    void displayTime(float timeToDisplay) {
        minutes = Mathf.FloorToInt(timeToDisplay / 60);
        seconds = Mathf.FloorToInt(timeToDisplay % 60);
        miliSeconds = (timeToDisplay % 1) * 1000;
        timerText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, miliSeconds);
    }

    public void restartGame() {
        SceneManager.LoadScene("Kasper");
    }
}

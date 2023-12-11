using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    public int assignmentPicked;

    public GameObject[] A1;
    public GameObject[] A2;
    public GameObject[] A3;

    public TMP_Text assText;

    void Awake() {
        assignmentPicked = Random.Range(1, 4);
    }
    // Start is called before the first frame update
    void Start()
    {
        switch (assignmentPicked) {
            case 1:
                for (int i = 0; i < A1.Length; i++) {
                    Instantiate(A1[i], new Vector3(11, 1.745f, 1 + i), Quaternion.identity);
                    assText.text = "sdu.dk";
                };
                break;
            case 2:
                for (int i = 0; i < A1.Length; i++) {
                    Instantiate(A2[i], new Vector3(11, 1.745f, 1 + i), Quaternion.identity);
                    assText.text = "Test.dk";
                };
                break;
            case 3:
                for (int i = 0; i < A1.Length; i++) {
                    Instantiate(A3[i], new Vector3(11, 1.745f, 1 + i), Quaternion.identity);
                    assText.text = "cyber.eu";
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
}

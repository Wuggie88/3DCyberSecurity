using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject A1;
    public GameObject A2;

    void Awake() {
        //pick a random puzzle to solve..
    }
    // Start is called before the first frame update
    void Start()
    {
        //instantiate all the cubes needed for the picked puzzle
        Instantiate(A1, new Vector3(11, 1.75f, 2.5f), Quaternion.identity);
        Instantiate(A2, new Vector3(11, 1.75f, 4.25f), Quaternion.identity);
    }
}

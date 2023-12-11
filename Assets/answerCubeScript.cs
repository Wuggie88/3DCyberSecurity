using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class answerCubeScript : MonoBehaviour
{
    public NoteController _noteController;

    [Space(10)]
    [SerializeField] [TextArea] public string noteText;

    [Header("Correct Cube bool")]
    [SerializeField] public bool correctAnswer;


    void Awake() {
        _noteController = this.GetComponent<NoteController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _noteController.noteText = noteText;
    }
   

}

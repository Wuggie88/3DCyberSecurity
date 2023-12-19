using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour
{

    [Header("Raycast Features")]
    [SerializeField] public float rayLength = 5;
    public Camera _camera;

    public NoteController _noteController;



    void Start()
    {
        _camera = GetComponent<Camera>();
    }
    void Update()
    {
        if (Physics.Raycast(_camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f)), transform.forward, out RaycastHit hit, rayLength)) {
            var readableItem = hit.collider.GetComponent<NoteController>();
            if (readableItem != null) {
                _noteController = readableItem;
            } else {
                ClearNote();
            }
        } else {
            ClearNote();
        }
        if(_noteController != null) {
            _noteController.ShowNote();
        }
    }
    void ClearNote() {
        if(_noteController != null) {
            _noteController.DisableNote();
            _noteController = null;   
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {

    public Transform _targetIcon;
    int _layerItem = 1 << 9;
    Transform _tracker;

    // Start is called before the first frame update
    void Start() {
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update() {
        if (_tracker) {
            Vector3 screenPos = Camera.main.WorldToScreenPoint(_tracker.position);
            _targetIcon.GetComponent<RectTransform>().anchoredPosition = screenPos * 1920f / Screen.width;
        }
    }

    private void OnTriggerEnter(Collider other) {
        _tracker = other.transform;
        _targetIcon.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other) {
        _tracker = null;
        _targetIcon.gameObject.SetActive(false);
    }

    void checkCollider() {
        if (Physics.CheckSphere(transform.position, 2, _layerItem)) {
            Debug.Log(1);
        }
    }

    public Transform GetInteract() {
        return _tracker;
    }

}

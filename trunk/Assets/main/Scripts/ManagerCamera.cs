using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerCamera : MonoBehaviour {

    CinemachineBrain _brain;

    // Start is called before the first frame update
    void Awake() {
        _brain = GetComponent<CinemachineBrain>();
        _brain.m_CameraActivatedEvent.AddListener((cur, last) => {
            if (cur.Name.Contains("FreeLook1")) {
                ((CinemachineFreeLook)cur).m_XAxis.Value = 0;
            }
            else if (cur.Name.Contains("FreeLook2")) {
                ((CinemachineFreeLook)cur).m_XAxis.Value = ((CinemachineFreeLook)last).m_XAxis.Value;
            }
        });
    }

    public void OnCameraChange(CinemachineBrain brain) {
        Debug.Log(brain.ActiveVirtualCamera);
    }

}

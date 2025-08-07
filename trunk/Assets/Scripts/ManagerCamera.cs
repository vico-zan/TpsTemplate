using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using Unity.Cinemachine;
using UnityEngine;

public class ManagerCamera : MonoBehaviour {

    //CinemachineBrain _brain;

    // Start is called before the first frame update
    //void Awake() {
    //    _brain = GetComponent<CinemachineBrain>();
    //    _brain.UpdateMethod.m_CameraActivatedEvent.AddListener((cur, last) => {
    //        if (cur.Name.Contains("FreeLook1")) {
    //            ((CinemachineFreeLook)cur).m_XAxis.Value = 0;
    //        }
    //        else if (cur.Name.Contains("FreeLook2")) {
    //            ((CinemachineFreeLook)cur).m_XAxis.Value = ((CinemachineFreeLook)last).m_XAxis.Value;
    //        }
    //    });
    //}

    public void OnCameraChange1(ICinemachineCamera pre, ICinemachineCamera next) {
        if(pre.Name.Contains("FreeLook1")) {
            ((CinemachineFreeLook)pre).m_XAxis.Value = 0;
        }
        else if(pre.Name.Contains("FreeLook2")) {
            ((CinemachineFreeLook)pre).m_XAxis.Value = ((CinemachineFreeLook)next).m_XAxis.Value;
        }
    }

    public void OnCameraChange(CinemachineBrain brain) {
        Debug.Log(brain.ActiveVirtualCamera);
    }

}

using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class VPlayerController : MonoBehaviour {

    public float moveSpeed;
    public float lookSpeed;

    private Vector2 _move;
    private Vector2 _look;

    Transform _cam;
    PlayerInput _input;
    Animator _animator;
    PlayerInteract _interact;
    bool _isLockControl;

    public CinemachineVirtualCameraBase _vcam1;
    public CinemachineVirtualCameraBase _vcam2;

    private void Awake() {
        _cam = Camera.main.transform;
        _animator = GetComponent<Animator>();
        _animator.applyRootMotion = false;
        _input = GetComponent<PlayerInput>();
        _interact = transform.Find("PlayerInteract").GetComponent<PlayerInteract>();
        _isLockControl = false;
        _input.actionEvents[0].AddListener(OnMove);
        _input.actionEvents[1].AddListener(OnRotate);
        _input.actionEvents[2].AddListener(OnConfirm);
        _input.actionEvents[3].AddListener(OnCancel);
        //Debug.Log(_input.actionEvents.Count);
        //foreach (var action in _input.actionEvents)
        //    Debug.Log(action.actionName);


        CinemachineCore.GetInputAxis = getRotateAxis;
    }

    float getRotateAxis(string axis) {
        if(axis == "Mouse X")
            return _look.x * lookSpeed;
        else if(axis == "Mouse Y")
            return _look.y * lookSpeed;
        return 0;
    }

    private void Start() {
        switchCam(_vcam1);
    }

    public void Update() {
        move(_move);
    }

    private void move(Vector2 direction) {
        float speed = direction.sqrMagnitude;
        _animator.SetFloat("moveSpeed", speed);
        if(speed < 0.1f)
            return;
        var camForward = Vector3.Scale(_cam.forward, new Vector3(1, 0, 1)).normalized;
        var move = direction.y * camForward + direction.x * _cam.right;
        var scaledMoveSpeed = moveSpeed * Time.deltaTime;
        transform.position += move * scaledMoveSpeed;

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(_cam.eulerAngles.y, Vector3.up), Time.deltaTime * 10);
    }

    public void OnMove(InputAction.CallbackContext context) {
        if(_isLockControl) return;
        _move = context.ReadValue<Vector2>();
    }

    public void OnRotate(InputAction.CallbackContext context) {
        _look = context.ReadValue<Vector2>();
    }

    public void OnConfirm(InputAction.CallbackContext context) {
        Transform target = _interact.GetInteract();
        if(target) {
            if(context.phase is InputActionPhase.Performed) {
                _vcam2.LookAt = target;
                _vcam2.transform.position = target.Find("cam").position;
                switchCam(_vcam2);
                lockControl(true);
            }
        }
    }

    public void OnCancel(InputAction.CallbackContext context) {
        if(context.phase is InputActionPhase.Performed) {
            switchCam(_vcam1);
            lockControl(false);
        }
    }

    void switchCam(CinemachineVirtualCameraBase vcam) {
        vcam.MoveToTopOfPrioritySubqueue();
    }

    void lockControl(bool b) {
        transform.Find("Dummy").gameObject.SetActive(!b);
        _isLockControl = b;
        if(b)
            _move = Vector2.zero;
    }
}

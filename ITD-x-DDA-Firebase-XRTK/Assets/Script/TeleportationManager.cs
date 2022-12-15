using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class TeleportationManager : MonoBehaviour
{
    [Header("Controller Obj")]
    public GameObject baseController;
    public GameObject teleportation;

    [Header("Input Action Ref")]
    public InputActionReference teleportActivationRef;

    [Header("Unity Event Obj")]
    public UnityEvent onTeleportActivate;
    public UnityEvent onTeleportCancle;

    private void Start()
    {
        teleportActivationRef.action.performed += TeleportModeActivate;
        teleportActivationRef.action.canceled += TeleportModeCancel;
    }

    private void TeleportModeCancel(InputAction.CallbackContext obj) => Invoke("DeactivateTeleporter", .1f);
    
    void DeactivateTeleporter() => onTeleportCancle.Invoke();

    private void TeleportModeActivate(InputAction.CallbackContext obj) => onTeleportActivate.Invoke();
}

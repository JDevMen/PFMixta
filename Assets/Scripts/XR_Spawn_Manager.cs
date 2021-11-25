using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class XR_Spawn_Manager : MonoBehaviour
{

    [SerializeField] private InputActionAsset actionAsset;

    [SerializeField] private XRRayInteractor rayInteractor;

    private InputAction _thumbstick;


    bool _isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Entr� a start");

        rayInteractor.enabled = false;

        var activate = actionAsset.FindActionMap("XRI RightHand").FindAction("Teleport Mode Activate");
        activate.Enable();
        activate.performed += onSpawnActivate;


        var cancel = actionAsset.FindActionMap("XRI RightHand").FindAction("Teleport Mode Cancel");
        cancel.Enable();
        cancel.performed += onSpawnCancel;

        _thumbstick = actionAsset.FindActionMap("XRI RightHand").FindAction("Move");
        _thumbstick.Enable();

    }

    // Update is called once per frame
    void Update()
    {
        if (!_isActive)
            return;

        if (_thumbstick.triggered)
        {
            Debug.Log("Entr� a thumbstick triggered");
            return;

        }

        Debug.Log("Entr� a revisar si hay alguna colisi�n con el raycast");

        if (!rayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit hit))
        {
            Debug.Log("Raycast para spawn cancelado por falta de colisi�n");
            rayInteractor.enabled = false;
            _isActive = false;
            return;
        }
        else
        {

            Debug.Log("Se activ� el raycast");
            Debug.Log("Coordenadas de raycast " + hit.point);
            _isActive = false;
            rayInteractor.enabled = false;
        }

    }

    private void onSpawnActivate(InputAction.CallbackContext context)
    {
        Debug.LogWarning("Entr� a spawn activate");
        rayInteractor.enabled = true;
        _isActive = true;
    }

    private void onSpawnCancel(InputAction.CallbackContext context)
    {
        Debug.LogWarning("Entr� a spawn cancel");
        rayInteractor.enabled = false;
        _isActive = false;

    }
}

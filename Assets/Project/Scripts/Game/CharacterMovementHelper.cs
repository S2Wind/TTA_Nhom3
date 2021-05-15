using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(Rigidbody))]
public class CharacterMovementHelper : MonoBehaviour
{
    XRRig m_XRRig = null;
    CharacterController m_CharacterController = null;
    CharacterControllerDriver m_Driver = null;

    private void Start()
    {
        m_XRRig = GetComponent<XRRig>();
        m_CharacterController = GetComponent<CharacterController>();
        m_Driver = GetComponent<CharacterControllerDriver>();
    }

    private void Update()
    {
        UpdateCharacterController();
    }


    /// <summary>
    /// Update the <see cref="CharacterController.height"/> and <see cref="CharacterController.center"/>
    /// based on the camera's position.
    /// </summary>
    protected virtual void UpdateCharacterController()
    {
        if (m_XRRig == null || m_CharacterController == null)
            return;

        var height = Mathf.Clamp(m_XRRig.cameraInRigSpaceHeight, m_Driver.minHeight, m_Driver.maxHeight);

        Vector3 center = m_XRRig.cameraInRigSpacePos;
        center.y = height / 2f + m_CharacterController.skinWidth;

        m_CharacterController.height = height;
        m_CharacterController.center = center;
    }
}

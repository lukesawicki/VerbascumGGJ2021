using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivityFactor = 110.0F;
    public float pitch = 0.0F;

    public Transform player;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseXaxies = Input.GetAxis("Mouse X") * mouseSensitivityFactor * Time.deltaTime;
        float mouseYaxies = Input.GetAxis("Mouse Y") * mouseSensitivityFactor * Time.deltaTime;

        player.Rotate(Vector3.up * mouseXaxies);
        pitch = pitch - mouseYaxies;
        pitch = Mathf.Clamp(pitch, -90.0F, 90.0F);
        transform.localRotation = Quaternion.Euler(pitch, 0.0F, 0.0F);
    }
}

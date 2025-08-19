using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 800f;
    public Transform playerBody;

    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Hide and lock cursor to center
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Prevents over-rotation

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // Up/down
        playerBody.Rotate(Vector3.up * mouseX); // Left/right
    }
}

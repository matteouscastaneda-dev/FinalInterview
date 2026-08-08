using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private Vector2 moveInput;
    private float zoomInput;

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    private void LateUpdate()
    {
        Vector3 direction = new Vector3(moveInput.x, 0f, moveInput.y);
        transform.position = transform.position + direction * speed * Time.deltaTime;

        transform.localPosition += transform.forward * zoomInput * speed * Time.deltaTime;
    }

    public void OnZoom(InputAction.CallbackContext context)
    {
        zoomInput = context.ReadValue<float>();
    }
}

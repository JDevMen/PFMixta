using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector2 horizontalInput;

    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 11f;
    [SerializeField] private float smoothInputSpeed = 0.2f;

    private Vector2 smoothInputVelocity;

    public void ReceiveInput(Vector2 pHorizontalInput)
    {
        horizontalInput = Vector2.SmoothDamp(horizontalInput, pHorizontalInput, ref smoothInputVelocity, smoothInputSpeed);

        //horizontalInput = pHorizontalInput;
        Debug.Log(horizontalInput);
    }

    private void Update()
    {
        Vector3 horizontalVelocity = (transform.right * horizontalInput.x + transform.forward * horizontalInput.y);
        controller.Move(horizontalVelocity * Time.deltaTime * speed);
    }
}

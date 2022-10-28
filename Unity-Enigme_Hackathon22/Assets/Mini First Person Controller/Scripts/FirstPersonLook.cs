using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonLook : MonoBehaviour
{
    [SerializeField]
    Transform character;
    public float sensitivity = 2f;
    public float smoothing = 1.5f;

    
    Vector2 velocity;
    Vector2 frameVelocity;

    private InputAction moveAction; 
    private PlayerInputAction actions; 
    private CharacterController controller;


    void Reset()
    {
        // Get the character from the FirstPersonMovement in parents.
        character = GetComponentInParent<flyMove>().transform;
    }

    void Start()
    {
        // Lock the mouse cursor to the game screen.
        Cursor.lockState = CursorLockMode.Locked;

        actions = new PlayerInputAction(); 
        moveAction = actions.Player.Look; 
        moveAction.Enable();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {

        Vector2 cameraDirection = moveAction.ReadValue<Vector2>();


        // Get smooth velocity.
        
        Vector2 rawFrameVelocity = Vector2.Scale(cameraDirection, Vector2.one / sensitivity);
        frameVelocity = Vector2.Lerp(frameVelocity, rawFrameVelocity, 1 / smoothing);
        velocity += frameVelocity;
        velocity.y = Mathf.Clamp(velocity.y, -90, 90);

        // Rotate camera up-down and controller left-right from velocity.
        transform.localRotation = Quaternion.AngleAxis(-velocity.y, Vector3.right);
        character.localRotation = Quaternion.AngleAxis(velocity.x, Vector3.up);
    }
}

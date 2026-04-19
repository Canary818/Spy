using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    public Rigidbody2D body;
    InputAction moveAction;
    InputAction jumpAction;
    private bool jumping = false;
    public bool vision = false;
    [SerializeField] GameObject visionField;
    [SerializeField] Sprite sprite1;
    [SerializeField] Sprite sprite2;
    private float timer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
        visionField.SetActive(false);
        timer = 0.5f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!vision)
        { 
            Vector2 moveValue = moveAction.ReadValue<Vector2>();

            if (moveAction.IsPressed())
            {
                transform.Translate(new Vector3(moveValue.x * 5 * Time.deltaTime, 0, 0));
            }

            if (jumpAction.WasPressedThisFrame() && !jumping)
            {
                body.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
                jumping = true;
            }
        }
        if (timer >= 0) timer -= Time.deltaTime;
        else 
        {
            timer = 0.5f;
            if (gameObject.GetComponent<SpriteRenderer>().sprite == sprite1) gameObject.GetComponent<SpriteRenderer>().sprite = sprite2;
            else gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
        };
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground") jumping = false;
    }

    public void toggleVision()
    {
        vision = !vision;
        visionField.SetActive(vision);
    }

    private void OnMouseDown()
    {
        toggleVision();
    }

}

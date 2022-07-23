using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode interactKey;

    private Rigidbody2D rb;

    public Vector2 moveForce = new Vector2(1f, 1f);
    public float baseSpeed = 0f;
    public bool trophy = false;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(upKey))
        {
            baseSpeed = 0f;
            Vector2 movement = new Vector2 (0f, baseSpeed += moveForce.y * Time.deltaTime);
            rb.transform.Translate(movement);
        }

        if (Input.GetKey(downKey))
        {
            baseSpeed = 0f;
            Vector2 movement = new Vector2(0f, baseSpeed -= moveForce.y * Time.deltaTime);
            rb.transform.Translate(movement);
        }

        if (Input.GetKey(leftKey))
        {
            baseSpeed = 0f;
            Vector2 movement = new Vector2(baseSpeed -= moveForce.y * Time.deltaTime, 0f);
            rb.transform.Translate(movement);
        }

        if (Input.GetKey(rightKey))
        {
            baseSpeed = 0f;
            Vector2 movement = new Vector2(baseSpeed += moveForce.y * Time.deltaTime, 0f);
            rb.transform.Translate(movement);
        }

        if (Input.GetKeyDown(interactKey))
        {
            Debug.Log("Interact");
            
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"Collided with {collision.gameObject.name}");

        InteractableObject interactableObject = collision.gameObject.GetComponent<InteractableObject>(); 
        if (interactableObject != null)
        {
            interactableObject.OnInteracted(this);
        }
        trophy = true;
    }
}

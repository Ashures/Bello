using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode interactKey;

    private Rigidbody2D rb;

    public Vector2 speed = new Vector2(1f, 1f);
    public float baseSpeed = 0f;
    public bool trophy = false;
    private TrophyMove _trophy;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        rb.velocity = Vector2.zero;

        if(Input.GetKey(upKey))
        {
            rb.MovePosition(new Vector2(transform.position.x + baseSpeed * Time.deltaTime, transform.position.y + speed.y * Time.deltaTime));
        }

        if (Input.GetKey(downKey))
        {
            rb.MovePosition(new Vector2(transform.position.x + baseSpeed * Time.deltaTime, transform.position.y - speed.y * Time.deltaTime));
        }

        if (Input.GetKey(leftKey))
        {
            rb.MovePosition(new Vector2(transform.position.x - speed.x * Time.deltaTime, transform.position.y + baseSpeed * Time.deltaTime));
        }

        if (Input.GetKey(rightKey))
        {
            rb.MovePosition(new Vector2(transform.position.x + speed.x * Time.deltaTime, transform.position.y + baseSpeed * Time.deltaTime));
        }

        if (Input.GetKeyDown(interactKey))
        {
            Debug.Log("Interact");
            if (_trophy != null)
            {
                _trophy.Drop();
                _trophy = null;
            }
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
        
    }

    public void Pickup(TrophyMove trophy)
    {
        _trophy = trophy;
    }
}

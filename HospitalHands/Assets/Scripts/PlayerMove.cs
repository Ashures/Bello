using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode interactKey;

    private Rigidbody2D rb;

    public Vector2 speed = new Vector2(25f, 25f);
    public float baseSpeed = 25f;
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
        speed = Vector2.zero;
        rb.velocity = Vector2.zero;

        // Single key move
        if(Input.GetKey(upKey))
        {
            //rb.MovePosition(new Vector2(transform.position.x + baseSpeed * Time.deltaTime, transform.position.y + speed.y * Time.deltaTime));
            speed.y = 1f;
        }

        if (Input.GetKey(downKey))
        {
            //rb.MovePosition(new Vector2(transform.position.x + baseSpeed * Time.deltaTime, transform.position.y - speed.y * Time.deltaTime));
            speed.y = -1f;
        }

        if (Input.GetKey(leftKey))
        {
            //rb.MovePosition(new Vector2(transform.position.x - speed.x * Time.deltaTime, transform.position.y + baseSpeed * Time.deltaTime));
            speed.x = -1f;
        }

        if (Input.GetKey(rightKey))
        {
            //rb.MovePosition(new Vector2(transform.position.x + speed.x * Time.deltaTime, transform.position.y + baseSpeed * Time.deltaTime));
            speed.x = 1f;
        }
        speed.Normalize();
        speed *= baseSpeed;
        rb.MovePosition(new Vector2(transform.position.x + speed.x * Time.deltaTime, transform.position.y + speed.y * Time.deltaTime));

        if (Input.GetKeyDown(interactKey))
        {
            Debug.Log("Interact");
<<<<<<< HEAD
=======

>>>>>>> ec06d0476107bc25ba637bbd9590fe8da5499ec3
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

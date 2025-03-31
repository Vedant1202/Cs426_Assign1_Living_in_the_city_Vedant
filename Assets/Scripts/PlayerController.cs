using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public float moveForce = 10f;
    public Transform throwPoint;  // Assign this to an empty GameObject above BB8
    public GameObject[] fruitPrefabs; // Apple = 0, Banana = 1, etc.
    public float throwForce = 600f;

    private int selectedFruit = 0;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        HandleThrowing();
        HandleFruitSwitch();
    }

    void FixedUpdate()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(moveX, 0f, moveZ).normalized;
        rb.AddForce(moveDirection * moveForce, ForceMode.Force);
    }

    void HandleFruitSwitch()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) selectedFruit = 0;
        if (Input.GetKeyDown(KeyCode.Alpha2)) selectedFruit = 1;
        if (Input.GetKeyDown(KeyCode.Alpha3)) selectedFruit = 2;
    }

    void HandleThrowing()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Spawn from throwPoint's position
            GameObject fruit = Instantiate(fruitPrefabs[selectedFruit], throwPoint.position, Quaternion.identity);
            Rigidbody fruitRb = fruit.GetComponent<Rigidbody>();

            if (fruitRb != null)
            {
                // Launch in throwPoint's forward direction with a 45-degree upward arc
                Vector3 throwDirection = (throwPoint.forward + Vector3.up).normalized;
                fruitRb.AddForce(throwDirection * throwForce);
            }
        }
    }
}

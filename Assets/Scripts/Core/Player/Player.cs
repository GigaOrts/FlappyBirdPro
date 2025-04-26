using UnityEngine;
using Zenject;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private Rigidbody2D _body2D;
    public float jumpForce = 10;

    private void Awake()
    {
        _body2D = GetComponent<Rigidbody2D>();
    }

    [Inject]
    private void Construct()
    {

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    private void Jump()
    {
        _body2D.linearVelocity = Vector3.zero;
        _body2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}

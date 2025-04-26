using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PipeHazard : Hazard
{
    [SerializeField] private float _speed;

    private Rigidbody2D _body2D;

    private void Start()
    {
        _body2D = GetComponent<Rigidbody2D>();
        _body2D.linearVelocity = new Vector2(_speed * Time.fixedDeltaTime, 0f);
    }
}

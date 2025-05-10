using UnityEngine;
using Zenject;

namespace Core
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerView : MonoBehaviour
    {
        private Player _player;
        private Rigidbody2D _body2D;

        [Inject]
        private void Construct(Player player)
        {
            _player = player;
        }
        
        private void Awake()
        {
            _body2D = GetComponent<Rigidbody2D>();
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
            _body2D.AddForce(Vector2.up * _player.jumpForce, ForceMode2D.Impulse);
        }
    }
}


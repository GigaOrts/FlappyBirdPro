using UnityEngine;
using Zenject;

public class Hazard : MonoBehaviour
{
    private GamePause _gamePause;

    [Inject]
    private void Construct(GamePause gamePause)
    {
        _gamePause = gamePause;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out PlayerView _))
        {
            _gamePause.Pause();
        }
    }
}

using UnityEngine;

public class XBOTAnimationController : MonoBehaviour
{

    private Animator animatorController;
    [SerializeField] private float velocity;
    [SerializeField] private float aceleration = 0.1f;
    [SerializeField] private float deceleration = 0.5f;
    void Awake()

    {
        animatorController = GetComponent<Animator>();
    }
    private void Update()
    {
        bool _move = Input.GetKey(KeyCode.W);
        bool _shooting = Input.GetKey(KeyCode.P);
        if (_move && velocity < 1)
        {
            velocity += Time.deltaTime * aceleration;
            animatorController.SetFloat("velocity", velocity);
        }
        if (!_move && velocity > 0)
        {
            velocity -= Time.deltaTime * deceleration;

            animatorController.SetFloat("velocity", velocity);
        }

        if (_shooting)
        {
            animatorController.SetBool("isShooting", true);
        }
        if (!_shooting)
        {
            animatorController.SetBool("isShooting", false);
        }
    }
}
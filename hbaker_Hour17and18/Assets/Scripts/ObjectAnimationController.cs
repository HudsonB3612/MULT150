using UnityEngine;

public class ObjectAnimationController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("PlayColor");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("PlayScale");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("PlaySpin");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("PlayHover");
        }
    }
}
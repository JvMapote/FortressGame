using UnityEngine.Audio;
using UnityEngine;

public class WalkingScript : MonoBehaviour
{
    public float runSpeed = 5f;
    public Animator animator;
    static AudioSource audioSource;
    float horizontalMove = 0f;
    Rigidbody2D rb;
    bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        //components
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //input value for move
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        //animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        bool jumping = animator.GetBool("IsJumping");
        bool crouching = animator.GetBool("IsCrouching");
        //is it moving?
        if (rb.velocity.x != 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

       /* if (isMoving)
        {

            if (!audioSource.isPlaying && (jumping == false && crouching == false))
            {
               
                
                    audioSource.loop = true;
                    audioSource.Play();
                
                }
        }
        else
        {
            audioSource.loop = false;

        } */

    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }
}

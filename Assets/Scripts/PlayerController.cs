using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    private float jumpForce = 8f;
    private Rigidbody2D rb2d;
    public bool canJump;
    public int JewelCount;
    public int Health;

    public Text HPText;
    public Text JewelText;

    private void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && canJump == true)
        {
            GetComponent<Animator>().Play("Rotation360");
            rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            canJump = false;
        }
    }

    public void LateUpdate()
    {
        HPText.text = Health.ToString();
        JewelText.text = JewelCount.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }
    }

    [System.Obsolete]
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Jewel"))
        {
            JewelCount++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Spike"))
        {
            Health--;
            if (Health <= 0)
                Application.LoadLevel(Application.loadedLevel);
        }
    }
}

using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float timeToTurn;

    private float timer;
    private Rigidbody2D rbEnemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbEnemy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= timeToTurn)
        {
            timer = 0;
            transform.localScale = new Vector3(transform.localScale.x * -1, 1, 1);
        }
    }

    private void FixedUpdate()
    {
        rbEnemy.linearVelocity = new Vector2(speed * transform.localScale.x, rbEnemy.linearVelocity.y);
    }
}

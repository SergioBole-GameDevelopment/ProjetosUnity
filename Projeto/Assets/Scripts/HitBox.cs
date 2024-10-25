using UnityEngine;

public class HitBox : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HurtBox hurt = collision.GetComponent<HurtBox>();
        if (hurt != null)
        {
            hurt.Hit();
        }
    }
}

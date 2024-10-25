using UnityEngine;

public class HurtBox : MonoBehaviour
{
    [SerializeField] private GameObject death;
    public void Hit()
    {
        GameObject newObject = Instantiate(death, transform.position, Quaternion.identity);

        Destroy(newObject, 0.6f);

        Destroy(transform.parent.gameObject);
    }
}

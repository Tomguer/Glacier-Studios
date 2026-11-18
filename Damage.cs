using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] int damage = 1;
    void OnTriggerStay(Collider other)
    {
        PlayerHealth health = other.GetComponent<PlayerHealth>();
        if (health != null) health.TakeDamage(damage);
    }
}
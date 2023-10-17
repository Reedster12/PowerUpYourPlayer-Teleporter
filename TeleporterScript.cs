using UnityEngine;

public class TeleporterScript : MonoBehaviour
{
    public GameObject orb;
    private float orbRespawnTime;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Teleport the player to (0, 1, 0)
            other.transform.position = new Vector3(0,1,0);

            // Set the orbRespawn time
            orbRespawnTime = Time.time + 10f;

            // Make the orb disappear
            orb.SetActive(false);
            gameObject.GetComponent<SphereCollider>().enabled = false;
        }
    }


    private void Update()
    {
        if (Time.time > orbRespawnTime)
        {
            // Make the orb reappear
            orb.SetActive(true);
            gameObject.GetComponent<SphereCollider>().enabled = true;
        }
    }
}

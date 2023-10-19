using UnityEngine;
using Mirror;

public class LAZER : NetworkBehaviour
{
    public Transform LazerTransform;
    public TrailRenderer LazerBeam;

    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer && Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        else if (!isLocalPlayer)
        {
            return;
        }
    }

    public void Shoot()
    {
        Ray ray = new Ray(LazerTransform.position, LazerTransform.forward); // Set raycast spawn position

        TrailRenderer beam = Instantiate(LazerBeam, LazerTransform.position, Quaternion.identity); // Creates a new beam game object

        beam.Clear(); // Clear any previous points in the trail renderer

        beam.AddPosition(LazerTransform.position); // Set the position of the beam to start at the laser transform

        if (Physics.Raycast(ray, out RaycastHit hit, 50f))
        {
            beam.transform.position = hit.point;

            PlayerHealth playerHealth = hit.collider.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth)
            {
                playerHealth.Damage(20);
            }
        }
        else
        {
            beam.transform.position = LazerTransform.position + (LazerTransform.forward * 20f);
        }
    }
}

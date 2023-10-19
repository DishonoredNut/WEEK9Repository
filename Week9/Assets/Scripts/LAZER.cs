/*using UnityEngine;
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
        Ray ray = new Ray (LazerTransform.position, LazerTransform.forward); //set raycast spawn position 

        TrailRenderer beam = Instantiate(lazerBeam, lazerBeam.position, Quaternion.identity); // Creates a new beam game object

        beam.AddPosition(lazerTransform.position); // set position of the beam to start at the laser transform

        if (Physics.Raycast(ray, out RayCastHit hit, 50f))
        {
            beam.transform.postion = hit.point;
            
            Var=PlayerHealth = hit.collider.gameObject.GetComponent<PlayerHealth>();
            if (PlayerHealth)
            {
                PlayerHealth.Damage(20); 
            }
            
        }
          else
        {
            beam.transform.position = LazerTransform.position + (LazerTransform.forward * 20f); 
        }
    }      
}*/

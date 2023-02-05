using UnityEngine;

public class Gun1 : MonoBehaviour
{
    public AudioSource audio;

    public int damage = 10;
    public int range = 100;

    public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetKeyDown("return"))
        {
            Shoot();
            
        }
    }

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Shoot()
    {
        audio.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log("Hello");

            Target target = hit.transform.GetComponent<Target>();


            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}



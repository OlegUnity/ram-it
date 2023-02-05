using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    public Camera cam;
    public int range = 10000;
    public int damage;
    public AudioSource audio;
    public int shellCount = 45;
    public int machineGunShells = 250;
    public AudioSource machineGun;
    public ParticleSystem gun;
    public ParticleSystem machinegun;
    public Text Shellshells;
    public Text machinesunshells;
    public Text currentDamage;
    public ParticleSystem Fire;
    public AudioSource flamthrower;
    
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentDamage.text = "Current Damage: " + damage.ToString();
        Shellshells.text = "Shells: " + shellCount.ToString();
        machinesunshells.text = "Machine gun shells: " + machineGunShells.ToString();
         Debug.DrawRay(transform.position, cam.transform.forward * 650, Color.red);
        if(Input.GetButtonDown("Fire1") && shellCount > 0)
        {
            audio.Play();
            // gun.Play();
            shellCount -= 1;
             damage = 30;
            shoot();
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 650, Color.yellow);
        }

        if(Input.GetButtonDown("Fire2") && machineGunShells > 0)
        {
            // machinegun.Play();
            machineGun.Play();
            machineGunShells -= 1;
            damage = 1;
            shoot();
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            flamthrower.Play();
            Flamethrower();
           Fire.Play(); 
        }

        else 
        {
            Debug.Log("No shells!");
            return;
            
        }
    }

    void shoot()
    {
       
        RaycastHit hit;
           
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            var target = hit.transform.GetComponent<Target>();

            if(target != null)
            {
                if(hit.collider.gameObject.tag == "FuelTank")
                {
                  target.SetOnFire(damage);
                }
                else
                {

               
                 target.TakeDamage(damage);
                }
            }
        }
    }

    void Flamethrower()
    {
        RaycastHit hit;
     if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100))
     {
         var target = hit.transform.GetComponent<Target>();
         if(target != null)
         {
            target.SetOnFire(damage);
         }
     }
    }

    
}

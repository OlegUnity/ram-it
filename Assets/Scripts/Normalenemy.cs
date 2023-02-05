using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Normalenemy : MonoBehaviour
{
    // Start is called before the first frame update
   NavMeshAgent agent;
public GameObject[] arr = new GameObject[2];
public GameObject cube;



void Start()
{
 agent = GetComponent<NavMeshAgent>();

}



void Update()
{

RaycastHit hit;

if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
{
if (hit.collider.gameObject.tag == "cube")
{
agent.SetDestination(cube.transform.position);
Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 650, Color.green);
}

else
{
agent.isStopped = false;
StartCoroutine(MoveBot());
Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 650, Color.yellow);
}

} 

else
{
agent.isStopped = false;
StartCoroutine(MoveBot());
Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 650, Color.red);
}

}

IEnumerator MoveBot()
{

int rnd1 = Random.Range(0, 12);
int[] arr1 = {1, 0, 1,0,0,0,1,1,0,1,0, 1};

int rnd = arr1[rnd1];
agent.SetDestination(arr[rnd].transform.position);
yield return new WaitForSeconds(0.1f);
}

}

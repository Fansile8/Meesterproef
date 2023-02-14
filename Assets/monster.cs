using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
 
public class monster : MonoBehaviour
{
 private NavMeshAgent Mob;
 
 public GameObject Player;
 
 public float MobdistanceRun = 4.0f;
 
 // Start is called before the first frame update
 void Start()
 
 {
 Mob = GetComponent<NavMeshAgent>();
 }
 
 // Update is called once per frame
 void Update()
 {
 float distance = Vector3.Distance(transform.position, Player.transform.position);
 
 //run towards player
 
 if (distance< MobdistanceRun)
 {
 Vector3 dirTopPlayer = transform.position - Player.transform.position;
 
 Vector3 newPos = transform.position - dirTopPlayer;
 
 Mob.SetDestination(newPos);
 }
 }
}
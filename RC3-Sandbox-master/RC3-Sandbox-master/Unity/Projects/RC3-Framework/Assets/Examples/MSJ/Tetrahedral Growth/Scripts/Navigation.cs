using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Navigation : MonoBehaviour
{

    //public float speed = 3.0f;
    //public float directionValue = 1.0f;
    public Transform home;
    NavMeshAgent agent;
    public Image Rating;
    public float fill;

    // Use this for initialization
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(home.transform.position);
        //transform.position += transform.forward * (speed * directionValue) * Time.deltaTime;
        fill = 0;
        Rating.fillAmount = fill;
    }

   
    private void Update()
    {
        var v = (agent.velocity.x + agent.velocity.z + agent.velocity.y) * 0.5f;
        var r = Mathf.Clamp(v, 0.3f, 1);
        Rating.fillAmount = r;
        Debug.Log(Rating.fillAmount);
    }
}
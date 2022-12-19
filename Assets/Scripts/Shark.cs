using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{
    private  Object prefab ;
    private float force { get; set; }
    public GameObject prefabObject { get; private set; }
    public Shark()
    {
        prefab = Resources.Load("Prefabs/shark");
        prefabObject = Instantiate(prefab) as GameObject;
        // Shark yourObject = newObject.GetComponent<Shark>();
        force = 200;
        
    }
    public Shark(Vector3 startPos):this()
    {
        prefabObject.transform.position = startPos;


    }

    public void Attack()
    {
        //GoForward();
        //Animator animator=prefabObject.GetComponent<Animator>();
        //animator.SetTrigger("Attack");//
        //new WaitForSeconds(2);
        //animator.SetTrigger("Moving");
        //Debug.Log("Attack");

        StartCoroutine(AttackAction());
    }
    private IEnumerator AttackAction()
    {
        GoForward();
        Animator animator = prefabObject.GetComponent<Animator>();
        animator.SetTrigger("Attack");//
        yield return new WaitForSeconds(2);
        animator.SetTrigger("Moving");
        Debug.Log("Attack");
    }

    public void GoForward()
    {
        Rigidbody rigidbody = prefabObject.GetComponent<Rigidbody>();
        rigidbody.AddForce(new Vector3(0,0,force),ForceMode.Force);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

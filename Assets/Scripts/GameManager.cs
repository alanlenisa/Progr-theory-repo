using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //[SerializeField]
    //private GameObject subj;

    // Start is called before the first frame update
    List<Shark> familyShark= new List<Shark>();
    void Start()
    {
        Shark DaddyShark = new Shark(new Vector3(0, -0.1f, 0));
        Shark BabyShark = new Shark(new Vector3(0, 0, 0));

        familyShark.Add(DaddyShark);
        familyShark.Add(BabyShark);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            foreach (Shark shark in familyShark)
            {
                shark.Attack();
            }
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject subject;

    // Start is called before the first frame update
    List<Shark> familyShark= new List<Shark>();
    void Start()
    {
        //Shark DaddyShark = new Shark(new Vector3(0, -0.2f, 0));
        //Shark BabyShark = new Shark(new Vector3(0, 0, 0));

        var daddyShark = Instantiate(subject, new Vector3(0, 0, 0), subject.transform.rotation);
        familyShark.Add(daddyShark.AddComponent<DaddyShark>());

        var babyShark = Instantiate(subject, new Vector3(0, -0.2f, 0), subject.transform.rotation);
        familyShark.Add(babyShark.AddComponent<BabyShark>());


        //familyShark.Add(BabyShark);
        
        
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

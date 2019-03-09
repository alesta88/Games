using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public GameObject projectile, gun;
    private GameObject projectileParent;

    private Animator animator;
    private SP myLaneSpawner;




    // Use this for initialization
    void Start () {
        animator = GameObject.FindObjectOfType<Animator>();

        projectileParent = GameObject.Find("Projectiles");
        if (!projectileParent)
        {
            projectileParent = new GameObject("Projectiles");
        }
        SetMyLaneSpawner();
    }
	
	// Update is called once per frame
	void Update () {
        if (IsAttackerAheadInLane())
        {
            animator.SetBool("IsAttacking", true);
        }
        else
        {
            animator.SetBool("IsAttacking", false);
        }
    }

    private void fire()
    {
        GameObject newProjectile = Instantiate(projectile) as GameObject;
        newProjectile.transform.parent = projectileParent.transform;
        newProjectile.transform.position = gun.transform.position;
    }

    void SetMyLaneSpawner()
    {
        SP[] spawnerArray = GameObject.FindObjectsOfType<SP>();

        foreach (SP spawner in spawnerArray)
        {
            if (spawner.transform.position.y == transform.position.y)
            {
                myLaneSpawner = spawner;
                return;
            }
        }

        Debug.LogError(name + " can't find spawner in lane");
    }


    bool IsAttackerAheadInLane()
    {
        // Exit if no attackers in lane
       if (myLaneSpawner.transform.childCount <= 0)
        {
            //print("no teki");
            return false;
        }

        // If there are attackers, are they ahead?
        foreach (Transform attacker in myLaneSpawner.transform)
        {
            if (attacker.transform.position.x > transform.position.x)
            {
                return true;
            }
        }

        // Attacker in lane, but behind us.
        return false;
    }

}



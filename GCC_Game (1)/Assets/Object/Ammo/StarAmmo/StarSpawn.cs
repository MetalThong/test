using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawn : PlayerSpawn
{
    public Sprite starDown;
    public Sprite starUp;
    private int downFire = -1;
    private SpriteRenderer starSprite;

    void Start()
    {
        starSprite = typeOfAmmo.GetComponent<SpriteRenderer>();
        starSprite.sprite = starDown;
    }

    void Update()
    {  
        countChild = transform.childCount;
        if (countChild<3) 
        {
            Spawning ();
        }  
    }

    protected override void Fire() 
    {
        GameObject ammo = Instantiate(typeOfAmmo, transform.position, Quaternion.identity, transform);
        SpriteRenderer ammoSprite = ammo.GetComponent<SpriteRenderer>();
        if (downFire == -1) 
        {   
            ammoSprite.sprite = starDown;   
        }
        else 
        {
            ammoSprite.sprite = starUp;
        }
        ammo.transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y + downFire*0.31f, 0);
        downFire *= -1;
    }
}
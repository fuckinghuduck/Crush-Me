﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillEnd : MonoBehaviour {

    public GameObject[] Scene;
    public BoxCollider2D LazerBox;
    public Lazer LazerSc;

    public void Boom()
    {
        Scene[0].SetActive(false);
        Scene[1].SetActive(false);
        Scene[2].SetActive(true);
    }
    public void Desskill()
    {
        gameObject.SetActive(false);
    }

    public void LazerAniEnd()
    {
        LazerSc.bLazerUsed = false;
        gameObject.SetActive(false);
    }

    public void LazerDmg()
    {
        LazerBox.enabled = true;
    }

    public void LazerDmgOff()
    {
        LazerBox.enabled = false;
    }

}

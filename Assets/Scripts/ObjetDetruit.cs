using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetDetruit : MonoBehaviour
{
public void OnCollisionEnter(Collision other)
{
    Destroy(gameObject);
}
}

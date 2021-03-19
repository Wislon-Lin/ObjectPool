using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{


    ObjectPooler objectPooler;

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;

		InvokeRepeating ("Ins",1,1);
    }

	void Ins()
	{
		objectPooler.SpawnFromPool("Cube",this.transform.position,this.transform.rotation);
	}

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpawner : MonoBehaviour
{
    #region Public Variables

    public GameObject Prefab;

    #endregion

    #region Unity Methods

    private void Start()
    {
        Instantiate(Prefab, Vector3.zero, Quaternion.identity);
    }

    #endregion
}
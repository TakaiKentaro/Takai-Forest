using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookPlayer : MonoBehaviour
{
    [SerializeField] GameObject _player;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(_player.transform);
    }
}

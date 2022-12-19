using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MobileTools;

public class PoolActivator : MonoBehaviour
{
    private FloatingTextPooler m_pooler;

    void Start()
    {
        m_pooler = GetComponent<FloatingTextPooler>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            m_pooler.CreateText("Random Text " + Random.Range(0, 102));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PokeAttatchPoint : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform PokePoint;

    private XRPokeInteractor _xrPokeInteractor;
    
    void Start()
    {
        _xrPokeInteractor = transform.parent.parent.GetComponentInChildren<XRPokeInteractor>();
        SetPokeAttatchPoint();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetPokeAttatchPoint() 
    { 
        if (PokePoint == null) { Debug.Log("Poke Attach Point Is Null"); return; }
        
        if (_xrPokeInteractor ==  null) { Debug.Log("XR Poke Interactor Is Null"); return; }

        _xrPokeInteractor.attachTransform = PokePoint;
    }

}

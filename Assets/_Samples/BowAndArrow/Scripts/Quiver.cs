﻿using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Quiver : XRBaseInteractable
{
    public GameObject arrowPrefab = null;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        CreateAndSelectArrow(args);
    }

    private void CreateAndSelectArrow(SelectEnterEventArgs args)
    {
       
        Arrow arrow = CreateArrow(args.interactorObject.transform);
        interactionManager.SelectEnter(args.interactorObject, arrow);
    }

    private Arrow CreateArrow(Transform orientation)
    {
       
        GameObject arrowObject = Instantiate(arrowPrefab, orientation.position, orientation.rotation);
        return arrowObject.GetComponent<Arrow>();
    }
}

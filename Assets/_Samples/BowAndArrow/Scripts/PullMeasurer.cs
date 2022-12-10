using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class PullMeasurer : XRBaseInteractable
{
    
    public class PullEvent : UnityEvent<Vector3, float> { }
    public PullEvent Pulled = new PullEvent();

    public Transform start = null;
    public Transform end = null;

    public float PullAmount { get; private set; }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        SetPullValues(start.position, 0.0f);
    }

    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        base.ProcessInteractable(updatePhase);

        if (isSelected)
        {
            
            if (updatePhase == XRInteractionUpdateOrder.UpdatePhase.Dynamic)
                CheckForPull();
        }
    }

    private void CheckForPull()
    {
        
        Vector3 interactorPosition = firstInteractorSelecting.transform.position;

        
        float newPullAmount = CalculatePull(interactorPosition);
        Vector3 newPullPosition = CalculatePosition(newPullAmount);

        
        SetPullValues(newPullPosition, newPullAmount);
    }

    private float CalculatePull(Vector3 pullPosition)
    {
        
        Vector3 pullDirection = pullPosition - start.position;
        Vector3 targetDirection = end.position - start.position;

        
        float maxLength = targetDirection.magnitude;
        targetDirection.Normalize();

        
        float pullValue = Vector3.Dot(pullDirection, targetDirection) / maxLength;
        pullValue = Mathf.Clamp(pullValue, 0.0f, 1.0f);

        return pullValue;
    }

    private Vector3 CalculatePosition(float amount)
    {
        
        return Vector3.Lerp(start.position, end.position, amount);
    }

    private void SetPullValues(Vector3 newPullPosition, float newPullAmount)
    {
        
        if (newPullAmount != PullAmount)
        {
            PullAmount = newPullAmount;
            Pulled?.Invoke(newPullPosition, newPullAmount);
        }
    }

    private void OnDrawGizmos()
    {
        
        if (start && end)
            Gizmos.DrawLine(start.position, end.position);
    }
}

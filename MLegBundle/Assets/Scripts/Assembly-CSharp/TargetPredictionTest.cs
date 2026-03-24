using ULTRAKILL.Enemy;
using UnityEngine;

public class TargetPredictionTest : MonoBehaviour
{
	public bool predictPlayerPosition;

	public bool throughPortals;

	public float time;

	public Transform previewPosition;

	public Transform previewPredictedPosition;

	public Transform previewGravityPosition;

	public Transform previewAssumeGroundMovementPosition;

	public Transform previewGravityAndGroundMovementPosition;

	[Header("Preview Toggles")]
	public bool showPosition;

	public bool showPredicted;

	public bool showGravity;

	public bool showGroundMovement;

	public bool showGravityAndGroundMovement;

	private Vision vision;

	private VisionQuery query;

	private void Start()
	{
	}

	private void Update()
	{
	}
}

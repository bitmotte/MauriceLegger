using UnityEngine;
using UnityEngine.Audio;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class CameraController : MonoSingleton<CameraController>
{
	private const float RotationOffsetSpeed = 5f;

	private const float TransitionRotationZSmoothTime = 0.25f;

	private const float TiltRotationZSmoothTime = 0.5f;

	private const float GravitySlerpSnapAngle = 0.01f;

	public bool invert;

	public float minimumX;

	public float maximumX;

	public float minimumY;

	public float maximumY;

	public OptionsManager opm;

	public float scroll;

	public Vector3 defaultTarget;

	public Vector3 originalPos;

	public Vector3 defaultPos;

	private Vector3 targetPos;

	public GameObject player;

	public NewMovement nm;

	[HideInInspector]
	public Camera cam;

	public bool activated;

	public int gamepadFreezeCount;

	public float rotationY;

	public float rotationX;

	public float transitionRotationZ;

	public float tiltRotationZ;

	public bool reverseX;

	public bool reverseY;

	public float cameraShaking;

	public float movementHor;

	public float movementVer;

	public int dodgeDirection;

	public float defaultFov;

	private AudioMixer[] audmix;

	private bool mouseUnlocked;

	private AssistController asscon;

	[SerializeField]
	private GameObject parryLight;

	[SerializeField]
	private GameObject parryFlash;

	[SerializeField]
	private Camera hudCamera;

	private float aspectRatio;

	private bool pixeled;

	private bool tilt;

	private float currentStop;

	private bool zooming;

	private float zoomTarget;

	private LayerMask environmentMask;

	public bool platformerCamera;

	public Quaternion rotationOffset;

	public Quaternion gravityRotation;

	public Vector3 gravityVec;

	public float transitionRotationZSmooth;

	public float tiltRotationZSmooth;

	public Quaternion rotation;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnPrefChanged(string key, object value)
	{
	}

	private void LateUpdate()
	{
	}

	public void ApplyRotations(bool debug = false)
	{
	}

	public void Transform(Matrix4x4 matrix, Vector3? gravity, Quaternion? proposedRotation = null)
	{
	}

	public void SetRotation(Quaternion rotation, Vector3 newGravity, Quaternion? offsetRotation = null)
	{
	}

	private void FixedUpdate()
	{
	}

	public void CameraShake(float shakeAmount)
	{
	}

	public void StopShake()
	{
	}

	public void ResetCamera(float degreesY, float degreesX = 0f)
	{
	}

	public void Zoom(float amount)
	{
	}

	public void StopZoom()
	{
	}

	public void ResetToDefaultPos()
	{
	}

	public Vector3 GetDefaultPos()
	{
		return default(Vector3);
	}

	public void CheckAspectRatio()
	{
	}

	public void CheckMouseReverse()
	{
	}
}

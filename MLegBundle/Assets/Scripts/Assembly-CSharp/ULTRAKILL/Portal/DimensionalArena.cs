using UnityEngine;

namespace ULTRAKILL.Portal
{
	public class DimensionalArena : MonoBehaviour
	{
		[Header("Enter portal side")]
		[SerializeField]
		private Transform volumeA;

		[Header("Exit portal side")]
		[SerializeField]
		private Transform volumeB;

		[Space]
		[SerializeField]
		private Portal portal;

		private Bounds boundsA;

		private Bounds boundsB;

		private void Start()
		{
		}

		private Bounds CalculateBounds(Transform volume)
		{
			return default(Bounds);
		}

		public bool TryGetPortalSide(Vector3 position, out PortalSide side)
		{
			side = default(PortalSide);
			return false;
		}

		public Vector3 TransformPoint(Vector3 position, PortalSide fromSide)
		{
			return default(Vector3);
		}

		private void OnDrawGizmos()
		{
		}
	}
}

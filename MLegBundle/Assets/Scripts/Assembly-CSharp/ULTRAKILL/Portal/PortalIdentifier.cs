using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace ULTRAKILL.Portal
{
	public class PortalIdentifier : MonoBehaviour
	{
		private NavMeshLinkData[] datas;

		private NavMeshLinkInstance[] instances;

		private Vector3[] positions;

		private readonly List<int> validLinkIdx;

		[NonSerialized]
		public bool isTraversable;

		[NonSerialized]
		public bool lastIsTraversable;

		[NonSerialized]
		private PortalHandle handle;

		[NonSerialized]
		private Vector3 lastPos;

		[NonSerialized]
		private Quaternion lastRot;

		[NonSerialized]
		private bool dirty;

		private readonly List<NavMeshLinkInstance>[] linksToRemove;

		private bool isRemoveLinkFromOther;

		private Quaternion updateRot;

		private Vector3 updatePos;

		private float lastUpdateTimer;

		public bool IsValidLinkExist => false;

		public PortalHandle Handle
		{
			get
			{
				return default(PortalHandle);
			}
			set
			{
			}
		}

		public IEnumerable<PortalNavMeshLink> GetValidLinks()
		{
			return null;
		}

		public bool GetClosestLink(Vector3 startPos, out PortalNavMeshLink portalLink)
		{
			portalLink = null;
			return false;
		}

		public bool TryGetOther(out PortalIdentifier other)
		{
			other = null;
			return false;
		}

		public void ResetDirtiness()
		{
		}

		public void SetLinks(NavMeshLinkData[] datas, NavMeshLinkInstance[] instances, Vector3[] positions)
		{
		}

		public void RemoveQueuedLinks()
		{
		}

		public void QueueLinksForRemoval()
		{
		}

		public bool UpdateDirtiness()
		{
			return false;
		}

		public bool CheckUpdateDiff()
		{
			return false;
		}

		private void OnDisable()
		{
		}

		private void RemoveCurrentLinks()
		{
		}

		public void RemoveLinks()
		{
		}

		private void ResetData()
		{
		}
	}
}

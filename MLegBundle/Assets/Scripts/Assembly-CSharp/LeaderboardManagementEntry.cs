using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardManagementEntry : MonoBehaviour
{
	[SerializeField]
	private TMP_Text levelNameLabel;

	[SerializeField]
	private TMP_Text anyPercentScoreLabel;

	[SerializeField]
	private TMP_Text pRankScoreLabel;

	public Button anyPercentResetButton;

	public Button pRankResetButton;

	[Header("Colors")]
	[SerializeField]
	private Color normalScoreColor;

	[SerializeField]
	private Color noScoreColor;

	[SerializeField]
	private Color invalidScoreColor;

	[HideInInspector]
	public int missionNumber;

	public void UpdateEntry(int missionNum, LeaderboardManagementScreen.CachedLevelScore cached)
	{
	}

	private static string FormatTime(int milliseconds)
	{
		return null;
	}
}

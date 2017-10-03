using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour 
{
	public Text GameClearLabel;
	public Text ObstacleLabel;
	public Button RetryButton;

	private void Start ()
	{
		// 開始時に表示を消す
		GameClearLabel.gameObject.SetActive(false);
		// 開始時に表示を消す
		ObstacleLabel.gameObject.SetActive(false);
		// 開始時に表示を消す
		RetryButton.gameObject.SetActive(false);
	}

	public void ShowGameClearLabel()
	{
		// 開始時に表示する
		GameClearLabel.gameObject.SetActive(true);
	}
	public void ShowObstacleLabel()
	{
		// 開始時に表示する
		ObstacleLabel.gameObject.SetActive (true);
	}
	public void ShowRetryButton()
	{
		// 開始時に表示する
		RetryButton.gameObject.SetActive (true);
	}
}
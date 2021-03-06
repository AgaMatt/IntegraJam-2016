﻿using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
	float maxY, minY, maxY2, minY2;
	public GameObject topBorder, bottomBorder, topBorder2, bottomBorder2;
	public float minTime = 1f;
	public float maxTime = 2f;
	public float spawnTimeShooter = 3f;
	public int totalPages = 2000;
	public int totalBooks = 10;
	private int pageCounter, bookCounter;
	public GameObject EnemyPage, EnemyBook;
	public bool doSpawn = true;
	public bool doSpawnShooter = true;


	void Start ()
	{
		bookCounter = totalBooks;
		pageCounter = totalPages;
		maxY = topBorder.transform.position.y;
		minY = bottomBorder.transform.position.y;
		maxY2 = topBorder2.transform.position.y;
		minY2 = bottomBorder2.transform.position.y;
		StartCoroutine (SpawnerPage ());
		StartCoroutine (SpawnerBook ());
		StartCoroutine (SpawnerPage2 ());
	}

	IEnumerator SpawnerPage ()
	{
		while (doSpawn && pageCounter > 0) {
			Instantiate (EnemyPage, new Vector3 (23, Random.Range (minY, maxY), 0), Quaternion.identity);
			pageCounter--;
			yield return new WaitForSeconds (Random.Range (minTime, maxTime));
		}
	}

	IEnumerator SpawnerPage2 ()
	{
		while (doSpawn && pageCounter > 0) {
			Instantiate (EnemyPage, new Vector3 (23, Random.Range (minY2, maxY2), 0), Quaternion.identity);
			pageCounter--;
			yield return new WaitForSeconds (Random.Range (minTime, maxTime));
		}
	}

	/*IEnumerator SpawnPowers()
	{
		yield return new WaitForSeconds (timeinbetween);
		while (doSpawn) {
		  //	float waitingTime;
			/*if (powerCount >= (int)(0.5 * totalEnemies)) {
				waitingTime = timeinbetween;
			} else {
				waitingTime = 0.5f * timeinbetween;
			}*/
	/*if (powerCount == totalEnemies / 2) {
				timeinbetween = timeinbetween / 2;
			}
			Instantiate (nyan, new Vector3 (11, Random.Range (5.46f, -6), 0), Quaternion.identity);
		yield return new WaitForSeconds (timeinbetween); // Era WaitingTime
			powerCount++;
		}
	}*/
	IEnumerator SpawnerBook ()
	{
		while (doSpawn && bookCounter > 0) {
			yield return new WaitForSeconds (spawnTimeShooter);
			Instantiate (EnemyBook, new Vector3 (23, -5.26f, -2), Quaternion.identity);
			bookCounter--;
		}
	}
} 
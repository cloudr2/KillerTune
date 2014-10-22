using UnityEngine;
using System.Collections;

public class EnemyA : Enemy {
	public int lifeSpan = 3;
	public int scoreValue = 100;
	public int damage = -3;//deals damage as a negative value
	public int heal = 1;//amount of hp recovered per kill

	public GUIText GUILifeSpanPrefab;

	private bool wasClicked = false;

	void Start()
	{
		StartCoroutine (LifeCountDown());
	}

	private IEnumerator LifeCountDown()
	{
		GUIText GUILifeSpan = (GUIText)Instantiate(GUILifeSpanPrefab,Camera.main.WorldToViewportPoint (this.transform.position),Quaternion.identity);
		GUILifeSpan.transform.parent = this.transform;
		while(lifeSpan > 0){
			this.lifeSpan --;
			Debug.Log("LIFESPAN = "  + this.lifeSpan);
			Debug.Log("EnemyA spawnRate: " + GameManager.GetCurrentSpawnRate());
			GUILifeSpan.text = this.lifeSpan.ToString();
			yield return new WaitForSeconds(GameManager.GetCurrentSpawnRate());
		}
		Destroy (this.gameObject);
	}

	void OnMouseDown()
	{
		if(gameObject.tag == "Enemy")
		{
			wasClicked = true;
			Destroy(gameObject);
			GameManager.instance.SetScore(this.scoreValue);
			if(HealthManager.instance.currentHealth < HealthManager.instance.maxHealth)
				HealthManager.instance.SetHealth(heal);
		}
	}


	void OnDestroy()
	{
		this.StopAllCoroutines ();
		if(!wasClicked)
			HealthManager.instance.SetHealth(damage);
	}

}
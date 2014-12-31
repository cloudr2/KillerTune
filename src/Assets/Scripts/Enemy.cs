using UnityEngine;
using System.Collections;

public abstract class Enemy : MonoBehaviour {

	protected abstract int lifeSpan {get;set;}
	protected abstract int scoreValue {get;}
	protected abstract int damage {get;}//deals damage as a negative value
	protected abstract int heal {get;}//amount of hp recovered per kill
	
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
		Debug.Log(lifeSpan);
		while(lifeSpan > 0){
			lifeSpan --;
			Debug.Log(lifeSpan);
			//Debug.Log("LIFESPAN = "  + this.lifeSpan);
		//	Debug.Log("EnemyA spawnRate: " + GameManager.GetCurrentSpawnRate());
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
		}
	}
		
		void OnDestroy()
		{
			this.StopAllCoroutines ();
			if(!wasClicked)
				HealthManager.instance.SetHealth(damage);
			else
			{
				GameManager.instance.SetScore(this.scoreValue);
				if(HealthManager.instance.currentHealth < HealthManager.instance.maxHealth)
					HealthManager.instance.SetHealth(heal);
			}
		}




}

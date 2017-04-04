#undef ARRAY

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	private int hp=100;
	private int mp=53;
	private int power=25;
	private const int CONSUMP_MP = 5;

	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	public void MPAttack(){
		if (mp < CONSUMP_MP) {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}else{
			mp -= CONSUMP_MP;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");
		}
	}

	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
	}

}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Boss lastboss = new Boss ();

		for (int i = 0; i < 11; i++) {
			lastboss.MPAttack ();
		}

		#if ARRAY
		int[] array = { 101, 201, 301, 401, 501 };

		for (int i = 0; i < 5; i++) {
			Debug.Log (array[i]);
		}

		for (int i = 0; i < 5; i++) {
			Debug.Log (array[4-i]);
		}
		#endif

	}

	// Update is called once per frame
	void Update () {

	}
}

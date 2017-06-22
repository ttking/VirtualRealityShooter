using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayerShooting : MonoBehaviour {

	public Transform shotgunCrosshair;
	public Transform pistolCrosshair;
    public GameObject projectile;
	private float fireRate = 40;
	private float waitTillNextFire = 0;

	public AudioClip pistolShootSound;
	public AudioClip shotgunShootSound;
	private AudioSource audio;

    private SteamVR_TrackedController controller;
	private SteamVR_TrackedObject trackedObject;
	private SteamVR_Controller.Device device;

	private bool gunChanged;
	[SerializeField]
	private GameObject shotgun;
	[SerializeField]
	private GameObject pistol;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();

		trackedObject = GetComponent<SteamVR_TrackedObject> ();
        controller = GetComponent<SteamVR_TrackedController>();

        controller.TriggerClicked += Shoot ;
		controller.PadClicked += Switch;
		gunChanged = true;
		shotgun.SetActive (false);
	}

    void Shoot (object sender, ClickedEventArgs e)
    {
		{
			if (projectile && !gunChanged)
				{
				if(waitTillNextFire <= 0){
					GameObject newProjectile = Instantiate(projectile, shotgunCrosshair.gameObject.transform.position, transform.rotation)as GameObject;
					newProjectile.GetComponent<Rigidbody>().AddForce(shotgunCrosshair.gameObject.transform.forward * 20f, ForceMode.VelocityChange);

					GameObject newProjectile2 = Instantiate(projectile, shotgunCrosshair.gameObject.transform.position, transform.rotation)as GameObject;
					newProjectile2.GetComponent<Rigidbody>().AddForce(shotgunCrosshair.gameObject.transform.forward * 20f, ForceMode.VelocityChange);

					GameObject newProjectile3 = Instantiate(projectile, shotgunCrosshair.gameObject.transform.position, transform.rotation)as GameObject;
					newProjectile3.GetComponent<Rigidbody>().AddForce(shotgunCrosshair.gameObject.transform.forward * 20f, ForceMode.VelocityChange);

					GameObject newProjectile4 = Instantiate(projectile, shotgunCrosshair.gameObject.transform.position, transform.rotation)as GameObject;
					newProjectile4.GetComponent<Rigidbody>().AddForce(shotgunCrosshair.gameObject.transform.forward * 20f, ForceMode.VelocityChange);

					waitTillNextFire = 1;

					audio.PlayOneShot (shotgunShootSound, 1f);
				}
			}
		}
		waitTillNextFire -= Time.deltaTime * fireRate;
		{
			if (projectile && gunChanged)
        	{
				GameObject newProjectile = Instantiate(projectile, pistolCrosshair.gameObject.transform.position, transform.rotation)as GameObject;
				newProjectile.GetComponent<Rigidbody>().AddForce(pistolCrosshair.gameObject.transform.forward * 20f, ForceMode.VelocityChange);

				audio.PlayOneShot (pistolShootSound, 0.7f);
        	}
    	}
	}

	void Switch(object sender, ClickedEventArgs e){
		if(device.GetAxis().x != 0){
			gunChanged = !gunChanged;
		}	
	}

	// Update is called once per frame
	void Update () {
		device = SteamVR_Controller.Input ((int)trackedObject.index);

		if (!gunChanged) {
			pistol.SetActive (false);
			shotgun.SetActive (true);
		}
		if (gunChanged) {
			shotgun.SetActive (false);	
			pistol.SetActive (true);
		}
	}
}

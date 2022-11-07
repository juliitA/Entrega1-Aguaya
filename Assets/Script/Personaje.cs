using UnityEngine;

public class Personaje : MonoBehaviour
{
	public GameObject objetoAInstanciar;
	public Transform lugar;
	public Animator anim;
	float vel = 0.0f;
	public float acceleration = 5f;
	public float desacceleration = 4f;


	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Debug.Log("Tiene 3 vidas");

    }
    private void Update()
    {	
		MovimientoJugador();
		Animacion();
       /// if (Input.GetKeyDown(KeyCode.J))
      ///  {
		///	Shoot();
        ///}
    }


	/// private void Shoot()
	
	///	Instantiate(objetoAInstanciar, lugar.position, transform.rotation);
	

	void MovimientoJugador()
    {
		float movX = Input.GetAxis("Horizontal");
		float movY = Input.GetAxis("Vertical");
		float mouseX = Input.GetAxis("Mouse X") * 500 * Time.deltaTime;
		Vector3 inputJugador = new Vector3(movX, 0, movY);
		transform.Translate(inputJugador * vel * Time.deltaTime);

		transform.Rotate(0f, mouseX, 0f, Space.Self);
    }

	private void Animacion()
    {

		bool apreteAdelante = Input.GetKey("w");

		if (apreteAdelante && vel < 5.0f)
		{
			vel += Time.deltaTime * acceleration;
		}
		if (!apreteAdelante && vel > 0.0f)
		{
			vel = 0.0f;
		}
		anim.SetFloat("velocidad", vel);
	}

	
}


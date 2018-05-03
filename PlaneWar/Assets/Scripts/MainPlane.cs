using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlane : MonoBehaviour {
    private float speed = 2.5f;
    private int hp = 100;
    private Vector3 direction;
    private float maxX;
    private float minX;
    private float maxY;
    private float minY;
    private Weapon weapon;

    private void Awake()
    {
        weapon = GetComponent<Weapon>();
    }
    void Start () {
        maxX = ScreenXY.MaxX;
        minX = ScreenXY.MinX;
        maxY = ScreenXY.MaxY;
        minY = ScreenXY.MinY;
    }
	
	void Update () {

        direction = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Move(direction);
        ClampFrame();
    }

    public void Move(Vector3 direction)
    {
        transform.position += direction * speed * Time.deltaTime;
    }
    private void ClampFrame()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);
    }
    public void FireOnce()
    {
        weapon.FireOnce();
    }
    public void FireStart()
    {
        weapon.FireStart();
    }
}

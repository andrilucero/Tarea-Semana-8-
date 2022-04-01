using camion_moto_camioneta.Clases;


static void imprimir(Camion A, Camion B)
{
    Console.WriteLine($"{A.owner}={A.GetVelocidadActual()} ===  {B.owner}={B.GetVelocidadActual()} ");
}


Camion cam = new Camion("GMC", 150, "Adiel Navas");
string mensajes;
cam.EncenderMotor();
mensajes = cam.acelerar();
Console.WriteLine(mensajes);
mensajes = cam.acelerar(50);
cam.Bocina();
Console.WriteLine(mensajes);
cam.soltarfulgon();
Console.WriteLine(mensajes);
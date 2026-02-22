//Clasificación de incidente de seguridad informática



Console.WriteLine("Clasificacion  de incidente de seguridad");
Console.WriteLine("tipo de incidente");
Console.WriteLine("1 Malware");
Console.WriteLine("2 Phishing");
Console.WriteLine("3 acceso no autorizado");
Console.WriteLine("4 fuga de informacion");
int tipoIncidente = int.Parse(Console.ReadLine());
Console.WriteLine("activo afectado");
Console.WriteLine("1 pc");
Console.WriteLine("2 servidor");
Console.WriteLine("3 base de datos");
Console.WriteLine("4 red");
int activo = int.Parse(Console.ReadLine());
Console.WriteLine("Datos comprometidos");
Console.WriteLine("1 ninguno");
Console.WriteLine("2 internos");
Console.WriteLine("3 personales");
Console.WriteLine("4 Financieros");
int datos = int.Parse(Console.ReadLine());
Console.WriteLine("numero de usuarios afectados");
int usuarios = int.Parse(Console.ReadLine());
string descripcionIncidente = "";
string descripcionActivo = "";
string severidad = "baja";
string respuesta = "";
string persistencia = "";
switch (tipoIncidente)
{
	case 1:
		descripcionIncidente = "malware";
		break;
	case 2:
		descripcionIncidente = "phishing";
		break;
	case 3:
		descripcionIncidente = "acceso no autorizado";
		break;
	case 4:
		descripcionIncidente = "fuga de informacion";
		break;
	default:
		descripcionIncidente = "desconocido";
		break;
}
switch (activo)
{
	case 1:
		descripcionActivo = "pc";
		break;
	case 2:
		descripcionActivo = "servidor";
		break;
	case 3:
		descripcionActivo = "base de datos";
		break;
	case 4:
		descripcionActivo = "red";
		break;
	default:
		descripcionActivo = "desconocido";
		break;
}
if (usuarios <= 0)
{
	Console.WriteLine("numero de ussuario invalido");
	return;
}
if (datos == 4)
{
	severidad = "critica";
}
else
{
	if (tipoIncidente == 4 && datos >= 3)
	{
		severidad = "critica";
	}
	else
	{
		if (activo == 2 && persistencia == "si")


		{
			severidad = "alta";
		}
		else
		{
			if (usuarios > 50)
			{
				severidad = "media";
			}
			else
			{
				severidad = "baja";
			}
		}
	}
	if (severidad == "critica")
		respuesta = "aislar sistema,notificar direccion y activar plan de respuestas inmediata";
	else if (severidad == "alta")
		respuesta = "contener incidente y realizar analisis forence";
	else if (severidad == "media")
		respuesta = "monitorear y aplicar medidas correctivas";
	else
		respuesta = "registrar incidente y seguimiento basico";

}

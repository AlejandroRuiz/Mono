using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;

namespace AndroidNotification
{
	//Agregamos el atributo [Service] para especificar que la clase sera del tipo servicio
	//Service Implenetaremos la clase del tipo servicio para que pueda usar metodos de esta clase padre
	//al igual usaremos View.IOnTouchListener para poder implementar los metodos de interaccion tocuh del usuario
	[Service]
	public class ChatHeadService : Service, View.IOnTouchListener
	{
		//Usaremos estas variables para manejar la posicion del objeto sobre la ventana
		private int initialX;
		private int initialY;
		private float initialTouchX;
		private float initialTouchY;

		//crearemos una variable del tipo IWindowManager como manejador pricipal de la pantall
		private IWindowManager windowManager;
		//crearemos una simple imagen la cual mostraremos sobre la ventana
		private ImageView chatHead;
		//Crearemos una variable del tipo WindowManagerLayoutParams que contendra los parametros necesarios para poder
		//presentar la imagen de manera correcta sobre la pantalla
		WindowManagerLayoutParams param = null;
		//metodo para hacer Bind al servicio el cual no usaremos en este ejemplo
		public override IBinder OnBind (Intent intent)
		{
			return null;
		}
		//Metodo principal en el cual se creara el servicio y pintaremos nuestro imageview sobre la ventana
		public override void OnCreate ()
		{
			base.OnCreate ();
			//incializaremos en windowmanager obteniendo el servicio directo de la ventan del sistema y haremos
			//un casting de tipo JavaCast<IWindowManager>
			windowManager = GetSystemService ("window").JavaCast<IWindowManager> ();
			//inicializaremos nuestro imageview dandole los atributos de nuestra clase para que obtenga los metodos
			//de touch
			chatHead = new ImageView(this);
			//definimos la imagen del imageview
			chatHead.SetImageResource (Resource.Drawable.ic_launcher);
			//Asignamos el listener del touch nuestra clase del tipo View.IOnTouchListener
			chatHead.SetOnTouchListener (this);
			//instanciamos los parametros que necesitamos para poder tomar la pantalla y asi poder mostrar nuestro imageview
			param = new WindowManagerLayoutParams(
				WindowManagerLayoutParams.WrapContent,
				WindowManagerLayoutParams.WrapContent,
				WindowManagerTypes.Phone,
				WindowManagerFlags.NotFocusable,
				Format.Translucent);
			//Agregamos la propiedad de gravedad en la parte de arriba hacia la izquieda
			param.Gravity = GravityFlags.Top | GravityFlags.Left;
			//Asignamos la posicion X del imageview
			param.X = 0;
			//Asignamos la posicion Y del imageview
			param.Y = 100;
			//Agregamos una vista a la ventana del sistema con nuestro imageview y los parametros generados
			windowManager.AddView (chatHead, param);
		}
		//Metodo para destruir la imagen
		public override void OnDestroy ()
		{
			base.OnDestroy ();
			if (chatHead != null) windowManager.RemoveView(chatHead);
		}
		//Metodo hijo del tipo View.IOnTouchListener para manejar el tocuh sobre la imagen
		public bool OnTouch(View v, MotionEvent e)
		{
			//Mediante este switch verificamos el tipo de accion
			switch (e.Action) {
			//Case tipo down de la imagen
			case MotionEventActions.Down:
				initialX = param.X;
				initialY = param.Y;
				initialTouchX = e.RawX;
				initialTouchY = e.RawY;
				return true;
			//Case tipo Up de la iamgen
			case MotionEventActions.Up:
				return true;
			//Case tipo Move de la imagen
			case MotionEventActions.Move:
				param.X = initialX + (int) (e.RawX - initialTouchX);
				param.Y = initialY + (int) (e.RawY - initialTouchY);
				windowManager.UpdateViewLayout(chatHead, param);
				return true;
			}
			return false;
		}
	}
}
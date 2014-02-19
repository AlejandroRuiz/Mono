using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Calc.Core;

namespace Calc.Droid
{
    [Activity(Label = "Calc.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        Button bSum, bRes, bMul, bDiv;
        EditText nUno, nDos;
        TextView tRes;
        Calculadora c = new Calculadora();
        public void Asignacion()
        {
            bSum = FindViewById<Button>(Resource.Id.btnSum);
            bRes = FindViewById<Button>(Resource.Id.btnRes);
            bMul = FindViewById<Button>(Resource.Id.btnMul);
            bDiv = FindViewById<Button>(Resource.Id.btnDiv);
            nUno = FindViewById<EditText>(Resource.Id.txtNumero1);
            nDos = FindViewById<EditText>(Resource.Id.txtNumero2);
            tRes = FindViewById<TextView>(Resource.Id.lblRes);
        }

        public void Eventos()
        {
            bSum.Click += (a,e) => {
                try
                {
                    c.Numero1 = Convert.ToDouble(nUno.Text);
                    c.Numero2 = Convert.ToDouble(nDos.Text);
                    tRes.Text = c.Suma().ToString();
                }
                catch (Exception ex) { tRes.Text = ex.Message; }
            };
            bRes.Click += (a, e) => {
                try
                {
                    c.Numero1 = Convert.ToDouble(nUno.Text);
                    c.Numero2 = Convert.ToDouble(nDos.Text);
                    tRes.Text = c.Resta().ToString();
                }
                catch (Exception ex) { tRes.Text = ex.Message; }
            };
            bMul.Click += (a, e) => {
                try
                {
                    c.Numero1 = Convert.ToDouble(nUno.Text);
                    c.Numero2 = Convert.ToDouble(nDos.Text);
                    tRes.Text = c.Multiplicacion().ToString();
                }
                catch (Exception ex) { tRes.Text = ex.Message; }
            };
            bDiv.Click += (a,e) =>{
                try
                {
                    c.Numero1 = Convert.ToDouble(nUno.Text);
                    c.Numero2 = Convert.ToDouble(nDos.Text);
                    tRes.Text = c.Division().ToString();
                }
                catch (Exception ex) { tRes.Text = ex.Message; }
            };
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Asignacion();
            Eventos();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hackaton.App.Frontend.Pages
{
    public class calentamientoModel : PageModel
    {
        public double masa{get;set;}
        public double altura{get;set;}
        public double imc{get;set;}
        public string mensaje{get;set;}
        public IActionResult OnGet()
        {
            altura = altura;
            masa = masa; 
            return Page();
        }

        public IActionResult OnPost(){
            if(altura!= 0){
                imc = masa/Math.Pow(altura,2);
                if(imc < 16){
                    mensaje = "delgadez severa";
                }else if (imc>= 16 && imc <=16.99){
                    mensaje = "delgadez moderda";
                }else if (imc>= 17 && imc <18.49){
                    mensaje = "delgadez aceptable";
                }else if (imc>= 18.5 && imc <24.99){
                    mensaje = "peso normal";
                }else if (imc>= 25 && imc <29.99){
                    mensaje = "sobrepeso";
                }else if (imc>= 30 && imc <34.99){
                    mensaje = "obesidad tipo I";
                }else if (imc>= 35 && imc <39.99){
                    mensaje = "obesidad tipo II";
                }else if (imc>= 40 && imc <49.99){
                    mensaje = "obesidad tipo III o morbida";
                }else if (imc>=50){
                    mensaje = "obesidad tipo IV o extrema";
                }
                Console.WriteLine("el imc calculado es: "+ imc + mensaje);

            }else{
                mensaje= "Altura incorrecta ingrese un número diferete de 0 ";
            }
            return Page();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
    {
        public class CajasDinamicasController : Controller
        {
            
            public ActionResult CajasDinamicas(int? numInputs)
            {
               
                if (numInputs.HasValue && numInputs.Value > 0)
                {
                   
                    List<string> inputs = new List<string>();

                   
                    for (int i = 0; i < numInputs.Value; i++)
                    {
                        inputs.Add($"<br><input type='text' name='input{i + 1}' class='form-control' />");
                    }

                    
                    ViewBag.Inputs = inputs;
                }
                else
                {
                     ViewBag.Inputs = null;
                }

                   ViewBag.NumInputs = numInputs;
                  return View();
            }

            [HttpPost, ActionName("Calculos")]
            public ActionResult CalculosPost(FormCollection form)
            {
                var numeros = new List<int>();

                
                foreach (var key in form.Keys)
                {
                   
                    if (key.ToString().StartsWith("input"))
                    {
                        int numero;

                      
                        if (int.TryParse(form[key.ToString()], out numero))
                        {
                           
                            numeros.Add(numero);
                        }
                    }
                }

                  int sumaTotal = numeros.Sum();
                ViewBag.SumaTotal = sumaTotal;

               Dictionary<int, int> contador = new Dictionary<int, int>();
                List<int> numerosRepetidos = new List<int>();

                foreach (int numero in numeros)
                {
                     if (contador.ContainsKey(numero))
                    {
                        contador[numero]++;
                        if (!numerosRepetidos.Contains(numero))
                        {
                            numerosRepetidos.Add(numero);
                        }
                    }
                    else
                    {
                          contador[numero] = 1;
                    }
                }

                ViewBag.NumerosRepetidos = numerosRepetidos;

                return View();
            }
        }
    }
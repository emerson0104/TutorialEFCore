using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TutorialEntityFrameworkCore.Models;

namespace TutorialEntityFrameworkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int Op = 0;
            string x = string.Empty;
            do
            {
                Console.WriteLine("------------1- Guardar en la Base de Datos.");
                Console.WriteLine("------------2-  un simple Query.");
                Console.WriteLine("------------3- un doble Query.");
                Console.WriteLine("------------4- Hacer un query usando SQL.");
                Console.WriteLine("------------5- Actualizar data de una entidad.");
                Console.WriteLine("------------6- Borrar datos de una entidad.");
                Console.WriteLine("------------7- Actualizar entidad usando Range en un escenario desconectado.");
                Console.WriteLine("------------8- Salir");
                Console.WriteLine("---------------------OPCION:");
                x = Console.ReadLine();
                Op = Convertir(x);

            } while (Op != 8);
            switch (Op)
            {
                case 1:
                    Ejemplos.GuardarCurso();
                    Console.ReadKey();
                    break;
                case 2:
                    Ejemplos.SimpleQueryDB(); 
                    Console.ReadKey();
                    break;
                case 3:
                    Ejemplos.DoubleQueryDB(); 
                    Console.ReadKey();
                    break;
                case 4:
                    Ejemplos.QuerryUsingSql();
                    Console.ReadKey();
                    break;
                case 5:
                    Ejemplos.UpdatingData(); 
                    Console.ReadKey();
                    break;
                case 6:
                    Ejemplos.DeletingData(); 
                    Console.ReadKey();
                    break;
                case 7:
                    Ejemplos.UpdatingOnDisconnectedScenario(); 
                    Console.ReadKey();
                    break;
                case 8:
                    break;
            }
        }
        
        private static int Convertir(string x)
        {
            int opcion = 0;
            try
            {
                opcion = Convert.ToInt32(x);
                return opcion;
            }
            catch (Exception)
            {

                Console.WriteLine("Solo Se recibe Un numero");
            }
            return opcion;
        }
    }
    }

